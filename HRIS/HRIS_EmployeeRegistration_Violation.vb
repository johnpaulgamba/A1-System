Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Imports A1plus.FunctionClass
Public Class HRIS_EmployeeRegistration_ViolationRegistration
    Private tosave As Boolean
    Private ticketid As Integer = 0
    Private noofdays As Integer = 0
    Sub New(ByVal id As Integer)
        ' This call is required by the designer.
        InitializeComponent()
        loadingvaluestoComboBoxes_StoredProc("Combo_Employees_ActiveOnly", Me.EmployeeName, "Employee", "EmployeeID")
        loadingvaluestoComboBoxes_StoredProc("Combo_GeneralViolation_Activeonly", GeneralViolation, "GeneralViolation", "GeneralViolation")
        loadingvaluestoComboBoxes_StoredProc("Combo_Violations_Activeonly", violation, "violationdetails", "violationid")
        loadingvaluestoComboBoxes_StoredProc("Combo_EmployeesLevelA_ActiveOnly", Approvedby1, "Employee", "Position")
        loadingvaluestoComboBoxes_StoredProc("Combo_EmployeesLevelA_ActiveOnly", Approvedby2, "Employee", "Position")
        ' loadingvaluestoComboBoxes_StoredProc("Combo_EmployeesLevelA_ActiveOnly", IssuedBy, "Employee", "Position")
        'loadingvaluestoComboBoxes_StoredProc("HRIS_COMBOBOX_Positions", Me.Position, "Position", "Position")
        ' loadingvaluestoComboBoxes_StoredProc("HRIS_COMBOBOX_BusinessNature", Me.Nature_Of_Business, "BusinessNature", "BusinessNature")
        If id = 0 Then clear() Else loaddata("Select a.*,concat(d.LastName,', ',d.FirstName,' ',d.MiddleName) as Employee, " & _
   "b.ViolationType,b.ViolationDetails from hris_violationticket a join hris_violation_setup b on " & _
    "a.violationid=b.violationid join hris_employee d Where a.ticketid=" & id)
        ' Dim week As Integer = CDate("11/05/2018").Day / 7
        'MessageBox.Show(CDate("11/05/2018").Day & " " & week)
    End Sub
    Public Sub clear()

        FunctionClass.ClearPanel(Me.C1InputPanel1)
        Me.TicketNo.Text = searchRecord("SELECT AUTO_INCREMENT FROM Information_schema.tables where  table_schema='" & database & "' and table_name='hris_violationticket';", 1)
        Me.ViolationDate.Value = Now
        Me.DateServed.Value = Now
        Me.Status.Text = "OPEN"
        ' Me.SuspensionFrom.Value = Now
        Me.tosave = True
    End Sub
    Private Sub loaddata(ByVal sql As String)
        Try
            connect()
            con.Open()
            Dim ds As New DataSet
            Dim adapter As New MySqlDataAdapter(sql, con)
            With adapter
                .Fill(ds)
                .Dispose()
            End With
            With ds.Tables(0).Rows(0)
                Me.EmployeeName.SelectedValue = .Item("EmployeeID")
                Me.ticketid = .Item("ticketid")
                Me.TicketNo.Text = .Item("ticketno")
                Me.ViolationDate.Value = .Item("violationdate")
                Me.GeneralViolation.Text = .Item("violationtype")
                Me.violation.SelectedValue = .Item("violationid")
                Me.Status.Text = .Item("status")
                Me.DateServed.Value = .Item("datereceived")
                'Me.Subject.Text = .Item("memoSubject")
                'Me.Details.Text = .Item("memoDetails")
                'Me.SuspensionFrom.Value = .Item("suspensionfrom")
                'Me.SuspensionTo.Value = .Item("suspensionto")
                Me.IssuedBy.Text = .Item("issuedby")
                Me.ApprovedBy1.Text = .Item("approvedby1")
                Me.Approvedby2.Text = .Item("approvedby2")

                Me.Explanation.Text = .Item("explanation")
                Me.tosave = False
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub SaveCommandButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveJobOrder.Click
        If Me.EmployeeName.SelectedIndex = -1 Then MessageBox.Show("Invalid employee name", "Employee name is null", MessageBoxButtons.OK, MessageBoxIcon.Stop) : Exit Sub
        If Me.violation.SelectedValue = -1 Then MessageBox.Show("Invalid Violation", "Violation Details is null", MessageBoxButtons.OK, MessageBoxIcon.Stop) : Exit Sub

        If tosave = True Then
            ticketid = searchRecord("SELECT AUTO_INCREMENT FROM Information_schema.tables where  table_schema='" & database & "' and table_name='hris_violationticket';", 1)
            savecommand("Created")
        Else
            savecommand("Updated")
        End If

    End Sub
    Private Sub savecommand(ByVal ChangesMAdes As String)
        Try
            connect()
            con.Open()
            Dim command As New MySqlCommand
            With command
                .CommandText = "HRIS_Employee_ViolationTicket_Execute"
                .Connection = con
                .CommandType = CommandType.StoredProcedure
                With .Parameters
                    .AddWithValue("@ticketids", Me.ticketid)
                    .AddWithValue("@violationids", Me.violation.SelectedValue)
                    .AddWithValue("@employeeids", Me.EmployeeName.SelectedValue)
                    .AddWithValue("@violationdates", Me.ViolationDate.Value)
                    .AddWithValue("@ticketnos", Me.TicketNo.Text)
                    .AddWithValue("@datereceiveds", Me.DateServed.Value)
                    .AddWithValue("@issuedbys", Me.IssuedBy.Text.ToUpper)
                    .AddWithValue("@approvedby1s", Me.ApprovedBy1.Text.ToUpper)
                    .AddWithValue("@approvedby2s", Me.Approvedby2.Text.ToUpper)
                    .AddWithValue("@approvedbyposition2s", Me.Approvedby2.SelectedValue)
                    .AddWithValue("@approvedbyposition1s", Me.ApprovedBy1.SelectedValue)
                    .AddWithValue("@explanations", Me.Explanation.Text.ToUpper)
                    .AddWithValue("@statuss", Me.Status.Text.ToUpper)
                    .AddWithValue("@tosave", Me.tosave)
                    .AddWithValue("@Creators", APCESMainForm.UserFullName.Text.ToUpper)
                    .AddWithValue("@DateCreateds", "" & Now)
                    .AddWithValue("@ChangesMAdes", ChangesMAdes & "  on " & Now & " at " & APCESMainForm.ComputerName.Text & " by " & APCESMainForm.UserFullName.Text & vbCrLf & vbCrLf)
                End With
                .ExecuteNonQuery()
            End With
            FunctionClass.showMessage("The record has been successfully saved!", "Command Executed!", "Command executed")
            con.Close()
            command.Dispose()
            Me.tosave = False
        Catch ex As Exception
            FunctionClass.showMessage("Exception found:" & ex.Message, "Contact system admin", "Contact System Admin")
        End Try
    End Sub
    Private Sub InputButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub InputButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewOrder.Click
        clear()
    End Sub
    Private Sub GeneralViolation_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GeneralViolation.SelectedIndexChanged
        Try

            loadingvaluestoComboBoxes("Select concat(violationcode,' ',violationdetails) as violationdetails,violationid from hris_violation_Setup where violationtype='" & GeneralViolation.Text & "'order by violationid asc", violation, "violationdetails", "violationid")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub InputButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim x As New reportpreview1
        With x
            .print("Reporting_EmployeeMemo", "id", Me.ticketid, 3)
            .Show()

        End With
    End Sub

    Private Sub updatedependent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles updatedependent.Click
        Dim x As New HRIS_GeneralViolation
        With x
            .StartPosition = FormStartPosition.CenterScreen
            .ShowDialog()
        End With
        loadingvaluestoComboBoxes_StoredProc("Combo_GeneralViolation_Activeonly", GeneralViolation, "GeneralViolation", "GeneralViolation")
    End Sub
    Private Sub updateaddress_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles updateaddress.Click
        Dim X As New HRIS_PenaltySetUpRegistration
        With X
            .StartPosition = FormStartPosition.CenterScreen
            .ShowDialog()
        End With
    End Sub
    Private Sub updatetraining_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles updatetraining.Click
        Dim x As New HRIS_ViolationSetupRegistration(0)
        With x
            .StartPosition = FormStartPosition.CenterScreen
            .ShowDialog()
        End With
    End Sub
    Private Sub CloseForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseForm.Click
        Me.Close()
    End Sub

    Private Sub PrintCreditMemo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintCreditMemo.Click
        Dim X As New reportpreview1
        With X
            .print("Reporting_EmployeeNoticetoExplain", "id", Me.ticketid, 4)
            .StartPosition = FormStartPosition.CenterScreen
            .ShowDialog()

        End With
    End Sub
End Class
