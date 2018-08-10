Imports MySql.Data.MySqlClient
Public Class HRIS_GeneralViolation
    Private tosave As Boolean = True
    Private generalviolationid As Integer
    Private ds As DataSet = New DataSet
    Dim pagingAdapter As MySqlDataAdapter
    Dim pagingDS As DataSet
    Private Sub SaveRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveRecord.Click
        Try
            If Trim(Me.GeneralViolation.Text) = "" Then MessageBox.Show("generalviolation is required!", "Required field", MessageBoxButtons.OK, MessageBoxIcon.Stop) : Me.GeneralViolation.Focus() : Exit Sub
            If Trim(Me.Description.Text) = "" Then MessageBox.Show("Description is required!", "Required field", MessageBoxButtons.OK, MessageBoxIcon.Stop) : Me.Description.Focus() : Exit Sub
            If tosave = True Then
                If RecordDoExists("SELECT * from hris_generalviolation where generalviolation='" & Me.GeneralViolation.Text & "'") = True Then
                    MessageBox.Show("The generalviolation exist already.", "Exist already.", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Exit Sub
                End If
            Else
                If RecordDoExists("SELECT * from hris_generalviolation where generalviolation='" & Me.GeneralViolation.Text & "' AND generalviolationID<> '" & Me.generalviolationID & "'") = True Then
                    MessageBox.Show("The generalviolation exist already.", "Exist already.", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Exit Sub
                End If
            End If
            If tosave = True Then
                saveEditDelete("INSERT into hris_generalviolation (generalviolation,   Active, Creator, ChangesMade,datecreated) VALUES ( '" & _
                                    convertQuotes(Me.GeneralViolation.Text) & _
                                 "', '" & convertQuotes(Me.Description.Text) & _
                                  "', '" & Convert.ToSingle(Me.Status.Checked) & _
                                   "', '" & APCESMainForm.UserFullName.Text & _
                                  "', 'Originally created: " & convertQuotes(GeneralViolation.Text) & vbCrLf & _
                                  "Active:" & Me.Status.Checked & vbCrLf & _
                                  "by " & _
                                 convertQuotes(APCESMainForm.UserFullName.Text) & " at " & Now & "@ " & _
                                 convertQuotes(APCESMainForm.ComputerName.Text) & _
                                  "',now())", "saved")
            Else
                saveEditDelete("update hris_generalviolation SET generalviolation= '" & _
                                    convertQuotes(Me.GeneralViolation.Text) & _
                                 "', Description='" & convertQuotes(Me.Description.Text) & _
                                 "', Active='" & Convert.ToSingle(Me.Status.Checked) & _
                                 "', ChangesMade=Concat('Updated to: " & MySqlHelper.EscapeString(Me.GeneralViolation.Text.ToUpper) & vbCrLf & _
                                  "Active:" & Me.Status.Checked & vbCrLf & _
                                  "by " & _
                                  APCESMainForm.UserFullName.Text & " at " & Now & _
                                  "@ " & APCESMainForm.ComputerName.Text & _
                                  vbCrLf & vbCrLf & "-->'" & _
                                  ", ChangesMade) WHERE generalviolationID='" & Me.generalviolationID & "'", "updated..")
            End If
            tosave = False

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
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

    Private Sub vessel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, SearchClear.Click, SoRefresh.Click
        loadingReligions("Select GeneralViolationID as ID, GeneralViolation,  DateCreated,Creator from hris_generalviolation order by generalviolationid asc")
        tosave = True
    End Sub
    Public Sub loadingReligions(ByVal sql As String)
        Try
            MainLauncher(Me.C1FLEXGRID1, 0)
            connect()
            con.Open()
            pagingAdapter = New MySqlDataAdapter(sql, con)
            ds = New DataSet
            pagingAdapter.Fill(ds)
            pagingDS = New DataSet()
            pagingAdapter.Fill(pagingDS, "towns")
            con.Close()
            Me.C1FLEXGRID1.DataSource = pagingDS
            Me.C1FLEXGRID1.DataMember = "towns"
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
        With Me.C1FLEXGRID1
            .AutoSizeCols()
            .AllowSorting = True
            ' .Item(0, 1) = "ID"
            ' .Cols("ChangesMade").Visible = False
            ' .AutoSizeCol(.Cols("Active").Index)
            .AllowFiltering = True
        End With
        start.Stop()
    End Sub

    Private Sub InputButton12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputButton12.Click
        loadingReligions("Select GeneralViolationID as ID, GeneralViolation,  DateCreated,Creator from hris_generalviolation" & _
                         " where generalviolation like '%" & Searchfield.Text & "%' or description like '%" & Searchfield.Text & "%' order by generalviolationid asc")
        Me.Searchfield.Text = Nothing
    End Sub

    Private Sub InputButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Clear.Click
        Me.Description.Text = Nothing
        Me.GeneralViolation.Text = Nothing
        tosave = True
    End Sub

   
    Private Sub SOEditMenu_Click(ByVal sender As Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles SOEditMenu.Click
        connect()
        con.Open()
        command = New MySqlCommand("Select * from hris_generalviolation where generalviolationid='" & Me.C1flexgrid1.Item(Me.C1flexgrid1.RowSel, "id") & "'", con)
        reader = command.ExecuteReader
        If reader.Read = True Then
            Me.generalviolationid = reader.Item("generalviolationid")
            Me.GeneralViolation.Text = reader.Item("generalviolation")
            Me.Description.Text = reader.Item("Description")
        End If
        tosave = False
        reader.Close()
        command.Dispose()
        con.Close()
    End Sub
End Class