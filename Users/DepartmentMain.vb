﻿Imports mysql.data.mysqlclient
Public Class departmentsmain
    Public querystring As String = ""

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
    Private Sub inputbutton1_click(ByVal sender As system.object, ByVal e As system.eventargs) Handles inputbutton1.click
        Dim i As String = " where departmentname like '%" & convertquotes(Me.departmentcombo.text) & _
            "%' and description like '%" & convertquotes(Me.descriptiontextbox.text) & _
            "%' "
        Dim isactive = ""
        If Me.activeboth.checked = True Then isactive = "" Else isactive = " and active=" & convert.tosingle(Me.activeyes.checked)
        queryall(i & isactive)
    End Sub
    Private Sub queryall(ByVal a As String)
        querystring = a
        loaddata("departments_gridmain", a, Me.c1flexgrid1)
    End Sub
    Private Sub c1flexgrid1_mouseclick(ByVal sender As system.object, ByVal e As system.windows.forms.mouseeventargs) Handles c1flexgrid1.mouseclick
        DataGridView1_MouseClick(sender, e, Me.C1FlexGrid1, Me.C1ContextMenu1)
        If (e.Button = Windows.Forms.MouseButtons.Right) Then

            C1ContextMenu1.ShowContextMenu(C1FlexGrid1, e.Location)
        End If
    End Sub
    Private Sub curriculummain_load(ByVal sender As Object, ByVal e As system.eventargs) Handles me.load

        queryall("")
    End Sub
    Private Sub addnewcommand_click(ByVal sender As system.object, ByVal e As c1.win.c1command.clickeventargs) Handles addnewcommand.click
        Dim x As New departmentsentry(0)
        With x
            .startposition = formstartposition.centerscreen
            .showdialog()
        End With
    End Sub
    Private Sub deleterecordcommand_click(ByVal sender As system.object, ByVal e As c1.win.c1command.clickeventargs) Handles deleterecordcommand.click
        Try
            Dim sagot As msgboxresult = messagebox.show("performing the command will delete the selected record. are you sure you want to proceed?", "delete record?", messageboxbuttons.yesnocancel, messageboxicon.stop)
            If sagot = msgboxresult.yes Then
                saveeditdelete("delete from departments where departmentid=" & Me.c1flexgrid1.rows(Me.c1flexgrid1.rowsel).item("departmentid"), "deleted")
                refreshform()
            End If
        Catch ex As exception
        End Try
    End Sub
    Public Sub refreshform()
        loaddata("departments_gridmain", Me.querystring, Me.c1flexgrid1)
    End Sub

    Private Sub editrecordcommand_click(ByVal sender As Object, ByVal e As c1.win.c1command.clickeventargs) Handles editrecordcommand.click
        Try
            Dim id As Integer = Me.c1flexgrid1.rows(Me.c1flexgrid1.rowsel).item("departmentid")
            Dim x As New departmentsentry(id)
            With x


                .startposition = formstartposition.centerscreen
                .showdialog()
            End With
        Catch ex As exception
        End Try
    End Sub

    Private Sub refreshcommand_click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles RefreshCommand.Click
        Me.refreshform()
    End Sub

    Private Sub inputbutton2_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputButton2.Click
        Me.ActiveBoth.Checked = True
        Me.DepartmentCombo.Text = Nothing
        Me.DescriptionTextbox.Text = Nothing
    End Sub

    Private Sub inputbutton3_click(ByVal sender As system.object, ByVal e As system.eventargs) Handles inputbutton3.click
        Me.refreshform()
    End Sub

    Private Sub exportgriddatalist_click(ByVal sender As system.object, ByVal e As c1.win.c1command.clickeventargs) Handles exportgriddatalist.click
        exportgriddata(Me.c1flexgrid1)
    End Sub
End Class


