Imports mysql.data.mysqlclient
Public Class customersmainform

    Private Sub customermainform_load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.C1NavBar1.PanelHeaderFont = New Font("arial", 12, FontStyle.Bold)
        Me.C1NavBar2.PanelHeaderFont = New Font("arial", 12, FontStyle.Bold)
        loadingvaluestoComboBoxes("select distinct terms from customers order by terms asc", terms, "terms", "terms")
        loadingvaluestoComboBoxes("select distinct vattype from customers order by vattype asc", vattype, "vattype", "vattype")
        loadingvaluestoComboBoxes("select distinct taxtype from customers order by taxtype asc", taxtype, "taxtype", "taxtype")
        loaddata("admin_customers_main", " where companyid= '" & companyid & "' ", Me.C1FlexGrid1)
    End Sub
    Private filter As String = ""
    Private Sub searchbutton_click(sender As system.object, e As system.eventargs) Handles searchbutton.click
        Try

      
            Dim filterquery As String = " where a.datecreated like '%" & convertQuotes(Me.DateCreated.Text) & _
                "%' and a.customername like '%" & convertQuotes(Me.CustomerName.Text) & _
                "%' and a.billaddress like '%" & convertQuotes(Me.Address.Text) & _
                "%' and a.contactno like '%" & convertQuotes(Me.ContactNo.Text) & _
                "%' and a.tin like '%" & convertQuotes(Me.TIN.Text) & _
                "%' and a.lastupdate like '%" & convertQuotes(Me.LastUpdate.Text) & _
                "%' and a.creator like '%" & convertQuotes(Me.Creator.Text) & _
                "%' and a.taxtype like '%" & convertQuotes(Me.taxtype.Text) & _
                "%' and a.vattype like '%" & convertQuotes(Me.vattype.Text) & _
                "%' and a.terms like '%" & convertQuotes(Me.terms.Text) & _
                "%' and a.emailaddress like '%" & convertQuotes(Me.EmailAddress.Text) & _
                "%' and a.businesstype like '%" & convertQuotes(Me.Businesstype.Text) & _
            "%' and a.companyid like '%" & companyid & _
                "%'  "
        Me.filter = filterquery
        loaddata("admin_customers_main", filter, Me.c1flexgrid1)
        Catch ex As Exception
            'messagebox.show(ex.message)
        End Try
    End Sub

    Private Sub addnew_click(sender As system.object, e As c1.win.c1command.clickeventargs) Handles addnew.click
        Dim x As New customersentry(0)
        With x
            .startposition = formstartposition.centerscreen
            .showdialog()
        End With
    End Sub

    Private Sub editrecord_click(ByVal sender As system.object, ByVal e As c1.win.c1command.clickeventargs) Handles editrecord.click
        Try
            Dim id As Integer = Me.c1flexgrid1.rows(Me.c1flexgrid1.rowsel).item("customerid")
            Dim x As New customersentry(id)
            With x
                .startposition = formstartposition.centerscreen
                .showdialog()
            End With
        Catch ex As exception
            'showMessage(ex.Message, "exception found", "contact system admin", 1)
        End Try
    End Sub
    Private newstringcollec As New system.collections.specialized.stringcollection
    Public Sub loadallcommands(ByVal classname As String, ByVal storedproc As String)
        Try
            connect()
            con.open()
            Dim adapter As New mysqldataadapter
            Dim ds As New dataset
            adapter = New mysqldataadapter(storedproc, con)
            adapter.selectcommand.commandtype = commandtype.storedprocedure
            adapter.selectcommand.parameters.addwithvalue("@id", APCESMainForm.employeeid.text)
            adapter.selectcommand.parameters.addwithvalue("@classnames", classname)
            adapter.fill(ds)
            con.close()
            newstringcollec.clear()
            For Each row As datarow In ds.tables(0).rows
                newstringcollec.add(row.item("commandname").tostring.tolower)
            Next
            For Each x As c1.win.c1command.c1command In Me.c1commandholder1.commands
                If x.name.tolower.contains("c1contextmenu") Then
                    x.enabled = True
                ElseIf x.name.tolower = "c1command1" Or x.name.contains("runcmd") Then
                    x.enabled = True
                ElseIf newstringcollec.contains(x.name.tolower) Then
                    x.enabled = True
                Else
                    x.enabled = False
                End If
            Next
        Catch ex As exception
            showmessage(ex.message, "exception found", application.productname.tostring, 1)
        End Try
    End Sub

    Private Sub C1FlexGrid1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1FlexGrid1.DoubleClick
        Try
            Dim id As Integer = Me.C1FlexGrid1.Rows(Me.C1FlexGrid1.RowSel).Item("customerid")

            Dim x As New customersentry(id)
            With x
                .ButtonSave.Enabled = True
                .StartPosition = FormStartPosition.centerscreen
                .ShowDialog()
            End With
        Catch ex As Exception
            'showMessage(ex.Message, "exception found", "contact system admin", 1)
        End Try
    End Sub
    Private Sub c1flexgrid1_mouseclick(ByVal sender As system.object, ByVal e As system.windows.forms.mouseeventargs) Handles c1flexgrid1.mouseclick
        Try
            DataGridView1_MouseClick(sender, e, Me.C1FlexGrid1, Me.C1ContextMenu1)
            If (e.Button = Windows.Forms.MouseButtons.Right) Then
                C1ContextMenu1.ShowContextMenu(C1FlexGrid1, e.Location)
            End If
        Catch ex As Exception
            'showMessage(ex.Message, "exception found", "contact system admin", 1)
        End Try
    End Sub

    Private Sub exportgriddata_click(ByVal sender As system.object, ByVal e As c1.win.c1command.clickeventargs) Handles exportgrid.click
        exportgriddata(Me.c1flexgrid1)
    End Sub

    Public Sub refreshgrid_click() Handles refreshgrid.click
        loaddata("admin_customers_main", " where companyid= '" & companyid & "' ", Me.C1FlexGrid1)
    End Sub

    Private Sub clearbutton_click(sender As system.object, e As system.eventargs) Handles clearbutton.click
        Me.lastupdate.text = Nothing
        Me.datecreated.text = Nothing
        Me.customername.text = Nothing
        Me.description.text = Nothing
        Me.contactno.text = Nothing
        Me.tin.text = Nothing
        Me.address.text = Nothing
        Me.Businesstype.Text = Nothing
        Me.terms.Text = ""
        Me.vattype.Text = ""
        Me.taxtype.Text = ""
        loaddata("admin_customers_main", " where companyid= '" & companyid & "' ", Me.C1FlexGrid1)
    End Sub
End Class


