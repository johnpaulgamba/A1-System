Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Drawing.Imaging

Public Class HRIS_EmployeeInformation
    Dim DlgOpenFile As New OpenFileDialog()
    Public ImageLocation As String = ""
    Public tosave, picedit As Boolean
    Public employeeid As Integer
    Public basicsemimonthly, basicdaily As Double
    Public SSSER_Share, PHICER_Share, HDMFER_Share As Double


    Public Sub New(ByVal id As Integer)
        ' This call is required by the designer.
        InitializeComponent()
        C1DockingTab1.SelectedIndex = 0

        loadingvaluestoComboBoxes_StoredProc("combo_company_ActiveOnly", CompanyName, "companyname", "companyid")
        loadingvaluestoComboBoxes_StoredProc("combo_department_ActiveOnly", Department, "department", "departmentid")
        loadingvaluestoComboBoxes_StoredProc("combo_location_ActiveOnly", Location, "location", "location")
        loadingvaluestoComboBoxes_StoredProc("combo_group_ActiveOnly", Team, "groupname", "groupname")
        loadingvaluestoComboBoxes_StoredProc("combo_position_ActiveOnly", Position, "positionname", "positionname")
        loadingvaluestoComboBoxes_StoredProc("combo_religion_ActiveOnly", Religion, "religion", "religion")
        loadingvaluestoComboBoxes_StoredProc("combo_civilstatus_ActiveOnly", CivilStatus, "civilstatus", "civilstatus")
        loadingvaluestoComboBoxes_StoredProc("combo_gender_ActiveOnly", Gender, "gender", "gender")
        loadingvaluestoComboBoxes_StoredProc("combo_employmentlevel_ActiveOnly", EmploymentLevel, "employmentlevel", "employmentlevel")
        loadingvaluestoComboBoxes_StoredProc("combo_employeetype_ActiveOnly", EmployeeType, "employeetype", "employeetype")
        loadingvaluestoComboBoxes_StoredProc("combo_gender_ActiveOnly", Gender, "gender", "gender")
        loadingvaluestoComboBoxes_StoredProc("combo_employmentstatus_ActiveOnly", EmploymentStatus, "employmentstatus", "employmentstatus")
        loadingvaluestoComboBoxes_StoredProc("combo_payrollgroup_ActiveOnly", payrollgroup, "payrollgroup", "payrollgroup")
        loadingvaluestoComboBoxes_StoredProc("combo_paymentmethod_ActiveOnly", paymentmethod, "paymentmethod", "paymentmethod")
        loadingvaluestoComboBoxes_StoredProc("combo_employeesLevelA_ActiveOnly", ImmediateSuperior, "Employee", "EmployeeID")
        loadingvaluestoComboBoxes_StoredProc("combo_employeesLevelA_ActiveOnly", OvertimeApproval, "Employee", "EmployeeID")
        loadingvaluestoComboBoxes_StoredProc("combo_employeesLevelA_ActiveOnly", TimeSheetApproval, "Employee", "EmployeeID")
        ' Add any initialization after the InitializeComponent() call.
        If id = 0 Then clear() Else loadentries(id) : loadGrids(id)
    End Sub
    Private Sub Search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Search.Click
        'Try
        Dim id As Integer = Me.EmployeeNo.Text
        Dim idx As Integer = 0
        connect()
        con.Open()
        command = New MySqlCommand("select * from hris_employee where employeeno='" & id & "'", con)
        reader = command.ExecuteReader
        If reader.Read = True Then
            idx = reader.Item("employeeid")
        End If
        reader.Close()
        con.Close()
        command.Dispose()
        loadentries(idx)
        loadGrids(idx)
        ' Catch ex As Exception
        ' MessageBox.Show(ex.ToString)
        ' End Try
    End Sub
    Public Sub clear()
        FunctionClass.ClearPanel(Me.C1InputPanel1)
        FunctionClass.ClearPanel(Me.C1InputPanel2)
        FunctionClass.ClearPanel(Me.C1InputPanel3)
        FunctionClass.ClearPanel(Me.C1InputPanel4)
        FunctionClass.ClearPanel(Me.C1InputPanel5)
        Me.BasicSalary.Value = 0
        Me.ChargetoCompany.Checked = False
        Me.deducthdmf.Checked = True
        Me.deductphic.Checked = True
        Me.deductsss.Checked = True
        Me.deducttax.Checked = True
        Me.active.Checked = True
        Me.DateHired.Value = Now
        Me.CompanyName.SelectedValue = companyid
        tosave = True
        If tosave = True Then
            FunctionClass.loadtoGrid("Select requirementid,ok,requirement,optional from hris_requirement_setup", RequirementGrid)
            FunctionClass.loadtoGrid("Select payid, paytype, Amount, PayRate, active, remarks from companypayrollsetup where companyid = '" & companyid & "' order by `order` asc ", PaySetUpGrid)
            FunctionClass.loadtoGrid("Select allowanceid, allowance, amount ,active, remarks from companyallowance where companyid='" & companyid & "'", AllowanceGrid)
        End If

    End Sub
    Private Sub loadentries(ByVal id As Integer)
        Try
            Dim ds As New DataSet
            Dim adapter As New MySqlDataAdapter("select * from hris_employee where employeeid=" & id, con)
            With adapter
                .Fill(ds)
                .Dispose()
            End With
            con.Close()
            With ds.Tables(0).Rows(0)
                Me.employeeid = .Item("EMPLOYEEID")
                Me.EmployeeNo.Text = .Item("employeeno")
                Me.LastName.Text = .Item("lastname")
                Me.FirstName.Text = .Item("firstname")
                Me.MiddleName.Text = .Item("middlename")
                Me.Suffix.Text = .Item("Suffix")
                Me.Gender.Text = .Item("gender")
                Me.ContactNo.Text = .Item("contactno")
                Me.Email.Text = .Item("email")
                Me.active.Checked = .Item("active")
                Me.TIN.Text = .Item("tin")
                Me.PHIC.Text = .Item("phic")
                Me.SSS.Text = .Item("sss")
                Me.BankAccount.Text = .Item("bankaccountno")
                Me.HDMF.Text = .Item("hdmf")


                'payroll info
                Me.payrollgroup.Text = .Item("payrollgroup")
                Me.paymentmethod.Text = .Item("paymentmethod")
                Me.MonthlyHours.Value = .Item("monthlyhours")
                Me.MonthlyPay.Value = .Item("BasicPayMonth")
                Me.BasicSalary.Value = .Item("basicSalary")
                basicsemimonthly = .Item("BasicPaySemiMonth")
                basicdaily = .Item("BasicPayDaily")
                Me.BasicPayHourly.Value = .Item("BasicPayHour")
                Me.HiddenAllowanceRate.Value = .Item("HiddenRateHour")
                Me.wtax.Value = .Item("wtax")
                Me.SSSEEShare.Value = .Item("Sssee")
                Me.SSSER_Share = .Item("ssser")
                Me.PHICEEShare.Value = .Item("phicee")
                Me.PHICER_Share = .Item("phicer")
                Me.Mandatory.Value = .Item("hdmfer")
                Me.HDMFEEShare.Value = .Item("hdmfee")
                Me.deducthdmf.Checked = .Item("deducthdmf")
                Me.deductphic.Checked = .Item("deductphic")
                Me.deductsss.Checked = .Item("deductsss")
                Me.deducttax.Checked = .Item("deducttax")
                Me.ChargetoCompany.Checked = .Item("chargetocompany")
                Me.HiddenAllowance.Value = .Item("hiddenAllowance")
                Me.LegalAllowance.Value = .Item("legalallowance")
                Me.BasicPay.Value = .Item("basicsalary")
                Me.cola.Value = .Item("cola")


                loadearningsandincome()
                compute()



                ''Company Info
                Me.CompanyName.SelectedValue = .Item("companyid")
                Me.Department.SelectedValue = .Item("departmentid")
                Me.Position.Text = .Item("position")
                Me.ImmediateSuperior.Text = .Item("immediatesuperior")
                Me.TimeSheetApproval.Text = .Item("timesheetapproval")
                Me.OvertimeApproval.Text = .Item("otapproval")
                Me.EmploymentLevel.Text = .Item("employmentlevel")
                Me.EmploymentStatus.Text = .Item("employmentstatus")
                Me.EmployeeType.Text = .Item("employeetype")
                Me.Team.Text = .Item("groupname")
                Me.Location.Text = .Item("location")
                Me.DateHired.Value = .Item("datehired")
                Me.DateSeparated.Text = .Item("dateseparated")
                Me.DateResigned.Text = .Item("dateresigned")
                Me.DateRegular.Text = .Item("dateregular")
                Me.Rehirable.Checked = .Item("rehirable")
                Me.ContractStartDate.Text = .Item("contractstartdate")
                Me.ContractEndDate.Text = .Item("contractenddate")
                Me.ClearanceStatus.Text = .Item("clearancestatus")
                Me.DateCleared.Text = .Item("datecleared")
                Me.IssuedBy.Text = .Item("issuedby")
                Me.Remarks.Text = .Item("remarks")
                Me.DateofBirth.Value = .Item("Dateofbirth")
                Me.PlaceOfBirth.Text = .Item("placeofbirth")
                Me.CivilStatus.Text = .Item("civilstatus")
                Me.Religion.Text = .Item("religion")
                Me.Height.Value = .Item("height")
                Me.Weight.Value = .Item("weight")
                Me.BloodType.Text = .Item("bloodtype")
                Me.BodyBuild.Text = .Item("bodybuild")
                Dim lb() As Byte = .Item("employeeImage")
                Dim lstr As New System.IO.MemoryStream(lb)
                Me.PictureBox1.Image = Image.FromStream(lstr)
            End With
            tosave = False
        Catch ex As Exception
            '  MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub loadGrids(ByVal id As Integer)
        Try
            FunctionClass.loadtoGrid3("HRIS_GRID_hris_employee_dependents", id, Me.DependentsGrid)
            FunctionClass.loadtoGrid3("HRIS_GRID_hris_employee_education", id, Me.EducationGrid)
            FunctionClass.loadtoGrid3("HRIS_GRID_hris_employee_employment", id, Me.EmploymentGrid)
            FunctionClass.loadtoGrid3("HRIS_GRID_hris_employee_addresses", id, Me.ResidenceGrid)
            FunctionClass.loadtoGrid3("HRIS_GRID_hris_employee_training", id, Me.TrainingGrid)
            FunctionClass.loadtoGrid3("HRIS_GRID_hris_employee_memo", id, Me.MemoGrid)
            FunctionClass.loadtoGrid3("HRIS_GRID_hris_employee_requirements", id, Me.RequirementGrid)
            FunctionClass.loadtoGrid3("HRIS_GRID_hris_employee_allowance", id, Me.AllowanceGrid)
            '  FunctionClass.loadtoGrid3("HRIS_GRID_hris_employee_paysetup", id, Me.PaySetUpGrid)
            Me.addresstotal.Text = Me.ResidenceGrid.Rows.Count - 1
            Me.educationtotal.Text = Me.EducationGrid.Rows.Count - 1
            Me.dependentstotal.Text = Me.DependentsGrid.Rows.Count - 1
            Me.employmentotal.Text = Me.EmploymentGrid.Rows.Count - 1
            Me.trainingtotal.Text = Me.TrainingGrid.Rows.Count - 1
            Me.memototal.Text = Me.MemoGrid.Rows.Count - 1
            If Me.RequirementGrid.Rows.Count = 1 Then
                FunctionClass.loadtoGrid("Select requirementid,ok,requirement,optional from hris_requirement_setup where active=1", RequirementGrid)
            End If
            If Me.AllowanceGrid.Rows.Count = 1 Then
                FunctionClass.loadtoGrid("Select allowanceid, active, allowance, amount ,remarks from companyallowance where companyid='" & companyid & "' and active=1", AllowanceGrid)
            End If
            If Me.PaySetUpGrid.Rows.Count = 1 Then
                FunctionClass.loadtoGrid("Select payid, active, paytype, Amount, PayRate, remarks from companypayrollsetup where companyid = '" & companyid & "' and active=1", PaySetUpGrid)
            End If
        Catch ex As Exception
            '  MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub toenable(ByVal a As Boolean)
        With Me
            '.C1InputPanel1.ReadOnly = Not a
            '.C1InputPanel2.ReadOnly = Not a
        End With
    End Sub

    Private Sub saverecord_click() Handles SaveJobOrder.Click
        'If Me.DRDate.Value = Nothing Then
        'showMessage("invalid DR Date. make sure that you supplied valid DR Date.", "DR Date is invalid", "not valid", 3)
        'Exit Sub
        '  End If
        'checkserialgrid()
        If Me.EmployeeNo.Text = Nothing Or Val(Me.EmployeeNo.Text) = 0 Then MessageBox.Show("Invalid Employee No.", "Employee No is not valid", MessageBoxButtons.OK, MessageBoxIcon.Stop)

        If tosave = True Then
            Dim depositid As Integer = searchRecord("select auto_increment from information_schema.tables where  table_schema='" & database & "' and table_name='hris_employee';", 1)
            savecommand("HRIS_Employee_Execute", depositid, "Created ")
        Else
            savecommand("HRIS_Employee_Execute", employeeid, "Updated ")
        End If

    End Sub
    Private Function savecommand(ByVal a As String, ByVal depositid As Integer, ByVal b As String) As Boolean
        Dim cmd As New MySqlCommand
        Dim rawData() As Byte
        Dim fs As FileStream
        Dim sPath As String

        Dim mytrans As MySqlTransaction
        connect()
        con.Open()
        mytrans = con.BeginTransaction()
        ' Try
        connect()
        con.Open()

        command = New MySqlCommand
        With command
            .CommandText = a
            .Connection = con
            .CommandType = CommandType.StoredProcedure
            With .Parameters
                .AddWithValue("@employeeids", depositid)
                .AddWithValue("@employeenos", Me.EmployeeNo.Text)
                .AddWithValue("@firstnames", Me.FirstName.Text.ToUpper)
                .AddWithValue("@middlenames", Me.MiddleName.Text.ToUpper)
                .AddWithValue("@lastnames", Me.LastName.Text.ToUpper)
                .AddWithValue("@suffixs", Me.Suffix.Text.ToUpper)
                .AddWithValue("@genders", Me.Gender.Text.ToUpper)
                .AddWithValue("@contactnos", Me.ContactNo.Text.ToUpper)
                .AddWithValue("@emails", Me.Email.Text)
                .AddWithValue("@tins", convertQuotes(Me.TIN.Text))
                .AddWithValue("@phics", convertQuotes(Me.PHIC.Text))
                .AddWithValue("@hdmfs", convertQuotes(Me.HDMF.Text))
                .AddWithValue("@ssss", convertQuotes(Me.SSS.Text))
                .AddWithValue("@colas", cola.Value)
                .AddWithValue("@sssers", SSSER_Share)
                .AddWithValue("@sssees", SSSEEShare.Value)
                .AddWithValue("@phicers", PHICER_Share)
                .AddWithValue("@phicees", PHICEEShare.Value)
                .AddWithValue("@hdmfers", HDMFER_Share)
                .AddWithValue("@hdmfees", HDMFEEShare.Value)
                .AddWithValue("@wtaxs", wtax.Value)
                .AddWithValue("@bankaccountnos", convertQuotes(Me.BankAccount.Text))
                If Me.CompanyName.Text = "" Then .AddWithValue("@companyids", 0) Else .AddWithValue("@companyids", Me.CompanyName.SelectedValue)
                If Me.Department.Text = "" Then .AddWithValue("@departmentids", 0) Else .AddWithValue("@departmentids", Me.Department.SelectedValue)
                .AddWithValue("@hiddenallowances", Me.HiddenAllowance.Value)
                .AddWithValue("@hiddenratehours", Me.HiddenAllowanceRate.Value)
                .AddWithValue("@legalallowances", Me.LegalAllowance.Value)
                .AddWithValue("@basicsalarys", Me.BasicSalary.Value)

                .AddWithValue("@positions", Me.Position.Text.ToUpper)
                .AddWithValue("@employmentlevels", Me.EmploymentLevel.Text.ToUpper)
                .AddWithValue("@employeetypes", Me.EmployeeType.Text.ToUpper)
                .AddWithValue("@immediatesuperiors", Me.ImmediateSuperior.Text)
                .AddWithValue("@groupnames", Me.Team.Text.ToUpper)
                .AddWithValue("@locations", Me.Location.Text.ToUpper)
                .AddWithValue("@timesheetapprovals", Me.TimeSheetApproval.Text)
                .AddWithValue("@otapprovals", Me.TimeSheetApproval.Text)
                .AddWithValue("@datehireds", Me.DateHired.Value)
                .AddWithValue("@dateregulars", Me.DateRegular.Text)
                .AddWithValue("@dateseparateds", Me.DateSeparated.Text)
                .AddWithValue("@rehirables", Me.Rehirable.Checked)
                .AddWithValue("@dateresigneds", Me.DateResigned.Text)
                .AddWithValue("@contractstartdates", Me.ContractStartDate.Text)
                .AddWithValue("@contractenddates", Me.ContractEndDate.Text)
                .AddWithValue("@clearancestatuss", Me.ClearanceStatus.Text.ToUpper)
                .AddWithValue("@datecleareds", Me.DateCleared.Text)
                .AddWithValue("@issuedbys", Me.IssuedBy.Text.ToUpper)
                .AddWithValue("@remarkss", Me.Remarks.Text.ToUpper)
                .AddWithValue("@dateofbirths", Me.DateofBirth.Value)
                .AddWithValue("@placeofbirths", Me.PlaceOfBirth.Text.ToUpper)
                .AddWithValue("@civilstatuss", Me.CivilStatus.Text.ToUpper)
                .AddWithValue("@religions", Me.Religion.Text.ToUpper)
                .AddWithValue("@heights", Me.Height.Value)
                .AddWithValue("@weights", Me.Weight.Value)
                .AddWithValue("@payrollgroups", Me.payrollgroup.Text.ToUpper)
                .AddWithValue("@monthlyhourss", Me.MonthlyHours.Value)
                .AddWithValue("@basicpaymonths", Me.MonthlyPay.Value)
                .AddWithValue("@basicpaysemimonths", basicsemimonthly)
                .AddWithValue("@basicpayweeks", basicdaily)
                .AddWithValue("@basicpayhours", Me.BasicPayHourly.Value)
                .AddWithValue("@bloodtypes", Me.BloodType.Text.ToUpper)
                .AddWithValue("@payratetypes", Me.payrollgroup.Text.ToUpper)
                .AddWithValue("@paymentmethods", Me.paymentmethod.Text.ToUpper)
                .AddWithValue("@deducttaxs", Me.deducttax.Checked)
                .AddWithValue("@deducthdmfs", Me.deducthdmf.Checked)
                .AddWithValue("@deductphics", Me.deductphic.Checked)
                .AddWithValue("@deductssss", Me.deductsss.Checked)
                .AddWithValue("@chargetocompanys", Me.ChargetoCompany.Checked)
                .AddWithValue("@employmentstatuss", Me.EmploymentStatus.Text)
                .AddWithValue("@bodybuilds", Me.BodyBuild.Text)
                If picedit = True Then
                    sPath = DlgOpenFile.FileName
                    fs = New FileStream(sPath, FileMode.Open, FileAccess.Read)
                    rawData = New Byte(fs.Length) {}
                    fs.Read(rawData, 0, fs.Length)
                    fs.Close()
                    .AddWithValue("@employeeimages", rawData)
                Else
                    .AddWithValue("@employeeimages", "wala")
                End If
                .AddWithValue("@actives", Me.active.Checked)
                .AddWithValue("@creators", APCESMainForm.UserFullName.Text)
                .AddWithValue("@ChangesMadeS", b & " on " & Now & " at " & APCESMainForm.ComputerName.Text & " by " & APCESMainForm.UserFullName.Text & vbCrLf & "")
                .AddWithValue("@tosave", Me.tosave)
            End With
            .ExecuteNonQuery()


            If Me.tosave = False Then
                .CommandText = "delete from hris_requirements where employeeid='" & depositid & "'"
                .Connection = con
                .CommandType = CommandType.Text
                .ExecuteNonQuery()

                .CommandText = "delete from hris_allowance where employeeid='" & depositid & "'"
                .Connection = con
                .CommandType = CommandType.Text
                .ExecuteNonQuery()

                .CommandText = "delete from hris_paysetup where employeeid='" & depositid & "'"
                .Connection = con
                .CommandType = CommandType.Text
                .ExecuteNonQuery()
            End If
            .CommandText = "insert into `hris_requirements` (`employeeid`,`ok`,`requirement`,`requirementid`)" & _
                " values " & saveorders2(depositid, Me.RequirementGrid)
            .Connection = con
            .CommandType = CommandType.Text
            .ExecuteNonQuery()

            .CommandText = "insert into `hris_allowance` (`employeeid`,`allowanceid`,`amount`,`active`,`remarks`,`creator`)" & _
                " values " & saveorders3(depositid, Me.AllowanceGrid)
            .Connection = con
            .CommandType = CommandType.Text
            .ExecuteNonQuery()


            .CommandText = "insert into `hris_paysetup` (`employeeid`,`payid`,`amount`,`active`,`remarks`,`creator`)" & _
                " values " & saveorders4(depositid, Me.PaySetUpGrid)
            .Connection = con
            .CommandType = CommandType.Text
            .ExecuteNonQuery()

            ' .CommandText = "insert into `hris_requirements` (`employeeid`,`ok`,`requirement`,`requirementid`)" & _
            '    " values " & saveorders2(depositid, Me.RequirementGrid)
            '.Connection = con
            '.CommandType = CommandType.Text
            '.ExecuteNonQuery()

            mytrans.Commit()
            .Dispose()
            con.Close()
            If tosave = False Then showMessage("Click OK to continue", "The record has been successfully saved.", "Successfully saved", 2)
            Me.tosave = False
            Me.employeeid = depositid
            Return True
            Exit Function
        End With

        ' Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        '   Try
        'mytrans.Rollback()
        'Catch ex1 As MySqlException
        '   If Not mytrans.Connection Is Nothing Then
        '  End If
        'End Try
        'Return False
        ' End Try
    End Function
    Private Function saveorders2(ByVal id As Integer, ByVal flexgrid As C1.Win.C1FlexGrid.C1FlexGrid) As String
        Dim z11 As String = ""
        Try
            Dim x As Integer = 1
            Dim y As Integer = flexgrid.Rows.Count - 1
            For x = 1 To y
                With flexgrid.Rows(x)
                    If .Item("requirement") = Nothing Then Continue For
                    Dim oks As Integer = 0
                    If .Item("ok") = True Then oks = 1 Else oks = 0
                    z11 = z11 & " " & "('" & id & _
                        "', '" & oks & _
                        "', '" & .Item("requirement") & _
                        "', '" & .Item("requirementid") & _
                        "')            "

                End With
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return LTrim(RTrim(z11)).Replace("            ", ",")
    End Function
    Private Function saveorders3(ByVal id As Integer, ByVal flexgrid As C1.Win.C1FlexGrid.C1FlexGrid) As String
        Dim z11 As String = ""
        Try
            Dim x As Integer = 1
            Dim y As Integer = flexgrid.Rows.Count - 1
            For x = 1 To y
                With flexgrid.Rows(x)
                    z11 = z11 & " " & "('" & id & _
                        "', '" & .Item("Allowanceid") & _
                        "', '" & .Item("Amount") & _
                        "', '" & toint(.Item("active")) & _
                           "', '" & .Item("remarks") & _
                            "', '" & APCESMainForm.UserFullName.Text & _
                        "')            "

                End With
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Return LTrim(RTrim(z11)).Replace("            ", ",")
    End Function
    Private Function saveorders4(ByVal id As Integer, ByVal flexgrid As C1.Win.C1FlexGrid.C1FlexGrid) As String
        Dim z11 As String = ""
        Try
            Dim x As Integer = 1
            Dim y As Integer = flexgrid.Rows.Count - 1
            For x = 1 To y
                With flexgrid.Rows(x)
                    z11 = z11 & " " & "('" & id & _
                        "', '" & .Item("payid") & _
                        "', '" & .Item("Amount") & _
                        "', '" & toint(.Item("active")) & _
                           "', '" & .Item("remarks") & _
                            "', '" & APCESMainForm.UserFullName.Text & _
                        "')            "
                End With
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return LTrim(RTrim(z11)).Replace("            ", ",")
    End Function
    Private Sub RibbonButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.DoubleClick
        Try
            With DlgOpenFile
                .ShowReadOnly = True
                .Title = "Browse the  Image file. (jpg format is not valid)"
                .Filter = "Image File|*.png; *.jpg; *.gif; *.tiff; *.tif"
                .ShowDialog()
                Me.PictureBox1.Load(.FileName)
                ImageLocation = .FileName
                picedit = True
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            picedit = False
        End Try
    End Sub

    Private Sub CloseForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseForm.Click
        Me.Close()
    End Sub

    Private Sub NewAddress_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewAddress.Click, updateaddress.Click
        Try
            Dim x As New HRIS_EmployeeRegistration_Address(0)
            With x
                .EmployeeName.SelectedValue = employeeid
                .ShowDialog()
                .StartPosition = FormStartPosition.CenterScreen
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub EditAddress_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditAddress.Click
        Try
            Dim id As Integer = Me.ResidenceGrid.Rows(Me.ResidenceGrid.RowSel).Item("ID")
            Dim x As New HRIS_EmployeeRegistration_Address(id)
            With x
                .ShowDialog()
                .StartPosition = FormStartPosition.CenterScreen
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub AddressRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddressRefresh.Click
        FunctionClass.loadtoGrid3("HRIS_GRID_hris_employee_addresses", Me.employeeid, Me.ResidenceGrid)
        Me.addresstotal.Text = Me.ResidenceGrid.Rows.Count - 1
    End Sub
    Private Sub DeleteAddress_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteAddress.Click
        Dim id As Integer = Me.ResidenceGrid.Rows(Me.ResidenceGrid.RowSel).Item("ID")
        Dim x As New HRIS_EmployeeRegistration_Address(id)
        Dim i As String = MessageBox.Show("Are you want to delete the selected address?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If i = vbYes Then
            saveEditDelete("Delete from hris_address where addressid='" & id & "'", "deleted.")
        End If
    End Sub

    Private Sub NewDependent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewDependent.Click, updatedependent.Click
        Try
            Dim x As New HRIS_EmployeeRegistration_Dependent(0)
            With x
                .EmployeeName.SelectedValue = employeeid
                .ShowDialog()
                .StartPosition = FormStartPosition.CenterScreen
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub EditDependent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditDependent.Click
        Try
            Dim id As Integer = Me.dependentsGrid.Rows(Me.dependentsGrid.RowSel).Item("ID")
            Dim x As New HRIS_EmployeeRegistration_Dependent(id)
            With x
                .ShowDialog()
                .StartPosition = FormStartPosition.CenterScreen
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DeleteDependent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteDependent.Click
        Dim id As Integer = Me.dependentsGrid.Rows(Me.dependentsGrid.RowSel).Item("ID")
        Dim x As New HRIS_EmployeeRegistration_Dependent(id)
        Dim i As String = MessageBox.Show("Are you want to delete the selected dependents?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If i = vbYes Then
            saveEditDelete("Delete from hris_dependents where dependentid='" & id & "'", "deleted.")
        End If
    End Sub

    Private Sub DependenceRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DependenceRefresh.Click
        FunctionClass.loadtoGrid3("HRIS_GRID_hris_employee_dependents", Me.employeeid, Me.DependentsGrid)
        Me.dependentstotal.Text = Me.DependentsGrid.Rows.Count - 1
    End Sub


    Private Sub TimeSheetApproval_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TimeSheetApproval.Validated
        Me.OvertimeApproval.SelectedValue = TimeSheetApproval.SelectedValue
    End Sub

    Private Sub Neweducation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewEducation.Click, updateeducation.Click
        Try
            Dim x As New HRIS_EmployeeRegistration_Education(0)
            With x
                .EmployeeName.SelectedValue = employeeid
                .ShowDialog()
                .StartPosition = FormStartPosition.CenterScreen
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Editeducation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditEducation.Click
        Try
            Dim id As Integer = Me.educationGrid.Rows(Me.educationGrid.RowSel).Item("ID")
            Dim x As New HRIS_EmployeeRegistration_education(id)
            With x
                .ShowDialog()
                .StartPosition = FormStartPosition.CenterScreen
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Deleteeducation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteEducation.Click
        Dim id As Integer = Me.educationGrid.Rows(Me.educationGrid.RowSel).Item("ID")
        Dim i As String = MessageBox.Show("Are you want to delete the selected education?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If i = vbYes Then
            saveEditDelete("Delete from hris_educationalattainment where educationid='" & id & "'", "deleted.")
        End If
    End Sub

    Private Sub educationRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EducationRefresh.Click
        FunctionClass.loadtoGrid3("HRIS_GRID_hris_employee_education", Me.employeeid, Me.EducationGrid)
        Me.educationtotal.Text = Me.EducationGrid.Rows.Count - 1
    End Sub

    Private Sub Newtraining_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewTraining.Click, updatetraining.Click
        Try
            Dim x As New HRIS_EmployeeRegistration_Training(0)
            With x
                .EmployeeName.SelectedValue = employeeid
                .ShowDialog()
                .StartPosition = FormStartPosition.CenterScreen
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Edittraining_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditTraining.Click
        Try
            Dim id As Integer = Me.trainingGrid.Rows(Me.trainingGrid.RowSel).Item("ID")
            Dim x As New HRIS_EmployeeRegistration_training(id)
            With x
                .ShowDialog()
                .StartPosition = FormStartPosition.CenterScreen
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Deletetraining_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteTraining.Click
        Dim id As Integer = Me.trainingGrid.Rows(Me.trainingGrid.RowSel).Item("ID")
        Dim i As String = MessageBox.Show("Are you want to delete the selected training?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If i = vbYes Then
            saveEditDelete("Delete from hris_training where trainingid='" & id & "'", "deleted.")
        End If
    End Sub

    Private Sub TrainingRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrainingRefresh.Click
        FunctionClass.loadtoGrid3("HRIS_GRID_hris_employee_training", Me.employeeid, Me.TrainingGrid)
        Me.trainingtotal.Text = Me.TrainingGrid.Rows.Count - 1
    End Sub

    Private Sub Newemployment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewEmployment.Click, updateemployment.Click
        Try
            Dim x As New HRIS_EmployeeRegistration_EmploymentHistory(0)
            With x
                .EmployeeName.SelectedValue = employeeid
                .ShowDialog()
                .StartPosition = FormStartPosition.CenterScreen
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Editemployment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditEmployment.Click
        Try
            Dim id As Integer = Me.employmentGrid.Rows(Me.employmentGrid.RowSel).Item("ID")
            Dim x As New HRIS_EmployeeRegistration_EmploymentHistory(id)
            With x
                .ShowDialog()
                .StartPosition = FormStartPosition.CenterScreen
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Deleteemployment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteEmployment.Click
        Dim id As Integer = Me.employmentGrid.Rows(Me.employmentGrid.RowSel).Item("ID")
        Dim i As String = MessageBox.Show("Are you want to delete the selected employment?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If i = vbYes Then
            saveEditDelete("Delete from hris_employmenthistory where employmentid='" & id & "'", "deleted.")
        End If
    End Sub

    Private Sub employmentRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmploymentRefresh.Click
        FunctionClass.loadtoGrid3("HRIS_GRID_hris_employee_employment", Me.employeeid, Me.EmploymentGrid)
        Me.employmentotal.Text = Me.EmploymentGrid.Rows.Count - 1
    End Sub

    Private Sub NewMemo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim x As New HRIS_EmployeeRegistration_ViolationRegistration(0)
            With x
                .EmployeeName.SelectedValue = employeeid
                .ShowDialog()
                .StartPosition = FormStartPosition.CenterScreen
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub EditMemo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim id As Integer = Me.MemoGrid.Rows(Me.MemoGrid.RowSel).Item("ID")
            Dim x As New HRIS_EmployeeRegistration_ViolationRegistration(id)
            With x
                .ShowDialog()
                .StartPosition = FormStartPosition.CenterScreen
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DeleteMemo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim id As Integer = Me.MemoGrid.Rows(Me.MemoGrid.RowSel).Item("ID")
        Dim i As String = MessageBox.Show("Are you want to delete the selected Memo?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If i = vbYes Then
            saveEditDelete("Delete from hris_Memo where Memoid='" & id & "'", "deleted.")
        End If
    End Sub

    Private Sub MemoRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FunctionClass.loadtoGrid3("HRIS_GRID_hris_employee_Memo", Me.employeeid, Me.MemoGrid)
        Me.memototal.Text = Me.MemoGrid.Rows.Count - 1
    End Sub

    Private Sub PrintCreditMemo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintCreditMemo.Click
        Try
            Dim x As New reportpreview1
            With x
                .print("Reporting_EmployeeProfile", "id", Me.employeeid, 1)
                .Show()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim id As Integer = Me.MemoGrid.Rows(Me.MemoGrid.RowSel).Item("ID")
            Dim x As New reportpreview1
            With x
                .print("reporting_employeememo", "id", id, 3)
                .Show()
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BankAccount_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles BankAccount.Validated

    End Sub

    Private Sub NewOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewOrder.Click
        clear()
    End Sub
#Region "Compute Deduction"
    Private Sub BasicPayMonthly_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles BasicSalary.Validated, LegalAllowance.Validated
        'COMPUTE ALL DATA REQUIRED HERE....
        BasicPayHourly.Value = 0
        compute()
    End Sub
    Private Sub HiddenAllowance_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles HiddenAllowance.Validated
        HiddenAllowanceRate.Value = 0
        compute()
    End Sub
    Private Sub MonthlyHours_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MonthlyHours.Validated
        HiddenAllowanceRate.Value = 0
        BasicPayHourly.Value = 0
        compute()
    End Sub
    Private Sub deductphic_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles deductphic.CheckedChanged, deductsss.CheckedChanged, deducttax.CheckedChanged, deducthdmf.CheckedChanged
        compute()
    End Sub
    Private Sub MonthlyPay_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MonthlyPay.Validated
        If tosave = True Then
            Me.BasicSalary.Value = MonthlyPay.Value
            compute()
        Else
            compute()
        End If
    End Sub
    Private Sub HDMFEEShare_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles HDMFEEShare.Validated, SSSEEShare.Validated, PHICEEShare.Validated
        computemandatory()
    End Sub
    Public Sub payrollgroup_Validated() Handles payrollgroup.Validated
        loadearningsandincome()
    End Sub
   
    Public Sub loadearningsandincome()
        Try
            If Me.payrollgroup.Text = "WEEKLY" Then
                FunctionClass.loadtoGrid("Select payid, active, paytype, Amount, PayRate, remarks from companypayrollsetup where companyid = '" & companyid & "' and active=1 and weekly=1 order by `order` asc", PaySetUpGrid)
            ElseIf Me.payrollgroup.Text = "SEMI-MONTHLY" Then
                FunctionClass.loadtoGrid("Select payid, active, paytype, Amount, PayRate, remarks from companypayrollsetup where companyid = '" & companyid & "' and active=1 and semimonthly=1 order by `order` asc", PaySetUpGrid)
            ElseIf Me.payrollgroup.Text = "MONTHLY" Then
                FunctionClass.loadtoGrid("Select payid, active, paytype, Amount, PayRate, remarks from companypayrollsetup where companyid = '" & companyid & "' and active=1 and semimonthly=1 order by `order` asc", PaySetUpGrid)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub compute()
        Try

            basicsemimonthly = 0 : basicdaily = 0
            Dim salary As Double = 0
            Dim monthlypayxy As Double = 0
            monthlypayxy = MonthlyPay.Value
            salary = Me.BasicSalary.Value


        If salary = 0 Then basicsemimonthly = 0 Else basicsemimonthly = Val(salary) / 2
        If salary = 0 Then basicdaily = 0 Else basicdaily = Val(salary) / 26
        If salary = 0 Then BasicPay.Value = 0 Else BasicPay.Value = Me.BasicSalary.Value
        If LegalAllowance.Value = 0 Then Exception.Value = 0 Else Exception.Value = LegalAllowance.Value

            Me.BasicPayHourly.Value = Val(salary) / Me.MonthlyHours.Value
            Me.HiddenAllowanceRate.Value = HiddenAllowance.Value / MonthlyHours.Value


        GrossPay.Value = Me.BasicSalary.Value + HiddenAllowance.Value

        'If HiddenAllowance.Value = 0 then HiddenAllowanceRate.Value = 0 else val(hiddenAllowanceRate.Value)/208

            ssscompute(monthlypayxy)
            phiccompute(monthlypayxy)
            If tosave = False Then
                If HDMFEEShare.Value = 0 Then hdmfcompute(monthlypayxy)
            Else
                hdmfcompute(monthlypayxy)
            End If



            Me.Mandatory.Value = SSSEEShare.Value + PHICEEShare.Value + HDMFEEShare.Value
            Me.Exception.Value = Me.LegalAllowance.Value
            Me.TaxableIncome.Value = Me.BasicPay.Value - Exception.Value - Mandatory.Value
            Me.wtax.Value = FunctionClass.GetWTAX(Val(TaxableIncome.Value), "MONTHLY")

            If ChargetoCompany.Checked = True Then
                Me.NetPay.Value = Me.GrossPay.Value - Mandatory.Value
            Else
                Me.NetPay.Value = Me.GrossPay.Value - Mandatory.Value - Me.wtax.Value
            End If
            loaddeductions()
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub computemandatory()
        Me.Mandatory.Value = SSSEEShare.Value + PHICEEShare.Value + HDMFEEShare.Value
        Me.TaxableIncome.Value = Me.BasicPay.Value - Exception.Value - Mandatory.Value
        Me.wtax.Value = FunctionClass.GetWTAX(Val(TaxableIncome.Value), "MONTHLY")
    End Sub
    Public Sub ssscompute(ByVal a As Double)
        Dim sssee, ssser As Double
        connect()
        con.Open()
        command = New MySqlCommand
        With command
            .CommandText = "Select b.ee as EE, b.ertotal as ertotal from  ssstable b where '" & a & "' between b.rangefrom and b.rangeto"
            .Connection = con
            reader = .ExecuteReader
        End With

        If reader.Read = True Then
            sssee = reader.Item("EE")
            ssser = reader.Item("ERTotal")
        End If
        reader.Close()
        command.Dispose()
        con.Close()

        SSSEEShare.Value = sssee
        SSSER_Share = ssser

    End Sub
    Public Sub phiccompute(ByVal a As Double)
        Try
            Dim phicee, phicer As Double
            connect()
            con.Open()
            command = New MySqlCommand
            With command
                .CommandText = "Select (case when b.compute = 1 then '" & a & "' * b.EEShare else b.eeshare end) as EE,(case when b.compute = 1 then '" & a & "' * b.ErShare else b.ershare end) as Er" & _
                " from phictable b where '" & a & "' between b.rangefrom and b.rangeto"
                .Connection = con
                reader = .ExecuteReader
            End With

            If reader.Read = True Then
                phicee = reader.Item("EE")
                phicer = reader.Item("ER")
            End If
            reader.Close()
            command.Dispose()
            con.Close()

            PHICEEShare.Value = phicee
            PHICER_Share = phicer
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub hdmfcompute(ByVal a As Double)
        Try
            Dim hdmfee, hdmfer As Double
            connect()
            con.Open()
            command = New MySqlCommand
            With command
                .CommandText = "Select (case when b.compute = 1 then b.salarycredit * b.hdmfee else b.hdmfee end) as EE, (case when b.compute = 1 then b.salarycredit * b.hdmfer else b.hdmfer end)  as Er from  hdmftable b where '" & a & "' between b.rangefrom and b.rangeto "
                .Connection = con
                reader = .ExecuteReader
            End With

            If reader.Read = True Then
                hdmfee = reader.Item("ee")
                hdmfer = reader.Item("er")

            End If
            reader.Close()
            command.Dispose()
            con.Close()
          
                HDMFEEShare.Value = hdmfee
                HDMFER_Share = hdmfee


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub loaddeductions()
        Try
            Dim x As Integer = 1
            Dim y As Integer = PaySetUpGrid.Rows.Count - 1
            For x = 1 To y
                With PaySetUpGrid.Rows(x)
                    If .Item("Paytype") = "SSS" Then
                        If Me.deductsss.Checked = True Then .Item("Amount") = Me.SSSEEShare.Value Else .Item("Amount") = 0
                    ElseIf .Item("Paytype") = "PHIC" Then
                        If Me.deductphic.Checked = True Then .Item("Amount") = Me.PHICEEShare.Value Else .Item("Amount") = 0
                    ElseIf .Item("Paytype") = "HDMF" Then
                        If Me.deducthdmf.Checked = True Then .Item("Amount") = Me.HDMFEEShare.Value Else .Item("Amount") = 0
                    ElseIf .Item("Paytype") = "WTAX" Then
                        If Me.deducttax.Checked = True Then .Item("Amount") = Me.wtax.Value Else .Item("Amount") = 0
                    End If
                End With
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

    Private Sub LastName_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles LastName.Validated
        If tosave = True Then
            saverecord_click()
        End If
    End Sub

 
   
End Class