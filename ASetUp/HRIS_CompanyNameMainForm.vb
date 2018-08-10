Imports MySql.Data.MySqlClient
Imports C1.Win.C1Command
Imports C1.Win.C1FlexGrid
Public Class HRIS_CompanyNameMainForm
    Dim query1 As String = "SELECT CompanyID, CompanyName, AddressOfCompany,TIN,RDOCode,SSS,Philhealth,HDMF,ContactNo,EmailAddress, Active, Creator, ChangesMade from Company "
    Dim query2 As String = "  Companyname"
    Dim overallQuery As String = ""
    Private ds As DataSet = New DataSet
    Dim pagingAdapter As MySqlDataAdapter
    Dim pagingDS As DataSet
    Public scrollVal As Integer
    Dim totalRecords As Integer = 0
    Private Sub SOExportCurrent_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles SOExportCurrent.Click
        FunctionClass.ExportGrid(Me.DataGridView1)
    End Sub
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
#Region "Controls and Commands"
    Private Sub Register_Click() Handles SOAddMenu.Click
        Dim x As New HRIS_CompanyNameRegistration
        With x
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
        End With
    End Sub
    Private Sub EditRecord_Click() Handles SOEditMenu.Click
        Try
            Dim i As Integer = Me.DataGridView1.RowSel
            readingAllInfo("SELECT * from company WHERE CompanyID='" & Me.DataGridView1.Item(i, "CompanyID") & _
                           "'", 1)
        Catch ex As Exception
            MessageBox.Show("No record selected")
        End Try
    End Sub
    Public Sub Refresh_Click() Handles SoRefresh.Click, ReloadAllRecords.Click
        LoadingCompanySetup(overallQuery)
    End Sub
    Private Sub ViewItemHistory_Click() Handles SOViewRecord.Click
        Try
            Dim i As Integer = Me.DataGridView1.RowSel
            Dim x As New HistoryUpdate
            With x
                .HistoryTextbox.Text = Me.DataGridView1.Rows(i).Item("ChangesMAde")
                .Text = "Item history of " & Me.DataGridView1.Item(i, "CompanyName")
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
                saveEditDelete("DELETE from company WHERE CompanyID='" & Me.DataGridView1.Item(i, "CompanyID") & _
                         "'", "deleted.")
                SoRefresh.PerformClick()
            End If
        Catch ex As Exception
            MessageBox.Show("No record selected")
        End Try
    End Sub
    Private Sub DataGridView1_CellDoubleClick() Handles DataGridView1.DoubleClick
        Try
            If Me.SOAddMenu.Enabled = False Then Exit Sub
            Dim i As Integer = Me.DataGridView1.RowSel
            readingAllInfo("SELECT * from company WHERE CompanyID='" & Me.DataGridView1.Item(i, "CompanyID") & _
                           "'", 2)
        Catch ex As Exception
            MessageBox.Show("No record selected")
        End Try
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
                    Dim x As New HRIS_CompanyNameRegistration
                    With x
                        Dim lb() As Byte = reader.Item("CompanyImage")
                        Dim lstr As New System.IO.MemoryStream(lb)
                        .InputCheckBox1.Checked = reader.Item("Active")
                        .tosave = False
                        .companyid = reader.Item("CompanyID")
                        .CompanyName.Text = reader.Item("CompanyName")
                        .AddressOFCompany.Text = reader.Item("AddressofCompany")
                        .EmailAddress.Text = reader.Item("emailaddress")
                        .TelNo.Text = reader.Item("contactNo")
                        .TIN.Text = reader.Item("TIN")
                        .RDOCode.Text = reader.Item("rdocode")
                        .PhilHealthNo.Text = reader.Item("philhealth")
                        .HDMFNo.Text = reader.Item("hdmf")
                        .SSSNo.Text = reader.Item("sss")
                        .PictureBox1.Image = Image.FromStream(lstr)
                        .StartPosition = FormStartPosition.CenterParent
                        .ShowDialog()
                    End With
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub New()
        InitializeComponent()
        DataGridView1.GetType.InvokeMember("DoubleBuffered", Reflection.BindingFlags.NonPublic Or Reflection.BindingFlags.Instance Or System.Reflection.BindingFlags.SetProperty, Nothing, DataGridView1, New Object() {True})
        Me.RibbonBar4.Font = New Font("Arial", 9, FontStyle.Bold)
        Me.RibbonBar4.Width = 360
        Me.LabelItem9.Text = "Page Navigation"
        Dim i As Integer = 0
        Dim j As Integer = ButtonItem4.SubItems.Count - 2
        C1Command1.CommandLinks.Clear()
        Me.OrderBY.Items.Clear()

        For i = 1 To j
            Dim x As String = ButtonItem4.SubItems(i).Text
            Dim y As Boolean = Convert.ToBoolean(CType(ButtonItem4.SubItems(i), DevComponents.DotNetBar.ButtonItem).Checked)
            Dim z As Boolean = Convert.ToBoolean(CType(ButtonItem4.SubItems(i), DevComponents.DotNetBar.ButtonItem).Enabled)
            Dim mWindow As C1Command = CType(C1CommandHolder1.CreateCommand(GetType(C1CommandMenu)), C1Command)
            mWindow.Text = x
            mWindow.CheckAutoToggle = True And z
            Dim haha As New C1.Win.C1InputPanel.InputOption
            haha.Text = x.Replace(" ", "")
            Me.OrderBY.Items.Add(haha)
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
        overallQuery = query1 & "ORDER BY " & query2
        LoadingCompanySetup(overallQuery)
    End Sub
    Public Sub LoadingCompanySetup(ByVal sql As String)
        Try
            MainLauncher(Me.DataGridView1, 0)
            connect()
            con.Open()
            pagingAdapter = New MySqlDataAdapter(sql, con)
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
            countrow()
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
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        MainLauncher(0) : FunctionClass.TimerTick(Me.DataGridView1, Me.SliderZoomButton) : Timer1.Stop() : MainLauncher(1)
    End Sub
    Public Sub formatdatagrid()
        With Me.DataGridView1
            .AutoSizeCols()
            .AllowSorting = True
            .Rows(0).StyleDisplay.Font = New Font("Arial", Me.SliderZoomButton.Value + 1, FontStyle.Bold)
            .Cols("CompanyID").Caption = "ID"

            .Cols("ChangesMade").Visible = False
            .AutoSizeCol(.Cols("Active").Index)
            ColumnVisible()
        End With
    End Sub
    Private Sub ColumnVisible()
        FunctionClass.ColumnVisible(False, Me.DataGridView1, Me.ButtonItem4, Me.C1Command1)
    End Sub
    Private Sub a1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles a1.Click, _
        a2.Click, a3.Click, a4.Click, a5.Click, a6.Click
        ColumnVisible()
    End Sub
    Private Sub SearchRecords_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchRecords.Click
        Dim sortarrangement As String = ""
        If Asc.Checked = True Then sortarrangement = " ASC " Else sortarrangement = " DESC"
        overallQuery = performSearchQuery(sortarrangement, returnActiveInactive(RecordsActive.Checked, RecordsInactive.Checked, RecordsBoth.Checked))
        LoadingCompanySetup(overallQuery)
    End Sub
    Private Function performSearchQuery(ByVal sortarrangement As String, ByVal active As String)
        Dim CompanySetup As String = "  CompanyName LIKE '%" & convertQuotes(Me.CompanyName.Text) & "%'"
        Dim Description As String = " AND AddressOfCompany LIKE '%" & convertQuotes(Me.AddressofCompany.Text) & "%' "
        Dim Creator = " AND Creator LIKE '%" & convertQuotes(Me.Creator.Text) & "%' "
        Dim DateCreated = ""
        Dim LastUpdate = ""
        Dim Orderby As String = Me.OrderBY.Text.Replace(" ", "")
        Return query1 & " WHERE " & CompanySetup & Description & Creator & _
             DateCreated & LastUpdate & active & " Order by " & Orderby & sortarrangement
    End Function
    Private Function convertQuotes(ByVal a As String) As String
        Return MySqlHelper.EscapeString(a)
    End Function
    Private Function returnActiveInactive(ByVal a As Boolean, ByVal b As Boolean, ByVal c As Boolean)
        If a = False And b = False Then Return "" Else Return " AND ACTIVE=" & Convert.ToSingle(a)
    End Function
    Private Sub ClearFields_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearFields.Click
        FunctionClass.ClearPanel(Me.BasicSearchOption)
        Me.OrderBY.SelectedIndex = 0
        Me.RecordsBoth.Checked = True
        Me.Asc.Checked = True
    End Sub

    Private Sub C1Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1Button1.Click
        Me.C1SplitterPanel6.Visible = Not Me.C1SplitterPanel6.Visible
        If Me.C1SplitterPanel6.Visible = True Then Me.C1Button1.BackgroundImage = My.Resources.left Else Me.C1Button1.BackgroundImage = My.Resources.right
    End Sub
End Class
