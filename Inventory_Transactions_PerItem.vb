Imports mysql.data.mysqlclient
Public Class inventory_transactions_peritem
    Sub New(ByVal itemid As Integer, ByVal bname As String, ByVal wname As String, ByVal iname As String)

        ' this call is required by the designer.
        initializecomponent()
        Me.warehousename = convertquotes(wname)
        Me.branchname = convertquotes(bname)
        Me.itemid = itemid
        Me.warehousenamefilter.text = warehousename.toupper
        Me.branchnamefilter.text = bname.toupper
        Me.itemnamefilter.text = iname.toupper
        loadentries()
    End Sub
    Private warehousename As String = ""
    Private branchname As String = ""
    Private itemid As Integer = 0
    Private Sub loadentries()

        loadtogrid("select transactionid, date_format(transactiondate, '%m/%d/%y [%r]') as 'rrdate', " & _
               " reference, transactiontype, branchname, warehousename, itemname,  remarks, quantity, b.uom, a.transactedby " & _
               " from inventorytransactions a " & _
               " join items b  on a.itemid=b.itemid " & _
               " join warehouse c on a.warehouseid=c.warehouseid " & _
               " join branches d on a.branchid=d.branchid " & _
               " where a.itemid=b.itemid   and a.itemid=" & Me.itemid & _
               " and  c.warehousename like '%" & warehousename & "%' " & _
               " and  branchname like '%" & branchname & "%' " & _
               " order by transactiondate desc", Me.c1flexgrid1)
    End Sub
    Private Sub inputbutton4_click(ByVal sender As system.object, ByVal e As system.eventargs) Handles inputbutton4.click
        Me.close()
    End Sub

    Private Sub saverecordbutton_click(ByVal sender As system.object, ByVal e As system.eventargs) Handles saverecordbutton.click
        exportgriddata(Me.c1flexgrid1)

    End Sub



End Class

