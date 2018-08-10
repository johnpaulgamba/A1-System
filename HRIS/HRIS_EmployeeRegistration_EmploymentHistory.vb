Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Imports A1plus.FunctionClass
Public Class HRIS_EmployeeRegistration_EmploymentHistory
    Private tosave As Boolean = True
    Private employmentid As Integer = 0
    Sub New(ByVal id As Integer)

        ' This call is required by the designer.
        InitializeComponent()
        loadingvaluestoComboBoxes_StoredProc("Combo_Employees_ActiveOnly", Me.EmployeeName, "Employee", "EmployeeID")
        'loadingvaluestoComboBoxes_StoredProc("HRIS_COMBOBOX_Positions", Me.Position, "Position", "Position")
        ' loadingvaluestoComboBoxes_StoredProc("HRIS_COMBOBOX_BusinessNature", Me.Nature_Of_Business, "BusinessNature", "BusinessNature")
        If id = 0 Then clear() Else loaddata("Select * from hris_employmenthistory Where employmentID=" & id)
    End Sub
    Public Sub clear()
        FunctionClass.ClearPanel(Me.C1InputPanel1)
        Me.employmentid = 0
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
                Me.employmentid = .Item("employmentID")
                Me.Employeer.Text = .Item("Employeer")
                Me.ContactNo.Text = .Item("ContactNo")
                'Me.Duties.Text = .Item("Duties")
                Me.Period_To.Value = .Item("Period_To")
                Me.Period_From.Value = .Item("Period_From")
                Me.StartSalary.Value = .Item("StartSalary")
                Me.EndSalary.Value = .Item("EndSalary")
                Me.Position.Text = .Item("Position")
                ' Me.Nature_Of_Business.Text = .Item("Nature_Of_Business")
                Me.Address.Text = .Item("Address")
                ' Me.Reason_For_Leaving.Text = .Item("Reason_For_Leaving")
                ' Me.Remarks.Text = .Item("remarks")
                Me.tosave = False
                Me.EmployeeName.SelectedValue = .Item("EmployeeID")
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub SaveCommandButton_Click(sender As System.Object, e As System.EventArgs) Handles SaveCommandButton.Click
        If tosave = True Then
            employmentid = searchRecord("SELECT AUTO_INCREMENT FROM Information_schema.tables where  table_schema='" & database & "' and table_name='hris_employee_employment';", 1)
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
                .CommandText = "HRIS_EmploymentHistory_Execute"
                .Connection = con
                .CommandType = CommandType.StoredProcedure
                With .Parameters
                    .AddWithValue("@Employeers", Me.Employeer.Text.ToUpper)
                    .AddWithValue("@Positions", Me.Position.Text.ToUpper)
                    .AddWithValue("@Occupations", "")
                    .AddWithValue("@ContactNos", Me.ContactNo.Text)
                    .AddWithValue("@Nature_Of_Businesss", "")
                    .AddWithValue("@Period_Froms", Me.Period_From.Value)
                    .AddWithValue("@Period_Tos", Me.Period_To.Value)
                    .AddWithValue("@Start_Salarys", Me.StartSalary.Value)
                    .AddWithValue("@End_Salarys", Me.EndSalary.Value)
                    .AddWithValue("@Dutiess", "")
                    .AddWithValue("@Addresss", Me.Address.Text.ToUpper)
                    .AddWithValue("@Remarkss", "")
                    .AddWithValue("@tosave", Me.tosave)
                    .AddWithValue("Reason_For_leavings", "")
                    .AddWithValue("@employmentIDs", Me.employmentid)
                    .AddWithValue("@Creators", APCESMainForm.UserFullName.Text.ToUpper)
                    .AddWithValue("@DateCreateds", "" & Now)
                    .AddWithValue("@EmployeeIDs", Me.EmployeeName.SelectedValue)
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
    Private Sub InputButton4_Click(sender As System.Object, e As System.EventArgs) Handles InputButton4.Click
        Me.Close()
    End Sub
    Private Sub InputButton2_Click(sender As System.Object, e As System.EventArgs) Handles InputButton2.Click
        clear()
    End Sub

End Class
