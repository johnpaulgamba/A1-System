Imports mysql.data.mysqlclient
Public Class user_modulesprofilepermissionsetup01
    Sub New()
        initializecomponent()
        Me.administrationgrid.visualstyle = c1.win.c1flexgrid.visualstyle.system
        loadingvaluestocomboboxes("select profileid, profilename from user_permission_profile where active=1 order by profilename", Me.username, "profilename", "profileid")
        AddHandler Me.username.selectedindexchanged, AddressOf username_selectedindexchanged
    End Sub
    Private Sub loaddata(ByVal a As Integer)

        loadtogrid("select moduleid, (case when moduleid in (select moduleid from user_access_setup where profileid='" & a & _
                              "') then true else false end),  modulename, description from user_permission_modules x where active=1 and groupid in ( " & _
                                 " select groupid from user_permission_group where groupname ='administrations' and active=1) order by modulename, description", Me.administrationgrid)
        loadtogrid("select moduleid, (case when moduleid in (select moduleid from user_access_setup where profileid='" & a & _
                              "') then true else false end),  modulename, description from user_permission_modules x where active=1 and groupid in ( " & _
                                " select groupid from user_permission_group where groupname ='main transactions' and active=1) order by modulename, description", Me.salesgrid)
        loadtogrid("select moduleid,(case when moduleid in (select moduleid from user_access_setup where profileid='" & a & _
                              "') then true else false end),  modulename, description from user_permission_modules x where active=1 and groupid in ( " & _
                                " select groupid from user_permission_group where groupname ='reports' and active=1) order by modulename, description", Me.warehousegrid)
    End Sub
    Public Sub loadtogrid(ByVal sql As String, ByVal b As c1.win.c1flexgrid.c1flexgrid)
        Try

            Dim adapter As New mysqldataadapter
            Dim ds As New dataset
            connect()
            con.open()
            adapter = New mysqldataadapter(sql, con)
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
    Private Sub inputbutton3_click(ByVal sender As system.object, ByVal e As system.eventargs) Handles inputbutton3.click
        Me.close()
    End Sub
    Private Sub homegrid_cellchecked(ByVal sender As system.object, ByVal e As c1.win.c1flexgrid.rowcoleventargs) Handles salesgrid.cellchecked, _
        administrationgrid.cellchecked, _
        warehousegrid.cellchecked
        checkuncheck(CType(sender, c1.win.c1flexgrid.c1flexgrid), e.row)
    End Sub
    Private Sub checkuncheck(ByVal griddd As c1.win.c1flexgrid.c1flexgrid, ByVal e As Integer)
        With griddd.rows(e)
            If .item("check") = True Then
                .stylenew.backcolor = color.lavenderblush
            Else
                .clear(c1.win.c1flexgrid.clearflags.style)
            End If
        End With
    End Sub
    Private Sub saverecordbutton_click(ByVal sender As system.object, ByVal e As system.eventargs) Handles saverecordbutton.click
        Try

            If Me.username.selectedvalue.equals(dbnull.value) Then showmessage("profile name cannot be null. select valid profile name", "username cannot be null", "username is empty", 1) : Exit Sub
            saveeditdelete("delete from user_access_setup where profileid='" & Me.username.selectedvalue & "'", "wala")

            application.doevents()
            savecommand()
        Catch ex As exception
        Finally
            showmessage("user profile and permissions has been updated", "user permission created", "creation completed", 3)

        End Try
    End Sub
    Private Sub savecommand()
        Try
            connect()
            con.open()
            command = New mysqlcommand
            With command
                .commandtype = commandtype.text
                .connection = con
                Try
                    .commandtext = "insert into user_access_setup (userid, moduleid, datecreated, lastupdate, employeeid, creatorntuser, changesmade, profileid) " & _
                        " values " & saveorders2(administrationgrid)
                    .executenonquery()
                Catch ex As exception
                End Try
                Try
                    .commandtext = "insert into user_access_setup (userid, moduleid, datecreated, lastupdate, employeeid, creatorntuser, changesmade, profileid) " & _
                        " values " & saveorders2(salesgrid)
                    .executenonquery()
                Catch ex As exception
                End Try
                Try
                    .commandtext = "insert into user_access_setup (userid, moduleid, datecreated, lastupdate, employeeid, creatorntuser, changesmade, profileid) " & _
                        " values " & saveorders2(warehousegrid)
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
    Private Function saveorders2(ByVal flexgrid As c1.win.c1flexgrid.c1flexgrid) As String
        Dim z11 As String = ""
        Try

            Dim x As Integer = 1
            Dim y As Integer = flexgrid.rows.count - 1
            For x = 1 To y
                With flexgrid.rows(x)
                    Dim itemre As String = ""
                    If .item("check") = False Then Continue For
                    z11 = z11 & " " & "(0,'" & .item("moduleid") & "','" & now & "', 'none',0,  '" & APCESMainForm.useraccountname.text & "',  '', '" & Me.username.selectedvalue & "')            "
                End With
            Next
        Catch ex As exception
        End Try
        Return ltrim(rtrim(z11)).replace("            ", ",")
    End Function
    Private Sub username_selectedindexchanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim i As Integer = 0
        Try
            i = Me.UserName.SelectedValue
        Catch ex As Exception
            i = 0
        End Try
        loaddata(i)
    End Sub



    Private Sub clearbutton_click(sender As System.Object, e As System.EventArgs) Handles ClearButton.Click
        Me.UserName.SelectedIndex = -1
    End Sub
End Class

