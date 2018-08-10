Imports mysql.data.mysqlclient
Public Class servicereportmainform

    Private Sub warehousemainform_load(ByVal sender As Object, ByVal e As system.eventargs) Handles me.load
        Me.c1navbar1.panelheaderfont = New font("arial", 12, fontstyle.bold)
        Me.c1navbar2.panelheaderfont = New font("arial", 12, fontstyle.bold)
        Me.servedatefrom.value = now
        Me.serveto.value = now
        searchbutton_click(sender, e)
    End Sub
    Private filter As String = ""
    Private Sub searchbutton_click(ByVal sender As system.object, ByVal e As system.eventargs) Handles searchbutton.click
        Dim servedatequery As String = ""
        If Me.servedatefrom.text = Nothing And Me.serveto.text = Nothing Then
            servedatequery = ""
        Else
            If Me.servedatefrom.text <> Nothing Then
                If serveto.text <> Nothing Then
                    servedatequery = " and  date_format(a.servedate, '%Y/%m/%d')  between '" & Format(ServeDateFrom.Value, "yyyy/MM/dd") & "' and '" & Format(ServeTo.Value, "yyyy/MM/dd") & "' "
                Else
                    servedatequery = " and  a.servedate >= '" & Format(ServeDateFrom.Value, "yyyy/MM/dd") & "' "
                End If
            Else
                If ServeTo.Text <> Nothing Then
                    servedatequery = " and a.servedate<= '" & Format(ServeTo.Value, "yyyy/MM/dd") & "' "
                Else
                    servedatequery = " and a.servedate like '%%' "
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

        Dim filterquery As String = " and  a.servicereportid like '%" & convertquotes(Me.soreference.text) & _
            "%' and customername like '%" & convertquotes(Me.customername.text) & _
            "%' and a.datecreated like '%" & convertquotes(Me.datecreated.text) & _
            "%' and a.lastupdate like '%" & convertquotes(Me.lastupdate.text) & _
            "%' and a.creator like '%" & convertquotes(Me.creator.text) & "%' "
        Me.filter = filterquery & servedatequery & deliverydatequery
        loaddata("transaction_servicereport_main", filter, Me.c1flexgrid1)

    End Sub

    Private Sub addnew_click(ByVal sender As system.object, ByVal e As c1.win.c1command.clickeventargs) Handles addnew.click
        Dim x As New servicereport(0)
        With x
            .startposition = formstartposition.centerscreen
            .showdialog()
        End With
    End Sub

    Private Sub editrecord_click(ByVal sender As system.object, ByVal e As c1.win.c1command.clickeventargs) Handles editrecord.click
        Try
            Dim id As Integer = Me.c1flexgrid1.rows(Me.c1flexgrid1.rowsel).item("servicereportid")
            readdetails("select * from servicereport where servicereportid=" & id, 3)
        Catch ex As exception
            'showMessage(ex.Message, "exception found", "contact system admin", 1)
        End Try
    End Sub

    Private Sub c1flexgrid1_doubleclick(ByVal sender As Object, ByVal e As system.eventargs) Handles c1flexgrid1.doubleclick
        Try
            Dim id As Integer = Me.c1flexgrid1.rows(Me.c1flexgrid1.rowsel).item("servicereportid")
            readdetails("select * from servicereport where servicereportid=" & id, 4)
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
        loaddata("transaction_servicereport_main", filter, Me.c1flexgrid1)
    End Sub

    Private Sub clearbutton_click(ByVal sender As system.object, ByVal e As system.eventargs) Handles clearbutton.click
        Me.soreference.text = Nothing
        Me.customername.text = Nothing
        Me.lastupdate.text = Nothing
        Me.datecreated.text = Nothing
        Me.creator.text = Nothing
        Me.servedatefrom.value = now
        Me.serveto.value = now
        Me.deliverydatefrom.text = Nothing
        Me.deliverydateto.text = Nothing
    End Sub

    Private Sub printrecord_click(ByVal sender As system.object, ByVal e As c1.win.c1command.clickeventargs) Handles printrecord.click
        Try
            Dim id As Integer = Me.c1flexgrid1.rows(Me.c1flexgrid1.rowsel).item("servicereportid")
            Dim x As New reportpreview
            With x
                .print("reporting_servicereport_solo", "id", id, 6, "", "")
                .text = "print preview of se " & id.tostring("d10")
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
            Dim id As Integer = Me.c1flexgrid1.rows(Me.c1flexgrid1.rowsel).item("servicereportid")
            readdetails("select * from servicereport where servicereportid=" & id, 1)
        Catch ex As exception
            'showMessage(ex.Message, "exception found", "contact system admin", 1)
        End Try
    End Sub
    Private Sub readdetails(ByVal sql As String, ByVal b As Integer)
        Try
            Dim servicereportid As Integer = 0
            Dim ds As New dataset
            connect()
            con.open()
            Dim adapter As New mysqldataadapter(sql, con)
            With adapter
                .fill(ds)
                .dispose()
            End With
            con.close()
            servicereportid = ds.tables(0).rows(0).item("servicereportid")
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
                        .commandtext = "update servicereport set iscancelled=@iscancelled, cancelledby=@cancelledby, datecancelled=@datecancelled, " & _
                       "lastupdate=@lastupdate where servicereportid=@servicereportid"
                    ElseIf b = 2 Then
                        .commandtext = "update servicereport set isapproved=@iscancelled, approvedby=@cancelledby, dateapproved=@datecancelled, " & _
                       "lastupdate=@lastupdate where servicereportid=@servicereportid"
                    End If
                    With .parameters
                        .AddWithValue("@cancelledby", APCESMainForm.UserFullName.Text)
                        .AddWithValue("@datecancelled", Format(Now, "yyyy-MM-dd HH:mm:ss"))
                        .AddWithValue("@iscancelled", 1)
                        .AddWithValue("@lastupdate", "" & Now)
                        .AddWithValue("@servicereportid", servicereportid)
                    End With
                    .Connection = con
                    .ExecuteNonQuery()
                    'if b = 2 then
                    '    dim command1 as new mysqlcommand
                    '    command1.parameters.addwithvalue("@id", servicereportid)
                    '    command1.parameters.addwithvalue("@transactedbys", baketechmainform.userfullname.text)
                    '    command1.commandtext = "inventory_servicereport_approval"
                    '    command1.commandtype = commandtype.storedprocedure
                    '    command1.connection = con
                    '    command1.executenonquery()
                    '    command1.dispose()
                    'end if
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
                Dim x As New servicereport(servicereportid)
                With x
                    .StartPosition = FormStartPosition.centerscreen
                    .ShowDialog()
                End With
            ElseIf b = 4 Then
                Dim x As New servicereport(servicereportid)
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
                    .CommandText = "update servicereport set iscancelled=@iscancelled, cancelledby=@cancelledby, datecancelled=@datecancelled, " & _
                   "lastupdate=@lastupdate where servicereportid=@servicereportid"
                    With .Parameters
                        .AddWithValue("@cancelledby", APCESMainForm.UserFullName.Text)
                        .AddWithValue("@datecancelled", Format(Now, "yyyy-MM-dd HH:mm:ss"))
                        .AddWithValue("@iscancelled", 1)
                        .AddWithValue("@lastupdate", "" & Now)
                        .AddWithValue("@servicereportid", servicereportid)
                    End With
                    .Connection = con
                    .ExecuteNonQuery()
                    'dim command1 as new mysqlcommand
                    'command1.parameters.addwithvalue("@id", servicereportid)
                    'command1.parameters.addwithvalue("@transactedbys", "system")
                    'command1.commandtext = "inventory_servicereport_reversal"
                    'command1.commandtype = commandtype.storedprocedure
                    'command1.connection = con
                    'command1.executenonquery()
                    'command1.dispose()
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
            Dim id As Integer = Me.c1flexgrid1.rows(Me.c1flexgrid1.rowsel).item("servicereportid")
            readdetails("select * from servicereport where servicereportid=" & id, 2)
        Catch ex As exception
            'showMessage(ex.Message, "exception found", "contact system admin", 1)
        End Try
    End Sub

    Private Sub cancelapprovedcommand_click(ByVal sender As system.object, ByVal e As c1.win.c1command.clickeventargs) Handles cancelapprovedcommand.click
        Try
            Dim id As Integer = Me.c1flexgrid1.rows(Me.c1flexgrid1.rowsel).item("servicereportid")
            readdetails("select * from servicereport where servicereportid=" & id, 5)
        Catch ex As exception
            'showMessage(ex.Message, "exception found", "contact system admin", 1)
        End Try
    End Sub
End Class


