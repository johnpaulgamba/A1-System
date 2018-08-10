Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Public Class HRIS_EmployeeRegistration_Education
    Private tosave As Boolean = True
    Private educationID As Integer = 0
    Sub New(ByVal id As Integer)

        ' This call is required by the designer.
        InitializeComponent()
        loadingvaluestoComboBoxes_StoredProc("Combo_Employees_ActiveOnly", Me.EmployeeName, "Employee", "EmployeeID")
        loadingvaluestoComboBoxes_StoredProc("Combo_EducationalAttainment_ActiveOnly", Me.Attainment, "attainment", "attainment")
        If id = 0 Then Exit Sub
        loaddata("Select * from hris_educationalattainment Where educationID=" & id)
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
                Me.educationID = .Item("educationID")
                Me.NameOfSchool.Text = .Item("NameOfSchool")
                Me.Attainment.Text = .Item("Attainment")
                Me.Period_From.Value = .Item("Period_from")
                Me.Address.Text = .Item("address")
                Me.Period_To.Value = .Item("Period_To")
                Me.Remarks.Text = .Item("remarks")
                Me.tosave = False
                Me.EmployeeName.SelectedValue = .Item("EmployeeID")
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub SaveCommandButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveCommandButton.Click
        If tosave = True Then
            educationID = searchRecord("SELECT AUTO_INCREMENT FROM Information_schema.tables where  table_schema='" & database & "' and table_name='hris_educationalattainment';", 1)
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
                .CommandText = "HRIS_EducationalAttainment_Execute"
                .Connection = con
                .CommandType = CommandType.StoredProcedure
                With .Parameters
                    .AddWithValue("@EmployeeIDs", Me.EmployeeName.SelectedValue)
                    .AddWithValue("@NameOfSchools", Me.NameOfSchool.Text.ToUpper)
                    .AddWithValue("@Addresss", Me.Address.Text.ToUpper)
                    .AddWithValue("@Attainments", Me.Attainment.Text.ToUpper)
                    .AddWithValue("@Remarkss", Me.Remarks.Text.ToUpper)
                    .AddWithValue("@tosave", Me.tosave)
                    .AddWithValue("@Period_Tos", Me.Period_To.Value)
                    .AddWithValue("@Period_Froms", Me.Period_From.Value)
                    .AddWithValue("@educationIDs", Me.educationID)
                    .AddWithValue("@actives", Me.Active.Checked)
                    .AddWithValue("@CreatorS", APCESMainForm.UserFullName.Text.ToUpper)
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

    Private Sub InputButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputButton4.Click
        Me.Close()
    End Sub

    Private Sub InputButton2_Click(sender As System.Object, e As System.EventArgs) Handles InputButton2.Click
        FunctionClass.ClearPanel(Me.C1InputPanel1)
        Me.educationID = 0
        Me.tosave = False
    End Sub

End Class
