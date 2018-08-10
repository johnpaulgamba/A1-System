Imports MySql.Data.MySqlClient
Imports C1.Win.C1Command
Imports C1.Win.C1FlexGrid
Public Class ARBegBalanceMainForm

    Dim query1 As String = "Select BBID, Concat('BB ', a.BBID) as BBNo, date_format(a.BBDate, '%m/%d/%Y') as BBDate, " & _
  " a.isCancelled as Cancelled,A.isapproved as Approved, a.Remarks,a.DateCreated," & _
  "A.LastUpdate,a.Creator as CreatedBy From ARBegBalance a  WHERE a.BBID<> 0 and a.companyid='" & companyid & "'"
    Dim query2 As String = "  a.BBID desc"
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
            adapter.SelectCommand.Parameters.AddWithValue("@ID", BakeTechMainForm.EmployeeID.Text)
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
    Private Sub readdetails(ByVal sql As String, ByVal b As Integer)

        Dim BBID As Integer = 0
        Dim ds As New DataSet
        connect()
        con.Open()
        Dim adapter As New MySqlDataAdapter(sql, con)
        With adapter
            .Fill(ds)
            .Dispose()
        End With
        con.Close()
        BBID = ds.Tables(0).Rows(0).Item("BBID")
        ''CANCEL COMMAND
        If b = 1 Then
            With ds.Tables(0).Rows(0)
                If .Item("iscancelled") = True Then
                    showMessage("the record is already cancelled. you are not allowed to perform the command!", "cancelled already", "invalid command", 1)
                    Exit Sub
                End If
            End With
            Dim sagot As MsgBoxResult = MessageBox.Show("are you sure you want to perform the command?", "verification", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If sagot <> MsgBoxResult.Yes Then Exit Sub
            connect()
            con.Open()
            Dim command As New MySqlCommand
            With command
                .CommandText = "update ARBegBalance set isapproved=@isapproved, iscancelled=@iscancelled, cancelledby=@cancelledby, datecancelled=@datecancelled, " & _
               "lastupdate=@lastupdate where BBID=@BBID"
                With .Parameters
                    .AddWithValue("@cancelledby", BakeTechMainForm.UserFullName.Text)
                    .AddWithValue("@datecancelled", Format(Now, "yyyy-MM-dd HH:mm:ss"))
                    .AddWithValue("@iscancelled", 1)
                    .AddWithValue("@isapproved", 0)
                    .AddWithValue("@lastupdate", Format(Now, "yyyy-MM-dd HH:mm:ss"))
                    .AddWithValue("@BBID", BBID)
                End With
                .Connection = con
                .ExecuteNonQuery()

                .Parameters.AddWithValue("@id", BBID)
                .CommandText = "Inventory_ARBegBalance_recall"
                .CommandType = CommandType.StoredProcedure
                .Connection = con
                .ExecuteNonQuery()

                con.Close()
                command.Dispose()
                showMessage("the command has been successfully executed.", "command successful", "command executed", 3)
            End With
            ''APPROVE COMMAND
        ElseIf b = 2 Then
            With ds.Tables(0).Rows(0)
                If .Item("isapproved") = True Then
                    showMessage("the record is already approved. you are not allowed to perform the command!", "approved already", "invalid command", 1)
                    Exit Sub
                End If
            End With
            Dim sagot As MsgBoxResult = MessageBox.Show("are you sure you want to perform the command?", "verification", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If sagot <> MsgBoxResult.Yes Then Exit Sub
            connect()
            con.Open()
            Dim command As New MySqlCommand
            With command
                .CommandText = "update ARBegBalance set iscancelled=@iscancelled, isapproved=@isapproved, approvedby=@approvedby, dateapproved=@dateapproved, " & _
               "lastupdate=@lastupdate where BBID=@BBID"
                With .Parameters
                    .AddWithValue("@approvedby", BakeTechMainForm.UserFullName.Text)
                    .AddWithValue("@dateapproved", Format(Now, "yyyy-MM-dd HH:mm:ss"))
                    .AddWithValue("@isapproved", 1)
                    .AddWithValue("@iscancelled", 0)
                    .AddWithValue("@lastupdate", "" & Now)
                    .AddWithValue("@BBID", BBID)
                End With
                .Connection = con
                .ExecuteNonQuery()

                .Parameters.AddWithValue("@id", BBID.ToString("d6"))
                .CommandText = "Inventory_ARBegBalance_APPROVAL"
                .CommandType = CommandType.StoredProcedure
                .Connection = con
                .ExecuteNonQuery()

                con.Close()
                command.Dispose()
                showMessage("the command has been successfully executed.", "command successful", "command executed", 3)
            End With

            ''DELETE COMMAND
        ElseIf b = 4 Then
            Dim x As New ARBegBalanceEntry(BBID)
            With x
                .toenable(False)
                .StartPosition = FormStartPosition.CenterScreen
                .Show()

            End With
        ElseIf b = 8 Then
            Dim x As New ARBegBalanceEntry(BBID)
            With x
                '.toedit = False
                .toenable(False)
                .StartPosition = FormStartPosition.CenterScreen
                .Show()
            End With


        ElseIf b = 5 Then
            Dim x As New ARBegBalanceEntry(BBID)
            With x
                ' .toedit = True
                .BBID = BBID
                .tosave = False
                .toenable(True)
                .StartPosition = FormStartPosition.CenterScreen
                .Show()
            End With

        End If
    End Sub
#Region "Controls and Commands"
    Private Sub Register_Click() Handles SOAddMenu.Click
        MainLauncher(0)
        Dim x As New ARBegBalanceEntry(0)
        With x
            '.querytoString = overallQuery

            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
        End With
        MainLauncher(1)
    End Sub
    Private Sub EditRecord_Click() Handles SOEditMenu.Click
        Try
            Dim i As Integer = Me.DataGridView1.RowSel
            readdetails("SELECT * from ARBegBalance WHERE BBID='" & Me.DataGridView1.Item(i, "BBID") & _
                           "'", 5)
        Catch ex As Exception
            MessageBox.Show("No record selected")
        End Try
    End Sub
    Private Sub ViewItemHistory_Click() Handles SOViewRecord.Click
        Try
            Dim i As Integer = Me.DataGridView1.RowSel
            Dim x As New HistoryUpdate
            With x
                ' .HistoryTextbox.Text = Me.DataGridView1.Item(i, "ChangesMade")
                .Text = "Item history of " & Me.DataGridView1.Item(i, "PONO")
                .StartPosition = FormStartPosition.CenterParent
                .ShowDialog()
            End With

        Catch ex As Exception
            MessageBox.Show("No record selected")
        End Try
    End Sub
    Private Sub Refresh_Click() Handles SoRefresh.Click, ReloadAllRecords.Click
        LoadingItemBrands(overallQuery)
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
                saveEditDelete("DELETE from ARBegBalance WHERE BBID='" & Me.DataGridView1.Item(i, "BBID") & _
                         "'", "deleted.")
                saveEditDelete("DELETE from ARBegBalanceorders WHERE BBID='" & Me.DataGridView1.Item(i, "BBID") & _
                         "'", "wala")
                SoRefresh.PerformClick()
            End If
        Catch ex As Exception
            MessageBox.Show("No record selected")
        End Try
    End Sub
    Private Sub CancelJobOrderButton_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles CancelJobOrderButton.Click
        Try
            Dim id As Integer = Me.DataGridView1.Rows(Me.DataGridView1.RowSel).Item("BBID")
            readdetails("select * from ARBegBalance where BBID=" & id, 1)
        Catch ex As Exception
            showMessage(ex.Message, "exception found cancel order", "contact system admin", 1)
        End Try
    End Sub
    Private Sub DataGridView1_AfterSelChange(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RangeEventArgs)
        searchdetails()
    End Sub
    Private Sub searchdetails()
        Dim id As Integer = 0
        Try
            If Me.DataGridView1.Rows(1).Selected = True Then Me.DataGridView1.Rows(1).Selected = False
            id = Me.DataGridView1.Rows(Me.DataGridView1.RowSel).Item("BBID")
            FunctionClass.loadtoGrid3("Grid_ARBegBalance_Main_Details_01", id, Me.C1FlexGrid1)
            ' FunctionClass.loadtoGrid3("Grid_JobOrder_Main_Details_02", id, Me.C1FlexGrid2)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            ' Me.C1FlexGrid1.Rows.Count = 1
            ' Me.C1FlexGrid2.Rows.Count = 1
        End Try
    End Sub
    Private Sub DataGridView1_CellDoubleClick() Handles DataGridView1.DoubleClick
        Try
            If Me.SOAddMenu.Enabled = False Then Exit Sub
            Dim i As Integer = Me.DataGridView1.RowSel
            readdetails("SELECT * from ARBegBalance WHERE BBID='" & Me.DataGridView1.Item(i, "BBID") & _
                           "'", 4)
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
        LoadingForm()
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
            'MessageBox.Show(ex.Message)
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
                .AllowFiltering = True
                .AllowResizing = True
                .AllowSorting = True
                .Rows(0).StyleDisplay.Font = New Font("Arial", Me.SliderZoomButton.Value + 1, FontStyle.Bold)
                .Cols("BBID").Visible = False
                .Cols("BBDate").Visible = True
                .Cols("Cancelled").Caption = "Cancelled"
                .Cols("Approved").Caption = "Approved"
                .Cols("Cancelled").TextAlignFixed = TextAlignEnum.CenterCenter
                .Cols("Approved").TextAlignFixed = TextAlignEnum.CenterCenter
                '.Cols("Remarks").Width = 200
                .AutoSizeCol(.Cols("Cancelled").Index)
                .AutoSizeCol(.Cols("approved").Index)
                .AutoSizeCol(.Cols("Paid").Index)
                'ColumnVisible()
            End With
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub ColumnVisible()
        FunctionClass.ColumnVisible(False, Me.DataGridView1, Me.ButtonItem4, Me.C1Command1)
    End Sub
    Private Sub a1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles a1.Click
        ColumnVisible()
    End Sub
    Private Sub SearchRecords_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchRecords.Click
        Try
            Dim sortarrangement As String = ""
            If Asc.Checked = True Then sortarrangement = " ASC " Else sortarrangement = " DESC"
            overallQuery = performSearchQuery(sortarrangement)
            MainLauncher(0)
            LoadingItemBrands(overallQuery)
            MainLauncher(1)
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Function performSearchQuery(ByVal sortarrangement As String) As String
        Dim x As String = ""
        Dim isCancelledQuery As String = ""
        If Me.CancelledYes.Checked = True Then isCancelledQuery = " AND a.iscancelled=1 " Else isCancelledQuery = " AND a.iscancelled=0"
        If Me.CancelledBoth.Checked = True Then isCancelledQuery = ""
        Dim RRDatequery As String = ""
        If Me.DateFrom.Text = Nothing And Me.DateFrom.Text = Nothing Then
            RRDatequery = ""
        Else
            If Me.DateFrom.Text <> Nothing Then
                If DateFrom.Text <> Nothing Then
                    RRDatequery = " and  date_format(a.BBDate, '%Y/%m/%d')  between '" & Format(DateFrom.Value, "yyyy/MM/dd") & "' and '" & Format(DateTo.Value, "yyyy/MM/dd") & "' "
                Else
                    RRDatequery = " and  a.BBDate >= '" & Format(DateFrom.Value, "yyyy/MM/dd") & "' "
                End If
            Else
                If DateTo.Text <> Nothing Then
                    RRDatequery = " and a.BBDate<= '" & Format(DateTo.Value, "yyyy/MM/dd") & "' "
                Else
                    RRDatequery = " and a.BBDate like '%%' "
                End If
            End If
        End If


        Return query1 & " and a.bbid LIKE '%" & Val(Me.CMNo.Text) & _
                     "%' AND a.Creator Like '%" & Me.Creator.Text & "%' " & _
           isCancelledQuery & RRDatequery & "  ORDER BY a.bbid" & sortarrangement

    End Function
    Private Function convertQuotes(ByVal a As String) As String
        Return MySqlHelper.EscapeString(a)
    End Function
    Private Function returnActiveInactive(ByVal a As Boolean, ByVal b As Boolean, ByVal c As Boolean)
        If a = False And b = False Then Return "" Else Return " AND ACTIVE=" & Convert.ToSingle(a)
    End Function
    Private Sub ClearFields_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearFields.Click
        Me.cmno.Text = Nothing
        ' Me.DateOrdered.Text = Now
        Me.CustomerName.Text = Nothing
        Me.Creator.Text = Nothing
        Me.sino.Text = Nothing

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
        Me.DateFrom.Value = FirstDayOfMonth(Now)
        Me.DateTo.Value = LastDayOfMonth(Now)
        SearchRecords_Click(sender, e)
    End Sub
End Class
