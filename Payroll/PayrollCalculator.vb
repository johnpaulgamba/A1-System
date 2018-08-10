Imports MySql.Data.MySqlClient
Public Class PayrollCalculator
    Public toedit As Boolean
    Public tosave As Boolean = True
    Public payrollid As Integer = 0
    Public payrollperiodid As Integer = 0
    Public employeeid As Integer = 0
    Public companyidx As Integer = 0
    Public paygroup As String = 0
    Public chargetocompany As Boolean = False
    Public payrolldate1 As DateTime
    Public lastrow As Integer = 1
    Public sssee1, hdmfee1, phicee1, wtax1, hdmfloan1, sssloan1, vale1, gross2, semirate, hourlyrate, hiddenrate, legalexemption, Exempt, TaxableTotal, mandatoryx, basic13, voucher13 As Double
    Public deductsss, deductphic, deducthmdf, deductwtax As Boolean
    Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        Me.C1DockingTab1.SelectedIndex = 0
        loadingvaluestoComboBoxes_StoredProc("combo_department_ActiveOnly", Department, "department", "departmentid")
        RibbonTrackBar1_ValueChanged()
        ' Add any initialization after the InitializeComponent() call.
    End Sub


    Private Sub PayrollCalculator_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FunctionClass.loadtoGrid("Select Employeeid, Employeeno, concat(lastname,', ',Firstname,' ', left(MiddleName,1),'.') as Employee from hris_employee where companyid='" & companyidx & "' and payrollgroup='" & paygroup & "' and active=1 order by lastname, firstname asc", C1FlexGrid2)
        loadpayrollinfo()
        verifyifrecordexists()
        C1FlexGrid2_Click()
        Timer1.Start()
    End Sub
    Public Sub loadpayrollinfo()
        connect()
        con.Open()

        command = New MySqlCommand
        With command
            .CommandText = "select * from payroll_period where payrollperiodid='" & payrollperiodid & "'"
            .Connection = con
            reader = command.ExecuteReader
        End With
        If reader.Read = True Then
            With reader
                Dim payid As Integer = .Item("payrollperiodid")
                Me.PayrollCode.Text = payid.ToString("d10")
                Me.PayrollName.Text = .Item("payrollname")
                Me.PayrollDetails.Text = Format(.Item("payrolldate"), "[MM.dd.yyyy]") & " PAYROLL | " & .Item("payrollgroup")
                Me.payrolldate1 = .Item("payrolldate")
            End With
        End If
        Me.GetPayrollSummary()
    End Sub
#Region "Ribbon Controls"
    Public Sub RibbonTrackBar1_ValueChanged() Handles FontName.TextChanged, FontSize.ValueChanged
        Try
            MainLauncher(0)
            Me.C1InputPanel2.Font = New Font("Tahoma", Me.FontSize.Value + 1, FontStyle.Regular)
            Me.C1InputPanel1.Font = New Font("Tahoma", Me.FontSize.Value + 1, FontStyle.Regular)
            Me.C1InputPanel3.Font = New Font("Tahoma", Me.FontSize.Value + 1, FontStyle.Regular)
            Me.C1InputPanel7.Font = New Font("Tahoma", Me.FontSize.Value + 1, FontStyle.Regular)
            Me.C1DockingTab1.Font = New Font("Tahoma", Me.FontSize.Value + 1, FontStyle.Regular)
            With Me.PaySetUpGrid
                .Font = New Font(Me.FontName.Text, Me.FontSize.Value)
                .Rows(0).StyleDisplay.Font = New Font("Tahoma", Me.FontSize.Value + 1, FontStyle.Bold)
                .AutoSizeCols()
            End With

            With Me.C1FlexGrid2
                .Font = New Font(Me.FontName.Text, Me.FontSize.Value)
                .Rows(0).StyleDisplay.Font = New Font("Tahoma", Me.FontSize.Value + 1, FontStyle.Bold)
                .AutoSizeCols()
            End With
            MainLauncher(1)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub RibbonButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RibbonButton5.Click
        If Me.FontSize.Value <= 1 Then Exit Sub
        Me.FontSize.Value = Me.FontSize.Value - 1
    End Sub

    Private Sub RibbonButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RibbonButton3.Click
        Me.FontSize.Value = Me.FontSize.Value + 1
    End Sub


    Private Sub C1Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1Button2.Click
        Me.C1SplitterPanel2.Visible = Not Me.C1SplitterPanel2.Visible : If Me.C1SplitterPanel2.Visible = True Then Me.C1Button1.BackgroundImage = My.Resources.left Else Me.C1Button1.BackgroundImage = My.Resources.right
    End Sub
#End Region

    'CLICK EMPLOYEE GRID TO LOAD EMPLOYEE INFO
    Public Sub C1FlexGrid2_Click() Handles C1FlexGrid2.Click
        Try
            Timer1.Start()
            Dim i As Integer = Me.C1FlexGrid2.RowSel
            If Me.C1FlexGrid2.Item(lastrow, "OK") = False And toedit = True Then
                Dim response As String = MessageBox.Show("Are you sure you want to move to another employee without saving the computation?", "Computation is not yet saved.", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If response = vbYes Then
                    Me.ResetComputation.Enabled = False
                    tosave = True
                    loademployeepayrollinfo("Select * from hris_employee  where employeeid='" & Me.C1FlexGrid2.Item(i, "EmployeeID") & "'")
                    lastrow = Me.C1FlexGrid2.RowSel
                Else
                    Exit Sub
                End If
            Else
                If Me.C1FlexGrid2.Item(i, "OK") = True Then
                    tosave = False
                    Me.ResetComputation.Enabled = True
                    loademployeepayrollinfo("Select a.*,b.* from hris_employee a join payroll_register b on a.employeeid=b.employeeid where a.employeeid='" & Me.C1FlexGrid2.Item(i, "EmployeeID") & "' and payrollperiodid='" & Me.payrollperiodid & "'")
                    lastrow = Me.C1FlexGrid2.RowSel
                Else
                    Me.ResetComputation.Enabled = False
                    tosave = True
                    loademployeepayrollinfo("Select * from hris_employee  where employeeid='" & Me.C1FlexGrid2.Item(i, "EmployeeID") & "'")
                    lastrow = Me.C1FlexGrid2.RowSel
                End If
            End If
            Me.EmployeeNo.Text = Me.C1FlexGrid2.Item(i, "EmployeeNo")
        Catch ex As Exception

        End Try
    End Sub
    Public Sub loademployeepayrollinfo(ByVal a As String)
        connect()
        con.Open()
        Try
            command = New MySqlCommand
            With command
                .CommandText = a
                .Connection = con
                reader = .ExecuteReader
            End With
            If reader.Read = True Then
                With reader
                    employeeid = reader.Item("employeeid")
                    Me.EmployeeNo.Text = .Item("employeeno")
                    Me.MonthlyPay.Value = .Item("BasicSalary")
                    Me.semirate = .Item("BasicSalary") / 2
                    Me.HourlyPay.Value = .Item("BasicPayhour")
                    hourlyrate = .Item("BasicPayhour")
                    Me.TotalMonthlyPay.Value = .Item("BasicSalary") + .Item("hiddenAllowance")
                    Me.HiddenAllowance.Value = .Item("hiddenAllowance")
                    Me.hiddenrate = .Item("hiddenratehour")
                    Me.HiddenAllowanceRate.Value = .Item("hiddenratehour")
                    Me.legalexemption = .Item("legalallowance")
                    Me.PayrollGroup.Text = .Item("PayrollGroup")
                    Me.PayMethod.Text = .Item("paymentmethod")
                    Me.EmployeeName.Text = .Item("Lastname") & ", " & .Item("FirstName") & " " & .Item("MiddleName")
                    Me.Department.SelectedValue = .Item("departmentid")
                    Me.position.Text = .Item("Position")
                    Me.deducthmdf = .Item("deducthdmf")
                    Me.deductphic = .Item("deductphic")
                    Me.deductsss = .Item("deductsss")
                    Me.deductwtax = .Item("deducttax")
                    Me.chargetocompany = .Item("chargetocompany")
                    Me.charge.Checked = .Item("chargetocompany")
                    Me.companyidx = .Item("companyid")


                    If tosave = True Then
                        Me.PayReference.Text = Nothing
                        Me.payrollid = 0
                        If Me.PayrollGroup.Text = "WEEKLY" Then
                            FunctionClass.loadtoGrid("Select  b.PayID,  b.PayType, b.Amount, b.PayRate, b.Compute,b.Amount,b.Government,b.hidden, b.hiddenamount,b.Income,b.Deduction,`13th`, b.tax,b.Remarks from  companypayrollsetup b where b.active=1 and b.weekly=1 and b.companyid='" & companyidx & "' group by b.payid order by `order` asc", PaySetUpGrid)
                            If Me.PaySetUpGrid.Rows.Count = 1 Then
                                FunctionClass.loadtoGrid("Select  b.PayID,  b.PayType, b.Amount, b.PayRate, b.Compute,b.Amount,b.Government,b.hidden, b.hiddenamount,b.Income,b.Deduction,`13th`, b.tax, b.Remarks from  companypayrollsetup b where b.active=1 and b.weekly=1  group by b.payid order by `order` asc", PaySetUpGrid)
                            End If
                        ElseIf Me.PayrollGroup.Text = "SEMI-MONTHLY" Then
                            FunctionClass.loadtoGrid("Select  b.PayID,  b.PayType, b.Amount, b.PayRate, b.Compute,b.Amount,b.Government,b.hidden, b.hiddenamount,b.Income,b.Deduction,`13th`, b.tax,b.Remarks from  companypayrollsetup b where b.active=1 and b.semimonthly=1 and b.companyid='" & companyidx & "' group by b.payid order by `order` asc", PaySetUpGrid)

                            If Me.PaySetUpGrid.Rows.Count = 1 Then
                                FunctionClass.loadtoGrid("Select  b.PayID,  b.PayType, b.Amount, b.PayRate, b.Compute,b.Amount,b.Government,b.hidden, b.hiddenamount,b.Income,b.Deduction,`13th`, b.tax, b.Remarks from  companypayrollsetup b where b.active=1 and b.semimonthly=1  group by b.payid order by `order` asc", PaySetUpGrid)
                            End If
                        ElseIf Me.PayrollGroup.Text = "MONTHLY" Then
                            FunctionClass.loadtoGrid("Select  b.PayID,  b.PayType, b.Amount, b.PayRate, b.Compute,b.Amount,b.Government,b.hidden, b.hiddenamount,b.Income,b.Deduction,`13th`, b.tax, b.Remarks from  companypayrollsetup b where b.active=1 and b.semimonthly=1 and b.companyid='" & companyidx & "' group by b.payid order by `order` asc", PaySetUpGrid)

                            If Me.PaySetUpGrid.Rows.Count = 1 Then
                                FunctionClass.loadtoGrid("Select  b.PayID,  b.PayType, b.Amount, b.PayRate, b.Compute,b.Amount,b.Government,b.hidden, b.hiddenamount,b.Income,b.Deduction,`13th`, b.tax, b.Remarks from  companypayrollsetup b where b.active=1 and b.semimonthly=1  group by b.payid order by `order` asc", PaySetUpGrid)
                            End If
                        End If

                        LoadGovernmentDeductions()
                        UnloadLoadGovernmentDeductions()
                        calculategrid()
                    Else
                        Me.payrollid = .Item("payrollid")
                        Me.PayReference.Text = payrollid.ToString("d10")
                        If Me.PayrollGroup.Text = "WEEKLY" Then
                            FunctionClass.loadtoGrid("Select  b.PayID,  b.PayType, a.Value, b.PayRate, b.Compute,a.Amount,b.Government,b.hidden, a.hiddenamount,b.Income,b.Deduction, `13th`, b.tax,b.Remarks from  companypayrollsetup b left join payroll_register_detail a on a.payid=b.payid Where a.EmployeeID='" & employeeid & "' and b.active=1 and b.weekly=1  and a.payrollperiodid = '" & payrollperiodid & "' and b.companyid='" & companyidx & "' group by a.payid order by `order` asc", PaySetUpGrid)
                            If Me.PaySetUpGrid.Rows.Count = 1 Then
                                FunctionClass.loadtoGrid("Select  b.PayID,  b.PayType, a.Value, b.PayRate, b.Compute,b.Amount,b.Government,b.hidden, a.hiddenamount,b.Income,b.Deduction,`13th`, b.tax, b.Remarks from  companypayrollsetup b left join payroll_register_detail a on a.payid=b.payid Where a.EmployeeID='" & employeeid & "' and b.active=1 and b.weekly=1 and a.payrollperiodid = '" & payrollperiodid & "'  group by a.payid order by `order` asc", PaySetUpGrid)
                            End If
                        ElseIf Me.PayrollGroup.Text = "SEMI-MONTHLY" Then
                            FunctionClass.loadtoGrid("Select  b.PayID,  b.PayType, a.Value, b.PayRate,  b.Compute,b.Amount,b.Government,b.hidden, a.hiddenamount,b.Income,b.Deduction, `13th`,b.Remarks from  companypayrollsetup b left join payroll_register_detail a on a.payid=b.payid Where a.EmployeeID='" & employeeid & "' and b.active=1 and b.semimonthly=1 and a.payrollperiodid = '" & payrollperiodid & "' and b.companyid='" & companyidx & "' group by a.payid order by `order` asc", PaySetUpGrid)
                            If Me.PaySetUpGrid.Rows.Count = 1 Then
                                FunctionClass.loadtoGrid("Select  b.PayID,  b.PayType, a.Value, b.PayRate, b.Compute,b.Amount,b.Government,b.hidden, a.hiddenamount,b.Income,b.Deduction,`13th`, b.tax, b.Remarks from  companypayrollsetup b left join payroll_register_detail a on a.payid=b.payid Where a.EmployeeID='" & employeeid & "' and b.active=1 and b.semimonthly=1 and a.payrollperiodid = '" & payrollperiodid & "'  group by a.payid order by `order` asc", PaySetUpGrid)
                            End If
                        ElseIf Me.PayrollGroup.Text = "MONTHLY" Then
                            FunctionClass.loadtoGrid("Select  b.PayID,  b.PayType, a.Value, b.PayRate, b.Compute,b.Amount,b.Government,b.hidden, a.hiddenamount,b.Income,b.Deduction,`13th`, b.tax, b.Remarks from  companypayrollsetup b left join payroll_register_detail a on a.payid=b.payid Where a.EmployeeID='" & employeeid & "' and b.active=1 and b.semimonthly=1 and a.payrollperiodid = '" & payrollperiodid & "' and b.companyid='" & companyidx & "' group by a.payid order by `order` asc", PaySetUpGrid)
                            If Me.PaySetUpGrid.Rows.Count = 1 Then
                                FunctionClass.loadtoGrid("Select  b.PayID,  b.PayType, a.Value, b.PayRate,  b.Compute,b.Amount,b.Government,b.hidden, a.hiddenamount,b.Income,b.Deduction,`13th`, b.tax, b.Remarks from  companypayrollsetup b left join payroll_register_detail a on a.payid=b.payid Where a.EmployeeID='" & employeeid & "' and b.active=1 and b.semimonthly=1 and a.payrollperiodid = '" & payrollperiodid & "'  group by a.payid order by `order` asc", PaySetUpGrid)
                            End If
                        End If
                        calculategrid()
                    End If
                End With
            End If
            reader.Close()
            command.Dispose()
            con.Close()
            toedit = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub ResetComputation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetComputation.Click

        Me.payrollid = 0
        If Me.PayrollGroup.Text = "WEEKLY" Then
            FunctionClass.loadtoGrid("Select  b.PayID,  b.PayType, b.Amount, b.PayRate, b.Compute,b.Amount,b.Government,b.hidden, b.hiddenamount,b.Income,b.Deduction,`13th`, b.tax,b.Remarks from  companypayrollsetup b where b.active=1 and b.weekly=1 and b.companyid='" & companyidx & "' group by b.payid order by `order` asc", PaySetUpGrid)
            If Me.PaySetUpGrid.Rows.Count = 1 Then
                FunctionClass.loadtoGrid("Select  b.PayID,  b.PayType, b.Amount, b.PayRate, b.Compute,b.Amount,b.Government,b.hidden, b.hiddenamount,b.Income,b.Deduction,`13th`, b.tax, b.Remarks from  companypayrollsetup b where b.active=1 and b.weekly=1  group by b.payid order by `order` asc", PaySetUpGrid)
            End If
        ElseIf Me.PayrollGroup.Text = "SEMI-MONTHLY" Then
            FunctionClass.loadtoGrid("Select  b.PayID,  b.PayType, b.Amount, b.PayRate, b.Compute,b.Amount,b.Government,b.hidden, b.hiddenamount,b.Income,b.Deduction,`13th`, b.tax,b.Remarks from  companypayrollsetup b where b.active=1 and b.semimonthly=1 and b.companyid='" & companyidx & "' group by b.payid order by `order` asc", PaySetUpGrid)

            If Me.PaySetUpGrid.Rows.Count = 1 Then
                FunctionClass.loadtoGrid("Select  b.PayID,  b.PayType, b.Amount, b.PayRate, b.Compute,b.Amount,b.Government,b.hidden, b.hiddenamount,b.Income,b.Deduction,`13th`, b.tax, b.Remarks from  companypayrollsetup b where b.active=1 and b.semimonthly=1  group by b.payid order by `order` asc", PaySetUpGrid)
            End If
        ElseIf Me.PayrollGroup.Text = "MONTHLY" Then
            FunctionClass.loadtoGrid("Select  b.PayID,  b.PayType, b.Amount, b.PayRate, b.Compute,b.Amount,b.Government,b.hidden, b.hiddenamount,b.Income,b.Deduction,`13th`, b.tax, b.Remarks from  companypayrollsetup b where b.active=1 and b.semimonthly=1 and b.companyid='" & companyidx & "' group by b.payid order by `order` asc", PaySetUpGrid)

            If Me.PaySetUpGrid.Rows.Count = 1 Then
                FunctionClass.loadtoGrid("Select  b.PayID,  b.PayType, b.Amount, b.PayRate, b.Compute,b.Amount,b.Government,b.hidden, b.hiddenamount,b.Income,b.Deduction,`13th`, b.tax, b.Remarks from  companypayrollsetup b where b.active=1 and b.semimonthly=1  group by b.payid order by `order` asc", PaySetUpGrid)
            End If
        End If

        LoadGovernmentDeductions()
        UnloadLoadGovernmentDeductions()
        calculategrid()
        tosave = False

    End Sub
    Private Sub PaySetUpGrid_AfterEdit(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) Handles PaySetUpGrid.AfterEdit
        calculategrid()
    End Sub

    Public Sub LoadGovernmentDeductions()
        Try
            Dim x As Integer = 1
            Dim y As Integer = PaySetUpGrid.Rows.Count - 1
            For x = 1 To y
                With PaySetUpGrid.Rows(x)
                    Select Case .Item("paytype")
                        Case "SSS"
                            If deductsss = False Then .Item("value") = 0 Else .Item("value") = FunctionClass.GetSSSEE(Me.employeeid)
                        Case "PHIC"
                            If deductphic = False Then .Item("value") = 0 Else .Item("value") = FunctionClass.GetPHICEE(Me.employeeid)
                        Case "HDMF"
                            If deducthmdf = False Then .Item("value") = 0 Else .Item("value") = FunctionClass.GetHDMFEE(Me.employeeid)
                        Case "WTAX"
                            If deductwtax = False Then .Item("value") = 0 Else .Item("value") = FunctionClass.GetWTAX1(Me.employeeid)
                        Case "COLA"
                            .Item("value") = FunctionClass.GetCOLA(Me.employeeid)
                    End Select

                    If PayrollGroup.Text = "SEMI-MONTHLY" Then
                        If .Item("Paytype") = "BASIC SALARY" Then .Item("value") = Me.semirate : .Item("hiddenamount") = Me.HiddenAllowance.Value / 2
                        Me.Exempt = legalexemption / 2
                    ElseIf PayrollGroup.Text = "MONTHLY" Then
                        If .Item("Paytype") = "BASIC SALARY" Then .Item("value") = Me.MonthlyPay.Value : .Item("hiddenamount") = Me.HiddenAllowance.Value
                    End If
                    If chargetocompany = True Then
                        If .Item("Paytype") = "WTAX" Then .Item("deduction") = False
                    End If

                End With
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub UnloadLoadGovernmentDeductions()
        Try
            Dim s1, h1, p1, sl1, hl1, vl1, w1 As Integer
            s1 = 0 : h1 = 0 : p1 = 0 : sl1 = 0 : hl1 = 0 : vl1 = 0 : w1 = 0
            Dim x As Integer = 1
            Dim y As Integer = PaySetUpGrid.Rows.Count - 1
            For x = 1 To y
                With PaySetUpGrid.Rows(x)
                    If .Item("Paytype") = "SSS LOAN" Then sl1 = x
                    If .Item("Paytype") = "HDMF LOAN" Then hl1 = x
                    If .Item("Paytype") = "VALE" Then vl1 = x
                    If .Item("Paytype") = "SSS" Then s1 = x
                    If .Item("Paytype") = "PHIC" Then p1 = x
                    If .Item("Paytype") = "HDMF" Then h1 = x
                    If .Item("Paytype") = "WTAX" Then w1 = x
                End With
            Next
            If paygroup = "WEEKLY" Then
                Select Case GetWeekInMonth(payrolldate1)
                    Case 4
                        'WEEKLY PAYROLL 3RD DAY OF THE WEEK FOR GOVERNMENT REMITTANCE
                        : Me.PaySetUpGrid.Rows.Remove(hl1) : Me.PaySetUpGrid.Rows.Remove(sl1) : Me.PaySetUpGrid.Rows.Remove(w1)
                    Case 3
                        'WEEKLY PAYROLL 2ND DAY OF THE MONTH FOR GOVERNMENT REMITTANCE
                        Me.PaySetUpGrid.Rows.Remove(w1) : Me.PaySetUpGrid.Rows.Remove(h1) : Me.PaySetUpGrid.Rows.Remove(p1) : Me.PaySetUpGrid.Rows.Remove(s1)
                    Case Else
                        If Me.PaySetUpGrid.Rows.Count <> 1 Then
                            Me.PaySetUpGrid.Rows.Remove(hl1) : Me.PaySetUpGrid.Rows.Remove(sl1)
                            Me.PaySetUpGrid.Rows.Remove(w1) : Me.PaySetUpGrid.Rows.Remove(h1) : Me.PaySetUpGrid.Rows.Remove(p1) : Me.PaySetUpGrid.Rows.Remove(s1)
                        End If
                End Select
            ElseIf paygroup = "SEMI-MONTHLY" Then
                Select Case GetDayValue(payrolldate1)
                    Case 30 Or 31 Or 29 Or 28
                        'WEEKLY PAYROLL 30th DAY OF THE WEEK FOR GOVERNMENT REMITTANCE
                        Me.PaySetUpGrid.Rows.Remove(hl1) : Me.PaySetUpGrid.Rows.Remove(sl1)
                    Case 15
                        'WEEKLY PAYROLL 15th DAY OF THE WEEK FOR GOVERNMENT REMITTANCE
                        Me.PaySetUpGrid.Rows.Remove(h1) : Me.PaySetUpGrid.Rows.Remove(p1) : Me.PaySetUpGrid.Rows.Remove(s1) : Me.PaySetUpGrid.Rows.Remove(w1)
                    Case Else
                        If Me.PaySetUpGrid.Rows.Count <> 1 Then
                            Me.PaySetUpGrid.Rows.Remove(vl1) : Me.PaySetUpGrid.Rows.Remove(hl1) : Me.PaySetUpGrid.Rows.Remove(sl1)
                            Me.PaySetUpGrid.Rows.Remove(w1) : Me.PaySetUpGrid.Rows.Remove(h1) : Me.PaySetUpGrid.Rows.Remove(p1) : Me.PaySetUpGrid.Rows.Remove(s1)
                        End If
                End Select
            ElseIf paygroup = "MONTHLY" Then
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub calculategrid()
        Try
            Dim gross, deduction, thirtheen, hoursworked, taxable, onvoucher, exemption As Double
            gross = 0 : deduction = 0 : thirtheen = 0 : sssloan1 = 0 : hdmfloan1 = 0 : vale1 = 0 : sssee1 = 0
            hdmfee1 = 0 : phicee1 = 0 : taxable = 0 : mandatoryx = 0 : onvoucher = 0 : exemption = 0 : basic13 = 0 : voucher13 = 0

            Dim x As Integer = 1
            Dim y As Integer = PaySetUpGrid.Rows.Count - 1
            For x = 1 To y
                With PaySetUpGrid.Rows(x)

                    If PayrollGroup.Text = "WEEKLY" Then
                        If .Item("Paytype") = "REG.HOURS" Then hoursworked = .Item("value")
                    ElseIf PayrollGroup.Text = "SEMI-MONTHLY" Then
                        If .Item("Paytype") = "BASIC SALARY" Then
                            If .Item("Value") = 0 Then .Item("HiddenAmount") = 0
                        End If
                    ElseIf PayrollGroup.Text = "SEMI-MONTHLY" Then
                        If .Item("Paytype") = "BASIC SALARY" Then
                            If .Item("Value") = 0 Then .Item("HiddenAmount") = 0 Else .Item("hiddenamount") = HiddenAllowance.Value
                        End If
                    End If

                    If chargetocompany = True Then
                        If .Item("Paytype") = "WTAX" Then .Item("deduction") = False
                    End If

                    If .Item("Compute") = True Then
                        .Item("Amount") = .Item("Value") * .Item("Rate") * Me.hourlyrate
                        If .Item("Hidden") = True Then .Item("hiddenamount") = .Item("Value") * .Item("Rate") * Me.hiddenrate

                    Else
                        .Item("Amount") = .Item("Value")
                        If .Item("Paytype") = "COLA" Then
                            .Item("Amount") = (hoursworked / 8) * (.Item("value"))
                        End If
                    End If

                    If .Item("13th") = True Then basic13 = basic13 + .Item("Amount") : voucher13 = voucher13 + .Item("HiddenAmount")
                    If .Item("income") = True Then gross = gross + .Item("Amount")
                    If .Item("deduction") = True Then deduction = deduction + .Item("amount")
                    If .Item("government") = True Then mandatoryx = mandatoryx + .Item("amount")
                    If .Item("hidden") = True Then onvoucher = onvoucher + .Item("hiddenamount")
                    If .Item("tax") = True Then taxable = taxable + .Item("Amount")
                    'If .Item("Paytype") = "WTAX" Then wtax1 = .Item("Amount")

                    'ASSIGN VALUE TO VARIABLES FOR PAYROLL_REGISTER COLUMNS
                    If .Item("Paytype") = "SSS" Then sssee1 = .Item("Amount")
                    If .Item("Paytype") = "PHIC" Then phicee1 = .Item("Amount")
                    If .Item("Paytype") = "HDMF" Then hdmfee1 = .Item("amount")
                    If .Item("Paytype") = "SSS LOAN" Then sssloan1 = .Item("Amount")
                    If .Item("Paytype") = "HDMF LOAN" Then hdmfloan1 = .Item("Amount")
                    If .Item("Paytype") = "VALE" Then vale1 = .Item("Amount")
                    If .Item("Paytype") = "WTAX" Then wtax1 = .Item("Amount")
                End With
            Next

            Me.OnVoucherEarning.Value = onvoucher
            Me.BasicPayEarnings.Value = gross
            Me.NetPay.Value = gross - deduction

            Me.taxableincome.Value = taxable
            Me.TaxableTotal = taxable

            Me.TotalDeduction.Value = deduction
            Me.TotalEarnings.Value = onvoucher + gross
            Me.TakeHome.Value = gross + onvoucher - deduction
            Me.thirtenth.Value = basic13 + voucher13
        Catch ex As Exception
            Me.NetPay.Value = 0
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub verifyifrecordexists()
        Try
            Dim x As Integer = 1
            Dim y As Integer = C1FlexGrid2.Rows.Count - 1
            For x = 1 To y
                With C1FlexGrid2.Rows(x)
                    .Item("ok") = FunctionClass.checkifpayrollexists(payrollperiodid, .Item("employeeid"))
                    If .Item("OK") = True Then
                        .StyleNew.BackColor = Color.LightSalmon
                    End If
                End With
            Next
        Catch ex As Exception
            Me.NetPay.Value = 0
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub GetPayrollSummary()
        Try

            Me.TotalBasicPay.Value = FunctionClass.GetBasicSalaryTotal(Me.payrollperiodid)
            Me.TotalVoucherPay.Value = FunctionClass.GetOnVoucherTotal(Me.payrollperiodid)
            Me.TotalPayroll.Value = Me.TotalBasicPay.Value + Me.TotalVoucherPay.Value

        Catch ex As Exception
            MessageBox.Show(payrollperiodid & " " & ex.Message)

        End Try
    End Sub
    Private Sub PayrollCalculator_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        saveEditDelete("Update payroll_period set Basic='" & Me.TotalBasicPay.Value & "',voucher ='" & TotalVoucherPay.Value & "',total='" & Me.TotalPayroll.Value & "' where payrollperiodid='" & payrollperiodid & "'", "wala")
        PayrollPeriodMainForm.SearchRecords_Click(sender, e)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        timertick()
    End Sub
    Public Sub timertick()
        verifyifrecordexists()
        Timer1.Stop()
    End Sub

    Private Sub SaveCommandButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveJobOrder.Click
        Try
            payrollid = searchRecord("SELECT AUTO_INCREMENT FROM Information_schema.tables where  table_schema='" & database & "' and table_name='payroll_register';", 1)
            savecommand()
            Me.GetPayrollSummary()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub savecommand()
        Try
            If Me.PaySetUpGrid.Rows.Count <= 1 Then
                Exit Sub
            Else
                connect()
                con.Open()
                Dim command As New MySqlCommand
                With command

                    If tosave = False Then
                        .CommandText = "delete from payroll_register_detail where employeeid='" & employeeid & "' and payrollperiodid='" & payrollperiodid & "'"
                        .Connection = con
                        .CommandType = CommandType.Text
                        .ExecuteNonQuery()

                        .CommandText = "Delete from payroll_register where payrollperiodid='" & payrollperiodid & "' and employeeid = '" & employeeid & "'"
                        .Connection = con
                        .CommandType = CommandType.Text
                        .ExecuteNonQuery()
                    End If

                    .CommandText = "Insert into payroll_register(Register_Type,PayrollPeriodID,CompanyID,EmployeeID,Gross,Deduction,NetPay,SSSEE,PHICEE,HDMFEE,WTAX,SSSLoan,HDMFLoan,Vale,Mandatory,TaxableIncome,13thMonthPay,PaymentMethod,PayrollGroup,Creator,DateCreated) values " & _
                    " ('REGULAR','" & payrollperiodid & "','" & companyidx & "','" & employeeid & "','" & BasicPayEarnings.Value & "','" & Me.TotalDeduction.Value & "','" & NetPay.Value & "','" & sssee1 & "','" & phicee1 & "','" & hdmfee1 & "','" & wtax1 & "','" & sssloan1 & "','" & hdmfloan1 & "','" & vale1 & _
                    "','" & mandatoryx & "','" & taxableincome.Value & "','" & basic13 & "','" & PayMethod.Text & "','" & paygroup & "','" & APCESMainForm.UserFullName.Text & "',now())"
                    .Connection = con
                    .CommandType = CommandType.Text
                    .ExecuteNonQuery()

                    If OnVoucherEarning.Value <> 0 Then
                        .CommandText = "Insert into payroll_register(Register_Type,PayrollPeriodID,CompanyID,EmployeeID,Gross,Deduction,NetPay,SSSEE,PHICEE,HDMFEE,WTAX,SSSLoan,HDMFLoan,Vale,Mandatory,TaxableIncome,13thMonthPay,PaymentMethod,PayrollGroup,Creator,DateCreated) values " & _
                             " ('ALLOWANCE','" & payrollperiodid & "','" & companyidx & "','" & employeeid & "','" & OnVoucherEarning.Value & "',0,'" & OnVoucherEarning.Value & "',0,0,0,0,0,0,0,0,0,'" & voucher13 & "','" & PayMethod.Text & "','" & paygroup & "','" & APCESMainForm.UserFullName.Text & "',now())"
                        .Connection = con
                        .CommandType = CommandType.Text
                        .ExecuteNonQuery()
                    End If


                    ' If tosave = False Then
                    '.CommandText = "delete from payroll_register_detail where employeeid='" & employeeid & "' and payrollperiodid='" & payrollperiodid & "'"
                    '.Connection = con
                    '.CommandType = CommandType.Text
                    '.ExecuteNonQuery()
                    'End If


                    If saveorders2(Me.payrollperiodid, Me.PaySetUpGrid) <> "" Then
                        .CommandText = "insert into `payroll_register_detail` (`payrollperiodid`,`payrollid`,`payid`,`employeeid`,`value`,`Amount`,`hiddenamount`,`Remarks`,`creator`,`datecreated`)" & _
                             " values " & saveorders2(Me.payrollperiodid, Me.PaySetUpGrid)
                        .Connection = con
                        .CommandType = CommandType.Text
                        .ExecuteNonQuery()
                    Else
                        .CommandText = "insert into `payroll_register_detail` (`payrollperiodid`,`payrollid`,`payid`,`employeeid`,`value`,`Amount`,`hiddenamount`,`Remarks`,`creator`,`datecreated`)" & _
                           " values ('" & Me.payrollperiodid & "','" & payrollid & "','" & Me.PaySetUpGrid.Rows(2).Item("Payid") & "','" & employeeid & "','0', '0','0','','" & APCESMainForm.UserFullName.Text & "','" & Format(Now, "yyyy-MM-dd") & "')"
                        .Connection = con
                        .CommandType = CommandType.Text
                        .ExecuteNonQuery()
                    End If

                End With
                FunctionClass.showMessage("The record has been successfully saved!", "Command Executed!", "Command executed")
                Me.PayReference.Text = payrollid.ToString("d10")
                con.Close()
                command.Dispose()
                Timer1.Start()
                Me.tosave = False
            End If
        Catch ex As Exception
            FunctionClass.showMessage("Exception found:" & ex.Message, "Contact system admin", "Contact System Admin")
        End Try
    End Sub
    Private Function saveorders2(ByVal id As Integer, ByVal flexgrid As C1.Win.C1FlexGrid.C1FlexGrid) As String
        Dim z11 As String = ""
        Try
            Dim x As Integer = 1
            Dim y As Integer = flexgrid.Rows.Count - 1
            For x = 1 To y
                With flexgrid.Rows(x)
                    If .Item("Amount") = 0 Then Continue For
                    z11 = z11 & " " & "('" & id & _
                         "', '" & Me.payrollid & _
                        "', '" & .Item("payid") & _
                        "', '" & employeeid & _
                        "', '" & .Item("value") & _
                        "', '" & .Item("amount") & _
                          "', '" & .Item("hiddenamount") & _
                        "', '" & .Item("remarks") & _
                        "', '" & APCESMainForm.UserFullName.Text & _
                        "', '" & Format(Now, "yyyy-MM-dd") & "')            "
                End With
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return LTrim(RTrim(z11)).Replace("            ", ",")
    End Function
    Private Sub PrintRegister1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintRegister1.Click
        If paygroup = "SEMI-MONTHLY" Then
            Dim x As New ReportFormPrinting
            With x
                .print3("hris.Reporting_PayrollRegister_General", "filterquery", " and p.payrollperiodid=" & Me.payrollperiodid, 7, 1)
                .Show()
            End With
        End If
    End Sub
    Private Sub PrintCreditMemo1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub SaveJobOrder1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveJobOrder1.Click
        Dim x As New HRIS_IncomeDeduction
        With x
            .StartPosition = FormStartPosition.CenterScreen
            .ShowDialog()
        End With
    End Sub

    Private Sub SaveJobOrder4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveJobOrder4.Click
        ' Dim i As Integer = Me.C1FlexGrid2.RowSel

        If Me.C1FlexGrid2.RowSel = 0 Then Exit Sub
        Dim i As Integer = Me.C1FlexGrid2.Rows(Me.C1FlexGrid2.RowSel).Item("EmployeeID")
        Dim x As New HRIS_EmployeeInformation(i)
        With x
            .C1DockingTab1.SelectedIndex = 6
            .StartPosition = FormStartPosition.CenterScreen
            .ShowDialog()
        End With
    End Sub


    Private Sub SearchRecords_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchRecords.Click
        FunctionClass.loadtoGrid("Select Employeeid, Employeeno, concat(lastname,', ',Firstname,' ', left(MiddleName,1),'.') as Employee,PaymentMethod from hris_employee where companyid='" & companyidx & "' and payrollgroup='" & paygroup & "' and active=1  and  firstname like '%" & searchfield.Text & "%' order by lastname, firstname asc", C1FlexGrid2)
    End Sub

    Private Sub ReloadAllRecords_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReloadAllRecords.Click
        FunctionClass.loadtoGrid("Select Employeeid, Employeeno, concat(lastname,', ',Firstname,' ', left(MiddleName,1),'.') as Employee,PaymentMethod from hris_employee where companyid='" & companyidx & "' and payrollgroup='" & paygroup & "' and active=1 order by lastname asc", C1FlexGrid2)
    End Sub

    Private Sub ClearFields_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearFields.Click
        searchfield.Text = Nothing
    End Sub

    Private Sub SaveJobOrder2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveJobOrder2.Click
        Me.Close()
    End Sub

    Private Sub InputButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintRegister.Click
        C1TaskDialog1.Show()
    End Sub
    Private Sub C1TaskDialog1_ButtonClick(ByVal sender As System.Object, ByVal e As C1.Win.C1Win7Pack.TaskDialogButtonClickEventArgs) Handles C1TaskDialog1.ButtonClick
        Try
            If e.DialogResult = C1.Win.C1Win7Pack.TaskDialogResult.Custom Then
                Dim y1 As DialogResult = Windows.Forms.DialogResult.Cancel

                Select Case e.CustomButton.Name
                    Case "CancelButton"
                        Me.C1TaskDialog1.Close()
                    Case "Register1"
                        If paygroup = "SEMI-MONTHLY" Then
                            Dim x As New ReportFormPrinting
                            With x
                                .print3("hris.Reporting_PayrollRegister_General", "filterquery", " and a.register_type='REGULAR' and p.payrollperiodid=" & Me.payrollperiodid, 6, 0)
                                .ShowDialog()
                            End With
                        ElseIf paygroup = "MONTHLY" Then
                            Dim x As New ReportFormPrinting
                            With x
                                .print3("hris.Reporting_PayrollRegister_General", "filterquery", " and a.register_type='REGULAR' and p.payrollperiodid=" & Me.payrollperiodid, 6, 0)
                                .ShowDialog()
                            End With
                        ElseIf paygroup = "WEEKLY" Then
                            Dim x As New ReportFormPrinting
                            With x
                                .print3("hris.Reporting_PayrollRegister_General", "filterquery", " and a.register_type='REGULAR' and p.payrollperiodid=" & Me.payrollperiodid, 5, 0)
                                .ShowDialog()
                            End With
                        End If


                    Case "Register2"
                        If paygroup = "SEMI-MONTHLY" Then
                            Dim x As New ReportFormPrinting
                            With x
                                .print3("hris.Reporting_PayrollRegister_General", "filterquery", " and a.register_type='ALLOWANCE' and p.payrollperiodid=" & Me.payrollperiodid, 8, 1)
                                .ShowDialog()
                            End With
                        ElseIf paygroup = "MONTHLY" Then
                            Dim x As New ReportFormPrinting
                            With x
                                .print3("hris.Reporting_PayrollRegister_General", "filterquery", " and a.register_type='ALLOWANCE' and p.payrollperiodid=" & Me.payrollperiodid, 8, 1)
                                .ShowDialog()
                            End With
                        ElseIf paygroup = "WEEKLY" Then
                            Dim x As New ReportFormPrinting
                            With x
                                .print3("hris.Reporting_PayrollRegister_General", "filterquery", " and a.register_type='ALLOWANCE' and p.payrollperiodid=" & Me.payrollperiodid, 9, 1)
                                .ShowDialog()
                            End With
                        End If
                    Case "Voucher"
                        Dim x As New ReportFormPrinting
                        With x
                            .printReports("Reporting_PayrollRegister", " and b.payrollperiodid='" & payrollperiodid & "' and b.netpay <> 0", 1)
                            .ShowDialog()
                        End With
                End Select

            End If
            Me.Cursor = Cursors.WaitCursor
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub PrintCreditMemo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPaySlip.Click
        C1TaskDialog2.Show()
    End Sub

    Private Sub C1TaskDialog2_ButtonClick(ByVal sender As System.Object, ByVal e As C1.Win.C1Win7Pack.TaskDialogButtonClickEventArgs) Handles C1TaskDialog2.ButtonClick
        Try
            If e.DialogResult = C1.Win.C1Win7Pack.TaskDialogResult.Custom Then
                Dim y1 As DialogResult = Windows.Forms.DialogResult.Cancel

                Select Case e.CustomButton.Name
                    Case "CancelButton"
                        Me.C1TaskDialog1.Close()
                    Case "Register1"
                        If paygroup = "SEMI-MONTHLY" Then
                            Dim x As New ReportFormPrinting
                            With x
                                .print4("hris.Reporting_PayrollRegister_Weekly", "filterquery", " and a.register_type='REGULAR' and p.payrollperiodid=" & Me.payrollperiodid, 1, 0)
                                .ShowDialog()
                            End With
                        ElseIf paygroup = "MONTHLY" Then
                            Dim x As New ReportFormPrinting
                            With x
                                .print4("hris.Reporting_PayrollRegister_Weekly", "filterquery", " and a.register_type='REGULAR' and p.payrollperiodid=" & Me.payrollperiodid, 1, 0)
                                .ShowDialog()
                            End With
                        ElseIf paygroup = "WEEKLY" Then
                            Dim x As New ReportFormPrinting
                            With x
                                .print4("hris.Reporting_PayrollRegister_Weekly", "filterquery", " and a.register_type='REGULAR' and p.payrollperiodid=" & Me.payrollperiodid, 2, 0)
                                .ShowDialog()
                            End With
                        End If


                    Case "Register2"
                        If paygroup = "SEMI-MONTHLY" Then
                            Dim x As New ReportFormPrinting
                            With x
                                .print4("hris.Reporting_PayrollRegister_Weekly", "filterquery", " and a.register_type='ALLOWANCE' and p.payrollperiodid=" & Me.payrollperiodid, 3, 1)
                                .ShowDialog()
                            End With
                        ElseIf paygroup = "MONTHLY" Then
                            Dim x As New ReportFormPrinting
                            With x
                                .print4("hris.Reporting_PayrollRegister_Weekly", "filterquery", " and a.register_type='ALLOWANCE' and p.payrollperiodid=" & Me.payrollperiodid, 3, 1)
                                .ShowDialog()
                            End With
                        ElseIf paygroup = "WEEKLY" Then
                            Dim x As New ReportFormPrinting
                            With x
                                .print4("hris.Reporting_PayrollRegister_Weekly", "filterquery", " and a.register_type='ALLOWANCE' and p.payrollperiodid=" & Me.payrollperiodid, 4, 1)
                                .ShowDialog()
                            End With
                        End If
                End Select
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub PaySetUpGrid_Validated() Handles PaySetUpGrid.Validated
        toedit = True
    End Sub
End Class