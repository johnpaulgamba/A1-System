Imports mysql.data.mysqlclient
Public Class AccountsReceivablemainform
    Private Sub warehousemainform_load(ByVal sender As Object, ByVal e As System.EventArgs)
        refreshgrid_click()
    End Sub
    Private filter As String = ""
    Private Sub searchbutton_click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim customerid As Integer = Me.C1FlexGrid2.Rows(Me.C1FlexGrid2.RowSel).Item("customerid")
        Dim filterquery As String = " and a.customerid = '" & convertQuotes(customerid) & "' and a.companyid='" & companyid & "'"
        Me.filter = filterquery
        loaddata("transaction_AccountsReceivable_main", filter, Me.C1FlexGrid1)
    End Sub


    Private Sub c1flexgrid1_doubleclick(ByVal sender As Object, ByVal e As System.EventArgs)
        Try
            Dim id As Integer = Me.C1FlexGrid1.Rows(Me.C1FlexGrid1.RowSel).Item("customerid")
            readdetails("select * from salesinvoice where customerid='" & id & "'", 4)
        Catch ex As Exception
            showMessage(ex.Message, "exception found", "contact system admin", 1)
        End Try
    End Sub
    Private newstringcollec As New system.collections.specialized.stringcollection
    Public Sub loadallcommands(ByVal classname As String, ByVal storedproc As String)
        Try
            connect()
            con.open()
            Dim adapter As New mysqldataadapter
            Dim ds As New dataset
            adapter = New mysqldataadapter(storedproc, con)
            adapter.selectcommand.commandtype = commandtype.storedprocedure
            adapter.SelectCommand.Parameters.AddWithValue("@id", APCESMainForm.EmployeeID.Text)
            adapter.selectcommand.parameters.addwithvalue("@classnames", classname)
            adapter.fill(ds)
            con.close()
            newstringcollec.clear()
            For Each row As datarow In ds.tables(0).rows
                newstringcollec.add(row.item("commandname").tostring.tolower)
            Next
            For Each x As c1.win.c1command.c1command In Me.c1commandholder1.commands
                If x.name.tolower.contains("c1contextmenu") Then
                    x.enabled = True
                ElseIf x.name.tolower = "c1command1" Or x.name.contains("runcmd") Then
                    x.enabled = True
                ElseIf newstringcollec.contains(x.name.tolower) Then
                    x.enabled = True
                Else
                    x.enabled = False
                End If
            Next
        Catch ex As exception
            showmessage(ex.message, "exception found", application.productname.tostring, 1)
        End Try
    End Sub
    Private Sub c1flexgrid1_mouseclick(ByVal sender As system.object, ByVal e As system.windows.forms.mouseeventargs) Handles c1flexgrid1.mouseclick
        Try
            DataGridView1_MouseClick(sender, e, Me.C1FlexGrid1, Me.C1ContextMenu1)
            If (e.Button = Windows.Forms.MouseButtons.Right) Then
                C1ContextMenu1.ShowContextMenu(C1FlexGrid1, e.Location)
            End If
        Catch ex As Exception
            'showMessage(ex.Message, "exception found", "contact system admin", 1)
        End Try
    End Sub
    Private Sub exportgriddata_click() Handles ExportGrid1.Click, BtnExport.Click
        ExportGridData(Me.C1FlexGrid1)
    End Sub


    Public Sub refreshgrid_click() Handles RefreshGrid1.Click, BtnRefresh.Click, RefreshGrid1.Click
        loaddata("transaction_AccountsReceivable_main", " and a.companyid='" & companyid & "' ", Me.C1FlexGrid1)
        FunctionClass.loadtoGrid("select a.customerid,a.customername as Customer, creditamount " & _
      "from customers a  where a.companyid='" & companyid & "' order by a.customername asc", C1FlexGrid2)
        compute()
    End Sub

    Private Sub clearbutton_click(ByVal sender As system.object, ByVal e As system.eventargs) Handles clearbutton.click
        Me.CustomerName.Text = Nothing
        SearchButton.PerformClick()
        'Me.refreshgrid_click()
    End Sub

    Private Sub printrecord_click() Handles PrintRecord.Click, BtnPrint.Click
        Try
            Dim id As Integer = Me.C1FlexGrid1.Rows(Me.C1FlexGrid1.RowSel).Item("customerid")
            Dim x As New reportpreview
            With x
                .print("reporting_accountsreceivable_solo", "id", id, 6, "", "")

                .Text = "print preview of Statement of Account of " & CustomerName.Text
                .StartPosition = FormStartPosition.CenterScreen
                .WindowState = FormWindowState.Maximized
                .Show()
            End With
        Catch ex As Exception
            'showMessage(ex.Message, "exception found", "contact system admin", 1)
        End Try
    End Sub
    Private Sub readdetails(ByVal sql As String, ByVal b As Integer)
        Try
            Dim id As Integer = 0
            Dim ds As New DataSet
            connect()
            con.Open()
            Dim adapter As New MySqlDataAdapter(sql, con)
            With adapter
                .Fill(ds)
                .Dispose()
            End With
            con.Close()
            id = ds.Tables(0).Rows(0).Item("customerid")

            If b = 3 Then
                Dim x As New AccountsReceivable(id)
                With x
                    .StartPosition = FormStartPosition.CenterScreen
                    .ShowDialog()
                End With
            ElseIf b = 4 Then
                Dim x As New AccountsReceivable(id)
                With x
                    .toenable(False)
                    .StartPosition = FormStartPosition.CenterScreen
                    .ShowDialog()
                End With
            End If
        Catch ex As Exception
            'messagebox.show(ex.message)
        End Try
    End Sub
    Private Sub AccountsReceivablemainform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.C1NavBar1.PanelHeaderFont = New Font("arial", 12, FontStyle.Bold)
        Me.C1NavBar2.PanelHeaderFont = New Font("arial", 12, FontStyle.Bold)
        searchbutton_click(sender, e)
        Me.datefrom.Text = FirstDayOfMonth(Now)
        Me.dateto.Text = LastDayOfMonth(Now)
        FunctionClass.loadtoGrid("select a.customerid,a.customername as Customer, creditamount " & _
       "from customers a  where a.companyid='" & companyid & "' order by a.customername asc", C1FlexGrid2)
        ' FunctionClass.loadtoGrid("select a.customerid,a.customername as Customer, sum(b.creditamount)-sum(b.debitamount) as Balance " & _
        '"from customers a join accountsreceivable b on a.customerid=b.customerid and a.companyid='" & companyid & "' where b.paid<>1   group by a.customerid order by a.customername asc", C1FlexGrid2)
        compute()
    End Sub

    Private Sub Btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnclose.Click
        Me.Close()
    End Sub

    Private Sub C1FlexGrid2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1FlexGrid2.Click
        Try
            Dim customerid As Integer = Me.C1FlexGrid2.Rows(Me.C1FlexGrid2.RowSel).Item("customerid")
            loaddata("transaction_AccountsReceivable_main", " and a.companyid='" & companyid & "' and a.customerid='" & customerid & "' ", Me.C1FlexGrid1)
            compute()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SearchButton_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchButton.Click
        FunctionClass.loadtoGrid("select a.customerid,a.customername as Customer, creditamount " & _
       "from customers a  where a.companyid='" & companyid & "' and customername like '%" & CustomerName.Text & "%' order by a.customername asc", C1FlexGrid2)
        'loadtoGridNoFixed("Select customerid, customername as Customer from customers where companyid='" & companyid & _
        '   "' and customername like '%" & CustomerName.Text & "%' order by customername asc", C1FlexGrid2)
    End Sub

    Private Sub ClearButton_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click
        Me.CustomerName.Text = Nothing
        SearchButton.PerformClick()
    End Sub
    Private Sub compute()
        Try
            Dim gross1 As Double = Me.C1FlexGrid1.Aggregate(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, 10, Me.C1FlexGrid1.Rows.Count - 1, 10)
            Balance.Text = gross1.ToString("n2")
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ExportGrid3_Click(ByVal sender As Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles ExportGrid3.Click

    End Sub
End Class


