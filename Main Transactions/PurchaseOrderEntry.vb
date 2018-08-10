Imports mysql.data.mysqlclient
Public Class purchaseorderentry
    Public itemid As Integer
    Public purchaseorderid As Integer

    Sub New(ByVal itemid As Integer, ByVal pono As String)
        ' this call is required by the designer.
        InitializeComponent()
        loadingvaluestoComboBoxes("Select customername, customerid from customers where companyid='" & companyid & _
                                  "' order by customername asc", CustomerName, "customername", "customerid")
        'loadingvaluestoComboBoxes_StoredProc("admin_branches_combobox_activeonly", Me.BranchName, "branchname", "branchid")

        loadentries(itemid, pono)
        '  Me.SOReference.Text = searchRecord("select max(purchaseorderid) as id from purchaseorder where branchid='" & branchid & "'", 1)
    End Sub
    Private Sub loadentries(ByVal itemid As Integer, ByVal purchaseorderid As Integer)
        Try
            Dim ds As New DataSet
            Dim adapter As New MySqlDataAdapter("select b.customerid,a.itemid, c.itemcode,c.itemname,d.purchaseorderid,a.pono,d.quantity,d.fulfilled,d.purchaseorderid from SalesInvoiceorders a join SalesInvoice b on a.SalesInvoiceid=b.SalesInvoiceid join items c on a.itemid=c.itemid " & _
                                                " join purchaseorderorders d on a.purchaseorderid=d.purchaseorderid and a.itemid=d.itemid where a.itemid='" & itemid & _
                                                "' and a.purchaseorderid='" & purchaseorderid & "'", con)
            With adapter
                .Fill(ds)
                .Dispose()
            End With
            con.Close()
            With ds.Tables(0).Rows(0)
                Me.CustomerName.SelectedValue = .Item("customerid")
                Me.ItemCode.Text = .Item("itemcode")
                Me.ItemName.Text = .Item("itemname")
                Me.purchaseorderid = .Item("purchaseorderid")
                Me.POReference.Text = .Item("pono")
                Me.QtyFufilled.Value = .Item("fulfilled")
                Me.QtyOrdered.Value = .Item("quantity")
                Me.itemid = .Item("itemid")
                ' Me.Remarks.Text = .Item("remarks1")
                loadtoGridNoFixed("select a.itemid,concat('',b.SINO),a.PONo, concat('',c.drno), c.drdate, a.quantity,a.unitprice,a.discount, " & _
                                  "a.quantity*(a.unitprice-a.discount),b.taxcode,b.currency,a.quantity,a.quantity,a.quantity,b.ORNO,b.paid,a.remarks,d.itemcode,upper(a.itemname) from SalesInvoiceorders a join SalesInvoice b on a.SalesInvoiceid=b.SalesInvoiceid join deliveryreceipt c on a.deliveryreceiptid=c.deliveryreceiptid join items d on a.itemid=d.itemid where a.itemid='" & itemid & "' and a.purchaseorderid='" & purchaseorderid & "'", Me.C1FlexGrid1)
                compute()

            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub customername_selectedindexchanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerName.SelectedIndexChanged
        Dim id As Integer = 0
        Try
            id = Me.CustomerName.SelectedValue
            loadcustomerdetails(id)
        Catch ex As Exception
            Me.Address.Text = Nothing
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
            End With
        Catch ex As Exception

        End Try
    End Sub
    Private Sub compute()
        Try
            Dim x As Integer = 1
            Dim y As Integer = Me.C1FlexGrid1.Rows.Count - 1
            For x = 1 To y
                With C1FlexGrid1.Rows(x)
                    Dim cur As String = ""
                    If .Item("currency") = "Philippine Peso" Then : .Item("currency") = "Php " : ElseIf .Item("currency") = "US Dollar" Then : .Item("currency") = "$ " : End If
                    Dim gross As Double = .Item("gross")
                    If .Item("taxcode") = "VAT-In" Then
                        .Item("vatablesales") = (gross - (gross / 1.12 * 0.12))
                        .Item("vatamount") = (gross / 1.12 * 0.12)
                        .Item("totalsales") = gross
                    ElseIf .Item("taxcode") = "VAT-Ex" Then
                        .Item("vatablesales") = gross
                        .Item("vatamount") = (gross * 0.12)
                        .Item("totalsales") = (gross + (gross * 0.12))
                    End If
                End With
            Next
            Dim quantity As Double = Me.C1FlexGrid1.Aggregate(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, 5, Me.C1FlexGrid1.Rows.Count - 1, 5)
            Me.Fulfilled.Text = quantity.ToString("n2")
            Dim totalsales As Double = Me.C1FlexGrid1.Aggregate(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, 13, Me.C1FlexGrid1.Rows.Count - 1, 13)
            Me.TotalSalesAmount.Text = "Php " & totalsales.ToString("n2")
            Me.C1FlexGrid1.AutoSizeCols()
        Catch ex As Exception
            'messagebox.show(ex.message)
        End Try

    End Sub
    Public Sub clear()
        '   Me.SOReference.Text = Nothing
        ' Me.BranchName.SelectedIndex = -1
        Me.CustomerName.SelectedIndex = -1
        Me.Remarks.Text = Nothing
        Me.C1FlexGrid1.Cols(5).Visible = False
        Me.C1FlexGrid1.Rows.Count = 1
        Me.C1FlexGrid1.Rows.Count = 5

        ' Dim depositid As Integer = searchRecord("select max(purchaseorderid) as id from purchaseorder where branchid='" & branchid & "'", 1)
        'Me.SOReference.Text = depositid.ToString("d6")
    End Sub

    Private Sub inputbutton2_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputButton2.Click
        Try
            Dim x As New reportpreview
            With x
                .print2("reporting_pomonitoring_solo", "itemid", itemid, "pono", Me.purchaseorderid)
                .Text = "print preview of PO Monitoring "
                .StartPosition = FormStartPosition.centerscreen
                .WindowState = FormWindowState.Maximized
                .Show()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub inputbutton4_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputButton4.Click
        Me.Close()
    End Sub

    Private Sub InputButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputButton1.Click
        ExportGridData(Me.C1FlexGrid1)
    End Sub
End Class

