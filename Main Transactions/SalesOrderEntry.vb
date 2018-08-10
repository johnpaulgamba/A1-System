Imports MySql.Data.MySqlClient
Public Class SalesOrderEntry
    Public tosave, iscancelled As Boolean
    Public paids As Boolean = False
    Public PurchaseOrderid As Integer
    Public vattype As String = ""
    Public hitory As String = ""
#Region "Ribbon Controls"
    Private Sub UseItemCodeforCoding_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim allitems As String = " "
        For c1 As Integer = 1 To Me.c1FlexGrid1.Rows.Count - 1
            If Me.c1FlexGrid1.Rows(c1).Item("itemcode") = Nothing Then Continue For
            allitems = allitems & "," & Me.c1FlexGrid1.Rows(c1).Item("itemcode")
        Next
        allitems = allitems.Replace(" ,", "")
        Dim x As New ViolationTicketLookup(0)
        With x
            .violation.Focus()
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
        End With
        If x.DialogResult = Windows.Forms.DialogResult.OK Then
            Dim xo As Integer = Me.c1FlexGrid1.RowSel
            Dim xi2 As Integer = 0

            For Each y As C1.Win.C1FlexGrid.Row In x.C1FlexGrid1.Rows.Selected
                Dim x1 As Integer = y.Index
                With x.C1FlexGrid1.Rows(x1)
                    Me.c1FlexGrid1.Rows(xo).Item("itemid") = .Item("itemid")
                    Me.c1FlexGrid1.Rows(xo).Item("ItemCode") = .Item("itemcode")
                    Me.c1FlexGrid1.Rows(xo).Item("itemname") = .Item("itemname")
                    Me.c1FlexGrid1.Rows(xo).Item("uom") = .Item("uom")
                    Me.c1FlexGrid1.Rows(xo).Item("unitprice") = .Item("unitprice")
                    If Me.c1FlexGrid1.Rows(xo).Item("Balance") = Nothing Then Me.c1FlexGrid1.Rows(xo).Item("Balance") = 0
                    If Me.c1FlexGrid1.Rows(xo).Item("QUANTITy") = Nothing Then Me.c1FlexGrid1.Rows(xo).Item("quantity") = 0
                    If Me.c1FlexGrid1.Rows(xo).Item("unitprice") = Nothing Then Me.c1FlexGrid1.Rows(xo).Item("unitprice") = 0
                    If Me.c1FlexGrid1.Rows(xo).Item("fulfilled") = Nothing Then Me.c1FlexGrid1.Rows(xo).Item("fulfilled") = 0
                    If Me.c1FlexGrid1.Rows(xo).Item("gross") = Nothing Then Me.c1FlexGrid1.Rows(xo).Item("gross") = 0
                    If Me.c1FlexGrid1.Rows(xo).Item("discount") = Nothing Then Me.c1FlexGrid1.Rows(xo).Item("discount") = 0
                End With
                If x.C1FlexGrid1.Rows.Selected.Count - 1 < 0 Then Exit Sub
                xo = xo + 1
                Me.c1FlexGrid1.Rows.Insert(xo)
                xi2 = xo
            Next
        End If
    End Sub
    Private Sub RibbonButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.FontSize.Value <= 1 Then Exit Sub
        Me.FontSize.Value = Me.FontSize.Value - 1
    End Sub

    Private Sub RibbonButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.FontSize.Value = Me.FontSize.Value + 1
    End Sub
    Private Sub SetNumberOfRows_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim strRows As String
        Dim intRows As Integer
        strRows = InputBox("Please input the number of rows", "Set no. of rows", CStr(c1FlexGrid1.Rows.Count - 1))
        If strRows = "" Then
            Return
        End If
        intRows = Val(strRows)
        If intRows = c1FlexGrid1.Rows.Count - 1 Or intRows < 1 Or intRows > 10000000 Then
        Else
            c1FlexGrid1.Rows.Count = intRows + 1
        End If
    End Sub
    Private Sub InsertRowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.c1FlexGrid1.Rows.Insert(Me.c1FlexGrid1.Selection.TopRow)
        Catch ex As Exception
            Me.c1FlexGrid1.Rows.Add()
        End Try
    End Sub
    Private Sub DeleteRowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            With Me.c1FlexGrid1
                Dim x As Integer = .Selection.TopRow
                Dim y As Integer = .Selection.BottomRow

                For a As Integer = x To y
                    .Rows.Remove(x)
                Next
            End With
        Catch ex As Exception
        End Try
    End Sub
    Private Sub RibbonTrackBar1_ValueChanged() Handles Me.Load, FontName.TextChanged, FontSize.ValueChanged
        Try
            MainLauncher(0)
            With Me.c1FlexGrid1
                .Font = New Font(Me.FontName.Text, Me.FontSize.Value)
                .Cols("ItemCode").StyleDisplay.Font = New Font(Me.FontName.Text, Me.FontSize.Value)
                .Cols("Quantity").StyleDisplay.Font = New Font(Me.FontName.Text, Me.FontSize.Value, FontStyle.Bold)
                .Cols("ItemName").StyleDisplay.Font = New Font(Me.FontName.Text, Me.FontSize.Value)
                .Rows(0).StyleDisplay.Font = New Font("Tahoma", Me.FontSize.Value + 1, FontStyle.Bold)
                .AutoSizeCols()
            End With
            MainLauncher(1)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub ClearContentsButton_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.c1FlexGrid1.Selection.Clear(C1.Win.C1FlexGrid.ClearFlags.Content)
    End Sub
    Private Sub OrderListOfItems_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Delete Then
            ' performDeleteOrder()
        ElseIf e.Modifiers = Keys.Control Then
            If e.KeyCode = Keys.C Then
                Me.c1FlexGrid1.Copy()
            ElseIf e.KeyCode = Keys.V Then
                Me.c1FlexGrid1.Paste()
            End If
        End If
    End Sub
    Private Sub OrderListOfItems_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.SaveJobOrder.Visible = False Then Exit Sub
        Me.RibbonOrderListOfItems.Enabled = True
    End Sub
    Private Sub OrderListOfItems_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.RibbonOrderListOfItems.Enabled = False
        '  Me.LineRow.Visible = False
    End Sub
#End Region
    Public Sub New(ByVal id As Integer)
        ' This call is required by the designer. 
        InitializeComponent()
        loadingvaluestoComboBoxes("Select customername, customerid from customers where companyid='" & companyid & _
                                  "' order by customername asc", CustomerName, "customername", "customerid")
        ' loadingvaluestoComboBoxes("Select distinct creditterms from PurchaseOrder", creditterms, "creditterms", "creditterms")

        ' Add any initialization after the InitializeComponent() call.
        'If id = 0 Then Me.C1DockingTab1.SelectedIndex = 0 : clear()
        If id = 0 Then
            clear()
        Else
            loadentries(id)
        End If
    End Sub
    Private Sub loadentries(ByVal id As Integer)
        Try
            Dim ds As New DataSet
            Dim adapter As New MySqlDataAdapter("select * from PurchaseOrder where PurchaseOrderid=" & id, con)
            With adapter
                .Fill(ds)
                .Dispose()
            End With
            con.Close()
            With ds.Tables(0).Rows(0)
                Me.SIDate.Value = .Item("PODate")
                Me.PurchaseOrderid = .Item("PurchaseOrderid")
                Me.PoNo.Text = .Item("Pono")
                Me.Remarks.Text = .Item("remarks")
                Me.CreditTerms.Text = .Item("terms")
                Me.Remarks.Text = .Item("remarks")
                'Me.Currency.Text = .Item("Currency")
                If .Item("currency") = "Php" Then : Me.Currency.Text = "Philippine Peso" : ElseIf .Item("currency") = "$" Then : Me.Currency.Text = "US Dollar" : End If
                If .Item("Taxcode") = "VAT-In" Then : Me.VATIn.Checked = True : ElseIf .Item("taxcode") = "VAT-Ex" Then : Me.VATEx.Checked = True : End If
                If tosave = False Then
                    FunctionClass.loadtoGrid("Select a.itemid,b.itemcode, a.itemname, a.uom,a.quantity, a.fulfilled, a.quantity-a.fulfilled, a.unitprice,a.discount, a.quantity*(a.unitprice-a.discount), a.remarks from purchaseorderorders a join items b on a.itemid=b.itemid where a.purchaseorderid='" & id & "'", c1FlexGrid1)
                Else

                End If
                Me.iscancelled = .Item("iscancelled")
                If .Item("iscancelled") = True Then : cancelled.Text = "CANCELLED" : Else : cancelled.Text = "APPROVED" : End If
                tosave = False
                compute()
                Me.CustomerName.SelectedValue = .Item("customerid")
                c1FlexGrid1.Rows.Add()
                Me.c1FlexGrid1.Cols(6).AllowEditing = False
                Me.c1FlexGrid1.Cols(7).AllowEditing = False
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
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
            .cancelorder.Enabled = a
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
                Me.Address.Text = .Item("Billaddress")
                Me.CreditTerms.Text = .Item("terms")
                Me.vattype = .Item("vattype")
                If Me.vattype = "VAT Inclusive" Then VATIn.Checked = True Else VATEx.Checked = True
                If Me.tosave = True Then
                    'MessageBox.Show(id)
                    'loadtoGridNoFixed("Select * from deliveryreceipt where customerid='" & id & "'", C1FlexGrid2)
                End If
            End With
        Catch ex As Exception
            Me.TIN.Text = Nothing
            Me.BusinessType.Text = Nothing
            Me.Address.Text = Nothing
            Me.CreditTerms.Text = Nothing
            Me.vattype = Nothing
            'MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub InputButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        clear()
    End Sub
    Public Sub clear()
        'POReference.Text = ""
        Me.PoNo.Text = Nothing
        Me.Currency.Text = "Philippine Peso"
        Me.VATIn.Checked = True
        Me.SIAmount.Text = ""
        Me.CreditTerms.Text = Nothing
        Me.c1FlexGrid1.Rows.Count = 1
        Me.c1FlexGrid1.Rows.Count = 10
        Me.c1FlexGrid1.Cols(6).Visible = False
        Me.c1FlexGrid1.Cols(7).Visible = False
        Me.c1FlexGrid1.Cols(9).Visible = False
        Me.CustomerName.Focus()
        Me.CustomerName.SelectedIndex = -1
        Me.TIN.Text = Nothing
        Me.BusinessType.Text = Nothing
        Me.Address.Text = Nothing
        Me.CreditTerms.Text = Nothing
        Me.vattype = Nothing
        toenable(True)
        tosave = True
        'Dim drnox As Integer = searchRecord("select max(Pono) as Auto_Increment from PurchaseOrder where companyid='" & companyid & "'", 1) + 1
        'Me.PoNo.Text = drnox.ToString("d10") 'POReference.Focus()
        ' Dim depositid As Integer = searchRecord("select max(PurchaseOrderid) as id from PurchaseOrder where branchid='" & companyid & "'", 1)
        'Me.RRReference.Text = depositid.ToString("d6")
    End Sub


    Private Sub btnsave_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If tosave = True Then
            connect()
            con.Open()
            command = New MySqlCommand("select * from PurchaseOrder where Pono='" & PoNo.Text & "' and companyid='" & companyid & "'", con)
            reader = command.ExecuteReader
            If reader.Read = True Then
                showMessage("Please retype new PO number", "PO number already exist on our records", "Duplicate PO No", 3)
                Me.PoNo.Text = Nothing
                Exit Sub
            End If
        End If
        If Me.PoNo.Text = Nothing Then
            showMessage("invalid PO No. make sure that you supplied valid PO No.", "PO No is invalid", "not valid", 3)
            Exit Sub
        End If
        If Me.SIDate.Value = Nothing Then
            showMessage("invalid PO Date. make sure that you supplied valid PO Date.", "PO Date is invalid", "not valid", 3)
            Exit Sub
        End If
        If tosave = True Then
            Dim depositid As Integer = searchRecord("select auto_increment from information_schema.tables where  table_schema='" & database & "' and table_name='PurchaseOrder';", 1)
            savecommand("transaction_SalesOrder_entry", depositid)
        Else
            savecommand("transaction_SalesOrder_entry", PurchaseOrderid)
        End If

    End Sub
    Private Function savecommand(ByVal a As String, ByVal depositid As Integer) As Boolean
        Dim PurchaseOrderid As String = depositid
        Dim mytrans As MySqlTransaction
        connect()
        con.Open()

        Dim commandx As New MySqlCommand
        With commandx
            If tosave = False Then
                Dim command1 As New MySqlCommand
                ' .Parameters.AddWithValue("@id", depositid)
                '.CommandText = "Inventory_PurchaseOrder_Recall"
                '.CommandType = CommandType.StoredProcedure
                '.Connection = con
                '.ExecuteNonQuery()
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
                    .AddWithValue("@POdates", Me.SIDate.Value)
                    .AddWithValue("@PurchaseOrderids", depositid)
                    .AddWithValue("@companyids", companyid)
                    .AddWithValue("@ponos", Pono.Text)
                    .AddWithValue("@datecreateds", "" & Now)
                    .AddWithValue("@creators", APCESMainForm.UserFullName.Text)
                    .AddWithValue("@customerids", Me.CustomerName.SelectedValue)
                    .AddWithValue("@REMARKSS", Me.Remarks.Text)
                    .AddWithValue("@termss", Me.CreditTerms.Text)
                    .AddWithValue("@isapproveds", 1)
                    .AddWithValue("@iscancelleds", 0)
                    .AddWithValue("@fulfilleds", 0)
                    .AddWithValue("@approvedbys", APCESMainForm.UserFullName.Text)
                    .AddWithValue("@tosave", Me.tosave)
                    '.AddWithValue("@Currencys", Currency.Text)
                    .AddWithValue("@historys", "")
                    If Currency.Text = "Philippine Peso" Then : .AddWithValue("@currencys", "Php") : ElseIf Me.Currency.Text = "US Dollar" Then : .AddWithValue("@currencys", "$") : End If
                    If Me.VATIn.Checked = True Then : .AddWithValue("@taxcodes", VATIn.Text) : ElseIf Me.VATEx.Checked = True Then : .AddWithValue("@taxcodes", VATEx.Text) : End If
                    If Currency.Text = "Philippine Peso" Then : .AddWithValue("@grossamounts", Me.GrossAmount.Text.Replace("Php ", "").Replace(",", "")) : ElseIf Me.Currency.Text = "US Dollar" Then : .AddWithValue("@grossamounts", Me.GrossAmount.Text.Replace("$ ", "").Replace(",", "")) : End If
                    If Currency.Text = "Philippine Peso" Then : .AddWithValue("@vatablesaless", Me.NetSalesAmount.Text.Replace("Php ", "").Replace(",", "")) : ElseIf Me.Currency.Text = "US Dollar" Then : .AddWithValue("@vatablesaless", Me.NetSalesAmount.Text.Replace("$ ", "").Replace(",", "")) : End If
                    If Currency.Text = "Philippine Peso" Then : .AddWithValue("@vatamounts", Me.VATAmount.Text.Replace("Php ", "").Replace(",", "")) : ElseIf Me.Currency.Text = "US Dollar" Then : .AddWithValue("@vatamounts", Me.VATAmount.Text.Replace("$ ", "").Replace(",", "")) : End If
                End With
                .ExecuteNonQuery()
                Dim mynewcommand As New MySqlCommand
                With mynewcommand

                    If Me.tosave = False Then
                        .CommandText = "delete from PurchaseOrderorders where PurchaseOrderid='" & depositid & "'"
                        .Connection = con
                        .CommandType = CommandType.Text
                        .ExecuteNonQuery()
                    End If

                    If saveorders2(depositid, Me.c1FlexGrid1) <> "" Then
                        .CommandText = "insert into `PurchaseOrderorders` (`PurchaseOrderid`,`itemid`,`itemname`,`uom`,`quantity`,`fulfilled`,`unitprice`, `discount`, `remarks`)" & _
                            " values " & saveorders2(depositid, Me.c1FlexGrid1)
                        .Connection = con
                        .CommandType = CommandType.Text
                        .ExecuteNonQuery()
                    End If

                    .Parameters.AddWithValue("@id", depositid)
                    .CommandText = "Inventory_PurchaseOrder_Approval"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = con
                    .ExecuteNonQuery()

                    .CommandText = "Update PurchaseOrder  set isapproved=1,dateapproved=now(), iscancelled=0 where PurchaseOrderid = '" & depositid & "'"
                    .Connection = con
                    .CommandType = CommandType.Text
                    .ExecuteNonQuery()
                End With
                mytrans.Commit()
                .Dispose()
                con.Close()

                showMessage("Click OK to continue", "The record has been successfully saved.", "Successfully saved", 2)
                'MessageBox.Show("the record has been successfully saved.", "command executed", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.tosave = False
                Me.PurchaseOrderid = depositid
                SalesOrderMain.SoRefresh.PerformClick()
                Return True
                Exit Function
            End With

        Catch ex As Exception
            showMessage(ex.Message, "Error Encountered", "Error saving...", 3)
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
                    If .Item("quantity") = Nothing Then Continue For
                    z11 = z11 & " " & "('" & id & _
                                   "', '" & .Item("itemid") & _
                           "', '" & .Item("itemname") & _
                         "', '" & .Item("uom") & _
                          "', '" & .Item("Quantity") & _
                             "', '" & .Item("fulfilled") & _
                        "', '" & .Item("unitprice") &
                        "', '" & .Item("discount") & "', '" & .Item("remarks") & _
                          "')            "

                End With
            Next
        Catch ex As Exception
            'messagebox.show(ex.message)
        End Try
        Return LTrim(RTrim(z11)).Replace("            ", ",")
    End Function
    Private Sub compute()
        Dim currencyx As String = ""
        If Currency.Text = "Philippine Peso" Then : currencyx = "Php " : ElseIf Me.Currency.Text = "US Dollar" Then : currencyx = "$ " : End If
        Try

            With Me.C1FlexGrid1.Rows(Me.C1FlexGrid1.RowSel)
                .Item("gross") = .Item("quantity") * .Item("unitprice") - (.Item("quantity") * .Item("discount"))
                If tosave = True Then
                    .Item("fulfilled") = 0
                    .Item("balance") = 0
                End If
            End With

            Dim gross As Double = Me.c1FlexGrid1.Aggregate(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, 10, Me.c1FlexGrid1.Rows.Count - 1, 10)
            If Me.VATIn.Checked = True And VATEx.Checked = False Then
                Me.GrossAmount.Text = currencyx & gross.ToString("n2")
                Me.VATAmount.Text = currencyx & (gross / 1.12 * 0.12).ToString("n2")
                Me.NetSalesAmount.Text = currencyx & (gross - (gross / 1.12 * 0.12)).ToString("n2")
                'Me.SIAmount.Text = gross.ToString("n2")
            ElseIf VATIn.Checked = False And VATEx.Checked = True Then
                Me.VATAmount.Text = currencyx & (gross * 0.12).ToString("n2")
                Me.GrossAmount.Text = currencyx & (gross + (gross * 0.12)).ToString("n2")
                Me.NetSalesAmount.Text = currencyx & gross.ToString("n2")
                'Me.SIAmount.Text = currencyx & gross.ToString("n2")
            End If
            Me.SIAmount.Text = Me.GrossAmount.Text
        Catch ex As Exception
            Me.GrossAmount.Text = "0.00"
            Me.VATAmount.Text = "0.00"
            Me.NetSalesAmount.Text = "0.00"
        End Try
    End Sub

    Private Sub InputButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim cur As String = ""
            Dim vattype As String = ""
            Select Case Currency.Text
                Case "Philippine Peso"
                    cur = "Php"
                Case "US Dollar"
                    cur = "$"
            End Select
            If VATIn.Checked = True Then : vattype = "VAT Inclusive" : ElseIf VATEx.Checked = True Then : vattype = "VAT Exclusive" : End If
            Dim x As New reportpreview
            With x
                .print("Reporting_PurchaseOrder_Solo", "id", PurchaseOrderid, 4, vattype, cur)
                .Text = "Print  preview of Sales Invoice #" & PurchaseOrderid
                .StartPosition = FormStartPosition.CenterScreen
                .WindowState = FormWindowState.Maximized
                .Show()
            End With
        Catch ex As Exception
        End Try
    End Sub

    Private Sub InputButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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
                        .CommandText = "update PurchaseOrder set isapproved=0,iscancelled=1, cancelledby='" & APCESMainForm.UserFullName.Text & "',lastupdate='" & "" & Now & "',datecancelled='" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "' where PurchaseOrderid='" & PurchaseOrderid & "'"
                        .Connection = con
                        .ExecuteNonQuery()

                        .Parameters.AddWithValue("@id", PurchaseOrderid)
                        .CommandText = "Inventory_PurchaseOrder_recall"
                        .CommandType = CommandType.StoredProcedure
                        .Connection = con
                        .ExecuteNonQuery()

                        con.Close()
                        command.Dispose()
                        showMessage("the command has been successfully executed.", "command successful", "command executed", 3)
                        Me.cancelled.Text = "CANCELLED"
                        ' PurchaseOrderMain.refreshgrid_click()
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
    Private Function saveordersx(ByVal flexgrid As C1.Win.C1FlexGrid.C1FlexGrid) As String
        Dim z11 As String = ""
        Try
            Dim x As Integer = 1
            Dim y As Integer = flexgrid.Rows.Count - 1
            For x = 1 To y
                With flexgrid.Rows(x)
                    If .Item("delivered") = False Then Continue For
                    z11 = z11 & " " & "" & .Item("deliveryreceiptid") & "            "
                End With
            Next
        Catch ex As Exception
            'messagebox.show(ex.message)
        End Try
        Return LTrim(RTrim(z11)).Replace("            ", ",")
    End Function

    Private Sub C1FlexGrid1_AfterEdit(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs)
        ' Try
        If e.Col = 5 Or e.Col = 8 Or e.Col = 9 Then
            With Me.c1FlexGrid1.Rows(Me.c1FlexGrid1.RowSel)
                ' .Item("Received") = "0"
                .Item("gross") = Val(.Item("quantity")) * Val(.Item("unitprice")) - (Val(.Item("quantity")) * Val(.Item("discount")))
                If tosave = False Then
                    If .Item("fulfilled") > .Item("quantity") Then
                        MessageBox.Show("Quantity should not be less than fulfilled quantity", "Error editing the quantity", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    End If
                End If
            End With
        ElseIf e.Col = 2 Then
            connect()
            con.Open()
            command = New MySqlCommand("Select * from items where itemcode = '" & Me.c1FlexGrid1.Rows(Me.c1FlexGrid1.RowSel).Item("itemcode") & "'", con)
            reader = command.ExecuteReader
            If reader.Read = True Then
                Dim xo As Integer = Me.c1FlexGrid1.RowSel
                Me.c1FlexGrid1.Rows(Me.c1FlexGrid1.RowSel).Item("itemid") = reader.Item("itemid")
                Me.c1FlexGrid1.Rows(Me.c1FlexGrid1.RowSel).Item("itemcode") = reader.Item("itemcode")
                Me.c1FlexGrid1.Rows(Me.c1FlexGrid1.RowSel).Item("itemname") = reader.Item("itemname")
                Me.c1FlexGrid1.Rows(Me.c1FlexGrid1.RowSel).Item("unitprice") = reader.Item("unitprice")
                Me.c1FlexGrid1.Rows(Me.c1FlexGrid1.RowSel).Item("uom") = reader.Item("uom")
                If Me.c1FlexGrid1.Rows(xo).Item("QUANTITy") = Nothing Then Me.c1FlexGrid1.Rows(xo).Item("quantity") = 0
                If Me.c1FlexGrid1.Rows(xo).Item("unitprice") = Nothing Then Me.c1FlexGrid1.Rows(xo).Item("unitprice") = 0
                If Me.c1FlexGrid1.Rows(xo).Item("fulfilled") = Nothing Then Me.c1FlexGrid1.Rows(xo).Item("fulfilled") = 0
                If Me.c1FlexGrid1.Rows(xo).Item("Balance") = Nothing Then Me.c1FlexGrid1.Rows(xo).Item("Balance") = 0
                If Me.c1FlexGrid1.Rows(xo).Item("gross") = Nothing Then Me.c1FlexGrid1.Rows(xo).Item("gross") = 0
                If Me.c1FlexGrid1.Rows(xo).Item("discount") = Nothing Then Me.c1FlexGrid1.Rows(xo).Item("discount") = 0
            Else
                MessageBox.Show("Item code does not exist", "Invalid item code", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Me.c1FlexGrid1.Rows(Me.c1FlexGrid1.RowSel).Item("itemcode") = Nothing
            End If
            command.Dispose()
            reader.Close()
            con.Close()
        End If
        ' Catch ex As Exception
        'MessageBox.Show(ex.Message)
        ' End Try
        'Me.C1FlexGrid1.AutoSizeRows()
        compute()
    End Sub


    Private Sub Pono_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Pono.Validated
        If tosave = True Then
            connect()
            con.Open()
            command = New MySqlCommand("select * from PurchaseOrder where Pono='" & Pono.Text & "' and companyid='" & companyid & "'", con)
            reader = command.ExecuteReader
            If reader.Read = True Then
                showMessage("Please retype new PO number", "PO number already exist on our records", "Duplicate PO No", 3)
                Me.PoNo.Text = Nothing
            End If
        End If
    End Sub

    Private Sub VATIn_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles VATIn.CheckedChanged, VATEx.CheckedChanged
        compute()
    End Sub

    Private Sub Currency_ChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Currency.ChangeCommitted
        compute()
    End Sub

    Private Sub C1FlexGrid1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1FlexGrid1.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If Me.c1FlexGrid1.ColSel = 2 Then
                    Dim allitems As String = " "
                    For c1 As Integer = 1 To Me.c1FlexGrid1.Rows.Count - 1
                        If Me.c1FlexGrid1.Rows(c1).Item("itemcode") = Nothing Then Continue For
                        allitems = allitems & "," & Me.c1FlexGrid1.Rows(c1).Item("itemcode")
                    Next
                    allitems = allitems.Replace(" ,", "")
                    Dim x As New ViolationTicketLookup(0)
                    With x
                        .violation.Focus()
                        .StartPosition = FormStartPosition.CenterParent
                        .ShowDialog()
                    End With
                    If x.DialogResult = Windows.Forms.DialogResult.OK Then
                        Dim xo As Integer = Me.c1FlexGrid1.RowSel
                        Dim xi2 As Integer = 0

                        For Each y As C1.Win.C1FlexGrid.Row In x.C1FlexGrid1.Rows.Selected
                            Dim x1 As Integer = y.Index
                            With x.C1FlexGrid1.Rows(x1)
                                Me.c1FlexGrid1.Rows(xo).Item("itemid") = .Item("itemid")
                                Me.c1FlexGrid1.Rows(xo).Item("ItemCode") = .Item("itemcode")
                                Me.c1FlexGrid1.Rows(xo).Item("itemname") = .Item("itemname")
                                Me.c1FlexGrid1.Rows(xo).Item("uom") = .Item("uom")
                                Me.c1FlexGrid1.Rows(xo).Item("unitprice") = .Item("unitprice")
                                If Me.c1FlexGrid1.Rows(xo).Item("Balance") = Nothing Then Me.c1FlexGrid1.Rows(xo).Item("Balance") = 0
                                If Me.c1FlexGrid1.Rows(xo).Item("QUANTITy") = Nothing Then Me.c1FlexGrid1.Rows(xo).Item("quantity") = 0
                                If Me.c1FlexGrid1.Rows(xo).Item("unitprice") = Nothing Then Me.c1FlexGrid1.Rows(xo).Item("unitprice") = 0
                                If Me.c1FlexGrid1.Rows(xo).Item("fulfilled") = Nothing Then Me.c1FlexGrid1.Rows(xo).Item("fulfilled") = 0
                                If Me.c1FlexGrid1.Rows(xo).Item("gross") = Nothing Then Me.c1FlexGrid1.Rows(xo).Item("gross") = 0
                                If Me.c1FlexGrid1.Rows(xo).Item("discount") = Nothing Then Me.c1FlexGrid1.Rows(xo).Item("discount") = 0
                            End With
                            If x.C1FlexGrid1.Rows.Selected.Count - 1 < 0 Then Exit Sub
                            xo = xo + 1
                            Me.c1FlexGrid1.Rows.Insert(xo)
                            xi2 = xo
                        Next
                        ' Me.c1FlexGrid1.Rows.Remove(xi2)
                    End If
                ElseIf Me.c1FlexGrid1.ColSel = 10 Then
                    Dim rowsel1 = Val(Me.c1FlexGrid1.RowSel) + 1
                    Me.c1FlexGrid1.Select(rowsel1, 1)
                End If

            ElseIf e.KeyCode = Keys.Delete Then
                Dim sagot As MsgBoxResult = MessageBox.Show("performing the command will delete the entire row. do you want to proceed?", "perform delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Stop)
                If sagot = MsgBoxResult.Yes Then
                    Me.C1FlexGrid1.Rows.Remove(Me.C1FlexGrid1.RowSel)
                    compute()
                End If

            ElseIf e.Modifiers = Keys.Control Then
                If e.KeyCode = Keys.C Then
                    Me.c1FlexGrid1.Copy()
                ElseIf e.KeyCode = Keys.V Then
                    Me.c1FlexGrid1.Paste()
                End If
            End If

            Me.C1FlexGrid1.AutoSizeRows()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


End Class