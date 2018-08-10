Imports mysql.data.mysqlclient
Public Class servicereport
    Sub New(ByVal id As Integer)

        ' this call is required by the designer.
        initializecomponent()
        loadingvaluestocomboboxes_storedproc("admin_customers_combobox_activeonly", Me.customername, "customername", "customerid")
        loadingvaluestocomboboxes_storedproc("admin_branches_combobox_activeonly", Me.branchname, "branchname", "branchid")
        loadingvaluestocomboboxes_storedproc("admin_warehouse_combobox_activeonly", Me.warehousename, "warehousename", "warehouseid")
        AddHandler Me.customername.selectedindexchanged, AddressOf Me.customername_selectedindexchanged
        If id = 0 Then Me.servedate.value = now
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
            Dim adapter As New mysqldataadapter("select * from servicereport where servicereportid=" & id, con)
            With adapter
                .fill(ds)
                .dispose()
            End With
            con.close()
            With ds.tables(0).rows(0)
                Me.servedate.value = .item("servedate")
                Me.deliverydate.value = .item("deliverydate")
                Me.customername.selectedvalue = .item("customerid")
                Me.remarks.text = .item("remarks")
                Me.branchname.selectedvalue = .item("branchid")
                Me.warehousename.selectedvalue = .item("warehouseid")
                Me.servicereportid = .item("servicereportid")
                Me.technician.text = .item("technician")
                Me.footer.text = .item("footer")
                Me.landmark.text = .item("landmark")
                Me.tosave = False
                Me.sereference.text = "se  " & Me.servicereportid.tostring("d10")
                loadtogridnofixed("select a.itemid, itemname, b.uom,  quantity,   " & _
                           "  remarks from items a " & _
                           " join servicereportorders b on a.itemid=b.itemid and servicereportid=" & id, Me.c1flexgrid1)

            End With
        Catch ex As exception

        End Try
    End Sub

    Private Sub customername_selectedindexchanged(sender As System.Object, e As System.EventArgs)
        Dim id As Integer = 0
        Try
            id = Me.CustomerName.SelectedValue
            loadcustomerdetails(id)
        Catch ex As Exception
            Me.Address.Text = Nothing
            Me.ContactNo.Text = Nothing
            Me.BusinessType.Text = Nothing
            Me.TIN.Text = Nothing
            Me.ContactNo.Text = Nothing
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

        If tosave = True Then
            Dim depositid As Integer = searchRecord("select auto_increment from information_schema.tables where  table_schema='" & database & "' and table_name='servicereport';", 1)
            savecommand("transaction_servicereport_entry", depositid)
        Else
            savecommand("transaction_servicereport_entry", Me.servicereportid)
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
                    .addwithvalue("@servedates", Me.servedate.value)
                    .addwithvalue("@deliverydates", Me.deliverydate.value)
                    .addwithvalue("@servicereportids", depositid)
                    .addwithvalue("@datecreateds", "" & now)
                    .addwithvalue("@creators", APCESMainForm.userfullname.text)
                    .addwithvalue("@customerids", Me.customername.selectedvalue)
                    .addwithvalue("@remarkss", Me.remarks.text)
                    .addwithvalue("@isapproveds", 0)
                    .addwithvalue("@iscancelleds", 0)
                    .addwithvalue("@approvedbys", "")
                    .addwithvalue("@cancelledbys", "")
                    .addwithvalue("@branchids", Me.branchname.selectedvalue)
                    .addwithvalue("@warehouseids", Me.warehousename.selectedvalue)
                    .addwithvalue("@tosave", Me.tosave)
                    .addwithvalue("@technicians", Me.technician.text)
                    .addwithvalue("@landmarks", Me.landmark.text)
                    .addwithvalue("@footers", Me.footer.text)
                End With
                .executenonquery()
                Dim mynewcommand As New mysqlcommand
                With mynewcommand
                    If Me.tosave = False Then
                        .commandtext = "delete from servicereportorders where servicereportid=" & depositid
                        .connection = con
                        .commandtype = commandtype.text
                        .executenonquery()
                    End If
                    .commandtext = "insert into `servicereportorders` (`servicereportid`,`itemid`,`uom`,`quantity`, `remarks`)" & _
                        " values " & saveorders2(depositid, Me.c1flexgrid1)
                    .connection = con
                    .commandtype = commandtype.text
                    .executenonquery()
                End With
                mytrans.commit()
                .dispose()
                con.close()
                messagebox.show("the record has been successfully saved.", "command executed", messageboxbuttons.ok, messageboxicon.information)
                Me.servicereportid = depositid
                Me.sereference.text = "se " & depositid.tostring("d10")
                Me.tosave = False
                servicereportmainform.refreshgrid_click()
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
    Private Function saveorders2(ByVal id As Integer, ByVal flexgrid As C1.Win.C1FlexGrid.C1FlexGrid) As String
        Dim z11 As String = ""
        Try
            Dim x As Integer = 1
            Dim y As Integer = flexgrid.Rows.Count - 1
            For x = 1 To y
                With flexgrid.Rows(x)
                    If .Item("itemid") = Nothing Then Continue For
                    Dim itemre As String = ""
                    z11 = z11 & " " & "('" & id & _
                        "', '" & .Item("itemid") & _
                        "', '" & .Item("uom") & _
                        "', '" & .Item("quantity") & _
                        "', '" & .Item("remarks") & "')            "

                End With
            Next
        Catch ex As Exception
        End Try
        Return LTrim(RTrim(z11)).Replace("            ", ",")
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
                    Dim x As New ViolationTicketLookup(allitems)
                    With x
                        .StartPosition = FormStartPosition.centerscreen
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
    Private Sub c1flexgrid1_beforeedit(ByVal sender As System.Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) Handles C1FlexGrid1.BeforeEdit
        If e.Col = 3 Then
            If Me.C1FlexGrid1.Rows(Me.C1FlexGrid1.RowSel).Item("itemid") = Nothing Then
                e.Cancel = True
            End If
        End If
    End Sub
    Private servicereportid As Integer = 0
    Private tosave As Boolean = True

    Private Sub inputbutton3_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputButton3.Click
        Me.SEReference.Text = Nothing
        Me.ServeDate.Value = Now
        Me.DeliveryDate.Text = Nothing
        Me.BranchName.SelectedIndex = -1
        Me.WarehouseName.SelectedIndex = -1
        Me.Technician.Text = Nothing
        Me.CustomerName.SelectedIndex = -1
        Me.Remarks.Text = Nothing
        Me.C1FlexGrid1.Rows.Count = 1
        Me.C1FlexGrid1.Rows.Count = 10
        Me.tosave = True
        Me.SaveRecord.Enabled = True
        Me.servicereportid = 0
        Me.toenable(True)
    End Sub

    Private Sub inputbutton2_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputButton2.Click
        Try
            Dim x As New reportpreview
            With x
                .print("reporting_servicereport_solo", "id", Me.servicereportid, 6, "", "")
                .Text = "print preview of se " & Me.servicereportid.ToString("d10")
                .StartPosition = FormStartPosition.centerscreen
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

