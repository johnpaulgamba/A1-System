Imports mysql.data.mysqlclient
Public Class purchaseordermainform
    Private filter As String = ""
    Private Sub searchbutton_click(ByVal sender As system.object, ByVal e As system.eventargs) Handles searchbutton.click
        Dim podatequery As String = ""
        If Me.podatefrom.text = Nothing And Me.podateto.text = Nothing Then
            podatequery = ""
        Else
            If Me.podatefrom.text <> Nothing Then
                If podateto.text <> Nothing Then
                    podatequery = " and  date_format(h.Podate, '%Y/%m/%d')  between '" & Format(PODateFrom.Value, "yyyy/MM/dd") & "' and '" & Format(PODateTo.Value, "yyyy/MM/dd") & "' "
                Else
                    podatequery = " and  h.Podate >= '" & Format(PODateFrom.Value, "yyyy/MM/dd") & "' "
                End If
            Else
                If PODateTo.Text <> Nothing Then
                    podatequery = " and h.Podate<= '" & Format(PODateTo.Value, "yyyy/MM/dd") & "' "
                Else
                    podatequery = " and h.Podate like '%%' "
                End If
            End If
        End If
        Dim filterquery As String = " and  h.pono like '%" & convertQuotes(Me.SOReference.Text) & _
            "%' and d.itemcode like '%" & convertQuotes(Me.itemcode.Text) & _
            "%' and d.itemname like '%" & convertQuotes(Me.itemname.Text) & _
            "%' and c.customername like '%" & convertQuotes(Me.CustomerName.Text) & _
               "%' and h.companyid like '%" & companyid & "%'"
        Me.filter = filterquery & podatequery
        loaddata("transaction_purchaseorder_main", filter, Me.c1flexgrid1)

    End Sub

    Private Sub c1flexgrid1_doubleclick(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1FlexGrid1.DoubleClick, BtnOpen.Click
        Try
            Dim itemid As Integer = Me.C1FlexGrid1.Rows(Me.C1FlexGrid1.RowSel).Item("itemid")
            Dim pono As String = Me.C1FlexGrid1.Rows(Me.C1FlexGrid1.RowSel).Item("id")
            readdetails("select * from salesinvoiceorders where itemid='" & itemid & "' and purchaseorderid='" & pono & "'", 4)
        Catch ex As Exception
            ' showMessage(ex.Message, "exception found", "contact system admin", 1)
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
            '  showmessage(ex.message, "exception found", application.productname.tostring, 1)
        End Try
    End Sub
    Private Sub c1flexgrid1_mouseclick(ByVal sender As system.object, ByVal e As system.windows.forms.mouseeventargs) Handles c1flexgrid1.mouseclick
        Try
            DataGridView1_MouseClick(sender, e, Me.C1FlexGrid1, Me.C1ContextMenu1)
            If (e.Button = Windows.Forms.MouseButtons.Right) Then

                C1ContextMenu1.ShowContextMenu(C1FlexGrid1, e.Location)
            End If

        Catch ex As exception
            'showMessage(ex.Message, "exception found", "contact system admin", 1)
        End Try

    End Sub

    Private Sub exportgriddata_click() Handles ExportGrid.Click, BtnExport.Click
        ExportGridData(Me.C1FlexGrid1)
    End Sub

    Public Sub refreshgrid_click() Handles RefreshGrid.Click, BtnRefresh.Click
        Me.ClearButton.PerformClick()
        loaddata("transaction_purchaseorder_main", filter, Me.C1FlexGrid1)
    End Sub

    Private Sub clearbutton_click(ByVal sender As system.object, ByVal e As system.eventargs) Handles clearbutton.click
        Me.soreference.text = Nothing
        Me.CustomerName.Text = Nothing
        Me.itemname.Text = Nothing
        Me.itemcode.Text = Nothing
        Me.DateCreated.Text = Nothing
        Me.creator.text = Nothing
        Me.podatefrom.value = now
        Me.PODateTo.Value = Now
        loaddata("transaction_purchaseorder_main", "", Me.C1FlexGrid1)
    End Sub

    Private Sub printrecord_click() Handles PrintRecord.Click, BtnPrint.Click
        Try
            Dim itemid As Integer = Me.C1FlexGrid1.Rows(Me.C1FlexGrid1.RowSel).Item("itemid")
            Dim pono As String = Me.C1FlexGrid1.Rows(Me.C1FlexGrid1.RowSel).Item("id")
            Try
                Dim x As New reportpreview
                With x
                    .print2("reporting_pomonitoring_solo", "itemid", itemid, "pono", pono)
                    .Text = "print preview of PO Monitoring "
                    .StartPosition = FormStartPosition.centerscreen
                    .WindowState = FormWindowState.Maximized
                    .Show()
                End With
            Catch ex As Exception

            End Try
        Catch ex As Exception
            'showMessage(ex.Message, "exception found", "contact system admin", 1)
        End Try
    End Sub
    Private Sub readdetails(ByVal sql As String, ByVal b As Integer)
        Try
            Dim itemid As Integer = 0
            Dim pono As String = ""
            Dim ds As New DataSet
            connect()
            con.Open()
            Dim adapter As New MySqlDataAdapter(sql, con)
            With adapter
                .Fill(ds)
                .Dispose()
            End With
            con.Close()
            pono = ds.Tables(0).Rows(0).Item("purchaseorderid")
            itemid = ds.Tables(0).Rows(0).Item("itemid")
            If b = 3 Then
                Dim x As New purchaseorderentry(itemid, pono)
                With x
                    .StartPosition = FormStartPosition.centerscreen
                    .ShowDialog()
                End With
            ElseIf b = 4 Then
                Dim x As New purchaseorderentry(itemid, pono)
                With x
                    .StartPosition = FormStartPosition.centerscreen
                    .ShowDialog()
                End With
            End If
        Catch ex As Exception
            'messagebox.show(ex.message)
        End Try
    End Sub


    Private Sub purchaseordermainform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.C1NavBar1.PanelHeaderFont = New Font("arial", 12, FontStyle.Bold)
        Me.C1NavBar2.PanelHeaderFont = New Font("arial", 12, FontStyle.Bold)
        Me.PODateFrom.Value = FirstDayOfMonth(Now)
        Me.PODateTo.Value = LastDayOfMonth(Now)
        searchbutton_click(sender, e)
    End Sub

    Private Sub Btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnclose.Click
        Me.Close()
    End Sub
End Class


