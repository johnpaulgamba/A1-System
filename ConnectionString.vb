Imports MySql.Data.MySqlClient
Imports C1.Win.C1Win7Pack.C1TaskDialog
Imports C1.Win.C1Win7Pack
Imports C1.Win.C1FlexGrid
Imports System.Windows.Forms
Imports C1.Win.C1Command
Module ConnectionString
    Public MaximumToDisplay As Integer = 1000
    Public IsNotError As Boolean = False
    Public companyid As Integer = 1
    Public database As String = "hris"
    Public UserID As String = "johnpaul"
    Public Password As String = "PoYgI143321"
    'Public ServerHost As String = "192.168.1.221"
    Public ServerHost As String = "127.0.0.1"
    Public con As New MySqlConnection
    Public reader As MySqlDataReader
    Public command As MySqlCommand
    Public Sub connect()
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            Else
                With con
                    .ConnectionString = "SERVER=" & ServerHost & ";UID=" & UserID & ";Password=" & Password & ";Database=" & database
                    ' .ConnectionString = "SERVER=localhos1t;UID=root;Password=a;Database=baketechdb"
                    .Open()
                End With
                con.Close()
                con.Dispose()
            End If
        Catch ex As Exception
            showMessage(ex.Message, "exception found", "contact system admin", 1)
        End Try
    End Sub
    Public Sub showMessage(ByVal Content As String, ByVal mainInstruc As String, ByVal WindowTitle As String, ByVal Type As Integer)
        Select Case Type
            Case 1
                MessageBox.Show(mainInstruc & vbNewLine & Content, WindowTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Case 2
                MessageBox.Show(mainInstruc & vbNewLine & Content, WindowTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 3
                MessageBox.Show(mainInstruc & vbNewLine & Content, WindowTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 4
                MessageBox.Show(mainInstruc & vbNewLine & Content, WindowTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Select
    End Sub
    Public Function searchRecord(ByVal a As String, ByVal b As Integer) As Integer
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
                    Dim X As Integer = reader.Item("Auto_Increment")
                    Return X
                    con.Close() : command.Dispose() : reader.Close()
                    Exit Function
                End If
            End If
        Catch ex As Exception
        End Try
        Return 0
    End Function
    Public Function Get_data(ByVal a As String, ByVal b As Integer) As String
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
                    Dim X As String = reader.Item("data")
                    Return X
                    command.Dispose() : reader.Close() : con.Close()
                    Exit Function
                End If
            End If
        Catch ex As Exception
            ''messagebox.show(ex.message)
        End Try
        Return ""
    End Function
    Public Function convertQuotes(ByVal text1 As String) As String
        Return MySqlHelper.EscapeString(text1)
    End Function

    Public Sub loaddata(ByVal Sql As String, ByVal FilterQuery As String, ByVal flexgrid As C1FlexGrid)
        Try
            connect()
            con.Open()
            Dim ds As New DataSet
            Dim adapter As New MySqlDataAdapter(Sql, con)
            With adapter
                .SelectCommand.CommandType = CommandType.StoredProcedure
                .SelectCommand.Parameters.AddWithValue("@FilterQuery", FilterQuery)
                .Fill(ds)
                .Dispose()
            End With
            con.Close()
            With flexgrid
                .Redraw = False
                .DataSource = ds.Tables(0)
                .Styles.EmptyArea.BackColor = Color.White
                .Styles.EmptyArea.Border.Style = C1.Win.C1FlexGrid.BorderStyleEnum.None
                .Styles.Alternate.BackColor = Color.White
                .Styles.Alternate.Border.Direction = BorderDirEnum.Both
                .Styles.Alternate.Border.Color = Color.Gray
                .Styles.Alternate.ForeColor = Color.Black
                .Styles.Alternate.Border.Style = C1.Win.C1FlexGrid.BorderStyleEnum.Dotted
                .Styles.Normal.BackColor = Color.White
                .Styles.Normal.Border.Direction = BorderDirEnum.Both
                .Styles.Normal.Border.Color = Color.Gray
                .Styles.Normal.Border.Style = C1.Win.C1FlexGrid.BorderStyleEnum.Dotted
                .Styles.Normal.ForeColor = Color.Black
                .SelectionMode = SelectionModeEnum.Row
                .FocusRect = FocusRectEnum.None
                .ExtendLastCol = True
                If .Cols.Fixed = 1 Then
                    .Cols(1).Visible = False
                Else
                    .Cols(0).Visible = False
                End If

                .Redraw = True
            End With
            formatGrid(flexgrid)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub formatGrid(ByVal grid As C1FlexGrid)
        With grid
            .Styles.Normal.Font = New Font(APCESMainForm.RibbonFontComboBox1.Text, APCESMainForm.statusTrackBar.Value, FontStyle.Regular)
            .Styles.Fixed.Font = New Font("Arial", APCESMainForm.statusTrackBar.Value, FontStyle.Bold)
            If grid.SelectionMode = SelectionModeEnum.Default Then .FocusRect = FocusRectEnum.Solid Else .FocusRect = FocusRectEnum.None
            '.Styles.EmptyArea.BackColor = StudentsMain.C1NavBarPanel1.BackColor
            .AutoSizeCols()
            .AutoSizeRows()
        End With
    End Sub
    Public Function DataGridView1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs, ByVal DataGridView1 As C1FlexGrid, ByVal C1ContextMenu1 As C1ContextMenu) As Integer
        If (e.Button = Windows.Forms.MouseButtons.Right) Then
            Dim x As Integer = DataGridView1.HitTest(e.Location.X, e.Location.Y).Row
            DataGridView1.Row = x
            Return x
            Exit Function
        End If
        Return 0
    End Function

    Public Sub saveEditDelete(ByVal a As String, ByVal b As String)
        command = New MySqlCommand
        Dim mytrans As MySqlTransaction
        connect()
        con.Open()
        mytrans = con.BeginTransaction()
        Try
            With command
                .CommandText = a
                .CommandType = CommandType.Text
                .Connection = con
                .CommandTimeout = 10000
                .Transaction = mytrans
                .ExecuteNonQuery()
                mytrans.Commit()
            End With
            If b = "wala" Then Exit Sub
            showMessage("The record has been successfully " & b & ".", "Command successfully executed", "Command executed", 3)
            IsNotError = False
        Catch ex As Exception
            IsNotError = True
            Try
                mytrans.Rollback()
            Catch ex1 As MySqlException
                If Not mytrans.Connection Is Nothing Then
                    showMessage("An exception of type " & ex1.GetType().ToString() & _
                                                " was encountered while attempting to roll back the transaction.", "Exception found", "Error", 1)
                End If
            End Try
            MessageBox.Show(ex.ToString)
            'showMessage(ex.Message, "Exception found!", "Contact system admin", 1)
        Finally
            con.Close()
            command.Dispose()
            con.Dispose()
        End Try
    End Sub
    Public Sub ExportGridData(ByVal datagridview1 As C1.Win.C1FlexGrid.C1FlexGrid)
        Try
            Dim saveFileDialog1 As New SaveFileDialog()
            saveFileDialog1.Filter = "Excel files (*.xls)|*.xls"
            saveFileDialog1.FilterIndex = 2
            saveFileDialog1.RestoreDirectory = True
            If saveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK And saveFileDialog1.FileName <> "" Then
                datagridview1.SaveExcel(saveFileDialog1.FileName, C1.Win.C1FlexGrid.FileFlags.IncludeFixedCells Or C1.Win.C1FlexGrid.FileFlags.VisibleOnly)
            Else
                Exit Sub
            End If
            showMessage("The file you have requested has been successfully exported to " & saveFileDialog1.FileName, "Export completed", "Export success!", 3)
        Catch ex As Exception
        End Try
    End Sub
    Public Sub loadingvaluestoComboBoxes_StoredProc(ByVal sql As String, ByVal a As C1.Win.C1InputPanel.InputComboBox, ByVal displaymem As String, ByVal valuemem As String)
        Try
            Dim PagAdapter As New MySqlDataAdapter
            Dim PagDS As New DataSet
            connect()
            con.Open()
            PagAdapter = New MySqlDataAdapter(sql, con)
            PagAdapter.SelectCommand.CommandType = CommandType.StoredProcedure
            PagDS = New DataSet
            PagAdapter.Fill(PagDS)
            con.Close()
            With a
                .Items.Clear()
                .DataSource = PagDS.Tables(0)
                .DisplayMember = displaymem.ToString
                .ValueMember = valuemem.ToString
                .SelectedIndex = -1
                If .Items.Count < 2 Then .GripHandleVisible = False Else .GripHandleVisible = True
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub loadingvaluestoComboBoxes(ByVal sql As String, ByVal a As C1.Win.C1InputPanel.InputComboBox, ByVal displaymem As String, ByVal valuemem As String)
        Try
            Dim PagAdapter As New MySqlDataAdapter
            Dim PagDS As New DataSet
            connect()
            con.Open()
            PagAdapter = New MySqlDataAdapter(sql, con)
            PagAdapter.SelectCommand.CommandType = CommandType.Text
            PagDS = New DataSet
            PagAdapter.Fill(PagDS)
            con.Close()
            With a
                .Items.Clear()
                .DataSource = PagDS.Tables(0)
                .DisplayMember = displaymem.ToString
                .ValueMember = valuemem.ToString
                .SelectedIndex = -1
                If .Items.Count < 2 Then .GripHandleVisible = False Else .GripHandleVisible = True
            End With
        Catch ex As Exception
        End Try
    End Sub
  
    Public Sub loadtoGrid(ByVal sql As String, ByVal b As C1.Win.C1FlexGrid.C1FlexGrid)
        Try
            Dim adapter As New MySqlDataAdapter
            Dim ds As New DataSet
            connect()
            con.Open()
            adapter = New MySqlDataAdapter(sql, con)
            ds = New DataSet
            adapter.Fill(ds)
            con.Close()
            con.Dispose()
            With b
                .Redraw = False
                .Rows.Count = ds.Tables(0).Rows.Count + 1
                .Cols.Count = ds.Tables(0).Columns.Count + 2
                Dim dr As DataRow, dc As DataColumn
                Dim rowIndex%, colIndex%
                rowIndex = 1
                For Each dr In ds.Tables(0).Rows
                    colIndex = 1
                    b(rowIndex, 0) = rowIndex
                    For Each dc In ds.Tables(0).Columns
                        b(rowIndex, colIndex) = dr(dc)
                        colIndex = colIndex + 1
                    Next
                    .Rows(rowIndex).Clear(ClearFlags.Style)
                    rowIndex = rowIndex + 1
                Next
                b.AutoSizeCols()
                .Redraw = True
            End With
        Catch ex As Exception
            ' MessageBox.Show(ex.Message)
            b.AutoSizeCols()
        Finally
        End Try
    End Sub
    Public Sub loadtoGridNoFixed(ByVal sql As String, ByVal b As C1.Win.C1FlexGrid.C1FlexGrid)
        Try
            Dim adapter As New MySqlDataAdapter
            Dim ds As New DataSet
            connect()
            con.Open()
            adapter = New MySqlDataAdapter(sql, con)
            ds = New DataSet
            adapter.Fill(ds)
            con.Close()
            con.Dispose()
            With b
                .Redraw = False
                .Rows.Count = ds.Tables(0).Rows.Count + 1
                ' .Cols.Count = ds.Tables(0).Columns.Count
                Dim dr As DataRow, dc As DataColumn
                Dim rowIndex%, colIndex%
                rowIndex = 1
                For Each dr In ds.Tables(0).Rows
                    colIndex = 0
                    For Each dc In ds.Tables(0).Columns
                        b(rowIndex, colIndex) = dr(dc)
                        colIndex = colIndex + 1
                    Next
                    .Rows(rowIndex).Clear(ClearFlags.Style)
                    rowIndex = rowIndex + 1
                Next
                b.AutoSizeCols()
                .Redraw = True
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            b.AutoSizeCols()
        Finally
        End Try
    End Sub
    Public Sub loadingvaluestoComboBoxes1(ByVal sql As String, ByVal a As ComboBox, ByVal displaymem As String, ByVal valuemem As String)
        Try
            Dim PagAdapter As New MySqlDataAdapter
            Dim PagDS As New DataSet
            connect()
            con.Open()
            PagAdapter = New MySqlDataAdapter(sql, con)
            PagAdapter.SelectCommand.CommandType = CommandType.Text
            PagDS = New DataSet
            PagAdapter.Fill(PagDS)
            con.Close()
            With a
                .Items.Clear()
                .DataSource = PagDS.Tables(0)
                .DisplayMember = displaymem.ToString
                .ValueMember = valuemem.ToString
                .SelectedIndex = -1
            End With
        Catch ex As Exception
            ''messagebox.show(ex.message)
        End Try
    End Sub
    Public Function FirstDayOfMonth(ByVal sourceDate As DateTime) As DateTime
        Return New DateTime(sourceDate.Year, sourceDate.Month, 1)
    End Function

    'Get the last day of the month
    Public Function LastDayOfMonth(ByVal sourceDate As DateTime) As DateTime
        Dim lastDay As DateTime = New DateTime(sourceDate.Year, sourceDate.Month, 1)
        Return lastDay.AddMonths(1).AddDays(-1)
    End Function
    Public Function toint(ByVal a As Boolean) As Integer
        If a = True Then Return 1 Else Return 0
    End Function
    Public Function semiperiodfrom(ByVal sourcedate As DateTime) As DateTime
        Dim cutoff As DateTime
        If sourcedate.Day >= 1 And sourcedate.Day <= 15 Then
            cutoff = New DateTime(sourcedate.Year, sourcedate.Month, 1)
        Else
            cutoff = New DateTime(sourcedate.Year, sourcedate.Month, 16)
        End If
        Return cutoff
    End Function
    Public Function semiperiodto(ByVal sourcedate As DateTime) As DateTime
        Dim cutoff As DateTime
        If sourcedate.Day >= 1 And sourcedate.Day <= 15 Then
            cutoff = New DateTime(sourcedate.Year, sourcedate.Month, 15)
        Else
            sourcedate = New DateTime(sourcedate.Year, sourcedate.Month, 1)
            cutoff = sourcedate.AddMonths(1).AddDays(-1)
        End If
        Return cutoff
    End Function
    Public Function semicutoffto(ByVal sourcedate As DateTime) As DateTime
        Dim cutoff As DateTime
        Try
            If sourcedate.Day >= 1 And sourcedate.Day <= 15 Then
                cutoff = New DateTime(sourcedate.Year, sourcedate.Month, 5)
            Else
                cutoff = New DateTime(sourcedate.Year, sourcedate.Month, 20)
            End If
        Catch ex As Exception
            If sourcedate.Day >= 1 And sourcedate.Day <= 15 Then
                cutoff = New DateTime(sourcedate.Year - 1, sourcedate.Month, 5)
            Else
                cutoff = New DateTime(sourcedate.Year - 1, sourcedate.Month, 20)
            End If
        End Try
        Return cutoff
    End Function
    Public Function semicutofffrom(ByVal sourcedate As DateTime) As DateTime
        Dim cutoff As DateTime
        Try
            If sourcedate.Day >= 1 And sourcedate.Day <= 15 Then
                cutoff = New DateTime(sourcedate.Year, sourcedate.Month - 1, 21)
            Else
                cutoff = New DateTime(sourcedate.Year, sourcedate.Month, 6)
            End If
        Catch ex As Exception
            cutoff = sourcedate.AddMonths(-1).AddDays(6)
        End Try
        Return cutoff
    End Function
  
    Public Function weeklyperiodfrom(ByVal sourcedate As DateTime) As DateTime
        Dim today As Date = sourcedate
        Dim dayDiff As Integer = today.DayOfWeek - DayOfWeek.Sunday
        Dim friday As Date = today.AddDays(-dayDiff)
        Return friday
    End Function
    Public Function weeklyperiodto(ByVal sourcedate As DateTime) As DateTime
        Dim today As Date = sourcedate
        Dim dayDiff As Integer = today.DayOfWeek - DayOfWeek.Saturday
        Dim thursday As Date = today.AddDays(-dayDiff)
        Return thursday
    End Function
    Public Function weeklycutofffrom(ByVal sourcedate As DateTime) As DateTime
        Dim today As Date = sourcedate
        Dim dayDiff As Integer = today.DayOfWeek - DayOfWeek.Friday
        Dim friday As Date = today.AddDays(-dayDiff)
        Return friday.AddDays(-14)
    End Function
    Public Function weeklycutoffto(ByVal sourcedate As DateTime) As DateTime
        Dim today As Date = sourcedate
        Dim dayDiff As Integer = today.DayOfWeek - DayOfWeek.Thursday
        Dim thursday As Date = today.AddDays(-dayDiff)
        Return thursday.AddDays(-7)
    End Function
    Public Function fiscalyyearfrom(ByVal sourcedate As DateTime) As DateTime
        Dim cutoff As DateTime
        Dim today As Date = sourcedate.AddYears(-1)
        cutoff = New DateTime(today.Year, 11, 1)
        Return cutoff
    End Function
    Public Function fiscalyearto(ByVal sourcedate As DateTime) As DateTime
        Dim cutoff As DateTime
        Dim today As Date = sourcedate.AddYears(-1)
        cutoff = New DateTime(Now.Year, 10, 31)
        Return cutoff
    End Function
    Public Function GetWeekInMonth(ByVal dtDate As Date) As Integer
        Dim DateWeekNumber As Integer = DatePart(DateInterval.WeekOfYear, dtDate, FirstDayOfWeek.System)
        Dim MonthStartWeek As Integer = DatePart(DateInterval.WeekOfYear, New DateTime(dtDate.Year, dtDate.Month, 1), FirstDayOfWeek.System)
        Return DateWeekNumber - MonthStartWeek + 1
    End Function
    Public Function GetDayValue(ByVal sourcedate As Date) As Integer
        Dim dayvalue As Integer = 0
        Try
            dayvalue = Convert.ToInt32(Format(sourcedate, "dd"))

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return dayvalue
    End Function
End Module
