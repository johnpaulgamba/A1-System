Imports MySql.Data.MySqlClient
Imports C1.Win.C1Command
Imports C1.Win.C1FlexGrid

Public Class Payroll_WitholdingTax
    Dim query1 As String = "SELECT * from Payroll_Group "
    Dim query2 As String = " PayrollGroup"
    Dim overallQuery As String = ""
    Private ds As DataSet = New DataSet
    Dim pagingAdapter As MySqlDataAdapter
    Dim pagingDS As DataSet
    Public scrollVal As Integer
    Dim totalRecords As Integer = 0
    Private NewStringCollec As New System.Collections.Specialized.StringCollection
    Public Sub loadallCommands(ByVal ClassName As String, ByVal StoredProc As String)
        Try
            connect()
            con.Open()
            Dim adapter As New MySqlDataAdapter
            Dim ds As New DataSet
            adapter = New MySqlDataAdapter(StoredProc, con)
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure
            adapter.SelectCommand.Parameters.AddWithValue("@ID", APCESMainForm.EmployeeID.Text)
            adapter.SelectCommand.Parameters.AddWithValue("@ClassName", ClassName)
            adapter.Fill(ds)
            con.Close()
            NewStringCollec.Clear()
            For Each row As DataRow In ds.Tables(0).Rows
                NewStringCollec.Add(row.Item("CommandName").ToString.ToLower)
            Next
            For Each x As C1Command In Me.C1CommandHolder1.Commands
                If x.Name.ToLower.Contains("c1contextmenu") Then
                    x.Enabled = True
                ElseIf x.Name.ToLower = "c1command1" Or x.Name.Contains("runcmd") Then
                    x.Enabled = True
                ElseIf NewStringCollec.Contains(x.Name.ToLower) Then
                    x.Enabled = True
                Else
                    x.Enabled = False : x.Visible = False
                End If
            Next
        Catch ex As Exception
            FunctionClass.showMessage(ex.Message, "Exception found", Application.ProductName.ToString)
        End Try
    End Sub
    Private Sub SOExportCurrent_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles SOExportCurrent.Click
        FunctionClass.ExportGrid(Me.DataGridView1)
    End Sub
    Private Sub readingAllInfo(ByVal a As String, ByVal b As Integer)
        Try
            command = New MySqlCommand
            connect()
            con.Open()
            With command
                .CommandText = a
                .Connection = con
                reader = .ExecuteReader
            End With
            If b = 1 Then
                If reader.Read = True Then
                    Dim PayGroupID As Integer = reader.Item("PayGroupID")
                    Dim PayrollGroup As String = reader.Item("PayrollGroup")
                    Dim x As New PayrollGroupRegistration
                    With x
                        .QuerytoString = overallQuery
                        .toSave = False
                        .EditLoad(PayGroupID)
                        .PayGroupID = PayGroupID
                        .Text = "Currently modifying : " & PayrollGroup
                        .StartPosition = FormStartPosition.CenterParent
                        .ShowDialog()
                    End With
                    con.Close()
                    command.Dispose()
                    reader.Close()
                End If
            ElseIf b = 2 Then
                If reader.Read = True Then
                    Dim PayGroupID As Integer = reader.Item("PayGroupID")
                    Dim PayrollGroup As String = reader.Item("PayrollGroup")
                    Dim x As New PayrollGroupRegistration
                    With x
                        .QuerytoString = overallQuery
                        .toSave = False
                        .PayGroupID = PayGroupID
                        .EditLoad(PayGroupID)
                        .Text = "Currently modifying : " & PayrollGroup
                        .toEnableAllControls(True)
                        .SaveRecord.Enabled = False
                        .StartPosition = FormStartPosition.CenterParent
                        .ShowDialog()
                    End With
                    con.Close()
                    command.Dispose()
                    reader.Close()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
#Region "Controls and Buttons"

#End Region
#Region "Page Navigations"
    Public Sub gotoFirst() Handles First.Click
        scrollVal = FunctionClass.gotoFirst(scrollVal, PreviousPage, NextPage, First, MoveToLast, pagingDS, totalRecords, PageNumber, pagingAdapter, DataGridView1, TextBox1, True) : FunctionClass.countrowsof(scrollVal, Me.DataGridView1)
    End Sub
    Public Sub PreviousPageClick() Handles PreviousPage.Click
        scrollVal = FunctionClass.PreviousPageClick(scrollVal, PreviousPage, NextPage, First, MoveToLast, pagingDS, totalRecords, PageNumber, pagingAdapter, DataGridView1, TextBox1, True) : FunctionClass.countrowsof(scrollVal, Me.DataGridView1)
    End Sub
    Public Sub NavigatePageType()
        scrollVal = FunctionClass.NavigatePageType(scrollVal, PreviousPage, NextPage, First, MoveToLast, pagingDS, totalRecords, PageNumber, pagingAdapter, DataGridView1, TextBox1, True) : FunctionClass.countrowsof(scrollVal, Me.DataGridView1)
    End Sub
    Public Sub LastPageClick() Handles MoveToLast.Click
        scrollVal = FunctionClass.LastPageClick(scrollVal, PreviousPage, NextPage, First, MoveToLast, pagingDS, totalRecords, PageNumber, pagingAdapter, DataGridView1, TextBox1, True) : FunctionClass.countrowsof(scrollVal, Me.DataGridView1)
    End Sub
    Public Sub NextPageClick() Handles NextPage.Click
        scrollVal = FunctionClass.NextPageClick(scrollVal, PreviousPage, NextPage, First, MoveToLast, pagingDS, totalRecords, PageNumber, pagingAdapter, DataGridView1, TextBox1, True) : FunctionClass.countrowsof(scrollVal, Me.DataGridView1)
    End Sub
    Public Sub countrow()
        scrollVal = FunctionClass.countrow(scrollVal, PreviousPage, NextPage, First, MoveToLast, pagingDS, totalRecords, PageNumber, pagingAdapter, DataGridView1, TextBox1, True) : FunctionClass.countrowsof(scrollVal, Me.DataGridView1)
    End Sub
    Private Sub PageNumber_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles PageNumber.KeyDown
        If e.KeyCode = Keys.Enter Then
            scrollVal = FunctionClass.NavigatePageType(scrollVal, PreviousPage, NextPage, First, MoveToLast, pagingDS, totalRecords, PageNumber, pagingAdapter, DataGridView1, TextBox1, True) : FunctionClass.countrowsof(scrollVal, Me.DataGridView1)
        End If
    End Sub
#End Region
    Public Sub New()
        InitializeComponent()
        DataGridView1.GetType.InvokeMember("DoubleBuffered", Reflection.BindingFlags.NonPublic Or Reflection.BindingFlags.Instance Or System.Reflection.BindingFlags.SetProperty, Nothing, DataGridView1, New Object() {True})
        Me.RibbonBar4.Font = New Font("Arial", 9, FontStyle.Bold)
        Me.RibbonBar4.Width = 360
        Me.LabelItem9.Text = "Page Navigation"
        Dim i As Integer = 0
        Dim j As Integer = ButtonItem4.SubItems.Count - 2
        C1Command1.CommandLinks.Clear()
        For i = 1 To j
            Dim x As String = ButtonItem4.SubItems(i).Text
            Dim y As Boolean = Convert.ToBoolean(CType(ButtonItem4.SubItems(i), DevComponents.DotNetBar.ButtonItem).Checked)
            Dim z As Boolean = Convert.ToBoolean(CType(ButtonItem4.SubItems(i), DevComponents.DotNetBar.ButtonItem).Enabled)
            Dim mWindow As C1Command = CType(C1CommandHolder1.CreateCommand(GetType(C1CommandMenu)), C1Command)
            mWindow.Text = x
            mWindow.CheckAutoToggle = True And z
            mWindow.Checked = y
            AddHandler mWindow.CheckedChanged, AddressOf a2_Click
            C1Command1.CommandLinks.Add(New C1CommandLink(mWindow))
        Next
        FunctionClass.GridStyle(Me.DataGridView1)
        Me.Timer1.Stop()
        LoadingForm()
    End Sub
    Private Sub a2_Click()
        FunctionClass.ColumnVisible(True, Me.DataGridView1, Me.ButtonItem4, Me.C1Command1)
    End Sub
    Private Sub DataGridView1_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGridView1.MouseClick
        FunctionClass.DataGridView1_MouseClick(sender, e, Me.DataGridView1, Me.C1ContextMenu1)
        If (e.Button = Windows.Forms.MouseButtons.Right) Then
            C1ContextMenu1.ShowContextMenu(DataGridView1, e.Location)
        End If
    End Sub
    Public Sub LoadingForm() Handles SOShowAll.Click, SoRefresh.Click

        Dim payrolldatequery As String = ""
        If Me.payrolldatefrom.Text = Nothing And Me.payrolldateto.Text = Nothing Then
            payrolldatequery = ""
        Else
            If Me.payrolldatefrom.Text <> Nothing Then
                If payrolldateto.Text <> Nothing Then
                    payrolldatequery = " and  date_format(y.payrolldate, '%Y/%m/%d')  between '" & Format(payrolldatefrom.Value, "yyyy/MM/dd") & "' and '" & Format(payrolldateto.Value, "yyyy/MM/dd") & "' "
                Else
                    payrolldatequery = " and  y.payrolldate >= '" & Format(payrolldatefrom.Value, "yyyy/MM/dd") & "' "
                End If
            Else
                If payrolldateto.Text <> Nothing Then
                    payrolldatequery = " and y.payrolldate<= '" & Format(payrolldateto.Value, "yyyy/MM/dd") & "' "
                Else
                    payrolldatequery = " and y.payrolldate like '%%' "
                End If
            End If
        End If

        'loadingPayrollGroups("Reporting_PayrollRegister_13thMonthPay", "", payrolldatequery)
    End Sub
    Public Sub loadingPayrollGroups(ByVal sql As String, ByVal searchquery As String, ByVal datequery As String)
        Try
            MainLauncher(Me.DataGridView1, 0)
            connect()
            con.Open()
            pagingAdapter = New MySqlDataAdapter(sql, con)
            pagingAdapter.SelectCommand.CommandType = CommandType.StoredProcedure
            pagingAdapter.SelectCommand.Parameters.AddWithValue("filterquery", searchquery)
            pagingAdapter.SelectCommand.Parameters.AddWithValue("datefrom", Format(payrolldatefrom.Value, "yyyy-MM-dd"))
            pagingAdapter.SelectCommand.Parameters.AddWithValue("dateto", Format(payrolldateto.Value, "yyyy-MM-dd"))
            If Me.PayrollGroup.Text = "" Then
                pagingAdapter.SelectCommand.Parameters.AddWithValue("payrollgroups", "")
            Else
                pagingAdapter.SelectCommand.Parameters.AddWithValue("payrollgroups", Me.PayrollGroup.Text)
            End If

            ds = New DataSet
            pagingAdapter.Fill(ds)
            pagingDS = New DataSet()
            pagingAdapter.Fill(pagingDS, scrollVal, MaximumToDisplay, "towns")

            con.Close()
            Me.DataGridView1.DataSource = pagingDS
            Me.DataGridView1.DataMember = "towns"
            totalRecords = ds.Tables(0).Rows.Count



            If totalRecords <= MaximumToDisplay Then
                Me.PreviousPage.Enabled = False
                Me.First.Enabled = False
                Me.MoveToLast.Enabled = False
                Me.NextPage.Enabled = False
            Else
                Me.PreviousPage.Enabled = False
                Me.First.Enabled = False
                Me.MoveToLast.Enabled = True
                Me.NextPage.Enabled = True
            End If
            Me.PageNumber.Text = "1"
            gotoFirst()
            If ds.Tables(0).Rows.Count <= MaximumToDisplay Then
                Me.NextPage.Enabled = False
                Me.MoveToLast.Enabled = False
            End If
            formatdatagrid()
            For i As Integer = 1 To DataGridView1.Rows.Count - 1
                With DataGridView1.Rows(i)
                    .Item(0) = i
                End With
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Me.NextPage.Enabled = False
            Me.MoveToLast.Enabled = False
            Me.First.Enabled = False
            Me.PreviousPage.Enabled = False
        Finally
            MainLauncher(Me.DataGridView1, 1)
        End Try
    End Sub
    Public Sub formatdatagrid()
        Dim start As New Timer
        With start
            .Interval = 1
            .Start()
        End With
        With Me.DataGridView1
            .AutoSizeCols()
            .AllowSorting = True
            .Rows(0).StyleDisplay.Font = New Font("Arial", Me.SliderZoomButton.Value + 1, FontStyle.Bold)
            ' .Item(0, 1) = "ID"
            .Cols("EmployeeID").Visible = False
            ' .Cols("ChangesMade").Visible = False
            '.AutoSizeCol(.Cols("Active").Index)
            ColumnVisible()
        End With
        start.Stop()
    End Sub
    Private Sub SliderZoomButton_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles SliderZoomButton.MouseLeave
        Timer1.Stop()
    End Sub
    Private Sub SliderZoomButton_valueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SliderZoomButton.ValueChanged
        Timer1.Start()
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        FunctionClass.TimerTick(Me.DataGridView1, SliderZoomButton)
    End Sub
    Private Function returnActiveInactive(ByVal a As Boolean, ByVal b As Boolean, ByVal c As Boolean)
        If a = False And b = False Then Return "" Else Return " AND ACTIVE=" & Convert.ToSingle(a)
    End Function
    Private Sub SearchRecords_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchRecords.Click
        Dim sortarrangement As String = ""
        Dim OrderbyOf As String = ""



        Dim payrolldatequery As String = ""
        If Me.payrolldatefrom.Text = Nothing And Me.payrolldateto.Text = Nothing Then
            payrolldatequery = ""
        Else
            If Me.payrolldatefrom.Text <> Nothing Then
                If payrolldateto.Text <> Nothing Then
                    payrolldatequery = " and  date_format(y.payrolldate, '%Y/%m/%d')  between '" & Format(payrolldatefrom.Value, "yyyy/MM/dd") & "' and '" & Format(payrolldateto.Value, "yyyy/MM/dd") & "' "
                Else
                    payrolldatequery = " and  y.payrolldate >= '" & Format(payrolldatefrom.Value, "yyyy/MM/dd") & "' "
                End If
            Else
                If payrolldateto.Text <> Nothing Then
                    payrolldatequery = " and y.payrolldate<= '" & Format(payrolldateto.Value, "yyyy/MM/dd") & "' "
                Else
                    payrolldatequery = " and y.payrolldate like '%%' "
                End If
            End If
        End If

        Dim s1 As String = companyname.Text
        Dim s2 As String = department.Text
        Dim s4 As String = employeename.Text

        If companyname.Text = "" Then s1 = "" Else s1 = " and z.companyid = '" & companyname.SelectedValue & "' "
        If department.Text = "" Then s2 = "" Else s2 = " and x.departmentid = '" & department.SelectedValue & "' "
        If employeename.Text = "" Then s4 = "" Else s4 = " and x.employeeid='" & employeename.SelectedValue & "' "
        Dim filtersearchquery As String = payrolldatequery & s1 & s2 & s4

        loadingPayrollGroups("Reporting_PayrollRegister_WitholdingTax", filtersearchquery, payrolldatequery)
        'If Asc.Checked = True Then sortarrangement = " ASC " Else sortarrangement = " DESC"
        ' OrderbyOf = Trim(Me.OrderBY.Text).Replace(" ", "")
        ' overallQuery = performSearchQuery(PayrollGroup.Text, Creator.Text, Description.Text, "", "", "", OrderbyOf, sortarrangement, returnActiveInactive(RecordsActive.Checked, RecordsInactive.Checked, RecordsBoth.Checked))
        'loadingPayrollGroups(overallQuery)
        ' FunctionClass.loadtoGrid_13Parameters("Reporting_PayrollRegister_13thMonthPay", "", DataGridView1)

    End Sub

    Private Function convertQuotes(ByVal a As String) As String
        Return MySqlHelper.EscapeString(a)
    End Function
    Private Sub ClearFields_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearFields.Click
        Me.companyname.SelectedIndex = -1
        Me.employeename.SelectedIndex = -1
        Me.department.SelectedIndex = -1

        Me.payrolldatefrom.Value = FirstDayOfMonth(Now)
        Me.payrolldateto.Value = LastDayOfMonth(Now)

        'Me.OrderBY.SelectedIndex = 0
        ' Me.Asc.Checked = True
    End Sub
    Private Sub ColumnVisible()
        FunctionClass.ColumnVisible(False, Me.DataGridView1, Me.ButtonItem4, Me.C1Command1)
    End Sub
    Private Sub a1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles a3.Click, _
        a4.Click, a8.Click, a10.Click, a5.Click, a6.Click
        ColumnVisible()
    End Sub
    Private Sub C1Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1Button1.Click
        Me.C1SplitterPanel6.Visible = Not Me.C1SplitterPanel6.Visible
        If Me.C1SplitterPanel6.Visible = True Then Me.C1Button1.BackgroundImage = My.Resources.left Else Me.C1Button1.BackgroundImage = My.Resources.right
    End Sub

    Private Sub Payroll_13MonthPay_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadingvaluestoComboBoxes_StoredProc("Combo_payrollgroup_Activeonly", Me.PayrollGroup, "payrollgroup", "payrollgroup")
        loadingvaluestoComboBoxes_StoredProc("Combo_Employees_Activeonly", Me.employeename, "Employee", "EmployeeID")
        loadingvaluestoComboBoxes_StoredProc("combo_company_ActiveOnly", companyname, "companyname", "companyid")
        loadingvaluestoComboBoxes_StoredProc("combo_department_ActiveOnly", department, "department", "departmentid")
        Me.payrolldatefrom.Value = fiscalyyearfrom(Now)
        Me.payrolldateto.Value = fiscalyearto(Now)
    End Sub
End Class
