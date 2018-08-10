Imports MySql.Data.MySqlClient
Public Class HRIS_RelationshipRegistration
    Dim ds As New DataSet
    Dim pagingAdapter As New MySqlDataAdapter
    Dim dsItem As New DataSet
    Dim pagingDSAdapter As New MySqlDataAdapter
    Public toSave As Boolean = True
    Public RelationshipID As Integer
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
                    Me.Description.Text = .Item("Description")
                    Me.Relationship.Text = .Item("Relationship")
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
            .Text = "Relationship Entry"
            .Status.Checked = True
            .Relationship.Text = Nothing
            .Description.Text = Nothing
            .toEnableAllControls(False)
        End With
    End Sub
    Public Sub toEnableAllControls(ByVal a As Boolean)
        With Me
            .Description.ReadOnly = a
            .Relationship.ReadOnly = a
            .Status.Enabled = Not a
        End With
    End Sub
    Sub New()
        InitializeComponent()
        ' Me.Size = Me.PanelEx1.Size
    End Sub
    Public Sub EditLoad(ByVal a As Integer)
        loadDS("SELECT * from HRIS_Relationship where RelationshipID='" & a & "'")
    End Sub
    Private Sub messageOF(ByVal a As String)
        MessageBox.Show(a, "Field required!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Exit Sub
    End Sub
    Private Sub SaveRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveRecord.Click
        Try
            If Trim(Me.Relationship.Text) = "" Then
                MessageBox.Show("Relationship is required!", "Required field", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If
            If Trim(Me.Description.Text) = "" Then
                MessageBox.Show("Description is required!", "Required field", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If
            If toSave = True Then
                If RecordDoExists("SELECT * from HRIS_Relationship where Relationship='" & Me.Relationship.Text & "'") = True Then
                    MessageBox.Show("The Relationship exist already.", "Exist already.", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Exit Sub
                End If
            Else
                If RecordDoExists("SELECT * from HRIS_Relationship where Relationship='" & Me.Relationship.Text & "' AND RelationshipID<> '" & Me.RelationshipID & "'") = True Then
                    MessageBox.Show("The Relationship exist already.", "Exist already.", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Exit Sub
                End If
            End If
            If toSave = True Then
                saveEditDelete("INSERT INTO HRIS_Relationship (Relationship, Description,  Active, EmployeeID, DateCreated, CreatorNtUser, LastUpdate, ChangesMade) VALUES ( '" & _
                                    convertQuotes(Me.Relationship.Text) & _
                                 "', '" & convertQuotes(Me.Description.Text) & _
                                  "', '" & Convert.ToSingle(Me.Status.Checked) & _
                                  "', '" & APCESMainform.EmployeeID.Text & _
                                  "', '" & Now & _
                                  "', '" & APCESMainform.NTUser.Text & _
                                  "', 'NONE', 'Originally created: " & convertQuotes(Relationship.Text) & vbCrLf & _
                                  "Active:" & Me.Status.Checked & vbCrLf & _
                                  "by " & _
                                 convertQuotes(APCESMainform.EmployeeName.Text) & " at " & Now & "@ " & _
                                 convertQuotes(APCESMainform.ComputerName.Text) & _
                                  "')", "saved")
            Else
                saveEditDelete("UPDATE HRIS_Relationship SET Relationship= '" & _
                                    convertQuotes(Me.Relationship.Text) & _
                                 "', Active='" & Convert.ToSingle(Me.Status.Checked) & _
                                  "', LastUpdate='" & Now & _
                                  "', ChangesMade=Concat('Updated to: Relationship:" & MySqlHelper.EscapeString(Me.Relationship.Text.ToUpper) & vbCrLf & _
                                  "Active:" & Me.Status.Checked & vbCrLf & _
                                  "by " & _
                                  APCESMainform.EmployeeName.Text & " at " & Now & _
                                  "@ " & APCESMainform.ComputerName.Text & _
                                  vbCrLf & vbCrLf & "-->'" & _
                                  ", ChangesMade) WHERE RelationshipID='" & Me.RelationshipID & "'", "updated..")
            End If

            If IsNotError = False Then
                NewRecord_Click(sender, e)
                If NeededDialogResult = True Then Me.DialogResult = Windows.Forms.DialogResult.OK : Exit Sub
                HRIS_RelationshipMainForm.loadingHRIS_Relationship(QuerytoString)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public NeededDialogResult As Boolean = False
    Private Function convertQuotes(ByVal a As String) As String
        Return MySqlHelper.EscapeString(UCase(a))
    End Function
    Private Sub NewRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateNewrecord.Click
        tostartNewRecord()
        Me.SaveRecord.Enabled = True
        Me.Status.Enabled = True
    End Sub
    Private Sub CloseForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseForm.Click
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
    Private Sub Department_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Relationship.Validating
        If toSave = True Then
            If RecordDoExists("SELECT * from HRIS_Relationship where Relationship='" & Me.Relationship.Text & "'") = True Then
                MessageBox.Show("The Relationship exist already.", "Exist already.", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                e.Cancel = True
                Exit Sub
            End If
        Else
            If RecordDoExists("SELECT * from HRIS_Relationship where Relationship='" & Me.Relationship.Text & "' AND RelationshipID<> '" & Me.RelationshipID & "'") = True Then
                MessageBox.Show("The Relationship exist already.", "Exist already.", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                e.Cancel = True
                Exit Sub
            End If
        End If
    End Sub

End Class
