Imports MySql.Data.MySqlClient
Imports MySql.Data
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Public Class Payroll_HDMF_LoanPayment

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
    Private Sub PrintReportButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintReportButton.Click

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
    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        Try
            If Me.company.Text = "" Then showMessage("Please select company and try again.", "No company selected.", "Select company and try again", 3) : Exit Sub
            ' If Me.payrollgroup.Text = "" Then showMessage("Please select payroll group and try again.", "No payroll group selected.", "Select payroll group and try again", 3) : Exit Sub
            MainLauncher(0)

            Dim s1 As String = company.Text
            Dim s3 As String = payrollgroup.Text
            Dim s4 As String = EmployeeName.Text

            Dim payrolldatequery As String = ""
            If Me.payrolldatefrom.Text = Nothing And Me.payrolldateto.Text = Nothing Then
                payrolldatequery = ""
            Else
                If Me.payrolldatefrom.Text <> Nothing Then
                    If payrolldateto.Text <> Nothing Then
                        payrolldatequery = " and  date_format(d.payrolldate, '%Y/%m/%d')  between '" & Format(payrolldatefrom.Value, "yyyy/MM/dd") & "' and '" & Format(payrolldateto.Value, "yyyy/MM/dd") & "' "
                    Else
                        payrolldatequery = " and  d.payrolldate >= '" & Format(payrolldatefrom.Value, "yyyy/MM/dd") & "' "
                    End If
                Else
                    If payrolldateto.Text <> Nothing Then
                        payrolldatequery = " and d.payrolldate<= '" & Format(payrolldateto.Value, "yyyy/MM/dd") & "' "
                    Else
                        payrolldatequery = " and d.payrolldate like '%%' "
                    End If
                End If
            End If


            'Dim Startdate As Date = SDate.Value
            ''  Dim EndDate As Date = eDaate.Value
            If company.Text = "" Then
                s1 = ""
            Else
                If company.SelectedValue = 2 Or company.SelectedValue = 6 Then
                    s1 = " and c.companyid in (6,2) "
                Else

                    s1 = " and c.companyid = '" & company.SelectedValue & "' "
                End If

            End If
            If EmployeeName.Text = "" Then s4 = "" Else s4 = " and c.employeeid='" & EmployeeName.SelectedValue & "' "


            Dim filtersearchquery As String = ""

            If Me.monthly.Checked = True Then
                If Me.payrollgroup.Text = "" Then MessageBox.Show("Selected month is not valid!, Please select month and try again") : Exit Sub
                ' filtersearchquery = " and date_format(d.payrolldate,'%m-%Y') = " & Format(payrollgroup.SelectedValue, "MM-yyyy") & s1
                filtersearchquery = " and  date_format(d.payrolldate, '%Y/%m/%d')  between '" & Format(FirstDayOfMonth(payrollgroup.SelectedValue), "yyyy/MM/dd") & "' and '" & Format(LastDayOfMonth(payrollgroup.SelectedValue), "yyyy/MM/dd") & "' " & s1
                printReports("Reporting_HDMF_Loan", filtersearchquery, 1)
            ElseIf Me.individual.Checked = True Then
                If Me.EmployeeName.Text = "" Then MessageBox.Show("Selected employee is not valid!, Please select employee and try again") : Exit Sub
                filtersearchquery = payrolldatequery & s1 & s4
                printReports("Reporting_HDMF_Loan", filtersearchquery, 2)
            End If
            MainLauncher(0)

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
            End With
            Dim da As New MySqlDataAdapter
            Dim ds As New DataSet
            da.SelectCommand = command
            da.SelectCommand.CommandTimeout = 10000
            da.Fill(ds)
            con.Close()
            command.Dispose()
            If ds.Tables(0).Rows.Count <= 0 Then
                MessageBox.Show("Search not found!, Please try another search category")
            Else
                If c = 1 Then
                    Dim crpt As New Reporting_HDMFLoan_Monthly
                    With crpt
                        .SetDataSource(ds.Tables(0))
                        Me.CrystalReportViewer2.ReportSource = crpt
                        Me.CrystalReportViewer2.Refresh()
                    End With
                ElseIf c = 2 Then
                    Dim crpt As New Reporting_HDMFLoan_Individual
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
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
            MessageBox.Show("Search not found!, Please try another search category")
        End Try
    End Sub
    Dim CommandText As String
    Dim Count As Integer = 0
    Dim DisplayMem As String
    Dim ComboboxName As String

    Private Sub SalesReportFilter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadComboboxes()
        Me.company.SelectedValue = companyid
        ' Me.SDate.Value = Now
        ' Me.eDaate.Value = Now
        MainLauncher(0)
    End Sub
    Sub LoadComboboxes()
        RemoveHandler Me.company.SelectedIndexChanged, AddressOf cmbCust_SelectedIndexChanged
        loadingvaluestoComboBoxes_StoredProc("Combo_Employees_Activeonly", Me.EmployeeName, "Employee", "EmployeeID")
        loadingvaluestoComboBoxes_StoredProc("combo_company_ActiveOnly", company, "companyname", "companyid")
        loadingvaluestoComboBoxes_StoredProc("combo_payrollmonth_ActiveOnly", payrollgroup, "payrollmonth", "payrolldate")
        'loadingvaluestoComboBoxes_StoredProc("combo_employeetype_ActiveOnly", EmployeeType, "employeetype", "employeetype")
        AddHandler Me.company.SelectedIndexChanged, AddressOf cmbCust_SelectedIndexChanged
        Me.payrolldatefrom.Value = fiscalyyearfrom(Now)
        Me.payrolldateto.Value = fiscalyearto(Now)

    End Sub
    Sub clear()
        company.Text = ""
        payrollgroup.Text = ""
        Me.company.SelectedValue = companyid
        Me.payrolldatefrom.Value = fiscalyyearfrom(Now)
        Me.payrolldateto.Value = fiscalyearto(Now)
    End Sub
    Private Sub cmbCust_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        ' FunctionClass.loadingvaluestoComboBoxes("select CustomerID,CustomerName as CustomerName from customers Where  ParentID=" & Me.company.SelectedValue & "  Group by CustomerName Order By CustomerName", Me.department, "CustomerName", "CustomerID")
    End Sub

    Private Sub RefreshDropDownsCombo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Application.DoEvents()
        MainLauncher(0)
        LoadComboboxes()
        MainLauncher(1)
    End Sub


    Private Sub cmdClear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        clear()
    End Sub
End Class
