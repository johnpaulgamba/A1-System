Imports MySql.Data.MySqlClient
Public Class Passwordvalidation
    Public userid As Integer = 0
    Public overwrite As Boolean = False

    Private Sub InputButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputButton3.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub SaveRecordButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveRecordButton.Click
        If overwrite = True Then
            If Me.Password.Text.Replace(" ", "") = Nothing Then showMessage("Password must not be empty", "Password empty", "Invalid", 1) : Me.Password.Focus() : Exit Sub
            Dim haha As New C1.Win.C1Win7Pack.C1TaskDialog
            With haha
                .WindowTitle = "Overwrite?"
                .MainInstruction = "Overwrite Password"
                .Content = "Performing the command will overwrite password for this user. Do you want to continue?"
                .MainCommonIcon = C1.Win.C1Win7Pack.TaskDialogCommonIcon.Shield
                .CommonButtons = C1.Win.C1Win7Pack.TaskDialogCommonButtons.Ok Or C1.Win.C1Win7Pack.TaskDialogCommonButtons.Cancel
                .Show()
            End With
            If haha.DialogResult = C1.Win.C1Win7Pack.TaskDialogResult.Ok Then
                SaveCommand("Update user_access Set Password=AES_Encrypt(@Passwords, 'USERNAME'), " & _
                            "Lastupdate=@LastUpdates Where UserID=@UserIDs")
                Me.Close()
            End If
            Exit Sub
        End If
        If returnifExist("SELECT * from user_access WHERE AES_DECRYPT(Password, 'USERNAME')=@Password", 1) = True Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Else
            Dim x As New useraccountregistration(0)
            With x
                .showerrormessage("Invalid current password", "You are required input the valid current password.", "Invalid current password")
                .Dispose()
            End With
        End If
    End Sub
    Public Sub SaveCommand(ByVal storedproc As String)
        Try
            command = New MySqlCommand
            connect()
            con.Open()
            With command
                .CommandText = storedproc
                .CommandType = CommandType.Text
                .Connection = con
                With .Parameters
                    .AddWithValue("@Usernames", Me.UserName.Text)
                    .AddWithValue("@Passwords", Me.Password.Text)
                    .AddWithValue("@EmployeeIDs", 0)
                    .AddWithValue("@DateCreateds", "" & Now)
                    .AddWithValue("@LastUpdates", "" & Now)
                    .AddWithValue("@UserIds", Me.userid)
                    .AddWithValue("@CreatorNTUsers", APCESMainForm.UserAccountName.Text)
                End With
                .ExecuteNonQuery()
                .Dispose()
            End With
            Dim taskdial As New C1.Win.C1Win7Pack.C1TaskDialog
            With taskdial
                .WindowTitle = "Record saved!"
                .MainInstruction = "Password overwritten"
                .MainCommonIcon = C1.Win.C1Win7Pack.TaskDialogCommonIcon.Information
                .Content = "Password has been successfully overwritten."
                .CommonButtons = C1.Win.C1Win7Pack.TaskDialogCommonButtons.Ok
                .Show()
            End With
        Catch ex As Exception
            showMessage("Exception found. Contact System Administrator", ex.Message, "System error", 1)
        End Try
    End Sub
    Private Function returnifExist(ByVal a As String, ByVal b As Integer) As Boolean
        Try
            connect()
            con.Open()
            command = New MySqlCommand
            With command
                .CommandText = a
                .Connection = con
                .Parameters.AddWithValue("@Password", Me.Password.Text)
                reader = .ExecuteReader
            End With
            If b = 1 Then
                If reader.Read = True Then
                    Return True
                    con.Close()
                    command.Dispose()
                    reader.Close()
                End If
            End If
        Catch ex As Exception
        End Try
        Return False
    End Function
End Class