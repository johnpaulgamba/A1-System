Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Imports C1.Win.C1FlexGrid
Public Class HRIS_ViolationSetupRegistration
    Public tosave As Boolean = True
    Private ViolationID As Integer = 0
    Sub New(ByVal id As Integer)

        ' This call is required by the designer.
        InitializeComponent()
        loadingvaluestoComboBoxes_StoredProc("Combo_GeneralViolation_Activeonly", GeneralViolation, "GeneralViolation", "GeneralViolation")
        If id = 0 Then CLEAR() Else loaddata("Select * from hris_violation_setup where violationid='" & id & "'", id)
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub loaddata(ByVal sql As String, ByVal id As Integer)
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
                Me.ViolationID = .Item("violationid")
                Me.ViolationDetails.Text = .Item("violationdetails")
                Me.ViolationCode.Text = .Item("violationcode")
                Me.GeneralViolation.Text = .Item("violationtype")
                Me.isActive.Checked = .Item("Active")
                Me.tosave = False

            End With
            FunctionClass.loadtoGrid("Select penaltyid,penaltylevel,noofdays from hris_violation_penalty where violationid= '" & id & "'", C1FlexGrid8)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub SaveCommandButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveCommandButton.Click
        Try
            If Me.GeneralViolation.Text = Nothing Then MessageBox.Show("General Violation should not be empty", "", MessageBoxButtons.OK, MessageBoxIcon.Warning) : Exit Sub
            If Me.ViolationDetails.Text = Nothing Then MessageBox.Show("Specific Violation should not be empty", "", MessageBoxButtons.OK, MessageBoxIcon.Warning) : Exit Sub
            If tosave = True Then
                ViolationID = searchRecord("SELECT AUTO_INCREMENT FROM Information_schema.tables where  table_schema='" & database & "' and table_name='hris_Violation_Setup';", 1)
                savecommand("Created")
            Else
                savecommand("Updated")

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub savecommand(ByVal ChangesMAdes As String)
        Dim mytrans As MySqlTransaction
        Try
            connect()
            con.Open()
            mytrans = con.BeginTransaction()
            Dim command As New MySqlCommand
            With command
                .CommandText = "hris_Violation_Setup_Execute"
                .Connection = con
                .CommandType = CommandType.StoredProcedure
                With .Parameters
                    .AddWithValue("@violationdetailss", Me.ViolationDetails.Text.ToUpper)
                    .AddWithValue("@violationcodes", Me.ViolationCode.Text.ToUpper)
                    .AddWithValue("@violationtypes", Me.GeneralViolation.Text.ToUpper)
                    .AddWithValue("@actives", Me.isActive.Checked)
                    .AddWithValue("@tosave", Me.tosave)
                    .AddWithValue("@violationIDs", Me.ViolationID)
                    .AddWithValue("@Creators", APCESMainForm.UserFullName.Text.ToUpper)
                    .AddWithValue("@ChangesMAdes", ChangesMAdes & "  on " & Now & " at " & APCESMainForm.ComputerName.Text & " by " & APCESMainForm.UserFullName.Text & vbCrLf & vbCrLf)
                End With
                .ExecuteNonQuery()

                If tosave = False Then
                    .CommandText = "delete from hris_Violation_penalty where violationid='" & Me.ViolationID & "'"
                    .Connection = con
                    .CommandType = CommandType.Text
                    .ExecuteNonQuery()

                    .CommandText = "insert into `hris_Violation_penalty` (`violationid`,`penaltyid`,`penaltylevel`,`noofdays`,`creator`)" & _
                        " values " & saveorders2(Me.ViolationID, Me.C1FlexGrid8)
                    .Connection = con
                    .CommandType = CommandType.Text
                    .ExecuteNonQuery()

                Else
                    .CommandText = "insert into `hris_Violation_penalty` (`violationid`,`penaltyid`,`penaltylevel`,`noofdays`,`creator`)" & _
                       " values " & saveorders2(Me.ViolationID, Me.C1FlexGrid8)
                    .Connection = con
                    .CommandType = CommandType.Text
                    .ExecuteNonQuery()
                End If

            End With
            FunctionClass.showMessage("The record has been successfully saved!", "Command Executed!", "Command executed")
            tosave = False
            mytrans.Commit()
            con.Dispose()
            con.Close()
        Catch ex As Exception
            mytrans.Rollback()
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Function saveorders2(ByVal id As Integer, ByVal flexgrid As C1.Win.C1FlexGrid.C1FlexGrid) As String
        Dim z11 As String = ""
        Try
            Dim x As Integer = 1
            Dim y As Integer = flexgrid.Rows.Count - 1
            For x = 1 To y
                With flexgrid.Rows(x)
                    If .Item("penaltyid") = Nothing Then Continue For
                    Dim oks As Integer = 0
                    z11 = z11 & " " & "('" & id & _
                        "', '" & .Item("penaltyid") & _
                        "', '" & .Item("penaltylevel") & _
                        "', '" & .Item("noofdays") & _
                          "', '" & APCESMainForm.UserFullName.Text & _
                        "')            "

                End With
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return LTrim(RTrim(z11)).Replace("            ", ",")
    End Function
    Public Sub CLEAR()
        ' FunctionClass.ClearPanel(Me.C1InputPanel1)
        Me.ViolationCode.Text = Nothing
        Me.ViolationDetails.Text = Nothing
        Me.GeneralViolation.Text = Nothing
        Me.isActive.Checked = True
        Me.tosave = True
    End Sub

    Private Sub InputButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputButton4.Click
        Me.Close()
    End Sub

    Private Sub InputButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputButton2.Click
        CLEAR()
    End Sub

    Private Sub HRIS_ViolationSetup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        con.Open()
        command = New MySqlCommand("Select distinct penaltylevel from hris_penaltysetup order by penaltyid asc", con)
        reader = command.ExecuteReader
        Me.C1ComboBox1.Items.Clear()
        Do While reader.Read = True
            Me.C1ComboBox1.Items.Add(reader.Item("penaltylevel"))
        Loop
        command.Dispose()
        con.Close()
    End Sub

    Private Sub C1InputPanel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1InputPanel1.Click
    End Sub

    Private Sub C1FlexGrid8_AfterEdit(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) Handles C1FlexGrid8.AfterEdit
        loadpenaltydata()
    End Sub

    Private Sub C1FlexGrid8_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1FlexGrid8.KeyDown
        If e.KeyCode = Keys.Delete Then
            Dim sagot As MsgBoxResult = MessageBox.Show("performing the command will delete the entire row. do you want to proceed?", "perform delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Stop)
            If sagot = MsgBoxResult.Yes Then
                Me.C1FlexGrid8.Rows.Remove(Me.C1FlexGrid8.RowSel)
            End If
        End If

    End Sub
    Public Sub loadpenaltydata()
        Try
            Dim x As Integer = 1
            Dim y As Integer = C1FlexGrid8.Rows.Count - 1
            For x = 1 To y
                With C1FlexGrid8.Rows(x)
                    connect()
                    con.Open()
                    command = New MySqlCommand("Select * from hris_penaltysetup where penaltylevel='" & Me.C1FlexGrid8.Item(x, "PenaltyLevel") & "'", con)
                    reader = command.ExecuteReader
                    If reader.Read = True Then
                        Me.C1FlexGrid8.Rows(x).Item("Penaltyid") = reader.Item("penaltyid")
                        Me.C1FlexGrid8.Rows(x).Item("noofdays") = reader.Item("noofdays")
                    End If
                    command.Dispose()
                    con.Close()
                End With
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub C1FlexGrid8_ValidateEdit(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.ValidateEditEventArgs) Handles C1FlexGrid8.ValidateEdit
        Try
            With Me.C1FlexGrid8
                If e.Col = 2 Then
                    Dim filterSearch As String = ""
                    filterSearch = C1FlexGrid8.Editor.Text
                    For a As Integer = 0 To .Rows.Count - 1
                        If e.Row = a Or .Item(a, 2) = String.Empty Then
                        Else
                            If filterSearch = .Item(a, 2) Then
                                MsgBox("The Penalty  '" & filterSearch & "' already exists.", MsgBoxStyle.Critical, "Duplicate Penalty Level.")
                                e.Cancel = True
                                Exit Sub
                            End If
                        End If
                    Next
                End If
            End With
            ' loadpenaltydata()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub InputButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputButton1.Click
        Dim x As New HRIS_GeneralViolation
        With x
            .StartPosition = FormStartPosition.CenterScreen
            .ShowDialog()
        End With
        loadingvaluestoComboBoxes_StoredProc("Combo_GeneralViolation_Activeonly", GeneralViolation, "GeneralViolation", "GeneralViolation")
    End Sub
End Class
