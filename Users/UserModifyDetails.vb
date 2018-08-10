Imports mysql.data.mysqlclient
Public Class useraccountmodifydetails
    Public tosave As Boolean = True
    Private userid As Integer = 0
    Sub New(ByVal id As Integer)

        ' this call is required by the designer.
        initializecomponent()
        loadingvaluestocomboboxes_storedproc("select departmentname from departments where active=1 order by departmentname", Me.department, "departmentname", "departmentname")
        Me.userid = id
        loaddetails("select * from user_access where userid=" & id)
    End Sub
    Private Sub loaddetails(ByVal a As String)
        Try
            Dim ds As New dataset
            connect()
            con.open()
            Dim adapter As New mysqldataadapter(a, con)
            adapter.fill(ds)
            con.close()
            adapter.dispose()
            With ds.tables(0).rows(0)
                Me.username.text = .item("username")
                Me.userid = .item("userid")
                Me.emailaddress.text = .item("emailaddress")
                Me.department.text = .item("department")
                Me.fullname.text = .item("fullname")
            End With
        Catch ex As exception
            messagebox.show(ex.message, "contact system admin")
        End Try
    End Sub
    Private Sub inputbutton3_click(ByVal sender As system.object, ByVal e As system.eventargs) Handles inputbutton3.click
        Me.close()
    End Sub

    Private Sub saverecordbutton_click(ByVal sender As system.object, ByVal e As system.eventargs) Handles saverecordbutton.click
        saveeditdelete("update user_access set department='" & convertquotes(Me.department.text) & _
                        "', fullname='" & convertquotes(Me.fullname.text) & _
                        "', emailaddress='" & convertquotes(Me.emailaddress.text) & _
                        "' where userid='" & Me.userid & "' ", "saved")
        user_accessmain.refreshform()
    End Sub
End Class

