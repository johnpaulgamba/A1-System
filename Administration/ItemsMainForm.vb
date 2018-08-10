Imports mysql.data.mysqlclient
Public Class itemsmainform
    Private Sub warehousemainform_load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        loadingvaluestoComboBoxes("Select distinct category from items  order by category asc", category, "category", "category")
        Me.C1NavBar1.PanelHeaderFont = New Font("arial", 12, FontStyle.Bold)
        Me.C1NavBar2.PanelHeaderFont = New Font("arial", 12, FontStyle.Bold)
        loaddata("admin_items_main", "", Me.C1FlexGrid1)
    End Sub
    Private filter As String = ""
    Private Sub searchbutton_click(sender As system.object, e As system.eventargs) Handles searchbutton.click
        Dim q1 As String = ""
        Dim q2 As String = ""
        
        Dim filterquery As String = " where itemname like '%" & convertQuotes(Me.Warehouse.Text) & _
             "%' and itemcode like '%" & convertQuotes(Me.itemcode.Text) & _
            "%' and description like '%" & convertQuotes(Me.Description.Text) & _
                "%' and category like '%" & convertQuotes(Me.category.Text) & _
            "%' and datecreated like '%" & convertQuotes(Me.DateCreated.Text) & _
            "%' and lastupdate like '%" & convertQuotes(Me.LastUpdate.Text) & _
            "%' and uom like '%" & convertQuotes(Me.UOM.Text) & _
            "%' and creator like '%" & convertQuotes(Me.Creator.Text) & "%' "

        Me.filter = filterquery
        loaddata("admin_items_main", filter, Me.c1flexgrid1)
    End Sub
    Private Sub addnew_click(sender As system.object, e As c1.win.c1command.clickeventargs) Handles addnew.click
        Dim x As New itemsentry(0)
        With x
            .startposition = formstartposition.centerscreen
            .showdialog()
        End With
    End Sub

    Private Sub editrecord_click(ByVal sender As system.object, ByVal e As c1.win.c1command.clickeventargs) Handles editrecord.click
        Try
            Dim id As Integer = Me.c1flexgrid1.rows(Me.c1flexgrid1.rowsel).item("itemid")
            Dim x As New itemsentry(id)
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

    Private Sub exportgrid_click(sender As system.object, e As c1.win.c1command.clickeventargs) Handles exportgrid.click
        exportgriddata(Me.c1flexgrid1)
    End Sub

    Public Sub refreshgrid_click() Handles refreshgrid.click
        loaddata("admin_items_main", "", Me.C1FlexGrid1)
    End Sub

    Private Sub clearbutton_click(sender As system.object, e As system.eventargs) Handles clearbutton.click
        Me.Warehouse.Text = Nothing
        Me.description.text = Nothing
        Me.lastupdate.text = Nothing
        Me.datecreated.text = Nothing
        Me.Creator.Text = Nothing
        Me.category.SelectedIndex = -1
    End Sub
End Class


