Imports C1.Win.C1SuperTooltip
Imports MySql.Data.MySqlClient
Imports DevComponents.DotNetBar.Controls
Imports System.Collections.Specialized
Imports C1.Win.C1InputPanel
Imports DevComponents.DotNetBar
Imports C1.Win.C1FlexGrid
Public Class JobOrderRegistration
    Dim ds As New DataSet
    Dim pagingAdapter As New MySqlDataAdapter
    Public toSave As Boolean = True
    Public querytoString As String = ""
    Public AdjustmentID As Integer = 0
    Public isToRefreshJobOrderOrdered As Boolean = False
    Sub New()
        InitializeComponent()
        Me.OrderListOfItems.Rows(0).StyleDisplay.Font = New Font("Segoe UI", FontSize.Value + 1, FontStyle.Bold)
        Me.OrderListOfItems.Cols("ItemName").Editor = Me.ListOfItems
        'FunctionClass.loadingvaluestoComboBoxes("SELECT Source, SourceID FROM Source WHERE ACTIVE=1 and isProduction=1 ORDER by Source", JOLocation, "Source", "SourceID")
        AddHandler Me.UseItemCodeforCoding.PressedChanged, AddressOf USeItemCode_CheckedChanged
    End Sub
    Public Sub loadingvaluestoComboBoxes(ByVal sql As String, ByVal a As C1.Win.C1InputPanel.InputComboBox, ByVal displaymem As String, ByVal valuemem As String)
        Try
            connect()
            con.Open()
            pagingAdapter = New MySqlDataAdapter(sql, con)
            ds = New DataSet
            pagingAdapter.Fill(ds)
            con.Close()
            With a
                .Items.Clear()
                .DataSource = ds.Tables(0)
                .DisplayMember = displaymem.ToString
                .ValueMember = valuemem.ToString
                If .Items.Count < 2 Then .GripHandleVisible = False Else .GripHandleVisible = True
            End With
        Catch ex As Exception
        End Try
    End Sub
#Region "Grid View Controls and Events"
    Private Sub OrderListOfItems_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Delete Then
            performDeleteOrder()
        ElseIf e.Modifiers = Keys.Control Then
            If e.KeyCode = Keys.C Then
                Me.OrderListOfItems.Copy()
            ElseIf e.KeyCode = Keys.V Then
                Me.OrderListOfItems.Paste()
                validateIfDuplicated()
            End If
        End If
    End Sub
    Private Sub loadcombo(ByVal a As String, ByVal combo As ComboBox)
        Try
            Dim ds As New DataSet
            Dim adapter As New MySqlDataAdapter
            connect()
            con.Open()
            adapter = New MySqlDataAdapter(a, con)
            adapter.Fill(ds)
            combo.DataSource = ds.Tables(0)
            combo.DisplayMember = "Itemname"
            con.Close()
            If ds.Tables(0).Rows.Count > 0 Then
                With combo
                    .DropDownStyle = ComboBoxStyle.DropDownList
                    .DropDownHeight = 500
                    .DropDownWidth = 800
                    .DropDownStyle = ComboBoxStyle.DropDownList
                End With
            Else
                With combo
                    .DropDownHeight = 1
                    .DropDownWidth = Me.OrderListOfItems.Cols("Itemname").Width
                    .DropDownStyle = ComboBoxStyle.DropDownList
                End With
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Function validateIfDuplicated() As Boolean
        Try
            With Me.OrderListOfItems
                Dim filterSearch As String = ""
                For a As Integer = 1 To .Rows.Count - 1
                    filterSearch = .Item(a, 2)
                    If .Item(a, 2) = String.Empty Then
                    Else
                        For x = a + 1 To .Rows.Count - 1
                            If filterSearch = .Item(x, 2) Then
                                MsgBox("The Item Code  '" & filterSearch & "' exists already.", MsgBoxStyle.Critical, "Exist already.")
                                .Rows(x).Clear(ClearFlags.Content)
                            End If
                        Next
                    End If
                Next
            End With
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Sub loadtoFlexcel(ByVal a As String, ByVal b As Integer, ByVal row As Integer, Optional ByVal x As String = "")
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
                With OrderListOfItems
                    If reader.Read = True Then
                        .Item(row, "ItemID") = reader.Item("ItemID")
                        .Item(row, "ItemName") = reader.Item("ItemName")
                        .Item(row, "UOM") = reader.Item("UOM")
                        .Item(row, "PaperContent") = reader.Item("PaperContent")
                    Else
                        .Item(row, "ItemID") = Nothing
                        .Item(row, "ItemName") = Nothing
                        .Item(row, "UOM") = Nothing
                        .Item(row, "PaperContent") = Nothing
                    End If
                End With
            ElseIf b = 2 Then
                With OrderListOfItems
                    If reader.Read = True Then
                        .Item(row, "ItemID") = reader.Item("ItemID")
                        .Item(row, "ItemCode") = reader.Item("ItemCode")
                        .Item(row, "UOM") = reader.Item("UOM")
                        .Item(row, "PaperContent") = reader.Item("PaperContent")
                        .AutoSizeCol(2)
                    Else
                        .Item(row, "ItemID") = Nothing
                        .Item(row, "ItemCode") = Nothing
                        .Item(row, "UOM") = Nothing
                        .Item(row, "PaperContent") = Nothing
                    End If
                End With
            ElseIf b = 3 Then
                With OrderListOfItems
                    If reader.Read = True Then
                        .Item(row, "ItemID") = reader.Item("ItemID")
                        .Item(row, "ItemName") = reader.Item("ItemName")
                        .Item(row, "ItemCode") = reader.Item("ItemCode")
                        .Item(row, "PaperContent") = reader.Item("PaperContent")
                        .Item(row, "UOM") = reader.Item("UOM")
                        .AutoSizeCol(2)
                    Else
                        .Item(row, "ItemID") = Nothing
                        .Item(row, "PaperContent") = Nothing
                        .Item(row, "ItemName") = Nothing
                        .Item(row, "ItemCode") = Nothing
                        .Item(row, "UOM") = Nothing
                    End If
                End With
            End If
            con.Close()
            command.Dispose()
            reader.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public SalesBookingID As String = ""
    Public isOrdered As Boolean = False

    Private Sub performDeleteOrder()
        If OrderListOfItems.Rows.Count - 1 = 0 Then Exit Sub
        With OrderListOfItems
            .Selection.Clear(ClearFlags.Content)
            If .Selection.ContainsCol(.Cols("ItemName").SafeIndex) = True Or _
                OrderListOfItems.Selection.ContainsCol(.Cols("UOM").SafeIndex) = True Or _
                OrderListOfItems.Selection.ContainsCol(.Cols("ItemCode").SafeIndex) = True Then
                'For a As Integer = .Selection.TopRow To .Selection.BottomRow
                '    loadtoFlexcel("SELECT * from Items where Active=1 and ItemCode='" & OrderListOfItems.Item(a, 2) & "'", 1, a)
                'Next
            End If
        End With
    End Sub
    Private Sub OrderListOfItems_EnterCell(ByVal sender As Object, ByVal e As System.EventArgs) Handles OrderListOfItems.EnterCell
        Try
            Me.LineRow.Text = "Line : " & Me.OrderListOfItems.RowSel & "  Column : " & Me.OrderListOfItems.Cols(OrderListOfItems.ColSel).Caption
            Me.LineRow.Visible = True
            With OrderListOfItems
                If .IsCellSelected(.RowSel, 4) = True And UseItemCodeforCoding.Pressed = False Then
                    setup(4, .RowSel)
                    If .Item(.RowSel, "Itemname") <> "" Then
                        .Cols("ItemName").AllowEditing = True
                    Else
                        If .Item(.RowSel, "FilterItem") = "" And .Item(.RowSel, "Itemname") = "" Then
                            .Cols("ItemName").AllowEditing = False
                            Exit Sub
                        Else
                            .Cols("ItemName").AllowEditing = True
                        End If
                        .StartEditing()
                    End If
                ElseIf .IsCellSelected(.RowSel, .Cols("FilterItem").Index) Then
                    .StartEditing()
                ElseIf .IsCellSelected(.RowSel, .Cols("Quantity").Index) Then
                    If .Item(.RowSel, "ItemID") <> 0 Then
                        .Cols("Quantity").AllowEditing = True
                        If .Item(.RowSel, "Quantity") <> 0 Then
                        Else
                            .StartEditing()
                        End If
                    Else
                        .Cols("Quantity").AllowEditing = False
                    End If
                ElseIf .IsCellSelected(.RowSel, .Cols("PaperContent").Index) Then
                    If .Item(.RowSel, "ItemID") <> 0 Then
                        .Cols("PaperContent").AllowEditing = True
                        If .Item(.RowSel, "paperContent") <> Nothing Then
                        Else
                            .StartEditing()
                        End If
                    Else
                        .Cols("PaperContent").AllowEditing = False
                    End If
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Sub setup(ByVal col As Integer, ByVal row As Integer)
        Try
            If OrderListOfItems.Item(row, "FilterItem") = "" Then
                loadcombo("SELECT ITEMNAME from Items where ItemID=0  AND ACTIVE=1 group by ItemName order by ItemName", ListOfItems)
                Exit Sub
            End If
            Dim x() As String = Split(OrderListOfItems.Item(row, "FilterItem"), " ")
            Dim ConditionOfQuery As String = ""
            For a As Integer = 0 To x.Length - 1
                If x.Length = 0 Then
                    ConditionOfQuery = " ITEMNAME LIKE '%" & convertQuotes(x(a)) & "%' "
                Else
                    If a = 0 Then
                        ConditionOfQuery = " ITEMNAME LIKE '%" & convertQuotes(x(a)) & "%' "
                    Else
                        ConditionOfQuery = ConditionOfQuery & " AND ITEMNAME LIKE '%" & convertQuotes(x(a)) & "%' "
                    End If
                End If
            Next
            loadcombo("SELECT ITEMNAME from Items where " & ConditionOfQuery & "  AND ACTIVE=1 group by ItemName order by ItemName", ListOfItems)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub OrderListOfItems_AfterEdit(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) Handles OrderListOfItems.AfterEdit
        Try
            With OrderListOfItems
                If e.Col = 2 Then 'this is for item code editing
                    loadtoFlexcel("SELECT *, (Select ItemName from Items x, BillOfMaterials y where x.ItemID=y.BOMItemID and y.ItemID=z.ItemID) as PaperContent from Items z where Active=1 and ItemCode='" & .Item(e.Row, e.Col) & "'", 1, e.Row)
                    .AutoSizeCol(e.Col)
                ElseIf e.Col = 4 Then
                    If UseItemCodeforCoding.Pressed = False Then
                        loadtoFlexcel("SELECT *, (Select ItemName from Items x, BillOfMaterials y where x.ItemID=y.BOMItemID and y.ItemID=z.ItemID) as PaperContent from Items z where Active=1 and ItemName='" & convertQuotes(.Item(e.Row, e.Col)) & "'", 2, e.Row)
                        .AutoSizeCol(e.Col)
                    End If
                End If
            End With
        Catch ex As Exception

        End Try

    End Sub
    Private Sub OrderListOfItems_ValidateEdit(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.ValidateEditEventArgs) Handles OrderListOfItems.ValidateEdit
        Try
            With Me.OrderListOfItems
                If e.Col = 2 Then
                    Dim filterSearch As String = ""
                    filterSearch = OrderListOfItems.Editor.Text
                    For a As Integer = 1 To .Rows.Count - 1
                        If e.Row = a Or .Item(a, 2) = String.Empty Then
                        Else
                            If filterSearch = .Item(a, 2) Then
                                MsgBox("The Item Code  '" & filterSearch & "' exists already.", MsgBoxStyle.Critical, "Exist already.")
                                e.Cancel = True
                                Exit Sub
                            End If
                        End If
                    Next
                ElseIf e.Col = 4 And UseItemCodeforCoding.Pressed = False Then
                    Dim filterSearch As String = ""
                    filterSearch = OrderListOfItems.Editor.Text
                    For a As Integer = 1 To .Rows.Count - 1
                        If e.Row = a Or .Item(a, 4) = String.Empty Then
                        Else
                            If filterSearch = .Item(a, 4) Then
                                MsgBox("The Item Name  '" & filterSearch & "' exists already.", MsgBoxStyle.Critical, "Exist already.")
                                e.Cancel = True
                                Exit Sub
                            End If
                        End If
                    Next
                ElseIf e.Col = .Cols("Quantity").SafeIndex Then
                    Dim filterSearch As String = OrderListOfItems.Editor.Text.Replace(",", "")
                    If Not IsNumeric(filterSearch.Replace(", ", "")) Or Val(filterSearch.Replace(", ", "")) <= 0 Then
                        MessageBox.Show("Invalid quantity to '" & .Item(e.Row, "ItemName"), "Invalid quantity.", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        .Select(e.Row, .Cols("Quantity").Index)
                        e.Cancel = True
                        Exit Sub
                    End If
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub OrderListOfItems_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrderListOfItems.Enter
        If Me.SaveJobOrder.Visible = False Then Exit Sub
        Me.RibbonOrderListOfItems.Enabled = True
    End Sub
    Private Sub OrderListOfItems_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.RibbonOrderListOfItems.Enabled = False
        '  Me.LineRow.Visible = False
    End Sub
#End Region
    Private _synchronizing As Boolean = False
    Private Sub USeItemCode_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        With OrderListOfItems
            If UseItemCodeforCoding.Pressed = False Then
                .Cols("FilterItem").Visible = True : .Cols("ItemName").AllowEditing = True : .Cols("ItemCode").AllowEditing = False
            Else
                .Cols("FilterItem").Visible = False : .Cols("ItemName").AllowEditing = False : .Cols("ItemCode").AllowEditing = True
            End If
        End With
    End Sub
#Region "Ribbon Controls"
    Private Sub SetNumberOfRows_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetNumberOfRows.Click
        Dim strRows As String
        Dim intRows As Integer
        strRows = InputBox("Please input the number of rows", "Set no. of rows", CStr(OrderListOfItems.Rows.Count - 1))
        If strRows = "" Then
            Return
        End If
        intRows = Val(strRows)
        If intRows = OrderListOfItems.Rows.Count - 1 Or intRows < 1 Or intRows > 10000000 Then
        Else
            OrderListOfItems.Rows.Count = intRows + 1
        End If
    End Sub
    Private Sub ClearContentsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearContentsButton.Click
        performDeleteOrder()
    End Sub
    Private Sub InsertRowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InsertRowButton.Click
        Try
            Me.OrderListOfItems.Rows.Insert(Me.OrderListOfItems.Selection.TopRow)
        Catch ex As Exception
            Me.OrderListOfItems.Rows.Add()
        End Try
    End Sub
    Private Sub DeleteRowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteRowButton.Click
        Try
            With Me.OrderListOfItems
                Dim x As Integer = .Selection.TopRow
                Dim y As Integer = .Selection.BottomRow

                For a As Integer = x To y
                    .Rows.Remove(x)
                Next
            End With
        Catch ex As Exception
        End Try
    End Sub
    Private Sub RibbonTrackBar1_ValueChanged() Handles Me.Load, FontName.TextChanged, FontSize.ValueChanged
        Try
            MainLauncher(0)
            With Me.OrderListOfItems
                .Font = New Font(Me.FontName.Text, Me.FontSize.Value)
                .Cols("ItemCode").StyleDisplay.Font = New Font(Me.FontName.Text, Me.FontSize.Value)
                .Cols("FilterItem").StyleDisplay.Font = New Font(Me.FontName.Text, Me.FontSize.Value)
                .Cols("Quantity").StyleDisplay.Font = New Font(Me.FontName.Text, Me.FontSize.Value, FontStyle.Bold)
                .Cols("ItemName").StyleDisplay.Font = New Font(Me.FontName.Text, Me.FontSize.Value)
                .Cols("PaperContent").StyleDisplay.Font = New Font(Me.FontName.Text, Me.FontSize.Value)
                .Rows(0).StyleDisplay.Font = New Font("Tahoma", Me.FontSize.Value + 1, FontStyle.Bold)
                .AutoSizeCols()
            End With
            With Me.BookingHistoryGrid
                .Font = Me.OrderListOfItems.Font
                .Styles.Fixed.Font = New Font(Me.FontName.Text, Me.FontSize.Value + 1, FontStyle.Bold)
                .AutoSizeCols()
            End With
            MainLauncher(1)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub ClearContentsButton_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearContentsButton.Click
        Me.OrderListOfItems.Selection.Clear(C1.Win.C1FlexGrid.ClearFlags.Content)
    End Sub
    Private Sub NewSalesOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewSalesOrder.Click
        clearing()
    End Sub
    Private Sub clearing()
        Me.toSave = True
        Me.JoReference.Text = Nothing
        '  Me.JobOrderDate.Text = Nothing
        Me.JOLocation.SelectedIndex = -1
        Me.JoType.SelectedIndex = -1
        Me.PurposeOFThisJO.Text = Nothing

        Me.OrderListOfItems.Rows.Count = 1
        Me.OrderListOfItems.Rows.Count = 15

        performReadOnly(True)
        Me.OrderListOfItems.Enabled = True
        Me.SaveJobOrder.Enabled = True

        Me.SalesBookingID = ""
        Me.isOrdered = False
        Me.JobOrderDate.Focus()
    End Sub

    Public Sub performReadOnly(ByVal a As Boolean)
        With Me
            .JOLocation.Enabled = a
            .PurposeOFThisJO.ReadOnly = Not a
            .JoType.Enabled = a
            .JobOrderDate.ReadOnly = Not a
        End With

    End Sub
#End Region
    Private Function validateGridInputs() As Boolean
        Try
            With OrderListOfItems
                Dim start As Integer = 1
                Dim endgrid As Integer = Me.OrderListOfItems.Rows.Count - 1
                For start = 1 To endgrid
                    If .Item(start, "ItemID") = Nothing Then
                    Else
                        If Not IsNumeric(.Item(start, "Quantity")) Or Val(.Item(start, "Quantity")) <= 0 Then
                            MessageBox.Show("Invalid quantity to '" & .Item(start, "ItemName"), "Invalid quantity.", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                            .Select(start, .Cols("Quantity").Index)
                            Return False
                            Exit Function
                        End If
                    End If
                Next
            End With
        Catch ex As Exception
            Return False
            MessageBox.Show("Error to validateGridInputs.")
            Exit Function
        End Try
        Return True
    End Function
    Private Function validateGridNotNull() As Boolean
        Try
            With OrderListOfItems
                Dim start As Integer = 1
                Dim endgrid As Integer = Me.OrderListOfItems.Rows.Count - 1
                For start = 1 To endgrid
                    If .Item(start, "ItemID") <> Nothing Then
                        Return False
                        Exit Function
                    End If
                Next
            End With
            MessageBox.Show("You are required to input list of items", "Required items", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Me.OrderListOfItems.Focus()
            Return True
        Catch ex As Exception
            MessageBox.Show("Error to ValidateGridNotNull.")
            Return False
            Exit Function
        End Try
    End Function
    Private Sub showMessage(ByVal a As String)
        MessageBox.Show(a, "Required field", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Me.StatusLabel.Text = a
    End Sub
    Private Function convertQuotes(ByVal a As String) As String
        Return MySqlHelper.EscapeString(a)
    End Function
    Public Sub loadtoOrderlistItems(ByVal sql As String, ByVal y As Integer)
        Try
            connect()
            con.Open()
            pagingAdapter = New MySqlDataAdapter(sql, con)
            ds = New DataSet
            pagingAdapter.Fill(ds)
            con.Close()
            If y = 1 Then
                If ds.Tables(0).Rows.Count < 0 Then Exit Sub
                Dim a As Integer = 1
                Dim b As Integer = ds.Tables(0).Rows.Count
                Me.OrderListOfItems.Rows.Count = b + 1
                For a = 1 To b
                    With OrderListOfItems
                        .Item(a, "ItemID") = ds.Tables(0).Rows(a - 1).Item("ItemID")
                        .Item(a, "ItemCode") = ds.Tables(0).Rows(a - 1).Item("ItemCode")
                        .Item(a, "ItemName") = ds.Tables(0).Rows(a - 1).Item("ItemName")
                        .Item(a, "UnitPrice") = ds.Tables(0).Rows(a - 1).Item("UnitPrice")
                        .Item(a, "UOM") = ds.Tables(0).Rows(a - 1).Item("UOM")
                        .Item(a, "Quantity") = ds.Tables(0).Rows(a - 1).Item("Quantity")
                        .AutoSizeCols()
                    End With
                Next

            Else
                If ds.Tables(0).Rows.Count < 0 Then
                Else
                    With ds.Tables(0).Rows(0)

                        ' Me.JoType.Text = .Item("Type")
                        'Me.JobOrderDate.Text = .Item("JoDate")
                        'Me.PurposeOFThisJO.Text = .Item("Purpose")
                        'Me.JoReference.Text = "JO " & AdjustmentID.ToString("d10")
                    End With
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub CloseForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseForm.Click
        Me.Close()
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Me.toSave = True Then Me.JobOrderDate.Value = Now
    End Sub
    Private Function ValidateParentID(ByVal a As String, ByVal b As Integer) As Integer
        Try
            command = New MySqlCommand
            If con.State = ConnectionState.Open Then con.Close()
            connect()
            con.Open()
            With command
                .CommandText = a
                .Connection = con
                reader = .ExecuteReader
            End With
            If b = 1 Then
                If reader.Read = True Then
                    Dim X As Integer = reader.Item("Auto_Increment")
                    Return X
                End If
                con.Close()
                command.Dispose()
                reader.Close()
            End If
        Catch ex As Exception
        End Try
        Return 1
    End Function
    Public Sub loadSalesOrders(ByVal Query As String)
        Try
            FunctionClass.loadtoGrid("Select y.SalesBookingRequestID, x.SalesOrderID, Concat('SO ', x.SalesOrderID) as SOReference, x.DateOrdered, CustomerName, y.BookedQty, '' from " & _
                                     " SalesOrder x, SalesOrderOrders x1, Customers c1, SalesBookingQtyRequested y WHERE x.SalesOrderID=x1.SalesOrderID AND  y.isJo=0 AND " & _
                                     " x.CustomerID=c1.CustomerID  AND x1.OrderID=y.OrderID " & Query & " Group by y.SalesBookingRequestID Order by x.SalesOrderID, CustomerName", Me.BookingHistoryGrid)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub SaveSalesOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveJobOrder.Click

        If Me.JobOrderDate.Text = "" Then MessageBox.Show("JO date is required..", "Field required", MessageBoxButtons.OK, MessageBoxIcon.Stop) : Me.JobOrderDate.Focus() : Exit Sub
        If Me.JoType.Text.Replace(" ", "") = Nothing Then MessageBox.Show("Job Order type is required.", "Field required", MessageBoxButtons.OK, MessageBoxIcon.Stop) : Me.JoType.Focus() : Exit Sub
        If Me.JOLocation.Text.Replace(" ", "") = Nothing Then MessageBox.Show("Location is required", "Field required", MessageBoxButtons.OK, MessageBoxIcon.Stop) : Me.JOLocation.Focus() : Exit Sub
        If Me.PurposeOFThisJO.Text.Replace(" ", "") = "" Then MessageBox.Show("Purpose of adjustment is required.", "Field required", MessageBoxButtons.OK, MessageBoxIcon.Stop) : Me.PurposeOFThisJO.Focus() : Exit Sub
        If validateGridNotNull() = True Then Exit Sub
        If validateGridInputs() = False Then Exit Sub
        If Me.toSave = True Then
            Me.JoReference.Text = "JO " & ValidateParentID("SELECT AUTO_INCREMENT FROM Information_schema.tables where  table_schema='" & database & "' and table_name='JobOrder';", 1).ToString("d10")
            Dim x As Integer = Val(Me.JoReference.Text.Replace("JO ", ""))
            MainLauncher(0)
            If SaveCommand("INSERT INTO JOBORDER(JODATE, TYPE, SourceID, PURPOSE, ISJOCOMPLETED, EmployeeID, CreatorNTUser, DateCreated, lastUpdate, Changesmade)" & _
                        "VALUES (@JODATE,@Type,  @Location, @PURPOSE, 0, @EmployeeID, @CreatorNtUser, @DateCreated, 'NONE', @ChangesMade)", "Created ") = True Then
                SaveCommand("DELETE FROM JOBORDERITEMS WHERE JOBORDERID='" & x & "'", "wala")
                saveOrders(x)
                Me.toSave = False
                Me.JoReference.Text = "JO " & x.ToString("d10")
                ' If isToRefreshJobOrderOrdered = True Then JObOrderOrdered.refreshMe()
            End If
        Else
            MainLauncher(0)
            Dim x As Integer = Val(Me.JoReference.Text.Replace("JO ", ""))
            If SaveCommand("UPDATE JOBORDER SET JODATE=@JODATE, TYPE=@TYPE," & _
                           "SourceID=@Location, PURPOSE=@PURPOSE, CHANGESMADE= Concat(@ChangesMade " & _
                           vbCrLf & vbCrLf & ", Changesmade), LastUpdate=@LastUpdate WHERE JOBORDERID=@JOBORDERID", "Updated ") = True Then
                SaveCommand("DELETE FROM JOBORDERITEMS WHERE JOBORDERID='" & x & "'", "wala")
                saveOrders(x)
                '  If isToRefreshJobOrderOrdered = True Then JObOrderOrdered.refreshMe()
            End If
        End If
        MainLauncher(1)
    End Sub
    Public JoID As Integer = 0
    Private Sub saveOrders(ByVal a As Integer)
        Dim x As Integer = 1
        Dim y As Integer = Me.OrderListOfItems.Rows.Count - 1
        With OrderListOfItems
            For x = 1 To y
                If .Item(x, "ItemID") = Nothing Then Continue For
                saveEditDelete("INSERT INTO JOBORDERITEMS  (JobOrderiD, ItemID, UOM,  JOQuantity, RemainingQty, PaperContent) Values ('" & a & _
                               "', '" & .Item(x, "ItemID") & "', '" & .Item(x, "UOM") & "', '" & .Item(x, "Quantity") & _
                               "', '" & .Item(x, "Quantity") & "', '" & convertQuotes(.Item(x, "PaperContent")) & "')", "wala")
            Next
        End With
        With Me.BookingHistoryGrid
            saveEditDelete("INSERT INTO JobOrderSO (SalesOrderID, JobOrderID, QuantityAllocated, SalesBookingRequestID) " & _
                           " VALUES " & saveOrders2(a, BookingHistoryGrid), "wala")
            saveEditDelete("Update SalesBookingQtyRequested x, JobOrderSO y Set x.isJO=1 Where x.SalesBookingRequestID=y.SalesBookingRequestID AND x.isJO=0 AND  " & _
                           " y.JobOrderID=" & a, "wala")
        End With
    End Sub
    Private Function saveOrders2(ByVal a As Integer, ByVal flexgrid As C1.Win.C1FlexGrid.C1FlexGrid) As String
        Dim z11 As String = ""
        Try
            MainLauncher(0)
            Dim x As Integer = 1
            Dim y As Integer = flexgrid.Rows.Count - 1
            For x = 1 To y
                With flexgrid.Rows(x)
                    Dim itemre As String = ""
                    z11 = z11 & " " & "('" & .Item("SalesOrderID") & "', '" & a & "', '" & .Item("Quantity") & _
                               "', '" & .Item("SalesBookingRequestID") & "')            "
                End With
            Next
        Catch ex As Exception
        End Try
        Return LTrim(RTrim(z11)).Replace("            ", ",")
    End Function
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1Button1.Click
        Me.C1SplitterPanel3.Visible = Not Me.C1SplitterPanel3.Visible
        If Me.C1SplitterPanel3.Visible = True Then Me.C1Button1.Image = My.Resources.upload Else Me.C1Button1.Image = My.Resources.download
    End Sub
    Private Function SaveCommand(ByVal a As String, ByVal b As String) As Boolean
        Try
            command = New MySqlCommand
            connect()
            con.Open()
            With command
                .CommandText = a
                .Connection = con
                With .Parameters
                    .AddWithValue("@JobOrderID", Me.JoReference.Text.Replace("JO ", ""))
                    .AddWithValue("@JODate", Format(Me.JobOrderDate.Value, "yyyy-MM-dd"))
                    .AddWithValue("@Location", Me.JOLocation.SelectedValue)
                    .AddWithValue("@Purpose", Me.PurposeOFThisJO.Text.ToUpper)
                    .AddWithValue("@Type", Me.JoType.Text.ToUpper)
                    .AddWithValue("@EmployeeID", APCESMainForm.EmployeeID.Text)
                    .AddWithValue("@CreatorNTUser", APCESMainForm.UserFullName.Text.ToUpper)
                    .AddWithValue("@DateCreated", "" & Now)
                    .AddWithValue("@LastUpdate", "" & Now)
                    '  .AddWithValue("@ChangesMade", b & " on " & Now & " at " & BakeTechMainForm.ComputerName.Text & " by " & baketechmainform.EmployeeName.Text)
                End With
                .ExecuteNonQuery()
            End With
            If b = "wala" Then
            Else
                MessageBox.Show("The record has been successfully saved.", "Command executed!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
            command.Dispose()
            Return True
            Exit Function
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
            Exit Function
        End Try
    End Function

    Private Sub RibbonButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RibbonButton5.Click
        If Me.FontSize.Value <= 1 Then Exit Sub
        Me.FontSize.Value = Me.FontSize.Value - 1
    End Sub

    Private Sub RibbonButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RibbonButton3.Click
        Me.FontSize.Value = Me.FontSize.Value + 1
    End Sub

    Private Sub OrderListOfItems_SetupEditor(ByVal sender As System.Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) Handles OrderListOfItems.SetupEditor
        If e.Col = Me.OrderListOfItems.Cols("PaperContent").Index Then
            Me.OrderListOfItems.Editor.Height = 50
        End If
    End Sub
End Class
