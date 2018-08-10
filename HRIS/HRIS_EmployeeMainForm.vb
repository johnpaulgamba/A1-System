Imports MySql.Data.MySqlClient
Imports C1.Win.C1Command
Imports C1.Win.C1FlexGrid
Imports System.IO
Public Class EmployeeMainForm

    Dim query1 As String = " Select a.EmployeeID, " & _
        " Concat('', a.EmployeeNo) as ID,  " & _
        " a.LastName, a.FirstName, a.MiddleName, a.Active,date_format(a.Dateofbirth, '%m/%d/%Y') as 'BirthDay',floor(datediff(now(), a.dateofbirth)/365) as Age , A.CivilStatus, " & _
        " a.EmploymentLevel as Level,a.EmployeeType as Type, a.EmploymentStatus as Status," & _
        " Department, a.Position, a.Location,date_format(a.DateHired, '%m/%d/%Y') as 'DateHired', floor(datediff(now(), a.datehired)/365) as Years," & _
        "(case when a.PayRateType='DAILY' or a.PayRateType='WEEKLY'  then concat(format(a.BasicPayDaily,2), ' /Day') else concat(format(a.BasicPayMonth,2), ' /Month')  end) as Salary, " & _
        "a.SSS,a.PHIC,a.HDMF, a.Address, a.Creator From hris_employee a " & _
        " JOIN departments b On a.DepartmentID=b.DepartmentID " & _
           " WHERE a.DepartmentID=b.DepartmentID "

    Dim query2 As String = " Employee  "
    Dim QUERY3 As String = " GROUP BY a.EmployeeID "
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
                    x.Enabled = False
                End If
            Next
        Catch ex As Exception
            FunctionClass.showMessage(ex.Message, "Exception found", Application.ProductName.ToString)
        End Try
    End Sub
    Private Sub ClearFields_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearFields.Click
        FunctionClass.ClearPanel(Me.BasicSearchOption)
    End Sub

#Region "Controls and Commands"
    Private Sub Register_Click() Handles SOAddMenu.Click
        Dim x As New HRIS_EmployeeInformation(0)
        With x
            .StartPosition = FormStartPosition.CenterScreen
            .ShowDialog()
        End With
    End Sub
    Private Sub ViewItemHistory_Click() Handles SOViewRecord.Click
        Try
            Dim i As Integer = Me.DataGridView1.RowSel
            Dim x As New HistoryUpdate
            With x
                .loaddata("hris_employee", "EmployeeID", Me.DataGridView1.Rows(i).Item("EmployeeID"))
                .Text = "Item history of " & Me.DataGridView1.Item(i, "Reference")
                .StartPosition = FormStartPosition.CenterParent
                .ShowDialog()
            End With
        Catch ex As Exception
            MessageBox.Show("No record selected")
        End Try
    End Sub
    Private Sub DataGridView1_CellDoubleClick() Handles DataGridView1.DoubleClick
        Try
            If Me.DataGridView1.RowSel = 0 Then Exit Sub
            Dim i As Integer = Me.DataGridView1.Rows(Me.DataGridView1.RowSel).Item("EmployeeID")
            Dim x As New HRIS_EmployeeInformation(i)
            With x
                .StartPosition = FormStartPosition.CenterParent
                .ShowDialog()
            End With

        Catch ex As Exception
            MessageBox.Show("No record selected")
        End Try
    End Sub
    Public Sub Refresh_Click() Handles SoRefresh.Click, ReloadAllRecords.Click
        LoadingItemBrands(overallQuery)
    End Sub

    Private Sub DataGridView1_RowColChange(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RangeEventArgs)
        MainLauncher(0)
        ShowItems()
        MainLauncher(1)
        Dim x As New HistoryUpdate
    End Sub
    Private Sub ShowItems()
        Try
            Dim id As Integer = 0
            Try
                Me.DataGridView1.Rows(1).Selected = False
                id = Me.DataGridView1.Rows(Me.DataGridView1.RowSel).Item("EmployeeID")
            Catch ex As Exception
                id = 0
            End Try
            FunctionClass.loadtoGrid3("HRIS_GRID_hris_employee_dependents", id, Me.DependentGrid)
            FunctionClass.loadtoGrid3("HRIS_GRID_hris_employee_education", id, Me.EducationGrid)
            FunctionClass.loadtoGrid3("HRIS_GRID_hris_employee_employment", id, Me.EmploymentGrid)
            FunctionClass.loadtoGrid3("HRIS_GRID_hris_employee_addresses", id, Me.ResidenceGrid)
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub DataGridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridView1.KeyDown
        If e.Modifiers = Keys.Control Then
            If e.KeyCode = Keys.Right Then
                Me.NextPageClick()
            ElseIf e.KeyCode = Keys.Left Then
                Me.PreviousPageClick()
            End If
        ElseIf e.KeyCode = Keys.Home Then
            gotoFirst()
        ElseIf e.KeyCode = Keys.End Then
            Me.LastPageClick()
        End If
    End Sub
#End Region
#Region "Page Navigations"
    Public Sub gotoFirst() Handles First.Click
        Me.DataGridView1.Redraw = False
        RemoveHandler Me.DataGridView1.AfterSelChange, AddressOf DataGridView1_RowColChange
        scrollVal = FunctionClass.gotoFirst(scrollVal, PreviousPage, NextPage, First, MoveToLast, pagingDS, totalRecords, PageNumber, pagingAdapter, DataGridView1, TextBox1, True) : FunctionClass.countrowsof5(scrollVal, Me.DataGridView1)
        AddHandling()
    End Sub
    Private Sub AddHandling()
        Try

            AddHandler Me.DataGridView1.AfterSelChange, AddressOf DataGridView1_RowColChange
            Me.DataGridView1.Rows(1).Selected = True
            Me.DataGridView1.Redraw = True
        Catch ex As Exception
        End Try
    End Sub
    Public Sub PreviousPageClick() Handles PreviousPage.Click
        Me.DataGridView1.Redraw = False
        RemoveHandler Me.DataGridView1.AfterSelChange, AddressOf DataGridView1_RowColChange
        scrollVal = FunctionClass.PreviousPageClick(scrollVal, PreviousPage, NextPage, First, MoveToLast, pagingDS, totalRecords, PageNumber, pagingAdapter, DataGridView1, TextBox1, True) : FunctionClass.countrowsof5(scrollVal, Me.DataGridView1)
        AddHandling()
    End Sub
    Public Sub LastPageClick() Handles MoveToLast.Click
        Me.DataGridView1.Redraw = False
        RemoveHandler Me.DataGridView1.AfterSelChange, AddressOf DataGridView1_RowColChange
        scrollVal = FunctionClass.LastPageClick(scrollVal, PreviousPage, NextPage, First, MoveToLast, pagingDS, totalRecords, PageNumber, pagingAdapter, DataGridView1, TextBox1, True) : FunctionClass.countrowsof5(scrollVal, Me.DataGridView1)
        AddHandling()
    End Sub
    Public Sub NextPageClick() Handles NextPage.Click
        Me.DataGridView1.Redraw = False
        RemoveHandler Me.DataGridView1.AfterSelChange, AddressOf DataGridView1_RowColChange
        scrollVal = FunctionClass.NextPageClick(scrollVal, PreviousPage, NextPage, First, MoveToLast, pagingDS, totalRecords, PageNumber, pagingAdapter, DataGridView1, TextBox1, True) : FunctionClass.countrowsof5(scrollVal, Me.DataGridView1)
        AddHandling()
    End Sub
    Public Sub countrow()
        scrollVal = FunctionClass.countrow(scrollVal, PreviousPage, NextPage, First, MoveToLast, pagingDS, totalRecords, PageNumber, pagingAdapter, DataGridView1, TextBox1, True) : FunctionClass.countrowsof5(scrollVal, Me.DataGridView1)
    End Sub
    Private Sub PageNumber_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles PageNumber.KeyDown
        If e.KeyCode = Keys.Enter Then
            scrollVal = FunctionClass.NavigatePageType(scrollVal, PreviousPage, NextPage, First, MoveToLast, pagingDS, totalRecords, PageNumber, pagingAdapter, DataGridView1, TextBox1, True) : FunctionClass.countrowsof5(scrollVal, Me.DataGridView1)
        End If
    End Sub
#End Region
    Sub New()
        InitializeComponent()

        loadingvaluestoComboBoxes_StoredProc("combo_department_ActiveOnly", Department, "department", "departmentid")
        loadingvaluestoComboBoxes_StoredProc("combo_location_ActiveOnly", Location, "location", "location")
        loadingvaluestoComboBoxes_StoredProc("combo_position_ActiveOnly", Position, "positionname", "positionname")
        loadingvaluestoComboBoxes_StoredProc("combo_civilstatus_ActiveOnly", CivilStatus, "civilstatus", "civilstatus")
        loadingvaluestoComboBoxes_StoredProc("combo_gender_ActiveOnly", Gender, "gender", "gender")
        loadingvaluestoComboBoxes_StoredProc("combo_employmentlevel_ActiveOnly", EmploymentLevel, "employmentlevel", "employmentlevel")
        loadingvaluestoComboBoxes_StoredProc("combo_employeetype_ActiveOnly", EmployeeType, "employeetype", "employeetype")
        loadingvaluestoComboBoxes_StoredProc("combo_gender_ActiveOnly", Gender, "gender", "gender")
        loadingvaluestoComboBoxes_StoredProc("combo_employmentstatus_ActiveOnly", EmploymentStatus, "employmentstatus", "employmentstatus")
        loadingvaluestoComboBoxes_StoredProc("combo_payrollgroup_ActiveOnly", PayrollGroup, "payrollgroup", "payrollgroup")
        loadingvaluestoComboBoxes_StoredProc("combo_employeesLevelA_ActiveOnly", ImmediateSuperior, "Employee", "EmployeeID")
        loadingvaluestoComboBoxes("Select * from company where companyid<>0 ", CompanyName, "CompanyName", "CompanyID")

        DataGridView1.GetType.InvokeMember("DoubleBuffered", Reflection.BindingFlags.NonPublic Or Reflection.BindingFlags.Instance Or System.Reflection.BindingFlags.SetProperty, Nothing, DataGridView1, New Object() {True})
        Dim i As Integer = 0
        Dim j As Integer = ButtonItem4.SubItems.Count - 2
        C1Command1.CommandLinks.Clear()
        For i = 1 To j
            Dim x As String = ButtonItem4.SubItems(i).Text
            Dim y As Boolean = Convert.ToBoolean(CType(ButtonItem4.SubItems(i), DevComponents.DotNetBar.ButtonItem).Checked)
            Dim z As Boolean = Convert.ToBoolean(CType(ButtonItem4.SubItems(i), DevComponents.DotNetBar.ButtonItem).Enabled)
            Dim z1 As New C1.Win.C1InputPanel.InputOption
            z1.Text = x

            Dim mWindow As C1Command = CType(C1CommandHolder1.CreateCommand(GetType(C1CommandMenu)), C1Command)
            mWindow.Text = x
            mWindow.CheckAutoToggle = True And z
            mWindow.Checked = y
            AddHandler mWindow.CheckedChanged, AddressOf a2_Click
            C1Command1.CommandLinks.Add(New C1CommandLink(mWindow))
        Next
        FunctionClass.GridStyle(Me.DataGridView1)
        FunctionClass.GridStyle(Me.DependentGrid)
        FunctionClass.GridStyle(Me.EducationGrid)
        FunctionClass.GridStyle(Me.EmploymentGrid)
        FunctionClass.GridStyle(Me.ResidenceGrid)
        AddHandler Me.DataGridView1.AfterSelChange, AddressOf DataGridView1_RowColChange
        Me.Timer1.Stop()
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
    Public Sub LoadingForm() Handles SOShowAll.Click
        overallQuery = query1 & QUERY3 & "ORDER BY " & query2
        LoadingItemBrands(overallQuery)
    End Sub
    Public Sub LoadingItemBrands(ByVal sql As String)
        Try
            FunctionClass.LoadingItemBrands(sql, Me.DataGridView1, Me.NextPage, Me.MoveToLast, Me.First, Me.PreviousPage, Me.PageNumber, Me.TextBox1, Me.LabelItem9)
            formatdatagrid()
        Catch ex As Exception
        Finally
        End Try
    End Sub
    Private Sub SliderZoomButton_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles SliderZoomButton.MouseLeave
        Timer1.Stop()
    End Sub
    Private Sub SliderZoomButton_valueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SliderZoomButton.ValueChanged
        Timer1.Start()
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        timertick()
    End Sub
    Public Sub timertick()
        MainLauncher(0) : FunctionClass.TimerTick(Me.DataGridView1, Me.SliderZoomButton)
        FunctionClass.TimerTick(Me.DependentGrid, Me.SliderZoomButton)
        FunctionClass.TimerTick(Me.EducationGrid, Me.SliderZoomButton)
        FunctionClass.TimerTick(Me.EmploymentGrid, Me.SliderZoomButton)
        FunctionClass.TimerTick(Me.ResidenceGrid, Me.SliderZoomButton)

        Timer1.Stop() : MainLauncher(1)
    End Sub
    Public Sub formatdatagrid()
        With Me.DataGridView1
            .AutoSizeCols()
            .Rows(0).StyleDisplay.Font = New Font("Arial", Me.SliderZoomButton.Value + 1, FontStyle.Bold)
            .Cols("EmployeeID").Visible = False
            .Cols("Years").TextAlign = TextAlignEnum.CenterCenter
            .Cols("Age").TextAlign = TextAlignEnum.CenterCenter
            .AllowSorting = True
            .AllowFiltering = True
            .AllowResizing = True
            .AutoSizeCols()
            'ColumnVisible()
        End With
    End Sub
    Private Sub ColumnVisible()
        FunctionClass.ColumnVisible(False, Me.DataGridView1, Me.ButtonItem4, Me.C1Command1)
    End Sub
    Private Sub a1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ColumnVisible()
    End Sub
    Private Sub SearchRecords_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchRecords.Click
        Dim sortarrangement As String = ""
        overallQuery = performSearchQuery(sortarrangement)
        LoadingItemBrands(overallQuery)
    End Sub
    Private Function performSearchQuery(ByVal sortarrangement As String) As String
        Dim DateHiredQuery As String = ""
        Dim birthdatequery As String = ""
        If Me.DateHiredFrom.Text = Nothing And Me.DateHiredTo.Text = Nothing Then
            DateHiredQuery = ""
        Else
            If Me.DateHiredFrom.Text <> Nothing Then
                If DateHiredTo.Text <> Nothing Then
                    DateHiredQuery = " AND Date_Format(a.DateHired, '%Y/%m/%d')  between '" & Format(DateHiredFrom.Value, "yyyy/MM/dd") & "' and '" & Format(DateHiredTo.Value, "yyyy/MM/dd") & "' "
                Else
                    DateHiredQuery = " AND a.DateHired >= '" & Format(DateHiredFrom.Value, "yyyy/MM/dd") & "' "
                End If
            Else
                If DateHiredTo.Text <> Nothing Then
                    DateHiredQuery = " AND a.DateHired <= '" & Format(DateHiredTo.Value, "yyyy/MM/dd") & "' "
                Else
                    DateHiredQuery = " AND a.DateHired LIKE '%%' "
                End If
            End If
        End If

        If Me.bdayfrom.Text = Nothing And Me.bdayto.Text = Nothing Then
            birthdatequery = ""
        Else
            If Me.bdayfrom.Text <> Nothing Then
                If bdayto.Text <> Nothing Then
                    birthdatequery = " AND Date_Format(a.dateofbirth, '%m/%d')  between '" & Format(bdayfrom.Value, "MM/dd") & "' and '" & Format(bdayto.Value, "MM/dd") & "' "
                Else
                    birthdatequery = " AND a.dateofbirth >= '" & Format(bdayfrom.Value, "MM/dd") & "' "
                End If
            Else
                If bdayto.Text <> Nothing Then
                    birthdatequery = " AND a.dateofbirth <= '" & Format(bdayto.Value, "MM/dd") & "' "
                Else
                    birthdatequery = " AND a.dateofbirth LIKE '%%' "
                End If
            End If
        End If

        Dim isCancelled As String = ""
        Dim isForwarded As String = ""
        Dim isPosted As String = ""
        If Me.ActiveBoth.Checked = True Then isPosted = "" Else isPosted = " AND a.Active=" & Convert.ToSingle(Me.ActiveYes.Checked)
        Dim departments As String = ""
        Dim firstnamex As String = ""
        Dim lastnamex As String = ""
        Dim company As String = " and companyid like '%" & CompanyName.SelectedValue & "%'"
        If Department.Text = "" Then departments = "" Else departments = " AND a.departmentid  = '" & Department.SelectedValue & "' "
        If firstname.Text <> "" Then firstnamex = " and a.firstname like '%" & firstname.Text & "%'"
        If LastName.Text <> "" Then lastnamex = " and a.lastname like '%" & LastName.Text & "'"
        Dim Positions As String = " AND a.Position like '%" & convertQuotes(Me.Position.Text) & "%' "
        Dim Superior As String = " AND a.ImmediateSuperior LIKE '%" & convertQuotes(Me.ImmediateSuperior.Text) & "%'"
        Dim Location As String = " AND a.Location like '%" & convertQuotes(Me.Location.Text) & "%'"
        Dim payrollgroup As String = ""
        If Me.PayrollGroup.Text = "" Then payrollgroup = "" Else payrollgroup = " AND a.payrollgroup = '" & convertQuotes(Me.PayrollGroup.Text) & "'"
        Dim civilstatus As String = " AND a.civilstatus LIKE '%" & convertQuotes(Me.CivilStatus.Text) & "%'"
        Dim gender As String = " and a.gender like '%" & convertQuotes(Me.Gender.Text) & "%'"
        Dim EmploymentLevel As String = " AND a.EmploymentLevel LIKE '%" & convertQuotes(Me.EmploymentLevel.Text) & "%'"
        Dim EmployeeType As String = " AND a.EmployeeType LIKE '%" & convertQuotes(Me.EmployeeType.Text) & "%'"
        Dim EmploymentStatus As String = " AND a.EmploymentStatus LIKE '%" & convertQuotes(Me.EmploymentStatus.Text) & "%'"

        Dim Order As String = " ASC"
        Return query1 & DateHiredQuery & firstnamex & lastnamex & _
            departments & isPosted & Superior & Location & payrollgroup & civilstatus & gender & Positions & company & _
            EmploymentLevel & EmployeeType & EmploymentStatus & isCancelled & isForwarded & isPosted & birthdatequery & _
            QUERY3
    End Function
    Private Function convertQuotes(ByVal a As String) As String
        Return MySqlHelper.EscapeString(a)
    End Function
    Private Function returnActiveInactive(ByVal a As Boolean, ByVal b As Boolean, ByVal c As Boolean)
        If a = False And b = False Then Return "" Else Return " AND ACTIVE=" & Convert.ToSingle(a)
    End Function
    Private Sub C1Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1Button1.Click
        Me.C1SplitterPanel2.Visible = Not Me.C1SplitterPanel2.Visible
        If Me.C1SplitterPanel2.Visible = True Then Me.C1Button1.BackgroundImage = My.Resources.left Else Me.C1Button1.BackgroundImage = My.Resources.right
    End Sub
    Private Sub C1Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1Button2.Click
        Me.C1SplitterPanel1.Visible = Not Me.C1SplitterPanel1.Visible
        If Me.C1SplitterPanel1.Visible = True Then Me.C1Button2.BackgroundImage = My.Resources.download Else Me.C1Button2.BackgroundImage = My.Resources.upload
    End Sub
    Private Sub SOExportCurrent_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles SOExportCurrent.Click
        FunctionClass.ExportGrid(Me.DataGridView1)
    End Sub
    Private Sub DeliveryReceiptsMainForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.SearchRecords_Click(sender, e)
    End Sub
    Private Sub EditCommand_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles EditCommand.Click
        Try
            If Me.DataGridView1.RowSel = 0 Then Exit Sub
            Dim i As Integer = Me.DataGridView1.Rows(Me.DataGridView1.RowSel).Item("EmployeeID")
            Dim x As New HRIS_EmployeeInformation(i)
            With x
                .StartPosition = FormStartPosition.CenterParent
                .ShowDialog()
            End With
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
            'MessageBox.Show("No record selected", "Select record", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
    End Sub

End Class
