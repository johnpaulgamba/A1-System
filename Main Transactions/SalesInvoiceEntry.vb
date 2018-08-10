Imports MySql.Data.MySqlClient
Public Class salesinvoiceEntry
    Public tosave, iscancelled As Boolean
    Public paids As Boolean = False
    Public salesinvoiceid As Integer
    Public vattype As String = ""

    Public Sub New(ByVal id As Integer)
        ' This call is required by the designer. 
        InitializeComponent()
        loadingvaluestoComboBoxes("Select customername, customerid from customers where companyid='" & companyid & _
                                  "' order by customername asc", CustomerName, "customername", "customerid")
        ' loadingvaluestoComboBoxes("Select distinct creditterms from salesinvoice", creditterms, "creditterms", "creditterms")

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
            Dim adapter As New MySqlDataAdapter("select * from salesinvoice where salesinvoiceid=" & id, con)
            With adapter
                .Fill(ds)
                .Dispose()
            End With
            con.Close()
            With ds.Tables(0).Rows(0)
                Me.SIDate.Value = .Item("SIDate")
                Me.salesinvoiceid = .Item("salesinvoiceid")
                Dim idx As Integer = .Item("sino")
                Me.SINo.Text = idx.ToString("d6")
                Me.PONo.Text = .Item("poNO")
                Me.RRNo.Text = .Item("RRNO")
                Me.orno.Text = .Item("ORNO")
                Me.Remarks.Text = .Item("remarks")
                Me.CustomerName.SelectedValue = .Item("customerid")
                Me.CreditTerms.Text = .Item("terms")
                Me.Remarks.Text = .Item("remarks")
                Me.DueDate.Value = .Item("duedate")
                Me.DRNox.Text = .Item("drno")
                paids = .Item("paid")
                Me.Paid.Checked = paids
                If .Item("currency") = "Php" Then : Me.Currency.Text = "Philippine Peso" : ElseIf .Item("currency") = "$" Then : Me.Currency.Text = "US Dollar" : End If
                If .Item("Taxcode") = "VAT-In" Then : Me.VATIn.Checked = True : ElseIf .Item("taxcode") = "VAT-Ex" Then : Me.VATEx.Checked = True : End If
                If tosave = False Then
                    Me.C1DockingTab1.SelectedIndex = 1
                    FunctionClass.loadtoGrid("Select iscancelled, deliveryreceiptid, concat('',DRNo), DRDate,PONO, format(GrossAmount,2),remarks from deliveryreceipt where customerid='" & .Item("customerid") & "' and isapproved=1  order by drdate desc", C1FlexGrid2)
                    'FunctionClass.loadtoGrid("Select isapproved, salesorderid, concat('',SONo), SOdate, PONo, Deliverydate,format(GrossAmount,2),remarks from salesorder where customerid='" & .Item("customerid") & "'", C1FlexGrid2)
                    'FunctionClass.loadtoGrid("Select a.deliveryreceiptid, a.salesorderid, concat('',c.drno), d.pono, a.itemid,b.itemcode, b.itemname, b.uom,d.quantity,d.fulfilled, d.quantity-d.fulfilled,a.quantity,d.unitprice, d.discount, (d.unitprice-d.discount)*d.quantity,d.remarks from salesinvoiceorders a join items b on a.itemid=b.itemid join salesorder c on a.salesorderid=c.salesorderid  join salesorderorders d on a.salesorderid=d.salesorderid where a.salesorderid=d.salesorderid and a.itemid=d.itemid and a.salesinvoiceid='" & id & "'", C1FlexGrid1)
                    FunctionClass.loadtoGrid("Select a.deliveryreceiptid,concat('',c.drno), a.pono, a.itemid,b.itemcode, a.itemname, a.uom,a.quantity,a.unitprice, a.discount, (a.unitprice-a.discount)*a.quantity,a.remarks,a.purchaseorderid from salesinvoiceorders a join items b on a.itemid=b.itemid join salesinvoice c on a.salesinvoiceid=c.salesinvoiceid where a.salesinvoiceid='" & id & "'", C1FlexGrid1)
                Else

                End If
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
            .Cancelorder.Enabled = a
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
                    'FunctionClass.loadtoGrid("Select * from deliveryreceipt where customerid='" & id & "'", C1FlexGrid2)
                    FunctionClass.loadtoGrid("Select accept, deliveryreceiptid, concat('',DRNo), DRDate,PONO,format(GrossAmount,2),remarks from deliveryreceipt where companyid = '" & companyid & "' and accept=0 and  customerid='" & id & "' order by drdate desc", C1FlexGrid2)
                End If
            End With
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
            Me.BusinessType.Text = Nothing
            Me.Address.Text = Nothing
            Me.CreditTerms.Text = Nothing
            Me.TIN.Text = Nothing
        End Try
    End Sub
    Private Sub InputButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewSalesOrder.Click
        clear()
    End Sub
    Public Sub clear()
        'POReference.Text = ""
        Me.C1DockingTab1.SelectedIndex = 0
        ' AddHandler Me.Supplier.SelectedIndexChanged, AddressOf Me.customername_selectedindexchanged
        Me.SINo.Text = Nothing
        Me.PONo.Text = Nothing
        Me.PONo.Text = Nothing
        Me.Currency.Text = "Philippine Peso"
        Me.VATIn.Checked = True
        Me.SIAmount.Text = ""
        Me.CreditTerms.Text = Nothing
        Me.C1FlexGrid1.Rows.Count = 1
        Me.C1FlexGrid2.Rows.Count = 1
        Me.CustomerName.Focus()
        Me.CustomerName.SelectedIndex = -1
        Me.BusinessType.Text = Nothing
        Me.Address.Text = Nothing
        Me.CreditTerms.Text = Nothing
        Me.TIN.Text = Nothing
        toenable(True)
        tosave = True
        Dim drnox As Integer = searchRecord("select max(SINO) as Auto_Increment from salesinvoice where companyid='" & companyid & "'", 1) + 1
        Me.SINo.Text = drnox.ToString("d6") 'POReference.Focus()
        ' Dim depositid As Integer = searchRecord("select max(salesinvoiceid) as id from salesinvoice where branchid='" & companyid & "'", 1)
        'Me.RRReference.Text = depositid.ToString("d6")
    End Sub

    Private Sub saverecord_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveJobOrder.Click
        If Me.SINo.Text = Nothing Then
            showMessage("invalid SI No. make sure that you supplied valid SI No.", "SI No is invalid", "not valid", 3)
            Exit Sub
        End If
        If Me.SIDate.Value = Nothing Then
            showMessage("invalid SI Date. make sure that you supplied valid SI Date.", "SI Date is invalid", "not valid", 3)
            Exit Sub
        End If
        'If Me.C1FlexGrid1.Aggregate(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, 0, Me.C1FlexGrid1.Rows.Count - 1, 0) = 0 Then
        'showMessage("you are required to input at least one valid item", "ordered items invalid", "not valid", 3)
        ' Exit Sub
        ' End If
        'checkserialgrid()
        If tosave = True Then
            Dim depositid As Integer = searchRecord("select auto_increment from information_schema.tables where  table_schema='" & database & "' and table_name='salesinvoice';", 1)
            savecommand("transaction_salesinvoice_entry", depositid)
        Else
            savecommand("transaction_salesinvoice_entry", salesinvoiceid)
        End If

    End Sub
    Private Function savecommand(ByVal a As String, ByVal depositid As Integer) As Boolean
        Dim salesinvoiceid As String = depositid
        Dim mytrans As MySqlTransaction
        connect()
        con.Open()

        Dim commandx As New MySqlCommand
        With commandx
            If tosave = False Then
                Dim command1 As New MySqlCommand
                .Parameters.AddWithValue("@id", depositid)
                .CommandText = "Inventory_salesinvoice_Recall"
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
                    .AddWithValue("@SIdates", Me.SIDate.Value)
                    .AddWithValue("@salesinvoiceids", depositid)
                    .AddWithValue("@companyids", companyid)
                    .AddWithValue("@sinos", SINo.Text)
                    .AddWithValue("@ponos", PONo.Text)
                    .AddWithValue("@rrnos", RRNo.Text)
                    .AddWithValue("@DRnos", DRNox.Text)
                    .AddWithValue("@Duedates", Me.DueDate.Value)
                    .AddWithValue("@datecreateds", "" & Now)
                    .AddWithValue("@creators", APCESMainForm.UserFullName.Text)
                    .AddWithValue("@customerids", Me.CustomerName.SelectedValue)
                    .AddWithValue("@REMARKSS", Me.Remarks.Text)
                    .AddWithValue("@termss", Me.CreditTerms.Text)
                    .AddWithValue("@isapproveds", 0)
                    .AddWithValue("@iscancelleds", 0)
                    .AddWithValue("@approvedbys", APCESMainForm.UserFullName.Text)
                    .AddWithValue("@cancelledbys", "")
                    .AddWithValue("@tosave", Me.tosave)
                    .AddWithValue("@PAIDS", paids)
                    If Currency.Text = "Philippine Peso" Then : .AddWithValue("@currencys", "Php") : ElseIf Me.Currency.Text = "US Dollar" Then : .AddWithValue("@currencys", "$") : End If
                    If Me.VATIn.Checked = True Then : .AddWithValue("@taxcodes", VATIn.Text) : ElseIf Me.VATEx.Checked = True Then : .AddWithValue("@taxcodes", VATEx.Text) : End If
                    If Currency.Text = "Philippine Peso" Then : .AddWithValue("@grossamounts", Me.GrossAmount.Text.Replace("Php ", "").Replace(",", "")) : ElseIf Me.Currency.Text = "US Dollar" Then : .AddWithValue("@grossamounts", Me.GrossAmount.Text.Replace("$ ", "").Replace(",", "")) : End If
                    If Currency.Text = "Philippine Peso" Then : .AddWithValue("@vatablesaless", Me.NetSalesAmount.Text.Replace("Php ", "").Replace(",", "")) : ElseIf Me.Currency.Text = "US Dollar" Then : .AddWithValue("@vatablesaless", Me.NetSalesAmount.Text.Replace("$ ", "").Replace(",", "")) : End If
                    If Currency.Text = "Philippine Peso" Then : .AddWithValue("@vatamounts", Me.VATAmount.Text.Replace("Php ", "").Replace(",", "")) : ElseIf Me.Currency.Text = "US Dollar" Then : .AddWithValue("@vatamounts", Me.VATAmount.Text.Replace("$ ", "").Replace(",", "")) : End If
                End With
                .ExecuteNonQuery()
                Dim mynewcommand As New MySqlCommand
                With mynewcommand

                    '.CommandText = "update deliveryreceipt set accept=1 where deliveryreceiptid  in (" & saveordersx(Me.C1FlexGrid2) & ")"
                    '.Connection = con
                    '.ExecuteNonQuery()

                    If Me.tosave = False Then
                        .CommandText = "delete from salesinvoiceorders where salesinvoiceid='" & depositid & "'"
                        .Connection = con
                        .CommandType = CommandType.Text
                        .ExecuteNonQuery()
                    End If


                    If Me.C1FlexGrid1.Aggregate(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, 8, Me.C1FlexGrid1.Rows.Count - 1, 8) <> 0 Then
                        .CommandText = "insert into `salesinvoiceorders` (`salesinvoiceid`,`deliveryreceiptid`,`purchaseorderid`,`POno`,`itemid`,`itemname`,`uom`,`quantity`,`unitprice`, `discount`, `remarks`)" & _
                            " values " & saveorders2(depositid, Me.C1FlexGrid1)
                        .Connection = con
                        .CommandType = CommandType.Text
                        .ExecuteNonQuery()
                    End If


                    .CommandText = "Update salesinvoice  set isapproved=1,dateapproved=now(), iscancelled=0 where salesinvoiceid = '" & depositid & "'"
                    .Connection = con
                    .CommandType = CommandType.Text
                    .ExecuteNonQuery()


                    .Parameters.AddWithValue("@id", depositid)
                    .CommandText = "Inventory_salesinvoice_Approval"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = con
                    .ExecuteNonQuery()


                End With
                mytrans.Commit()
                .Dispose()
                con.Close()

                showMessage("Click OK to continue", "The record has been successfully saved.", "Successfully saved", 2)
                'MessageBox.Show("the record has been successfully saved.", "command executed", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.tosave = False
                Me.salesinvoiceid = depositid
                SalesInvoiceMain.LoadingForm()
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
                            "', '" & .Item("deliveryreceiptid") & _
                                 "', '" & .Item("purchaseorderid") & _
                             "', '" & .Item("PONO") & _
                           "', '" & .Item("itemid") & _
                           "', '" & .Item("itemname") & _
                         "', '" & .Item("uom") & _
                          "', '" & .Item("Quantity") & _
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
            Dim gross As Double = Me.C1FlexGrid1.Aggregate(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, 11, Me.C1FlexGrid1.Rows.Count - 1, 11)
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
            ' MessageBox.Show(ex.Message)
            Me.GrossAmount.Text = "0.00"
            Me.VATAmount.Text = "0.00"
            Me.NetSalesAmount.Text = "0.00"
        End Try
    End Sub

    Private Sub InputButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintCreditMemo.Click
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
                .print("Reporting_salesinvoice_Solo", "id", salesinvoiceid, 4, vattype, cur)
                .Text = "Print  preview of Sales Invoice #" & salesinvoiceid
                .StartPosition = FormStartPosition.CenterScreen
                .WindowState = FormWindowState.Maximized
                .Show()
            End With
        Catch ex As Exception
        End Try
    End Sub

    Private Sub InputButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelorder.Click
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
                        .CommandText = "update salesinvoice set isapproved=0,iscancelled=1, cancelledby='" & APCESMainForm.UserFullName.Text & "',lastupdate='" & "" & Now & "',datecancelled='" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "' where salesinvoiceid='" & salesinvoiceid & "'"
                        .Connection = con
                        .ExecuteNonQuery()

                        .Parameters.AddWithValue("@id", salesinvoiceid)
                        .CommandText = "Inventory_salesinvoice_recall"
                        .CommandType = CommandType.StoredProcedure
                        .Connection = con
                        .ExecuteNonQuery()

                        con.Close()
                        command.Dispose()
                        showMessage("the command has been successfully executed.", "command successful", "command executed", 3)
                        Me.cancelled.Text = "CANCELLED"
                        ' salesinvoiceMain.refreshgrid_click()
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
    Private Sub C1FlexGrid2_CellChecked(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) Handles C1FlexGrid2.CellChecked
        FunctionClass.loadtoGrid("Select a.deliveryreceiptid,  concat('',c.drno) as drno, a.pono as pono, a.itemid,b.itemcode, b.itemname, b.uom,a.received,a.unitprice, a.discount, (a.unitprice-a.discount)*a.quantity,a.remarks,a.purchaseorderid from deliveryreceiptorders a join items b on a.itemid=b.itemid join deliveryreceipt c on a.deliveryreceiptid=c.deliveryreceiptid  where a.deliveryreceiptid in (" & saveordersx(Me.C1FlexGrid2) & ")", C1FlexGrid1)
        saveordersxx(C1FlexGrid2)
        compute()
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
    Public Sub saveordersxx(ByVal flexgrid As C1.Win.C1FlexGrid.C1FlexGrid)
        Dim z13 As String = ""
        Dim z15 As String = ""
        Try
            Dim x As Integer = 1
            Dim y As Integer = flexgrid.Rows.Count - 1
            For x = 1 To y
                With flexgrid.Rows(x)
                    If .Item("delivered") = False Then Continue For
                    z13 = z13 & " " & "" & .Item("drno") & "            "
                    z15 = z15 & " " & "" & .Item("sono") & "            "

                End With
            Next
            Me.DRNox.Text = LTrim(RTrim(z13)).Replace("            ", ",")
            Me.PONo.Text = LTrim(RTrim(z15)).Replace("            ", ",")
        Catch ex As Exception
            '  'messagebox.show(ex.message)
        End Try
    End Sub
    Private Sub C1FlexGrid1_AfterEdit(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) Handles C1FlexGrid1.AfterEdit
        Try
            If e.Col = 7 Or e.Col = 8 Or e.Col = 9 Then
                With Me.C1FlexGrid1.Rows(Me.C1FlexGrid1.RowSel)
                    ' .Item("Received") = "0"
                    .Item("gross") = Val(.Item("quantity")) * (.Item("UnitPrice") - .Item("discount"))
                End With
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Me.C1FlexGrid1.AutoSizeRows()
        Me.C1FlexGrid1.AutoSizeCols()
        compute()
    End Sub


    Private Sub SINo_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles SINo.Validated
        If tosave = True Then
            connect()
            con.Open()
            command = New MySqlCommand("select * from salesinvoice where sino='" & SINo.Text & "' and companyid='" & companyid & "'", con)
            reader = command.ExecuteReader
            If reader.Read = True Then
                showMessage("Please retype new SI number", "SI number already exist on our records", "Duplicate SI No", 3)
            End If
        End If
    End Sub
    Private Sub c1flexgrid1_keydown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1FlexGrid1.KeyDown
        Try

            If Me.C1FlexGrid1.ColSel = 11 Then
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
            'MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub VATIn_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles VATIn.CheckedChanged, VATEx.CheckedChanged
        compute()
    End Sub

    Private Sub Currency_ChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Currency.ChangeCommitted
        compute()
    End Sub

    Private Sub CloseForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseForm.Click
        Me.Close()
    End Sub

    Private Sub SIDate_ChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles SIDate.ChangeCommitted
        Me.DueDate.Value = Me.SIDate.Value
    End Sub
End Class