Imports MySql.Data.MySqlClient
Public Class HRIS_Employee_Bank_Registration
    Public employeeid As Integer
    Sub New(ByVal id As Integer)
        InitializeComponent()
        loadingvaluestoComboBoxes_StoredProc("Combo_Employees_Activeonly", Me.EmployeeName, "Employee", "EmployeeID")
        loadingvaluestoComboBoxes_StoredProc("combo_paymentmethod_ActiveOnly", paymentmethod, "paymentmethod", "paymentmethod")
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
                    Me.Reference.Text = .Item("bankaccountno")
                    Me.EmployeeName.SelectedValue = .Item("employeeid")
                    Me.PaymentMethod.Text = .Item("paymentmethod")
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
   

    Private Sub InputButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputButton4.Click
        Me.Close()
    End Sub


    Private Sub SaveCommandButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveCommandButton.Click
        saveEditDelete("update hris_employee set bankaccountno='" & Reference.Text & "', paymentmethod='" & PaymentMethod.Text & "' where employeeid = '" & employeeid & "'", "saved")
    End Sub
End Class