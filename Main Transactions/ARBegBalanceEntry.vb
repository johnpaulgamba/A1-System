Imports MySql.Data.MySqlClient
Public Class ARBegBalanceEntry
    Public tosave, iscancelled As Boolean
    Public paids As Boolean = False
    Public BBID As Integer
    Public vattype As String = ""
    Public hitory As String = ""

    Public Sub New(ByVal id As Integer)
        ' This call is required by the designer. 
        InitializeComponent()
        'loadingvaluestoComboBoxes("Select SINO, salesinvoiceid from salesinvoice where companyid='" & companyid & "' and iscancelled<>1", SIno, "salesinvoiceid", "sino")
        ' loadingvaluestoComboBoxes("Select distinct creditterms from ARBegBalance", creditterms, "creditterms", "creditterms")
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
            Dim adapter As New MySqlDataAdapter("select * from ARBegBalance where BBID=" & id, con)
            With adapter
                .Fill(ds)
                .Dispose()
            End With
            con.Close()
            With ds.Tables(0).Rows(0)
                Me.BBNo.Text = .Item("bbid")
                Me.SIDate.Value = .Item("bbdate")
                Me.BBID = .Item("BBID")
                Dim idx As Integer = .Item("cmno")
                Me.BBNo.Text = idx.ToString("d6")
                Me.Remarks.Text = .Item("remarks")

                Me.Remarks.Text = .Item("remarks")

                'If tosave = False Then
                'loadtoGridNoFixed("Select a.itemid, a.salesinvoiceid, c.itemcode, upper(a.itemname),upper(a.uom), b.quantity,a.quantity,a.unitprice,a.discount,a.quantity*(a.unitprice-a.discount),a.remarks " & _
                '     "from ARBegBalanceorders a join salesinvoiceorders b on a.salesinvoiceid=b.salesinvoiceid join items c on a.itemid=c.itemid where " & _
                '    "  a.itemid=b.itemid and a.salesinvoiceid='" & SIno.SelectedValue & "'", C1FlexGrid1)
                'End If
                Me.iscancelled = .Item("iscancelled")
                If .Item("iscancelled") = True Then : cancelled.Text = "CANCELLED" : Else : cancelled.Text = "APPROVED" : End If
                tosave = False
                compute()
            End With
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
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
    
    Private Sub InputButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewArBegBalance.Click, Newcreditmemo.Click
        clear()
    End Sub
    Public Sub clear()
        'POReference.Text = ""
     
        Me.C1FlexGrid1.Rows.Count = 10
        Me.BBNo.Focus()
        Me.Remarks.Text = Nothing
        toenable(True)
        tosave = True
        Dim drnox As Integer = searchRecord("select max(cmno) as Auto_Increment from ARBegBalance where companyid='" & companyid & "'", 1) + 1
        Me.BBNo.Text = drnox.ToString("d6") 'POReference.Focus()
        ' Dim depositid As Integer = searchRecord("select max(BBID) as id from ARBegBalance where branchid='" & companyid & "'", 1)
        'Me.RRReference.Text = depositid.ToString("d6")
    End Sub


    Private Sub btnsave_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveJobOrder.Click
        If Me.BBNo.Text = Nothing Then
            showMessage("invalid CM No. make sure that you supplied valid CM No.", "CM No is invalid", "not valid", 3)
            Exit Sub
        End If
        If Me.SIDate.Value = Nothing Then
            showMessage("invalid CM Date. make sure that you supplied valid CM Date.", "CM Date is invalid", "not valid", 3)
            Exit Sub
        End If
        ' If Me.C1FlexGrid1.Aggregate(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, 0, Me.C1FlexGrid1.Rows.Count - 1, 0) = 0 Then
        'showMessage("you are required to input at least one valid item", "ordered items invalid", "not valid", 3)
        'Exit Sub
        'End If
        'checkserialgrid()
        If tosave = True Then
            Dim depositid As Integer = searchRecord("select auto_increment from information_schema.tables where  table_schema='" & database & "' and table_name='ARBegBalance';", 1)
            savecommand("transaction_ARBegBalance_entry", depositid)
        Else
            savecommand("transaction_ARBegBalance_entry", BBID)
        End If

    End Sub
    Private Function savecommand(ByVal a As String, ByVal depositid As Integer) As Boolean
        Dim BBID As String = depositid
        Dim mytrans As MySqlTransaction
        connect()
        con.Open()

        Dim commandx As New MySqlCommand
        With commandx
            If tosave = False Then
                Dim command1 As New MySqlCommand
                .Parameters.AddWithValue("@id", depositid)
                .CommandText = "Inventory_ARBegBalance_Recall"
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
                    .AddWithValue("@BBIDs", depositid)
                    .AddWithValue("@cmdates", Me.SIDate.Value)
                    .AddWithValue("@companyids", companyid)
                    .AddWithValue("@cmnos", BBNo.Text)
                    .AddWithValue("@datecreateds", "" & Now)
                    .AddWithValue("@creators", BakeTechMainForm.UserFullName.Text)
                    .AddWithValue("@REMARKSS", Me.Remarks.Text)
                    .AddWithValue("@isapproveds", 1)
                    .AddWithValue("@iscancelleds", 0)
                    .AddWithValue("@applieds", 0)
                    .AddWithValue("@approvedbys", BakeTechMainForm.UserFullName.Text)
                    .AddWithValue("@tosave", Me.tosave)
                End With
                .ExecuteNonQuery()
                Dim mynewcommand As New MySqlCommand
                With mynewcommand

                    '.CommandText = "update deliveryreceipt set accept=1 where deliveryreceiptid  in (" & saveordersx(Me.C1FlexGrid2) & ")"
                    '.Connection = con
                    '.ExecuteNonQuery()

                    If Me.tosave = False Then
                        .CommandText = "delete from ARBegBalanceorders where BBID='" & depositid & "'"
                        .Connection = con
                        .CommandType = CommandType.Text
                        .ExecuteNonQuery()
                    End If

                    If Me.C1FlexGrid1.Rows.Count > 1 Then
                        .CommandText = "insert into `ARBegBalanceorders` (`BBID`,`salesinvoiceid`,`itemid`,`itemname`,`uom`,`quantity`,`unitprice`, `discount`, `remarks`)" & _
                         " values " & saveorders2(depositid, Me.C1FlexGrid1)

                        .Connection = con
                        .CommandType = CommandType.Text
                        .ExecuteNonQuery()
                    End If

                    .CommandText = "Update ARBegBalance  set isapproved=1,dateapproved=now(), iscancelled=0 where BBID = '" & depositid & "'"
                    .Connection = con
                    .CommandType = CommandType.Text
                    .ExecuteNonQuery()

                    .Parameters.AddWithValue("@id", depositid)
                    .CommandText = "Inventory_ARBegBalance_Approval"
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
                Me.BBID = depositid
                ARBegBalanceMainForm.LoadingForm()
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
        'If Currency.Text = "Philippine Peso" Then : currencyx = "Php " : ElseIf Me.Currency.Text = "US Dollar" Then : currencyx = "$ " : End If
        Try
            With Me.C1FlexGrid1.Rows(Me.C1FlexGrid1.RowSel)
                .Item("gross") = .Item("quantity") * .Item("unitprice") - (.Item("quantity") * .Item("discount"))
            End With

            Dim gross As Double = Me.C1FlexGrid1.Aggregate(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, 9, Me.C1FlexGrid1.Rows.Count - 1, 9)

            Me.GrossAmount.Text = currencyx & gross.ToString("n2")
            Me.VATAmount.Text = currencyx & (gross / 1.12 * 0.12).ToString("n2")
            Me.NetSalesAmount.Text = currencyx & (gross - (gross / 1.12 * 0.12)).ToString("n2")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Me.GrossAmount.Text = "0.00"
            Me.VATAmount.Text = "0.00"
            Me.NetSalesAmount.Text = "0.00"
        End Try
    End Sub

    Private Sub InputButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintARBegBalance.Click, PrintARBegBalance.Click, PrintCreditMemo.Click
        Try
            Dim x As New reportpreview
            With x
                .print("Reporting_ARBegBalance_Solo", "id", BBID, 7, vattype, "")
                .Text = "Print  preview of Credit Memo #" & BBID
                .StartPosition = FormStartPosition.CenterScreen
                .WindowState = FormWindowState.Maximized
                .Show()
            End With
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
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
                        .CommandText = "update ARBegBalance set isapproved=0,iscancelled=1, cancelledby='" & BakeTechMainForm.UserFullName.Text & "',lastupdate='" & "" & Now & "',datecancelled='" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "' where BBID='" & BBID & "'"
                        .Connection = con
                        .ExecuteNonQuery()

                        .Parameters.AddWithValue("@id", BBID)
                        .CommandText = "Inventory_ARBegBalance_recall"
                        .CommandType = CommandType.StoredProcedure
                        .Connection = con
                        .ExecuteNonQuery()

                        con.Close()
                        command.Dispose()
                        showMessage("the command has been successfully executed.", "command successful", "command executed", 3)
                        Me.cancelled.Text = "CANCELLED"
                        ' ARBegBalanceMain.refreshgrid_click()
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


    Private Sub cmno_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles BBNo.Validated
        If tosave = True Then
            connect()
            con.Open()
            command = New MySqlCommand("select * from ARBegBalance where cmno='" & BBNo.Text & "' and companyid='" & companyid & "'", con)
            reader = command.ExecuteReader
            If reader.Read = True Then
                showMessage("Please retype new PO number", "PO number already exist on our records", "Duplicate PO No", 3)
            End If
        End If
    End Sub

    Private Sub VATIn_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        compute()
    End Sub

    Private Sub Currency_ChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs)
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
                    Dim x As New itemlookup(0)
                    With x
                        .itemname.Focus()
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
            'MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CloseForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseForm.Click
        Me.Close()
    End Sub

End Class