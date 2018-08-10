Imports MySql.Data.MySqlClient
Imports MySql.Data
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Public Class Payroll_Home1

    Private tbcReportTab As System.Windows.Forms.TabControl
    Private myPageView As CrystalDecisions.Windows.Forms.PageView
    Private Sub HideTabs()
        Dim crvObject As Object
        For Each crvObject In Me.CrystalReportViewer2.Controls
            If crvObject.GetType Is GetType(CrystalDecisions.Windows.Forms.PageView) Then
                myPageView = CType(crvObject, CrystalDecisions.Windows.Forms.PageView)
                Dim crvObjectControl As Object
                For Each crvObjectControl In crvObject.controls
                    If crvObjectControl.GetType Is GetType(TabControl) Then
                        tbcReportTab = crvObjectControl
                    End If
                Next
            End If
        Next
        With tbcReportTab
            .ItemSize = New Size(0, 1)
            .SizeMode = TabSizeMode.Fixed
            .Dock = DockStyle.None
            .Left -= 4
            .Top -= 5
            .Width = .Parent.Width + 8
            .Height = .Parent.Height + 9
            .Anchor = AnchorStyles.Left Or AnchorStyles.Top Or AnchorStyles.Right Or AnchorStyles.Bottom
            .Appearance = TabAppearance.Normal
        End With
        With tbcReportTab.TabPages(0)
            .BackColor = Me.BackgroundColor
        End With
    End Sub
    Private Sub PrintReportButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintReportButton.Click

    End Sub
    Private Sub ExportReportButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportReportButton.Click
        Me.CrystalReportViewer2.ExportReport()
    End Sub
    Private Sub RefreshReportButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshReportButton.Click
        MainLauncher(0)
        Me.CrystalReportViewer2.Refresh()
        MainLauncher(1)
    End Sub
    Private Sub CloseFormButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseFormButton.Click
        Me.Close()
    End Sub

    Public Sub printReports(ByVal a As String, ByVal b As String, ByVal c As Integer)

        Try
            command = New MySqlCommand
            connect()
            con.Open()
            With command
                .Connection = con
                .CommandType = CommandType.StoredProcedure
                .CommandText = a
                .Parameters.AddWithValue("@filterquery", b)
                .Parameters.AddWithValue("@groupby", " ")
            End With
            Dim da As New MySqlDataAdapter
            Dim ds As New DataSet
            da.SelectCommand = command
            da.SelectCommand.CommandTimeout = 10000
            da.Fill(ds)
            con.Close()
            command.Dispose()
            If ds.Tables(0).Rows.Count <= 0 Then
                MessageBox.Show("Search not found!, Please try another search category")
            Else
                If c = 1 Then
                    Dim crpt As New Payroll_Register_Generic
                    Dim inclusivedate, registerdate As CrystalDecisions.CrystalReports.Engine.TextObject
                    With crpt
                        registerdate = .ReportDefinition.Sections(0).ReportObjects("text15") : registerdate.Text = "Date From " & Format(payrolldatefrom.Value, "MMM dd yyyy") & " to " & Format(payrolldateto.Value, "MMM dd yyyy")
                        inclusivedate = .ReportDefinition.Sections(4).ReportObjects("text21") : inclusivedate.Text = "Summary " & vbNewLine & Format(payrolldatefrom.Value, "MM/dd/yyyy") & "-" & Format(payrolldateto.Value, "MM/dd/yyyy")
                        .SetDataSource(ds.Tables(0))
                        Me.CrystalReportViewer2.ReportSource = crpt
                        Me.CrystalReportViewer2.Refresh()
                    End With
                ElseIf c = 2 Then
                    Dim crpt As New PayrollRegister_Weekly_General
                    With crpt
                        .SetDataSource(ds.Tables(0))
                        Me.CrystalReportViewer2.ReportSource = crpt
                        Me.CrystalReportViewer2.Refresh()
                    End With
                Else
                    MessageBox.Show("Search not found!, Please try another search category")
                End If
            End If
            '   HideTabs()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            'MessageBox.Show("Search not found!, Please try another search category")
        End Try
    End Sub
    Dim CommandText As String
    Dim Count As Integer = 0
    Dim DisplayMem As String
    Dim ComboboxName As String

    Private Sub SalesReportFilter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadComboboxes()
        Me.company.SelectedValue = companyid
        ' Me.SDate.Value = Now
        ' Me.eDaate.Value = Now
        MainLauncher(0)
    End Sub
    Sub LoadComboboxes()
        RemoveHandler Me.company.SelectedIndexChanged, AddressOf cmbCust_SelectedIndexChanged
        loadingvaluestoComboBoxes_StoredProc("Combo_Employees_Activeonly", Me.EmployeeName, "Employee", "EmployeeID")
        loadingvaluestoComboBoxes_StoredProc("combo_company_ActiveOnly", company, "companyname", "companyid")
        loadingvaluestoComboBoxes_StoredProc("combo_department_ActiveOnly", Department, "department", "departmentid")
        loadingvaluestoComboBoxes_StoredProc("combo_payrollgroup_ActiveOnly", payrollgroup, "payrollgroup", "payrollgroup")
        loadingvaluestoComboBoxes_StoredProc("combo_paymentmethod_ActiveOnly", paymentmethod, "paymentmethod", "paymentmethod")
        'loadingvaluestoComboBoxes_StoredProc("combo_employeetype_ActiveOnly", EmployeeType, "employeetype", "employeetype")
        AddHandler Me.company.SelectedIndexChanged, AddressOf cmbCust_SelectedIndexChanged
        Me.payrolldatefrom.Value = FirstDayOfMonth(Now)
        Me.payrolldateto.Value = LastDayOfMonth(Now)

    End Sub
    Sub clear()
        company.Text = ""
        payrollgroup.Text = ""
        Department.Text = ""
        paymentmethod.Text = ""
        Me.payrolldatefrom.Value = FirstDayOfMonth(Now)
        Me.payrolldateto.Value = LastDayOfMonth(Now)
    End Sub
    Private Sub cmbCust_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        If DBNull.Value.Equals(Me.company.SelectedValue) Then Me.Department.Text = Nothing : Exit Sub
        ' FunctionClass.loadingvaluestoComboBoxes("select CustomerID,CustomerName as CustomerName from customers Where  ParentID=" & Me.company.SelectedValue & "  Group by CustomerName Order By CustomerName", Me.department, "CustomerName", "CustomerID")
    End Sub

    Private Sub RefreshDropDownsCombo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Application.DoEvents()
        MainLauncher(0)
        LoadComboboxes()
        MainLauncher(1)
    End Sub
    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        Try
            'If Me.company.Text = "" Then showMessage("Please select company and try again.", "No company selected.", "Select company and try again", 3) : Exit Sub
            ' If Me.payrollgroup.Text = "" Then showMessage("Please select payroll group and try again.", "No payroll group selected.", "Select payroll group and try again", 3) : Exit Sub
            MainLauncher(0)

            Dim s1 As String = company.Text
            Dim s2 As String = Department.Text
            Dim s3 As String = payrollgroup.Text
            Dim s4 As String = EmployeeName.Text
            Dim s5 As String = paymentmethod.Text

            Dim payrolldatequery As String = ""
            If Me.payrolldatefrom.Text = Nothing And Me.payrolldateto.Text = Nothing Then
                payrolldatequery = ""
            Else
                If Me.payrolldatefrom.Text <> Nothing Then
                    If payrolldateto.Text <> Nothing Then
                        payrolldatequery = " and  date_format(c.payrolldate, '%Y/%m/%d')  between '" & Format(payrolldatefrom.Value, "yyyy/MM/dd") & "' and '" & Format(payrolldateto.Value, "yyyy/MM/dd") & "' "
                    Else
                        payrolldatequery = " and  c.payrolldate >= '" & Format(payrolldatefrom.Value, "yyyy/MM/dd") & "' "
                    End If
                Else
                    If payrolldateto.Text <> Nothing Then
                        payrolldatequery = " and c.payrolldate<= '" & Format(payrolldateto.Value, "yyyy/MM/dd") & "' "
                    Else
                        payrolldatequery = " and c.payrolldate like '%%' "
                    End If
                End If
            End If


            'Dim Startdate As Date = SDate.Value
            ''  Dim EndDate As Date = eDaate.Value
            If company.Text = "" Then s1 = "" Else s1 = " and b.companyid = '" & company.SelectedValue & "' "
            If Department.Text = "" Then s2 = "" Else s2 = " and a.departmentid = '" & Department.SelectedValue & "' "
            If EmployeeName.Text = "" Then s4 = "" Else s4 = " and a.employeeid='" & EmployeeName.SelectedValue & "' "
            ' If payrollgroup.Text = "" Then s3 = "" Else s3 = " and b.payrollgroup = '" & payrollgroup.Text & "' "
            If paymentmethod.Text = "" Then s5 = "" Else s5 = " and b.paymentmethod like '%" & paymentmethod.Text & "%' "

            Dim filtersearchquery As String = payrolldatequery & s1 & s2 & s4 & s5

            printReports("Reporting_PayrollRegister", filtersearchquery, 1)
            MainLauncher(0)


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub Print1()
        Try
            If Me.company.Text = "" Then showMessage("Please select company and try again.", "No company selected.", "Select company and try again", 3) : Exit Sub
            If Me.payrollgroup.Text = "" Then showMessage("Please select payroll group and try again.", "No payroll group selected.", "Select payroll group and try again", 3) : Exit Sub
            MainLauncher(0)

            Dim s1 As String = company.Text
            Dim s2 As String = Department.Text
            Dim s3 As String = payrollgroup.Text
            Dim s4 As String = EmployeeName.Text
            Dim s5 As String = paymentmethod.Text

            Dim payrolldatequery As String = ""
            If Me.payrolldatefrom.Text = Nothing And Me.payrolldateto.Text = Nothing Then
                payrolldatequery = ""
            Else
                If Me.payrolldatefrom.Text <> Nothing Then
                    If payrolldateto.Text <> Nothing Then
                        payrolldatequery = " and  date_format(y.payrolldate, '%Y/%m/%d')  between '" & Format(payrolldatefrom.Value, "yyyy/MM/dd") & "' and '" & Format(payrolldateto.Value, "yyyy/MM/dd") & "' "
                    Else
                        payrolldatequery = " and  y.payrolldate >= '" & Format(payrolldatefrom.Value, "yyyy/MM/dd") & "' "
                    End If
                Else
                    If payrolldateto.Text <> Nothing Then
                        payrolldatequery = " and y.payrolldate<= '" & Format(payrolldateto.Value, "yyyy/MM/dd") & "' "
                    Else
                        payrolldatequery = " and y.payrolldate like '%%' "
                    End If
                End If
            End If


            'Dim Startdate As Date = SDate.Value
            ''  Dim EndDate As Date = eDaate.Value
            If company.Text = "" Then s1 = "" Else s1 = " and z.companyid = '" & company.SelectedValue & "' "
            If Department.Text = "" Then s2 = "" Else s2 = " and x.departmentid = '" & Department.SelectedValue & "' "
            If EmployeeName.Text = "" Then s4 = "" Else s4 = " and x.employeeid='" & EmployeeName.SelectedValue & "' "
            If payrollgroup.Text = "" Then s3 = "" Else s3 = " and y.payrollgroup = '" & payrollgroup.Text & "' "
            If paymentmethod.Text = "" Then s5 = "" Else s5 = " and x.paymentmethod like '%" & paymentmethod.Text & "%' "

            Dim filtersearchquery As String = payrolldatequery & s1 & s2 & s3 & s4 & s5

            If payrollgroup.Text = "SEMI-MONTHLY" Then
                printReports("Reporting_PayrollRegister_General", filtersearchquery, 1)
            ElseIf payrollgroup.Text = "MONTHLY" Then
                printReports("Reporting_PayrollRegister_General", filtersearchquery, 1)
            ElseIf payrollgroup.Text = "WEEKLY" Then
                printReports("Reporting_PayrollRegister_General", filtersearchquery, 2)
            Else
                printReports("Reporting_PayrollRegister_General", filtersearchquery, 1)
            End If
            MainLauncher(0)


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub cmdClear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        clear()
    End Sub
End Class
