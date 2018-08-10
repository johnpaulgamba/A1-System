Imports mysql.data.mysqlclient
Public Class PaymentsMainForm

    Private Sub warehousemainform_load(ByVal sender As Object, ByVal e As System.EventArgs)
       
    End Sub
    Private filter As String = ""
    Private Sub searchbutton_click(ByVal sender As system.object, ByVal e As system.eventargs) Handles searchbutton.click
        Dim adjustdatequery As String = ""
        If Me.adjustedfrom.text = Nothing And Me.adjustedto.text = Nothing Then
            adjustdatequery = ""
        Else
            If Me.adjustedfrom.text <> Nothing Then
                If adjustedto.text <> Nothing Then
                    adjustdatequery = " and  date_format(a.ORDATE, '%Y/%m/%d')  between '" & Format(AdjustedFrom.Value, "yyyy/MM/dd") & "' and '" & Format(AdjustedTo.Value, "yyyy/MM/dd") & "' "
                Else
                    adjustdatequery = " and  a.ORDATE >= '" & Format(AdjustedFrom.Value, "yyyy/MM/dd") & "' "
                End If
            Else
                If AdjustedTo.Text <> Nothing Then
                    adjustdatequery = " and a.ORDATE<= '" & Format(AdjustedTo.Value, "yyyy/MM/dd") & "' "
                Else
                    adjustdatequery = " and a.ORDATE like '%%' "
                End If
            End If
        End If

        Dim filterquery As String = " and  a.paymentid like '%" & convertQuotes(Me.IAreference.Text) & _
            "%' and c.companyid ='" & companyid & _
            "' and a.datecreated like '%" & convertQuotes(Me.DateCreated.Text) & _
            "%' and a.lastupdate like '%" & convertQuotes(Me.LastUpdate.Text) & _
            "%' and a.creator like '%" & convertQuotes(Me.Creator.Text) & "%' "
        Me.filter = filterquery & adjustdatequery
        loaddata("transaction_payment_main", filter, Me.c1flexgrid1)

    End Sub

    

    Private Sub c1flexgrid1_doubleclick(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1FlexGrid1.DoubleClick, BtnOpen.Click
        Try
            Dim id As Integer = Me.C1FlexGrid1.Rows(Me.C1FlexGrid1.RowSel).Item("paymentid")
            readdetails("select * from payment where paymentid=" & id, 4)
        Catch ex As Exception
            showMessage(ex.Message, "exception found", "contact system admin", 1)
        End Try
    End Sub

    Private newstringcollec As New System.Collections.Specialized.StringCollection
    Public Sub loadallcommands(ByVal classname As String, ByVal storedproc As String)
        Try
            connect()
            con.open()
            Dim adapter As New mysqldataadapter
            Dim ds As New dataset
            adapter = New mysqldataadapter(storedproc, con)
            adapter.selectcommand.commandtype = commandtype.storedprocedure
            adapter.selectcommand.parameters.addwithvalue("@id", baketechmainform.employeeid.text)
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
    Private Sub c1flexgrid1_mouseclick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles C1FlexGrid1.MouseClick
        Try


            datagridview1_mouseclick(sender, e, Me.c1flexgrid1, Me.c1contextmenu1)
            If (e.Button = Windows.Forms.MouseButtons.Right) Then

                C1ContextMenu1.ShowContextMenu(C1FlexGrid1, e.Location)
            End If

        Catch ex As exception
            showmessage(ex.message, "exception found", "contact system admin", 1)
        End Try

    End Sub

    Private Sub exportgriddata_click() Handles ExportGrid.Click, BtnExport.Click
        ExportGridData(Me.C1FlexGrid1)
    End Sub

    Public Sub refreshgrid_click() Handles RefreshGrid.Click, BtnRefresh.Click
        loaddata("transaction_payment_main", filter, Me.C1FlexGrid1)
    End Sub

    Private Sub clearbutton_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click
        Me.iareference.text = Nothing
        Me.LastUpdate.Text = Nothing
        Me.datecreated.text = Nothing
        Me.creator.text = Nothing
        Me.adjustedfrom.value = now
        Me.adjustedto.value = now
    End Sub

    Private Sub printrecord_click() Handles PrintRecord.Click, BtnPrint.Click
        Try
            Dim id As Integer = Me.C1FlexGrid1.Rows(Me.C1FlexGrid1.RowSel).Item("paymentid")
            Dim x As New reportpreview
            With x
                ' .print("reporting_payment_solo", "id", id, 4)
                .Text = "print preview of ia " & id.ToString("d10")
                .StartPosition = FormStartPosition.centerscreen
                .WindowState = FormWindowState.Maximized
                .Show()
            End With
        Catch ex As Exception
            showMessage(ex.Message, "exception found", "contact system admin", 1)
        End Try
    End Sub
    Private Sub cancelcommand_click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles CancelCommand.Click
        Try
            Dim id As Integer = Me.c1flexgrid1.rows(Me.c1flexgrid1.rowsel).item("paymentid")
            readdetails("select * from payment where paymentid=" & id, 1)
        Catch ex As exception
            showmessage(ex.message, "exception found", "contact system admin", 1)
        End Try
    End Sub
    Private Sub addnew_click() Handles AddNew.Click, btnNew.Click
        Dim x As New PaymentEntry(0)
        With x
            .StartPosition = FormStartPosition.centerscreen
            .ShowDialog()
        End With
    End Sub

    Private Sub editrecord_click() Handles EditRecord.Click, BtnModify.Click
        Try
            Dim id As Integer = Me.C1FlexGrid1.Rows(Me.C1FlexGrid1.RowSel).Item("paymentid")
            readdetails("select * from payment where paymentid=" & id, 3)
        Catch ex As Exception
            showMessage(ex.Message, "exception found", "contact system admin", 1)
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
            id = ds.Tables(0).Rows(0).Item("paymentid")
            If b = 3 Then
                Dim x As New PaymentEntry(id)
                With x
                    .toenable(True)
                    .toedit = True
                    .tosave = False
                    .StartPosition = FormStartPosition.centerscreen
                    .ShowDialog()
                End With
            ElseIf b = 4 Then
                Dim x As New PaymentEntry(id)
                With x
                    .toenable(False)
                    .tosave = False
                    .toedit = False
                    .StartPosition = FormStartPosition.centerscreen
                    .ShowDialog()
                End With
            End If
        Catch ex As Exception
            'messagebox.show(ex.message)
        End Try
    End Sub

    Private Sub approvecommand_click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles ApproveCommand.Click
        Try
            Dim id As Integer = Me.c1flexgrid1.rows(Me.c1flexgrid1.rowsel).item("paymentid")
            readdetails("select * from payment where paymentid=" & id, 2)
        Catch ex As exception
            showmessage(ex.message, "exception found", "contact system admin", 1)
        End Try
    End Sub

    Private Sub PaymentsMainForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load, BtnRefresh.Click
        Me.C1NavBar1.PanelHeaderFont = New Font("arial", 12, FontStyle.Bold)
        Me.C1NavBar2.PanelHeaderFont = New Font("arial", 12, FontStyle.Bold)
        Me.AdjustedFrom.Value = Now
        Me.AdjustedTo.Value = Now
        searchbutton_click(sender, e)
    End Sub
End Class


