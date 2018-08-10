Imports mysql.data.mysqlclient
Public Class SalesAgentEntry
    Private tosave As Boolean = True
    Private recordid As Integer = 0
    Sub New(ByVal id As Integer)
        initializecomponent()
        If id = 0 Then Me.tosave = True : Exit Sub
        loadentry("select * from salesagent where salesagentid=" & id)
    End Sub
    Private Sub buttonnew_click(ByVal sender As system.object, ByVal e As system.eventargs) Handles buttonnew.click
        Me.SalesAgent.text = Nothing
        Me.Reference.Text = Nothing
        Me.Email.Text = Nothing
        Me.ContactNo.Text = Nothing

        Me.active.checked = True
        Me.description.text = Nothing
        Me.buttonsave.enabled = True
        Me.tosave = True
    End Sub

    Private Sub buttonclose_click(ByVal sender As system.object, ByVal e As system.eventargs) Handles buttonclose.click
        Me.close()
    End Sub

    Private Sub buttonsave_click(ByVal sender As system.object, ByVal e As system.eventargs) Handles buttonsave.click
        If Me.SalesAgent.text.replace(" ", "") = Nothing Then
            showmessage("you are required to input warehouse name.", "invalid input", "input not valid", 4)
            Exit Sub
        End If
        If Me.tosave = True Then
            Me.recordid = searchRecord("select auto_increment from information_schema.tables where  table_schema='" & database & "' and table_name='salesagent';", 1)
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
                .CommandText = "admin_salesagent_entry"
                .commandtype = commandtype.storedprocedure
                .connection = con
                With .parameters
                    .AddWithValue("salesagentids", Me.recordid)
                    .AddWithValue("salesagents", Me.SalesAgent.Text)
                    .AddWithValue("contactnos", Me.ContactNo.Text)
                    .AddWithValue("emails", Me.Email.Text)
                    .addwithvalue("descriptions", Me.description.text)
                    .addwithvalue("actives", Me.active.checked)
                    .addwithvalue("datecreateds", "" & now)
                    .addwithvalue("creators", APCESMainForm.userfullname.text)
                    .addwithvalue("tosave", Me.tosave)
                End With
                .executenonquery()
                con.close()
                command.dispose()
                Me.tosave = False
                Me.Reference.Text = "" & Me.recordid.ToString("d10")
                showmessage("the record has been successfully saved.", "command executed", "command success!", 3)
                SalesAgentMainForm.refreshgrid_click()
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
                Me.recordid = .Item("salesagentid")
                Me.SalesAgent.Text = .Item("salesagent")
                Me.Email.Text = .Item("email")
                Me.ContactNo.Text = .Item("ContactNo")
                Me.description.text = .item("description")
                Me.active.checked = .item("active")
                Me.Reference.Text = "" & Me.recordid.ToString("d10")
                Me.tosave = False
            End With
        Catch ex As exception
            'showMessage(ex.Message, "exception found", "contact system admin", 1)
        End Try
    End Sub
End Class

