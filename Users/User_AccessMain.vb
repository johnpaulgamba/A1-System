Imports MySql.Data.MySqlClient
Public Class User_AccessMain
    Public QueryString As String = ""
    Public Sub SubjectsMain_VisualStyleChanged(ByVal a As String)
        Me.C1NavBar1.PanelHeaderFont = New Font("Arial", 12, FontStyle.Bold)
        Me.C1NavBar2.PanelHeaderFont = New Font("Arial", 12, FontStyle.Bold)
        'Me.C1FlexGrid1.Styles.Normal.BackColor = Me.C1InputPanel1.BackColor
        Me.C1FlexGrid1.Styles.EmptyArea.Border.Style = C1.Win.C1FlexGrid.BorderStyleEnum.None
        Me.C1FlexGrid1.Styles.EmptyArea.BackColor = C1InputPanel1.BackColor
        'Me.C1FlexGrid1.Styles.Alternate.BackColor = Me.C1FlexGrid1.Styles.Normal.BackColor
        Me.C1NavBar1.StripHeight = 0 : Me.C1NavBar2.StripHeight = 0 : Me.C1NavBar2.ButtonHeight = 0
        Me.C1NavBar1.ButtonHeight = 0 : Me.C1NavBar1.GripHeight = 0 : Me.C1NavBar2.GripHeight = 0
    End Sub
    Private NewStringCollec As New System.Collections.Specialized.StringCollection
    Public Sub loadallCommands(ByVal ClassName As String, ByVal StoredProc As String)
        Try
            connect()
            con.Open()
            Dim adapter As New MySqlDataAdapter
            Dim ds As New DataSet
            adapter = New MySqlDataAdapter(StoredProc, con)
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure
            adapter.SelectCommand.Parameters.AddWithValue("@ID", APCESMainForm.EmployeeID.Text)
            adapter.SelectCommand.Parameters.AddWithValue("@ClassNames", ClassName)
            adapter.Fill(ds)
            con.Close()
            NewStringCollec.Clear()
            For Each row As DataRow In ds.Tables(0).Rows
                NewStringCollec.Add(row.Item("CommandName").ToString.ToLower)
            Next
            For Each x As C1.Win.C1Command.C1Command In Me.C1CommandHolder1.Commands
                If x.Name.ToLower.Contains("c1contextmenu") Then
                    x.Enabled = True
                ElseIf x.Name.ToLower = "c1command1" Or x.Name.Contains("runcmd") Then
                    x.Enabled = True
                ElseIf NewStringCollec.Contains(x.Name.ToLower) Then
                    x.Enabled = True
                Else
                    x.Enabled = False
                End If
            Next
        Catch ex As Exception
            showMessage(ex.Message, "Exception found", Application.ProductName.ToString, 1)
        End Try
    End Sub
    Private Sub InputButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputButton1.Click
        Dim i As String = " WHERE  a.EmailAddress LIKE '%" & convertQuotes(Me.EmailAddress.Text) & _
            "%' AND a.UserName LIKE '%" & convertQuotes(Me.UserName.Text) & _
            "%' AND a.Fullname LIKE '%" & convertQuotes(Me.Fullname.Text) & _
            "%' AND a.Department LIKE '%" & convertQuotes(Me.Department.Text) & _
            "%' "
        Dim isActive = ""
        If Me.ActiveBoth.Checked = True Then isActive = "" Else isActive = " AND a.ACTIVE=" & Convert.ToSingle(Me.ActiveYes.Checked)
        QueryAll(i & isActive)
    End Sub
    Private Sub QueryAll(ByVal a As String)
        QueryString = a
        loaddata("user_access_gridmain", a, Me.C1FlexGrid1)
    End Sub
    Private Sub C1Flexgrid1_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles C1FlexGrid1.MouseClick
        DataGridView1_MouseClick(sender, e, Me.C1FlexGrid1, Me.C1ContextMenu1)
        If (e.Button = Windows.Forms.MouseButtons.Right) Then

            C1ContextMenu1.ShowContextMenu(C1FlexGrid1, e.Location)
        End If
    End Sub
    Private Sub SubjectsMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        QueryAll("")
    End Sub
    Private Sub AddNewCommand_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles AddNewCommand.Click
        Dim x As New UserAccountRegistration(0)
        With x


            .StartPosition = FormStartPosition.centerscreen
            .ShowDialog()
        End With
    End Sub
    Private Sub DeleteRecordCommand_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles DeleteRecordCommand.Click
        Try
            Dim sagot As MsgBoxResult = MessageBox.Show("Performing the command will delete the selected record. Are you sure you want to proceed?", "Delete record?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Stop)
            If sagot = MsgBoxResult.Yes Then
                saveEditDelete("Delete From user_access where UserID=" & Me.C1FlexGrid1.Rows(Me.C1FlexGrid1.RowSel).Item("UserID"), "deleted")
                refreshform()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Public Sub refreshform()
        loaddata("user_access_gridmain", Me.QueryString, Me.C1FlexGrid1)
    End Sub

    Private Sub EditRecordCommand_Click(ByVal sender As Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles EditRecordCommand.Click
        Try
            Dim id As Integer = Me.C1FlexGrid1.Rows(Me.C1FlexGrid1.RowSel).Item("UserID")
            Dim x As New UserAccountRegistration(id)
            With x


                .StartPosition = FormStartPosition.centerscreen
                .ShowDialog()
            End With
        Catch ex As Exception
        End Try
    End Sub

    Private Sub RefreshCommand_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles RefreshCommand.Click
        Me.refreshform()
    End Sub

    Private Sub InputButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputButton2.Click
        Me.ActiveBoth.Checked = True
        Me.UserName.Text = Nothing
        Me.Fullname.Text = Nothing
        Me.Department.Text = Nothing
        Me.EmailAddress.Text = Nothing
    End Sub

    Private Sub InputButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputButton3.Click
        Me.refreshform()
    End Sub

    Private Sub ExportGridDataList_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles ExportGridDataList.Click
        ExportGridData(Me.C1FlexGrid1)
    End Sub


    Private Sub EnableDisableAccount_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles EnableDisableAccount.Click
        Try
            Dim i As Integer = Me.C1Flexgrid1.Rows(Me.C1Flexgrid1.RowSel).Item("UserID")
            Dim username As String = Me.C1Flexgrid1.Rows(Me.C1Flexgrid1.RowSel).Item("Username")
            Dim haha As New C1.Win.C1Win7Pack.C1TaskDialog
            With haha
                .WindowTitle = "Enable/ Disable account?"
                .MainInstruction = "Enable/ Disable account"
                .Content = "Performing the command will enable/disable the account of '" & username & "' . Do you want to continue?"
                .MainCommonIcon = C1.Win.C1Win7Pack.TaskDialogCommonIcon.Shield
                .CommonButtons = C1.Win.C1Win7Pack.TaskDialogCommonButtons.Ok Or C1.Win.C1Win7Pack.TaskDialogCommonButtons.Cancel
                .Show()
            End With
            If haha.DialogResult = C1.Win.C1Win7Pack.TaskDialogResult.Ok Then
                saveEditDelete("Update user_access Set Active=not(active), LastUpdate='" & Now & "' Where UserID='" & i & "'", "wala")
                showMessage("Account has been successfully updated", "Account Updated", "Account updated", 1)
                Me.refreshform()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ModifyUserDetailsCommand_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles ModifyUserDetailsCommand.Click
        Try

            Dim i As Integer = Me.C1FlexGrid1.Rows(Me.C1FlexGrid1.RowSel).Item("USerID")
            Dim x As New UserAccountModifyDetails(i)
            With x
                .StartPosition = FormStartPosition.centerscreen
                .ShowDialog()
            End With
        Catch ex As Exception
        End Try
    End Sub

    Private Sub OverwritePasswordCommand_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles OverwritePasswordCommand.Click
        Try
            Dim i As Integer = Me.C1FlexGrid1.Rows(Me.C1FlexGrid1.RowSel).Item("UserID")
            Dim username As String = Me.C1FlexGrid1.Rows(Me.C1FlexGrid1.RowSel).Item("Username")
            Dim x As New Passwordvalidation
            With x
                .Text = "Overwrite password"
                .userid = i
                .UserName.Text = username
                .overwrite = True
                .StartPosition = FormStartPosition.centerscreen
                .ShowDialog()
            End With
        Catch ex As Exception

        End Try
    End Sub
End Class
