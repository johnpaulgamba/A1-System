Imports mysql.data.mysqlclient
Public Class inventory_setup_items
    Sub New()

        ' this call is required by the designer.
        initializecomponent()
        loadingvaluestocomboboxes_storedproc("admin_warehouse_combobox_activeonly", Me.sources, "warehousename", "warehouseid")
        loadingvaluestocomboboxes_storedproc("admin_branches_combobox_activeonly", Me.branch, "branchname", "branchid")
    End Sub
    Private Sub searchbutton_click(sender As system.object, e As system.eventargs) Handles searchbutton.click
        loadtogridnofixed("select a.itemid, 0, concat('msi  ', a.itemid) as reference, " & _
               " itemname, uom  from items a " & _
               " where a.active=1  " & _
               " and a.itemid not in " & _
               " (select itemid from inventory where warehouseid=" & Me.sources.selectedvalue & _
               " and branchid=" & Me.branch.selectedvalue & ")  order by itemname", Me.c1flexgrid1)
    End Sub

    Private Sub savepricelist_click(sender As system.object, e As system.eventargs) Handles setupitems.click
        For i As Integer = 1 To Me.c1flexgrid1.rows.count - 1
            Try
                With Me.c1flexgrid1.rows(i)
                    If .item("check") = False Then Continue For
                    Dim depositid As Integer = searchrecord("select auto_increment from information_schema.tables where  table_schema='" & database & "' and table_name='inventory';", 1)
                    connect()
                    con.open()
                    Dim command As New mysqlcommand
                    command.commandtext = "insert into inventory (itemid, onhand, warehouseid, branchid) values (@itemids, @quantitys, @warehouseids, @branchids)"
                    command.parameters.addwithvalue("@itemids", .item("itemid"))
                    command.parameters.addwithvalue("@warehouseids", Me.sources.selectedvalue)
                    command.parameters.addwithvalue("@branchids", Me.branch.selectedvalue)
                    command.parameters.addwithvalue("@quantitys", 0)
                    command.parameters.addwithvalue("@transactiontypes", "item setup")
                    command.parameters.addwithvalue("@referencess", "inv " & depositid.tostring("d10"))
                    command.parameters.addwithvalue("@transactedbys", "system")
                    command.parameters.addwithvalue("@remarkss", "setting up items")
                    command.connection = con
                    command.executenonquery()
                    command.commandtext = "inventory_setup_items"
                    command.commandtype = commandtype.storedprocedure
                    command.connection = con
                    command.executenonquery()
                End With
                con.close()
                command.dispose()
            Catch ex As exception
            End Try
        Next
        showmessage("the item setup has been successfully executed", "command success!", "command executed", 3)
        Me.searchbutton_click(sender, e)
    End Sub

    Private Sub inputbutton2_click(sender As system.object, e As system.eventargs) Handles inputbutton2.click
        Me.close()
    End Sub

    Private Sub inputbutton3_click(sender As system.object, e As system.eventargs) Handles inputbutton3.click
        Me.branch.selectedindex = -1
        Me.sources.selectedindex = -1

    End Sub
End Class

