Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Public Class HRIS_EmployeeRegistration_Training
    Private tosave As Boolean = True
    Private TrainingID As Integer = 0
    Sub New(ByVal id As Integer)

        ' This call is required by the designer.
        InitializeComponent()
        loadingvaluestoComboBoxes_StoredProc("Combo_Employees_ActiveOnly", Me.EmployeeName, "Employee", "EmployeeID")
        'loadingvaluestoComboBoxes_StoredProc("Combo_EducationalAttainment_ActiveOnly", Me.Attainment, "attainment", "attainment")
        If id = 0 Then Exit Sub
        loaddata("Select * from HRIS_Training Where TrainingID=" & id)
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
                Me.TrainingID = .Item("TrainingID")
                Me.Conductedby.Text = .Item("ConductedBy")
                Me.DateFrom.Value = .Item("date_from")
                Me.NameOfSchool.Text = .Item("coursename")
                Me.DateTo.Value = .Item("date_to")
                Me.No_of_hours.Value = .Item("noofhours")
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
            TrainingID = searchRecord("SELECT AUTO_INCREMENT FROM Information_schema.tables where  table_schema='" & database & "' and table_name='HRIS_Training';", 1)
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
                .CommandText = "HRIS_Training_Execute"
                .Connection = con
                .CommandType = CommandType.StoredProcedure
                With .Parameters
                    .AddWithValue("@TrainingIDs", Me.TrainingID)
                    .AddWithValue("@EmployeeIDs", Me.EmployeeName.SelectedValue)
                    .AddWithValue("@coursenames", Me.NameOfSchool.Text.ToUpper)
                    .AddWithValue("@datefroms", Me.DateFrom.Value)
                    .AddWithValue("@datetos", Me.DateTo.Value)
                    .AddWithValue("@NoOfHourss", Me.No_of_hours.Value)
                    .AddWithValue("@Conductedbys", Me.Conductedby.Text.ToUpper)
                    .AddWithValue("@Remarkss", Me.Remarks.Text.ToUpper)
                    .AddWithValue("@tosave", Me.tosave)
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
        Me.TrainingID = 0
        Me.tosave = False
    End Sub

End Class
