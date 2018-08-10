Imports mysql.data.mysqlclient
Public Class loginform
    Sub New()

        ' this call is required by the designer.
        InitializeComponent()
        Try

            Dim lines2 = System.IO.File.ReadAllLines(Application.StartupPath & "\ipaddress.txt")
            ServerHost = lines2(0)
            'UserID = lines2(1)
            ' Password = lines2(2)
            'database = lines2(3).ToString.ToLower
        Catch ex As Exception
            'messagebox.show(ex.message)
        End Try
        'dim lines2 = system.io.file.readalllines(application.startuppath & "\ipaddresses.txt")
        'dim lines = system.io.file.readalllines(application.startuppath & "\database.txt")
        'ipadd = lines2(0)
        'database = lines(0)
        'loadme("")
    End Sub
    Private Sub inputbutton2_click(ByVal sender As system.object, ByVal e As system.eventargs) Handles inputbutton2.click
        Me.close()
    End Sub
    Private Sub inputbutton1_click(ByVal sender As system.object, ByVal e As system.eventargs) Handles inputbutton1.click
        application.doevents()
        loginuser("select * from user_access where username=@username and  aes_decrypt(`password`,'USERNAME')=@password", 1)
    End Sub
    Dim attempt As Integer = 5
    Private Sub loginuser(ByVal a As String, ByVal b As Integer)
        Try
            command = New mysqlcommand
            connect()
            con.open()
            With command
                .commandtext = a
                .commandtype = commandtype.text
                .connection = con
                .parameters.addwithvalue("@username", Me.username.text)
                .parameters.addwithvalue("@password", Me.passwordtextbox.text)
                reader = .executereader
            End With
            If b = 1 Then
                If reader.read = True Then

                    If reader.item("active") = False Then showmessage("your account has been temporarily suspended by system administrator." & _
                        " contact system administrator to activate your account.", "account suspended", "account temporarily suspended", 2) : Exit Try
                    attempt = 5
                    Dim username As String = reader.item("username").tostring.toupper
                    Dim userid As Integer = reader.item("userid")
                    Dim department As String = reader.item("department")
                    Dim fullname As String = reader.item("fullname")

                    reader.close()
                    command.dispose()
                    con.close()
                    With APCESMainForm
                        .UserFullName.Text = fullname.ToUpper
                        .UserAccountName.Text = username
                        .DepartmentLabel.Text = department
                        .EmployeeID.Text = userid
                        .StringCollect.Clear()
                        .preparealldata("rights_useraccess_modules_loading", .EmployeeID.Text)
                        .setMeBackGround()
                        .loadall()
                        .WindowState = FormWindowState.Maximized
                        .StartPosition = FormStartPosition.CenterScreen
                        .Show()
                    End With
                    Me.PasswordTextBox.Text = Nothing
                    Me.hide()
                Else
                    attempt = attempt - 1
                    If attempt = 0 Then
                        showmessage("supply valid login information. you used the maximum attempts. system will now terminate.", "invalid supplied login data", "user not found", 1)
                        application.exit()
                    Else
                        showmessage("supply valid login information. you have " & attempt & " remaining attempts to login", "invalid supplied login data", "user not found", 1)
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub username_keydown(ByVal sender As Object, ByVal e As system.windows.forms.keyeventargs) Handles username.keydown
        If e.keycode = keys.enter Then
            Me.passwordtextbox.focus()
        End If
    End Sub
    Private Sub password_keydown(ByVal sender As Object, ByVal e As system.windows.forms.keyeventargs) Handles passwordtextbox.keydown
        If e.keycode = keys.return Then
            loginuser("select * from user_access where username=@username and  aes_decrypt(`password`,'USERNAME')=@password", 1)
        End If
    End Sub
    Public vsstyle As String = ""
    Private Sub linklabel1_linkclicked(ByVal sender As system.object, ByVal e As system.windows.forms.linklabellinkclickedeventargs) Handles linklabel1.linkclicked
        '   messagebox.show(transformpassword(me.password.text))
    End Sub
End Class


