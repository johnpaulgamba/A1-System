Imports MySql.Data.MySqlClient
Public Class DebitMemoEntry
    Public tosave, iscancelled As Boolean
    Public paids As Boolean = False
    Public DebitMemoid As Integer
    Public vattype As String = ""
    Public hitory As String = ""

    Public Sub New(ByVal id As Integer)
        ' This call is required by the designer. 
        InitializeComponent()
        loadingvaluestoComboBoxes("Select customername, customerid from customers where companyid='" & companyid & _
                                  "' order by customername asc", CustomerName, "customername", "customerid")
        loadingvaluestoComboBoxes("Select sino, salesinvoiceid from salesinvoice where companyid='" & companyid & "' and iscancelled<>1", SIno, "sino", "salesinvoiceid")
        ' loadingvaluestoComboBoxes("Select distinct creditterms from DebitMemo", creditterms, "creditterms", "creditterms")

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
            Dim adapter As New MySqlDataAdapter("select * from DebitMemo where DebitMemoid=" & id, con)
            With adapter
                .Fill(ds)
                .Dispose()
            End With
            con.Close()
            With ds.Tables(0).Rows(0)
                Me.SIno.Text = .Item("SiNO")
                Me.SIDate.Value = .Item("DMDATE")
                Me.DebitMemoid = .Item("DebitMemoid")
                Dim idx As Integer = .Item("DMNo")
                Me.DMNo.Text = idx.ToString("d6")
                Me.Remarks.Text = .Item("remarks")
                Me.CreditTerms.Text = .Item("terms")
                Me.Remarks.Text = .Item("remarks")
                If .Item("currency") = "Php" Then : Me.Currency.Text = "Philippine Peso" : ElseIf .Item("currency") = "$" Then : Me.Currency.Text = "US Dollar" : End If
                If .Item("Taxcode") = "VAT-In" Then : Me.VATIn.Checked = True : ElseIf .Item("taxcode") = "VAT-Ex" Then : Me.VATEx.Checked = True : End If
                If tosave = False Then
                    loadtoGridNoFixed("Select a.itemid, a.salesinvoiceid, c.itemcode, upper(a.itemname),upper(a.uom), b.quantity,a.quantity,a.unitprice,a.discount,a.quantity*(a.unitprice-a.discount),a.remarks " & _
                          "from DebitMemoorders a join salesinvoiceorders b on a.salesinvoiceid=b.salesinvoiceid join items c on a.itemid=c.itemid where " & _
                          "  a.itemid=b.itemid and a.salesinvoiceid='" & SIno.SelectedValue & "'", C1FlexGrid1)
                End If
                Me.iscancelled = .Item("iscancelled")
                If .Item("iscancelled") = True Then : cancelled.Text = "CANCELLED" : Else : cancelled.Text = "APPROVED" : End If
                tosave = False
                compute()
                Me.CustomerName.SelectedValue = .Item("customerid")
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
            .CancelOrder.Enabled = a
            ' toedit = a
            ' InputButton1.Enabled = a
        End With
    End Sub
    Private Sub loadcustomerdetails(ByVal id As Integer)
        Try
            Dim ds As New DataSet
            connect()
            con.Open()
            Dim adapter As New MySqlDataAdapter("select a.customerid,b.customername,b.tin,b.businesstype,b.billaddress,b.vattype,b.terms from salesinvoice a join customers b where a.customerid=b.customerid and a.salesinvoiceid=" & id, con)
            With adapter
                .Fill(ds)
                .Dispose()
            End With
            con.Close()
            With ds.Tables(0).Rows(0)
                Me.CustomerName.SelectedValue = .Item("customerid")
                Me.TIN.Text = .Item("TIN")
                Me.BusinessType.Text = .Item("BusinessType")
                Me.Address.Text = .Item("Billaddress")
                Me.CreditTerms.Text = .Item("terms")
                Me.vattype = .Item("vattype")
                If Me.vattype = "VAT Inclusive" Then VATIn.Checked = True Else VATEx.Checked = True
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub InputButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        clear()
    End Sub
    Public Sub clear()
        'POReference.Text = ""
        Me.Currency.Text = "Philippine Peso"
        Me.VATIn.Checked = True
        Me.SIAmount.Text = ""
        Me.CreditTerms.Text = Nothing
        Me.C1FlexGrid1.Rows.Count = 10
        Me.DMNo.Focus()
        Me.CustomerName.SelectedIndex = -1
        toenable(True)
        tosave = True
        Dim drnox As Integer = searchRecord("select max(DMNo) as Auto_Increment from DebitMemo where companyid='" & companyid & "'", 1) + 1
        Me.DMNo.Text = drnox.ToString("d6") 'POReference.Focus()
        ' Dim depositid As Integer = searchRecord("select max(DebitMemoid) as id from DebitMemo where branchid='" & companyid & "'", 1)
        'Me.RRReference.Text = depositid.ToString("d6")
    End Sub


    Private Sub btnsave_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveJobOrder.Click
        If Me.DMNo.Text = Nothing Then
            showMessage("invalid CM No. make sure that you supplied valid CM No.", "CM No is invalid", "not valid", 3)
            Exit Sub
        End If
        If Me.SIDate.Value = Nothing Then
            showMessage("invalid CM Date. make sure that you supplied valid CM Date.", "CM Date is invalid", "not valid", 3)
            Exit Sub
        End If
        'If Me.C1FlexGrid1.Aggregate(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, 0, Me.C1FlexGrid1.Rows.Count - 1, 0) = 0 Then
        'showMessage("you are required to input at least one valid item", "ordered items invalid", "not valid", 3)
        'Exit Sub
        ' End If
        'checkserialgrid()
        If tosave = True Then
            Dim depositid As Integer = searchRecord("select auto_increment from information_schema.tables where  table_schema='" & database & "' and table_name='DebitMemo';", 1)
            savecommand("transaction_DebitMemo_entry", depositid)
        Else
            savecommand("transaction_DebitMemo_entry", DebitMemoid)
        End If

    End Sub
    Private Function savecommand(ByVal a As String, ByVal depositid As Integer) As Boolean
        Dim DebitMemoid As String = depositid
        Dim mytrans As MySqlTransaction
        connect()
        con.Open()

        Dim commandx As New MySqlCommand
        With commandx
            If tosave = False Then
                Dim command1 As New MySqlCommand
                .Parameters.AddWithValue("@id", depositid)
                .CommandText = "Inventory_DebitMemo_Recall"
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
                    .AddWithValue("@DebitMemoids", depositid)
                    .AddWithValue("@DMDATEs", Me.SIDate.Value)
                    .AddWithValue("@companyids", companyid)
                    .AddWithValue("@salesinvoiceids", Me.SIno.SelectedValue)
                    .AddWithValue("@sinos", Me.SIno.Text)
                    .AddWithValue("@DMNos", DMNo.Text)
                    .AddWithValue("@datecreateds", "" & Now)
                    .AddWithValue("@creators", APCESMainForm.UserFullName.Text)
                    .AddWithValue("@customerids", Me.CustomerName.SelectedValue)
                    .AddWithValue("@REMARKSS", Me.Remarks.Text)
                    .AddWithValue("@termss", Me.CreditTerms.Text)
                    .AddWithValue("@isapproveds", 1)
                    .AddWithValue("@iscancelleds", 0)
                    .AddWithValue("@applieds", 0)
                    .AddWithValue("@approvedbys", APCESMainForm.UserFullName.Text)
                    .AddWithValue("@tosave", Me.tosave)
                    If Currency.Text = "Philippine Peso" Then : .AddWithValue("@currencys", "Php") : ElseIf Me.Currency.Text = "US Dollar" Then : .AddWithValue("@currencys", "$") : End If
                    .AddWithValue("@historys", "")
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
                        .CommandText = "delete from DebitMemoorders where DebitMemoid='" & depositid & "'"
                        .Connection = con
                        .CommandType = CommandType.Text
                        .ExecuteNonQuery()
                    End If

                    If Me.C1FlexGrid1.Rows.Count > 1 Then
                        .CommandText = "insert into `DebitMemoorders` (`DebitMemoid`,`salesinvoiceid`,`itemid`,`itemname`,`uom`,`quantity`,`unitprice`, `discount`, `remarks`)" & _
         " values " & saveorders2(depositid, Me.C1FlexGrid1)
                        .Connection = con
                        .CommandType = CommandType.Text
                        .ExecuteNonQuery()
                    End If

                    .CommandText = "Update DebitMemo  set isapproved=1,dateapproved=now(), iscancelled=0 where DebitMemoid = '" & depositid & "'"
                    .Connection = con
                    .CommandType = CommandType.Text
                    .ExecuteNonQuery()

                    .Parameters.AddWithValue("@id", depositid)
                    .CommandText = "Inventory_DebitMemo_Approval"
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
                Me.DebitMemoid = depositid
                DebitMemoMainForm.LoadingForm()
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
                        "', '" & .Item("salesinvoiceid") & _
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
            With Me.C1FlexGrid1.Rows(Me.C1FlexGrid1.RowSel)
                .Item("gross") = .Item("quantity") * .Item("unitprice") - (.Item("quantity") * .Item("discount"))
            End With

            Dim gross As Double = Me.C1FlexGrid1.Aggregate(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, 9, Me.C1FlexGrid1.Rows.Count - 1, 9)
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
            MessageBox.Show(ex.Message)
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
                .print("Reporting_DebitMemo_Solo", "id", DebitMemoid, 8, vattype, cur)
                .Text = "Print  preview of Sales Invoice #" & DebitMemoid
                .StartPosition = FormStartPosition.CenterScreen
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
                        .CommandText = "update DebitMemo set isapproved=0,iscancelled=1, cancelledby='" & APCESMainForm.UserFullName.Text & "',lastupdate='" & "" & Now & "',datecancelled='" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "' where DebitMemoid='" & DebitMemoid & "'"
                        .Connection = con
                        .ExecuteNonQuery()

                        .Parameters.AddWithValue("@id", DebitMemoid)
                        .CommandText = "Inventory_DebitMemo_recall"
                        .CommandType = CommandType.StoredProcedure
                        .Connection = con
                        .ExecuteNonQuery()

                        con.Close()
                        command.Dispose()
                        showMessage("the command has been successfully executed.", "command successful", "command executed", 3)
                        Me.cancelled.Text = "CANCELLED"
                        ' DebitMemoMain.refreshgrid_click()
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

    Private Sub C1FlexGrid1_AfterEdit(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) Handles C1FlexGrid1.AfterEdit
        Try
            If e.Col = 6 Or e.Col = 7 Or e.Col = 8 Then
                With Me.C1FlexGrid1.Rows(Me.C1FlexGrid1.RowSel)
                    ' .Item("Received") = "0"
                    .Item("gross") = Val(.Item("quantity")) * Val(.Item("unitprice")) - (Val(.Item("quantity")) * Val(.Item("discount")))
                End With
            End If
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
        Me.C1FlexGrid1.AutoSizeRows()
        compute()
    End Sub
    Private Sub DMNo_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles DMNo.Validated
        If tosave = True Then
            connect()
            con.Open()
            command = New MySqlCommand("select * from DebitMemo where DMNo='" & DMNo.Text & "' and companyid='" & companyid & "'", con)
            reader = command.ExecuteReader
            If reader.Read = True Then
                showMessage("Please retype new Debit Memo number", "Debit Memo number already exist on our records", "Duplicate Debit Memo No", 3)
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
                If Me.C1FlexGrid1.ColSel = 1 Then
                    Dim allitems As String = " "
                    For c1 As Integer = 1 To Me.C1FlexGrid1.Rows.Count - 1
                        If Me.C1FlexGrid1.Rows(c1).Item("itemcode") = Nothing Then Continue For
                        allitems = allitems & "," & Me.C1FlexGrid1.Rows(c1).Item("itemcode")
                    Next
                    allitems = allitems.Replace(" ,", "")
                    Dim x As New ViolationTicketLookup(0)
                    With x
                        .violation.Focus()
                        .StartPosition = FormStartPosition.CenterParent
                        .ShowDialog()
                    End With
                    If x.DialogResult = Windows.Forms.DialogResult.OK Then
                        Dim xo As Integer = Me.C1FlexGrid1.RowSel
                        Dim xi2 As Integer = 0

                        For Each y As C1.Win.C1FlexGrid.Row In x.C1FlexGrid1.Rows.Selected
                            Dim x1 As Integer = y.Index
                            With x.C1FlexGrid1.Rows(x1)
                                Me.C1FlexGrid1.Rows(xo).Item("itemid") = .Item("itemid")
                                Me.C1FlexGrid1.Rows(xo).Item("ItemCode") = .Item("itemcode")
                                Me.C1FlexGrid1.Rows(xo).Item("itemname") = .Item("itemname")
                                Me.C1FlexGrid1.Rows(xo).Item("uom") = .Item("uom")
                                Me.C1FlexGrid1.Rows(xo).Item("unitprice") = .Item("unitprice")
                                If Me.C1FlexGrid1.Rows(xo).Item("Balance") = Nothing Then Me.C1FlexGrid1.Rows(xo).Item("Balance") = 0
                                If Me.C1FlexGrid1.Rows(xo).Item("QUANTITy") = Nothing Then Me.C1FlexGrid1.Rows(xo).Item("quantity") = 0
                                If Me.C1FlexGrid1.Rows(xo).Item("unitprice") = Nothing Then Me.C1FlexGrid1.Rows(xo).Item("unitprice") = 0
                                If Me.C1FlexGrid1.Rows(xo).Item("fulfilled") = Nothing Then Me.C1FlexGrid1.Rows(xo).Item("fulfilled") = 0
                                If Me.C1FlexGrid1.Rows(xo).Item("gross") = Nothing Then Me.C1FlexGrid1.Rows(xo).Item("gross") = 0
                                If Me.C1FlexGrid1.Rows(xo).Item("discount") = Nothing Then Me.C1FlexGrid1.Rows(xo).Item("discount") = 0
                            End With
                            If x.C1FlexGrid1.Rows.Selected.Count - 1 < 0 Then Exit Sub
                            xo = xo + 1
                            Me.C1FlexGrid1.Rows.Insert(xo)
                            xi2 = xo
                        Next
                        Me.C1FlexGrid1.Rows.Remove(xi2)
                    End If
                ElseIf Me.C1FlexGrid1.ColSel = 10 Then
                    Dim rowsel1 = Val(Me.C1FlexGrid1.RowSel) + 1
                    Me.C1FlexGrid1.Select(rowsel1, 1)
                End If

            ElseIf e.KeyCode = Keys.Delete Then
                Dim sagot As MsgBoxResult = MessageBox.Show("performing the command will delete the entire row. do you want to proceed?", "perform delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Stop)
                If sagot = MsgBoxResult.Yes Then
                    Me.C1FlexGrid1.Rows.Remove(Me.C1FlexGrid1.RowSel)
                    compute()
                End If
            End If
            Me.C1FlexGrid1.AutoSizeRows()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CloseForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub SIno_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles SIno.SelectedIndexChanged
        Try

            If tosave = True Then
                loadtoGridNoFixed("Select a.itemid, a.salesinvoiceid, b.itemcode, upper(a.itemname),upper(a.uom), a.quantity,a.quantity-a.quantity,a.unitprice,a.discount,a.quantity*(a.unitprice-a.discount),a.remarks " & _
                                  "from salesinvoiceorders a join items b on a.itemid=b.itemid where a.salesinvoiceid='" & SIno.SelectedValue & "'", C1FlexGrid1)
                loadcustomerdetails(SIno.SelectedValue)
            Else
                loadcustomerdetails(SIno.SelectedValue)
            End If

        Catch ex As Exception
            'MessageBox.Show("No records found")
        End Try
    End Sub

    Private Sub InputButton2_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles InputButton2.Click
        Try
            loadtoGridNoFixed("Select a.itemid, a.salesinvoiceid, b.itemcode, upper(a.itemname),upper(a.uom), a.quantity,a.quantity-a.quantity,a.unitprice,a.discount,a.quantity*(a.unitprice-a.discount),a.remarks " & _
                            "from salesinvoiceorders a join items b on a.itemid=b.itemid where a.salesinvoiceid='" & SIno.SelectedValue & "'", C1FlexGrid1)
            loadcustomerdetails(SIno.SelectedValue)
        Catch ex As Exception

        End Try
    End Sub
End Class