Imports MySql.Data.MySqlClient
Public Class ReportFormPrinting
    Dim TotalPage As Integer = 1
    Dim myadapter As New MySqlDataAdapter
    Dim ds As New DataSet
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
            con.Close()
            command.Dispose()
            If c = 1 Then
                Dim crpt As New EmployeeProfile201
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                End With
            ElseIf c = 2 Then
                Dim crpt As New EmployeeProfileEducation
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                End With
            ElseIf c = 3 Then
                Dim crpt As New EmployeeIndividualMemo
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                End With
            ElseIf c = 4 Then
                Dim crpt As New EmployeeNoticetoExplain
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                End With
            ElseIf c = 5 Then
                Dim crpt As New PayrollRegister_Weekly
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                End With
            ElseIf c = 6 Then
                Dim crpt As New PayrollRegister_SemiMonthly
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                End With
            ElseIf c = 8 Then
                Dim crpt As New PaySlip_Weekly
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                End With
            ElseIf c = 7 Then
                Dim crpt As New PaySlip_SemiMonthly
                With crpt
                    .SetDataSource(ds.Tables(0))
                    Me.CrystalReportViewer2.ReportSource = crpt
                    Me.CrystalReportViewer2.Refresh()
                End With
            End If

            ds.Dispose()
            da.Dispose()
            Me.CrystalReportViewer2.Zoom(100)
            Me.CrystalReportViewer2.Refresh()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Public Sub print3(ByVal a As String, ByVal parameter1 As String, ByVal b As String, ByVal c As Integer, ByVal x As Integer)
        Try
            command = New MySqlCommand
            connect()
            con.Open()
            With command
                .Connection = con
                .CommandType = CommandType.StoredProcedure
                .CommandText = a
                .Parameters.AddWithValue(parameter1, b)
                .Parameters.AddWithValue("groupbys", " group by x.employeeid order by x.lastname, x.firstname asc;")
                .Parameters.AddWithValue("x", x)
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
                Case 2
                Case 5
                    Dim crpt As New PayrollRegister_Weekly1
                    With crpt
                        .SetDataSource(ds.Tables(0))
                        Me.CrystalReportViewer2.ReportSource = crpt
                        Me.CrystalReportViewer2.Refresh()
                    End With
                Case 6
                    Dim crpt As New PayrollRegister_SemiMonthly1
                    With crpt
                        .SetDataSource(ds.Tables(0))
                        Me.CrystalReportViewer2.ReportSource = crpt
                        Me.CrystalReportViewer2.Refresh()
                    End With
                Case 7
                    Dim crpt As New PayrollRegister_SemiMonthly_Audit
                    With crpt
                        .SetDataSource(ds.Tables(0))
                        Me.CrystalReportViewer2.ReportSource = crpt
                        Me.CrystalReportViewer2.Refresh()
                    End With
                Case 8
                    Dim crpt As New PayrollRegisterOnvoucher_SemiMonthly
                    With crpt
                        .SetDataSource(ds.Tables(0))
                        Me.CrystalReportViewer2.ReportSource = crpt
                        Me.CrystalReportViewer2.Refresh()
                    End With
                Case 9
                    Dim crpt As New PayrollRegisterOnVoucher_Weekly
                    With crpt
                        .SetDataSource(ds.Tables(0))
                        Me.CrystalReportViewer2.ReportSource = crpt
                        Me.CrystalReportViewer2.Refresh()
                    End With
            End Select
            ds.Dispose()
            da.Dispose()
            Me.CrystalReportViewer2.Zoom(100)
            Me.CrystalReportViewer2.Refresh()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub printReports(ByVal a As String, ByVal b As String, ByVal c As Integer)

        Try
            command = New MySqlCommand
            connect()
            con.Open()
            With command
                .Connection = con
                .CommandType = CommandType.StoredProcedure
                .CommandText = a
                .Parameters.AddWithValue("@filterquery", b)
                .Parameters.AddWithValue("@groupby", " group by a.employeeid")
            End With
            Dim da As New MySqlDataAdapter
            Dim ds As New DataSet
            da.SelectCommand = command
            da.SelectCommand.CommandTimeout = 1000
            da.Fill(ds)
            con.Close()
            command.Dispose()
            If ds.Tables(0).Rows.Count <= 0 Then
                MessageBox.Show("Search not found!, Please try another search category")
            Else
                If c = 1 Then
                    Dim crpt As New Payroll_Voucher
                    With crpt
                        .SetDataSource(ds.Tables(0))
                        Me.CrystalReportViewer2.ReportSource = crpt
                        Me.CrystalReportViewer2.Refresh()
                    End With
                Else
                    MessageBox.Show("Search not found!, Please try another search category")
                End If
            End If
            '   HideTabs()
            ds.Dispose()
            da.Dispose()
            Me.CrystalReportViewer2.Zoom(150)
            Me.CrystalReportViewer2.Refresh()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            'MessageBox.Show("Search not found!, Please try another search category")
        End Try
    End Sub
    Public Sub print4(ByVal a As String, ByVal parameter1 As String, ByVal b As String, ByVal c As Integer, ByVal x As Integer)
        Try
            command = New MySqlCommand
            connect()
            con.Open()
            With command
                .Connection = con
                .CommandType = CommandType.StoredProcedure
                .CommandText = a
                .Parameters.AddWithValue(parameter1, b)
                .Parameters.AddWithValue("x", x)
            End With
            Dim da As New MySqlDataAdapter
            Dim ds As New DataSet
            da.SelectCommand = command
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.CommandTimeout = 10000
            da.Fill(ds)
            con.Close()
            command.Dispose()

            Select Case c
                Case 1
                    Dim crpt As New PaySlip_SemiMonthly
                    With crpt
                        .SetDataSource(ds.Tables(0))
                        Me.CrystalReportViewer2.ReportSource = crpt
                        Me.CrystalReportViewer2.Refresh()
                    End With
                Case 2
                    Dim crpt As New PaySlip_Weekly
                    With crpt
                        .SetDataSource(ds.Tables(0))
                        Me.CrystalReportViewer2.ReportSource = crpt
                        Me.CrystalReportViewer2.Refresh()
                    End With
                Case 3
                    Dim crpt As New PaySlip_Weekly
                    With crpt
                        .SetDataSource(ds.Tables(0))
                        Me.CrystalReportViewer2.ReportSource = crpt
                        Me.CrystalReportViewer2.Refresh()
                    End With
                Case 4
                Case 3
                    Dim crpt As New PaySlip_Weekly_Allowance
                    With crpt
                        .SetDataSource(ds.Tables(0))
                        Me.CrystalReportViewer2.ReportSource = crpt
                        Me.CrystalReportViewer2.Refresh()
                    End With
            End Select
            ds.Dispose()
            da.Dispose()
            Me.CrystalReportViewer2.Zoom(150)
            Me.CrystalReportViewer2.Refresh()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub PrintDocument_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintDocument.Click
        Me.CrystalReportViewer2.PrintReport()
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
    Private Sub CloseForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseForm.Click
        Me.Close()
    End Sub
    Private Sub Export_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Export.Click
        Me.CrystalReportViewer2.ExportReport()
    End Sub
    Private Sub First_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles First.Click
        Me.CrystalReportViewer2.ShowFirstPage()
        '    Me.TotalPage = Me.CrystalReportViewer2.GetCurrentPageNumber
        Me.PreviousPage.Enabled = False
        Me.MoveToLast.Enabled = True
        Me.NextPage.Enabled = True
        Me.First.Enabled = False
        pagings()
    End Sub
    Private Sub PreviousPage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PreviousPage.Click
        Me.CrystalReportViewer2.ShowPreviousPage()
        If Me.CrystalReportViewer2.GetCurrentPageNumber = 1 Then
            Me.PreviousPage.Enabled = False
            Me.First.Enabled = False
        End If
        Me.NextPage.Enabled = True
        Me.MoveToLast.Enabled = True
        pagings()
    End Sub
    Private Sub NextPage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextPage.Click
        Me.CrystalReportViewer2.ShowNextPage()
        If Me.CrystalReportViewer2.GetCurrentPageNumber = TotalPage Then
            Me.NextPage.Enabled = False
            Me.MoveToLast.Enabled = False
        End If
        Me.PreviousPage.Enabled = True
        Me.First.Enabled = True
        pagings()
    End Sub
    Private Sub MoveToLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoveToLast.Click
        Me.CrystalReportViewer2.ShowLastPage()
        Me.NextPage.Enabled = False
        Me.First.Enabled = True
        Me.PreviousPage.Enabled = True
        Me.MoveToLast.Enabled = False
        pagings()
    End Sub
    Public Sub loadMe()
        Me.CrystalReportViewer2.ShowLastPage()
        TotalPage = Me.CrystalReportViewer2.GetCurrentPageNumber
        Me.CrystalReportViewer2.ShowFirstPage()
        Me.TotPage.Text = TotalPage
        If TotalPage = 1 Then
            Me.NextPage.Enabled = False
            Me.PreviousPage.Enabled = False
            Me.MoveToLast.Enabled = False
            Me.First.Enabled = False
        Else
            Me.PreviousPage.Enabled = False
            Me.First.Enabled = False
        End If
        pagings()
    End Sub
    Private Sub pagings()
        Try
            Me.CurrentPage.Text = Me.CrystalReportViewer2.GetCurrentPageNumber
        Catch ex As Exception
            Me.CurrentPage.Text = "0"
            Me.TotPage.Text = "0"
        End Try
    End Sub
    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim valPage As Integer = Val(Me.TextBox1.Text)
            If valPage > TotalPage Then Exit Sub
            Me.CrystalReportViewer2.ShowNthPage(valPage)
            Me.CurrentPage.Text = valPage
        End If
    End Sub
    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        Dim allowedChars As String = "0123456789"
        If allowedChars.IndexOf(e.KeyChar) = -1 Then
            e.Handled = True
        End If
    End Sub
    Private Sub RibbonTrackBar1_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RibbonTrackBar1.MouseEnter
        Timer1.Start()
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.CrystalReportViewer2.Zoom(Me.RibbonTrackBar1.Value)
        Me.ZoomOf.Text = (RibbonTrackBar1.Value / 100) * 100 & "%"
    End Sub
    Private Sub RibbonTrackBar1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles RibbonTrackBar1.MouseLeave
        Timer1.Stop()
    End Sub
    Private Sub RibbonTrackBar1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RibbonTrackBar1.ValueChanged
        Timer1.Start()
    End Sub
    Private tbcReportTab As System.Windows.Forms.TabControl
    Private myPageView As CrystalDecisions.Windows.Forms.PageView
    Private Sub HideTabs()
        Dim crvObject As Object
        For Each crvObject In Me.CrystalReportViewer2.Controls
            If crvObject.GetType Is GetType(CrystalDecisions.Windows.Forms.PageView) Then
                myPageView = CType(crvObject, CrystalDecisions.Windows.Forms.PageView)
                Dim crvObjectControl As Object
                For Each crvObjectControl In crvObject.controls
                    If crvObjectControl.GetType Is GetType(TabControl) Then
                        tbcReportTab = crvObjectControl
                    End If
                Next
            End If
        Next
        With tbcReportTab
            .ItemSize = New Size(0, 1)
            .SizeMode = TabSizeMode.Fixed
            .Dock = DockStyle.None
            .Left -= 4
            .Top -= 5
            .Width = .Parent.Width + 8
            .Height = .Parent.Height + 9
            .Anchor = AnchorStyles.Left Or AnchorStyles.Top Or AnchorStyles.Right Or AnchorStyles.Bottom
            .Appearance = TabAppearance.Normal
        End With
        With tbcReportTab.TabPages(0)
            .BackColor = Me.BackgroundColor
        End With
    End Sub
    Private Sub ReportView_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' HideTabs()
    End Sub
    Sub New()
        InitializeComponent()
        MainLauncher(0)
        Timer1.Stop()
        Me.RibbonTrackBar1.Value = 100
    End Sub
End Class
