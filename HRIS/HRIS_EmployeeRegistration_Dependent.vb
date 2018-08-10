Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Public Class HRIS_EmployeeRegistration_Dependent
    Private tosave As Boolean = True
    Private dependentid As Integer = 0
    Sub New(ByVal id As Integer)

        ' This call is required by the designer.
        InitializeComponent()
        loadingvaluestoComboBoxes_StoredProc("Combo_Employees_Activeonly", Me.EmployeeName, "Employee", "EmployeeID")
        'loadingvaluestoComboBoxes_StoredProc("", Me.Occupation, "Position", "PositionID")
        loadingvaluestoComboBoxes_StoredProc("Combo_Gender_Activeonly", Me.Gender, "Gender", "Gender")
        'loadingvaluestoComboBoxes_StoredProc("HRIS_COMBOBOX_Relationship", Me.RelationShip, "Relationship", "Relationship")
        If id = 0 Then Exit Sub
        loaddata("Select * from hris_dependents Where DependentID=" & id)
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
                Me.dependentid = .Item("DependentID")
                Me.EmployeeName.SelectedValue = .Item("EmployeeID")
                Me.DependentName.Text = .Item("DependentName")
                Me.RelationShip.Text = .Item("RelationShip")
                Me.Occupation.Text = .Item("Occupation")
                Me.Gender.Text = .Item("Gender")
                Me.Birthdate.Value = .Item("Birthdate")
                Me.Address.Text = .Item("Address")
                Me.Remarks.Text = .Item("remarks")
                Me.EmergencyContact.Checked = .Item("isEmergencyContact")
                Me.Active.Checked = .Item("Active")
                Me.tosave = False

            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub SaveCommandButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveCommandButton.Click
        If tosave = True Then
            dependentid = searchRecord("SELECT AUTO_INCREMENT FROM Information_schema.tables where  table_schema='" & database & "' and table_name='hris_dependents';", 1)
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
                .CommandText = "HRIS_DEPENDENTS_Execute"
                .Connection = con
                .CommandType = CommandType.StoredProcedure
                With .Parameters
                    .AddWithValue("@EmployeeIDs", Me.EmployeeName.SelectedValue)
                    .AddWithValue("@DependentNames", Me.DependentName.Text.ToUpper)
                    .AddWithValue("@Relationships", Me.RelationShip.Text.ToUpper)
                    .AddWithValue("@Occupations", Me.Occupation.Text.ToUpper)
                    .AddWithValue("@Genders", Me.Gender.Text.ToUpper)
                    .AddWithValue("@Birthdates", Me.Birthdate.Value)
                    .AddWithValue("@Addresss", Me.Address.Text.ToUpper)
                    .AddWithValue("@Remarkss", Me.Remarks.Text.ToUpper)
                    .AddWithValue("@isEmergencyContacts", Me.EmergencyContact.Checked)
                    .AddWithValue("@Actives", Me.Active.Checked)
                    .AddWithValue("@tosave", Me.tosave)
                    .AddWithValue("@DependentIDs", Me.dependentid)
                    .AddWithValue("@CreatorS", APCESMainForm.UserFullName.Text.ToUpper)
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

    Private Sub Birthdate_ValueChanged(sender As System.Object, e As System.EventArgs) Handles Birthdate.ValueChanged
        Try
            If CInt(DateDiff(DateInterval.Day, Me.Birthdate.Value, Now) / 365) < 0 Then
                Me.Age.Value = 0
            Else
                Me.Age.Value = CInt(DateDiff(DateInterval.Day, Me.Birthdate.Value, Now) / 365)
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub InputButton4_Click(sender As System.Object, e As System.EventArgs) Handles InputButton4.Click
        Me.Close()
    End Sub

    Private Sub InputButton2_Click(sender As System.Object, e As System.EventArgs) Handles InputButton2.Click
        FunctionClass.ClearPanel(Me.C1InputPanel1)
        'Me.DependentName.Text = Nothing
        Me.Active.Checked = True
        Me.EmergencyContact.Checked = False
        Me.dependentid = 0
        Me.tosave = False
    End Sub
End Class
