Imports MySql.Data.MySqlClient
Imports C1.Win.C1Command
Imports C1.Win.C1FlexGrid

Public Class TaxTableMainForm
    Dim query1 As String = "SELECT TaxTableID as ID, PayrollGroup,format(Range_From,3)as Range_From, format(Range_To,3) as Range_To,  format(Add_Value,3) as IncomeTax,format(Add_Percent*100,3) as Add_Percent, Creator  from  TaxTable"
    Dim query2 As String = " taxtableid"
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
                    Dim taxtableid As Integer = reader.Item("taxtableid")
                    Dim PHICTABLE As String = reader.Item("PHICTABLE")
                    'Dim x As New PHICTABLERegistration
                    ' With x
                    '.QuerytoString = overallQuery
                    ' .toSave = False
                    '.EditLoad(taxtableid)
                    ' .taxtableid = taxtableid
                    ' .Text = "Currently modifying : " & PHICTABLE
                    '.StartPosition = FormStartPosition.CenterParent
                    ' .ShowDialog()
                    '  End With
                    con.Close()
                    command.Dispose()
                    reader.Close()
                End If
            ElseIf b = 2 Then
                If reader.Read = True Then
                    Dim taxtableid As Integer = reader.Item("taxtableid")
                    Dim PHICTABLE As String = reader.Item("PHICTABLE")
                    'Dim x As New PHICTABLERegistration
                    ' With x
                    '.QuerytoString = overallQuery
                    '.toSave = False
                    ' .taxtableid = taxtableid
                    '.EditLoad(taxtableid)
                    ' .Text = "Currently modifying : " & PHICTABLE
                    ' .toEnableAllControls(True)
                    '.SaveRecord.Enabled = False
                    '.StartPosition = FormStartPosition.CenterParent
                    '.ShowDialog()
                    ' End With
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
    Private Sub Register_Click() Handles SOAddMenu.Click
        '  Dim x As New PHICTABLERegistration
        ' With x
        '.QuerytoString = overallQuery
        '.StartPosition = FormStartPosition.CenterScreen
        '.ShowDialog()
        'End With
    End Sub
    Private Sub EditRecord_Click() Handles SOEditMenu.Click
        Try
            Dim i As Integer = Me.DataGridView1.RowSel
            readingAllInfo("SELECT * from hris_PHICTABLE WHERE taxtableid='" & Me.DataGridView1.Item(i, "taxtableid") & _
                           "'", 1)
        Catch ex As Exception
            MessageBox.Show("No record selected")
        End Try
    End Sub
    Private Sub ViewItemHistory_Click() Handles SOViewRecord.Click
        Try
            Dim i As Integer = Me.DataGridView1.RowSel
            Dim x As New HistoryUpdate
            With x
                .HistoryTextbox.Text = Me.DataGridView1.Item(i, "ChangesMade")
                .Text = "Item history of " & Me.DataGridView1.Item(i, "taxtableid")
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
                saveEditDelete("DELETE from hris_PHICTABLE WHERE taxtableid='" & Me.DataGridView1.Item(i, "taxtableid") & _
                         "'", "deleted.")
                Refresh_Click()
            End If
        Catch ex As Exception
            MessageBox.Show("No record selected")
        End Try
    End Sub
    Private Sub Refresh_Click() Handles SoRefresh.Click
        loadingPHICTABLEs(overallQuery)
    End Sub
    Private Sub DataGridView1_CellDoubleClick() Handles DataGridView1.DoubleClick
        Try
            If Me.SOAddMenu.Enabled = False Then Exit Sub
            Dim i As Integer = Me.DataGridView1.RowSel
            readingAllInfo("SELECT * from hris_PHICTABLE WHERE taxtableid='" & Me.DataGridView1.Item(i, "taxtableid") & _
                           "'", 2)
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
    Public Sub LoadingForm() Handles SOShowAll.Click
        overallQuery = query1 & " Order by " & query2
        loadingPHICTABLEs(overallQuery)
    End Sub
    Public Sub loadingPHICTABLEs(ByVal sql As String)
        Try
            FunctionClass.LoadingItemBrands(sql, Me.DataGridView1, Me.NextPage, Me.MoveToLast, Me.First, Me.PreviousPage, Me.PageNumber, Me.TextBox1, Me.LabelItem9)
            formatdatagrid()
        Catch ex As Exception
        Finally
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
            .Rows(0).StyleDisplay.Font = New Font("Arial", Me.SliderZoomButton.Value + 1, FontStyle.Bold)
            ' .Item(0, 1) = "ID"
            .Cols("ID").TextAlign = TextAlignEnum.RightCenter
            .Cols("Range_From").TextAlign = TextAlignEnum.RightCenter
            .Cols("Range_To").TextAlign = TextAlignEnum.RightCenter
            .Cols("IncomeTax").TextAlign = TextAlignEnum.RightCenter
            .Cols("Add_Percent").TextAlign = TextAlignEnum.RightCenter
            .Cols("creator").TextAlign = TextAlignEnum.LeftCenter
            ' .AutoSizeCol(.Cols("Active").Index)
            ColumnVisible()
        End With
        Timer1.Start()
        Timer1.Stop()
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
        If Asc.Checked = True Then sortarrangement = " ASC " Else sortarrangement = " DESC"
        OrderbyOf = Trim(Me.OrderBY.Text).Replace(" ", "")
        overallQuery = performSearchQuery(PHICTABLE.Text, Creator.Text, Description.Text, ChangesMade.Text, DateCreated.Text, LastUpdate.Text, OrderbyOf, sortarrangement, returnActiveInactive(RecordsActive.Checked, RecordsInactive.Checked, RecordsBoth.Checked))
        loadingPHICTABLEs(overallQuery)
    End Sub
    Private Function performSearchQuery(ByVal Classification As String, ByVal creator As String, ByVal description As String, _
                                        ByVal changesmade As String, ByVal datecreated As String, ByVal lastupdate As String, _
                                        ByVal orderby As String, ByVal sortarrangement As String, ByVal active As String)
        Dim query1 As String = "SELECT * from PHICTABLE WHERE"
        Classification = "  "
        creator = "  "
        description = " "
        changesmade = " "
        datecreated = " "
        lastupdate = " "
        Return query1 & Classification & creator & description & changesmade & datecreated & lastupdate & active
    End Function
    Private Function convertQuotes(ByVal a As String) As String
        Return MySqlHelper.EscapeString(a)
    End Function
    Private Sub ClearFields_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearFields.Click
        Me.PHICTABLE.Text = Nothing
        Me.Creator.Text = Nothing
        Me.Description.Text = Nothing
        Me.ChangesMade.Text = Nothing
        Me.DateCreated.Text = Nothing
        Me.LastUpdate.Text = Nothing
        Me.OrderBY.SelectedIndex = 0
        Me.RecordsBoth.Checked = True
        Me.Asc.Checked = True
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
End Class
