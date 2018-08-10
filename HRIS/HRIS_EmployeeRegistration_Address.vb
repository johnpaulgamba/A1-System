Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Public Class HRIS_EmployeeRegistration_Address
    Private tosave As Boolean = True
    Private AddressId As Integer = 0
    Sub New(ByVal id As Integer)
        InitializeComponent()
        loadingvaluestoComboBoxes_StoredProc("Combo_Employees_Activeonly", Me.EmployeeName, "Employee", "EmployeeID")
        If id = 0 Then
            tosave = True
        Else
            loaddata("Select * from HRIS_Address Where AddressId=" & id)
        End If
    End Sub
    Private Sub loaddata(ByVal sql As String)
        Try
            connect()
            con.Open()
            Dim ds As New DataSet
            Dim adapter As New MySqlDataAdapter(sql, con)
            With adapter
                .Fill(ds)
                .Dispose()
            End With
            With ds.Tables(0).Rows(0)
                Me.AddressId = .Item("AddressId")
                Me.ContactNo.Text = .Item("ContactNo")
                Me.MeasureOfStay.Text = .Item("MeasureOfStay")
                Me.LengthOfStay.Value = .Item("LengthOfStay")
                Me.Address.Text = .Item("CompleteAddress")
                Me.Remarks.Text = .Item("Remarks")
                Me.isPermanent.Checked = .Item("isPermanent")
                Me.isPresent.Checked = .Item("isPresent")
                Me.tosave = False
                Me.EmployeeName.SelectedValue = .Item("EmployeeID")
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub SaveCommandButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveCommandButton.Click
        Try
            If tosave = True Then
                AddressId = searchRecord("SELECT AUTO_INCREMENT FROM Information_schema.tables where  table_schema='" & database & "' and table_name='hris_employee_Address';", 1)
                savecommand("Created")
            Else
                savecommand("Updated")

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub savecommand(ByVal ChangesMAdes As String)
        Try
            connect()
            con.Open()
            Dim command As New MySqlCommand
            With command
                .CommandText = "HRIS_Address_Execute"
                .Connection = con
                .CommandType = CommandType.StoredProcedure
                With .Parameters
                    .AddWithValue("@EmployeeIDs", Me.EmployeeName.SelectedValue)
                    .AddWithValue("@CompleteAddresss", Me.Address.Text.ToUpper)
                    .AddWithValue("@aas", Me.LengthOfStay.Value)
                    .AddWithValue("@MeasureOfStays", Me.MeasureOfStay.Text.ToUpper)
                    .AddWithValue("@Remarkss", Me.Remarks.Text.ToUpper)
                    .AddWithValue("@isPermanents", Me.isPermanent.Checked)
                    .AddWithValue("@isPresents", Me.isPresent.Checked)
                    .AddWithValue("@ContactNos", Me.ContactNo.Text)
                    .AddWithValue("@tosave", Me.tosave)
                    .AddWithValue("@AddressIds", Me.AddressId)
                    .AddWithValue("@Creators", APCESMainForm.UserFullName.Text.ToUpper)
                    .AddWithValue("@ChangesMAdes", ChangesMAdes & "  on " & Now & " at " & APCESMainForm.ComputerName.Text & " by " & APCESMainForm.UserFullName.Text & vbCrLf & vbCrLf)
                End With
                .ExecuteNonQuery()
            End With
            FunctionClass.showMessage("The record has been successfully saved!", "Command Executed!", "Command executed")
            con.Close()
            command.Dispose()
            Me.tosave = False
            saveEditDelete("update hris_employee set address='" & Address.Text.ToUpper & "' where employeeid='" & EmployeeName.SelectedValue & "'", "wala")
        Catch ex As Exception
            '  FunctionClass.showMessage("Exception found:" & ex.Message, "Contact system admin", "Contact System Admin")
        End Try
    End Sub
    Private Sub InputButton4_Click(sender As System.Object, e As System.EventArgs) Handles InputButton4.Click
        Me.Close()
    End Sub
    Public Sub CLEAR()
        FunctionClass.ClearPanel(Me.C1InputPanel1)
        Me.isPresent.Checked = False
        Me.isPermanent.Checked = False
        Me.AddressId = 0
        Me.tosave = False
    End Sub
    Private Sub InputButton2_Click(sender As System.Object, e As System.EventArgs) Handles InputButton2.Click
        CLEAR()
    End Sub

End Class
