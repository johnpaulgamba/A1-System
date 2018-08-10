Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Public Class HRIS_EmployeeRegistration_Requirement
    Private tosave As Boolean = True
    Private employeeid As Integer = 0
    Sub New(ByVal id As Integer)

        ' This call is required by the designer.
        InitializeComponent()
        loadingvaluestoComboBoxes_StoredProc("Combo_Employees_Activeonly", Me.EmployeeName, "Employee", "EmployeeID")
        'loadingvaluestoComboBoxes_StoredProc("", Me.Occupation, "Position", "PositionID")
        'loadingvaluestoComboBoxes_StoredProc("HRIS_COMBOBOX_Relationship", Me.RelationShip, "Relationship", "Relationship")
        If id = 0 Then
            clear()
        Else
            loaddata(id)
        End If
    End Sub
    Public Sub clear()
        Me.EmployeeName.Text = Nothing
        'Me.C1FlexGrid8.Clear()
        tosave = True
        FunctionClass.loadtoGrid("Select requirementid,ok,requirement,optional from hris_requirement_setup", C1FlexGrid8)
        '  FunctionClass.loadtoGrid("Select requirementid,ok,requirement,optional from hris_requirement_setup", C1FlexGrid2)
    End Sub
    Private Sub loaddata(ByVal sql As Integer)
        Try
            Me.EmployeeName.SelectedValue = sql
            FunctionClass.loadtoGrid("Select a.requirementid,a.ok,b.requirement,b.optional from hris_requirements " & _
                                 "a join hris_requirement_setup b on a.requirementid=b.requirementid and a.employeeid='" & sql & "'", C1FlexGrid8)
            If Me.C1FlexGrid8.Rows.Count = 1 Then
                FunctionClass.loadtoGrid("Select requirementid,ok,requirement,optional from hris_requirement_setup where active=1", C1FlexGrid8)
            End If
            tosave = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub SaveCommandButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Function saveorders2(ByVal id As Integer, ByVal flexgrid As C1.Win.C1FlexGrid.C1FlexGrid) As String
        Dim z11 As String = ""
        Try
            Dim x As Integer = 1
            Dim y As Integer = flexgrid.Rows.Count - 1
            For x = 1 To y
                With flexgrid.Rows(x)
                    If .Item("requirement") = Nothing Then Continue For
                    Dim oks As Integer = 0
                    If .Item("ok") = True Then oks = 1 Else oks = 0
                    z11 = z11 & " " & "('" & id & _
                        "', '" & oks & _
                        "', '" & .Item("requirement") & _
                        "', '" & .Item("requirementid") & _
                        "')            "

                End With
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return LTrim(RTrim(z11)).Replace("            ", ",")
    End Function
    Private Sub InputButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub InputButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Function Active() As Object
        Throw New NotImplementedException
    End Function

    Private Sub EmployeeName_ChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeName.ChangeCommitted

    End Sub

    Private Sub InputButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputButton1.Click
        loaddata(Me.EmployeeName.SelectedValue)
    End Sub

    Private Sub SaveJobOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveJobOrder.Click
        If Me.EmployeeName.SelectedIndex = -1 Then MessageBox.Show("No Employee Selected") : Exit Sub
        Dim mytrans As MySqlTransaction
        connect()
        con.Open()

        mytrans = con.BeginTransaction()
        Try

            Dim mynewcommand As New MySqlCommand
            With mynewcommand

                If Me.tosave = False Then
                    .CommandText = "delete from hris_requirements where employeeid='" & EmployeeName.SelectedValue & "'"
                    .Connection = con
                    .CommandType = CommandType.Text
                    .ExecuteNonQuery()

                    .CommandText = "insert into `hris_requirements` (`employeeid`,`ok`,`requirement`,`requirementid`)" & _
                        " values " & saveorders2(EmployeeName.SelectedValue, Me.C1FlexGrid8)
                    .Connection = con
                    .CommandType = CommandType.Text
                    .ExecuteNonQuery()
                Else

                    .CommandText = "insert into `hris_requirements` (`employeeid`,`ok`,`requirement`,`requirementid`)" & _
                        " values " & saveorders2(EmployeeName.SelectedValue, Me.C1FlexGrid8)
                    .Connection = con
                    .CommandType = CommandType.Text
                    .ExecuteNonQuery()

                End If
            End With
            FunctionClass.showMessage("The record has been successfully saved!", "Command Executed!", "Command executed")
            tosave = False
            mytrans.Commit()
            con.Dispose()
            con.Close()
        Catch ex As Exception
            mytrans.Rollback()
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub NewOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewOrder.Click
        FunctionClass.ClearPanel(Me.C1InputPanel1)
        'Me.employeeName.Text = Nothing
        Me.Active.Checked = True
        Me.employeeid = 0
        Me.tosave = False
    End Sub

    Private Sub CloseForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseForm.Click
        Me.Close()
    End Sub
End Class
