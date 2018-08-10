Imports mysql.data.mysqlclient
Public Class user_permission_profile_entry
    Sub New(ByVal id As Integer)
        initializecomponent()
        If id = 0 Then Exit Sub
        loadexisting(id)
    End Sub
    Private Sub loadexisting(ByVal id As Integer)
        Try
            connect()
            con.open()
            Dim adapter As New mysqldataadapter("user_permission_profile_modification", con)
            Dim ds As New dataset
            With adapter
                .selectcommand.commandtype = commandtype.storedprocedure
                .selectcommand.parameters.addwithvalue("@id", id)
                .fill(ds)
                .dispose()
            End With
            With ds.tables(0).rows(0)
                Me.active.checked = .item("active")
                Me.profileid = .item("profileid")
                Me.profilename.text = .item("profilename")
                Me.remarks.text = .item("description")
                Me.tosave = False
            End With
        Catch ex As exception
            showmessage("no record found.", "not found", "contact system admin", 3)

        End Try
    End Sub
    Private tosave As Boolean = True
    Private profileid As Integer = 0
    Private Sub btnsave_click(ByVal sender As system.object, ByVal e As system.eventargs) Handles btnsave.click
        If Me.tosave = True Then
            Me.profileid = searchrecord("select auto_increment from information_schema.tables where  table_schema='" & database & "' and table_name='user_permission_profile';", 1)
            savecommand(profileid, Me.profilename.text, Me.remarks.text, convert.tosingle(Me.active.checked), now, now, APCESMainForm.useraccountname.text, tosave)
        Else
            savecommand(profileid, Me.profilename.text, Me.remarks.text, convert.tosingle(Me.active.checked), now, now, APCESMainForm.useraccountname.text, tosave)
        End If

    End Sub
    Private Sub savecommand(ByVal profileidx As Integer, ByVal profilenamenamex As String, _
                            ByVal descriptionx As String, ByVal activex As Integer, _
                            ByVal datecreatedx As String, ByVal lastupdatedx As String, _
                            ByVal creatorntuserx As String, ByVal tosavex As Boolean)
        Try
            command = New mysqlcommand
            connect()
            con.open()
            With command
                .commandtext = "user_permission_profile_saving"
                .commandtype = commandtype.storedprocedure
                With .parameters
                    .addwithvalue("@profileidx", profileidx)
                    .addwithvalue("@profilenamex", profilenamenamex)
                    .addwithvalue("@descriptionx", descriptionx)
                    .addwithvalue("@activex", activex)
                    .addwithvalue("@datecreatedx", datecreatedx)
                    .addwithvalue("@lastupdatex", lastupdatedx)
                    .addwithvalue("@creatorntuserx", creatorntuserx)
                    .addwithvalue("@tosavex", tosavex)
                End With
                .connection = con
                .executenonquery()
                user_permission_profile_main.refreshform()
                showmessage("the command has been executed successfully.", "command executed", "command success", 3)
            End With
        Catch ex As exception

        End Try
    End Sub

    Private Sub btnnew_click(sender As system.object, e As system.eventargs) Handles btnnew.click
        Me.tosave = True
        Me.profileid = 0
        Me.profilename.text = Nothing
        Me.remarks.text = Nothing
        Me.active.checked = True
    End Sub

    Private Sub btnclose_click(sender As system.object, e As system.eventargs) Handles btnclose.click
        Me.close()
    End Sub
End Class


