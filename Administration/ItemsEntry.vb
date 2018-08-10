Imports mysql.data.mysqlclient
Public Class itemsentry
    Private tosave As Boolean = True
    Private recordid As Integer = 0
    Sub New(ByVal id As Integer)
        InitializeComponent()
        loadingvaluestoComboBoxes1("Select distinct category from items order by category asc", Category, "category", "category")
        If id = 0 Then Me.tosave = True : Exit Sub
        loadentry("select * from items where itemid=" & id)
    End Sub
    Private Sub buttonnew_click(sender As system.object, e As system.eventargs) Handles buttonnew.click
        Me.itemsname.text = Nothing
        Me.reference.text = Nothing
        Me.active.checked = True
        Me.description.text = Nothing
        Me.buttonsave.enabled = True
        Me.tosave = True
    End Sub

    Private Sub buttonclose_click(sender As system.object, e As system.eventargs) Handles buttonclose.click
        Me.close()
    End Sub

    Private Sub buttonsave_click(sender As system.object, e As system.eventargs) Handles buttonsave.click
        If Me.itemsname.text.replace(" ", "") = Nothing Then
            showmessage("you are required to input item name.", "invalid input", "input not valid", 4)
            Exit Sub



        End If
        If Me.tosave = True Then
            connect()
            con.Open()
            command = New MySqlCommand
            With command
                .CommandText = ("Select * from items where itemcode='" & Me.itemcode.Text & "'")
                .Connection = con
                reader = command.ExecuteReader
            End With
            If reader.Read = True Then : showMessage("Itemcode already exist", "Itemcode already exist", "Already exist", 1) : Exit Sub : End If

            Me.recordid = searchRecord("select auto_increment from information_schema.tables where  table_schema='" & database & "' and table_name='items';", 1)
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
                .commandtext = "admin_items_entry"
                .CommandType = CommandType.StoredProcedure
                .connection = con
                With .parameters
                    .AddWithValue("itemids", Me.recordid)
                    .AddWithValue("itemcodes", Me.itemcode.Text)
                    .AddWithValue("unitprices", Me.price.Value)
                    .AddWithValue("categorys", Me.Category.Text)
                    .AddWithValue("companyids", companyid)
                    .addwithvalue("itemnames", Me.itemsname.text)
                    .addwithvalue("descriptions", Me.description.text)
                    .addwithvalue("actives", Me.active.checked)
                    .AddWithValue("datecreateds", "" & Now)
                    .addwithvalue("creators", APCESMainForm.userfullname.text)
                    .addwithvalue("uoms", Me.uom.text)
                    .addwithvalue("tosave", Me.tosave)
                End With
                .executenonquery()
                con.close()
                command.dispose()
                Me.tosave = False
                Me.Reference.Text = "" & Me.recordid.ToString("d10")
                showmessage("the record has been successfully saved.", "command executed", "command success!", 3)
                itemsmainform.refreshgrid_click()
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
                Me.recordid = .Item("itemid")
                Me.itemcode.Text = .Item("itemcode")
                Me.price.Value = .Item("unitprice")
                Me.Category.Text = .Item("category")
                Me.itemsname.text = .item("itemname")
                Me.description.text = .item("description")
                Me.uom.text = .item("uom")
                Me.active.checked = .item("active")
                Me.Reference.Text = "msi   " & Me.recordid.ToString("d10")
                Me.tosave = False
            End With
        Catch ex As exception
            showMessage(ex.Message, "exception found", "contact system  admin", 1)
        End Try
    End Sub

    Private Sub ItemsName_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ItemsName.LostFocus
        Me.Category.Focus()
    End Sub

    Private Sub ItemsName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemsName.TextChanged

    End Sub

    Private Sub Category_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Category.LostFocus
        Me.Description.Focus()
    End Sub

    Private Sub ItemsName_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles ItemsName.Validated
        If tosave = True Then
            connect()
            con.Open()
            command = New MySqlCommand("select * from items where itemname like '%" & ItemsName.Text & "%' and companyid='" & companyid & "'", con)
            reader = command.ExecuteReader
            If reader.Read = True Then
                showMessage("Please retype new item", "Item already exist on our records", "Duplicate item", 3)
            End If
        End If
    End Sub
End Class

