Imports MySql.Data.MySqlClient
Public Class CompanyAllowanceSetUp
    Private tosave As Boolean = True
    Private EarningSetupid As Integer
    Private ds As DataSet = New DataSet
    Dim pagingAdapter As MySqlDataAdapter
    Dim pagingDS As DataSet
#Region "Ribbon Controls"
    Private Sub RibbonTrackBar1_ValueChanged() Handles FontName.TextChanged, FontSize.ValueChanged
        Try
            MainLauncher(0)
            Me.C1InputPanel2.Font = New Font("Tahoma", Me.FontSize.Value + 1, FontStyle.Regular)
            With Me.C1flexgrid1
                .Font = New Font(Me.FontName.Text, Me.FontSize.Value)
                '.Cols("ItemCode").StyleDisplay.Font = New Font(Me.FontName.Text, Me.FontSize.Value)
                '.Cols("Quantity").StyleDisplay.Font = New Font(Me.FontName.Text, Me.FontSize.Value, FontStyle.Bold)
                '.Cols("ItemName").StyleDisplay.Font = New Font(Me.FontName.Text, Me.FontSize.Value)
                .Rows(0).StyleDisplay.Font = New Font("Tahoma", Me.FontSize.Value + 1, FontStyle.Bold)
                .AutoSizeCols()
            End With
            MainLauncher(1)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub RibbonButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RibbonButton5.Click
        If Me.FontSize.Value <= 1 Then Exit Sub
        Me.FontSize.Value = Me.FontSize.Value - 1
    End Sub

    Private Sub RibbonButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RibbonButton3.Click
        Me.FontSize.Value = Me.FontSize.Value + 1
    End Sub
    Private Sub SetNumberOfRows_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetNumberOfRows.Click
        Dim strRows As String
        Dim intRows As Integer
        strRows = InputBox("Please input the number of rows", "Set no. of rows", CStr(C1flexgrid1.Rows.Count - 1))
        If strRows = "" Then
            Return
        End If
        intRows = Val(strRows)
        If intRows = C1flexgrid1.Rows.Count - 1 Or intRows < 1 Or intRows > 10000000 Then
        Else
            C1flexgrid1.Rows.Count = intRows + 1
        End If
    End Sub
    Private Sub InsertRowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InsertRowButton.Click
        Try
            Me.C1flexgrid1.Rows.Insert(Me.C1flexgrid1.Selection.TopRow)
        Catch ex As Exception
            Me.C1flexgrid1.Rows.Add()
        End Try
    End Sub
    Private Sub DeleteRowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteRowButton.Click
        Try
            With Me.C1flexgrid1
                Dim x As Integer = .Selection.TopRow
                Dim y As Integer = .Selection.BottomRow

                For a As Integer = x To y
                    .Rows.Remove(x)
                Next
            End With
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ClearContentsButton_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearContentsButton.Click
        Me.C1flexgrid1.Selection.Clear(C1.Win.C1FlexGrid.ClearFlags.Content)
    End Sub

    Private Sub OrderListOfItems_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1flexgrid1.Enter
        If Me.SaveJobOrder.Visible = False Then Exit Sub
        Me.RibbonOrderListOfItems.Enabled = True
    End Sub
    Private Sub OrderListOfItems_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1flexgrid1.Leave
        Me.RibbonOrderListOfItems.Enabled = False
        '  Me.LineRow.Visible = False
    End Sub
#End Region

    Private Function RecordDoExists(ByVal a As String) As Boolean
        Try
            command = New MySqlCommand
            connect()
            con.Open()
            With command
                .CommandText = a
                .Connection = con
                reader = .ExecuteReader
            End With
            If reader.Read = True Then Return True Else Return False
            Exit Function
        Catch ex As Exception
            Return False
            Exit Function
        End Try
    End Function

    '  Private Sub vessel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, SoRefresh.Click
    '  loadingReligions("Select EarningSetupID as ID, EarningSetup,  DateCreated,Creator from hris_EarningSetup order by EarningSetupid asc")
    ' tosave = True
    '  End Sub
    Public Sub loadingReligions(ByVal sql As String)
        Try
            MainLauncher(Me.C1flexgrid1, 0)
            connect()
            con.Open()
            pagingAdapter = New MySqlDataAdapter(sql, con)
            ds = New DataSet
            pagingAdapter.Fill(ds)
            pagingDS = New DataSet()
            pagingAdapter.Fill(pagingDS, "towns")
            con.Close()
            Me.C1flexgrid1.DataSource = pagingDS
            Me.C1flexgrid1.DataMember = "towns"
            formatdatagrid()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MainLauncher(Me.C1flexgrid1, 1)
        End Try
    End Sub
    Public Sub formatdatagrid()
        Dim start As New Timer
        With start
            .Interval = 1
            .Start()
        End With
        With Me.C1flexgrid1
            .AutoSizeCols()
            .AllowSorting = True
            ' .Item(0, 1) = "ID"
            ' .Cols("ChangesMade").Visible = False
            ' .AutoSizeCol(.Cols("Active").Index)
            .AllowFiltering = True
        End With
        start.Stop()
    End Sub

    Private Sub CloseForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseForm.Click
        Me.Close()
    End Sub

    Private Sub SaveJobOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveJobOrder.Click
        If Me.CompanyName.SelectedIndex = -1 Then MessageBox.Show("No Company Selected") : Exit Sub
        '  Try
        If RecordDoExists("Select * from companyAllowance where companyid='" & CompanyName.SelectedValue & "'") = True Then
            Dim vbresponse = MessageBox.Show("Allowance for this company has already been set-up." & vbNewLine & "Are you sure you want to continue with the update?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If vbresponse = vbNo Then Exit Sub
            savetoPayrollSetup()
        Else
            savetoPayrollSetup()
        End If
        FunctionClass.showMessage("The record has been successfully saved!", "Command Executed!", "Command executed")
        tosave = False
        ' Catch ex As Exception
        '      MessageBox.Show(ex.ToString)
        ' End Try
    End Sub
    Public Sub savetoPayrollSetup()
        Try
            Dim x As Integer = 1
            Dim y As Integer = C1flexgrid1.Rows.Count - 1
            For x = 1 To y
                With C1flexgrid1.Rows(x)
                    'Dim calc, gov, earn, deduct As Integer

                    If .Item("Allowance") = Nothing Then Continue For
                    If .Item("Allowanceid") = Nothing Then
                        saveEditDelete("Insert into CompanyAllowance (`companyid`,`Allowance`,`Amount`,`Order`,`Active`,`remarks`,`creator`,`changesmade`) values " & _
                                       " ('" & CompanyName.SelectedValue & "','" & .Item("Allowance").ToString.ToUpper & "','" & Val(.Item("Amount").ToString.ToUpper) & "','" & Val(.Item("Order")) & _
                                       "','" & toint(.Item("Active")) & "','" & .Item("Remarks") & "','" & APCESMainForm.UserFullName.Text & "','Originally created: " & convertQuotes(.Item("Allowance")) & vbCrLf & _
                                  "by " & convertQuotes(APCESMainForm.UserFullName.Text) & " on " & Now & "@ " & _
                                 convertQuotes(APCESMainForm.ComputerName.Text) & "')", "wala")

                    ElseIf .Item("Allowanceid") <> Nothing Then
                        saveEditDelete("update companyAllowance SET allowance= '" & _
                                   convertQuotes(.Item("allowance").ToString.ToUpper) & _
                                "', Amount='" & Val(.Item("amount")) & _
                                 "', companyid='" & CompanyName.SelectedValue & _
                                "', Active='" & toint(.Item("Active")) & _
                                "', `Order`='" & Val(.Item("Order")) & _
                                "', ChangesMade=Concat('Updated to: " & MySqlHelper.EscapeString(.Item("Allowance")) & vbCrLf & _
                                 "by " & _
                                 APCESMainForm.UserFullName.Text & " at " & Now & _
                                 "@ " & APCESMainForm.ComputerName.Text & _
                                 vbCrLf & vbCrLf & "-->'" & _
                                 ", ChangesMade) WHERE Allowanceid='" & .Item("Allowanceid") & "'", "wala")
                    End If

                End With
            Next
            FunctionClass.loadtoGrid("Select Allowanceid,  Allowance,Amount, Active,`Order`,Remarks from companyAllowance where companyid='" & CompanyName.SelectedValue & "'", C1flexgrid1)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub HRIS_EarningSetup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadingvaluestoComboBoxes("Select * from company where companyid<>0 ", CompanyName, "CompanyName", "CompanyID")
        Me.CompanyName.SelectedValue = companyid
        FunctionClass.loadtoGrid("Select Allowanceid,  Allowance,Amount, Active,`Order`,Remarks from companyAllowance where companyid='" & companyid & "'", C1flexgrid1)
    End Sub

    Private Sub C1flexgrid1_AfterEdit(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) Handles C1flexgrid1.AfterEdit
        Dim x As Integer = 1
        Dim y As Integer = C1flexgrid1.Rows.Count - 1
        For x = 1 To y
            With C1flexgrid1.Rows(x)
                If .Item("Amount") = Nothing Then .Item("Amount") = 0
                If .Item("order") = Nothing Then .Item("order") = 0
                If .Item("aCTIVE") = Nothing Then .Item("aCTIVE") = True
            End With
        Next
    End Sub

    Private Sub Load_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Load.Click
        Try
            'FunctionClass.loadtoGrid("Select Allowanceid, PayType, Allowance,Compute,Government,Income,Deduction,Active,`Order`,Remarks from companyAllowance where companyid='1'", C1flexgrid1)
            FunctionClass.loadtoGrid("Select Allowanceid,  Allowance,Amount, Active,`Order`,Remarks from companyAllowance where companyid='" & CompanyName.SelectedValue & "'", C1flexgrid1)
        Catch ex As Exception
            '  MessageBox.Show(ex.Message)
            Me.C1flexgrid1.Rows.Count = 10
        End Try
    End Sub
    Private Sub ViewItemHistory_Click() Handles SOViewRecord.Click
        Try
            Dim i As Integer = Me.C1flexgrid1.RowSel
            Dim ID As Integer = Me.C1flexgrid1.Rows(i).Item("Allowanceid")
            Dim x As New HistoryUpdate
            With x
                .loaddata("companyAllowance", "Allowanceid", ID)
                .Text = "Item history of " & Me.C1flexgrid1.Item(i, "PayType")
                .StartPosition = FormStartPosition.CenterParent
                .ShowDialog()
            End With
        Catch ex As Exception
            MessageBox.Show("No record selected")
        End Try
    End Sub
End Class