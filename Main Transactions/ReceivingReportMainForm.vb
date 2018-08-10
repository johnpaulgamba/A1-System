Imports mysql.data.mysqlclient
Public Class ReceivingReportsmainform
    Private filter As String = ""
    Private Sub searchbutton_click(ByVal sender As system.object, ByVal e As system.eventargs) Handles searchbutton.click
        Dim RRDatequery As String = ""
        If Me.RRDatefrom.text = Nothing And Me.RRDateto.text = Nothing Then
            RRDatequery = ""
        Else
            If Me.RRDateFrom.Text <> Nothing Then
                If RRDateTo.Text <> Nothing Then
                    RRDatequery = " and  date_format(a.RRdate, '%Y/%m/%d')  between '" & Format(RRDateFrom.Value, "yyyy/MM/dd") & "' and '" & Format(RRDateTo.Value, "yyyy/MM/dd") & "' "
                Else
                    RRDatequery = " and  a.RRdate >= '" & Format(RRDateFrom.Value, "yyyy/MM/dd") & "' "
                End If
            Else
                If RRDateTo.Text <> Nothing Then
                    RRDatequery = " and a.RRdate<= '" & Format(RRDateTo.Value, "yyyy/MM/dd") & "' "
                Else
                    RRDatequery = " and a.RRdate like '%%' "
                End If
            End If
        End If

        Dim filterquery As String = " and a.RRNo like '%" & convertQuotes(Me.SOReference.Text) & _
                     "%' and customername like '%" & convertQuotes(Me.CustomerName.Text) & _
            "%' and a.datecreated like '%" & convertQuotes(Me.DateCreated.Text) & _
            "%' and a.lastupdate like '%" & convertQuotes(Me.LastUpdate.Text) & _
            "%' and a.companyid = '" & companyid & _
            "' and a.creator like '%" & convertQuotes(Me.Creator.Text) & "%' "
        Me.filter = filterquery & RRDatequery
        loaddata("transaction_ReceivingReport_main", filter, Me.C1FlexGrid1)

    End Sub

    Private Sub addnew_click() Handles AddNew.Click, btnNew.Click
        Dim x As New ReceivingReportentry(0)
        With x
            .InputButton3.PerformClick()
            .StartPosition = FormStartPosition.centerscreen
            .Show()
        End With
    End Sub

    Private Sub editrecord_click() Handles EditRecord.Click, BtnModify.Click
        Try
            Dim id As Integer = Me.C1FlexGrid1.Rows(Me.C1FlexGrid1.RowSel).Item("ReceivingReportid")
            readdetails("select * from ReceivingReport where ReceivingReportid=" & id, 3)
        Catch ex As Exception
            'showMessage(ex.Message, "exception found", "contact system admin", 1)
        End Try
    End Sub

    Private Sub c1flexgrid1_doubleclick(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1FlexGrid1.DoubleClick, BtnOpen.Click
        Try
            Dim id As Integer = Me.C1FlexGrid1.Rows(Me.C1FlexGrid1.RowSel).Item("ReceivingReportid")
            readdetails("select * from ReceivingReport where ReceivingReportid=" & id, 4)
        Catch ex As Exception
            'showMessage(ex.Message, "exception found", "contact system admin", 1)
        End Try
    End Sub
    Private newstringcollec As New System.Collections.Specialized.StringCollection
    Public Sub loadallcommands(ByVal classname As String, ByVal storedproc As String)
        Try
            connect()
            con.Open()
            Dim adapter As New MySqlDataAdapter
            Dim ds As New DataSet
            adapter = New MySqlDataAdapter(storedproc, con)
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure
            adapter.SelectCommand.Parameters.AddWithValue("@id", APCESMainForm.EmployeeID.Text)
            adapter.SelectCommand.Parameters.AddWithValue("@classnames", classname)
            adapter.Fill(ds)
            con.Close()
            newstringcollec.Clear()
            For Each row As DataRow In ds.Tables(0).Rows
                newstringcollec.Add(row.Item("commandname").ToString.ToLower)
            Next
            For Each x As C1.Win.C1Command.C1Command In Me.C1CommandHolder1.Commands
                If x.Name.ToLower.Contains("c1contextmenu") Then
                    x.Enabled = True
                ElseIf x.Name.ToLower = "c1command1" Or x.Name.Contains("runcmd") Then
                    x.Enabled = True
                ElseIf newstringcollec.Contains(x.Name.ToLower) Then
                    x.Enabled = True
                Else
                    x.Enabled = False
                End If
            Next
        Catch ex As Exception
            showMessage(ex.Message, "exception found", Application.ProductName.ToString, 1)
        End Try
    End Sub
    Private Sub c1flexgrid1_mouseclick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles C1FlexGrid1.MouseClick
        Try


            DataGridView1_MouseClick(sender, e, Me.C1FlexGrid1, Me.C1ContextMenu1)
            If (e.Button = Windows.Forms.MouseButtons.Right) Then

                C1ContextMenu1.ShowContextMenu(C1FlexGrid1, e.Location)
            End If

        Catch ex As Exception
            'showMessage(ex.Message, "exception found", "contact system admin", 1)
        End Try

    End Sub

    Private Sub exportgriddata_click() Handles ExportGrid.Click, BtnExport.Click
        ExportGridData(Me.C1FlexGrid1)
    End Sub

    Public Sub refreshgrid_click() Handles RefreshGrid.Click, BtnRefresh.Click
        Me.ClearButton.PerformClick()
        loaddata("transaction_ReceivingReport_main", filter, Me.C1FlexGrid1)
    End Sub

    Private Sub clearbutton_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click
        Me.SOReference.Text = Nothing
        Me.CustomerName.Text = Nothing
        Me.LastUpdate.Text = Nothing
        Me.DateCreated.Text = Nothing
        Me.Creator.Text = Nothing
        Me.RRDatefrom.value = Now
        Me.RRDateTo.Value = Now
        Me.refreshgrid_click()
    End Sub

    Private Sub printrecord_click() Handles PrintRecord.Click, BtnPrint.Click
        Try
            Dim id As Integer = Me.C1FlexGrid1.Rows(Me.C1FlexGrid1.RowSel).Item("ReceivingReportid")
            Dim x As New reportpreview
            With x
                .print("reporting_ReceivingReport_solo", "id", id, 2, "", "")
                .Text = "print preview of RR " & id.ToString("d10")
                .StartPosition = FormStartPosition.centerscreen
                .WindowState = FormWindowState.Maximized
                .Show()
            End With
        Catch ex As Exception
            'showMessage(ex.Message, "exception found", "contact system admin", 1)
        End Try
    End Sub
    Private Sub cancelcommand_click() Handles CancelCommand.Click, btnCancel.Click
        Try
            Dim id As Integer = Me.C1FlexGrid1.Rows(Me.C1FlexGrid1.RowSel).Item("ReceivingReportid")
            readdetails("select * from ReceivingReport where ReceivingReportid=" & id, 1)
        Catch ex As Exception
            'showMessage(ex.Message, "exception found", "contact system admin", 1)
        End Try
    End Sub
    Private Sub readdetails(ByVal sql As String, ByVal b As Integer)
        Try
            Dim ReceivingReportid As Integer = 0
            Dim ds As New DataSet
            connect()
            con.Open()
            Dim adapter As New MySqlDataAdapter(sql, con)
            With adapter
                .Fill(ds)
                .Dispose()
            End With
            con.Close()
            ReceivingReportid = ds.Tables(0).Rows(0).Item("ReceivingReportid")
            If b = 1 Then
                With ds.Tables(0).Rows(0)
                    If .Item("iscancelled") = True Then
                        showMessage("the record is already cancelled. you are not allowed to perform the command!", "cancelled already", "invalid command", 1)
                        Exit Sub
                    End If
                End With
                Dim sagot As MsgBoxResult = MessageBox.Show("are you sure you want to perform the command?", "verification", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information)
                If sagot <> MsgBoxResult.Yes Then Exit Sub
                connect()
                con.Open()
                Dim command As New MySqlCommand
                With command
                    If b = 1 Then
                        .CommandText = "update ReceivingReport set  iscancelled=@iscancelled, cancelledby=@cancelledby, datecancelled=@datecancelled, " & _
                       "lastupdate=@lastupdate where ReceivingReportid=@ReceivingReportid"
                    End If
                    With .Parameters
                        .AddWithValue("@cancelledby", APCESMainForm.UserFullName.Text)
                        .AddWithValue("@datecancelled", Format(Now, "yyyy-MM-dd HH:mm:ss"))
                        .AddWithValue("@iscancelled", 1)
                        .AddWithValue("@lastupdate", "" & Now)
                        .AddWithValue("@ReceivingReportid", ReceivingReportid)
                    End With
                    .Connection = con
                    .ExecuteNonQuery()

                    con.Close()
                    command.Dispose()
                    showMessage("the command has been successfully executed.", "command successful", "command executed", 3)
                    Me.refreshgrid_click()
                End With
            ElseIf b = 3 Then
                Dim x As New ReceivingReportentry(ReceivingReportid)
                With x
                    .StartPosition = FormStartPosition.centerscreen
                    .Show()
                End With
            ElseIf b = 4 Then
                Dim x As New ReceivingReportentry(ReceivingReportid)
                With x
                    .toenable(False)
                    .StartPosition = FormStartPosition.centerscreen
                    .Show()
                End With
            ElseIf b = 5 Then
                With ds.Tables(0).Rows(0)
                    If .Item("iscancelled") = True Then
                        showMessage("the record is already cancelled. you are not allowed to perform the command!", "cancelled already", "invalid command", 1)
                        Exit Sub
                    End If
                    If .Item("isapproved") = False Then
                        showMessage("the record is not yet approved. you are not allowed to perform the command!", "approved already", "invalid command", 1)
                        Exit Sub
                    End If
                End With
                Dim sagot As MsgBoxResult = MessageBox.Show("are you sure you want to perform the command?", "verification", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information)
                If sagot <> MsgBoxResult.Yes Then Exit Sub
                connect()
                con.Open()
                Dim command As New MySqlCommand
                With command
                    .CommandText = "update ReceivingReport set iscancelled=@iscancelled, cancelledby=@cancelledby, datecancelled=@datecancelled, " & _
                       "lastupdate=@lastupdate where ReceivingReportid=@ReceivingReportid"
                    With .Parameters
                        .AddWithValue("@cancelledby", APCESMainForm.UserFullName.Text)
                        .AddWithValue("@datecancelled", Format(Now, "yyyy-MM-dd HH:mm:ss"))
                        .AddWithValue("@iscancelled", 1)
                        .AddWithValue("@lastupdate", "" & Now)
                        .AddWithValue("@ReceivingReportid", ReceivingReportid)
                    End With
                    .Connection = con
                    .ExecuteNonQuery()
                    showMessage("the command has been successfully executed.", "command successful", "command executed", 3)
                    Me.refreshgrid_click()
                End With
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub approvecommand_click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles ApproveCommand.Click
        Try
            Dim id As Integer = Me.C1FlexGrid1.Rows(Me.C1FlexGrid1.RowSel).Item("ReceivingReportid")
            readdetails("select * from ReceivingReport where ReceivingReportid=" & id, 2)
        Catch ex As Exception
            'showMessage(ex.Message, "exception found", "contact system admin", 1)
        End Try
    End Sub

    Private Sub cancelapprovedcommand_click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles CancelApprovedCommand.Click
        Try
            Dim id As Integer = Me.C1FlexGrid1.Rows(Me.C1FlexGrid1.RowSel).Item("ReceivingReportid")
            readdetails("select * from ReceivingReport where ReceivingReportid=" & id, 5)
        Catch ex As Exception
            'showMessage(ex.Message, "exception found", "contact system admin", 1)
        End Try
    End Sub

    Private Sub ReceivingReportsmainform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.C1NavBar1.PanelHeaderFont = New Font("arial", 12, FontStyle.Bold)
        Me.C1NavBar2.PanelHeaderFont = New Font("arial", 12, FontStyle.Bold)
        Me.RRDateFrom.Value = FirstDayOfMonth(Now)
        Me.RRDateTo.Value = LastDayOfMonth(Now)
        searchbutton_click(sender, e)
    End Sub

    Private Sub Btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnclose.Click
        Me.Close()
    End Sub

    Private Sub C1InputPanel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1InputPanel1.Click

    End Sub
End Class


