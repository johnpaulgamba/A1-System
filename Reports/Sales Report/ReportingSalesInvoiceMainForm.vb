Imports MySql.Data.MySqlClient
Public Class ReportingSalesInvoiceMainForm

    Private Sub WarehouseMainForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.C1NavBar1.PanelHeaderFont = New Font("Arial", 12, FontStyle.Bold)
        Me.C1NavBar2.PanelHeaderFont = New Font("Arial", 12, FontStyle.Bold)
        Me.RrdateFrom.Value = Now
        Me.RRdateto.Value = Now
        ' SearchButton_Click(sender, e)
    End Sub
    Private filter As String = ""
    Private Sub SearchButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchButton.Click

        Dim iscancels As Integer = 0
        Dim isApproves As Integer = 1


        If Me.CancelBoth.Checked = True Then iscancels = 0 Else iscancels = Convert.ToSingle(Me.CancelYes.Checked)
        If Me.ApproveBoth.Checked = True Then isApproves = 1 Else isApproves = Convert.ToSingle(Me.ApproveYes.Checked)

        Dim RRDatequery As String = ""
        If Me.RRDateFrom.Text = Nothing And Me.RRDateTo.Text = Nothing Then
            RRDatequery = ""
        Else
            If Me.RRDateFrom.Text <> Nothing Then
                If RRDateTo.Text <> Nothing Then
                    RRDatequery = " and  date_format(a.SIDate, '%Y/%m/%d')  between '" & Format(RrdateFrom.Value, "yyyy/MM/dd") & "' and '" & Format(RRdateto.Value, "yyyy/MM/dd") & "' "
                Else
                    RRDatequery = " and  a.SIDate >= '" & Format(RrdateFrom.Value, "yyyy/MM/dd") & "' "
                End If
            Else
                If RRdateto.Text <> Nothing Then
                    RRDatequery = " and a.SIDate<= '" & Format(RRdateto.Value, "yyyy/MM/dd") & "' "
                Else
                    RRDatequery = " and a.SIDate like '%%' "
                End If
            End If
        End If

        Dim filterquery As String = " and  a.sino like '%" & convertQuotes(Me.SINo.Text) & _
          "%' and h.drno like '%" & convertQuotes(Me.DRNo.Text) & _
            "%' and x.pono like '%" & convertQuotes(Me.PoNo.Text) & _
            "%' and customername like '%" & convertQuotes(Me.CustomerName.Text) & _
            "%' and x.itemname like '%" & convertQuotes(Me.ItemName.Text) & _
            "%' and y.itemcode like '%" & convertQuotes(Me.Itemcode.Text) & _
            "%' and a.iscancelled = '" & convertQuotes(iscancels) & _
             "' and a.isapproved = '" & isApproves & _
            "' and a.datecreated like '%" & convertQuotes(Me.DateCreated.Text) & _
            "%' and a.companyid= '" & companyid &
            "' and a.lastupdate like '%" & convertQuotes(Me.LastUpdate.Text) & _
            "%' "
        Me.filter = filterquery & RRDatequery

        Try
            print("Reporting_SalesInvoice_Main", "filterquery", filter, 0)
        Catch ex As Exception
            'messagebox.show(ex.message)
        End Try

    End Sub
    Public Sub print(ByVal a As String, ByVal parameter As String, ByVal b As String, ByVal c As Integer)
        Try
            command = New MySqlCommand
            connect()
            con.Open()
            With command
                .Connection = con
                .CommandType = CommandType.StoredProcedure
                .CommandText = a
                .Parameters.AddWithValue(parameter, b)
            End With
            Dim da As New MySqlDataAdapter
            Dim ds As New DataSet
            da.SelectCommand = command
            da.SelectCommand.CommandTimeout = 1000
            da.Fill(ds)
            con.Close()
            command.Dispose()

            If Me.GroupNone.Checked = True Then
                Dim crpt As New SalesinvoiceByItems
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer1.ReportSource = crpt
                    Me.CrystalReportViewer1.Refresh()
                End With
                ds.Dispose()
                Me.CrystalReportViewer1.Zoom(100)
                Me.CrystalReportViewer1.Refresh()
            ElseIf Me.BranchGroup.Checked = True Then
                Dim crpt As New InventoryAdjustmentReportGroupByBranch
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer1.ReportSource = crpt
                    Me.CrystalReportViewer1.Refresh()
                End With
                ds.Dispose()
                Me.CrystalReportViewer1.Zoom(100)
                Me.CrystalReportViewer1.Refresh()
            ElseIf Me.ItemGroup.Checked = True Then
                Dim crpt As New InventoryAdjustmentReportGroupByItems
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer1.ReportSource = crpt
                    Me.CrystalReportViewer1.Refresh()
                End With
                ds.Dispose()
                Me.CrystalReportViewer1.Zoom(100)
                Me.CrystalReportViewer1.Refresh()
            ElseIf Me.WarehouseGroup.Checked = True Then
                Dim crpt As New InventoryAdjustmentReportGroupByWarehouse
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer1.ReportSource = crpt
                    Me.CrystalReportViewer1.Refresh()
                End With
                ds.Dispose()
                Me.CrystalReportViewer1.Zoom(100)
                Me.CrystalReportViewer1.Refresh()
            End If

        Catch ex As Exception
            'messagebox.show(ex.message)
        End Try
    End Sub
End Class
