Imports mysql.data.mysqlclient
Public Class inventory_per_location
    Sub New(ByVal id As Integer)

        ' this call is required by the designer.
        initializecomponent()
        loaditem(id)
    End Sub
    Private Sub loaditem(ByVal id As Integer)
        loadtogridnofixed("select a.itemid, 0, concat('msi  ', a.itemid) as reference, " & _
               " warehousename, itemname, onhand, a.uom  from items a " & _
               " join inventory b on a.itemid=b.itemid  " & _
               " join warehouse c on b.warehouseid=c.warehouseid  " & _
               " where a.itemid=" & id & " order by warehousename ", Me.c1flexgrid1)
    End Sub

    Private Sub inputbutton2_click(sender As system.object, e As system.eventargs) Handles inputbutton2.click
        Me.close()
    End Sub
End Class

