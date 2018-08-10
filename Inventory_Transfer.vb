Imports mysql.data.mysqlclient
Public Class inventory_transfer
    Sub New(ByVal id As Integer)

        ' this call is required by the designer.
        initializecomponent()
        loadingvaluestocomboboxes_storedproc("admin_branches_combobox_activeonly", Me.branchfrom, "branchname", "branchid")
        loadingvaluestocomboboxes_storedproc("admin_warehouse_combobox_activeonly", Me.warehousefrom, "warehousename", "warehouseid")
        loadingvaluestocomboboxes_storedproc("admin_branches_combobox_activeonly", Me.branchto, "branchname", "branchid")
        loadingvaluestocomboboxes_storedproc("admin_warehouse_combobox_activeonly", Me.warehouseto, "warehousename", "warehouseid")
        loadingvaluestocomboboxes_storedproc("admin_ship_combobox_activeonly", Me.shippingname, "shippingname", "shippingid")
        If id = 0 Then Me.transferdate.value = now
        If id <> 0 Then loadentries(id)

    End Sub
    Public Sub toenable(ByVal a As Boolean)
        With Me
            .c1inputpanel1.readonly = Not a
            .c1inputpanel2.readonly = Not a
            .c1flexgrid1.allowediting = a
            .saverecord.enabled = a
            .inputbutton2.enabled = a
        End With
    End Sub
    Private Sub loadentries(ByVal id As Integer)
        Try
            Dim ds As New dataset
            Dim adapter As New mysqldataadapter("select * from inventory_transfer where transferid=" & id, con)
            With adapter
                .fill(ds)
                .dispose()
            End With
            con.close()
            With ds.tables(0).rows(0)
                Me.transferdate.value = .item("transferdate")
                Me.remarks.text = .item("remarks")
                Me.branchfrom.selectedvalue = .item("branchfrom")
                Me.warehousefrom.selectedvalue = .item("warehousefrom")
                Me.branchto.selectedvalue = .item("branchto")
                Me.warehouseto.selectedvalue = .item("warehouseto")
                Me.transferid = .item("transferid")
                Me.shippingname.selectedvalue = .item("shippingid")
                Me.cost.value = .item("cost")
                Me.tosave = False
                Me.trreference.text = "so  " & Me.transferid.tostring("d10")
                loadtogridnofixed("select a.itemid, itemname, b.uom, quantity, " & _
                           " remarks from items a " & _
                           " join inventory_transferitems b on a.itemid=b.itemid and transferid=" & id, Me.c1flexgrid1)

            End With
        Catch ex As exception

        End Try
    End Sub
    Private Sub saverecord_click(sender As System.Object, e As System.EventArgs) Handles SaveRecord.Click
        If Me.BranchFrom.Text = Nothing Or Me.BranchTo.Text = Nothing Then
            showMessage("invalid branch selected. make sure that you supplied valid branch.", "branch is invalid", "not valid", 3)
            Exit Sub
        End If
        If Me.WarehouseFrom.Text = Nothing Or Me.WarehouseTo.Text = Nothing Then
            showMessage("invalid warehouse selected. make sure that you supplied valid warehouse.", "warehouse is invalid", "not valid", 3)
            Exit Sub
        End If
        If Me.C1FlexGrid1.Aggregate(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, 0, Me.C1FlexGrid1.Rows.Count - 1, 0) = 0 Then
            showMessage("you are required to input at least one valid item", "ordered items invalid", "not valid", 3)
            Exit Sub
        End If

        If tosave = True Then
            Dim depositid As Integer = searchRecord("select auto_increment from information_schema.tables where  table_schema='" & database & "' and table_name='inventory_transfer';", 1)
            savecommand("inventory_transfer_entry", depositid)
        Else
            savecommand("inventory_transfer_entry", Me.transferid)
        End If

    End Sub
    Private Function savecommand(ByVal a As String, ByVal depositid As Integer) As Boolean
        Dim mytrans As mysqltransaction
        connect()
        con.open()
        mytrans = con.begintransaction()
        Try
            command = New mysqlcommand
            With command
                .commandtext = a
                .connection = con
                .commandtype = commandtype.storedprocedure
                With .parameters
                    .addwithvalue("@transferdates", Me.transferdate.value)
                    .addwithvalue("@transferids", depositid)
                    .addwithvalue("@datecreateds", "" & now)
                    .addwithvalue("@creators", baketechmainform.userfullname.text)
                    .addwithvalue("@remarkss", Me.remarks.text)
                    .addwithvalue("@isapproveds", 0)
                    .addwithvalue("@iscancelleds", 0)
                    .addwithvalue("@approvedbys", "")
                    .addwithvalue("@cancelledbys", "")
                    .addwithvalue("@branchfroms", Me.branchfrom.selectedvalue)
                    .addwithvalue("@warehousefroms", Me.warehousefrom.selectedvalue)
                    .addwithvalue("@shippingids", Me.shippingname.selectedvalue)
                    .addwithvalue("@costs", Me.cost.value)
                    .addwithvalue("@branchtos", Me.branchto.selectedvalue)
                    .addwithvalue("@warehousetos", Me.warehouseto.selectedvalue)
                    .addwithvalue("@tosave", Me.tosave)
                End With
                .executenonquery()
                Dim mynewcommand As New mysqlcommand
                With mynewcommand
                    If Me.tosave = False Then
                        .commandtext = "delete from inventory_transferitems where transferid=" & depositid
                        .connection = con
                        .commandtype = commandtype.text
                        .executenonquery()
                    End If
                    .commandtext = "insert into `inventory_transferitems` (`transferid`,`itemid`,`uom`,`quantity`, `remarks`)" & _
                        " values " & saveorders2(depositid, Me.c1flexgrid1)
                    .connection = con
                    .commandtype = commandtype.text
                    .executenonquery()
                End With
                mytrans.commit()
                .dispose()
                con.close()
                messagebox.show("the record has been successfully saved.", "command executed", messageboxbuttons.ok, messageboxicon.information)
                Me.transferid = depositid
                Me.trreference.text = "tr " & depositid.tostring("d10")
                Me.tosave = False
                inventory_transfermainform.refreshgrid_click()
                Return True
                Exit Function
            End With
        Catch ex As exception
            messagebox.show(ex.message)
            Try
                mytrans.rollback()
            Catch ex1 As mysqlexception
                If Not mytrans.connection Is Nothing Then
                    showmessage("an exception of type " & ex1.gettype().tostring() & _
                                      " was encountered while attempting to roll back the transaction.", "exception found", "error", 1)
                End If
            End Try
            Return False
        End Try
    End Function
    Private Function saveorders2(ByVal id As Integer, ByVal flexgrid As c1.win.c1flexgrid.c1flexgrid) As String
        Dim z11 As String = ""
        Try
            Dim x As Integer = 1
            Dim y As Integer = flexgrid.rows.count - 1
            For x = 1 To y
                With flexgrid.rows(x)
                    If .item("itemid") = Nothing Then Continue For
                    Dim itemre As String = ""
                    z11 = z11 & " " & "('" & id & _
                        "', '" & .item("itemid") & _
                        "', '" & .item("uom") & _
                        "', '" & .item("quantity") & _
                        "', '" & .item("remarks") & "')            "

                End With
            Next
        Catch ex As exception
        End Try
        Return ltrim(rtrim(z11)).replace("            ", ",")
    End Function
    Private Sub c1flexgrid1_keydown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles C1FlexGrid1.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If Me.C1FlexGrid1.ColSel = 1 Then
                    Dim allitems As String = " "
                    For c1 As Integer = 1 To Me.C1FlexGrid1.Rows.Count - 1
                        If Me.C1FlexGrid1.Rows(c1).Item("itemid") = Nothing Then Continue For
                        allitems = allitems & "," & Me.C1FlexGrid1.Rows(c1).Item("itemid")
                    Next
                    allitems = allitems.Replace(" ,", "")
                    Dim x As New itemlookup(allitems)
                    With x
                        .StartPosition = FormStartPosition.CenterParent
                        .C1FlexGrid1.Cols("unitprice").Visible = False
                        .ShowDialog()
                    End With
                    If x.DialogResult = Windows.Forms.DialogResult.OK Then
                        Dim xi As Integer = Me.C1FlexGrid1.RowSel
                        Dim xi2 As Integer = 0
                        For Each y As C1.Win.C1FlexGrid.Row In x.C1FlexGrid1.Rows.Selected
                            Dim x1 As Integer = y.Index
                            With x.C1FlexGrid1.Rows(x1)
                                Me.C1FlexGrid1.Rows(xi).Item("itemid") = .Item("itemid")
                                Me.C1FlexGrid1.Rows(xi).Item("itemname") = .Item("itemname")
                                Me.C1FlexGrid1.Rows(xi).Item("uom") = .Item("uom")
                                If Me.C1FlexGrid1.Rows(xi).Item("quantity") = Nothing Then Me.C1FlexGrid1.Rows(xi).Item("quantity") = 0
                                Me.C1FlexGrid1.AutoSizeCols()
                            End With
                            If x.C1FlexGrid1.Rows.Selected.Count - 1 < 1 Then Exit Sub
                            xi = xi + 1
                            Me.C1FlexGrid1.Rows.Insert(xi)
                            xi2 = xi
                        Next
                        Me.C1FlexGrid1.Rows.Remove(xi2)
                    End If
                End If
            ElseIf e.KeyCode = Keys.Delete Then
                If Me.C1FlexGrid1.ColSel = 1 Then
                    Dim sagot As MsgBoxResult = MessageBox.Show("performing the command will delete the entire row. do you want to proceed?", "perform delete?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Stop)
                    If sagot = MsgBoxResult.Yes Then
                        Me.C1FlexGrid1.Rows.Remove(Me.C1FlexGrid1.RowSel)
                    End If
                ElseIf Me.C1FlexGrid1.ColSel = 3 Then
                    Me.C1FlexGrid1.Rows(Me.C1FlexGrid1.RowSel).Item("quantity") = 0
                End If
                Me.C1FlexGrid1.AutoSizeRows()
                Me.C1FlexGrid1.AutoSizeCols()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub c1flexgrid1_beforeedit(sender As System.Object, e As C1.Win.C1FlexGrid.RowColEventArgs) Handles C1FlexGrid1.BeforeEdit
        If e.Col = 3 Or e.Col = 5 Or e.Col = 4 Or e.Col = 6 Then
            If Me.C1FlexGrid1.Rows(Me.C1FlexGrid1.RowSel).Item("itemid") = Nothing Then
                e.Cancel = True
            End If
        End If
    End Sub
    Private transferid As Integer = 0
    Private tosave As Boolean = True

    Private Sub inputbutton3_click(sender As System.Object, e As System.EventArgs) Handles InputButton3.Click
        Me.TRReference.Text = Nothing
        Me.TransferDate.Value = Now
        Me.BranchFrom.SelectedIndex = -1
        Me.WarehouseFrom.SelectedIndex = -1
        Me.Remarks.Text = Nothing
        Me.C1FlexGrid1.Rows.Count = 1
        Me.C1FlexGrid1.Rows.Count = 10
        Me.tosave = True
        Me.SaveRecord.Enabled = True
        Me.transferid = 0
        Me.WarehouseTo.SelectedIndex = -1
        Me.BranchTo.SelectedIndex = -1
        Me.ShippingName.SelectedIndex = -1
        Me.Cost.Value = 0

        Me.toenable(True)
    End Sub

    Private Sub inputbutton2_click(sender As System.Object, e As System.EventArgs) Handles InputButton2.Click
        Try
            Dim x As New reportpreview
            With x
                .print("reporting_inventory_transfer_solo", "id", Me.transferid, 5)
                .Text = "print preview of tr " & Me.transferid.ToString("d10")
                .StartPosition = FormStartPosition.CenterParent
                .WindowState = FormWindowState.Maximized
                .Show()
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub inputbutton4_click(sender As System.Object, e As System.EventArgs) Handles InputButton4.Click
        Me.Close()
    End Sub
End Class

