Imports mysql.data.mysqlclient
Public Class departmentsentry
    Sub New(ByVal id As Integer)
        initializecomponent()
        If id = 0 Then Exit Sub
        loadexisting(id)
    End Sub
    Private Sub loadexisting(ByVal id As Integer)
        Try
            connect()
            con.open()
            Dim adapter As New mysqldataadapter("departments_modification", con)
            Dim ds As New dataset
            With adapter
                .selectcommand.commandtype = commandtype.storedprocedure
                .selectcommand.parameters.addwithvalue("@id", id)
                .fill(ds)
                .dispose()
            End With
            With ds.tables(0).rows(0)
                Me.active.checked = .item("active")
                Me.departmentid = .item("departmentid")
                Me.department.text = .item("departmentname")
                Me.remarks.text = .item("description")
                Me.tosave = False
            End With
        Catch ex As exception
            showmessage("no record found.", "not found", "contact system admin", 1)

        End Try
    End Sub
    Private tosave As Boolean = True
    Private departmentid As Integer = 0
    Private Sub btnsave_click(ByVal sender As system.object, ByVal e As system.eventargs) Handles btnsave.click
        If Me.tosave = True Then
            Me.departmentid = searchrecord("select auto_increment from information_schema.tables where  table_schema='" & database & "' and table_name='departments';", 1)
            savecommand(departmentid, Me.department.text, Me.remarks.text, convert.tosingle(Me.active.checked), now, now, APCESMainForm.useraccountname.text, tosave)
        Else
            savecommand(departmentid, Me.department.text, Me.remarks.text, convert.tosingle(Me.active.checked), now, now, APCESMainForm.useraccountname.text, tosave)
        End If

    End Sub
    Private Sub savecommand(ByVal departmentidx As Integer, ByVal departmentnamex As String, _
                            ByVal descriptionx As String, ByVal activex As Integer, _
                            ByVal datecreatedx As String, ByVal lastupdatedx As String, _
                            ByVal creatorntuserx As String, ByVal tosavex As Boolean)
        Try
            command = New mysqlcommand
            connect()
            con.open()
            With command
                .commandtext = "departments_saving"
                .commandtype = commandtype.storedprocedure
                With .parameters
                    .addwithvalue("@departmentidx", departmentidx)
                    .addwithvalue("@departmentx", departmentnamex)
                    .addwithvalue("@descriptionx", descriptionx)
                    .addwithvalue("@activex", activex)
                    .addwithvalue("@datecreatedx", datecreatedx)
                    .addwithvalue("@lastupdatex", lastupdatedx)
                    .addwithvalue("@creatorntuserx", creatorntuserx)
                    .addwithvalue("@tosavex", tosavex)
                End With
                .connection = con
                .executenonquery()
                departmentsmain.refreshform()
                showmessage("the command has been executed successfully.", "command executed", "command success", 3)
            End With
        Catch ex As exception

        End Try
    End Sub

    Private Sub btnnew_click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        Me.tosave = True
        Me.departmentid = 0
        Me.Department.Text = Nothing
        Me.Remarks.Text = Nothing
        Me.Active.Checked = True
    End Sub

    Private Sub btnclose_click(sender As system.object, e As system.eventargs) Handles btnclose.click
        Me.close()
    End Sub

End Class


