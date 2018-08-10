Imports mysql.data.mysqlclient
Public Class vehicleentry
    Private tosave As Boolean = True
    Private recordid As Integer = 0
    Sub New(ByVal id As Integer)
        initializecomponent()
        If id = 0 Then Me.tosave = True : Exit Sub
        loadentry("select * from vehicle where vehicleid=" & id)
    End Sub
    Private Sub buttonnew_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonNew.Click
        Me.VehicleName.text = Nothing
        Me.reference.text = Nothing
        Me.active.checked = True
        Me.description.text = Nothing
        Me.buttonsave.enabled = True
        Me.tosave = True
    End Sub

    Private Sub buttonclose_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClose.Click
        Me.close()
    End Sub

    Private Sub buttonsave_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSave.Click
        If Me.VehicleName.text.replace(" ", "") = Nothing Then
            showmessage("you are required to input vehicle name.", "invalid input", "input not valid", 4)
            Exit Sub
        End If
        If Me.tosave = True Then
            Me.recordid = searchrecord("select auto_increment from information_schema.tables where  table_schema='" & database & "' and table_name='vehicle';", 1)
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
                .commandtext = "admin_vehicle_entry"
                .commandtype = commandtype.storedprocedure
                .connection = con
                With .parameters
                    .addwithvalue("vehicleids", Me.recordid)
                    .AddWithValue("vehiclenames", Me.VehicleName.Text)
                    .AddWithValue("platenos", Me.PlateNo.Text)
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
                Me.reference.text = "sh " & Me.recordid.tostring("d10")
                showmessage("the record has been successfully saved.", "command executed", "command success!", 3)
                VehicleMainForm.refreshgrid_click()
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
                Me.recordid = .item("vehicleid")
                Me.VehicleName.Text = .Item("vehiclename")
                Me.PlateNo.Text = .Item("plateno")
                Me.description.text = .item("description")
                Me.active.checked = .item("active")
                Me.reference.text = "sh  " & Me.recordid.tostring("d10")
                Me.tosave = False
            End With
        Catch ex As exception
            'showMessage(ex.Message, "exception found", "contact system admin", 1)
        End Try
    End Sub
End Class

