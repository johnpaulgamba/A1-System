Imports MySql.Data.MySqlClient

Public Class AccountsReceivable
    Public customerid As Integer
    Sub New(ByVal id As Integer)

        ' this call is required by the designer.
        InitializeComponent()
        loadingvaluestoComboBoxes("Select customername, customerid from customers where companyid='" & companyid & _
                                  "' order by customername asc", CustomerName, "customername", "customerid")
        'loadingvaluestoComboBoxes_StoredProc("admin_branches_combobox_activeonly", Me.BranchName, "branchname", "branchid")

        loadentries(id)
        '  Me.SOReference.Text = searchRecord("select max(purchaseorderid) as id from purchaseorder where branchid='" & branchid & "'", 1)
    End Sub
    Public Sub toenable(ByVal a As Boolean)
        With Me
            .C1InputPanel2.ReadOnly = Not a
            .C1FlexGrid1.AllowEditing = a
        End With
    End Sub
    Private Sub loadentries(ByVal id As Integer)
        Try
            Dim ds As New DataSet
            Dim adapter As New MySqlDataAdapter("select * from salesinvoice a join customers b on a.customerid=b.customerid and a.customerid='" & id & "'", con)
            With adapter
                .Fill(ds)
                .Dispose()
            End With
            con.Close()
            With ds.Tables(0).Rows(0)
                Me.CustomerName.SelectedValue = .Item("customerid")
                customerid = .Item("customerid")
                loadtoGridNoFixed("Select customerid, concat('',SINo), SIDate,DRNO,PONO,TaxCode,VatableSales,VATAmount, GrossAmount, Remarks from salesinvoice where customerid='" & id & "' and paid<>1", Me.C1FlexGrid1)
            End With
            compute()
        Catch ex As Exception
            'messagebox.show(ex.message)
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
            Dim vatsales As Double = Me.C1FlexGrid1.Aggregate(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, 6, Me.C1FlexGrid1.Rows.Count - 1, 6)
            Me.vatablesales.Text = vatsales.ToString("n2")
            Dim vatamount As Double = Me.C1FlexGrid1.Aggregate(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, 7, Me.C1FlexGrid1.Rows.Count - 1, 7)
            Me.VATAmount.Text = vatamount.ToString("n2")
            Dim total As Double = Me.C1FlexGrid1.Aggregate(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, 8, Me.C1FlexGrid1.Rows.Count - 1, 8)
            Me.totalsales.Text = total.ToString("n2")

            Me.C1FlexGrid1.AutoSizeCols()
        Catch ex As Exception
            Me.vatablesales.Text = "0.00"
            Me.VATAmount.Text = "0.00"

        End Try
    End Sub


    Public Sub clear()
        '   Me.SOReference.Text = Nothing
        ' Me.BranchName.SelectedIndex = -1
        Me.CustomerName.SelectedIndex = -1
        Me.C1FlexGrid1.Rows.Count = 1
        Me.C1FlexGrid1.Rows.Count = 5

        Me.toenable(True)
        ' Dim depositid As Integer = searchRecord("select max(purchaseorderid) as id from purchaseorder where branchid='" & branchid & "'", 1)
        'Me.SOReference.Text = depositid.ToString("d6")
    End Sub

    Private Sub inputbutton2_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputButton2.Click
        Try
            Dim x As New reportpreview
            With x
                .print("reporting_accountsreceivable_solo", "id", customerid, 6, "", "")

                .Text = "print preview of Statement of Account of " & CustomerName.Text
                .StartPosition = FormStartPosition.CenterScreen
                .WindowState = FormWindowState.Maximized
                .Show()
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub inputbutton4_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputButton4.Click
        Me.Close()
    End Sub
End Class