Imports mysql.data.mysqlclient
Public Class ReceivingReportentry
    Sub New(ByVal id As Integer)

        ' this call is required by the designer.
        initializecomponent()
        loadingvaluestoComboBoxes_StoredProc("admin_customers_combobox_activeonly", Me.CustomerName, "customername", "customerid")
        'loadingvaluestoComboBoxes_StoredProc("admin_branches_combobox_activeonly", Me.BranchName, "branchname", "branchid")
        AddHandler Me.CustomerName.SelectedIndexChanged, AddressOf Me.customername_selectedindexchanged
        If id = 0 Then clear() : Me.CustomerName.Focus()
        If id <> 0 Then loadentries(id)
        '  Me.SOReference.Text = searchRecord("select max(purchaseorderid) as id from purchaseorder where branchid='" & branchid & "'", 1)
    End Sub
    Public Sub toenable(ByVal a As Boolean)
        With Me
            .c1inputpanel1.readonly = Not a
            .c1inputpanel2.readonly = Not a
            .c1flexgrid1.allowediting = a
            .SaveRecord.Enabled = a
            .InputButton1.Enabled = a
            .inputbutton2.enabled = a
        End With
    End Sub
    Private Sub loadentries(ByVal id As Integer)
        Try
            Dim ds As New dataset
            Dim adapter As New MySqlDataAdapter("select * from ReceivingReport where ReceivingReportid=" & id, con)
            With adapter
                .fill(ds)
                .dispose()
            End With
            con.Close()
            With ds.Tables(0).Rows(0)
                Me.RRdate.Value = .Item("RRDate")
                Dim idx As Integer = .Item("rrno")
                Me.RRNo.Text = idx.ToString("d6")
                Me.Amount.Text = .Item("grossamount")
                Me.CustomerName.SelectedValue = .Item("customerid")
                Me.Remarks.Text = .Item("remarks")
                Me.ReceivingReportid = .Item("ReceivingReportid")
                If .Item("iscancelled") = True Then : cancelled.Text = "CANCELLED" : Else : cancelled.Text = "APPROVED" : End If
                Me.tosave = False
                loadtoGridNoFixed("select a.itemid, a.itemcode, itemname, a.uom, quantity,  b.unitprice, discount, " & _
                           " (b.unitprice*quantity) - (quantity* discount),  remarks from items a " & _
                           " join ReceivingReportorders b on a.itemid=b.itemid WHERE b. ReceivingReportid ='" & id & "'", Me.C1FlexGrid1)
                compute()
            End With
        Catch ex As Exception
            'messagebox.show(ex.message)
        End Try
    End Sub

    Private Sub customername_selectedindexchanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim id As Integer = 0
        Try
            id = Me.CustomerName.SelectedValue
            loadcustomerdetails(id)
        Catch ex As Exception
            Me.Address.Text = Nothing
            Me.BusinessType.Text = Nothing
            Me.TIN.Text = Nothing
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
                Me.TIN.Text = .Item("tin")
                Me.Address.Text = .Item("billaddress")
                Me.BusinessType.Text = .Item("BusinessType")

            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub saverecord_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveRecord.Click
        If Me.RRNo.Text = Nothing Then
            showMessage("invalid RR No. make sure that you supplied valid RR No.", "RR No is invalid", "not valid", 3)
            Exit Sub
        End If
        If Me.CustomerName.Text = Nothing Then
            showMessage("invalid supplier selected. make sure that you supplied valid supplier.", "supplier is invalid", "not valid", 3)
            Exit Sub
        End If
        If Me.C1FlexGrid1.Aggregate(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, 0, Me.C1FlexGrid1.Rows.Count - 1, 0) = 0 Then
            showMessage("you are required to input at least one valid item", "ordered items invalid", "not valid", 3)
            Exit Sub
        End If
        If tosave = True Then
            Dim depositid As Integer = searchRecord("select auto_increment from information_schema.tables where  table_schema='" & database & "' and table_name='ReceivingReport';", 1)
            savecommand("transaction_ReceivingReport_entry", depositid)
        Else
            savecommand("transaction_ReceivingReport_entry", Me.ReceivingReportid)
        End If

    End Sub
    Private Function savecommand(ByVal a As String, ByVal depositid As Integer) As Boolean
        Dim mytrans As MySqlTransaction
        connect()
        con.Open()
        mytrans = con.BeginTransaction()
        Try
            command = New MySqlCommand
            With command
                .CommandText = a
                .Connection = con
                .CommandType = CommandType.StoredProcedure
                With .Parameters
                    .AddWithValue("@ReceivingReportids", depositid)
                    .AddWithValue("@RRDates", Me.RRDate.Value)
                    .AddWithValue("@RRNos", Me.RRNo.Text)
                    .AddWithValue("@companyids", companyid)
                    .AddWithValue("@datecreateds", "" & Now)
                    .AddWithValue("@creators", APCESMainForm.UserFullName.Text)
                    .AddWithValue("@customerids", Me.CustomerName.SelectedValue)
                    .AddWithValue("@remarkss", Me.Remarks.Text)
                    .AddWithValue("@isapproveds", 1)
                    .AddWithValue("@iscancelleds", 0)
                    .AddWithValue("@approvedbys", "")
                    .AddWithValue("@cancelledbys", "")
                    .AddWithValue("@tosave", Me.tosave)
                    .AddWithValue("@grossamounts", Me.GrossAmount.Text.Replace("Php ", "").Replace(",", ""))
                End With
                .ExecuteNonQuery()
                Dim mynewcommand As New MySqlCommand
                With mynewcommand
                    If Me.tosave = False Then
                        .CommandText = "delete from ReceivingReportorders where ReceivingReportid=" & depositid
                        .Connection = con
                        .CommandType = CommandType.Text
                        .ExecuteNonQuery()
                    End If
                    .CommandText = "insert into `ReceivingReportorders` (`ReceivingReportid`,`itemid`,`uom`,`quantity`,`unitprice`, `discount`, `remarks`)" & _
                        " values " & saveorders2(depositid, Me.C1FlexGrid1)
                    .Connection = con
                    .CommandType = CommandType.Text
                    .ExecuteNonQuery()
                End With
                mytrans.Commit()
                .Dispose()
                con.Close()
                MessageBox.Show("the record has been successfully saved.", "command executed", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.ReceivingReportid = depositid
                Me.cancelled.Text = "APPROVED"
                Me.tosave = False
                ReceivingReportsmainform.refreshgrid_click()
                Return True
                Exit Function
            End With
        Catch ex As Exception
            'messagebox.show(ex.message)
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
                    If .Item("itemid") = Nothing Then Continue For
                    Dim itemre As String = ""
                    z11 = z11 & " " & "('" & id & _
                        "', '" & .Item("itemid") & _
                        "', '" & .Item("uom") & _
                        "', '" & .Item("quantity") & _
                                             "', '" & Val(.Item("unitprice")) &
                        "', '" & .Item("percentdiscount") & _
                        "', '" & .Item("remarks") & "')            "

                End With
            Next
        Catch ex As Exception
        End Try
        Return LTrim(RTrim(z11)).Replace("            ", ",")
    End Function
    Private Sub c1flexgrid1_keydown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1FlexGrid1.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If Me.C1FlexGrid1.ColSel = 2 Then
                    Dim allitems As String = " "
                    For c1 As Integer = 1 To Me.C1FlexGrid1.Rows.Count - 1
                        If Me.C1FlexGrid1.Rows(c1).Item("itemcode") = Nothing Then Continue For
                        allitems = allitems & "," & Me.C1FlexGrid1.Rows(c1).Item("itemcode")
                    Next
                    allitems = allitems.Replace(" ,", "")
                    Dim x As New ViolationTicketLookup(0)
                    With x
                        .violation.Focus()
                        .StartPosition = FormStartPosition.centerscreen
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
                                If Me.C1FlexGrid1.Rows(xo).Item("unitprice") = Nothing Then Me.C1FlexGrid1.Rows(xo).Item("unitprice") = 0
                                If Me.C1FlexGrid1.Rows(xo).Item("gross") = Nothing Then Me.C1FlexGrid1.Rows(xo).Item("gross") = 0
                                If Me.C1FlexGrid1.Rows(xo).Item("percentdiscount") = Nothing Then Me.C1FlexGrid1.Rows(xo).Item("percentdiscount") = 0

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
        Catch ex As Exception
            'messagebox.show(ex.message)
        End Try
    End Sub
    Private Sub c1flexgrid1_afteredit(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) Handles C1FlexGrid1.AfterEdit
        Try
            If e.Col = 1 Then
                connect()
                con.Open()
                command = New MySqlCommand("Select * from items where itemcode = '" & Me.C1FlexGrid1.Rows(Me.C1FlexGrid1.RowSel).Item("itemcode") & "'", con)
                reader = command.ExecuteReader
                If reader.Read = True Then
                    Dim xo As Integer = Me.C1FlexGrid1.RowSel
                    Me.C1FlexGrid1.Rows(Me.C1FlexGrid1.RowSel).Item("itemid") = reader.Item("itemid")
                    Me.C1FlexGrid1.Rows(Me.C1FlexGrid1.RowSel).Item("itemcode") = reader.Item("itemcode")
                    Me.C1FlexGrid1.Rows(Me.C1FlexGrid1.RowSel).Item("itemname") = reader.Item("itemname")
                    Me.C1FlexGrid1.Rows(Me.C1FlexGrid1.RowSel).Item("unitprice") = reader.Item("unitprice")
                    Me.C1FlexGrid1.Rows(Me.C1FlexGrid1.RowSel).Item("uom") = reader.Item("uom")
                    If Me.C1FlexGrid1.Rows(xo).Item("unitprice") = Nothing Then Me.C1FlexGrid1.Rows(xo).Item("unitprice") = 0
                    If Me.C1FlexGrid1.Rows(xo).Item("fulfilled") = Nothing Then Me.C1FlexGrid1.Rows(xo).Item("fulfilled") = 0
                    If Me.C1FlexGrid1.Rows(xo).Item("gross") = Nothing Then Me.C1FlexGrid1.Rows(xo).Item("gross") = 0
                    If Me.C1FlexGrid1.Rows(xo).Item("percentdiscount") = Nothing Then Me.C1FlexGrid1.Rows(xo).Item("percentdiscount") = 0
                Else
                    MessageBox.Show("Item code does not exist", "Invalid item code", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Me.C1FlexGrid1.Rows(Me.C1FlexGrid1.RowSel).Item("itemcode") = Nothing
                End If
                command.Dispose()
                reader.Close()
                con.Close()

            End If
        Catch ex As Exception
            'messagebox.show(ex.message)
        End Try
        'Me.C1FlexGrid1.AutoSizeRows()
        compute()
    End Sub
    Private Sub compute()
        Try
            With Me.C1FlexGrid1.Rows(Me.C1FlexGrid1.RowSel)
                .Item("Percentdiscount") = "0"
                .Item("gross") = .Item("quantity") * .Item("unitprice") - (.Item("quantity") * .Item("percentdiscount"))
            End With

            Dim gross As Double = Me.C1FlexGrid1.Aggregate(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, 7, Me.C1FlexGrid1.Rows.Count - 1, 7)
            Me.GrossAmount.Text = gross.ToString("n2")
            Me.Amount.Text = gross.ToString("n2")
            Me.VATAmount.Text = (gross / 1.12 * 0.12).ToString("n2")
            Me.NetSalesAmount.Text = (gross - (gross / 1.12 * 0.12)).ToString("n2")
        Catch ex As Exception
            Me.GrossAmount.Text = "0.00"
            Me.VATAmount.Text = "0.00"
            Me.NetSalesAmount.Text = "0.00"
        End Try
    End Sub
    Private ReceivingReportid As Integer = 0
    Private tosave As Boolean = True

    Private Sub inputbutton3_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputButton3.Click
        clear()
    End Sub
    Public Sub clear()
        '   Me.SOReference.Text = Nothing
        Me.Amount.Text = "0.00"
        ' Me.BranchName.SelectedIndex = -1
        Me.CustomerName.SelectedIndex = -1
        Me.Remarks.Text = Nothing
        Me.C1FlexGrid1.Rows.Count = 1
        Me.C1FlexGrid1.Rows.Count = 5
        compute()
        Me.tosave = True
        Me.SaveRecord.Enabled = True
        Me.ReceivingReportid = 0
        Me.toenable(True)
        Dim RRNox As Integer = searchRecord("select max(RRNo) as Auto_Increment from ReceivingReport where companyid='" & companyid & "'", 1) + 1
        Me.RRNo.Text = RRNox.ToString("d6")
    End Sub

    Private Sub inputbutton2_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputButton2.Click
        Try
            Dim x As New reportpreview
            With x
                .print("reporting_ReceivingReport_solo", "id", Me.ReceivingReportid, 2, "", "")
                .Text = "print preview of Purchase Order " & Me.ReceivingReportid.ToString("d6")
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


    Private Sub InputButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputButton1.Click
        Dim sagot As MsgBoxResult = MessageBox.Show("are you sure you want to perform the command?", "verification", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information)
        If sagot <> MsgBoxResult.Yes Then Exit Sub
        connect()
        con.Open()
        Dim command As New MySqlCommand
        With command
            .CommandText = "update ReceivingReport set iscancelled=@iscancelled, cancelledby=@cancelledby, datecancelled=@datecancelled, " & _
               "lastupdate=@lastupdate where ReceivingReportid=@ReceivingReportid"
            With .Parameters
                .AddWithValue("@cancelledby", APCESMainForm.UserFullName.Text)
                .AddWithValue("@datecancelled", Format(Now, "yyyy-MM-dd HH:mm:ss"))
                .AddWithValue("@iscancelled", 1)
                .AddWithValue("@lastupdate", "" & Now)
                .AddWithValue("@ReceivingReportid", Me.ReceivingReportid)
            End With
            .Connection = con
            .ExecuteNonQuery()
            con.Close()
            .Dispose()
        End With
        showMessage("the command has been successfully executed.", "command successful", "command executed", 3)
        ReceivingReportsmainform.refreshgrid_click()
    End Sub

End Class

