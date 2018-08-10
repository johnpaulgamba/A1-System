Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Public Class HRIS_EmployeeRegistration_Requirements_SetUp
    Private tosave As Boolean = True
    Private RequirementID As Integer = 0
    Sub New(ByVal id As Integer)
        Try

        InitializeComponent()

        'loadingvaluestoComboBoxes_StoredProc("Combo_Employees_Activeonly", Me.EmployeeName, "Employee", "EmployeeID")
        If id = 0 Then
            CLEAR()
        Else
            loaddata("Select * from HRIS_Requirement_SetUp Where RequirementID=" & id)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
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
                Me.RequirementID = .Item("Requirementid")
                Me.Description.Text = .Item("description")
                Me.Requirement.Text = .Item("Requirement")
                Me.isActive.Checked = .Item("Active")
                Me.tosave = False

            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub SaveCommandButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveCommandButton.Click
        Try


            If tosave = True Then
                RequirementID = searchRecord("SELECT AUTO_INCREMENT FROM Information_schema.tables where  table_schema='" & database & "' and table_name='hris_Requirement_Setup';", 1)
                savecommand("Created")
            Else
                savecommand("Updated")

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub savecommand(ByVal ChangesMAdes As String)
        '  Try
        connect()
        con.Open()
        Dim command As New MySqlCommand
        With command
            .CommandText = "HRIS_Requirement_SetUp_Execute"
            .Connection = con
            .CommandType = CommandType.StoredProcedure
            With .Parameters
                .AddWithValue("@descriptions", Me.Description.Text.ToUpper)
                .AddWithValue("@Requirements", Me.Requirement.Text.ToUpper)
                .AddWithValue("@actives", Me.isActive.Checked)
                .AddWithValue("@tosave", Me.tosave)
                .AddWithValue("@RequirementIDs", Me.RequirementID)
                .AddWithValue("@Creators", APCESMainForm.UserFullName.Text.ToUpper)
                .AddWithValue("@ChangesMAdes", ChangesMAdes & "  on " & Now & " at " & APCESMainForm.ComputerName.Text & " by " & APCESMainForm.UserFullName.Text & vbCrLf & vbCrLf)
            End With
            .ExecuteNonQuery()
        End With
        FunctionClass.showMessage("The record has been successfully saved!", "Command Executed!", "Command executed")
        con.Close()
        command.Dispose()
        Me.tosave = False
        'Catch ex As Exception
        '  FunctionClass.showMessage("Exception found:" & ex.Message, "Contact system admin", "Contact System Admin")
        ' End Try
    End Sub
    Public Sub CLEAR()
        ' FunctionClass.ClearPanel(Me.C1InputPanel1)
        Me.Requirement.Text = Nothing
        Me.Description.Text = Nothing
        Me.isActive.Checked = True
        Me.tosave = True
    End Sub

    Private Sub InputButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputButton4.Click
        Me.Close()
    End Sub

    Private Sub InputButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputButton2.Click
        CLEAR()
    End Sub
End Class
