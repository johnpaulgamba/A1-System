Imports MySql.Data.MySqlClient
Imports C1.Win.C1Command
Imports C1.Win.C1FlexGrid
Imports System.IO
Public Class HRIS_Employee_RequirementsMainForm

    Dim query1 As String = " Select Concat(a.EmployeeID) as EmployeeID,  " & _
        " Concat(LastName, ', ', FirstName, ' ', MiddleName) as Employee, " & _
         " date_format(a.DateHired, '%m/%d/%Y') as 'DateHired', a.EmployeeType as Status," & _
        " Department, a.Position, a.Location,a.GroupName, a.Active, " & _
        " a.Creator From hris_employee a " & _
        " JOIN departments b On a.DepartmentID=b.DepartmentID " & _
           " WHERE a.DepartmentID=b.DepartmentID  "
    Dim query2 As String = " Employee "
    Dim QUERY3 As String = " GROUP BY  a.Employeeid "
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
        Dim x As New HRIS_EmployeeRegistration_Requirement(0)
        With x
            .StartPosition = FormStartPosition.CenterScreen
            .ShowDialog()
        End With
    End Sub
    Private Sub ViewItemHistory_Click() Handles SOViewRecord.Click
        Try
            Dim i As Integer = Me.DataGridView1.RowSel
            Dim ID As Integer = Me.DataGridView1.Rows(i).Item("Employeeid")
            Dim x As New HRIS_EmployeeRegistration_Requirement(ID)
            With x
                ' .loaddata("HRIS_Requirements", "RequirementID", ID)
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

    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        Try
            Dim i As Integer = Me.DataGridView1.RowSel
            Dim ID As Integer = Me.DataGridView1.Rows(i).Item("Employeeid")
            Dim x As New HRIS_EmployeeRegistration_Requirement(ID)
            With x
                ' .loaddata("HRIS_Requirements", "RequirementID", ID)
                .StartPosition = FormStartPosition.CenterParent
                .ShowDialog()
            End With
        Catch ex As Exception
            MessageBox.Show("No record selected")
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
        'RemoveHandler Me.DataGridView1.AfterSelChange, AddressOf DataGridView1_RowColChange
        scrollVal = FunctionClass.gotoFirst(scrollVal, PreviousPage, NextPage, First, MoveToLast, pagingDS, totalRecords, PageNumber, pagingAdapter, DataGridView1, TextBox1, True) : FunctionClass.countrowsof5(scrollVal, Me.DataGridView1)
        AddHandling()
    End Sub
    Private Sub AddHandling()
        Try
            Me.DataGridView1.Rows(1).Selected = True
            Me.DataGridView1.Redraw = True
        Catch ex As Exception
        End Try
    End Sub
    Public Sub PreviousPageClick() Handles PreviousPage.Click
        Me.DataGridView1.Redraw = False
        'RemoveHandler Me.DataGridView1.AfterSelChange, AddressOf DataGridView1_RowColChange
        scrollVal = FunctionClass.PreviousPageClick(scrollVal, PreviousPage, NextPage, First, MoveToLast, pagingDS, totalRecords, PageNumber, pagingAdapter, DataGridView1, TextBox1, True) : FunctionClass.countrowsof5(scrollVal, Me.DataGridView1)
        AddHandling()
    End Sub
    Public Sub LastPageClick() Handles MoveToLast.Click
        Me.DataGridView1.Redraw = False
        'RemoveHandler Me.DataGridView1.AfterSelChange, AddressOf DataGridView1_RowColChange
        scrollVal = FunctionClass.LastPageClick(scrollVal, PreviousPage, NextPage, First, MoveToLast, pagingDS, totalRecords, PageNumber, pagingAdapter, DataGridView1, TextBox1, True) : FunctionClass.countrowsof5(scrollVal, Me.DataGridView1)
        AddHandling()
    End Sub
    Public Sub NextPageClick() Handles NextPage.Click
        Me.DataGridView1.Redraw = False
        'RemoveHandler Me.DataGridView1.AfterSelChange, AddressOf DataGridView1_RowColChange
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
        FunctionClass.LoadingItemBrands(sql, Me.DataGridView1, Me.NextPage, Me.MoveToLast, Me.First, Me.PreviousPage, Me.PageNumber, Me.TextBox1, Me.LabelItem9)
        formatdatagrid()
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
        Timer1.Stop() : MainLauncher(1)
    End Sub
    Public Sub formatdatagrid()
        With Me.DataGridView1
            .AutoSizeCols()
            .AllowSorting = True
            .Rows(0).StyleDisplay.Font = New Font("Arial", Me.SliderZoomButton.Value + 1, FontStyle.Bold)
            .Cols("EmployeeID").Visible = False
            ColumnVisible()
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
        If Me.DateHiredFrom.Text = Nothing And Me.DateHiredTo.Text = Nothing Then
            DateHiredQuery = ""
        Else
            If Me.DateHiredFrom.Text <> Nothing Then
                If DateHiredTo.Text <> Nothing Then
                    DateHiredQuery = " AND Date_Format(b.DateHired, '%Y/%m/%d')  between '" & Format(DateHiredFrom.Value, "yyyy/MM/dd") & "' and '" & Format(DateHiredTo.Value, "yyyy/MM/dd") & "' "
                Else
                    DateHiredQuery = " AND b.DateHired >= '" & Format(DateHiredFrom.Value, "yyyy/MM/dd") & "' "
                End If
            Else
                If DateHiredTo.Text <> Nothing Then
                    DateHiredQuery = " AND b.DateHired <= '" & Format(DateHiredTo.Value, "yyyy/MM/dd") & "' "
                Else
                    DateHiredQuery = " AND b.DateHired LIKE '%%' "
                End If
            End If
        End If


        Dim isCancelled As String = ""
        Dim isForwarded As String = ""
        Dim isPosted As String = ""
        If Me.ActiveBoth.Checked = True Then isPosted = "" Else isPosted = " AND a.Active=" & Convert.ToSingle(Me.ActiveYes.Checked)
        Dim DRNo As String = " AND MiddleName LIKE '%" & convertQuotes(Me.MiddleName.Text) & "%'"
        Dim CancelBy As String = " AND LastName LIKE '%" & convertQuotes(Me.LastName.Text) & "%'"
        Dim ConfirmBy As String = " AND FirstName LIKE '%" & convertQuotes(Me.FirstName.Text) & "%'"
        Dim Order As String = " ASC"
        Return query1 & DRNo & CancelBy & _
          isPosted & _
            ConfirmBy & isCancelled & isForwarded & isPosted & _
            QUERY3 & " ORDER BY a.Employeeid " & Order
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

    Private Sub SOExportCurrent_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles SOExportCurrent.Click
        FunctionClass.ExportGrid(Me.DataGridView1)
    End Sub
    Private Sub DeliveryReceiptsMainForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.SearchRecords_Click(sender, e)
    End Sub
    Private Sub EditCommand_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles EditCommand.Click
        Try
            If Me.DataGridView1.RowSel = 0 Then Exit Sub
            Dim i As Integer = Me.DataGridView1.Rows(Me.DataGridView1.RowSel).Item("employeeid")
            Dim x As New HRIS_EmployeeRegistration_Requirement(i)
            With x
                .StartPosition = FormStartPosition.CenterParent
                .ShowDialog()
            End With
        Catch ex As Exception
            MessageBox.Show("No record selected", "Select record", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
    End Sub
End Class
