Imports mysql.data.mysqlclient
Public Class inventory_transactions
    Sub New()

        ' this call is required by the designer.
        initializecomponent()
        loadingvaluestocomboboxes_storedproc("admin_warehouse_combobox_activeonly", Me.warehouse, "warehousename", "warehouseid")
        loadingvaluestocomboboxes_storedproc("admin_branches_combobox_activeonly", Me.branch, "branchname", "branchid")
        Me.datefrom.value = now
        Me.dateto.value = now
    End Sub
    Private Sub loadentries(ByVal a As String, ByVal transactionfilter As String)
        Dim fullquery As String = " and itemname like '%" & convertquotes(Me.itemname.text) & _
          "%' and transactiontype like '%" & convertquotes(Me.transactiontype.text) & "%' "
        loadtogrid("select transactionid, date_format(transactiondate, '%m/%d/%y [%r]') as 'rrdate', " & _
               " reference, transactiontype, branchname, warehousename, itemname,  remarks, quantity, b.uom, a.transactedby " & _
               " from inventorytransactions a " & _
               " join items b  on a.itemid=b.itemid " & _
               " join warehouse c on a.warehouseid=c.warehouseid " & _
               " join branches d on a.branchid=d.branchid " & _
               " where a.itemid=b.itemid   " & _
               " and  c.warehousename like '%" & Me.warehouse.text & "%' " & _
               " and  branchname like '%" & Me.branch.text & "%' " & _
               transactionfilter & fullquery & " order by transactiondate desc", Me.c1flexgrid1)
    End Sub
    Private Sub inputbutton4_click(ByVal sender As system.object, ByVal e As system.eventargs) Handles inputbutton4.click
        Me.close()
    End Sub

    Private Sub saverecordbutton_click(ByVal sender As system.object, ByVal e As system.eventargs) Handles saverecordbutton.click
        exportgriddata(Me.c1flexgrid1)

    End Sub

    Private Sub searchbutton_click(sender As system.object, e As system.eventargs) Handles searchbutton.click
        Dim transactiondatequery As String = ""
        If Me.datefrom.text = Nothing And Me.dateto.text = Nothing Then
            transactiondatequery = ""
        Else
            If Me.datefrom.text <> Nothing Then
                If dateto.text <> Nothing Then
                    transactiondatequery = " and date_format(transactiondate, '%Y/%m/%d')  between '" & Format(DateFrom.Value, "yyyy/MM/dd") & "' and '" & Format(DateTo.Value, "yyyy/MM/dd") & "' "
                Else
                    transactiondatequery = " and transactiondate >= '" & Format(DateFrom.Value, "yyyy/MM/dd") & "' "
                End If
            Else
                If DateTo.Text <> Nothing Then
                    transactiondatequery = " and transactiondate<= '" & Format(DateTo.Value, "yyyy/MM/dd") & "' "
                Else
                    transactiondatequery = " "
                End If
            End If
        End If
        loadentries(transactiondatequery, transactiondatequery)
    End Sub

    Private Sub datefrom_keydown(sender As system.object, e As system.windows.forms.keyeventargs) Handles warehouse.keydown, transactiontype.keydown, itemname.keydown, dateto.keydown, datefrom.keydown
        If e.keycode = keys.enter Then
            Me.searchbutton_click(sender, e)
        End If
    End Sub
End Class

