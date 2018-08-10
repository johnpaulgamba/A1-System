Imports mysql.data.mysqlclient
Public Class user_permission_button_entry
    Public tosave As Boolean = True
    Sub New(ByVal id As Integer)
        initializecomponent()
        loadingvaluestocomboboxes("select moduleid, modulename from user_permission_modules where active=1 group by modulename order by modulename", Me.modulenamecombobox, "modulename", "moduleid")
        If id = 0 Then Exit Sub
        loadme(id)
    End Sub
    Private Sub clearbutton_click() Handles clearbutton.click
        With Me
            .buttonnametextbox.text = Nothing
            .commandnametextbox.text = Nothing
            .activecheckbox.checked = True
            .descriptiontextbox.text = Nothing
            .c1inputpanel1.readonly = False
            .saverecordbutton.enabled = True
            .tosave = True
            Me.text = "user permission - module button registration"
            Me.modulenamecombobox.focus()
        End With
    End Sub
    Public Sub loadme(ByVal id As Integer)
        Try
            Dim ds As New dataset
            connect()
            con.open()
            Dim adapter As New mysqldataadapter("user_permission_button_modification", con)
            adapter.selectcommand.commandtype = commandtype.storedprocedure
            adapter.selectcommand.parameters.addwithvalue("@id", id)
            adapter.fill(ds)
            With ds.tables(0).rows(0)
                descriptiontextbox.text = .item("description")
                commandnametextbox.text = .item("commandname")
                buttonnametextbox.text = .item("nameofbutton")
                activecheckbox.checked = .item("active")
                Me.tosave = False
                moduleid = .item("buttonid")
                modulenamecombobox.selectedvalue = .item("moduleid")
            End With
            con.close()
            ds.dispose()
            adapter.dispose()
        Catch ex As exception
            'messagebox.show(ex.message)
        End Try
    End Sub
    Private Sub savecommand(ByVal storedproc As String, _
                            ByVal nameofbutton As String, _
                            ByVal description As String, _
                            ByVal active2 As Boolean, _
                            ByVal commandname As String, _
                            ByVal changesmade As String, _
                            ByVal tosave As Boolean, _
                            ByVal buttonid As Integer)
        Try
            command = New mysqlcommand
            connect()
            con.open()
            With command
                .commandtext = storedproc
                .commandtype = commandtype.storedprocedure
                .connection = con
                With .parameters
                    .addwithvalue("@nameofbuttons", nameofbutton.toupper)
                    .addwithvalue("@descriptions", Me.descriptiontextbox.text)
                    .addwithvalue("@commandnames", commandname)
                    .addwithvalue("@actives", active2)
                    .addwithvalue("@datecreateds", "" & now)
                    .addwithvalue("@employeeids", 0)
                    .addwithvalue("@creatorntusers", APCESMainForm.useraccountname.text)
                    .addwithvalue("@changesmades", changesmade & vbcrlf & vbcrlf)
                    .addwithvalue("@tosave", tosave)
                    .addwithvalue("@buttonids", buttonid)
                    .addwithvalue("@moduleids", Me.modulenamecombobox.selectedvalue)
                End With
                .executenonquery()
                .dispose()
            End With
            Dim taskdial As New c1.win.c1win7pack.c1taskdialog
            With taskdial
                .windowtitle = "record saved!"
                .maininstruction = "user permission button saved."
                .maincommonicon = c1.win.c1win7pack.taskdialogcommonicon.information
                .content = "your data has been successfully saved."
                .commonbuttons = c1.win.c1win7pack.taskdialogcommonbuttons.ok
                .show()
            End With
            clearbutton_click()
            user_permission_buttons_main.refreshform()
        Catch ex As exception
            Dim taskdial As New c1.win.c1win7pack.c1taskdialog
            With taskdial
                .windowtitle = "error"
                .maininstruction = "exception found. contact system administrator"
                .content = ex.message
                .maincommonicon = c1.win.c1win7pack.taskdialogcommonicon.error
                .commonbuttons = c1.win.c1win7pack.taskdialogcommonbuttons.ok
                .show()
            End With
        End Try
    End Sub
    Public moduleid As Integer = 0
    Private Sub saverecordbutton_click(ByVal sender As system.object, ByVal e As system.eventargs) Handles saverecordbutton.click
        If Me.buttonnametextbox.text.replace(" ", "") = Nothing Then messagebox.show("invalid user permission group", "invalid", messageboxbuttons.ok, messageboxicon.stop) : Me.buttonnametextbox.focus() : Exit Sub
        If Me.buttonnametextbox.text.replace(" ", "") = Nothing Then messagebox.show("invalid user permission module", "invalid", messageboxbuttons.ok, messageboxicon.stop) : Me.buttonnametextbox.focus() : Exit Sub
        If Me.commandnametextbox.text.replace(" ", "") = Nothing Then messagebox.show("invalid button name", "invalid", messageboxbuttons.ok, messageboxicon.stop) : Me.commandnametextbox.focus() : Exit Sub
        If Me.descriptiontextbox.text.replace(" ", "") = Nothing Then messagebox.show("invalid description", "invalid", messageboxbuttons.ok, messageboxicon.stop) : Me.descriptiontextbox.focus() : Exit Sub
        If tosave = True Then
            savecommand("user_permission_module_button_add", Me.buttonnametextbox.text, Me.descriptiontextbox.text, Me.activecheckbox.checked, Me.commandnametextbox.text, _
                                " ", tosave, 0)
        Else
            savecommand("user_permission_module_button_add", Me.buttonnametextbox.text, Me.descriptiontextbox.text, Me.activecheckbox.checked, Me.commandnametextbox.text, _
                                        " ", tosave, moduleid)
        End If
    End Sub
    Private Sub inputbutton3_click(ByVal sender As system.object, ByVal e As system.eventargs) Handles inputbutton3.click
        Me.close()
    End Sub
End Class

