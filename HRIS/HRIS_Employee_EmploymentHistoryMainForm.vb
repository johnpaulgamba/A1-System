﻿Imports MySql.Data.MySqlClient
Imports C1.Win.C1Command
Imports C1.Win.C1FlexGrid
Imports System.IO
Public Class HRIS_EmploymentHistoryHistoryMainForm

    Dim query1 As String = " Select a.EmploymentID as EmploymentID, " & _
        " Concat('EEH ', a.EmploymentID) as Reference, " & _
        " Concat('EMP ', b.EmployeeNo) as EmployeeNo,  " & _
        " Concat(LastName, ', ', FirstName, ' ', MiddleName) as Employee, " & _
        " Concat(Period_From, ' - ', Period_To) as Period, a.Employeer,a.Position, a.ContactNo, " & _
        " b.Active, " & _
        " a.Creator" & _
        " From HRIS_EmploymentHistory a" & _
        " JOIN hris_employee b On a.EmployeeID=b.EmployeeID   " & _
        " WHERE a.EmployeeID=b.EmployeeID  "
    Dim query2 As String = " Employeer  "
    Dim QUERY3 As String = " GROUP BY  a.EmploymentID "
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
        Dim x As New HRIS_EmployeeRegistration_EmploymentHistory(0)
        With x
            .StartPosition = FormStartPosition.CenterScreen
            .ShowDialog()
        End With
    End Sub
    Private Sub ViewItemHistory_Click() Handles SOViewRecord.Click
        Try
            Dim i As Integer = Me.DataGridView1.RowSel
            Dim ID As Integer = Me.DataGridView1.Rows(i).Item("EmploymentID")
            Dim x As New HistoryUpdate
            With x
                .loaddata("HRIS_EmploymentHistory", "EmploymentID", ID)
                .Text = "Item history of " & Me.DataGridView1.Item(i, "Reference")
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
        Timer1.Stop() : MainLauncher(1)
    End Sub
    Public Sub formatdatagrid()
        With Me.DataGridView1
            .AutoSizeCols()
            .AllowSorting = True
            .Rows(0).StyleDisplay.Font = New Font("Arial", Me.SliderZoomButton.Value + 1, FontStyle.Bold)
            .Cols("EmploymentID").Visible = False
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
        Dim OrderbyOf As String = ""
        Dim s1 As String = CompanyName.Text
        Dim s2 As String = Department.Text
        Dim s3 As String = SSSNo.Text
        Dim s4 As String = EmployeeName.Text

        If CompanyName.Text = "" Then s1 = "" Else s1 = " and b.companyid = '" & CompanyName.SelectedValue & "' "
        If Department.Text = "" Then s2 = "" Else s2 = " and b.departmentid = '" & Department.SelectedValue & "' "
        If EmployeeName.Text = "" Then s4 = "" Else s4 = " and a.employeeid='" & EmployeeName.SelectedValue & "' "
        If SSSNo.Text = "" Then s3 = "" Else s3 = " and a.employeer like'%" & SSSNo.Text & "%' "
        Dim filtersearchquery As String = s1 & s2 & s4 & s3

        overallQuery = query1 & filtersearchquery
        LoadingItemBrands(overallQuery)

    End Sub
  
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
        loadingvaluestoComboBoxes_StoredProc("Combo_Employees_Activeonly", Me.EmployeeName, "Employee", "EmployeeID")
        loadingvaluestoComboBoxes_StoredProc("combo_company_ActiveOnly", CompanyName, "companyname", "companyid")
        loadingvaluestoComboBoxes_StoredProc("combo_department_ActiveOnly", Department, "department", "departmentid")
        Me.SearchRecords_Click(sender, e)
    End Sub
    Private Sub EditCommand_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles EditCommand.Click
        Try
            If Me.DataGridView1.RowSel = 0 Then Exit Sub
            Dim i As Integer = Me.DataGridView1.Rows(Me.DataGridView1.RowSel).Item("EmploymentID")
            Dim x As New HRIS_EmployeeRegistration_EmploymentHistory(i)
            With x
                .StartPosition = FormStartPosition.CenterParent
                .ShowDialog()
            End With
        Catch ex As Exception
            MessageBox.Show("No record selected", "Select record", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
    End Sub

End Class
