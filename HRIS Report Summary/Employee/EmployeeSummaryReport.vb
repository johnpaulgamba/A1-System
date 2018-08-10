Imports MySql.Data.MySqlClient
Imports MySql.Data
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine


Public Class EmployeeSummaryReport

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
                    Dim crpt As New EmployeeSummaryPerCompany
                    With crpt
                        .SetDataSource(ds.Tables(0))
                        Me.CrystalReportViewer2.ReportSource = crpt
                        Me.CrystalReportViewer2.Refresh()
                    End With
                ElseIf c = 2 Then
                    Dim crpt As New EmployeeSummaryPerDepartment
                    With crpt
                        .SetDataSource(ds.Tables(0))
                        Me.CrystalReportViewer2.ReportSource = crpt
                        Me.CrystalReportViewer2.Refresh()
                    End With
                ElseIf c = 3 Then
                    Dim crpt As New EmployeeSummaryPerLocation
                    With crpt
                        .SetDataSource(ds.Tables(0))
                        Me.CrystalReportViewer2.ReportSource = crpt
                        Me.CrystalReportViewer2.Refresh()
                    End With
                ElseIf c = 4 Then
                    Dim crpt As New EmployeeSummaryPerPosition
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
            MessageBox.Show(ex.Message)
            'MessageBox.Show("Search not found!, Please try another search category")
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
        loadingvaluestoComboBoxes_StoredProc("combo_company_ActiveOnly", company, "companyname", "companyid")
        loadingvaluestoComboBoxes_StoredProc("combo_department_ActiveOnly", department, "department", "departmentid")
        loadingvaluestoComboBoxes_StoredProc("combo_location_ActiveOnly", locations, "location", "location")
        loadingvaluestoComboBoxes_StoredProc("combo_group_ActiveOnly", team, "groupname", "groupname")
        loadingvaluestoComboBoxes_StoredProc("combo_position_ActiveOnly", position, "positionname", "positionname")
        loadingvaluestoComboBoxes_StoredProc("combo_employmentlevel_ActiveOnly", employmentlevel, "employmentlevel", "employmentlevel")
        'loadingvaluestoComboBoxes_StoredProc("combo_employeetype_ActiveOnly", EmployeeType, "employeetype", "employeetype")
        loadingvaluestoComboBoxes_StoredProc("combo_employmentstatus_ActiveOnly", employmentstatus, "employmentstatus", "employmentstatus")
        AddHandler Me.company.SelectedIndexChanged, AddressOf cmbCust_SelectedIndexChanged
    End Sub
    Sub clear()
        company.Text = ""
        locations.Text = ""
        department.Text = ""
        position.Text = ""
        payrollgroup.Text = ""
        team.Text = ""
        Me.employmentlevel.Text = ""
        Me.employmentstatus.Text = ""
    End Sub
    Private Sub cmbCust_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        If DBNull.Value.Equals(Me.company.SelectedValue) Then Me.department.Text = Nothing : Exit Sub
        ' FunctionClass.loadingvaluestoComboBoxes("select CustomerID,CustomerName as CustomerName from customers Where  ParentID=" & Me.company.SelectedValue & "  Group by CustomerName Order By CustomerName", Me.department, "CustomerName", "CustomerID")
    End Sub

    Private Sub RefreshDropDownsCombo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Application.DoEvents()
        MainLauncher(0)
        LoadComboboxes()
        MainLauncher(1)
    End Sub
    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        Try

            MainLauncher(0)
            Dim s1 As String = company.Text
            Dim s2 As String = department.Text
            Dim s3 As String = locations.Text
            Dim s4 As String = position.Text
            Dim s5 As String = team.Text
            Dim s6 As String = payrollgroup.Text
            Dim s7 As String = employmentlevel.Text
            Dim s8 As String = employmentstatus.Text


            'Dim Startdate As Date = SDate.Value
            ''  Dim EndDate As Date = eDaate.Value
            If company.Text = "" Then s1 = "" Else s1 = " and companyname like '%" & company.Text & "%' "
            If department.Text = "" Then s2 = "" Else s2 = " and department like '%" & department.Text & "%' "
            If locations.Text = "" Then s3 = "" Else s3 = " and location like '%" & locations.Text & "%' "
            If position.Text = "" Then s4 = "" Else s4 = " and position like '%" & position.Text & "%' "
            If team.Text = "" Then s5 = "" Else s5 = " and team like '%" & team.Text & "%' "
            If payrollgroup.Text = "" Then s6 = "" Else s6 = " and payrollgroup like '%" & payrollgroup.Text & "%' "
            If employmentlevel.Text = "" Then s7 = "" Else s7 = " and employmentlevel like '%" & employmentlevel.Text & "%' "
            If employmentstatus.Text = "" Then s8 = "" Else s8 = " and employmentstatus like '%" & employmentstatus.Text & "%' "

            Dim filtersearchquery As String = s1 & s2 & s3 & s4 & s5 & s6 & s7 & s8
            MainLauncher(0)

            If rdoCompany.Checked = True Then
                With Me
                    .printReports("Reporting_Employee_Report", filtersearchquery, 1)
                End With
            ElseIf Me.rdodepartment.Checked = True Then
                With Me
                    .printReports("Reporting_Employee_Report", filtersearchquery, 2)
                End With
            ElseIf Me.rdolocation.Checked = True Then
                With Me
                    .printReports("Reporting_Employee_Report", filtersearchquery, 3)
                End With
            ElseIf Me.rdoposition.Checked = True Then
                With Me
                    .printReports("Reporting_Employee_Report", filtersearchquery, 4)
                End With
                '  Else If Me.rdolocation.Text=
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub cmdClear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        clear()
    End Sub
End Class
