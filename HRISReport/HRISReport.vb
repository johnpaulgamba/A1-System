Imports mysql.data.mysqlclient
Imports mysql.data
Imports crystaldecisions.shared
Imports crystaldecisions.crystalreports
Imports crystaldecisions.crystalreports.engine

Public Class reportpreview1
    Public Sub print(ByVal a As String, ByVal parameter As String, ByVal b As Integer, ByVal c As Integer)
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

            '  Dim d1 As New DataSet
            ' Dim adapter1 As New MySqlDataAdapter("Reporting_EmployeeProfileEmployment", con)
            ' With adapter1
            '.SelectCommand.CommandType = CommandType.StoredProcedure
            '.SelectCommand.Parameters.AddWithValue("id", b)
            ' .Fill(d1)
            ' End With

            ' Dim d3 As New DataSet
            ' Dim adapter3 As New MySqlDataAdapter("Reporting_EmployeeProfileEducation", con)
            ' With adapter3
            ' .SelectCommand.CommandType = CommandType.StoredProcedure
            ' .SelectCommand.Parameters.AddWithValue("id", b)
            ' .Fill(d3)
            'End With

            ' Dim d2 As New DataSet
            '  Dim adapter2 As New MySqlDataAdapter("Reporting_EmployeeProfileDependents", con)
            ' With adapter2
            '.SelectCommand.CommandType = CommandType.StoredProcedure
            '.SelectCommand.Parameters.AddWithValue("id", b)
            '.Fill(d2)
            '  End With

            'Dim d4 As New DataSet
            'Dim adapter4 As New MySqlDataAdapter("Reporting_EmployeeProfileTraining", con)
            'With adapter4
            '.SelectCommand.CommandType = CommandType.StoredProcedure
            '.SelectCommand.Parameters.AddWithValue("id", b)
            '.Fill(d4)
            'End With
            'Dim d5 As New DataSet
            'Dim adapter5 As New MySqlDataAdapter("Reporting_EmployeeProfileMemo", con)
            'With adapter5
            '.SelectCommand.CommandType = CommandType.StoredProcedure
            '.SelectCommand.Parameters.AddWithValue("id", b)
            ' .Fill(d5)
            'End With


            con.Close()
            command.Dispose()
            If c = 1 Then
                Dim crpt As New EmployeeProfile201
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer1.ReportSource = crpt
                    Me.CrystalReportViewer1.Refresh()
                    ' .Subreports(0).SetDataSource(d1.Tables(0))
                    ' .Subreports(0).SetDataSource(d2.Tables(0))
                    ' .Subreports(0).SetDataSource(d3.Tables(0))
                    '  .Subreports(0).SetDataSource(d4.Tables(0))
                    ' .Subreports(0).SetDataSource(d5.Tables(0))



                End With
            ElseIf c = 2 Then
                Dim crpt As New EmployeeProfileEducation
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer1.ReportSource = crpt
                    Me.CrystalReportViewer1.Refresh()
                End With
            ElseIf c = 3 Then
                Dim crpt As New EmployeeIndividualMemo
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer1.ReportSource = crpt
                    Me.CrystalReportViewer1.Refresh()
                End With

            ElseIf c = 4 Then
                Dim crpt As New EmployeeNoticetoExplain
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer1.ReportSource = crpt
                    Me.CrystalReportViewer1.Refresh()
                End With
            End If

            ds.Dispose()
            da.Dispose()
            'adapter1.Dispose()
            ' adapter2.Dispose()
            'adapter3.Dispose()
            ' adapter4.Dispose()
            'adapter5.Dispose()

            Me.CrystalReportViewer1.Zoom(100)
            Me.CrystalReportViewer1.Refresh()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
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
    Public Sub print3(ByVal a As String, ByVal parameter1 As String, ByVal b As String, ByVal c As Integer)
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

            Select Case c
                Case 1
                    Dim crpt As New Reporting_POMonitoring_Solo
                    With crpt
                        .SetDataSource(ds.Tables(0))
                        Me.CrystalReportViewer1.ReportSource = crpt
                        Me.CrystalReportViewer1.Refresh()
                    End With
                Case 2
                Case 3

            End Select
            ds.Dispose()
            da.Dispose()
            Me.CrystalReportViewer1.Zoom(100)
            Me.CrystalReportViewer1.Refresh()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class


