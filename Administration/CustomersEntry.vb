Imports mysql.data.mysqlclient
Public Class customersentry
    Private tosave As Boolean = True
    Private recordid As Integer = 0
    Sub New(ByVal id As Integer)
        InitializeComponent()
        loadingvaluestoComboBoxes1("Select distinct terms from customers order by terms asc", terms, "terms", "terms")
        ' loadingvaluestocomboboxes_storedproc("admin_warehouse_combobox_activeonly", me.businesstype, "warehousename", "warehouseid")
        If id = 0 Then Me.tosave = True : Exit Sub
        loadentry("select * from customers where customerid=" & id)

    End Sub

    Private Sub buttonnew_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonNew.Click
        Me.CustomerName.Text = Nothing
        Me.Reference.Text = Nothing
        Me.Active.Checked = True
        Me.ButtonSave.Enabled = True
        Me.ShipAddress.Text = Nothing
        Me.BillAddress.Text = Nothing
        Me.ContactPerson.Text = Nothing
        Me.ContactNo.Text = Nothing
        Me.VatType.SelectedItem = 0
        Me.TIN.Text = Nothing
        Me.Businesstype.SelectedIndex = -1
        Me.TaxType.Text = "vatable"
        Me.EmailAddress.Text = Nothing
    End Sub

    Private Sub buttonclose_click(ByVal sender As system.object, ByVal e As system.eventargs) Handles buttonclose.click
        Me.close()
    End Sub

    Private Sub buttonsave_click(ByVal sender As system.object, ByVal e As system.eventargs) Handles buttonsave.click
        If Me.customername.text.replace(" ", "") = Nothing Then
            showMessage("Please .", "invalid input", "input not valid", 4)
            Exit Sub
        End If
        If Me.tosave = True Then
            Me.recordid = searchrecord("select auto_increment from information_schema.tables where  table_schema='" & database & "' and table_name='customers';", 1)
            savecommand()
        Else
            savecommand()
        End If
    End Sub
    Private Sub savecommand()
        ' Try
        connect()
        con.Open()
        Dim command As New MySqlCommand
        With command
            .CommandText = "admin_customers_entry"
            .CommandType = CommandType.StoredProcedure
            .Connection = con
            With .Parameters
                .AddWithValue("customerids", Me.recordid)
                .AddWithValue("companyids", companyid)
                .AddWithValue("customernames", Me.CustomerName.Text)
                .AddWithValue("termss", Me.terms.Text)
                .AddWithValue("vattypes", Me.VatType.Text)
                .AddWithValue("actives", Me.Active.Checked)
                .AddWithValue("datecreateds", "" & Now)
                .AddWithValue("shipaddresss", Me.BillAddress.Text)
                .AddWithValue("billaddresss", Me.BillAddress.Text)
                .AddWithValue("contactpersons", Me.ContactPerson.Text)
                .AddWithValue("contactnos", Me.ContactNo.Text)
                .AddWithValue("tins", Me.TIN.Text)
                .AddWithValue("businesstypes", Me.Businesstype.Text)
                .AddWithValue("taxtypes", Me.TaxType.Text)
                .AddWithValue("creators", APCESMainForm.UserFullName.Text)
                .AddWithValue("tosave", Me.tosave)
                .AddWithValue("emailaddresss", Me.EmailAddress.Text)
            End With
            .ExecuteNonQuery()
            command.Dispose()
            con.Close()



            shipaddressz(Me.recordid, "", C1FlexGrid1)


            Me.tosave = False
            Me.Reference.Text = "" & Me.recordid.ToString("d10")
            showMessage("the record has been successfully saved.", "command executed", "command success!", 3)
            customersmainform.refreshgrid_click()
        End With
        'Catch ex As exception
        '     'showMessage(ex.Message, "exception found", "contact system admin", 1)
        'End Try
    End Sub
    Public Sub shipaddressz(ByVal id As Integer, ByVal b As String, ByVal flexgrid As C1.Win.C1FlexGrid.C1FlexGrid)

        Dim x As Integer = 1
        Dim y As Integer = flexgrid.Rows.Count - 1
        For x = 1 To y
            With flexgrid.Rows(x)
                If .Item("shipaddress") = Nothing Then Continue For
                connect()
                con.Open()
                command = New MySqlCommand("Select * from shipaddress where customerid='" & id & "' and shipid='" & .Item("shipid") & "'", con)
                reader = command.ExecuteReader
                If reader.Read = False Then
                    reader.Close()
                    command = New MySqlCommand("Insert into shipaddress(shipaddress,customerid,creator,datecreated) values ('" & .Item("Shipaddress") & "','" & id & "','" & APCESMainForm.UserAccountName.Text & "',now())", con)
                    command.ExecuteNonQuery()
                    command.Dispose()
                End If

                command.Dispose()
                con.Close()

                If Me.tosave = False Then
                    saveEditDelete("UPDATE shipaddress set shipaddress='" & .Item("Shipaddress") & "', lastupdate=now() where shipid = '" & .Item("shipid") & "'", "wala")
                End If
            End With


        Next


    End Sub
    Private Sub loadentry(ByVal sql As String)
        Try
            connect()
            con.Open()
            Dim adapter As New MySqlDataAdapter(sql, con)
            Dim ds As New DataSet
            With adapter
                .SelectCommand.CommandType = CommandType.Text
                .Fill(ds)
            End With
            adapter.Dispose()
            con.Close()
            With ds.Tables(0).Rows(0)
                Me.recordid = .Item("customerid")
                Me.CustomerName.Text = .Item("customername")
                Me.Active.Checked = .Item("active")
                Me.Reference.Text = "" & Me.recordid.ToString("d10")
                Me.ShipAddress.Text = .Item("shipaddress")
                Me.BillAddress.Text = .Item("billaddress")
                Me.ContactPerson.Text = .Item("Contactperson")
                Me.Businesstype.Text = .Item("businesstype")
                Me.TIN.Text = .Item("tin")
                Me.terms.Text = .Item("terms")
                Me.VatType.Text = .Item("vattype")
                Me.ContactNo.Text = .Item("contactno")
                Me.TaxType.Text = .Item("taxtype")
                Me.EmailAddress.Text = .Item("emailaddress")
                loadtoGridNoFixed("Select shipid, shipaddress from shipaddress where customerid='" & Me.recordid & "'", C1FlexGrid1)
                Me.C1FlexGrid1.Rows.Add(2)
                Me.tosave = False
            End With
        Catch ex As Exception
            'showMessage(ex.Message, "exception found", "contact system admin", 1)
        End Try
    End Sub

   
    Private Sub C1FlexGrid1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1FlexGrid1.Click

    End Sub

    Private Sub C1FlexGrid1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1FlexGrid1.KeyDown
        Try

       
        If e.KeyCode = Keys.Delete Then
                Dim sagot As MsgBoxResult = MessageBox.Show("performing the command will delete the address. do you want to proceed?", "perform delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Stop)
            If sagot = MsgBoxResult.Yes Then
                    saveEditDelete("delete from shipaddress where shipid='" & Me.C1FlexGrid1.Rows(Me.C1FlexGrid1.RowSel).Item("shipid") & "'", "wala")
                    Me.C1FlexGrid1.Rows.Remove(Me.C1FlexGrid1.RowSel)

            End If '
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TaxType_ChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TaxType.ChangeCommitted

    End Sub

    Private Sub TaxType_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TaxType.LostFocus
        Me.terms.Focus()
    End Sub

    Private Sub terms_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles terms.LostFocus
        Me.VatType.Focus()
    End Sub

    Private Sub terms_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles terms.SelectedIndexChanged

    End Sub

    Private Sub CustomerName_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles CustomerName.Validated
        If tosave = True Then
            connect()
            con.Open()
            command = New MySqlCommand("select * from customers where customername like '%" & CustomerName.Text & "%' and companyid='" & companyid & "'", con)
            reader = command.ExecuteReader
            If reader.Read = True Then
                showMessage("Please retype new customer", "Customer already exist on our records", "Duplicate customer", 3)
                Exit Sub
            End If
        End If
    End Sub
End Class

