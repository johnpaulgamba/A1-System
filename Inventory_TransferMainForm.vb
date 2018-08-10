Imports mysql.data.mysqlclient
Public Class inventory_transfermainform


    Private Sub warehousemainform_load(sender As Object, e As system.eventargs) Handles me.load
        Me.c1navbar1.panelheaderfont = New font("arial", 12, fontstyle.bold)
        Me.c1navbar2.panelheaderfont = New font("arial", 12, fontstyle.bold)
        Me.transferfrom.value = now
        Me.transferto.value = now
        searchbutton_click(sender, e)
    End Sub
    Private filter As String = ""
    Private Sub searchbutton_click(sender As system.object, e As system.eventargs) Handles searchbutton.click
        Dim transferdatequery As String = ""
        If Me.transferfrom.text = Nothing And Me.transferto.text = Nothing Then
            transferdatequery = ""
        Else
            If Me.transferfrom.text <> Nothing Then
                If transferto.text <> Nothing Then
                    transferdatequery = " and  date_format(a.transferdate, '%Y/%m/%d')  between '" & Format(TransferFrom.Value, "yyyy/MM/dd") & "' and '" & Format(TransferTo.Value, "yyyy/MM/dd") & "' "
                Else
                    transferdatequery = " and  a.transferdate >= '" & Format(TransferFrom.Value, "yyyy/MM/dd") & "' "
                End If
            Else
                If TransferTo.Text <> Nothing Then
                    transferdatequery = " and a.transferdate<= '" & Format(TransferTo.Value, "yyyy/MM/dd") & "' "
                Else
                    transferdatequery = " and a.transferdate like '%%' "
                End If
            End If
        End If

        Dim filterquery As String = " and  a.transferid like '%" & convertquotes(Me.iareference.text) & _
            "%' and c.warehousename like '%" & convertquotes(Me.warehousefrom.text) & _
            "%' and e.warehousename like '%" & convertquotes(Me.warehouseto.text) & _
            "%' and b.branchname like '%" & convertquotes(Me.branchfrom.text) & _
            "%' and d.branchname like '%" & convertquotes(Me.branchto.text) & _
            "%' and a.datecreated like '%" & convertquotes(Me.datecreated.text) & _
            "%' and a.lastupdate like '%" & convertquotes(Me.lastupdate.text) & _
            "%' and a.creator like '%" & convertquotes(Me.creator.text) & "%' "
        Me.filter = filterquery & transferdatequery
        loaddata("transaction_inventory_transfer_main", filter, Me.c1flexgrid1)

    End Sub

    Private Sub addnew_click(sender As system.object, e As c1.win.c1command.clickeventargs) Handles addnew.click
        Dim x As New inventory_transfer(0)
        With x
            .startposition = formstartposition.centerparent
            .showdialog()
        End With
    End Sub

    Private Sub editrecord_click(sender As system.object, e As c1.win.c1command.clickeventargs) Handles editrecord.click
        Try
            Dim id As Integer = Me.c1flexgrid1.rows(Me.c1flexgrid1.rowsel).item("transferid")
            readdetails("select * from inventory_transfer where transferid=" & id, 3)
        Catch ex As exception
            showmessage(ex.message, "exception found", "contact system admin", 1)
        End Try
    End Sub

    Private Sub c1flexgrid1_doubleclick(sender As Object, e As system.eventargs) Handles c1flexgrid1.doubleclick
        Try
            Dim id As Integer = Me.c1flexgrid1.rows(Me.c1flexgrid1.rowsel).item("transferid")
            readdetails("select * from inventory_transfer where transferid=" & id, 4)
        Catch ex As exception
            showmessage(ex.message, "exception found", "contact system admin", 1)
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
            adapter.selectcommand.parameters.addwithvalue("@id", baketechmainform.employeeid.text)
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
            showmessage(ex.message, "exception found", "contact system admin", 1)
        End Try

    End Sub

    Private Sub exportgriddata_click(ByVal sender As system.object, ByVal e As c1.win.c1command.clickeventargs) Handles exportgrid.click
        exportgriddata(Me.c1flexgrid1)
    End Sub

    Public Sub refreshgrid_click() Handles refreshgrid.click
        loaddata("transaction_inventory_transfer_main", filter, Me.c1flexgrid1)
    End Sub

    Private Sub clearbutton_click(sender As system.object, e As system.eventargs) Handles clearbutton.click
        Me.iareference.text = Nothing
        Me.warehousefrom.text = Nothing
        Me.lastupdate.text = Nothing
        Me.datecreated.text = Nothing
        Me.creator.text = Nothing
        Me.transferfrom.value = now
        Me.transferto.value = now
    End Sub

    Private Sub printrecord_click(sender As system.object, e As c1.win.c1command.clickeventargs) Handles printrecord.click
        Try
            Dim id As Integer = Me.c1flexgrid1.rows(Me.c1flexgrid1.rowsel).item("transferid")
            Dim x As New reportpreview
            With x
                .print("reporting_inventory_transfer_solo", "id", id, 5)
                .text = "print preview of tr " & id.tostring("d10")
                .startposition = formstartposition.centerparent
                .windowstate = formwindowstate.maximized
                .show()
            End With
        Catch ex As exception
            showmessage(ex.message, "exception found", "contact system admin", 1)
        End Try
    End Sub
    Private Sub cancelcommand_click(sender As system.object, e As c1.win.c1command.clickeventargs) Handles cancelcommand.click
        Try
            Dim id As Integer = Me.c1flexgrid1.rows(Me.c1flexgrid1.rowsel).item("transferid")
            readdetails("select * from inventory_transfer where transferid=" & id, 1)
        Catch ex As exception
            showmessage(ex.message, "exception found", "contact system admin", 1)
        End Try
    End Sub
    Private Sub readdetails(ByVal sql As String, ByVal b As Integer)
        Try
            Dim transferid As Integer = 0
            Dim ds As New dataset
            connect()
            con.open()
            Dim adapter As New mysqldataadapter(sql, con)
            With adapter
                .fill(ds)
                .dispose()
            End With
            con.close()
            transferid = ds.tables(0).rows(0).item("transferid")
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
                        .commandtext = "update inventory_transfer set iscancelled=@iscancelled, cancelledby=@cancelledby, datecancelled=@datecancelled, " & _
                       "lastupdate=@lastupdate where transferid=@transferid"
                    ElseIf b = 2 Then
                        .commandtext = "update inventory_transfer set isapproved=@iscancelled, approvedby=@cancelledby, dateapproved=@datecancelled, " & _
                       "lastupdate=@lastupdate where transferid=@transferid"
                    End If
                    With .parameters
                        .AddWithValue("@cancelledby", BakeTechMainForm.UserFullName.Text)
                        .AddWithValue("@datecancelled", Format(Now, "yyyy-MM-dd HH:mm:ss"))
                        .addwithvalue("@iscancelled", 1)
                        .addwithvalue("@lastupdate", "" & now)
                        .addwithvalue("@transferid", transferid)
                    End With
                    .connection = con
                    .executenonquery()

                    If b = 2 Then
                        Dim command1 As New mysqlcommand
                        command1.parameters.addwithvalue("@id", transferid)
                        command1.parameters.addwithvalue("@transactedbys", baketechmainform.userfullname.text)
                        command1.commandtext = "inventory_transfer_approval"
                        command1.commandtype = commandtype.storedprocedure
                        command1.connection = con
                        command1.executenonquery()
                    End If
                    con.close()
                    command.dispose()
                    showmessage("the command has been successfully executed.", "command successful", "command executed", 3)
                    Me.refreshgrid_click()
                End With
            ElseIf b = 3 Then
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
                Dim x As New inventory_transfer(transferid)
                With x
                    .startposition = formstartposition.centerparent
                    .showdialog()
                End With
            ElseIf b = 4 Then
                Dim x As New inventory_transfer(transferid)
                With x
                    .toenable(False)
                    .startposition = formstartposition.centerparent
                    .showdialog()
                End With
            End If
        Catch ex As exception
        End Try
    End Sub

    Private Sub approvecommand_click(sender As system.object, e As c1.win.c1command.clickeventargs) Handles approvecommand.click
        Try
            Dim id As Integer = Me.c1flexgrid1.rows(Me.c1flexgrid1.rowsel).item("transferid")
            readdetails("select * from inventory_transfer where transferid=" & id, 2)
        Catch ex As exception
            showmessage(ex.message, "exception found", "contact system admin", 1)
        End Try
    End Sub

End Class


