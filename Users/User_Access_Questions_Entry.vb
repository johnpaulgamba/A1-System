Imports MySql.Data.MySqlClient
Public Class User_Access_Questions_Entry
    Sub New(ByVal Id As Integer)
        InitializeComponent()
        If Id = 0 Then Exit Sub
        loadexisting(Id)
    End Sub
    Private Sub loadexisting(ByVal id As Integer)
        Try
            connect()
            con.Open()
            Dim adapter As New MySqlDataAdapter("user_access_questions_modification", con)
            Dim ds As New DataSet
            With adapter
                .SelectCommand.CommandType = CommandType.StoredProcedure
                .SelectCommand.Parameters.AddWithValue("@ID", id)
                .Fill(ds)
                .Dispose()
            End With
            With ds.Tables(0).Rows(0)
                Me.Active.Checked = .Item("Active")
                Me.Questionid = .Item("QuestionID")
                Me.Question.Text = .Item("QuestionName")
                Me.Remarks.Text = .Item("Description")
                Me.tosave = False
            End With
        Catch ex As Exception
            showMessage("No record found.", "Not found", "Contact system admin", 1)

        End Try
    End Sub
    Private tosave As Boolean = True
    Private Questionid As Integer = 0
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Me.tosave = True Then
            Me.Questionid = searchRecord("SELECT AUTO_INCREMENT FROM information_schema.tables where  table_schema='" & database & "' and table_name='user_access_questions';", 1)
            savecommand(Questionid, Me.Question.Text, Me.Remarks.Text, Convert.ToSingle(Me.Active.Checked), Now, Now, APCESMainForm.UserAccountName.Text, tosave)
        Else
            savecommand(Questionid, Me.Question.Text, Me.Remarks.Text, Convert.ToSingle(Me.Active.Checked), Now, Now, APCESMainForm.UserAccountName.Text, tosave)
        End If

    End Sub
    Private Sub savecommand(ByVal QuestionIDx As Integer, ByVal QuestionNamex As String, _
                            ByVal Descriptionx As String, ByVal Activex As Integer, _
                            ByVal datecreatedx As String, ByVal lastupdatedx As String, _
                            ByVal creatorNtuserx As String, ByVal tosavex As Boolean)
        Try
            command = New MySqlCommand
            connect()
            con.Open()
            With command
                .CommandText = "user_access_questions_saving"
                .CommandType = CommandType.StoredProcedure
                With .Parameters
                    .AddWithValue("@QuestionIDX", QuestionIDx)
                    .AddWithValue("@QuestionX", QuestionNamex)
                    .AddWithValue("@DescriptionX", Descriptionx)
                    .AddWithValue("@ActiveX", Activex)
                    .AddWithValue("@DateCreatedX", datecreatedx)
                    .AddWithValue("@LastUpdateX", lastupdatedx)
                    .AddWithValue("@CreatorNTUserX", creatorNtuserx)
                    .AddWithValue("@toSaveX", tosavex)
                End With
                .Connection = con
                .ExecuteNonQuery()
                User_Access_Questions_Main.refreshform()
                showMessage("The command has been executed successfully.", "Command executed", "Command success", 3)
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        Me.tosave = True
        Me.Questionid = 0
        Me.Question.Text = Nothing
        Me.Remarks.Text = Nothing
        Me.Active.Checked = True
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
