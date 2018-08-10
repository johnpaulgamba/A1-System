Imports mysql.data.mysqlclient
Public Class inventory_onhand
    Sub New(ByVal id As Integer)

        ' this call is required by the designer.
        initializecomponent()
        loadingvaluestocomboboxes_storedproc("admin_warehouse_combobox_activeonly", Me.warehouse, "warehousename", "warehouseid")
        loadingvaluestocomboboxes_storedproc("admin_branches_combobox_activeonly", Me.branch, "branchname", "branchid")

    End Sub
    Private Sub inputbutton2_click(ByVal sender As system.object, ByVal e As system.eventargs) Handles inputbutton2.click
        Me.close()
    End Sub
    Private Sub searchbutton_click(ByVal sender As system.object, ByVal e As system.eventargs) Handles searchbutton.click
        loadtogridnofixed("select a.itemid, 0, concat('msi  ', a.itemid) as reference, " & _
             " branchname, warehousename, itemname, onhand, a.uom  from items a " & _
             " join inventory b on a.itemid=b.itemid  " & _
             " join warehouse c on b.warehouseid=c.warehouseid  " & _
             " join branches d on b.branchid=d.branchid " & _
             " where itemname like '%" & convertquotes(Me.itemname.text) & _
             "%' and warehousename like '%" & convertquotes(Me.warehouse.text) & _
             "%' and branchname like '%" & convertquotes(Me.branch.text) & _
             "%' order by itemname ", Me.c1flexgrid1)
    End Sub

    Private Sub inputbutton1_click(sender As system.object, e As system.eventargs) Handles inputbutton1.click
        exportgriddata(Me.c1flexgrid1)
    End Sub

    Private Sub inputbutton4_click(sender As system.object, e As system.eventargs) Handles inputbutton4.click
        Try
            Dim itemid As Integer = Me.c1flexgrid1.rows(Me.c1flexgrid1.rowsel).item("itemid")
            Dim wname As String = Me.c1flexgrid1.rows(Me.c1flexgrid1.rowsel).item("warehousename")
            Dim bname As String = Me.c1flexgrid1.rows(Me.c1flexgrid1.rowsel).item("branchname")
            Dim iname As String = Me.c1flexgrid1.rows(Me.c1flexgrid1.rowsel).item("itemname")
            Dim x As New inventory_transactions_peritem(itemid, bname, wname, iname)
            With x
                .startposition = formstartposition.centerparent
                .showdialog()
            End With
        Catch ex As exception

        End Try
    End Sub
End Class

