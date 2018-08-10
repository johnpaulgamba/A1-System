Imports mysql.data.mysqlclient
Public Class PaymentEntry
    Public paymentid As Integer
    Public tosave, iscancelled As Boolean
    Public Sub New(ByVal id As Integer, ByVal allowedit As Boolean)

        ' This call is required by the designer. 
        InitializeComponent()
        loadingvaluestoComboBoxes("Select customername, customerid from customers where companyid='" & companyid & _
                                  "' order by customername asc", CustomerName, "customername", "customerid")
        ' loadingvaluestoComboBoxes("Select distinct creditterms from payment", creditterms, "creditterms", "creditterms")

        ' Add any initialization after the InitializeComponent() call.
        'If id = 0 Then Me.C1DockingTab1.SelectedIndex = 0 : clear()
        If id = 0 Then
            clear()
        Else
            loadentries(id, allowedit)
        End If

    End Sub
#Region "Ribbon Control"
    Private Sub RibbonButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RibbonButton5.Click
        If Me.FontSize.Value <= 1 Then Exit Sub
        Me.FontSize.Value = Me.FontSize.Value - 1
    End Sub
    Private Sub RibbonTrackBar1_ValueChanged() Handles Me.Load, FontName.TextChanged, FontSize.ValueChanged
        Try
            MainLauncher(0)
            Dim x1 As Integer = 1
            Dim y1 As Integer = C1FlexGrid1.Cols.Count - 1
            For x1 = 1 To y1
                Me.C1FlexGrid1.Font = New Font(Me.FontName.Text, Me.FontSize.Value)
                With C1FlexGrid1.Cols(x1)
                    .StyleDisplay.Font = New Font(Me.FontName.Text, Me.FontSize.Value + 1, FontStyle.Regular)
                End With
                Me.C1FlexGrid1.Rows(0).StyleDisplay.Font = New Font("Tahoma", Me.FontSize.Value + 1, FontStyle.Bold)
                Me.C1FlexGrid1.AutoSizeCols() : Me.C1FlexGrid1.AutoSizeRows()
            Next

            Dim x As Integer = 1
            Dim y As Integer = C1FlexGrid2.Cols.Count - 1
            For x = 1 To y
                Me.C1FlexGrid2.Font = New Font(Me.FontName.Text, Me.FontSize.Value)
                With C1FlexGrid2.Cols(x)
                    .StyleDisplay.Font = New Font(Me.FontName.Text, Me.FontSize.Value + 1, FontStyle.Regular)
                End With
                Me.C1FlexGrid2.Rows(0).StyleDisplay.Font = New Font("Tahoma", Me.FontSize.Value + 1, FontStyle.Bold)
                Me.C1FlexGrid2.AutoSizeCols() : Me.C1FlexGrid2.AutoSizeRows()
            Next

            Dim x2 As Integer = 1
            Dim y2 As Integer = C1FlexGrid3.Cols.Count - 1
            For x2 = 1 To y2
                Me.C1FlexGrid3.Font = New Font(Me.FontName.Text, Me.FontSize.Value)
                With C1FlexGrid3.Cols(x2)
                    .StyleDisplay.Font = New Font(Me.FontName.Text, Me.FontSize.Value + 1, FontStyle.Regular)
                End With
                Me.C1FlexGrid3.Rows(0).StyleDisplay.Font = New Font("Tahoma", Me.FontSize.Value + 1, FontStyle.Bold)
                Me.C1FlexGrid3.AutoSizeCols() : Me.C1FlexGrid3.AutoSizeRows()
            Next
            MainLauncher(1)
        Catch ex As Exception
            ' MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub RibbonButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RibbonButton3.Click
        Me.FontSize.Value = Me.FontSize.Value + 1
    End Sub

#End Region
    Private Sub loadentries(ByVal id As Integer, ByVal toedit As Boolean)
        Try
            Dim ds As New DataSet
            Dim adapter As New MySqlDataAdapter("select * from payment where paymentid=" & id, con)
            With adapter
                .Fill(ds)
                .Dispose()
            End With
            con.Close()
            With ds.Tables(0).Rows(0)
                Me.ORDATE.Value = .Item("ORDATE")
                Me.paymentid = .Item("paymentid")
                Dim idx As Integer = .Item("ORNO")
                Me.ORNO.Text = idx.ToString("d6")
                Me.Reference.Text = .Item("reference")
                Me.Paymethod.Text = .Item("PayMethod")
                Me.Remarks.Text = .Item("remarks")
                Me.Amount.Text = .Item("Amount")
                Me.CustomerName.SelectedValue = .Item("customerid")
                Me.C1DockingTab1.SelectedIndex = 0
                tosave = False
                MessageBox.Show(toedit)
                If tosave = False And toedit = True Then
                    FunctionClass.loadtoGrid("Select paid,salesinvoiceid,concat('SI ',SINO), DueDate,datediff(now(),duedate),format(grossamount,2),format(amountpaid-amountpaid,2),remarks from salesinvoice where iscancelled <>1 and  customerid='" & .Item("customerid") & "' and companyid='" & companyid & "' order by sino desc", C1FlexGrid1)
                    FunctionClass.loadtoGrid("Select paid,creditmemoid,concat('CM ',CMNO), CMDate,datediff(now(),CMdate),format(grossamount,2),format(amountpaid-amountpaid,2),remarks from creditmemo where iscancelled <>1 and  customerid='" & .Item("customerid") & "' and companyid='" & companyid & "' order by cmno desc", C1FlexGrid2)
                    FunctionClass.loadtoGrid("Select paid,debitmemoid,concat('DM ',DMNO), DMDate,datediff(now(),DMdate),format(grossamount,2),format(amountpaid-amountpaid,2),remarks from debitmemo where iscancelled <>1 and  customerid='" & .Item("customerid") & "' and companyid='" & companyid & "' order by dmno desc", C1FlexGrid3)
                ElseIf tosave = False And toedit = False Then
                    FunctionClass.loadtoGrid("Select a.paid,B.salesinvoiceid,concat('',a.SINO), a.DueDate,datediff(now(),a.duedate),format(a.grossamount,2),format(b.amount,2),remarks from salesinvoice a join paymentorders b on a.salesinvoiceid=b.salesinvoiceid where b.paymentid='" & id & "' and  a.customerid='" & .Item("customerid") & "' order by sino desc", C1FlexGrid1)
                    FunctionClass.loadtoGrid("Select a.paid,B.creditmemoid,concat('',a.cmNO), a.cmDate,datediff(now(),a.cmdate),format(a.grossamount,2),format(b.amount,2),remarks from creditmemo a join paymentorders b on a.creditmemoid=b.creditmemoid where b.paymentid='" & id & "' and  a.customerid='" & .Item("customerid") & "' order by cmno desc", C1FlexGrid2)
                    FunctionClass.loadtoGrid("Select a.paid,B.debitmemoid,concat('',a.dmNO), a.dmDate,datediff(now(),a.dmdate),format(a.grossamount,2),format(b.amount,2),remarks from debitmemo a join paymentorders b on a.debitmemoid=b.debitmemoid where b.paymentid='" & id & "' and  a.customerid='" & .Item("customerid") & "' order by dmno desc", C1FlexGrid3)
                End If
                iscancelled = .Item("iscancelled")
                If .Item("iscancelled") = True Then : cancelled.Text = "CANCELLED" : Else : cancelled.Text = "APPROVED" : End If

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
            C1FlexGrid2.AllowEditing = a
            C1FlexGrid3.AllowEditing = a
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
                Me.Address.Text = .Item("Billaddress")
                Me.C1DockingTab1.SelectedIndex = 0
                If Me.tosave = True Then
                    FunctionClass.loadtoGrid("Select paid,salesinvoiceid,concat('SI ',SINO), DueDate,datediff(now(),duedate),format(grossamount,2),format(amountpaid,2),remarks from salesinvoice where companyid ='" & companyid & "' and iscancelled <>1 and  customerid='" & .Item("customerid") & "' and paid<>1 order by sino desc", C1FlexGrid1)
                    FunctionClass.loadtoGrid("Select paid,creditmemoid,concat('CM ',CMNO), CMDATE,datediff(now(),cmdate),format(grossamount,2),format(amountpaid,2),remarks from creditmemo where companyid ='" & companyid & "' and iscancelled <>1 and  customerid='" & .Item("customerid") & "' and paid<>1 order by cmno desc", C1FlexGrid2)
                    FunctionClass.loadtoGrid("Select paid,debitmemoid,concat('DM ',DMNO), DMDATE,datediff(now(),dmdate),format(grossamount,2),format(amountpaid,2),remarks from debitmemo where companyid ='" & companyid & "' and iscancelled <>1 and  customerid='" & .Item("customerid") & "' and paid<>1 order by dmno desc", C1FlexGrid3)
                End If
            End With
        Catch ex As Exception
            Me.TIN.Text = Nothing
            Me.Address.Text = Nothing
            Me.BusinessType.Text = Nothing
        End Try
    End Sub
    Private Sub InputButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Newdebitmemo.Click
        clear()
    End Sub
    Public Sub clear()
        'POReference.Text = ""
        ' AddHandler Me.Supplier.SelectedIndexChanged, AddressOf Me.customername_selectedindexchanged
        Me.ORNO.Text = Nothing
        Me.Reference.Text = Nothing
        Me.C1FlexGrid1.Rows.Count = 1
        Me.CustomerName.Focus()
        Me.CustomerName.SelectedIndex = -1
        Me.C1DockingTab1.SelectedIndex = 0
        toenable(True)
        tosave = True
        Dim drnox As Integer = searchRecord("select max(ORNO) as Auto_Increment from payment where companyid='" & companyid & "'", 1) + 1
        Me.ORNO.Text = drnox.ToString("d6") 'POReference.Focus()
        ' Dim depositid As Integer = searchRecord("select max(paymentid) as id from payment where branchid='" & companyid & "'", 1)
        'Me.RRReference.Text = depositid.ToString("d6")
    End Sub

    Private Sub saverecord_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveJobOrder.Click
        If Me.ORNO.Text = Nothing Then
            showMessage("invalid OR No. make sure that you supplied valid OR No.", "OR No is invalid", "not valid", 3)
            Exit Sub
        End If
        If Me.ORDATE.Value = Nothing Then
            showMessage("invalid OR Date. make sure that you supplied valid OR Date.", "OR Date is invalid", "not valid", 3)
            Exit Sub
        End If
        '   If Me.C1FlexGrid1.Aggregate(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, 0, Me.C1FlexGrid1.Rows.Count - 1, 0) = 0 Then
        'showMessage("you are required tag at least 1 invoice", "Sales Invoice invalid", "not valid", 3)
        ' Exit Sub
        ' End If
        'checkserialgrid()
        If tosave = True Then
            Dim depositid As Integer = searchRecord("select auto_increment from information_schema.tables where  table_schema='" & database & "' and table_name='payment';", 1)
            savecommand("transaction_payment_entry", depositid)
        Else
            savecommand("transaction_payment_entry", paymentid)
        End If

    End Sub
    Private Function savecommand(ByVal a As String, ByVal depositid As Integer) As Boolean
        Dim paymentid As String = depositid
        Dim mytrans As MySqlTransaction
        connect()
        con.Open()

        mytrans = con.BeginTransaction()
        Dim COMMAND1 = New MySqlCommand
        With COMMAND1
            .Parameters.AddWithValue("@id", depositid)
            .CommandText = "Inventory_payment_Recall"
            .CommandType = CommandType.StoredProcedure
            .Connection = con
            .ExecuteNonQuery()
        End With

        Try
            command = New MySqlCommand
            With command
                .CommandText = a
                .Connection = con
                .CommandType = CommandType.StoredProcedure
                With .Parameters
                    .AddWithValue("@ORDATEs", Me.ORDATE.Value)
                    .AddWithValue("@paymentids", depositid)
                    .AddWithValue("@companyids", companyid)
                    .AddWithValue("@ORNOs", ORNO.Text)
                    .AddWithValue("@referencess", Reference.Text)
                    .AddWithValue("@paymethods", Paymethod.Text)
                    .AddWithValue("@amountS", Amount.Value)
                    .AddWithValue("@tags", "")
                    .AddWithValue("@datecreateds", "" & Now)
                    .AddWithValue("@creators", APCESMainForm.UserFullName.Text)
                    .AddWithValue("@customerids", Me.CustomerName.SelectedValue)
                    .AddWithValue("@REMARKSS", Me.Remarks.Text)
                    .AddWithValue("@isapproveds", 0)
                    .AddWithValue("@iscancelleds", 0)
                    .AddWithValue("@approvedbys", APCESMainForm.UserFullName.Text)
                    .AddWithValue("@cancelledbys", "")
                    .AddWithValue("@tosave", Me.tosave)
                End With
                .ExecuteNonQuery()
                Dim mynewcommand As New MySqlCommand
                With mynewcommand

                    If Me.tosave = False Then
                        .CommandText = "delete from paymentorders where paymentid='" & depositid & "'"
                        .Connection = con
                        .CommandType = CommandType.Text
                        .ExecuteNonQuery()
                    End If

                    If saveorders2(depositid, Me.C1FlexGrid1) <> "" Then
                        'save from invoice flex
                        .CommandText = "insert into `paymentorders` (`paymentid`,`salesinvoiceid`,`amount`,`reference`,`ORNO`,`Paid`)" & _
                       " values " & saveorders2(depositid, Me.C1FlexGrid1)
                        .Connection = con
                        .CommandType = CommandType.Text
                        .ExecuteNonQuery()
                    End If
                    If saveorders3(depositid, Me.C1FlexGrid2) <> "" Then
                        'save from creditmemo
                        .CommandText = "insert into `paymentorders` (`paymentid`,`creditmemoid`,`amount`,`reference`,`ORNO`,`Paid`)" & _
                      " values " & saveorders3(depositid, Me.C1FlexGrid2)
                        .Connection = con
                        .CommandType = CommandType.Text
                        .ExecuteNonQuery()
                    End If
                    If saveorders4(depositid, Me.C1FlexGrid3) <> "" Then
                        'save from debitmemo
                        .CommandText = "insert into `paymentorders` (`paymentid`,`debitmemoid`,`amount`,`reference`,`ORNO`,`Paid`)" & _
                      " values " & saveorders4(depositid, Me.C1FlexGrid3)
                        .Connection = con
                        .CommandType = CommandType.Text
                        .ExecuteNonQuery()
                    End If

                    .Parameters.AddWithValue("@id", depositid)
                    .CommandText = "Inventory_payment_Approval"
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
                Me.paymentid = depositid
                PaymentMainForm.LoadingForm()
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
                    If .Item("paid") = False Then Continue For
                    z11 = z11 & " " & "('" & id & _
                           "', '" & .Item("salesinvoiceid") & _
                           "',  '" & .Item("amountpaid") & _
                             "',  '" & .Item("SINO") & _
                                "',  '" & Me.ORNO.Text & _
                          "',1)            "

                End With
            Next
        Catch ex As Exception
            'messagebox.show(ex.message)
        End Try
        Return LTrim(RTrim(z11)).Replace("            ", ",")
    End Function
    Private Function saveorders3(ByVal id As Integer, ByVal flexgrid As C1.Win.C1FlexGrid.C1FlexGrid) As String
        Dim z11 As String = ""
        Try
            Dim x As Integer = 1
            Dim y As Integer = flexgrid.Rows.Count - 1
            For x = 1 To y
                With flexgrid.Rows(x)
                    If .Item("paid") = False Then Continue For
                    z11 = z11 & " " & "('" & id & _
                           "', '" & .Item("creditmemoid") & _
                           "',  '" & .Item("amountpaid") & _
                             "',  '" & .Item("cmNO") & _
                                "',  '" & Me.ORNO.Text & _
                          "',1)            "

                End With
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return LTrim(RTrim(z11)).Replace("            ", ",")
    End Function
    Private Function saveorders4(ByVal id As Integer, ByVal flexgrid As C1.Win.C1FlexGrid.C1FlexGrid) As String
        Dim z11 As String = ""
        Try
            Dim x As Integer = 1
            Dim y As Integer = flexgrid.Rows.Count - 1
            For x = 1 To y
                With flexgrid.Rows(x)
                    If .Item("paid") = False Then Continue For
                    z11 = z11 & " " & "('" & id & _
                           "', '" & .Item("debitmemoid") & _
                           "',  '" & .Item("amountpaid") & _
                             "',  '" & .Item("DMNO") & _
                                "',  '" & Me.ORNO.Text & _
                          "',1)            "

                End With
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return LTrim(RTrim(z11)).Replace("            ", ",")
    End Function
    Private Sub compute()
        Me.Amount.Text = Nothing
        Dim currencyx As String = ""
        Dim grossfinal, gross, gross1, gross2 As Double
        'Try

        If Me.C1FlexGrid1.Rows.Count <= 1 Then
            grossfinal = 0
        Else
            gross = Me.C1FlexGrid1.Aggregate(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, 7, Me.C1FlexGrid1.Rows.Count - 1, 7)
        End If

        If Me.C1FlexGrid2.Rows.Count <= 1 Then
            gross1 = 0
        Else
            gross1 = Me.C1FlexGrid2.Aggregate(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, 7, Me.C1FlexGrid2.Rows.Count - 1, 7)
        End If

        If Me.C1FlexGrid3.Rows.Count <= 1 Then
            gross2 = 0
        Else
            gross2 = Me.C1FlexGrid3.Aggregate(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, 7, Me.C1FlexGrid3.Rows.Count - 1, 7)
        End If

        grossfinal = (gross + gross1) - gross2
        Me.Amount.Text = grossfinal.ToString("n2")
        'Catch ex As Exception
        'MessageBox.Show(ex.Message)
        ' Me.Amount.Text = "0.00"
        ' End Try
    End Sub

    Private Sub InputButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintDebitMemo.Click
        Try
            Dim cur As String = ""
            Dim vattype As String = ""
            Dim x As New reportpreview
            With x
                .print("Reporting_payment_Solo", "id", paymentid, 4, vattype, cur)
                .Text = "Print  preview of Payment #" & paymentid
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
                        .CommandText = "update payment set isapproved=0,iscancelled=1, cancelledby='" & APCESMainForm.UserFullName.Text & "',lastupdate='" & "" & Now & "' where paymentid='" & paymentid & "'"
                        .Connection = con
                        .ExecuteNonQuery()

                        .Parameters.AddWithValue("@id", paymentid)
                        .CommandText = "Inventory_payment_recall"
                        .CommandType = CommandType.StoredProcedure
                        .Connection = con
                        .ExecuteNonQuery()

                        con.Close()
                        command.Dispose()
                        showMessage("the command has been successfully executed.", "command successful", "command executed", 3)
                        Me.cancelled.Text = "CANCELLED"
                        PaymentMainForm.SoRefresh.PerformClick()
                    End If
                End With
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub InputButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub C1FlexGrid1_CellChecked(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) Handles C1FlexGrid1.CellChecked
        C1FlexGrid1.Rows(Me.C1FlexGrid1.RowSel).Item("amountpaid") = C1FlexGrid1.Rows(Me.C1FlexGrid1.RowSel).Item("totalsales")
        compute()
    End Sub

    Private Sub C1FlexGrid1_AfterEdit(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) Handles C1FlexGrid1.AfterEdit
        Try
            If e.Col = 1 Then
                With Me.C1FlexGrid1.Rows(Me.C1FlexGrid1.RowSel)
                    ' .Item("Received") = "0"
                    If .Item("paid") = True Then
                        .Item("amountpaid") = .Item("totalsales")
                    Else
                        .Item("amountpaid") = 0
                    End If
                End With
                compute()
            ElseIf e.Col = 9 Then
                compute()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Me.C1FlexGrid1.AutoSizeRows()
    End Sub
    Private Sub C1FlexGrid2_CellChecked(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) Handles C1FlexGrid2.CellChecked
        C1FlexGrid2.Rows(Me.C1FlexGrid2.RowSel).Item("amountpaid") = C1FlexGrid2.Rows(Me.C1FlexGrid2.RowSel).Item("totalsales")
        compute()
    End Sub

    Private Sub C1FlexGrid2_AfterEdit(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) Handles C1FlexGrid2.AfterEdit
        Try
            If e.Col = 1 Then
                With Me.C1FlexGrid2.Rows(Me.C1FlexGrid2.RowSel)
                    ' .Item("Received") = "0"
                    If .Item("paid") = True Then
                        .Item("amountpaid") = .Item("totalsales")
                    Else
                        .Item("amountpaid") = 0
                    End If
                End With
                compute()
            ElseIf e.Col = 9 Then
                compute()
            End If
        Catch ex As Exception
            ' 'messagebox.show(ex.message)
        End Try
        'Me.C1FlexGrid1.AutoSizeRows()
    End Sub

    Private Sub C1FlexGrid3_CellChecked(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) Handles C1FlexGrid3.CellChecked
        C1FlexGrid3.Rows(Me.C1FlexGrid3.RowSel).Item("amountpaid") = C1FlexGrid3.Rows(Me.C1FlexGrid3.RowSel).Item("totalsales")
        compute()
    End Sub

    Private Sub c1flexgrid3_AfterEdit(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) Handles C1FlexGrid3.AfterEdit
        Try
            If e.Col = 1 Then
                With Me.C1FlexGrid3.Rows(Me.C1FlexGrid3.RowSel)
                    ' .Item("Received") = "0"
                    If .Item("paid") = True Then
                        .Item("amountpaid") = .Item("totalsales")
                    Else
                        .Item("amountpaid") = 0
                    End If
                End With
                compute()
            ElseIf e.Col = 9 Then
                compute()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Me.C1FlexGrid3.AutoSizeRows()
    End Sub
    Private Sub ORNO_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles ORNO.Validated
        If tosave = True Then
            connect()
            con.Open()
            command = New MySqlCommand("select * from payment where ORNO='" & ORNO.Text & "' and companyid='" & companyid & "'", con)
            reader = command.ExecuteReader
            If reader.Read = True Then
                showMessage("Please retype new OR number", "OR number already exist on our records", "Duplicate OR No", 3)
            End If
        End If
    End Sub
    Private Sub CloseForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseForm.Click
        Me.Close()
    End Sub
End Class

