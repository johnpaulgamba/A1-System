Imports mysql.data.mysqlclient
Public Class useraccountregistration
    Public tosave As Boolean = True
    Sub New(ByVal id As Integer)

        ' this call is required by the designer.
        initializecomponent()
        loadingvaluestocomboboxes("select questionname from user_access_questions where active=1 order by questionname", Me.recoveryquestion, "questionname", "questionname")
        loadingvaluestocomboboxes("select departmentname from departments where active=1 order by departmentname", Me.department, "departmentname", "departmentname")
        If id = 0 Then Exit Sub
        loadme(id)
    End Sub
    Private Sub clearbutton_click() Handles clearbutton.click
        With Me
            .activecheckbox.checked = True
            .username.text = Nothing
            .recoveryquestion.selectedindex = -1
            .answer.text = Nothing
            .password.text = Nothing
            .confirmpassword.text = Nothing
            .emailaddress.text = Nothing
            .c1inputpanel1.readonly = False
            .fullname.text = Nothing
            .department.selectedindex = -1
            .saverecordbutton.enabled = True
            .tosave = True
            Me.text = "user permission - module registration"
        End With
    End Sub
    Private Sub loadme(ByVal id As Integer)
        Try
            Dim ds As New dataset
            connect()
            con.open()
            Dim adapter As New mysqldataadapter("user_access_modification", con)
            adapter.selectcommand.commandtype = commandtype.storedprocedure
            adapter.selectcommand.parameters.addwithvalue("@id", id)
            adapter.fill(ds)
            With ds.tables(0).rows(0)
                Me.tosave = False
                Me.recoveryquestion.text = .item("recoveryquestion")
                Me.username.text = .item("username")
                Me.userid = .item("userid")
                Me.emailaddress.text = .item("emailaddress")
                Me.department.text = .item("department")
                Me.fullname.text = .item("fullname")
                Me.activecheckbox.checked = .item("active")
            End With
            con.close()
            ds.dispose()
            adapter.dispose()
        Catch ex As exception
            'messagebox.show(ex.message)
        End Try
    End Sub
    Private Sub savecommand(ByVal storedproc As String)
        Try
            command = New mysqlcommand
            connect()
            con.open()
            With command
                .commandtext = storedproc
                .commandtype = commandtype.storedprocedure
                .connection = con
                With .parameters
                    .addwithvalue("@usernames", Me.username.text)
                    .addwithvalue("@passwords", Me.password.text)
                    .addwithvalue("@recoveryquestions", Me.recoveryquestion.text)
                    .addwithvalue("@recoveryanswers", Me.answer.text)
                    .addwithvalue("@emailaddresss", Me.emailaddress.text)
                    .addwithvalue("@employeeids", 0)
                    .addwithvalue("@datecreateds", "" & now)
                    .addwithvalue("@lastupdates", "" & now)
                    .addwithvalue("@userids", Me.userid)
                    .addwithvalue("@actives", Me.activecheckbox.checked)
                    .addwithvalue("@fullnames", Me.fullname.text)
                    .addwithvalue("@departments", Me.department.text)
                    .addwithvalue("@creatorntusers", APCESMainForm.useraccountname.text)
                    .addwithvalue("@tosave", tosave)
                End With
                .executenonquery()
                .dispose()
            End With
            showmessage("user account has been added succesfully.", "command executed", "command successful", 3)
            user_accessmain.refreshform()
            clearbutton_click()
        Catch ex As exception
            showerrormessage("exception found. contact system administrator", ex.message, "system error")
        End Try
    End Sub
    Public Sub showerrormessage(ByVal instrucion As String, ByVal content As String, ByVal windowtitle As String)
        Dim taskdial As New c1.win.c1win7pack.c1taskdialog
        With taskdial
            .windowtitle = windowtitle
            .maininstruction = instrucion
            .content = content
            .maincommonicon = c1.win.c1win7pack.taskdialogcommonicon.error
            .commonbuttons = c1.win.c1win7pack.taskdialogcommonbuttons.ok
            .show()
        End With
    End Sub
    Public userid As Integer = 0
    Private Sub saverecordbutton_click(ByVal sender As system.object, ByVal e As system.eventargs) Handles saverecordbutton.click
        If trim(Me.username.text) = Nothing Then showerrormessage("user name is required.", "you are required to input valid username. empty username is not valid", "username is empty") : Me.username.focus() : Exit Sub
        If trim(Me.password.text) = Nothing Then showerrormessage("password is required.", "you are required to input your password", "password is empty") : Me.password.focus() : Exit Sub
        If trim(Me.confirmpassword.text) = Nothing Then showerrormessage("password confirmation is required.", "you are required to input your password confirmation.", "confirm password is empty") : Me.confirmpassword.focus() : Exit Sub
        If trim(Me.emailaddress.text) = Nothing Then showerrormessage("password confirmation is required.", "you are required to input your email address. this will be used for your password recovery and contact.", "email address is empty") : Me.emailaddress.focus() : Exit Sub
        If trim(Me.recoveryquestion.text) = Nothing Then showerrormessage("password confirmation is required.", "you are required to select valid security question", "security question is empty") : Me.recoveryquestion.focus() : Exit Sub
        If trim(Me.answer.text) = Nothing Then showerrormessage("recovery answer is required.", "you are required to input your recovery answer", "confirm password is empty") : Me.answer.focus() : Exit Sub
        If trim(Me.confirmpassword.text) <> trim(Me.password.text) Then showerrormessage("password mismatch.", "passwords did not matched.", "password mismatch") : Me.confirmpassword.focus() : Exit Sub
        If tosave = True Then
            If returnifexist("select * from user_access where username=@username", 1) = True Then showerrormessage("user name is already taken.", "the username is already taken and is not available to be used.", "username is already taken") : Me.username.focus() : Exit Sub
            savecommand("user_access_add")
        Else
            If returnifexist("select * from user_access where username=@username and userid <>" & userid, 1) = True Then showerrormessage("user name is already taken.", "the username is already taken and is not available to be used.", "username is already taken") : Me.username.focus() : Exit Sub
            Dim x As New passwordvalidation
            With x
                .userid = Me.userid
                .username.text = Me.username.text
                .inputlabel5.text = "old password"
                .startposition = formstartposition.centerscreen
                .showdialog()
            End With
            If x.dialogresult = windows.forms.dialogresult.cancel Then Exit Sub
            savecommand("user_access_add2")
        End If
    End Sub
    Private Sub inputbutton3_click(ByVal sender As system.object, ByVal e As system.eventargs) Handles inputbutton3.click
        Me.close()
    End Sub
    Private Function returnifexist(ByVal a As String, ByVal b As Integer) As Boolean
        Try
            connect()
            con.open()
            command = New mysqlcommand
            With command
                .commandtext = a
                .connection = con
                .parameters.addwithvalue("@username", Me.username.text)
                reader = .executereader
            End With
            If b = 1 Then
                If reader.read = True Then
                    Return True
                    con.close()
                    command.dispose()
                    reader.close()
                End If
            End If
        Catch ex As exception
        End Try
        Return False
    End Function
End Class

