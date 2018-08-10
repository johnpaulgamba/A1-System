Imports mysql.data.mysqlclient
Imports mysql.data
Imports crystaldecisions.shared
Imports crystaldecisions.crystalreports
Imports crystaldecisions.crystalreports.engine

Public Class reportpreview
    Public Sub print(ByVal a As String, ByVal parameter As String, ByVal b As Integer, ByVal c As Integer, ByVal vattype As String, ByVal currency As String)
        ' Try
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
        If c = 1 Then
            Dim crpt As New Sales_Orders_Solo
            With crpt
                .SetDataSource(ds.Tables(0))
                Me.CrystalReportViewer1.ReportSource = crpt
                Me.CrystalReportViewer1.Refresh()
            End With
        ElseIf c = 2 Then
            Dim crpt As New Receiving_Report_Solo
            With crpt
                .SetDataSource(ds.Tables(0))
                Me.CrystalReportViewer1.ReportSource = crpt
                Me.CrystalReportViewer1.Refresh()
            End With

            'DELIVERY RECEIPT SOLO PRINTING FOR 3 COMPANIES
        ElseIf c = 3 Then
            If companyid = 3 Then
                Dim crpt As New DeliveryReceipt_Solo
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer1.ReportSource = crpt
                    Me.CrystalReportViewer1.Refresh()
                End With
            ElseIf companyid = 4 Then
                Dim crpt As New Schuesters_DeliveryReceipt_Solo
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer1.ReportSource = crpt
                    Me.CrystalReportViewer1.Refresh()
                End With
            ElseIf companyid = 5 Then
                Dim crpt As New Starkson_DeliveryReceipt_Solo
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer1.ReportSource = crpt
                    Me.CrystalReportViewer1.Refresh()
                End With
            Else
                Dim crpt As New DeliveryReceipt_Solo
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer1.ReportSource = crpt
                    Me.CrystalReportViewer1.Refresh()
                End With
            End If
            ' SALES INVOICE PRINTING SOLO FOR 3 COMPANIES
        ElseIf c = 4 Then
            Select Case vattype
                Case "VAT Inclusive"

                    If companyid = 3 Then
                        Dim crpt1 As New Vat_Inclusive_Solo
                        Dim Cur1, Cur2, Cur3 As CrystalDecisions.CrystalReports.Engine.TextObject
                        Cur1 = crpt1.ReportDefinition.Sections(2).ReportObjects("cur1")
                        Cur2 = crpt1.ReportDefinition.Sections(3).ReportObjects("cur2")
                        Cur3 = crpt1.ReportDefinition.Sections(4).ReportObjects("cur3")
                        Cur1.Text = currency.ToString : Cur2.Text = currency.ToString : Cur3.Text = currency.ToString

                        With crpt1
                            .SetDataSource(ds.Tables(0))
                            Me.CrystalReportViewer1.ReportSource = crpt1
                            Me.CrystalReportViewer1.Refresh()
                        End With
                    ElseIf companyid = 4 Then
                        Dim crpt1 As New Schuesters_VatInclusive_Solo
                        Dim Cur1, Cur2, Cur3 As CrystalDecisions.CrystalReports.Engine.TextObject
                        Cur1 = crpt1.ReportDefinition.Sections(2).ReportObjects("cur1")
                        Cur2 = crpt1.ReportDefinition.Sections(3).ReportObjects("cur2")
                        Cur3 = crpt1.ReportDefinition.Sections(4).ReportObjects("cur3")
                        Cur1.Text = currency.ToString : Cur2.Text = currency.ToString : Cur3.Text = currency.ToString

                        With crpt1
                            .SetDataSource(ds.Tables(0))
                            Me.CrystalReportViewer1.ReportSource = crpt1
                            Me.CrystalReportViewer1.Refresh()
                        End With
                    ElseIf companyid = 5 Then
                        Dim crpt1 As New Starkson_VatInclusive_Solo
                        Dim Cur1, Cur2, Cur3 As CrystalDecisions.CrystalReports.Engine.TextObject
                        Cur1 = crpt1.ReportDefinition.Sections(2).ReportObjects("cur1")
                        Cur2 = crpt1.ReportDefinition.Sections(3).ReportObjects("cur2")
                        Cur3 = crpt1.ReportDefinition.Sections(4).ReportObjects("cur3")
                        Cur1.Text = currency.ToString : Cur2.Text = currency.ToString : Cur3.Text = currency.ToString

                        With crpt1
                            .SetDataSource(ds.Tables(0))
                            Me.CrystalReportViewer1.ReportSource = crpt1
                            Me.CrystalReportViewer1.Refresh()
                        End With
                    Else
                        Dim crpt1 As New Vat_Inclusive_Solo

                        Dim Cur1, Cur2, Cur3 As CrystalDecisions.CrystalReports.Engine.TextObject
                        Cur1 = crpt1.ReportDefinition.Sections(2).ReportObjects("cur1")
                        Cur2 = crpt1.ReportDefinition.Sections(3).ReportObjects("cur2")
                        Cur3 = crpt1.ReportDefinition.Sections(4).ReportObjects("cur3")
                        Cur1.Text = currency.ToString : Cur2.Text = currency.ToString : Cur3.Text = currency.ToString
                        With crpt1
                            .SetDataSource(ds.Tables(0))
                            Me.CrystalReportViewer1.ReportSource = crpt1
                            Me.CrystalReportViewer1.Refresh()
                        End With
                    End If
                Case "VAT Exclusive"
                    If companyid = 3 Then
                        Dim crpt1 As New Vat_Exclusive_Solo
                        Dim Cur1, Cur2, Cur3 As CrystalDecisions.CrystalReports.Engine.TextObject
                        Cur1 = crpt1.ReportDefinition.Sections(2).ReportObjects("cur1")
                        Cur2 = crpt1.ReportDefinition.Sections(3).ReportObjects("cur2")
                        Cur3 = crpt1.ReportDefinition.Sections(4).ReportObjects("cur3")
                        Cur1.Text = currency : Cur2.Text = currency : Cur3.Text = currency
                        With crpt1
                            .SetDataSource(ds.Tables(0))
                            Me.CrystalReportViewer1.ReportSource = crpt1
                            Me.CrystalReportViewer1.Refresh()
                        End With
                    ElseIf companyid = 4 Then
                        Dim crpt1 As New Schuesters_VatExclusive_Solo
                        Dim Cur1, Cur2, Cur3 As CrystalDecisions.CrystalReports.Engine.TextObject
                        Cur1 = crpt1.ReportDefinition.Sections(2).ReportObjects("cur1")
                        Cur2 = crpt1.ReportDefinition.Sections(3).ReportObjects("cur2")
                        Cur3 = crpt1.ReportDefinition.Sections(4).ReportObjects("cur3")
                        Cur1.Text = currency.ToString : Cur2.Text = currency.ToString : Cur3.Text = currency.ToString

                        With crpt1
                            .SetDataSource(ds.Tables(0))
                            Me.CrystalReportViewer1.ReportSource = crpt1
                            Me.CrystalReportViewer1.Refresh()
                        End With
                    ElseIf companyid = 5 Then
                        Dim crpt1 As New Starkson_VatExclusive_Solo
                        Dim Cur1, Cur2, Cur3 As CrystalDecisions.CrystalReports.Engine.TextObject
                        Cur1 = crpt1.ReportDefinition.Sections(2).ReportObjects("cur1")
                        Cur2 = crpt1.ReportDefinition.Sections(3).ReportObjects("cur2")
                        Cur3 = crpt1.ReportDefinition.Sections(4).ReportObjects("cur3")
                        Cur1.Text = currency.ToString : Cur2.Text = currency.ToString : Cur3.Text = currency.ToString

                        With crpt1
                            .SetDataSource(ds.Tables(0))
                            Me.CrystalReportViewer1.ReportSource = crpt1
                            Me.CrystalReportViewer1.Refresh()
                        End With
                    Else
                        Dim crpt1 As New Vat_Exclusive_Solo
                        Dim Cur1, Cur2, Cur3 As CrystalDecisions.CrystalReports.Engine.TextObject
                        Cur1 = crpt1.ReportDefinition.Sections(2).ReportObjects("cur1")
                        Cur2 = crpt1.ReportDefinition.Sections(3).ReportObjects("cur2")
                        Cur3 = crpt1.ReportDefinition.Sections(4).ReportObjects("cur3")
                        Cur1.Text = currency.ToString : Cur2.Text = currency.ToString : Cur3.Text = currency.ToString

                        With crpt1
                            .SetDataSource(ds.Tables(0))
                            Me.CrystalReportViewer1.ReportSource = crpt1
                            Me.CrystalReportViewer1.Refresh()
                        End With
                    End If
            End Select


        ElseIf c = 6 Then
            Dim crpt As New Reporting_SOA_Solo
            With crpt
                .SetDataSource(ds.Tables(0))
                Me.CrystalReportViewer1.ReportSource = crpt
                Me.CrystalReportViewer1.Refresh()
            End With
        ElseIf c = 7 Then
            Dim crpt As New Reporting_CreditMemo_Solo
            With crpt
                .SetDataSource(ds.Tables(0))
                Me.CrystalReportViewer1.ReportSource = crpt
                Me.CrystalReportViewer1.Refresh()
            End With
        ElseIf c = 8 Then
            Dim crpt As New Reporting_DebitMemo_Solo
            With crpt
                .SetDataSource(ds.Tables(0))
                Me.CrystalReportViewer1.ReportSource = crpt
                Me.CrystalReportViewer1.Refresh()
            End With
        End If

        ds.Dispose()
        da.Dispose()
        Me.CrystalReportViewer1.Zoom(100)
        Me.CrystalReportViewer1.Refresh()
        'Catch ex As Exception
        ' 'messagebox.show(ex.message)
        ' End Try
    End Sub
    Public Sub print2(ByVal a As String, ByVal parameter1 As String, ByVal b As Integer, ByVal parameter2 As String, ByVal b1 As Integer)
        Try
            command = New MySqlCommand
            connect()
            con.Open()
            With command
                .Connection = con
                .CommandType = CommandType.StoredProcedure
                .CommandText = a
                .Parameters.AddWithValue(parameter1, b)
                .Parameters.AddWithValue(parameter2, b1)
            End With
            Dim da As New MySqlDataAdapter
            Dim ds As New DataSet
            da.SelectCommand = command
            da.SelectCommand.CommandTimeout = 1000
            da.Fill(ds)
            con.Close()
            command.Dispose()

            Dim crpt As New Reporting_POMonitoring_Solo
            With crpt
                .SetDataSource(ds.Tables(0))
                Me.CrystalReportViewer1.ReportSource = crpt
                Me.CrystalReportViewer1.Refresh()
            End With

            ds.Dispose()
            da.Dispose()
            Me.CrystalReportViewer1.Zoom(100)
            Me.CrystalReportViewer1.Refresh()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class


