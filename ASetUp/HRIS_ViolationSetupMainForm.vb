Imports MySql.Data.MySqlClient
Imports C1.Win.C1Command
Imports C1.Win.C1FlexGrid
Public Class HRIS_ViolationSetUpMainForm

    Dim query1 As String = "Select ViolationID, ViolationCode, ViolationType as General_Violation, ViolationDetails as Specific_Violation, Active, Creator from hris_violation_setup"
    Dim query2 As String = "  violationid asc"
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
                    Dim ViolationID As Integer = reader.Item("ViolationID")
                    Dim Violation As Integer = reader.Item("ViolationCode")
                    Dim x As New HRIS_ViolationSetupRegistration(ViolationID)
                    With x
                        .tosave = False
                        .Text = "Currently Modify : " & Violation
                        .StartPosition = FormStartPosition.CenterScreen
                        .ShowDialog()
                    End With
                    con.Close()
                    command.Dispose()
                    reader.Close()
                End If
            ElseIf b = 2 Then
                If reader.Read = True Then
                      Dim ViolationID As Integer = reader.Item("ViolationID")
                    Dim Violation As Integer = reader.Item("ViolationCode")
                    Dim x As New HRIS_ViolationSetupRegistration(ViolationID)
                    With x
                        .tosave = False
                        .Text = "Currently Modify : " & Violation
                        .StartPosition = FormStartPosition.CenterScreen
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
#Region "Controls and Commands"
    Private Sub Register_Click() Handles SOAddMenu.Click
        Dim x As New HRIS_ViolationSetupRegistration(0)
        With x
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
        End With
    End Sub
    Private Sub EditRecord_Click() Handles SOEditMenu.Click
        Try
            Dim i As Integer = Me.DataGridView1.RowSel
            readingAllInfo("SELECT * from HRIS_Violation_SetUp WHERE ViolationID='" & Me.DataGridView1.Item(i, "ViolationID") & _
                           "'", 1)
        Catch ex As Exception
            MessageBox.Show("No record selected")
        End Try
    End Sub
    Private Sub ViewItemHistory_Click() Handles SOViewRecord.Click
        Try
            Dim i As Integer = Me.DataGridView1.RowSel
            Dim ID As Integer = Me.DataGridView1.Rows(i).Item("violationID")
            Dim x As New HistoryUpdate
            With x
                .loaddata("Hris_Violation_SetUp", "violationID", ID)
                .Text = "Item history of " & Me.DataGridView1.Item(i, "ViolationCode")
                .StartPosition = FormStartPosition.CenterParent
                .ShowDialog()
            End With
        Catch ex As Exception
            MessageBox.Show("No record selected")
        End Try
    End Sub
    Private Sub DeleteRecord_Click() Handles SODeleteMenu.Click
        Try
            If Me.DataGridView1.RowSel = 0 Then
                MessageBox.Show("No record to delete.")
                Exit Sub
            End If
            Dim answer As MsgBoxResult = MessageBox.Show("Performing the command will delete the record " & vbCrLf & "and may affect other transactions." & vbCrLf & "Do you want to continue?", "Warning!.", MessageBoxButtons.YesNo, MessageBoxIcon.Stop)
            If answer = MsgBoxResult.Yes Then
                Dim i As Integer = Me.DataGridView1.RowSel
                saveEditDelete("DELETE from HRIS_Violation_SetUp WHERE ViolationID='" & Me.DataGridView1.Item(i, "ViolationID") & _
                         "'", "deleted.")
                Refresh_Click()
            End If
        Catch ex As Exception
            MessageBox.Show("No record selected")
        End Try
    End Sub
    Private Sub Refresh_Click() Handles SoRefresh.Click, ReloadAllRecords.Click
        'loadingHRIS_Violation(overallQuery)
    End Sub
    Private Sub DataGridView1_CellDoubleClick() Handles DataGridView1.DoubleClick
        Try
            If Me.SOAddMenu.Enabled = False Then Exit Sub
            Dim i As Integer = Me.DataGridView1.RowSel
            readingAllInfo("SELECT * from HRIS_Violation_SetUp WHERE ViolationID='" & Me.DataGridView1.Item(i, "ViolationID") & _
                           "'", 2)
        Catch ex As Exception
            MessageBox.Show("No record selected")
        End Try
    End Sub
#End Region

#Region "Page Navigations"
    Public Sub gotoFirst() Handles First.Click
        Try
            RemoveHandler Me.DataGridView1.AfterSelChange, AddressOf DataGridView1_AfterSelChange
            scrollVal = FunctionClass.gotoFirst(scrollVal, PreviousPage, NextPage, First, MoveToLast, pagingDS, totalRecords, PageNumber, pagingAdapter, DataGridView1, TextBox1, True) : FunctionClass.countrowsof5(scrollVal, Me.DataGridView1)
            AddHandler Me.DataGridView1.AfterSelChange, AddressOf DataGridView1_AfterSelChange
            Me.DataGridView1.Rows(1).Selected = True
        Catch ex As Exception
        End Try
    End Sub
    Public Sub PreviousPageClick() Handles PreviousPage.Click
        Try
            RemoveHandler Me.DataGridView1.AfterSelChange, AddressOf DataGridView1_AfterSelChange
            scrollVal = FunctionClass.PreviousPageClick(scrollVal, PreviousPage, NextPage, First, MoveToLast, pagingDS, totalRecords, PageNumber, pagingAdapter, DataGridView1, TextBox1, True) : FunctionClass.countrowsof5(scrollVal, Me.DataGridView1)
            AddHandler Me.DataGridView1.AfterSelChange, AddressOf DataGridView1_AfterSelChange
            Me.DataGridView1.Rows(1).Selected = True
        Catch ex As Exception
        End Try
    End Sub
    Private Sub DataGridView1_AfterSelChange(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RangeEventArgs)
        searchdetails()
    End Sub
    Private Sub searchdetails()
        Dim id As Integer = 0
        Try
            If Me.DataGridView1.Rows(1).Selected = True Then Me.DataGridView1.Rows(1).Selected = False
            id = Me.DataGridView1.Rows(Me.DataGridView1.RowSel).Item("violationid")
            FunctionClass.loadtoGrid3("Grid_ViolationSetUp_Main_Details", id, Me.C1FlexGrid1)
            ' FunctionClass.loadtoGrid3("Grid_JobOrder_Main_Details_02", id, Me.C1FlexGrid2)
        Catch ex As Exception
            ' Me.C1FlexGrid1.Rows.Count = 1
            ' Me.C1FlexGrid2.Rows.Count = 1
        End Try
    End Sub
    Public Sub NavigatePageType()
        scrollVal = FunctionClass.NavigatePageType(scrollVal, PreviousPage, NextPage, First, MoveToLast, pagingDS, totalRecords, PageNumber, pagingAdapter, DataGridView1, TextBox1, True) : FunctionClass.countrowsof5(scrollVal, Me.DataGridView1)
    End Sub
    Public Sub LastPageClick() Handles MoveToLast.Click
        Try
            RemoveHandler Me.DataGridView1.AfterSelChange, AddressOf DataGridView1_AfterSelChange
            scrollVal = FunctionClass.LastPageClick(scrollVal, PreviousPage, NextPage, First, MoveToLast, pagingDS, totalRecords, PageNumber, pagingAdapter, DataGridView1, TextBox1, True) : FunctionClass.countrowsof5(scrollVal, Me.DataGridView1)
            AddHandler Me.DataGridView1.AfterSelChange, AddressOf DataGridView1_AfterSelChange
            Me.DataGridView1.Rows(1).Selected = True
        Catch ex As Exception
        End Try
    End Sub
    Public Sub NextPageClick() Handles NextPage.Click
        Try
            RemoveHandler Me.DataGridView1.AfterSelChange, AddressOf DataGridView1_AfterSelChange
            scrollVal = FunctionClass.NextPageClick(scrollVal, PreviousPage, NextPage, First, MoveToLast, pagingDS, totalRecords, PageNumber, pagingAdapter, DataGridView1, TextBox1, True) : FunctionClass.countrowsof5(scrollVal, Me.DataGridView1)
            AddHandler Me.DataGridView1.AfterSelChange, AddressOf DataGridView1_AfterSelChange
            Me.DataGridView1.Rows(1).Selected = True
        Catch ex As Exception
        End Try
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
        FunctionClass.GridStyle(Me.DataGridView1)
        DataGridView1.GetType.InvokeMember("DoubleBuffered", Reflection.BindingFlags.NonPublic Or Reflection.BindingFlags.Instance Or System.Reflection.BindingFlags.SetProperty, Nothing, DataGridView1, New Object() {True})
        RemoveHandler Me.DataGridView1.AfterSelChange, AddressOf DataGridView1_AfterSelChange
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
        Me.Timer1.Stop()
        'LoadingForm()
        AddHandler Me.DataGridView1.AfterSelChange, AddressOf DataGridView1_AfterSelChange
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
        overallQuery = query1 & " ORDER BY " & query2
        LoadingItemBrands(overallQuery)
    End Sub
    Public Sub LoadingItemBrands(ByVal sql As String)
        RemoveHandler Me.DataGridView1.AfterSelChange, AddressOf DataGridView1_AfterSelChange
        Try
            MainLauncher(Me.DataGridView1, 0)
            connect()
            con.Open()
            pagingAdapter = New MySqlDataAdapter("LoadAllData", con)
            pagingAdapter.SelectCommand.CommandType = CommandType.StoredProcedure
            pagingAdapter.SelectCommand.Parameters.AddWithValue("@StringQuery", sql)
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
        FunctionClass.TimerTick(Me.C1FlexGrid1, Me.SliderZoomButton)
        FunctionClass.TimerTick(Me.C1FlexGrid2, Me.SliderZoomButton)
        Timer1.Stop() : MainLauncher(1)
    End Sub
    Public Sub formatdatagrid()
        Try
            With Me.DataGridView1
                .AutoSizeCols()
                .AllowFiltering = True
                .AllowSorting = True
                .Rows(0).StyleDisplay.Font = New Font("Arial", Me.SliderZoomButton.Value + 1, FontStyle.Bold)
                .Cols("ViolationID").Visible = False
                'ColumnVisible()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub ColumnVisible()
        FunctionClass.ColumnVisible(False, Me.DataGridView1, Me.ButtonItem4, Me.C1Command1)
    End Sub
    Private Sub a1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles a1.Click
        ColumnVisible()
    End Sub
    Private Sub SearchRecords_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchRecords.Click
        Dim sortarrangement As String = ""
        If Asc.Checked = True Then sortarrangement = " ASC " Else sortarrangement = " DESC"
        overallQuery = performSearchQuery(sortarrangement)
        MainLauncher(0)
        LoadingItemBrands(overallQuery)
        MainLauncher(1)
    End Sub
    Private Function performSearchQuery(ByVal sortarrangement As String) As String
        Dim x As String = ""
        Dim isCancelledQuery As String = ""
        If Me.CancelledYes.Checked = True Then isCancelledQuery = " AND a.iscancelled=1 " Else isCancelledQuery = " AND a.iscancelled=0"
        If Me.CancelledBoth.Checked = True Then isCancelledQuery = ""
        Dim RRDatequery As String = ""
        Return query1 & " where violationcode like '%" & convertQuotes(ViolationCode.Text) & "%' and violationtype LIKE '%" & convertQuotes(GeneralViolation.Text) & _
          "%' and violationdetails like '" & convertQuotes(SpecificViolation.Text) & "%' "
    End Function
    
    Private Function convertQuotes(ByVal a As String) As String
        Return MySqlHelper.EscapeString(a)
    End Function
  
    Private Sub ClearFields_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearFields.Click
        Me.ViolationCode.Text = Nothing
        ' Me.DateOrdered.Text = Now
        Me.SpecificViolation.Text = Nothing
        Me.Desc.Checked = True
    End Sub
    Private Sub C1Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1Button2.Click
        Me.C1SplitterPanel1.Visible = Not Me.C1SplitterPanel1.Visible
        If Me.C1SplitterPanel1.Visible = True Then Me.C1Button2.Image = My.Resources.download Else Me.C1Button2.Image = My.Resources.upload
    End Sub
    Private Sub C1Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1Button1.Click
        Me.C1SplitterPanel2.Visible = Not Me.C1SplitterPanel2.Visible : If Me.C1SplitterPanel2.Visible = True Then Me.C1Button1.BackgroundImage = My.Resources.left Else Me.C1Button1.BackgroundImage = My.Resources.right
    End Sub

    Private Sub JobOrdersMainForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SearchRecords_Click(sender, e)
    End Sub

    
End Class
