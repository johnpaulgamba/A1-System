Imports mysql.data.mysqlclient
Public Class ShippingAddressEntry
    Private tosave As Boolean = True
    Private recordid As Integer = 0
    Sub New(ByVal id As Integer)
        InitializeComponent()
        loadingvaluestoComboBoxes("Select customername, customerid from customers where companyid='" & companyid & _
                                   "' order by customername asc", Customername, "customername", "customerid")
        If id = 0 Then Me.tosave = True : Exit Sub
        loadentry("select * from ShipAddress where Shipid=" & id)
    End Sub
    Private Sub buttonnew_click(ByVal sender As system.object, ByVal e As system.eventargs) Handles buttonnew.click
        Me.ShippingAddress.text = Nothing
        Me.Reference.Text = Nothing
        Me.Active.Checked = True
        Me.ShippingAddress.text = Nothing
        Me.buttonsave.enabled = True
        Me.tosave = True
    End Sub

    Private Sub buttonclose_click(ByVal sender As system.object, ByVal e As system.eventargs) Handles buttonclose.click
        Me.close()
    End Sub

    Private Sub buttonsave_click(ByVal sender As system.object, ByVal e As system.eventargs) Handles buttonsave.click
        If Me.ShippingAddress.text.replace(" ", "") = Nothing Then
            showMessage("you are required to input shipping address.", "invalid input", "input not valid", 4)

            Exit Sub

        ElseIf Me.Customername.Text = Nothing Then
            showMessage("you are required to select customer.", "invalid input", "input not valid", 4)
            Exit Sub
        End If
        If Me.tosave = True Then
            Me.recordid = searchRecord("select auto_increment from information_schema.tables where  table_schema='" & database & "' and table_name='shipaddress';", 1)
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
                .CommandText = "admin_ShippingAddress_entry"
                .commandtype = commandtype.storedprocedure
                .connection = con
                With .parameters
                    .AddWithValue("Shipids", Me.recordid)
                    .AddWithValue("customerids", Me.Customername.SelectedValue)
                    .AddWithValue("ShipAddresss", Me.ShippingAddress.Text)
                    .AddWithValue("actives", Me.Active.Checked)
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
                ShippingAddressMainForm.refreshgrid_click()
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
                Me.recordid = .Item("Shipid")
                Me.Customername.SelectedValue = .Item("customerid")
                Me.ShippingAddress.Text = .Item("ShipAddress")
                Me.Active.Checked = .Item("active")
                Me.Reference.Text = "" & Me.recordid.ToString("d10")
                Me.tosave = False
            End With
        Catch ex As exception
            'showMessage(ex.Message, "exception found", "contact system admin", 1)
        End Try
    End Sub
End Class

