Imports mysql.data.mysqlclient
Public Class user_permission_modules_entry
    Public tosave As Boolean = True
    Sub New(ByVal id As Integer)

        initializecomponent()
        loadingvaluestocomboboxes("select groupid, groupname from user_permission_group where active=1 group by groupname order by groupname", Me.groupnamecombobox, "groupname", "groupid")
        If id = 0 Then Exit Sub
        loadme(id)
    End Sub
    Private Sub clearbutton_click() Handles clearbutton.click
        With Me
            .modulenametxtbox.text = Nothing
            .buttonnametextbox.text = Nothing
            .activecheckbox.checked = True
            .descriptiontextbox.text = Nothing
            .c1inputpanel1.readonly = False
            .saverecordbutton.enabled = True
            .tosave = True
            Me.text = "access modules entry"
            Me.modulenametxtbox.focus()
        End With
    End Sub
    Public Sub loadme(ByVal id As Integer)
        Try
            Dim ds As New dataset
            connect()
            con.open()
            Dim adapter As New mysqldataadapter("user_permission_modules_modification", con)
            adapter.selectcommand.commandtype = commandtype.storedprocedure
            adapter.selectcommand.parameters.addwithvalue("@id", id)
            adapter.fill(ds)
            With ds.tables(0).rows(0)
                descriptiontextbox.text = .item("description")
                buttonnametextbox.text = .item("modulebuttonname")
                modulenametxtbox.text = .item("modulename")
                activecheckbox.checked = .item("active")
                classname.text = .item("classname")
                Me.tosave = False
                moduleid = .item("moduleid")
                groupnamecombobox.selectedvalue = .item("groupid")
            End With
            con.close()
            ds.dispose()
            adapter.dispose()
        Catch ex As exception
            'messagebox.show(ex.message)
        End Try


    End Sub
    Private Sub savecommand(ByVal storedproc As String, _
                            ByVal groupid As Integer, _
                            ByVal modulename As String, _
                            ByVal description As String, _
                            ByVal buttonname As String, _
                            ByVal active As Boolean, _
                            ByVal tosave As Boolean, _
                            ByVal moduleid As Integer, _
                            ByVal objecttypes As String)
        Try
            command = New mysqlcommand
            connect()
            con.open()
            With command
                .commandtext = storedproc
                .commandtype = commandtype.storedprocedure
                .connection = con
                With .parameters
                    .addwithvalue("@modulenames", modulename.toupper)
                    .addwithvalue("@buttonnames", buttonname)
                    .addwithvalue("@descriptions", Me.descriptiontextbox.text)
                    .addwithvalue("@actives", active)
                    .addwithvalue("@datecreateds", "" & now)
                    .addwithvalue("@employeeids", 0)
                    .addwithvalue("@creatorntusers", APCESMainForm.useraccountname.text)
                    .addwithvalue("@changesmades", "")
                    .addwithvalue("@tosave", tosave)
                    .addwithvalue("@groupids", groupid)
                    .addwithvalue("@moduleids", moduleid)
                    .addwithvalue("@objecttypes", objecttypes)
                End With
                .executenonquery()
                .dispose()
            End With
            user_permission_modules_main.refreshform()
            showmessage("the record has been successfully added to the database.", "command executed", "command executed", 3)
            clearbutton_click()
        Catch ex As exception
            showmessage("error says:" & ex.message, "contact system admin", "system error", 1)

        End Try
    End Sub
    Public moduleid As Integer = 0
    Private Sub saverecordbutton_click(ByVal sender As system.object, ByVal e As system.eventargs) Handles saverecordbutton.click
        If Me.modulenametxtbox.text.replace(" ", "") = Nothing Then messagebox.show("invalid user permission group", "invalid", messageboxbuttons.ok, messageboxicon.stop) : Me.modulenametxtbox.focus() : Exit Sub
        If Me.modulenametxtbox.text.replace(" ", "") = Nothing Then messagebox.show("invalid user permission module", "invalid", messageboxbuttons.ok, messageboxicon.stop) : Me.modulenametxtbox.focus() : Exit Sub
        If Me.buttonnametextbox.text.replace(" ", "") = Nothing Then messagebox.show("invalid button name", "invalid", messageboxbuttons.ok, messageboxicon.stop) : Me.buttonnametextbox.focus() : Exit Sub
        If Me.descriptiontextbox.text.replace(" ", "") = Nothing Then messagebox.show("invalid description", "invalid", messageboxbuttons.ok, messageboxicon.stop) : Me.descriptiontextbox.focus() : Exit Sub
        If tosave = True Then
            savecommand("user_permission_module_add", Me.groupnamecombobox.selectedvalue, Me.modulenametxtbox.text, Me.descriptiontextbox.text, Me.buttonnametextbox.text, Me.activecheckbox.checked, tosave, 0, Me.classname.text)
        Else
            savecommand("user_permission_module_add", Me.groupnamecombobox.selectedvalue, Me.modulenametxtbox.text, Me.descriptiontextbox.text, Me.buttonnametextbox.text, Me.activecheckbox.checked, Me.tosave, moduleid, Me.classname.text)
        End If
    End Sub
    Private Sub inputbutton3_click(ByVal sender As system.object, ByVal e As system.eventargs) Handles inputbutton3.click
        Me.close()
    End Sub
End Class

