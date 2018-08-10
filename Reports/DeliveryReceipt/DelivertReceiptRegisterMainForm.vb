Imports MySql.Data.MySqlClient
Public Class DeliveryReceiptRegisterMainForm

    Private Sub WarehouseMainForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.C1NavBar1.PanelHeaderFont = New Font("Arial", 12, FontStyle.Bold)
        Me.C1NavBar2.PanelHeaderFont = New Font("Arial", 12, FontStyle.Bold)
        Me.RRDATEFROM.Value = Now
        Me.RRDATETO.Value = Now
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
                    RRDatequery = " and  date_format(a.Drdate, '%Y/%m/%d')  between '" & Format(RRDateFrom.Value, "yyyy/MM/dd") & "' and '" & Format(RRDateTo.Value, "yyyy/MM/dd") & "' "
                Else
                    RRDatequery = " and  a.Drdate >= '" & Format(RRDateFrom.Value, "yyyy/MM/dd") & "' "
                End If
            Else
                If RRDateTo.Text <> Nothing Then
                    RRDatequery = " and a.Drdate<= '" & Format(RRDateTo.Value, "yyyy/MM/dd") & "' "
                Else
                    RRDatequery = " and a.Drdate like '%%' "
                End If
            End If
        End If

        Dim filterquery As String = " and  a.drno like '%" & convertQuotes(Me.DRNo.Text) & _
            "%' and customername like '%" & convertQuotes(Me.customername.Text) & _
            "%' and x.itemname like '%" & convertQuotes(Me.ItemName.Text) & _
            "%' and y.itemcode like '%" & convertQuotes(Me.itemcode.Text) & _
            "%' and a.iscancelled = '" & convertQuotes(iscancels) & _
             "' and a.isapproved = '" & isApproves & _
            "' and a.datecreated like '%" & convertQuotes(Me.DateCreated.Text) & _
                     "%' and a.companyid= '" & companyid &
            "' and a.lastupdate like '%" & convertQuotes(Me.LastUpdate.Text) & _
            "%' "
        Me.filter = filterquery & RRDatequery

        Try
            print("Reporting_DeliveryReceipt_Main", "filterquery", filter, 0)
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
                Dim crpt As New DeliveryReceiptByItems
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer1.ReportSource = crpt
                    Me.CrystalReportViewer1.Refresh()
                End With
                ds.Dispose()
                Me.CrystalReportViewer1.Zoom(100)
                Me.CrystalReportViewer1.Refresh()
            ElseIf Me.PONoGroup.Checked = True Then
                Dim crpt As New Reporting_DeliveryReceipt_GroupByPONo
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer1.ReportSource = crpt
                    Me.CrystalReportViewer1.Refresh()
                End With
                ds.Dispose()
                Me.CrystalReportViewer1.Zoom(100)
                Me.CrystalReportViewer1.Refresh()
            ElseIf Me.ItemGroup.Checked = True Then
                Dim crpt As New Reporting_DeliveryReceipt_GroupByItems
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

    Private Sub C1InputPanel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1InputPanel1.Click

    End Sub
End Class
