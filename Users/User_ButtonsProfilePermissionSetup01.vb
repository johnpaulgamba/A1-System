Imports mysql.data.mysqlclient
Public Class user_buttonsprofilepermissionsetup01
    Sub New()

        ' this call is required by the designer.
        initializecomponent()
        loadingvaluestocomboboxes("select profileid, profilename from user_permission_profile where active=1 order by profilename", Me.username, "profilename", "profileid")
        AddHandler Me.username.selectedvaluechanged, AddressOf username_selectedindexchanged
    End Sub
    Private Sub username_selectedindexchanged()
        Dim i As Integer = -1
        Try
            i = Me.username.selectedvalue
            loaddata(i)
        Catch ex As exception
        End Try
    End Sub
    Private Sub loaddata(ByVal a As Integer)

        loadall(a, "administrations", administrationgrid)
        loadall(a, "main transactions", maintransactionsgrid)
        loadall(a, "reports", reportsgrid)
    End Sub
    Public Sub loadtogrid2(ByVal sql As String, ByVal b As c1.win.c1flexgrid.c1flexgrid)
        Try

            Dim adapter As New mysqldataadapter
            Dim ds As New dataset
            connect()
            con.open()
            adapter = New mysqldataadapter("loadalldata", con)
            adapter.selectcommand.commandtype = commandtype.storedprocedure
            adapter.selectcommand.parameters.addwithvalue("@stringquery", sql.tostring.tolower)
            adapter.selectcommand.commandtimeout = 50000
            ds = New dataset
            adapter.fill(ds)
            con.close()
            con.dispose()
            With b
                .redraw = False
                .rows.count = ds.tables(0).rows.count + 1
                .cols.count = ds.tables(0).columns.count + 2
                Dim dr As datarow, dc As datacolumn
                Dim rowindex%, colindex%
                rowindex = 1
                For Each dr In ds.tables(0).rows
                    colindex = 1
                    b(rowindex, 0) = rowindex
                    For Each dc In ds.tables(0).columns
                        b(rowindex, colindex) = dr(dc)
                        colindex = colindex + 1
                    Next
                    .rows(rowindex).clear(c1.win.c1flexgrid.clearflags.style)
                    checkuncheck(b, rowindex)
                    rowindex = rowindex + 1
                Next
                b.autosizecols()
                .redraw = True
            End With
        Catch ex As exception
            'messagebox.show(ex.message)
        Finally
        End Try
    End Sub
    Private Sub loadall(ByVal userid As Integer, ByVal name As String, ByVal grid As c1.win.c1flexgrid.c1flexgrid)
        loadtogrid2("select buttonid, (case when y.buttonid in (select buttonid from user_access_setup_button where profileid='" & userid & _
                             "') then true else false end),  modulename, nameofbutton, y.description from user_permission_modules x, user_permission_modules_buttons y, " & _
                             " user_access_setup z where z.moduleid=y.moduleid and  z.profileid='" & userid & "' and  x.moduleid=y.moduleid and x.active=1 and y.active=1 and  groupid in ( " & _
                             " select groupid from user_permission_group where groupname ='" & name & "' and active=1) group by buttonid  order by modulename, nameofbutton, y.description ", grid)

    End Sub
    Private Sub inputbutton3_click(ByVal sender As system.object, ByVal e As system.eventargs) Handles inputbutton3.click
        Me.close()
    End Sub
    Private Sub homegrid_cellchecked(ByVal sender As system.object, ByVal e As c1.win.c1flexgrid.rowcoleventargs) Handles maintransactionsgrid.cellchecked, _
          administrationgrid.cellchecked, reportsgrid.cellchecked
        checkuncheck(CType(sender, c1.win.c1flexgrid.c1flexgrid), e.row)
    End Sub
    Private Sub checkuncheck(ByVal griddd As c1.win.c1flexgrid.c1flexgrid, ByVal e As Integer)
        With griddd.rows(e)
            If .item("check") = True Then
                .stylenew.backcolor = color.lavenderblush
                .stylenew.border.style = c1.win.c1flexgrid.borderstyleenum.none
            Else
                .clear(c1.win.c1flexgrid.clearflags.style)
            End If
        End With
    End Sub
    Private Sub saverecordbutton_click(ByVal sender As system.object, ByVal e As system.eventargs) Handles saverecordbutton.click
        Try
            If Me.username.selectedvalue.equals(dbnull.value) Then showmessage("profile name cannot be null. select valid username", "profile name cannot be null", "user profile is empty", 3) : Exit Sub
            saveeditdelete("delete from user_access_setup_button where profileid='" & Me.username.selectedvalue & "'", "wala")

            savecommand()
        Catch ex As exception
        Finally
            showmessage("user profile and permissions has been updated", "user permission created", "creation completed", 2)

        End Try
    End Sub

    Private Function saveorders2(ByVal flexgrid As c1.win.c1flexgrid.c1flexgrid) As String
        Dim z11 As String = ""
        Try

            Dim x As Integer = 1
            Dim y As Integer = flexgrid.rows.count - 1
            For x = 1 To y
                With flexgrid.rows(x)
                    Dim itemre As String = ""
                    If .item("check") = False Then Continue For
                    z11 = z11 & " " & "(0, '" & .item("moduleid") & _
                        "', '" & now & "', 'none',0, '" & APCESMainForm.useraccountname.text & "',  '','" & Me.username.selectedvalue & "')            "
                End With
            Next
        Catch ex As exception
        End Try
        Return ltrim(rtrim(z11)).replace("            ", ",")
    End Function
    Private Sub savecommand()
        Try
            connect()
            con.open()
            command = New mysqlcommand
            With command
                .commandtype = commandtype.text
                .connection = con
                Try
                    .commandtext = "insert into user_access_setup_button (userid, buttonid, datecreated, lastupdate, employeeid, creatorntuser, changesmade, profileid) values " & saveorders2(administrationgrid)
                    .executenonquery()
                Catch ex As exception
                End Try
                Try
                    .commandtext = "insert into user_access_setup_button (userid, buttonid, datecreated, lastupdate, employeeid, creatorntuser, changesmade, profileid) values " & saveorders2(maintransactionsgrid)
                    .executenonquery()
                Catch ex As exception
                End Try
                Try
                    .commandtext = "insert into user_access_setup_button (userid, buttonid, datecreated, lastupdate, employeeid, creatorntuser, changesmade, profileid) values " & saveorders2(reportsgrid)
                    .executenonquery()
                Catch ex As exception
                End Try

            End With
        Catch ex As exception
        Finally
            con.close()
            command.dispose()
        End Try
    End Sub
End Class

