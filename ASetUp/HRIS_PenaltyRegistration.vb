Imports MySql.Data.MySqlClient
Public Class HRIS_PenaltySetUpRegistration
    Dim ds As New DataSet
    Dim pagingAdapter As New MySqlDataAdapter
    Dim dsItem As New DataSet
    Dim pagingDSAdapter As New MySqlDataAdapter
    Public toSave As Boolean = True
    Public PenaltyID As Integer
    Public QuerytoString As String = ""
    Public Sub loadDS(ByVal sql As String)
        Try
            connect()
            con.Open()
            pagingDSAdapter = New MySqlDataAdapter(sql, con)
            dsItem = New DataSet
            pagingDSAdapter.Fill(dsItem)
            con.Close()
            If dsItem.Tables(0).Rows.Count <= 1 Then
                With dsItem.Tables(0).Rows(0)
                    Me.Noofdays.Value = .Item("noofdays")
                    Me.PenaltyLevel.Text = .Item("PenaltyLevel")
                    Me.Status.Checked = .Item("Active")
                End With
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub tostartNewRecord()
        toSave = True
        With Me
            .Text = "Penalty Level Entry"
            .Status.Checked = True
            .PenaltyLevel.Text = Nothing
            .Noofdays.Value = Nothing
            .toEnableAllControls(False)
        End With
    End Sub
    Public Sub toEnableAllControls(ByVal a As Boolean)
        With Me
            .Noofdays.ReadOnly = a
            .PenaltyLevel.ReadOnly = a
            .Status.Enabled = Not a
        End With
    End Sub
    Sub New()
        InitializeComponent()
        ' Me.Size = Me.PanelEx1.Size
    End Sub
    Public Sub EditLoad(ByVal a As Integer)
        loadDS("SELECT * from HRIS_PenaltySetUp where PenaltyID='" & a & "'")
    End Sub
    Private Sub messageOF(ByVal a As String)
        MessageBox.Show(a, "Field required!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Exit Sub
    End Sub
    Private Sub SaveRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveRecord.Click
        Try
            If Trim(Me.PenaltyLevel.Text) = "" Then
                MessageBox.Show("Penalty is required!", "Required field", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If

            If toSave = True Then
                saveEditDelete("INSERT INTO HRIS_PenaltySetUp (PenaltyLevel, noofdays,  Active,  Creator,ChangesMade) VALUES ( '" & _
                                    convertQuotes(Me.PenaltyLevel.Text) & _
                                 "', '" & Me.Noofdays.Value & _
                                  "', '" & Convert.ToSingle(Me.Status.Checked) & _
                                 "', '" & APCESMainForm.UserFullName.Text & _
                                  "', 'Originally created: " & convertQuotes(PenaltyLevel.Text) & vbCrLf & _
                                  "Active:" & Me.Status.Checked & vbCrLf & _
                                  "by " & _
                                 convertQuotes(APCESMainForm.UserFullName.Text) & " at " & Now & "@ " & _
                                 convertQuotes(APCESMainForm.ComputerName.Text) & _
                                  "')", "saved")
            Else
                saveEditDelete("UPDATE HRIS_PenaltySetUp SET PenaltyLevel= '" & _
                                    convertQuotes(Me.PenaltyLevel.Text) & _
                                 "', Active='" & Convert.ToSingle(Me.Status.Checked) & _
                                  "', ChangesMade=Concat('Updated to: Penalty:" & MySqlHelper.EscapeString(Me.PenaltyLevel.Text.ToUpper) & vbCrLf & _
                                  "Active:" & Me.Status.Checked & vbCrLf & _
                                  "by " & _
                                  APCESMainForm.UserFullName.Text & " at " & Now & _
                                  "@ " & APCESMainForm.ComputerName.Text & _
                                  vbCrLf & vbCrLf & "-->'" & _
                                  ", ChangesMade) WHERE PenaltyID='" & Me.PenaltyID & "'", "updated..")
            End If

            If IsNotError = False Then
                NewRecord_Click(sender, e)
                If NeededDialogResult = True Then Me.DialogResult = Windows.Forms.DialogResult.OK : Exit Sub
                'HRIS_ViolationSetUpMainForm.loadingHRIS_Violation(QuerytoString)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public NeededDialogResult As Boolean = False
    Private Function convertQuotes(ByVal a As String) As String
        Return MySqlHelper.EscapeString(UCase(a))
    End Function
    Private Sub NewRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        tostartNewRecord()
        Me.SaveRecord.Enabled = True
        Me.Status.Enabled = True
    End Sub
    Private Sub CloseForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
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

End Class
