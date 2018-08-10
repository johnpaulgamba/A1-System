Imports MySql.Data.MySqlClient
Public Class POMonitoringMainForm

    Private Sub WarehouseMainForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.C1NavBar1.PanelHeaderFont = New Font("Arial", 12, FontStyle.Bold)
        Me.C1NavBar2.PanelHeaderFont = New Font("Arial", 12, FontStyle.Bold)
    End Sub
    Private filter As String = ""
    Private Sub SearchButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchButton.Click

        Dim iscancels As Integer = 0
        Dim isApproves As Integer = 1
        Dim RRDatequery As String = ""
        
      
        Try
            If PoNox.Checked = True Then
                print("Reporting_POMonitoring_Solo", "pono", PONo.Text, 1)
            Else
                print("Reporting_POMonitoring_Solo", "pono", PONo.Text, 2)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Public Sub print(ByVal a As String, ByVal parameter1 As String, ByVal b As String, ByVal c As Integer)
        Try
            command = New MySqlCommand
            connect()
            con.Open()
            With command
                .Connection = con
                .CommandType = CommandType.StoredProcedure
                .CommandText = a
                .Parameters.AddWithValue(parameter1, b)
            End With
            Dim da As New MySqlDataAdapter
            Dim ds As New DataSet
            da.SelectCommand = command
            da.SelectCommand.CommandTimeout = 1000
            da.Fill(ds)
            con.Close()
            command.Dispose()

            If c = 1 Then
                Dim crpt As New Reporting_POMonitoring_Solo
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer1.ReportSource = crpt
                    Me.CrystalReportViewer1.Refresh()
                End With
            Else
                Dim crpt As New Reporting_POMonitoring_GroupByPoNo
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
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class
