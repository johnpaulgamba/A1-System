Imports MySql.Data.MySqlClient
Public Class DeliveryReceiptentry
    Public tosave, iscancelled As Boolean
    Public deliveryreceiptid As Integer
    Public accept As Boolean = 0
    Public Sub New(ByVal id As Integer)
        ' This call is required by the designer. 
        InitializeComponent()
        loadingvaluestoComboBoxes("Select customername, customerid from customers where companyid='" & companyid & _
                                  "' order by customername asc", CustomerName, "customername", "customerid")
        loadingvaluestoComboBoxes1("Select distinct checkedby from deliveryreceipt order by checkedby asc", CheckedBy, "checkedby", "checkedby")
        loadingvaluestoComboBoxes1("Select distinct approvedby from deliveryreceipt order by approvedby asc", ApprovedBy, "approvedby", "approvedby")
        loadingvaluestoComboBoxes("Select distinct plateno from vehicle order by plateno asc", Vehicle, "plateno", "plateno")
        ' loadingvaluestoComboBoxes("Select distinct creditterms from Deliveryreceipt", creditterms, "creditterms", "creditterms")

        ' Add any initialization after the InitializeComponent() call.
        'If id = 0 Then Me.C1DockingTab1.SelectedIndex = 0 : clear()
        If id = 0 Then
            clear()
        Else
            loadentries(id)
        End If

    End Sub

#Region "Ribbon Controls"
    Private Sub RibbonButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RibbonButton5.Click
        If Me.FontSize.Value <= 1 Then Exit Sub
        Me.FontSize.Value = Me.FontSize.Value - 1
    End Sub

    Private Sub RibbonButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RibbonButton3.Click
        Me.FontSize.Value = Me.FontSize.Value + 1
    End Sub
    Private Sub RibbonTrackBar1_ValueChanged() Handles Me.Load, FontName.TextChanged, FontSize.ValueChanged
        Try
            MainLauncher(0)
            Dim x As Integer = 1
            Dim y As Integer = C1FlexGrid1.Cols.Count - 1
            For x = 1 To y
                Me.C1FlexGrid1.Font = New Font(Me.FontName.Text, Me.FontSize.Value)
                With C1FlexGrid1.Cols(x)
                    .StyleDisplay.Font = New Font(Me.FontName.Text, Me.FontSize.Value + 1, FontStyle.Regular)
                End With
                Me.C1FlexGrid1.Rows(0).StyleDisplay.Font = New Font("Tahoma", Me.FontSize.Value + 1, FontStyle.Bold)
                Me.C1FlexGrid1.AutoSizeCols()
                Me.C1FlexGrid1.AutoSizeRows()
            Next

            Dim x1 As Integer = 1
            Dim y1 As Integer = C1FlexGrid2.Cols.Count - 1
            For x1 = 1 To y1
                Me.C1FlexGrid1.Font = New Font(Me.FontName.Text, Me.FontSize.Value)
                With C1FlexGrid2.Cols(x1)
                    .StyleDisplay.Font = New Font(Me.FontName.Text, Me.FontSize.Value + 1, FontStyle.Regular)

                End With
                Me.C1FlexGrid2.Rows(0).StyleDisplay.Font = New Font("Tahoma", Me.FontSize.Value + 1, FontStyle.Bold)
                Me.C1FlexGrid2.AutoSizeCols()
                Me.C1FlexGrid2.AutoSizeRows()
            Next
            MainLauncher(1)
        Catch ex As Exception
        End Try
    End Sub
#End Region
    Private Sub loadentries(ByVal id As Integer)
        Try
            Dim ds As New DataSet
            Dim adapter As New MySqlDataAdapter("select * from Deliveryreceipt where deliveryreceiptid=" & id, con)
            With adapter
                .Fill(ds)
                .Dispose()
            End With
            con.Close()
            With ds.Tables(0).Rows(0)
                Me.DRDate.Value = .Item("DRdate")
                Me.deliveryreceiptid = .Item("deliveryreceiptid")
                Dim idx As Integer = .Item("drno")
                Me.DRNo.Text = idx.ToString("d6")
                Me.PONO.Text = .Item("poNO")
                Me.GRno.Text = .Item("GRNO")
                Me.Vehicle.Text = .Item("vehicle")
                Me.PreparedBy.Text = .Item("creator")
                Me.CheckedBy.Text = .Item("checkedby")
                Me.ApprovedBy.Text = .Item("Approvedby")
                Me.Remarks.Text = .Item("remarks")
                Me.CustomerName.SelectedValue = .Item("customerid")
                loadingvaluestoComboBoxes("Select shipaddress,shipid from shipaddress where customerid = '" & .Item("customerid") & "'", Shipaddress, "shipaddress", "shipid")
                Me.Shipaddress.SelectedValue = .Item("shipid")
                Me.CreditTerms.Text = .Item("terms")
                Me.accept = .Item("accept")
                Me.C1FlexGrid1.Cols(7).Visible = False
                Me.C1FlexGrid1.Cols(9).Visible = True
                FunctionClass.loadtoGrid("select a.itemid,purchaseorderid, a.pono, b.itemcode,a.itemname,a.uom,a.quantity, a.quantity,a.received,a.unitprice,a.discount,(a.quantity-a.discount)*a.unitprice,a.noofpack,a.pack,a.packing,a.jobticket,a.reference,a.remarks from deliveryreceiptorders a join items b on a.itemid=b.itemid where deliveryreceiptid='" & id & "'", C1FlexGrid1)
                FunctionClass.loadtoGrid("select iscancelled, purchaseorderid, concat('',pono), podate, remarks from purchaseorder where customerid='" & .Item("customerid") & "' and iscancelled <> 1 and companyid='" & companyid & "' order by pono desc", C1FlexGrid2)
                'FunctionClass.loadtoGrid(
                Me.iscancelled = .Item("iscancelled")
                If .Item("iscancelled") = True Then : cancelled.Text = "CANCELLED" : Else : cancelled.Text = "APPROVED" : End If
                tosave = False
                compute()
            End With
        Catch ex As Exception
            'messagebox.show(ex.message)
        End Try
    End Sub
    Public Sub toenable(ByVal a As Boolean)
        With Me
            .C1InputPanel1.ReadOnly = Not a
            .C1InputPanel2.ReadOnly = Not a
            .C1FlexGrid1.AllowEditing = a
            '  .C1FlexGrid3.Visible = a
            .SaveJobOrder.Enabled = a
            '.btnprint.Enabled = a
            .CancelOrder.Enabled = a
            ' toedit = a
            ' InputButton1.Enabled = a
        End With
    End Sub
    Private Sub customername_selectedindexchanged() Handles CustomerName.SelectedIndexChanged
        Dim id As Integer = 0
        Try
            id = Me.CustomerName.SelectedValue
            'MessageBox.Show(Me.customername.SelectedValue)
            loadcustomerdetails(id)

        Catch ex As Exception
            ' 'messagebox.show(ex.message)
        End Try
    End Sub
    Private Sub loadcustomerdetails(ByVal id As Integer)
        Try
            Dim ds As New DataSet
            connect()
            con.Open()
            Dim adapter As New MySqlDataAdapter("select * from customers where customerid=" & id, con)
            With adapter
                .Fill(ds)
                .Dispose()
            End With
            con.Close()
            With ds.Tables(0).Rows(0)
                Me.TIN.Text = .Item("TIN")
                Me.BusinessType.Text = .Item("BusinessType")
                Me.CreditTerms.Text = .Item("terms")
                If Me.tosave = True Then
                    loadingvaluestoComboBoxes("Select shipaddress,shipid from shipaddress where customerid = '" & .Item("customerid") & "'", Shipaddress, "shipaddress", "shipid")
                    FunctionClass.loadtoGrid("select fulfilled, purchaseorderid, concat('',pono), podate, remarks from purchaseorder where customerid='" & id & "' and fulfilled<>1 and iscancelled <> 1 and companyid='" & companyid & "' order by podate desc", C1FlexGrid2)
                        Me.Shipaddress.SelectedIndex = 0
                    End If
            End With
        Catch ex As Exception
            Me.TIN.Text = Nothing
            Me.BusinessType.Text = Nothing
            Me.Shipaddress.SelectedIndex = -1
            Me.CreditTerms.Text = Nothing
        End Try
    End Sub
    Private Sub InputButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewOrder.Click
        clear()
    End Sub
    Public Sub clear()
        Me.C1DockingTab1.SelectedIndex = 0
        'POReference.Text = ""
        Me.PreparedBy.Text = APCESMainForm.UserFullName.Text
        Me.CheckedBy.Text = Nothing
        Me.ApprovedBy.Text = Nothing
        ' AddHandler Me.Supplier.SelectedIndexChanged, AddressOf Me.customername_selectedindexchanged
        Me.DRNo.Text = Nothing
        Me.PONO.Text = Nothing
        Me.PONO.Text = Nothing
        Me.GRno.Text = Nothing
        Me.TIN.Text = Nothing
        Me.BusinessType.Text = Nothing
        Me.Shipaddress.SelectedIndex = -1
        Me.CreditTerms.Text = Nothing
        Me.CreditTerms.Text = Nothing
        Me.Vehicle.SelectedIndex = -1
        Me.CustomerName.Focus()
        Me.C1FlexGrid1.Rows.Count = 6
        Me.CustomerName.SelectedIndex = -1
        toenable(True)
        tosave = True
        Dim drnox As Integer = searchRecord("select max(DRNO) as Auto_Increment from deliveryreceipt where companyid='" & companyid & "'", 1) + 1
        Me.DRNo.Text = drnox.ToString("d5") 'POReference.Focus()
        ' Dim depositid As Integer = searchRecord("select max(deliveryreceiptid) as id from Deliveryreceipt where branchid='" & companyid & "'", 1)
        'Me.RRReference.Text = depositid.ToString("d6")
    End Sub

    Private Sub saverecord_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveJobOrder.Click
        If Me.DRNo.Text = Nothing Then
            showMessage("invalid DR No. make sure that you supplied valid DR No.", "DR No is invalid", "not valid", 3)
            Exit Sub
        End If
        If Me.DRDate.Value = Nothing Then
            showMessage("invalid DR Date. make sure that you supplied valid DR Date.", "DR Date is invalid", "not valid", 3)
            Exit Sub
        End If
        'checkserialgrid()
        If tosave = True Then
            Dim depositid As Integer = searchRecord("select auto_increment from information_schema.tables where  table_schema='" & database & "' and table_name='deliveryreceipt';", 1)
            savecommand("transaction_deliveryreceipt_entry", depositid)
        Else
            savecommand("transaction_deliveryreceipt_entry", deliveryreceiptid)
        End If

    End Sub
    Private Function savecommand(ByVal a As String, ByVal depositid As Integer) As Boolean
        Dim deliveryreceiptid As String = depositid
        Dim mytrans As MySqlTransaction

        connect()
        con.Open()


        Dim commandx As New MySqlCommand
        With commandx
            If tosave = False And iscancelled = False Then
                Dim command1 As New MySqlCommand
                .Parameters.AddWithValue("@id", depositid)
                .CommandText = "Inventory_DeliveryReceipt_Recall"
                .CommandType = CommandType.StoredProcedure
                .Connection = con
                .ExecuteNonQuery()
            End If
        End With

        mytrans = con.BeginTransaction()
        Try
            command = New MySqlCommand
            With command
                .CommandText = a
                .Connection = con
                .CommandType = CommandType.StoredProcedure
                With .Parameters
                    .AddWithValue("@DRdates", Me.DRDate.Value)
                    .AddWithValue("@deliveryreceiptids", depositid.ToString("d10"))
                    .AddWithValue("@companyids", companyid.ToString("d10"))
                    .AddWithValue("@shipids", Shipaddress.SelectedValue)
                    .AddWithValue("@ponos", PONo.Text)
                    .AddWithValue("@DRnos", DRNo.Text)
                    .AddWithValue("@grnos", GRno.Text)
                    .AddWithValue("@datecreateds", "" & Now)
                    .AddWithValue("@creators", Me.PreparedBy.Text)
                    .AddWithValue("@checkedbys", CheckedBy.Text)
                    .AddWithValue("@customerids", Me.CustomerName.SelectedValue)
                    .AddWithValue("@REMARKSS", Me.Remarks.Text)
                    .AddWithValue("@termss", Me.CreditTerms.Text)
                    .AddWithValue("@isapproveds", 1)
                    .AddWithValue("@iscancelleds", 0)
                    .AddWithValue("@accepts", Me.accept)
                    .AddWithValue("@approvedbys", ApprovedBy.Text)
                    .AddWithValue("@cancelledbys", "")
                    .AddWithValue("@vehicles", Vehicle.Text)
                    .AddWithValue("@tosave", Me.tosave)
                    .AddWithValue("@grossamounts", Me.GrossAmount.Text.Replace("PHP ", "").Replace(",", ""))
                End With
                .ExecuteNonQuery()
                Dim mynewcommand As New MySqlCommand
                With mynewcommand


                    If Me.tosave = False Then
                        .CommandText = "delete from deliveryreceiptorders where deliveryreceiptid='" & depositid & "'"
                        .Connection = con
                        .CommandType = CommandType.Text
                        .ExecuteNonQuery()
                    End If

                    If saveorders2(depositid, C1FlexGrid1) <> "" Then
                        .CommandText = "insert into `deliveryreceiptorders` (`deliveryreceiptid`,`purchaseorderid`,`itemid`,`itemname`,`uom`,`quantity`,`received`,`unitprice`, `discount`, `pono`,`pack`,`noofpack`,`jobticket`,`packing`,`reference`,`remarks`)" & _
                            " values " & saveorders2(depositid, Me.C1FlexGrid1)
                        .Connection = con
                        .CommandType = CommandType.Text
                        .ExecuteNonQuery()
                    End If

                    .CommandText = "inventory_deliveryreceipt_approval"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@id", depositid)
                    .Connection = con
                    .ExecuteNonQuery()

                End With
                mytrans.Commit()
                .Dispose()
                con.Close()
                Me.PONO.Text = Get_data("Select group_concat(distinct(pono)) as data from deliveryreceiptorders where deliveryreceiptid='" & depositid & "'", 1)
                showMessage("Click OK to continue", "The record has been successfully saved.", "Successfully saved", 2)
                'MessageBox.Show("the record has been successfully saved.", "command executed", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.tosave = False
                Me.iscancelled = False
                Me.deliveryreceiptid = depositid
                DeliveryReceiptMain.SoRefresh.PerformClick()
                Return True
                Exit Function

            End With

        Catch ex As Exception
            showMessage(ex.Message, "Please fill-up the required information correctly", "Error saving...", 3)
            Try
                mytrans.Rollback()
            Catch ex1 As MySqlException
                If Not mytrans.Connection Is Nothing Then
                    showMessage("an exception of type " & ex1.GetType().ToString() & _
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
                    If .Item("qtydelivered") = Nothing Then Continue For
                    z11 = z11 & " " & "('" & id & _
                          "', '" & .Item("purchaseorderid") & _
                        "', '" & .Item("itemid") & _
                           "', '" & .Item("itemname") & _
                         "', '" & .Item("uom") & _
                          "', '" & .Item("Qtydelivered") & _
                           "', '" & .Item("received") & _
                        "', '" & .Item("unitprice") &
                        "', '" & .Item("discount") & _
                           "', '" & .Item("pono") & _
                              "', '" & .Item("perpack") &
                                "', '" & .Item("noofpacks") & _
                        "', '" & .Item("jobticket") & _
                        "', '" & .Item("packing") & _
                     "', '" & .Item("reference") & _
                        "', '" & .Item("remarks") & _
                          "')            "

                End With
            Next
        Catch ex As Exception
            'messagebox.show(ex.message)
        End Try
        Return LTrim(RTrim(z11)).Replace("            ", ",")
    End Function
    Private Sub compute()
        Try
            Dim gross As Double = Me.C1FlexGrid1.Aggregate(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, 8, Me.C1FlexGrid1.Rows.Count - 1, 8)
            Me.GrossAmount.Text = gross.ToString("n2")
            Me.VATAmount.Text = (gross / 1.12 * 0.12).ToString("n2")
            Me.NetSalesAmount.Text = (gross - (gross / 1.12 * 0.12)).ToString("n2")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Me.GrossAmount.Text = "0.00"
            Me.VATAmount.Text = "0.00"
            Me.NetSalesAmount.Text = "0.00"
        End Try
    End Sub
    Private Sub InputButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintCreditMemo.Click
        Try
            Dim x As New reportpreview
            With x
                .print("Reporting_Deliveryreceipt_Solo", "id", deliveryreceiptid, 3, "", "")
                .Text = "Print  preview of Delivery Receipt "
                .WindowState = FormWindowState.Maximized
                .Show()
            End With
        Catch ex As Exception
        End Try
    End Sub

    Private Sub InputButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelOrder.Click
        Try
            Dim sagot As MsgBoxResult = MessageBox.Show("are you sure you want to perform the command?", "verification", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If sagot = vbYes Then
                connect()
                con.Open()
                Dim command As New MySqlCommand
                With command

                    If iscancelled = True Then
                        showMessage("The entry has already been cancelled.", "Already Cancelled.", "Not allowed to cancel", 4)
                    Else
                        .CommandText = "update Deliveryreceipt set isapproved=0, accept=0, iscancelled=1, cancelledby='" & APCESMainForm.UserFullName.Text & "',lastupdate='" & "" & Now & "',datecancelled='" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "' where deliveryreceiptid='" & deliveryreceiptid & "'"
                        .Connection = con

                        .ExecuteNonQuery()
                        .Parameters.AddWithValue("@id", deliveryreceiptid)
                        .CommandText = "Inventory_recall_DR"
                        .CommandType = CommandType.StoredProcedure
                        .Connection = con
                        .ExecuteNonQuery()

                        con.Close()
                        command.Dispose()
                        showMessage("the command has been successfully executed.", "command successful", "command executed", 3)
                        Me.cancelled.Text = "CANCELLED"
                        DeliveryReceiptMain.SoRefresh.PerformClick()
                        End

                    End If
                End With
            End If
        Catch ex As Exception
            'messagebox.show(ex.message)
        End Try
    End Sub

    Private Sub InputButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub c1flexgrid1_keydown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1FlexGrid1.KeyDown
        Try

            If Me.C1FlexGrid1.ColSel = 14 Then
                If e.KeyCode = Keys.Enter Then
                    Dim rowsel1 = Val(Me.C1FlexGrid1.RowSel) + 1
                    Me.C1FlexGrid1.Select(rowsel1, 1)
                End If

            ElseIf e.Modifiers = Keys.Control Then
                If e.KeyCode = Keys.C Then
                    Me.C1FlexGrid1.Copy()
                ElseIf e.KeyCode = Keys.V Then
                    Me.C1FlexGrid1.Paste()
                End If

            Else
                If e.KeyCode = Keys.Delete Then
                    Dim sagot As MsgBoxResult = MessageBox.Show("performing the command will delete the entire row. do you want to proceed?", "perform delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Stop)
                    If sagot = MsgBoxResult.Yes Then
                        Me.C1FlexGrid1.Rows.Remove(Me.C1FlexGrid1.RowSel)
                        compute()
                    End If
                End If

            End If
        Catch ex As Exception
            'messagebox.show(ex.message)
        End Try
    End Sub
    Private Sub C1FlexGrid1_AfterEdit(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) Handles C1FlexGrid1.AfterEdit
        Try

            If e.Col = 7 Or e.Col = 8 Or e.Col = 9 Or e.Col = 12 Or e.Col = 13 Or e.Col = 14 Then


                Dim k11 As String = ""
                Dim xo As Integer = Me.C1FlexGrid1.RowSel
                Dim itemid As String = ""
                With Me.C1FlexGrid1.Rows(xo)
                    .Item("packing") = .Item("noofpacks") & " " & .Item("uom") & "s @ " & Val(.Item("qtydelivered")) / Val(.Item("noofpacks")) & " PCS/" & "PACK"
                    '.Item("jobticket") = "JT# " & "(" & .Item("qtydelivered") & ")"
                    .Item("perpack") = Val(.Item("qtydelivered")) / Val(.Item("noofpacks"))


                    itemid = .Item("itemid")
                    If tosave = True Then .Item("received") = 0

                    If tosave = True Then
                        .Item("received") = .Item("qtydelivered")
                    End If


                    Dim k As Integer = 1
                    Dim l As Integer = C1FlexGrid1.Rows.Count - 1

                    For k = 1 To l
                        With C1FlexGrid1.Rows(k)
                            If .Item("itemid") = itemid Then
                                .Item("reference") = callremarks(C1FlexGrid1.Rows(Me.C1FlexGrid1.RowSel).Item("itemid"), C1FlexGrid1)
                            End If
                        End With
                    Next
                End With



                With Me.C1FlexGrid1.Rows(Me.C1FlexGrid1.RowSel)
                    .Item("discount") = "0"
                    .Item("gross") = .Item("qtydelivered") * .Item("unitprice") - (.Item("qtydelivered") * .Item("discount"))
                End With

            End If
            C1FlexGrid1.AutoSizeCols()
            compute()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Function callremarks(ByVal itemid As String, ByVal flexgrid As C1.Win.C1FlexGrid.C1FlexGrid) As String
        Dim z11 As String = ""
        Try
            Dim x As Integer = 1
            Dim y As Integer = flexgrid.Rows.Count - 1
            For x = 1 To y
                With flexgrid.Rows(x)

                    If .Item("itemid") = itemid Then
                        Dim delivered As Integer = .Item("qtydelivered")
                        z11 = z11 & " " & "PO# " & .Item("PONo") & "  (" & delivered.ToString("N0") & ")" & "            "
                    End If

                End With
            Next
        Catch ex As Exception
            'messagebox.show(ex.message)
        End Try
        Return LTrim(RTrim(z11)).Replace("            ", ",")
    End Function

    Private Sub DRNo_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles DRNo.Validated
        If tosave = True Then
            connect()
            con.Open()
            command = New MySqlCommand("select * from deliveryreceipt where drno='" & DRNo.Text & "' and companyid='" & companyid & "'", con)
            reader = command.ExecuteReader
            If reader.Read = True Then
                showMessage("Please retype new DR number", "DR number already exist on our records", "Duplicate DR No", 3)
                Me.DRNo.Text = Nothing
            End If
        End If
    End Sub

    Private Sub InputButton3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewOrder.Click
        clear()
    End Sub
    Private Sub C1FlexGrid2_CellChecked(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) Handles C1FlexGrid2.CellChecked
        Try
            If tosave = True Then
                If companyid = 3 Then
                    FunctionClass.loadtoGrid("Select a.itemid, a.purchaseorderid, concat('',c.pono) as pono,b.itemcode, a.itemname, a.uom,a.quantity-a.fulfilled,0,0,a.unitprice, a.discount, (a.unitprice-a.discount)*a.quantity,a.remarks,a.remarks,a.remarks,a.remarks,a.remarks,a.remarks from purchaseorderorders a join items b on a.itemid=b.itemid join purchaseorder c on a.purchaseorderid=c.purchaseorderid  where a.purchaseorderid in (" & saveordersx(Me.C1FlexGrid2) & ")", C1FlexGrid1)
                Else
                    FunctionClass.loadtoGrid("Select a.itemid, a.purchaseorderid, concat('',c.pono) as pono,b.itemcode, a.itemname, a.uom,a.quantity-a.fulfilled,0,0,a.unitprice, a.discount, (a.unitprice-a.discount)*a.quantity,a.remarks,a.remarks,a.remarks,a.remarks,a.remarks,a.remarks from purchaseorderorders a join items b on a.itemid=b.itemid join purchaseorder c on a.purchaseorderid=c.purchaseorderid  where a.purchaseorderid in (" & saveordersx(Me.C1FlexGrid2) & ") and a.quantity-a.fulfilled > 0", C1FlexGrid1)
                End If
            Else
                FunctionClass.loadtoGrid("Select a.itemid, a.purchaseorderid, concat('',c.pono) as pono,b.itemcode, a.itemname, a.uom,a.quantity-a.fulfilled,0,0,a.unitprice, a.discount, (a.unitprice-a.discount)*a.quantity,a.remarks,a.remarks,a.remarks,a.remarks,a.remarks,a.remarks from purchaseorderorders a join items b on a.itemid=b.itemid join purchaseorder c on a.purchaseorderid=c.purchaseorderid  where a.purchaseorderid in (" & saveordersx(Me.C1FlexGrid2) & ")", C1FlexGrid1)
            End If

            compute()
        Catch ex As Exception
            ' MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Function saveordersx(ByVal flexgrid As C1.Win.C1FlexGrid.C1FlexGrid) As String
        Dim z11 As String = ""
        Try
            Dim x As Integer = 1
            Dim y As Integer = flexgrid.Rows.Count - 1
            For x = 1 To y
                With flexgrid.Rows(x)
                    If .Item("fulfilled") = False Then Continue For
                    z11 = z11 & " " & "" & .Item("purchaseorderid") & "            "
                End With
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return LTrim(RTrim(z11)).Replace("            ", ",")
    End Function

    Private Sub CloseForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseForm.Click
        Me.Close()
    End Sub
End Class

