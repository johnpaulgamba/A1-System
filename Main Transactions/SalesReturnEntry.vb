Imports mysql.data.mysqlclient
Public Class salesreturnentry
    Sub New(ByVal id As Integer)

        ' this call is required by the designer.
        initializecomponent()
        loadingvaluestocomboboxes_storedproc("admin_customers_combobox_activeonly", Me.customername, "customername", "customerid")
        loadingvaluestocomboboxes_storedproc("admin_branches_combobox_activeonly", Me.branchname, "branchname", "branchid")
        loadingvaluestocomboboxes_storedproc("admin_warehouse_combobox_activeonly", Me.warehousename, "warehousename", "warehouseid")
        AddHandler Me.customername.selectedindexchanged, AddressOf Me.customername_selectedindexchanged
        If id = 0 Then Me.returndate.value = now
        If id <> 0 Then loadentriesmodify(id)
    End Sub
    Private Sub loadentriesmodify(ByVal id As Integer)
        Try
            Dim ds As New dataset
            Dim adapter As New mysqldataadapter("select a.*, b.salesorderid, b.dateordered, b.deliverydate, b.customerid " & _
                                                " from salesreturn a join salesorder b on a.salesorderid=b.salesorderid where returnid=" & id, con)
            With adapter
                .fill(ds)
                .dispose()
            End With
            con.close()
            With ds.tables(0).rows(0)
                Me.returnid = .item("returnid")
                Me.srreference.text = "sr  " & Me.returnid.tostring("d10")
                Me.tosave = False
                Me.dateordered.value = .item("dateordered")
                Me.returndate.value = .item("returndate")
                Me.deliverydate.value = .item("deliverydate")
                Me.customername.selectedvalue = .item("customerid")
                Me.remarks.text = .item("remarks")
                Me.branchname.selectedvalue = .item("branchid")
                Me.warehousename.selectedvalue = .item("warehouseid")
                Me.salesorderid = .item("salesorderid")
                Me.soreference.text = "so  " & Me.salesorderid.tostring("d10")
                loadtogridnofixed("select a.itemid, itemname, b.uom, unitprice, quantity, discount, " & _
                           "(unitprice*quantity) - (quantity* discount),  remarks from items a " & _
                           " join salesreturnorders  b on a.itemid=b.itemid and returnid=" & id, Me.c1flexgrid1)
                Me.loaddatabutton.enabled = False
                Me.filtersoreference.enabled = False
                compute()
            End With
        Catch ex As exception
            Me.returnid = 0
            Me.srreference.text = Nothing
            Me.dateordered.text = Nothing
            Me.returndate.text = Nothing
            Me.deliverydate.text = Nothing
            Me.customername.selectedindex = -1
            Me.remarks.text = Nothing
            Me.branchname.selectedindex = -1
            Me.warehousename.selectedindex = -1
            Me.salesorderid = 0
            Me.soreference.text = Nothing
            Me.c1flexgrid1.rows.count = 1
            Me.loaddatabutton.enabled = False
            Me.filtersoreference.enabled = False
            compute()
        End Try
    End Sub

    Private Sub loadentries(ByVal id As Integer)
        Try
            Dim ds As New dataset
            Dim adapter As New mysqldataadapter("select * from salesorder where salesorderid=" & id, con)
            With adapter
                .fill(ds)
                .dispose()
            End With
            con.close()
            With ds.tables(0).rows(0)
                Me.dateordered.value = .item("dateordered")
                Me.deliverydate.value = .item("deliverydate")
                Me.customername.selectedvalue = .item("customerid")
                Me.remarks.text = .item("remarks")
                Me.branchname.selectedvalue = .item("branchid")
                Me.warehousename.selectedvalue = .item("warehouseid")
                Me.salesorderid = .item("salesorderid")
                Me.soreference.text = "so  " & Me.salesorderid.tostring("d10")
                loadtogridnofixed("select a.itemid, itemname, b.uom, unitprice, quantity, discount, " & _
                           "(unitprice*quantity) - (quantity* discount),  remarks from items a  " & _
                           " join salesorderorders b on a.itemid=b.itemid and salesorderid=" & id, Me.c1flexgrid1)

                compute()
            End With
        Catch ex As exception
            Me.dateordered.text = Nothing
            Me.deliverydate.text = Nothing
            Me.customername.selectedindex = -1
            Me.remarks.text = Nothing
            Me.branchname.selectedindex = -1
            Me.warehousename.selectedindex = -1
            Me.salesorderid = 0
            Me.soreference.text = Nothing
            Me.c1flexgrid1.rows.count = 1
        End Try
    End Sub

    Private Sub customername_selectedindexchanged(sender As system.object, e As system.eventargs)
        Dim id As Integer = 0
        Try
            id = Me.customername.selectedvalue
            loadcustomerdetails(id)
        Catch ex As exception
            Me.address.text = Nothing
            Me.contactno.text = Nothing
            Me.businesstype.text = Nothing
            Me.tin.text = Nothing
            Me.contactno.text = Nothing
        End Try
    End Sub
    Private Sub loadcustomerdetails(ByVal id As Integer)
        Try
            Dim ds As New dataset
            connect()
            con.open()
            Dim adapter As New mysqldataadapter("select * from customers where customerid=" & id, con)
            With adapter
                .fill(ds)
                .dispose()
            End With
            con.close()
            With ds.tables(0).rows(0)
                Me.address.text = .item("address")
                Me.contactno.text = .item("contactno")
                Me.businesstype.text = .item("businesstype")
                Me.tin.text = .item("tin")
                Me.contactno.text = .item("contactno")
            End With
        Catch ex As exception

        End Try
    End Sub

    Private Sub saverecord_click(sender As System.Object, e As System.EventArgs) Handles SaveRecord.Click
        If Me.CustomerName.Text = Nothing Then
            showMessage("invalid customer selected. make sure that you supplied valid customer.", "customer is invalid", "not valid", 3)
            Exit Sub
        End If
        If Me.BranchName.Text = Nothing Then
            showMessage("invalid branch selected. make sure that you supplied valid branch.", "branch is invalid", "not valid", 3)
            Exit Sub
        End If
        If Me.WarehouseName.Text = Nothing Then
            showMessage("invalid warehouse selected. make sure that you supplied valid warehouse.", "warehouse is invalid", "not valid", 3)
            Exit Sub
        End If
        If Me.C1FlexGrid1.Aggregate(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, 0, Me.C1FlexGrid1.Rows.Count - 1, 0) = 0 Then
            showMessage("you are required to input at least one valid item", "ordered items invalid", "not valid", 3)
            Exit Sub
        End If
        If Me.DeliveryDate.Text = Nothing Then
            showMessage("invalid delivery date. make sure that you supplied valid delivery date.", "delivery date is invalid", "not valid", 3)
            Exit Sub
        End If
        If Me.ReturnDate.Text = Nothing Then
            showMessage("invalid return date make sure that you supplied valid return date.", "return date is invalid", "not valid", 3)
            Exit Sub
        End If
        If tosave = True Then
            Dim depositid As Integer = searchRecord("select auto_increment from information_schema.tables where  table_schema='" & database & "' and table_name='salesreturn';", 1)
            savecommand("transaction_salesreturn_entry", depositid)
        Else
            savecommand("transaction_salesreturn_entry", Me.returnid)
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
                    .addwithvalue("@returndates", Me.returndate.value)
                    .addwithvalue("@returnids", depositid)
                    .addwithvalue("@salesorderids", Me.salesorderid)
                    .addwithvalue("@datecreateds", "" & now)
                    .addwithvalue("@creators", APCESMainForm.userfullname.text)
                    .addwithvalue("@isapproveds", 0)
                    .addwithvalue("@iscancelleds", 0)
                    .addwithvalue("@approvedbys", "")
                    .addwithvalue("@cancelledbys", "")
                    .addwithvalue("@remarkss", Me.remarks.text)
                    .addwithvalue("@branchids", Me.branchname.selectedvalue)
                    .addwithvalue("@warehouseids", Me.warehousename.selectedvalue)
                    .addwithvalue("@tosave", Me.tosave)
                    .addwithvalue("@grossamounts", Me.grossamount.text.replace("php ", "").replace(",", ""))
                End With
                .executenonquery()
                Dim mynewcommand As New mysqlcommand
                With mynewcommand
                    If Me.tosave = False Then
                        .commandtext = "delete from salesreturnorders where returnid=" & depositid
                        .connection = con
                        .commandtype = commandtype.text
                        .executenonquery()
                    End If
                    .commandtext = "insert into `salesreturnorders` (`returnid`,`itemid`,`uom`,`quantity`,`unitprice`, `discount`, `remarks`)" & _
                        " values " & saveorders2(depositid, Me.c1flexgrid1)
                    .connection = con
                    .commandtype = commandtype.text
                    .executenonquery()
                End With
                mytrans.commit()
                .dispose()
                con.close()
                messagebox.show("the record has been successfully saved.", "command executed", messageboxbuttons.ok, messageboxicon.information)
                Me.returnid = depositid
                Me.tosave = False
                Me.srreference.text = "sr " & depositid.tostring("d10")
                salesreturnmainform.refreshgrid_click()
                Return True
                Exit Function
            End With
        Catch ex As exception
            'messagebox.show(ex.message)
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
    Private returnid As Integer = 0
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
                        "', '" & .item("unitprice") &
                        "', '" & .item("percentdiscount") & _
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
               
            ElseIf e.KeyCode = Keys.Delete Then
                If Me.C1FlexGrid1.ColSel = 1 Then
                    Dim sagot As MsgBoxResult = MessageBox.Show("performing the command will delete the entire row. do you want to proceed?", "perform delete?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Stop)
                    If sagot = MsgBoxResult.Yes Then
                        Me.C1FlexGrid1.Rows.Remove(Me.C1FlexGrid1.RowSel)
                        compute()
                    End If
              
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
    Private Sub c1flexgrid1_afteredit(sender As Object, e As C1.Win.C1FlexGrid.RowColEventArgs) Handles C1FlexGrid1.AfterEdit
        Try
            If e.Col = 3 Or e.Col = 4 Or e.Col = 5 Or e.Col = 6 Then
                With Me.C1FlexGrid1.Rows(Me.C1FlexGrid1.RowSel)
                    .Item("gross") = .Item("quantity") * .Item("unitprice") - (.Item("quantity") * .Item("unitprice") * (.Item("percentdiscount") / 100))
                End With
            End If
        Catch ex As Exception
        End Try
        Me.C1FlexGrid1.AutoSizeCols()
        Me.C1FlexGrid1.AutoSizeRows()
        compute()
    End Sub
    Private Sub compute()
        Try
            Dim gross As Double = Me.c1flexgrid1.aggregate(c1.win.c1flexgrid.aggregateenum.sum, 1, 6, Me.c1flexgrid1.rows.count - 1, 6)
            Me.grossamount.text = "php " & gross.tostring("n2")
            Me.vatamount.text = "php " & (gross / 1.12 * 0.12).tostring("n2")
            Me.netsalesamount.text = "php " & (gross - (gross / 1.12 * 0.12)).tostring("n2")
        Catch ex As exception
            Me.grossamount.text = "php 0.00"
            Me.vatamount.text = "php 0.00"
            Me.netsalesamount.text = "php 0.00"
        End Try
    End Sub
    Private salesorderid As Integer = 0
    Private tosave As Boolean = True
    Public Sub toenable(ByVal a As Boolean)
        With Me
            .c1inputpanel5.readonly = Not a
            .c1inputpanel6.enabled = a
            .c1flexgrid1.allowediting = a
            .saverecord.enabled = a
            .inputbutton2.enabled = a

        End With
    End Sub
    Private Sub inputbutton3_click(sender As System.Object, e As System.EventArgs) Handles InputButton3.Click
        Me.SOReference.Text = Nothing
        Me.DateOrdered.Value = Now
        Me.DeliveryDate.Text = Nothing
        Me.BranchName.SelectedIndex = -1
        Me.WarehouseName.SelectedIndex = -1
        Me.CustomerName.SelectedIndex = -1
        Me.Remarks.Text = Nothing
        Me.C1FlexGrid1.Rows.Count = 1
        Me.C1FlexGrid1.Rows.Count = 10
        Me.SRReference.Text = Nothing
        compute()
        Me.tosave = True
        Me.SaveRecord.Enabled = True
        Me.salesorderid = 0
        Me.returnid = 0
        Me.LoadDataButton.Enabled = True
        Me.FilterSOReference.Enabled = True
        Me.toenable(True)
    End Sub

    Private Sub inputbutton2_click(sender As System.Object, e As System.EventArgs) Handles InputButton2.Click
        Try
            Dim x As New reportpreview
            With x
                .print("reporting_salesreturn_solo", "id", Me.returnid, 2, "", "")
                .Text = "print preview of so " & Me.returnid.ToString("d10")
                .StartPosition = FormStartPosition.centerscreen
                .WindowState = FormWindowState.Maximized
                .Show()
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub inputbutton4_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputButton4.Click
        Me.Close()
    End Sub

    Private Sub filtersoreference_keydown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles FilterSOReference.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim x As New salesorderlookup
            With x
                .StartPosition = FormStartPosition.centerscreen
                .ShowDialog()
            End With
            If x.DialogResult = Windows.Forms.DialogResult.OK Then
                Me.salesorderid = x.C1FlexGrid1.Rows(x.C1FlexGrid1.RowSel).Item("salesorderid")
                Me.FilterSOReference.Text = Me.salesorderid
                Me.loadentries(salesorderid)
            End If
        End If
    End Sub

    Private Sub loaddatabutton_click(sender As System.Object, e As System.EventArgs) Handles LoadDataButton.Click
        Dim id As Integer = 0
        Try
            id = Val(Me.FilterSOReference.Text)
        Catch ex As Exception
            id = 0
        End Try
        Me.salesorderid = id
        loadentries(Me.salesorderid)
    End Sub
End Class

