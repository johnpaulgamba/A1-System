Imports MySql.Data.MySqlClient
Imports MySql.Data
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine


Public Class StoreProcPrinting
#Region "Hidden"
    'Dim TotalPage As Integer = 1
    'Dim myadapter As New MySqlDataAdapter
    'Dim ds As New DataSet
    'Private Sub PrintDocument_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintDocument.Click
    '    Me.CrystalReportViewer2.PrintReport()
    '    Me.DialogResult = Windows.Forms.DialogResult.OK
    'End Sub
    'Private Sub CloseForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseForm.Click
    '    Me.Close()
    'End Sub  
    'Private Sub Export_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Export.Click
    '    Me.CrystalReportViewer2.ExportReport()
    'End Sub
    'Private Sub First_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles First.Click
    '    Me.CrystalReportViewer2.ShowFirstPage()
    '    Me.PreviousPage.Enabled = False
    '    Me.MoveToLast.Enabled = True
    '    Me.NextPage.Enabled = True
    '    Me.First.Enabled = False
    '    pagings()
    'End Sub
    'Private Sub PreviousPage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PreviousPage.Click
    '    Me.CrystalReportViewer2.ShowPreviousPage()
    '    If Me.CrystalReportViewer2.GetCurrentPageNumber = 1 Then
    '        Me.PreviousPage.Enabled = False
    '        Me.First.Enabled = False
    '    End If
    '    Me.NextPage.Enabled = True
    '    Me.MoveToLast.Enabled = True
    '    pagings()
    'End Sub
    'Private Sub NextPage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextPage.Click
    '    Me.CrystalReportViewer2.ShowNextPage()
    '    If Me.CrystalReportViewer2.GetCurrentPageNumber = TotalPage Then
    '        Me.NextPage.Enabled = False
    '        Me.MoveToLast.Enabled = False
    '    End If
    '    Me.PreviousPage.Enabled = True
    '    Me.First.Enabled = True
    '    pagings()
    'End Sub
    'Private Sub MoveToLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoveToLast.Click
    '    Me.CrystalReportViewer2.ShowLastPage()
    '    Me.NextPage.Enabled = False
    '    Me.First.Enabled = True
    '    Me.PreviousPage.Enabled = True
    '    Me.MoveToLast.Enabled = False
    '    pagings()
    'End Sub
    'Public Sub loadMe()
    '    Me.CrystalReportViewer2.ShowLastPage()
    '    TotalPage = Me.CrystalReportViewer2.GetCurrentPageNumber
    '    Me.CrystalReportViewer2.ShowFirstPage()
    '    Me.TotPage.Text = TotalPage
    '    If TotalPage = 1 Then
    '        Me.NextPage.Enabled = False
    '        Me.PreviousPage.Enabled = False
    '        Me.MoveToLast.Enabled = False
    '        Me.First.Enabled = False
    '    Else
    '        Me.PreviousPage.Enabled = False
    '        Me.First.Enabled = False
    '    End If
    '    pagings()
    'End Sub
    'Private Sub pagings()
    '    Try
    '        Me.CurrentPage.Text = Me.CrystalReportViewer2.GetCurrentPageNumber
    '    Catch ex As Exception
    '        Me.CurrentPage.Text = "0"
    '        Me.TotPage.Text = "0"
    '    End Try
    'End Sub
    'Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        Dim valPage As Integer = Val(Me.TextBox1.Text)
    '        If valPage > TotalPage Then Exit Sub
    '        Me.CrystalReportViewer2.ShowNthPage(valPage)
    '        Me.CurrentPage.Text = valPage
    '    End If
    'End Sub
    'Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
    '    Dim allowedChars As String = "0123456789"
    '    If allowedChars.IndexOf(e.KeyChar) = -1 Then
    '        e.Handled = True
    '    End If
    'End Sub
#End Region
   Private queryA As String = ""
    Private ValueA As Integer = 0
    Public Sub printDaily(ByVal a As String, ByVal b As String, ByVal x As Integer)

        Try
            command = New MySqlCommand
            connect()
            con.Open()
            With command
                .Connection = con
                .CommandType = CommandType.StoredProcedure
                .CommandText = a
                .CommandTimeout = 1000
                .Parameters.AddWithValue(b, x)
            End With
            Dim da As New MySqlDataAdapter
            Dim ds As New DataSet
            da.SelectCommand = command
            da.Fill(ds)
            con.Close()
            command.Dispose()


            If a = "usp_InventoryAdjustments" Then
                Dim crpt As New InventoryStockAdjustments
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                End With
            ElseIf a = "usp_DepartmentalTransfer" Then
                Dim crpt As New DepartmentalInventoryTransfer
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                End With
            ElseIf a = "usp_StockinFromTranspo" Then
                Dim crpt As New ReceiveStockFromTranspo_TP_SOLO
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                End With
            ElseIf a = "usp_InventoryProductionStockIn" Then
                Dim crpt As New ReceiveStockFromProduction_TP_solo
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                End With
            ElseIf a = "usp_InventoryStockTransfer" Then
                Dim crpt As New InventoryStockTransfer_TP_solo
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                End With

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub PrintSalesOrderAdjust(ByVal SalesOrderID As Integer, ByVal SalesBookingID As Integer)

        Try
            command = New MySqlCommand
            connect()
            con.Open()
            With command
                .Connection = con
                .CommandText = "Print_SalesOrderAdjustment"
                .CommandType = CommandType.StoredProcedure
                .CommandTimeout = 1000
                .Parameters.AddWithValue("@SalesOrderIDs", SalesOrderID)
                .Parameters.AddWithValue("@SalesBookingIDs", SalesBookingID)
            End With
            Dim da As New MySqlDataAdapter
            Dim ds As New DataSet
            da.SelectCommand = command
            da.Fill(ds)
            con.Close()
            command.Dispose()
            Dim crpt As New SalesOrderAdjustment
            With crpt
                .SetDataSource(ds.Tables(0))
                Me.CrystalReportViewer2.ReportSource = crpt
                Me.CrystalReportViewer2.Refresh()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private tbcReportTab As System.Windows.Forms.TabControl
    Private myPageView As CrystalDecisions.Windows.Forms.PageView
  
    Sub New()
        InitializeComponent()
        MainLauncher(0)

        Me.CrystalReportViewer2.Zoom(2)
    End Sub
    Dim Page1Only As Integer = 0
    Public Sub dualParamPrintprint(ByVal a As String, ByVal Parameter As String, ByVal Parameter2 As String, ByVal b As Integer, ByVal d As String, ByVal c As Integer, ByVal parameter3 As String, ByVal paramval3 As Integer)
        Me.queryA = a
        Me.ValueA = b
        Try
            command = New MySqlCommand
            connect()
            con.Open()
            With command
                .Connection = con
                .CommandType = CommandType.StoredProcedure
                .CommandText = a
                .Parameters.AddWithValue(Parameter, b)
                .Parameters.AddWithValue(Parameter2, d)
                .Parameters.AddWithValue(parameter3, paramval3)
            End With
            Dim da As New MySqlDataAdapter
            Dim ds As New DataSet
            da.SelectCommand = command
            da.SelectCommand.CommandTimeout = 1000
            da.Fill(ds)
            con.Close()
            command.Dispose()
            If c = 1 Then
              
                    Dim crpt As New PurchaseOrderFormat
                    With crpt
                        .SetDataSource(ds.Tables(0))
                        Me.CrystalReportViewer2.ReportSource = crpt
                        Me.CrystalReportViewer2.Refresh()
                    End With
                    Me.Page1Only = 1
                    Me.ExportReportButton.Enabled = True


            ElseIf c = 2 Then
               
                    Dim crpt As New PurchaseOrderFormatPlain
                    With crpt
                        .SetDataSource(ds.Tables(0))
                        Me.CrystalReportViewer2.ReportSource = crpt
                        Me.CrystalReportViewer2.Refresh()
                    End With
                    Me.Page1Only = 1
                    Me.ExportReportButton.Enabled = True


            End If
            ds.Dispose()
            da.Dispose()
            Me.CrystalReportViewer2.Zoom(100)
            Me.CrystalReportViewer2.Refresh()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    'Public Sub ACFI_Print(ByVal a As String, ByVal Parameter As String, ByVal b As Integer, ByVal c As Integer)
    '    Me.queryA = a
    '    Me.ValueA = b
    '    Try
    '        command = New MySqlCommand
    '        connect()
    '        con.Open()
    '        With command
    '            .Connection = con
    '            .CommandType = CommandType.StoredProcedure
    '            .CommandText = a
    '            .Parameters.AddWithValue(Parameter, b)
    '        End With
    '        Dim da As New MySqlDataAdapter
    '        Dim ds As New DataSet
    '        da.SelectCommand = command
    '        da.SelectCommand.CommandTimeout = 1000
    '        da.Fill(ds)
    '        con.Close()
    '        command.Dispose()
    '        If c = 1 Then
    '            Dim crpt As New ACFI_CheckVoucherPrint
    '            With crpt
    '                .SetDataSource(ds.Tables(0))
    '                Me.CrystalReportViewer2.ReportSource = crpt
    '                Me.CrystalReportViewer2.Refresh()
    '            End With
   



    '        ElseIf c = 3 Then
    '            Dim crpt As New ACFI_CheckVoucherPrint
    '            With crpt
    '                .SetDataSource(ds.Tables(0))
    '                Me.CrystalReportViewer2.ReportSource = crpt
    '                Me.CrystalReportViewer2.Refresh()
    '            End With
    '        ElseIf c = 4 Then
    '            Dim crpt As New ACFI_CheckVoucherPrint
    '            With crpt
    '                .SetDataSource(ds.Tables(0))
    '                Me.CrystalReportViewer2.ReportSource = crpt
    '                Me.CrystalReportViewer2.Refresh()
    '            End With
    '        ElseIf c = 5 Then
    '            Dim crpt As New Purchasing_Inventorytransfer
    '            With crpt
    '                .SetDataSource(ds.Tables(0))
    '                Me.CrystalReportViewer2.ReportSource = crpt
    '                Me.CrystalReportViewer2.Refresh()
    '            End With
    '            Me.ExportReportButton.Enabled = False
    '        End If
    '        ds.Dispose()
    '        da.Dispose()
    '        Me.CrystalReportViewer2.Zoom(100)
    '        Me.CrystalReportViewer2.Refresh()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    End Try
    'End Sub

    Public Sub print(ByVal a As String, ByVal Parameter As String, ByVal b As Integer, ByVal c As Integer)
        Me.queryA = a
        Me.ValueA = b
        Try
            command = New MySqlCommand
            connect()
            con.Open()
            With command
                .Connection = con
                .CommandType = CommandType.StoredProcedure
                .CommandText = a
                .Parameters.AddWithValue(Parameter, b)
            End With
            Dim da As New MySqlDataAdapter
            Dim ds As New DataSet
            da.SelectCommand = command
            da.SelectCommand.CommandTimeout = 1000
            da.Fill(ds)
            con.Close()
            command.Dispose()
            If c = 1 Then
                Dim crpt As New DeliveryReceiptTemplate
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                End With
                Me.Page1Only = 1
                Me.ToolStripButton1.Visible = True
                Me.PrintReportButton.Visible = False
                Me.ExportReportButton.Enabled = True
            ElseIf c = 2 Then
                If database.ToString.ToLower.Contains("tdi") Then
                    Dim crpt As New SalesInvoiceTemplateTDIReg
                    With crpt
                        .SetDataSource(ds.Tables(0))
                        Me.CrystalReportViewer2.ReportSource = crpt
                        Me.CrystalReportViewer2.Refresh()
                    End With
                    Me.Page1Only = 1

                Else
                    If ds.Tables(0).Rows(0).Item("SIType").ToString <> "SI REG" Then
                        Dim crpt As New SalesInvoicePlainNewFormatTemplate
                        With crpt
                            .SetDataSource(ds.Tables(0))
                            Me.CrystalReportViewer2.ReportSource = crpt
                            Me.CrystalReportViewer2.Refresh()
                        End With
                        Me.Page1Only = 1
                    Else
                        Dim crpt As New SalesInvoiceTemplate
                        With crpt
                            .SetDataSource(ds.Tables(0))
                            Me.CrystalReportViewer2.ReportSource = crpt
                            Me.CrystalReportViewer2.Refresh()
                        End With
                        Me.Page1Only = 1
                    End If
                End If
                Me.Page1Only = 1
                Me.ToolStripButton1.Visible = True
                Me.PrintReportButton.Visible = False
                Me.ExportReportButton.Enabled = True
            ElseIf c = 3 Then
                Dim crpt As New PickListTemplate1
                crpt.SetDataSource(ds.Tables(0))
                crpt.PrintOptions.ApplyPageMargins(New CrystalDecisions.Shared.PageMargins(0, 0, 0, 200))
                Me.CrystalReportViewer2.ReportSource = crpt
                Me.ExportReportButton.Visible = False
                Me.PrintReportButton.Visible = False
                Me.ToolStripButton1.Visible = True
            ElseIf c = 4 Then
                Dim crpt As New SalesBookingTemplate1
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                End With
                Me.ExportReportButton.Enabled = False
            ElseIf c = 5 Then
                Dim crpt As New TripTicketTemplate1
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                End With
                Me.ExportReportButton.Enabled = False

            ElseIf c = 6 Then
                Dim crpt As New TripTicketTemplate2Itemized
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                End With
                Me.ExportReportButton.Enabled = False
            ElseIf c = 7 Then
                Dim crpt As New SpecificJobOrderTemplateGroupbySO
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                End With
                Me.ExportReportButton.Enabled = False
            ElseIf c = 8 Then
                Dim crpt As New SpecificJobOrderTemplateGroupbyiTEM
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                End With
                Me.ExportReportButton.Enabled = False
            ElseIf c = 9 Then
                Dim crpt As New packingListTemplate1
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                End With
                Me.ExportReportButton.Enabled = True
            ElseIf c = 10 Then
                Dim crpt As New PackingListTemplate2
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                End With
                Me.ExportReportButton.Enabled = True
            ElseIf c = 11 Then
                Dim crpt As New SalesInvoiceAccomodation2
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                End With
                Me.Page1Only = 1
                Me.ExportReportButton.Enabled = True
            ElseIf c = 12 Then
                Dim crpt As New TripTicketTemplate3
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                End With
                Me.ExportReportButton.Enabled = False
            ElseIf c = 13 Then
                Dim crpt As New PackingListTemplate3
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                End With
                Me.ExportReportButton.Enabled = True
            ElseIf c = 14 Then
                Dim crpt As New MiscellaneousTripTicketTemplate1
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                End With
                Me.ExportReportButton.Enabled = False
            ElseIf c = 15 Then
                Dim crpt As New MiscellaneousTripTicketTemplate2Itemized
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                End With
                Me.ExportReportButton.Enabled = False
            ElseIf c = 16 Then
                Dim crpt As New SalesOrderReportNew
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                End With
                Me.ExportReportButton.Enabled = True
            ElseIf c = 17 Then
                Dim crpt As New CreditNotesReportsX
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                End With
                Me.ExportReportButton.Enabled = True
            ElseIf c = 18 Then
                Dim crpt As New PendingSalesOrder
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                End With
                Me.ExportReportButton.Enabled = True
            ElseIf c = 19 Then
                Dim crpt As New DMsoloreport
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                End With
                Me.ExportReportButton.Enabled = True
            ElseIf c = 20 Then
                Dim crpt As New AcknowledgementReceipt
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                End With
                Me.Page1Only = 1
                Me.ToolStripButton1.Visible = True
                Me.PrintReportButton.Visible = False
                Me.ExportReportButton.Enabled = True
            ElseIf c = 21 Then
                Dim crpt As New CounterReceiptReport
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                End With
                Me.ExportReportButton.Enabled = True
            ElseIf c = 22 Then
         Dim crpt As New StickerTemplate1
                crpt.SetDataSource(ds.Tables(0))
                Me.CrystalReportViewer2.ReportSource = crpt
                Me.ExportReportButton.Visible = False
                Me.PrintReportButton.Visible = False
                Me.ToolStripButton1.Visible = True
                Me.isPicklist = "halfSize"
                Me.ExportReportButton.Enabled = False
            ElseIf c = 23 Then
                Dim crpt As New StickerTemplate2
                crpt.SetDataSource(ds.Tables(0))
                Me.CrystalReportViewer2.ReportSource = crpt
                Me.ExportReportButton.Visible = False
                Me.PrintReportButton.Visible = False
                Me.ToolStripButton1.Visible = True
                Me.isPicklist = "halfSize"
                Me.ExportReportButton.Enabled = False
            ElseIf c = 24 Then
                Dim crpt As New PendingSalesOrderWithoutPrice
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                End With
                Me.ExportReportButton.Enabled = True
            ElseIf c = 25 Then
                Dim crpt As New InvoiceSummaryReport
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                End With
                Me.ExportReportButton.Enabled = True
            ElseIf c = 26 Then
                Dim crpt As New CounterReceiptReportSalesAgent
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                End With
                Me.ExportReportButton.Enabled = True
            ElseIf c = 27 Then
                Dim crpt As New DeliverSummary_Store
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                End With
                Me.ExportReportButton.Enabled = True
            ElseIf c = 28 Then
                Dim crpt As New PackingListTemplate4
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                End With
                Me.ExportReportButton.Enabled = True
                'Metro bank DS Cash
            ElseIf c = 29 Then
                Dim crpt As New MetroCash
                crpt.SetDataSource(ds.Tables(0))
                Me.CrystalReportViewer2.ReportSource = crpt
                Me.ExportReportButton.Visible = False
                Me.PrintReportButton.Visible = False
                Me.ToolStripButton1.Visible = True
                Me.isPicklist = "met3"
                Me.ExportReportButton.Enabled = False
                'Metro Bank DS Check 8.4 x 4
            ElseIf c = 30 Then
                Dim crpt As New MetroCheck
                crpt.SetDataSource(ds.Tables(0))
                Me.CrystalReportViewer2.ReportSource = crpt
                Me.ExportReportButton.Visible = False
                Me.PrintReportButton.Visible = False
                Me.ToolStripButton1.Visible = True
                Me.isPicklist = "met3"
                Me.ExportReportButton.Enabled = False

                'Metro Bank PS
            ElseIf c = 31 Then
                Dim crpt As New MetrobankBillPurchasedTemplateData
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                End With
                Me.ExportReportButton.Enabled = True
            ElseIf c = 32 Then
                Dim crpt As New BDO
                crpt.SetDataSource(ds.Tables(0))
                Me.CrystalReportViewer2.ReportSource = crpt
                Me.ExportReportButton.Visible = False
                Me.PrintReportButton.Visible = False
                Me.ToolStripButton1.Visible = True
                Me.isPicklist = "bdo"
                Me.ExportReportButton.Enabled = False
            ElseIf c = 33 Then
                Dim crpt As New BDOCheckDepositSlipTemplateData
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                End With
                Me.ExportReportButton.Enabled = True
            ElseIf c = 34 Then
                Dim crpt As New Purchase_Request
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                End With
                Me.ExportReportButton.Enabled = False
            ElseIf c = 35 Then
                Dim crpt As New PurchaseOrder
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                End With
                Me.ExportReportButton.Enabled = False
            ElseIf c = 36 Then
                Dim crpt As New ReceivingReport
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                End With
                Me.ExportReportButton.Enabled = False
            ElseIf c = 37 Then
                Dim crpt As New SpecificJobOrderTemplateGroupbyJO
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                End With
                Me.ExportReportButton.Enabled = False
            ElseIf c = 371 Then
                Dim crpt As New SpecificJobOrderTemplateGroupbyJO2
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                End With
                Me.ExportReportButton.Enabled = False
            ElseIf c = 38 Then
                Dim crpt As New Purchasing_Itemissuance
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                End With
                Me.ExportReportButton.Enabled = False
            ElseIf c = 39 Then
                Dim crpt As New Purchasing_Materialsrequisition
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                End With

                Me.ExportReportButton.Enabled = False
            ElseIf c = 40 Then
                Dim crpt As New Purchasing_Stockinitems
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                End With
                Me.ExportReportButton.Enabled = False
            ElseIf c = 41 Then
                Dim crpt As New Purchasing_Itemassignment
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                End With
                Me.ExportReportButton.Enabled = False
            ElseIf c = 42 Then
                Dim crpt As New Purchasing_RollsSetup
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                End With
                Me.ExportReportButton.Enabled = False
            ElseIf c = 43 Then
                Dim crpt As New BDOCheck
                crpt.SetDataSource(ds.Tables(0))
                Me.CrystalReportViewer2.ReportSource = crpt
                Me.ExportReportButton.Visible = False
                Me.PrintReportButton.Visible = False
                Me.ToolStripButton1.Visible = True
                Me.isPicklist = "bdo"
                Me.ExportReportButton.Enabled = False
            ElseIf c = 44 Then
                Dim crpt As New RollsReleaseForm
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                End With
                Me.ExportReportButton.Enabled = False

            ElseIf c = 45 Then
                Dim crpt As New Purchasing_Rollsadjustment
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                End With
                Me.ExportReportButton.Enabled = False
            ElseIf c = 46 Then
                Dim crpt As New Purchasing_Itemadjustment
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                End With
                Me.ExportReportButton.Enabled = False
            ElseIf c = 47 Then
                Dim crpt As New Purchasing_Rollstockin
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                End With
                Me.ExportReportButton.Enabled = False
            ElseIf c = 48 Then
                Dim crpt As New Purchasing_Inventorytransfer
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                End With
                Me.ExportReportButton.Enabled = False
            ElseIf c = 49 Then
                Dim crpt As New PurchaseReturn
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                End With
                Me.ExportReportButton.Enabled = False
            ElseIf c = 50 Then
                Dim crpt As New PackingListTemplateLaNueva2SL
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                End With
            ElseIf c = 51 Then
                Dim crpt As New Transferinoutreport1
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                End With
            ElseIf c = 52 Then
                Dim crpt As New purchasing_rollstransfer
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                End With
            ElseIf c = 53 Then
                Dim crpt As New Purchasejobout
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                End With
            ElseIf c = 54 Then

                Dim crpt As New ReceivingReportSolo
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                End With


            ElseIf c = 55 Then
                Dim crpt As New salesbookinghistorysolo
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                End With
            ElseIf c = 56 Then
                Dim crpt As New PurchaseRRCopy
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                End With
            ElseIf c = 57 Then

                Dim d1 As New DataSet
                Dim adapter2 As New MySqlDataAdapter("GetEntryDetails", con)
                With adapter2
                    .SelectCommand.CommandType = CommandType.StoredProcedure
                    .SelectCommand.Parameters.AddWithValue("@id", b)
                    .Fill(d1)
                End With

                Dim crpt As New Apvfinalxi

                With crpt
                    .SetDataSource(ds.Tables(0))
                    .Subreports("x").SetDataSource(d1.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                End With
            ElseIf c = 58 Then
                Dim crpt As New Pettycash
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                End With
            ElseIf c = 59 Then
                Dim crpt As New accDebitmemoaccounting
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                End With
            ElseIf c = 60 Then
                If database.Contains("aces") Then
                    Dim crpt As New Checkwriter
                    With crpt
                        .SetDataSource(ds.Tables(0))
                        Me.CrystalReportViewer2.ReportSource = crpt
                        Me.CrystalReportViewer2.Refresh()
                    End With
                Else
                    Dim crpt As New Checkwriter
                    With crpt
                        .SetDataSource(ds.Tables(0))
                        Me.CrystalReportViewer2.ReportSource = crpt
                        Me.CrystalReportViewer2.Refresh()
                    End With
                End If

            ElseIf c = 61 Then
                Dim crpt As New accCreditmemoreport
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                End With
            ElseIf c = 62 Then

                Dim d1x As New DataSet
                Dim adapter2x As New MySqlDataAdapter("logo2", con)
                With adapter2x
                    .SelectCommand.CommandType = CommandType.StoredProcedure
                    .Fill(d1x)
                End With

                Dim d1 As New DataSet
                Dim adapter2 As New MySqlDataAdapter("GetCheckdetails", con)
                With adapter2
                    .SelectCommand.Parameters.AddWithValue("@id", b)
                    .SelectCommand.CommandType = CommandType.StoredProcedure
                    .Fill(d1)
                End With
                Dim d2 As New DataSet
                Dim adapter23 As New MySqlDataAdapter("Getvoucher_Invoice", con)
                With adapter23
                    .SelectCommand.Parameters.AddWithValue("@id", b)
                    .SelectCommand.CommandType = CommandType.StoredProcedure
                    .Fill(d2)
                End With
                Dim crpt As New CheckVoucherFinal2
                With crpt
                    .SetDataSource(ds.Tables(0))
                    .Subreports(0).SetDataSource(d1x.Tables(0))
                    .Subreports(1).SetDataSource(d1.Tables(0))
                    .Subreports(2).SetDataSource(d2.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                End With


            ElseIf c = 63 Then
                Dim d1 As New DataSet
                Dim adapter2 As New MySqlDataAdapter("GetCheckdetails", con)
                With adapter2
                    .SelectCommand.Parameters.AddWithValue("@id", b)
                    .SelectCommand.CommandType = CommandType.StoredProcedure
                    .Fill(d1)
                End With
                Dim d2 As New DataSet
                Dim adapter23 As New MySqlDataAdapter("Getvoucher_Invoice", con)
                With adapter23
                    .SelectCommand.Parameters.AddWithValue("@id", b)
                    .SelectCommand.CommandType = CommandType.StoredProcedure
                    .Fill(d2)
                End With

                Dim crpt As New CheckVoucherFinalReg
                With crpt
                    crpt.SetDataSource(ds.Tables(0))
                    .Subreports(0).SetDataSource(d1.Tables(0))
                    .Subreports(1).SetDataSource(d2.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.ExportReportButton.Visible = False
                    Me.PrintReportButton.Visible = False
                    Me.ToolStripButton1.Visible = True
                    Me.isPicklist = "voucher"
                End With

            ElseIf c = 64 Then
                Dim d1x As New DataSet
                Dim adapter2x As New MySqlDataAdapter("logo2", con)
                With adapter2x
                    .SelectCommand.CommandType = CommandType.StoredProcedure
                    .Fill(d1x)
                End With
                Dim d1 As New DataSet
                Dim adapter2 As New MySqlDataAdapter("GetCheckdetails", con)
                With adapter2
                    .SelectCommand.Parameters.AddWithValue("@id", b)
                    .SelectCommand.CommandType = CommandType.StoredProcedure
                    .Fill(d1)
                End With
                Dim d2 As New DataSet
                Dim adapter23 As New MySqlDataAdapter("Getvoucher_Invoice", con)
                With adapter23
                    .SelectCommand.Parameters.AddWithValue("@id", b)
                    .SelectCommand.CommandType = CommandType.StoredProcedure
                    .Fill(d2)
                End With
                Dim crpt As New CheckVoucherFinal2Desc
                With crpt
                    .SetDataSource(ds.Tables(0))
                    .Subreports(0).SetDataSource(d1x.Tables(0))
                    .Subreports(1).SetDataSource(d1.Tables(0))
                    .Subreports(2).SetDataSource(d2.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                End With
            ElseIf c = 65 Then
                Dim d1 As New DataSet
                Dim adapter2 As New MySqlDataAdapter("GetCheckdetails", con)
                With adapter2
                    .SelectCommand.Parameters.AddWithValue("@id", b)
                    .SelectCommand.CommandType = CommandType.StoredProcedure
                    .Fill(d1)
                End With
                Dim d2 As New DataSet
                Dim adapter23 As New MySqlDataAdapter("Getvoucher_Invoice", con)
                With adapter23
                    .SelectCommand.Parameters.AddWithValue("@id", b)
                    .SelectCommand.CommandType = CommandType.StoredProcedure
                    .Fill(d2)
                End With
                Dim crpt As New CheckVoucherFinalPart
                With crpt
                    crpt.SetDataSource(ds.Tables(0))
                    .Subreports(0).SetDataSource(d1.Tables(0))
                    .Subreports(1).SetDataSource(d2.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.ExportReportButton.Visible = False
                    Me.PrintReportButton.Visible = False
                    Me.ToolStripButton1.Visible = True
                    Me.isPicklist = "voucher"
                End With
            ElseIf c = 66 Then
                Dim crpt As New TripTicketTemplate4
                With crpt
                    .SetDataSource(ds.Tables(0))

                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                End With
            ElseIf c = 67 Then
                If database.Contains("aces") Then
                    Dim crpt As New ACFI_BIRFormNo2307
                    With crpt
                        .SetDataSource(ds.Tables(0))
                        Me.CrystalReportViewer2.ReportSource = crpt
                        Me.CrystalReportViewer2.Refresh()
                    End With
                Else
                    Dim crpt As New BIRFormNo2307
                    With crpt
                        .SetDataSource(ds.Tables(0))
                        Me.CrystalReportViewer2.ReportSource = crpt
                        Me.CrystalReportViewer2.Refresh()
                    End With
                End If

            ElseIf c = 68 Then
                Dim d1 As New DataSet
                Dim adapter2 As New MySqlDataAdapter("logo2", con)
                With adapter2
                    .SelectCommand.CommandType = CommandType.StoredProcedure
                    .Fill(d1)
                End With
                Dim crpt As New JournalvoucherPrinting
                With crpt
                    .PrintOptions.PrinterName = ""
                    .SetDataSource(ds.Tables(0))
                    .Subreports(0).SetDataSource(d1.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                End With
                Me.ExportReportButton.Enabled = False
            ElseIf c = 69 Then
                Dim d1 As New DataSet
                Dim adapter2 As New MySqlDataAdapter("logo2", con)
                With adapter2
                    .SelectCommand.CommandType = CommandType.StoredProcedure
                    .Fill(d1)
                End With
                Dim crpt As New RollConversionReport
                With crpt
                    .SetDataSource(ds.Tables(0))
                    .Subreports(0).SetDataSource(d1.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                End With
                Me.ExportReportButton.Enabled = False
            ElseIf c = 70 Then
                Dim crpt As New POSSaleasorderReport
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                End With
            ElseIf c = 71 Then
                Dim crpt As New accDebitmemoappliedreport
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                End With
            ElseIf c = 72 Then
                Dim crpt As New accCreditmemoappliedreport
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                End With
            ElseIf c = 73 Then
                Dim crpt As New BIRFormNo2307CNC
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                End With
            ElseIf c = 74 Then
                Dim crpt As New BIRFormNo2307CV
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                End With
            ElseIf c = 75 Then
                Dim d1x As New DataSet
                Dim adapter2x As New MySqlDataAdapter("logo2", con)
                With adapter2x
                    .SelectCommand.CommandType = CommandType.StoredProcedure
                    .Fill(d1x)
                End With

                Dim crpt As New ReturntoVendor
                With crpt
                    .SetDataSource(ds.Tables(0))
                    .Subreports(0).SetDataSource(d1x.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                End With
            ElseIf c = 76 Then
                Dim d1x As New DataSet
                Dim adapter2x As New MySqlDataAdapter("logo2", con)
                With adapter2x
                    .SelectCommand.CommandType = CommandType.StoredProcedure
                    .Fill(d1x)
                End With
                Dim crpt As New PaymentApplicationPrintout
                With crpt
                    .SetDataSource(ds.Tables(0))
                    .Subreports(0).SetDataSource(d1x.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                End With
            ElseIf c = 77 Then
                Dim d1x As New DataSet
                Dim adapter2x As New MySqlDataAdapter("logo2", con)
                With adapter2x
                    .SelectCommand.CommandType = CommandType.StoredProcedure
                    .Fill(d1x)
                End With
                Dim crpt As New CreditApplicationPrintout
                With crpt
                    .SetDataSource(ds.Tables(0))
                    .Subreports(0).SetDataSource(d1x.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                End With
            ElseIf c = 78 Then
                Dim d1x As New DataSet
                Dim adapter2x As New MySqlDataAdapter("logo2", con)
                With adapter2x
                    .SelectCommand.CommandType = CommandType.StoredProcedure
                    .Fill(d1x)
                End With
                Dim crpt As New DebitApplicationPrintout
                With crpt
                    .SetDataSource(ds.Tables(0))
                    .Subreports(0).SetDataSource(d1x.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                End With
            ElseIf c = 79 Then
                Dim crpt As New VisminPackingListFinal
                With crpt
                    .SetDataSource(ds.Tables(0))
                    '.Subreports(0).SetDataSource(d1x.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                End With
            ElseIf c = 80 Then
                Dim d1x As New DataSet
                Dim adapter2x As New MySqlDataAdapter("logo2", con)
                With adapter2x
                    .SelectCommand.CommandType = CommandType.StoredProcedure
                    .Fill(d1x)
                End With
                Dim crpt As New RollsReturnFinal
                With crpt
                    .SetDataSource(ds.Tables(0))
                    .Subreports(0).SetDataSource(d1x.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                End With
            ElseIf c = 81 Then
                Dim crpt As New DRPackinglistStyle
                With crpt
                    .SetDataSource(ds.Tables(0))
                    '.Subreports(0).SetDataSource(d1x.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                End With
            ElseIf c = 82 Then
                Dim crpt As New SMBarcodePrintOut
                With crpt
                    .SetDataSource(ds.Tables(0))
                    '.Subreports(0).SetDataSource(d1x.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                End With
            End If
            ds.Dispose()
            da.Dispose()
            Me.CrystalReportViewer2.Zoom(100)
            Me.CrystalReportViewer2.Refresh()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub Export_Print(ByVal c As Integer, ByVal b As String, ByVal b1 As Integer)
        Try
            If c = 80 Then
                Dim d1 As New DataSet
                Dim d2 As New DataSet
                Dim adapter2 As New MySqlDataAdapter("GetImageForPDF", con)
                With adapter2
                    .SelectCommand.Parameters.AddWithValue("@DocTypes", b)
                    .SelectCommand.CommandType = CommandType.StoredProcedure
                    .Fill(d1)
                    .Dispose()
                End With
                Dim adapternew As New MySqlDataAdapter("PrintDR", con)
                With adapternew
                    .SelectCommand.Parameters.AddWithValue("@DRID", b1)
                    .SelectCommand.CommandType = CommandType.StoredProcedure
                    .Fill(d2)
                    .Dispose()
                End With
                Dim crpt As New DRPDFrpt
                With crpt
                    .Subreports(0).SetDataSource(d2.Tables(0))
                    .SetDataSource(d1.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                    Me.CrystalReportViewer2.ExportReport()
                End With
            ElseIf c = 81 Then
                Dim d1 As New DataSet
                Dim d2 As New DataSet
                Dim adapter2 As New MySqlDataAdapter("GetImageForPDF", con)
                With adapter2
                    .SelectCommand.Parameters.AddWithValue("@DocTypes", b)
                    .SelectCommand.CommandType = CommandType.StoredProcedure
                    .Fill(d1)
                    .Dispose()
                End With
                Dim adapternew As New MySqlDataAdapter("PrintSI", con)
                With adapternew
                    .SelectCommand.Parameters.AddWithValue("@SIID", b1)
                    .SelectCommand.CommandType = CommandType.StoredProcedure
                    .Fill(d2)
                    .Dispose()
                End With
                Dim crpt As New SIPDF
                With crpt
                    .Subreports(0).SetDataSource(d2.Tables(0))
                    .SetDataSource(d1.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                    Me.CrystalReportViewer2.ExportReport()
                End With

            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub printPicklistBatch(ByVal a As String, ByVal c As String)

        Try
            connect()
            con.Open()
            Dim ds As New DataSet
            Dim da As New MySqlDataAdapter("PrintPicklistBatch_FinalVersion02", con)
            With da
                .SelectCommand.CommandType = CommandType.StoredProcedure
                .SelectCommand.Parameters.AddWithValue("PicklistIds", c)
                .SelectCommand.CommandTimeout = 1000000
                .Fill(ds)
                .Dispose()
            End With
            con.Close()
            Dim crpt As New PickListTemplate2
            With crpt
                .SetDataSource(ds.Tables(0))
                Me.ExportReportButton.Visible = False
                Me.PrintReportButton.Visible = False
                Me.ToolStripButton1.Visible = True
                Me.CrystalReportViewer2.ReportSource = crpt
                Me.CrystalReportViewer2.Refresh()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Function GetPapersizeID(ByVal PrinterName As String, ByVal PaperSizeName As String) As Integer
        Dim doctoprint As New System.Drawing.Printing.PrintDocument()
        Dim PaperSizeID As Integer = 0
        Dim ppname As String = ""
        Dim s As String = ""
        doctoprint.PrinterSettings.PrinterName = PrinterName
        For i As Integer = 0 To doctoprint.PrinterSettings.PaperSizes.Count - 1
            Dim rawKind As Integer
            ppname = PaperSizeName
            If doctoprint.PrinterSettings.PaperSizes(i).PaperName = ppname Then
                rawKind = CInt(doctoprint.PrinterSettings.PaperSizes(i).GetType().GetField("kind", Reflection.BindingFlags.Instance Or Reflection.BindingFlags.NonPublic).GetValue(doctoprint.PrinterSettings.PaperSizes(i)))
                PaperSizeID = rawKind
                Exit For
            End If
        Next
        Return PaperSizeID
    End Function
    Public Sub printNTR1(ByVal a As String, ByVal i1 As Integer)
        Try
            command = New MySqlCommand
            connect()
            con.Open()
            With command
                .Connection = con
                .CommandType = CommandType.StoredProcedure
                .CommandText = a
                .Parameters.AddWithValue("@ntID", i1)
            End With
            Dim da As New MySqlDataAdapter
            Dim ds As New DataSet
            da.SelectCommand = command
            da.Fill(ds)
            con.Close()
            command.Dispose()
            Dim crpt As New PulloutForm_Solo
            With crpt
                .SetDataSource(ds.Tables(0))
                Me.CrystalReportViewer2.ReportSource = crpt
                Me.CrystalReportViewer2.Refresh()
            End With
        Catch ex As Exception
        End Try
    End Sub

    Private Sub PrintReportButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintReportButton.Click
        If Me.Page1Only = 1 Then
            Dim printDialog1 As New PrintDialog
            Dim printDocument1 As New System.Drawing.Printing.PrintDocument
            printDialog1.Document = printDocument1
            Dim dr As DialogResult = printDialog1.ShowDialog()
            If dr = System.Windows.Forms.DialogResult.OK Then
                Dim nCopies As Integer = printDocument1.PrinterSettings.Copies
                Dim sPage As Integer = printDocument1.PrinterSettings.FromPage
                Dim ePage As Integer = printDocument1.PrinterSettings.ToPage
                Dim PrinterName As String = printDocument1.PrinterSettings.PrinterName
                Dim crReportDocument As CrystalDecisions.CrystalReports.Engine.ReportDocument
                crReportDocument = Me.CrystalReportViewer2.ReportSource
                Try
                    crReportDocument.PrintOptions.PrinterName = PrinterName
                    crReportDocument.PrintToPrinter(nCopies, False, sPage, ePage)
                Catch ex As Exception
                    MessageBox.Show(ex.ToString())
                End Try
                Me.PrintCopy = nCopies
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        Else
            Dim printDialog1 As New PrintDialog
            Dim printDocument1 As New System.Drawing.Printing.PrintDocument
            printDialog1.Document = printDocument1
            Dim dr As DialogResult = printDialog1.ShowDialog()
            If dr = System.Windows.Forms.DialogResult.OK Then
                Dim nCopies As Integer = printDocument1.PrinterSettings.Copies
                Dim sPage As Integer = printDocument1.PrinterSettings.FromPage
                Dim ePage As Integer = printDocument1.PrinterSettings.ToPage
                Dim PrinterName As String = printDocument1.PrinterSettings.PrinterName
                Dim crReportDocument As CrystalDecisions.CrystalReports.Engine.ReportDocument
                crReportDocument = Me.CrystalReportViewer2.ReportSource
                Try
                    crReportDocument.PrintOptions.PrinterName = PrinterName
                    crReportDocument.PrintToPrinter(nCopies, False, sPage, ePage)
                Catch ex As Exception
                    MessageBox.Show(ex.ToString())
                End Try
                Me.PrintCopy = nCopies
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        End If
    End Sub
    Private Sub ExportReportButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportReportButton.Click
        Me.CrystalReportViewer2.ExportReport()
    End Sub
    Private Sub RefreshReportButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshReportButton.Click
        MainLauncher(0)
        Me.CrystalReportViewer2.Refresh()
        MainLauncher(1)
    End Sub
    Private Sub CloseFormButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseFormButton.Click
        Me.Close()
    End Sub

    Public Sub printSalesReport(ByVal a As String, _
                                      ByVal Customer As String, _
                                      ByVal BranchSite As String, _
                                      ByVal Agent As String, _
                                      ByVal SalesGroup As String, _
                                      ByVal SalesAreas As String, _
                                      ByVal ItemDescription As String, _
                                      ByVal ItemFamily As String, _
                                      ByVal ItemCategory As String, _
                                      ByVal ItemBrand As String, _
                                      ByVal StartDate As Date, _
                                      ByVal EndDate As Date, _
                                      ByVal c As Integer)
        Try
            command = New MySqlCommand
            connect()
            con.Open()
            With command
                .Connection = con
                .CommandType = CommandType.StoredProcedure
                .CommandText = a
                .Parameters.AddWithValue("@Customer", Customer)
                .Parameters.AddWithValue("@BranchSite", BranchSite)
                .Parameters.AddWithValue("@Agent", Agent)
                .Parameters.AddWithValue("@SalesGroup", SalesGroup)
                .Parameters.AddWithValue("@SalesArea", SalesAreas)
                .Parameters.AddWithValue("@DeliveryArea", SalesAreas)
                .Parameters.AddWithValue("@ItemDescription", ItemDescription)
                .Parameters.AddWithValue("@ItemFamily", ItemFamily)
                .Parameters.AddWithValue("@ItemCategory", ItemCategory)
                .Parameters.AddWithValue("@ItemBrand", ItemBrand)
                .Parameters.AddWithValue("@StartDate", StartDate)
                .Parameters.AddWithValue("@EndDate", EndDate)
            End With
            Dim da As New MySqlDataAdapter
            Dim ds As New DataSet
            da.SelectCommand = command
            da.Fill(ds)
            con.Close()
            command.Dispose()
            If c = 1 Then
                Dim crpt As New SalesReportByItem
                With crpt
                    .SetDataSource(ds.Tables(0))
                    .SetParameterValue("Customer1", Customer)
                    .SetParameterValue("Branch1", BranchSite)
                    .SetParameterValue("SalesAgent1", Agent)
                    .SetParameterValue("ItemFam1", ItemFamily)
                    .SetParameterValue("ItemDesc1", ItemDescription)
                    .SetParameterValue("ItemCategory1", ItemCategory)
                    .SetParameterValue("Brand1", ItemBrand)
                    .SetParameterValue("SalesGroup1", SalesGroup)
                    .SetParameterValue("SalesArea1", SalesAreas)
                    .SetParameterValue("dateSE", "Report as of : " & StartDate & "-" & EndDate)
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                End With
            ElseIf c = 2 Then
                Dim crpt As New SalesRepArea
                With crpt
                    .SetDataSource(ds.Tables(0))
                    .SetParameterValue("Customer1", Customer)
                    .SetParameterValue("Branch1", BranchSite)
                    .SetParameterValue("SalesAgent1", Agent)
                    .SetParameterValue("ItemFam1", ItemFamily)
                    .SetParameterValue("ItemDesc1", ItemDescription)
                    .SetParameterValue("ItemCategory1", ItemCategory)
                    .SetParameterValue("Brand1", ItemBrand)
                    .SetParameterValue("SalesGroup1", SalesGroup)
                    .SetParameterValue("SalesArea1", SalesAreas)
                    .SetParameterValue("dateSE", "Report as of : " & StartDate & "-" & EndDate)
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                End With

            ElseIf c = 3 Then
                Dim crpt As New SalesRepCustomer
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    .SetParameterValue("Customer1", Customer)
                    .SetParameterValue("Branch1", BranchSite)
                    .SetParameterValue("SalesAgent1", Agent)
                    .SetParameterValue("ItemFam1", ItemFamily)
                    .SetParameterValue("ItemDesc1", ItemDescription)
                    .SetParameterValue("ItemCategory1", ItemCategory)
                    .SetParameterValue("Brand1", ItemBrand)
                    .SetParameterValue("SalesGroup1", SalesGroup)
                    .SetParameterValue("SalesArea1", SalesAreas)
                    .SetParameterValue("dateSE", "Report as of : " & StartDate & "-" & EndDate)
                    Me.CrystalReportViewer2.Refresh()
                End With
            ElseIf c = 4 Then
                Dim crpt As New SalesRepSalesMan
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    .SetParameterValue("Customer1", Customer)
                    .SetParameterValue("Branch1", BranchSite)
                    .SetParameterValue("SalesAgent1", Agent)
                    .SetParameterValue("ItemFam1", ItemFamily)
                    .SetParameterValue("ItemDesc1", ItemDescription)
                    .SetParameterValue("ItemCategory1", ItemCategory)
                    .SetParameterValue("Brand1", ItemBrand)
                    .SetParameterValue("SalesGroup1", SalesGroup)
                    .SetParameterValue("SalesArea1", SalesAreas)
                    .SetParameterValue("dateSE", "Report as of : " & StartDate & "-" & EndDate)
                    Me.CrystalReportViewer2.Refresh()
                End With
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private isPicklist As String = ""


    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        printpaper(isPicklist)
    End Sub
    Private Sub printpaper(ByVal a As String)
        MainLauncher(0)
        Dim printDialog1 As New PrintDialog
        Dim printDocument1 As New System.Drawing.Printing.PrintDocument
        printDialog1.Document = printDocument1
        printDialog1.AllowSomePages = True
        Dim dr As DialogResult = printDialog1.ShowDialog()
        If dr = System.Windows.Forms.DialogResult.OK Then
            Dim nCopies As Integer = printDocument1.PrinterSettings.Copies
            Dim sPage As Integer = printDocument1.PrinterSettings.FromPage
            Dim ePage As Integer = printDocument1.PrinterSettings.ToPage
            Dim PrinterName As String = printDocument1.PrinterSettings.PrinterName
            Dim crReportDocument As CrystalDecisions.CrystalReports.Engine.ReportDocument
            crReportDocument = Me.CrystalReportViewer2.ReportSource
            Try

                With crReportDocument.PrintOptions
                    .PrinterName = PrinterName
                    .PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
                    If a <> "" Then
                        .PaperSize = GetPapersizeID(PrinterName, a)
                        .ApplyPageMargins(New CrystalDecisions.Shared.PageMargins(0, 0, 0, 0))
                    End If
                    If Me.Page1Only = 1 Then
                        crReportDocument.PrintToPrinter(nCopies, False, 1, 1)
                    Else
                        crReportDocument.PrintToPrinter(nCopies, False, sPage, ePage)
                    End If

                End With
                Me.PrintCopy = nCopies
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
        MainLauncher(1)
    End Sub
    Public PrintCopy As Integer = 1

    Private Sub StoreProcPrinting_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.Modifiers = Keys.Alt Then
            If e.KeyCode = Keys.P Then
                If Me.ToolStripButton1.Visible = False Then
                    Me.PrintReportButton.PerformClick()
                Else
                    ToolStripButton1.PerformClick()
                End If

            End If
        End If
    End Sub

    Private Sub StoreProcPrinting_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
      
    End Sub

    Private Sub CrystalReportViewer2_Load(sender As System.Object, e As System.EventArgs) Handles CrystalReportViewer2.Load
        '  CType(Me.CrystalReportViewer2.ReportSource, CrystalDecisions.CrystalReports.Engine.ReportDocument)
    End Sub
End Class
