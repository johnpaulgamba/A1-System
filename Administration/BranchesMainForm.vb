Imports mysql.data.mysqlclient
Public Class branchesmainform
    Private Sub warehousemainform_load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.C1NavBar1.PanelHeaderFont = New Font("arial", 12, FontStyle.Bold)
        Me.C1NavBar2.PanelHeaderFont = New Font("arial", 12, FontStyle.Bold)
        loaddata("admin_company_main", "", Me.C1FlexGrid1)
    End Sub
    Private filter As String = ""
    Private Sub searchbutton_click(sender As system.object, e As system.eventargs) Handles searchbutton.click
        Dim filterquery As String = "  and companyname like '%" & convertQuotes(Me.BranchName.Text) & _
            "%' and address like '%" & convertQuotes(Me.Address.Text) & _
            "%' and contactno like '%" & convertQuotes(Me.ContactNo.Text) & _
            "%' and tin like '%" & convertQuotes(Me.TIN.Text) & _
            "%' and lastupdate like '%" & convertQuotes(Me.LastUpdate.Text) & _
            "%' and creator like '%" & convertQuotes(Me.Creator.Text) & "%' "
        Me.filter = filterquery
        loaddata("admin_company_main", filter, Me.C1FlexGrid1)

    End Sub

    Private Sub addnew_click(sender As system.object, e As c1.win.c1command.clickeventargs) Handles addnew.click
        Dim x As New branchesentry(0)
        With x
            .startposition = formstartposition.centerscreen
            .showdialog()
        End With
    End Sub

    Private Sub editrecord_click(ByVal sender As system.object, ByVal e As c1.win.c1command.clickeventargs) Handles editrecord.click
        Try
            Dim id As Integer = Me.C1FlexGrid1.Rows(Me.C1FlexGrid1.RowSel).Item("companyid")
            Dim x As New branchesentry(id)
            With x
                .startposition = formstartposition.centerscreen
                .showdialog()
            End With
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
        loaddata("admin_company_main", filter, Me.C1FlexGrid1)
    End Sub

    Private Sub clearbutton_click(sender As system.object, e As system.eventargs) Handles clearbutton.click
        Me.lastupdate.text = Nothing
        Me.datecreated.text = Nothing
        Me.branchname.text = Nothing
        Me.ContactNo.Text = Nothing
        Me.tin.text = Nothing
        Me.address.text = Nothing
        Me.owner.text = Nothing

    End Sub
End Class


