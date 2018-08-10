Imports mysql.data.mysqlclient
Public Class itempricelistentry
    Sub New()

        ' this call is required by the designer.
        initializecomponent()
        loadingvaluestocomboboxes_storedproc("admin_branches_combobox_activeonly", Me.branch, "branchname", "branchid")
    End Sub
    Private Sub searchbutton_click(ByVal sender As system.object, ByVal e As system.eventargs) Handles searchbutton.click
        Try
            If Me.branch.text = Nothing Then showmessage("you are required to select valid branch!", "invalid branch", "invalid branch", 3) : Exit Sub
            Dim isfg As String = ""
            Dim isrm As String = ""
            Dim itemnamefilter As String = ""
            If Me.itemtype.text.tolower = "both" Then
                isfg = ""
                isrm = ""
            ElseIf Me.itemtype.text.tolower = "finished goods" Then
                isfg = " and isfg=1 "
            ElseIf Me.itemtype.text.tolower = "raw materials" Then
                isrm = " and isrm=1 "
            End If
            itemnamefilter = " and itemname like '%" & convertquotes(Me.itemname.text) & "%'"
            filter(isfg & isrm & itemnamefilter)
            Me.branchname.text = Me.branch.text
            Me.branchid.text = Me.branch.selectedvalue
        Catch ex As exception

        End Try

    End Sub
    Private Sub filter(ByVal filterquery As String)
        loadtogridnofixed("select a.itemid, concat('msi  ', a.itemid) as reference, " & _
                   " itemname, uom, coalesce(unitprice, 0), '' from items a " & _
                   " left join pricelist b on a.itemid=b.itemid and  branchid=" & Me.branch.selectedvalue & _
                   " where a.active=1 " & filterquery & " order by itemname", Me.c1flexgrid1)

    End Sub

    Private Sub savepricelist_click(ByVal sender As system.object, ByVal e As system.eventargs) Handles savepricelist.click
        Try
            For i As Integer = 1 To Me.c1flexgrid1.rows.count - 1
                With Me.c1flexgrid1.rows(i)
                    connect()
                    con.open()
                    Dim command As New mysqlcommand
                    command.commandtext = "delete from pricelist where itemid=" & .item("itemid")
                    command.connection = con
                    command.executenonquery()
                    command.dispose()
                    Dim commandnew As New mysqlcommand
                    command.commandtext = "insert into pricelist (itemid, unitprice, active, branchid) values ('" & .item("itemid") & _
                        "', '" & .item("unitprice") & "', '1', '" & Me.branchid.text & "')"
                    command.connection = con
                    command.executenonquery()
                    command.dispose()
                End With
            Next
            showmessage("the pricelist has been successfully updated.", "pricelist updated", "command exceuted", 2)
        Catch ex As exception
        End Try
    End Sub

    Private Sub inputbutton2_click(ByVal sender As system.object, ByVal e As system.eventargs) Handles inputbutton2.click
        Me.close()

    End Sub

    Private Sub inputbutton3_click(ByVal sender As system.object, ByVal e As system.eventargs) Handles inputbutton3.click
        Me.itemtype.text = "both"
        Me.itemname.text = Nothing
        Me.branchname.text = Nothing

    End Sub
End Class

