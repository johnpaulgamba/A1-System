Imports MySql.Data.MySqlClient
Public Class HRIS_Employee_PHIC_Registration
    Public employeeid As Integer
    Sub New(ByVal id As Integer)
        InitializeComponent()
        loadingvaluestoComboBoxes_StoredProc("Combo_Employees_Activeonly", Me.EmployeeName, "Employee", "EmployeeID")
        If id = 0 Then Me.Close() Else loaddatame(id)
    End Sub

    Public Sub loaddatame(ByVal id2 As Integer)
        Try
            connect()
            con.Open()
            command = New MySqlCommand
            With command
                .CommandText = "Select * from hris_employee where employeeid = '" & id2 & "'"
                .Connection = con
                reader = .ExecuteReader
            End With

            If reader.Read = True Then
                With reader
                    Me.employeeid = .Item("employeeid")
                    Me.Reference.Text = .Item("phic")
                    Me.basicsalary.Value = .Item("basicpaymonth")
                    Me.EmployeeName.SelectedValue = .Item("employeeid")
                    loadpremium(.Item("basicpaymonth"))
                End With
            Else
                MessageBox.Show("Wala")
            End If
            reader.Close()
            command.Dispose()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub loadpremium(ByVal salary As Double)
        Try
            connect()
            con.Open()
            command = New MySqlCommand
            With command
                .CommandText = "Select * from phictable where '" & Me.basicsalary.Value & "' between rangefrom and rangeto"
                .Connection = con
                reader = .ExecuteReader
            End With
            If reader.Read = True Then
                With reader
                    If .Item("Compute") = True Then
                        Me.eeshare.Value = reader.Item("EEshare") * salary
                        Me.ershare.Value = reader.Item("Ershare") * salary
                        Me.total.Value = eeshare.Value + ershare.Value
                    Else
                        Me.eeshare.Value = reader.Item("EEshare")
                        Me.ershare.Value = reader.Item("Ershare")
                        Me.total.Value = eeshare.Value + ershare.Value
                    End If
                 
                End With
            End If
            reader.Close()
            command.Dispose()
            con.Close()

        Catch ex As Exception
        End Try
    End Sub

    Private Sub InputButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputButton4.Click
        Me.Close()
    End Sub

    Private Sub basicsalary_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles basicsalary.Validated
        If basicsalary.Value >= 0 Then
            loadpremium(basicsalary.Value)
        End If
    End Sub

    Private Sub SaveCommandButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveCommandButton.Click
        saveEditDelete("update hris_employee set phic='" & Reference.Text & "', phicee='" & eeshare.Value & "',phicer='" & ershare.Value & "' where employeeid = '" & employeeid & "'", "saved")
    End Sub
End Class