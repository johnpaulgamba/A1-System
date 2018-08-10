Imports mysql.data.mysqlclient
Public Class branchesentry
    Private tosave As Boolean = True
    Private recordid As Integer = 0
    Sub New(ByVal id As Integer)
        initializecomponent()
        If id = 0 Then Me.tosave = True : Exit Sub
        loadentry("select * from company where companyid=" & id)
    End Sub
    Private Sub buttonnew_click(sender As system.object, e As system.eventargs) Handles buttonnew.click
        Me.branchname.text = Nothing
        Me.reference.text = Nothing
        Me.active.checked = True
        Me.ButtonSave.Enabled = True
        Me.address.text = Nothing
        Me.ContactNo.Text = Nothing
        Me.tin.text = Nothing
        Me.tosave = True
    End Sub

    Private Sub buttonclose_click(sender As system.object, e As system.eventargs) Handles buttonclose.click
        Me.close()
    End Sub

    Private Sub buttonsave_click(sender As system.object, e As system.eventargs) Handles buttonsave.click
        If Me.branchname.text.replace(" ", "") = Nothing Then
            showmessage("you are required to input branch name.", "invalid input", "input not valid", 4)
            Exit Sub
        End If
        If Me.tosave = True Then
            Me.recordid = searchrecord("select auto_increment from information_schema.tables where  table_schema='" & database & "' and table_name='branches';", 1)
            savecommand()
        Else
            savecommand()
        End If
    End Sub
    Private Sub savecommand()
        Try
            connect()
            con.open()
            Dim command As New mysqlcommand
            With command
                .CommandText = "admin_company_entry"
                .commandtype = commandtype.storedprocedure
                .connection = con
                With .parameters
                    .AddWithValue("companyids", Me.recordid)
                    .AddWithValue("companynames", Me.BranchName.Text)
                    .AddWithValue("actives", Me.Active.Checked)
                    .addwithvalue("datecreateds", "" & now)
                    .addwithvalue("addresss", Me.address.text)
                    .AddWithValue("contactnos", Me.ContactNo.Text)
                    .addwithvalue("tins", Me.tin.text)
                    .AddWithValue("creators", APCESMainForm.UserFullName.Text)
                    .addwithvalue("tosave", Me.tosave)
                End With
                .executenonquery()
                con.close()
                command.dispose()
                Me.tosave = False
                Me.reference.text = "br " & Me.recordid.tostring("d10")
                showmessage("the record has been successfully saved.", "command executed", "command success!", 3)
                branchesmainform.refreshgrid_click()
            End With
        Catch ex As exception
            'showMessage(ex.Message, "exception found", "contact system admin", 1)
        End Try
    End Sub
    Private Sub loadentry(ByVal sql As String)
        Try
            connect()
            con.open()
            Dim adapter As New mysqldataadapter(sql, con)
            Dim ds As New dataset
            With adapter
                .selectcommand.commandtype = commandtype.text
                .fill(ds)
            End With
            adapter.dispose()
            con.close()
            With ds.tables(0).rows(0)
                Me.recordid = .Item("companyid")
                Me.BranchName.Text = .Item("companyname")

                Me.active.checked = .item("active")
                Me.reference.text = "br  " & Me.recordid.tostring("d10")
                Me.address.text = .item("address")

                Me.tin.text = .item("tin")
                Me.contactno.text = .item("contactno")

                Me.tosave = False
            End With
        Catch ex As exception
            'showMessage(ex.Message, "exception found", "contact system admin", 1)
        End Try
    End Sub
End Class

