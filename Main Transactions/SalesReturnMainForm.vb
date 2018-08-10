Imports mysql.data.mysqlclient
Public Class salesreturnmainform

    Private Sub warehousemainform_load(sender As Object, e As system.eventargs) Handles me.load
        Me.c1navbar1.panelheaderfont = New font("arial", 12, fontstyle.bold)
        Me.c1navbar2.panelheaderfont = New font("arial", 12, fontstyle.bold)
        Me.returndateto.value = now
        Me.returndatefrom.value = now
        searchbutton_click(sender, e)
    End Sub
    Private filter As String = ""
    Private Sub searchbutton_click(sender As system.object, e As system.eventargs) Handles searchbutton.click
        Dim dateorderedquery As String = ""
        If Me.dateorderedfrom.text = Nothing And Me.dateorderedto.text = Nothing Then
            dateorderedquery = ""
        Else
            If Me.dateorderedfrom.text <> Nothing Then
                If dateorderedto.text <> Nothing Then
                    dateorderedquery = " and  date_format(a.dateordered, '%Y/%m/%d')  between '" & Format(DateOrderedFrom.Value, "yyyy/MM/dd") & "' and '" & Format(DateOrderedTo.Value, "yyyy/MM/dd") & "' "
                Else
                    dateorderedquery = " and  a.dateordered >= '" & Format(DateOrderedFrom.Value, "yyyy/MM/dd") & "' "
                End If
            Else
                If DateOrderedTo.Text <> Nothing Then
                    dateorderedquery = " and a.dateordered<= '" & Format(DateOrderedTo.Value, "yyyy/MM/dd") & "' "
                Else
                    dateorderedquery = " and a.dateordered like '%%' "
                End If
            End If
        End If
        Dim returndatequery As String = ""
        If Me.ReturnDateFrom.Text = Nothing And Me.ReturnDateTo.Text = Nothing Then
            returndatequery = ""
        Else
            If Me.ReturnDateFrom.Text <> Nothing Then
                If ReturnDateTo.Text <> Nothing Then
                    returndatequery = " and  date_format(a1.returndate, '%Y/%m/%d')  between '" & Format(ReturnDateFrom.Value, "yyyy/MM/dd") & "' and '" & Format(ReturnDateTo.Value, "yyyy/MM/dd") & "' "
                Else
                    returndatequery = " and  a1.returndate >= '" & Format(ReturnDateFrom.Value, "yyyy/MM/dd") & "' "
                End If
            Else
                If ReturnDateTo.Text <> Nothing Then
                    returndatequery = " and a1.returndate<= '" & Format(ReturnDateTo.Value, "yyyy/MM/dd") & "' "
                Else
                    returndatequery = " and a1.returndate like '%%' "
                End If
            End If
        End If

        Dim deliverydatequery As String = ""
        If Me.DeliveryDateFrom.Text = Nothing And Me.DeliveryDateTo.Text = Nothing Then
            deliverydatequery = ""
        Else
            If Me.DeliveryDateFrom.Text <> Nothing Then
                If DeliveryDateTo.Text <> Nothing Then
                    deliverydatequery = " and  date_format(a.deliverydate, '%Y/%m/%d')  between '" & Format(DeliveryDateFrom.Value, "yyyy/MM/dd") & "' and '" & Format(DeliveryDateTo.Value, "yyyy/MM/dd") & "' "
                Else
                    deliverydatequery = " and  a.deliverydate >= '" & Format(DeliveryDateFrom.Value, "yyyy/MM/dd") & "' "
                End If
            Else
                If DeliveryDateTo.Text <> Nothing Then
                    deliverydatequery = " and a.deliverydate<= '" & Format(DeliveryDateTo.Value, "yyyy/MM/dd") & "' "
                Else
                    deliverydatequery = " and a.deliverydate like '%%' "
                End If
            End If
        End If

        Dim filterquery As String = " and  a.salesorderid like '%" & convertquotes(Me.soreference.text) & _
            "%' and customername like '%" & convertquotes(Me.customername.text) & _
            "%' and a.datecreated like '%" & convertquotes(Me.datecreated.text) & _
            "%' and a.lastupdate like '%" & convertquotes(Me.lastupdate.text) & _
            "%' and a.creator like '%" & convertquotes(Me.creator.text) & "%' "
        Me.filter = filterquery & dateorderedquery & deliverydatequery & returndatequery
        loaddata("transaction_salesreturn_main", filter, Me.c1flexgrid1)

    End Sub

    Private Sub addnew_click(sender As system.object, e As c1.win.c1command.clickeventargs) Handles addnew.click
        Dim x As New salesreturnentry(0)
        With x
            .startposition = formstartposition.centerscreen
            .showdialog()
        End With
    End Sub

    Private Sub editrecord_click(ByVal sender As system.object, ByVal e As c1.win.c1command.clickeventargs) Handles editrecord.click
        Try
            Dim id As Integer = Me.c1flexgrid1.rows(Me.c1flexgrid1.rowsel).item("returnid")
            readdetails("select * from salesreturn where returnid=" & id, 3)
        Catch ex As exception
            'showMessage(ex.Message, "exception found", "contact system admin", 1)
        End Try
    End Sub

    Private Sub c1flexgrid1_doubleclick(ByVal sender As Object, ByVal e As system.eventargs) Handles c1flexgrid1.doubleclick
        Try
            Dim id As Integer = Me.c1flexgrid1.rows(Me.c1flexgrid1.rowsel).item("returnid")
            readdetails("select * from salesreturn where returnid=" & id, 4)
        Catch ex As exception
            'showMessage(ex.Message, "exception found", "contact system admin", 1)
        End Try
    End Sub

    Private newstringcollec As New system.collections.specialized.stringcollection
    Public Sub loadallcommands(ByVal classname As String, ByVal storedproc As String)
        Try
            connect()
            con.open()
            Dim adapter As New mysqldataadapter
            Dim ds As New dataset
            adapter = New mysqldataadapter(storedproc, con)
            adapter.selectcommand.commandtype = commandtype.storedprocedure
            adapter.selectcommand.parameters.addwithvalue("@id", APCESMainForm.employeeid.text)
            adapter.selectcommand.parameters.addwithvalue("@classnames", classname)
            adapter.fill(ds)
            con.close()
            newstringcollec.clear()
            For Each row As datarow In ds.tables(0).rows
                newstringcollec.add(row.item("commandname").tostring.tolower)
            Next
            For Each x As c1.win.c1command.c1command In Me.c1commandholder1.commands
                If x.name.tolower.contains("c1contextmenu") Then
                    x.enabled = True
                ElseIf x.name.tolower = "c1command1" Or x.name.contains("runcmd") Then
                    x.enabled = True
                ElseIf newstringcollec.contains(x.name.tolower) Then
                    x.enabled = True
                Else
                    x.enabled = False
                End If
            Next
        Catch ex As exception
            showmessage(ex.message, "exception found", application.productname.tostring, 1)
        End Try
    End Sub
    Private Sub c1flexgrid1_mouseclick(ByVal sender As system.object, ByVal e As system.windows.forms.mouseeventargs) Handles c1flexgrid1.mouseclick
        Try


            datagridview1_mouseclick(sender, e, Me.c1flexgrid1, Me.c1contextmenu1)
            If (e.Button = Windows.Forms.MouseButtons.Right) Then
                C1ContextMenu1.ShowContextMenu(C1FlexGrid1, e.Location)
            End If

        Catch ex As exception
            'showMessage(ex.Message, "exception found", "contact system admin", 1)
        End Try

    End Sub

    Private Sub exportgriddata_click(ByVal sender As system.object, ByVal e As c1.win.c1command.clickeventargs) Handles exportgrid.click
        exportgriddata(Me.c1flexgrid1)
    End Sub

    Public Sub refreshgrid_click() Handles refreshgrid.click
        loaddata("transaction_salesreturn_main", filter, Me.c1flexgrid1)
    End Sub

    Private Sub clearbutton_click(ByVal sender As system.object, ByVal e As system.eventargs) Handles clearbutton.click
        Me.soreference.text = Nothing
        Me.customername.text = Nothing
        Me.lastupdate.text = Nothing
        Me.datecreated.text = Nothing
        Me.creator.text = Nothing
        Me.dateorderedfrom.value = now
        Me.dateorderedto.value = now
        Me.deliverydatefrom.text = Nothing
        Me.deliverydateto.text = Nothing
    End Sub

    Private Sub printrecord_click(ByVal sender As system.object, ByVal e As c1.win.c1command.clickeventargs) Handles printrecord.click
        Try
            Dim id As Integer = Me.c1flexgrid1.rows(Me.c1flexgrid1.rowsel).item("returnid")
            Dim x As New reportpreview
            With x
                .print("reporting_salesreturn_solo", "id", id, 2, "", "")
                .text = "print preview of sr " & id.tostring("d10")
                .startposition = formstartposition.centerscreen
                .windowstate = formwindowstate.maximized
                .show()
            End With
        Catch ex As exception
            'showMessage(ex.Message, "exception found", "contact system admin", 1)
        End Try
    End Sub
    Private Sub cancelcommand_click(ByVal sender As system.object, ByVal e As c1.win.c1command.clickeventargs) Handles cancelcommand.click
        Try
            Dim id As Integer = Me.c1flexgrid1.rows(Me.c1flexgrid1.rowsel).item("returnid")
            readdetails("select * from salesreturn where returnid=" & id, 1)
        Catch ex As exception
            'showMessage(ex.Message, "exception found", "contact system admin", 1)
        End Try
    End Sub
    Private Sub readdetails(ByVal sql As String, ByVal b As Integer)
        Try
            Dim returnid As Integer = 0
            Dim ds As New dataset
            connect()
            con.open()
            Dim adapter As New mysqldataadapter(sql, con)
            With adapter
                .fill(ds)
                .dispose()
            End With
            con.close()
            returnid = ds.tables(0).rows(0).item("returnid")
            If b = 1 Or b = 2 Then
                With ds.tables(0).rows(0)
                    If .item("iscancelled") = True Then
                        showmessage("the record is already cancelled. you are not allowed to perform the command!", "cancelled already", "invalid command", 1)
                        Exit Sub
                    End If
                    If .item("isapproved") = True Then
                        showmessage("the record is already approved. you are not allowed to perform the command!", "approved already", "invalid command", 1)
                        Exit Sub
                    End If
                End With
                Dim sagot As msgboxresult = messagebox.show("are you sure you want to perform the command?", "verification", messageboxbuttons.yesnocancel, messageboxicon.information)
                If sagot <> msgboxresult.yes Then Exit Sub
                connect()
                con.open()
                Dim command As New mysqlcommand
                With command
                    If b = 1 Then
                        .commandtext = "update salesreturn set iscancelled=@iscancelled, cancelledby=@cancelledby, datecancelled=@datecancelled, " & _
                       "lastupdate=@lastupdate where returnid=@returnid"
                    ElseIf b = 2 Then
                        .commandtext = "update salesreturn set isapproved=@iscancelled, approvedby=@cancelledby, dateapproved=@datecancelled, " & _
                       "lastupdate=@lastupdate where returnid=@returnid"
                    End If
                    With .parameters
                        .AddWithValue("@cancelledby", APCESMainForm.UserFullName.Text)
                        .AddWithValue("@datecancelled", Format(Now, "yyyy-MM-dd HH:mm:ss"))
                        .AddWithValue("@iscancelled", 1)
                        .AddWithValue("@lastupdate", "" & Now)
                        .AddWithValue("@returnid", returnid)
                    End With
                    .Connection = con
                    .ExecuteNonQuery()
                    If b = 2 Then
                        Dim command1 As New MySqlCommand
                        command1.Parameters.AddWithValue("@id", returnid)
                        command1.Parameters.AddWithValue("@transactedbys", APCESMainForm.UserFullName.Text)
                        command1.CommandText = "inventory_salesreturn_approval"
                        command1.CommandType = CommandType.StoredProcedure
                        command1.Connection = con
                        command1.ExecuteNonQuery()
                        command1.Dispose()
                    End If
                    con.Close()
                    command.Dispose()
                    showMessage("the command has been successfully executed.", "command successful", "command executed", 3)
                    Me.refreshgrid_click()
                End With
            ElseIf b = 3 Then
                With ds.Tables(0).Rows(0)
                    If .Item("iscancelled") = True Then
                        showMessage("the record is already cancelled. you are not allowed to perform the command!", "cancelled already", "invalid command", 1)
                        Exit Sub
                    End If
                    If .Item("isapproved") = True Then
                        showMessage("the record is already approved. you are not allowed to perform the command!", "approved already", "invalid command", 1)
                        Exit Sub
                    End If
                End With
                Dim x As New salesreturnentry(returnid)
                With x
                    .StartPosition = FormStartPosition.centerscreen
                    .ShowDialog()
                End With
            ElseIf b = 4 Then
                Dim x As New salesreturnentry(returnid)
                With x
                    .toenable(False)
                    .StartPosition = FormStartPosition.centerscreen
                    .ShowDialog()
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
                    .CommandText = "update salesreturn set iscancelled=@iscancelled, cancelledby=@cancelledby, datecancelled=@datecancelled, " & _
                         "lastupdate=@lastupdate where returnid=@returnid"
                    With .Parameters
                        .AddWithValue("@cancelledby", APCESMainForm.UserFullName.Text)
                        .AddWithValue("@datecancelled", Format(Now, "yyyy-MM-dd HH:mm:ss"))
                        .AddWithValue("@iscancelled", 1)
                        .AddWithValue("@lastupdate", "" & Now)
                        .AddWithValue("@returnid", returnid)
                    End With
                    .Connection = con
                    .ExecuteNonQuery()
                    Dim command1 As New MySqlCommand
                    command1.Parameters.AddWithValue("@id", returnid)
                    command1.Parameters.AddWithValue("@transactedbys", APCESMainForm.UserFullName.Text)
                    command1.CommandText = "inventory_salesreturn_reversal"
                    command1.CommandType = CommandType.StoredProcedure
                    command1.Connection = con
                    command1.ExecuteNonQuery()
                    command1.Dispose()
                    con.Close()
                    command.Dispose()
                    showMessage("the command has been successfully executed.", "command successful", "command executed", 3)
                    Me.refreshgrid_click()
                End With
            End If
        Catch ex As exception
        End Try
    End Sub

    Private Sub approvecommand_click(ByVal sender As system.object, ByVal e As c1.win.c1command.clickeventargs) Handles approvecommand.click
        Try
            Dim id As Integer = Me.c1flexgrid1.rows(Me.c1flexgrid1.rowsel).item("returnid")
            readdetails("select * from salesreturn where returnid=" & id, 2)
        Catch ex As exception
            'showMessage(ex.Message, "exception found", "contact system admin", 1)
        End Try
    End Sub

    Private Sub cancelapprovedcommand_click(ByVal sender As system.object, ByVal e As c1.win.c1command.clickeventargs) Handles cancelapprovedcommand.click
        Try
            Dim id As Integer = Me.c1flexgrid1.rows(Me.c1flexgrid1.rowsel).item("returnid")
            readdetails("select * from salesreturn where returnid=" & id, 5)
        Catch ex As exception
            'showMessage(ex.Message, "exception found", "contact system admin", 1)
        End Try
    End Sub
End Class


