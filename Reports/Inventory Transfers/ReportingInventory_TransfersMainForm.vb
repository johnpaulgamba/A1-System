Imports MySql.Data.MySqlClient
Public Class ReportingInventory_TransfersMainForm

    Private Sub WarehouseMainForm_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Me.C1NavBar1.PanelHeaderFont = New Font("Arial", 12, FontStyle.Bold)
        Me.C1NavBar2.PanelHeaderFont = New Font("Arial", 12, FontStyle.Bold)
        Me.TransferDateFrom.Value = Now
        Me.TransferDateTo.Value = Now
    End Sub
    Private filter As String = ""
    Private Sub SearchButton_Click(sender As System.Object, e As System.EventArgs) Handles SearchButton.Click
        'Dim TransferDateQuery As String = ""
        'If Me.TransferDateFrom.Text = Nothing And Me.TransferDateTo.Text = Nothing Then
        '    TransferDateQuery = ""
        'Else
        '    If Me.TransferDateFrom.Text <> Nothing Then
        '        If TransferDateTo.Text <> Nothing Then
        '            TransferDateQuery = " AND  Date_Format(a.TransferDate, '%Y/%m/%d')  between '" & Format(TransferDateFrom.Value, "yyyy/MM/dd") & "' and '" & Format(TransferDateTo.Value, "yyyy/MM/dd") & "' "
        '        Else
        '            TransferDateQuery = " AND  a.TransferDate >= '" & Format(TransferDateFrom.Value, "yyyy/MM/dd") & "' "
        '        End If
        '    Else
        '        If TransferDateTo.Text <> Nothing Then
        '            TransferDateQuery = " AND a.TransferDate<= '" & Format(TransferDateTo.Value, "yyyy/MM/dd") & "' "
        '        Else
        '            TransferDateQuery = " AND a.TransferDate LIKE '%%' "
        '        End If
        '    End If
        'End If
        'Dim DeliveryDateQuery As String = ""
        'If Me.DeliveryDateFrom.Text = Nothing And Me.DeliveryDateTo.Text = Nothing Then
        '    DeliveryDateQuery = ""
        'Else
        '    If Me.DeliveryDateFrom.Text <> Nothing Then
        '        If DeliveryDateTo.Text <> Nothing Then
        '            DeliveryDateQuery = " AND  Date_Format(a.DeliveryDate, '%Y/%m/%d')  between '" & Format(DeliveryDateFrom.Value, "yyyy/MM/dd") & "' and '" & Format(DeliveryDateTo.Value, "yyyy/MM/dd") & "' "
        '        Else
        '            DeliveryDateQuery = " AND  a.DeliveryDate >= '" & Format(DeliveryDateFrom.Value, "yyyy/MM/dd") & "' "
        '        End If
        '    Else
        '        If DeliveryDateTo.Text <> Nothing Then
        '            DeliveryDateQuery = " AND a.DeliveryDate<= '" & Format(DeliveryDateTo.Value, "yyyy/MM/dd") & "' "
        '        Else
        '            DeliveryDateQuery = " AND a.DeliveryDate LIKE '%%' "
        '        End If
        '    End If
        'End If

        'Dim filterQuery As String = "    a.Inventory_TransferID LIKE '%" & convertQuotes(Me.SOReference.Text) & _
        '    "%' AND CustomerName LIKE '%" & convertQuotes(Me.CustomerName.Text) & _
        '    "%' AND a.DateCreated LIKE '%" & convertQuotes(Me.DateCreated.Text) & _
        '    "%' AND a.LastUpdate LIKE '%" & convertQuotes(Me.LastUpdate.Text) & _
        '    "%' AND a.Creator LIKE '%" & convertQuotes(Me.Creator.Text) & "%' "
        ''Me.filter = filterQuery & TransferDateQuery & DeliveryDateQuery
        ''loaddata("Transaction_Inventory_Transfer_Main", filter, Me.C1FlexGrid1)
        Try
            print("Reporting_Inventory_Transfers", "FilterQuery", "")
        Catch ex As Exception

        End Try

    End Sub
    Public Sub print(ByVal a As String, ByVal Parameter As String, ByVal b As String)
        Try
            command = New MySqlCommand
            connect()
            con.Open()
            Dim iscancels As Integer = 3
            Dim isApproves As Integer = 3
            If Me.CancelBoth.Checked = True Then iscancels = 3 Else iscancels = Convert.ToSingle(Me.CancelYes.Checked)
            If Me.ApproveBoth.Checked = True Then isApproves = 3 Else isApproves = Convert.ToSingle(Me.ApproveYes.Checked)
            Dim da As New MySqlDataAdapter(a, con)
            Dim ds As New DataSet
            With da.SelectCommand
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@TransferDateFrom", TransferDateFrom.Value)
                .Parameters.AddWithValue("@TransferDateTo", TransferDateTo.Value)
                .Parameters.AddWithValue("@DeliverFrom", Now)
                .Parameters.AddWithValue("@DeliverTo", Now)
                '  .Parameters.AddWithValue("@CustomerNames", Me.CustomerName.Text)
                .Parameters.AddWithValue("@TransferIDs", Me.SOReference.Text)
                .Parameters.AddWithValue("@Creators", Me.Creator.Text)
                .Parameters.AddWithValue("@DateCreateds", Me.DateCreated.Text)
                .Parameters.AddWithValue("@Lastupdates", Me.LastUpdate.Text)
                .Parameters.AddWithValue("@ItemNames", Me.ItemName.Text)
                .Parameters.AddWithValue("@Branchnames", Me.BranchName.Text)
                .Parameters.AddWithValue("@iscancels", iscancels)
                .Parameters.AddWithValue("@isapproves", isApproves)
                .Parameters.AddWithValue("@WarehouseNames", Me.WarehouseNAme.Text)
            End With
            da.Fill(ds)
            con.Close()
            da.Dispose()
            If Me.GroupNone.Checked = True Then
                Dim crpt As New Inventory_TransferReport
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer1.ReportSource = crpt
                    Me.CrystalReportViewer1.Refresh()
                End With
                ds.Dispose()
                Me.CrystalReportViewer1.Zoom(100)
                Me.CrystalReportViewer1.Refresh()
            ElseIf Me.BranchGroup.Checked = True Then
                'Dim crpt As New Inventory_TransferReportGroupByBranch
                'With crpt
                '    .SetDataSource(ds.Tables(0))
                '    Me.CrystalReportViewer1.ReportSource = crpt
                '    Me.CrystalReportViewer1.Refresh()
                'End With
                'ds.Dispose()
                'Me.CrystalReportViewer1.Zoom(100)
                'Me.CrystalReportViewer1.Refresh()
            ElseIf Me.ItemGroup.Checked = True Then
                'Dim crpt As New Inventory_TransferReportGroupByItems
                'With crpt
                '    .SetDataSource(ds.Tables(0))
                '    Me.CrystalReportViewer1.ReportSource = crpt
                '    Me.CrystalReportViewer1.Refresh()
                'End With
                'ds.Dispose()
                'Me.CrystalReportViewer1.Zoom(100)
                'Me.CrystalReportViewer1.Refresh()
            ElseIf Me.WarehouseGroup.Checked = True Then
                'Dim crpt As New Inventory_TransferReportGroupByWarehouse
                'With crpt
                '    .SetDataSource(ds.Tables(0))
                '    Me.CrystalReportViewer1.ReportSource = crpt
                '    Me.CrystalReportViewer1.Refresh()
                'End With
                'ds.Dispose()
                'Me.CrystalReportViewer1.Zoom(100)
                'Me.CrystalReportViewer1.Refresh()
            End If

        Catch ex As Exception
            'messagebox.show(ex.message)
        End Try
    End Sub
End Class
