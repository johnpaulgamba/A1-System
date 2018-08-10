Imports A1plus.FunctionClass
Imports MySql.Data.MySqlClient
Public Class HR_EmployeeRegistration
    Private EmpID As Integer = 0
    Private tosave As Boolean = True
    Sub New(ByVal id As Integer)

        ' This call is required by the designer.
        InitializeComponent()
        loadingvaluestoComboBoxes_StoredProc("HRIS_COMBOBOX_Positions", Me.Position, "Position", "PositionID")
        loadingvaluestoComboBoxes_StoredProc("HRIS_COMBOBOX_Departments", Me.Department, "Department", "DepartmentID")

        If id = 0 Then Exit Sub
        Me.tosave = False
        loaddata("Select * from hris_employee  Where EmpID=" & id)
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
                Me.EmpID = .Item("EmpID")
                Dim EmployeesID As Integer = .Item("EmployeeID")
                Me.LastName.Text = .Item("Lastname")
                Me.FirstName.Text = .Item("Firstname")
                Me.MiddleName.Text = .Item("MiddleName")
                Me.Email.Text = .Item("BirthPlace")
                Me.DateHired.Value = .Item("DateHired")
                Me.BirthDate.Value = .Item("BirthDate")
                Me.Position.SelectedValue = .Item("PositionID")
                Me.Department.SelectedValue = .Item("DepartmentID")
                Me.SSSNo.Text = .Item("SSSNo")
                Me.TIN.Text = .Item("TIN")
                Me.HDMF.Text = .Item("HDMF")
                Me.PhilHealth.Text = .Item("PhilHealth")
                Me.EmployeeID.Text = EmployeesID
                Me.tosave = False
                loadGrids(EmployeesID)
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub SaveCommandButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveCommandButton.Click

        If tosave = True Then
            EmpID = searchRecord("SELECT AUTO_INCREMENT FROM Information_schema.tables where  table_schema='" & database & "' and table_name='hris_employee';", 1)
            savecommand("Created")
        Else
            savecommand("Updated")
        End If
    End Sub
    Private Sub loadGrids(ByVal id As Integer)
        'FunctionClass.loadtoGrid3("HRIS_GRID_hris_employee_dependents", id, Me.DependentGrid)
        ' FunctionClass.loadtoGrid3("HRIS_GRID_hris_employee_education", id, Me.EducationGrid)
        'FunctionClass.loadtoGrid3("HRIS_GRID_hris_employee_employment", id, Me.EmploymentGrid)
        'FunctionClass.loadtoGrid3("HRIS_GRID_hris_employee_addresses", id, Me.ResidenceGrid)
    End Sub
    Private Sub savecommand(ByVal ChangesMAdes As String)
        Try
            connect()
            con.Open()
            Dim command As New MySqlCommand
            With command
                .CommandText = "HRIS_EXECUTE_employee"
                .Connection = con
                .CommandType = CommandType.StoredProcedure
                With .Parameters
                    .AddWithValue("@EmployeeIDs", Me.EmployeeID.Text)
                    .AddWithValue("@FirstNames", Me.FirstName.Text.ToUpper)
                    .AddWithValue("@MiddleNames", Me.MiddleName.Text.ToUpper)
                    .AddWithValue("@LastNames", Me.LastName.Text.ToUpper)
                    .AddWithValue("@DepartmentIDs", Me.Department.SelectedValue)
                    .AddWithValue("@PositionIds", Me.Position.SelectedValue)
                    .AddWithValue("@BirthPlaces", Me.Email.Text.ToUpper)
                    .AddWithValue("@TINs", Me.TIN.Text.ToUpper)
                    .AddWithValue("@SSSnos", Me.SSSNo.Text.ToUpper)
                    .AddWithValue("@HDMFs", Me.HDMF.Text.ToUpper)
                    .AddWithValue("@PhilHealths", Me.PhilHealth.Text.ToUpper)
                    .AddWithValue("@DateHireds", Me.DateHired.Value)
                    .AddWithValue("@BirthDates", Me.BirthDate.Value)
                    .AddWithValue("@tosave", Me.tosave)
                    .AddWithValue("@EmpIDs", Me.EmpID)
                    .AddWithValue("@CreatorNTUsers", APCESMainForm.UserFullName.Text.ToUpper)
                    .AddWithValue("@DateCreateds", "" & Now)
                    .AddWithValue("@ChangesMAdes", ChangesMAdes & "  on " & Now & " at " & APCESMainForm.ComputerName.Text & " by " & APCESMainForm.UserFullName.Text & vbCrLf & vbCrLf)

                End With
                .ExecuteNonQuery()
            End With
            FunctionClass.showMessage("The record has been successfully saved!", "Command Executed!", "Command executed")
            con.Close()
            command.Dispose()
            Me.tosave = False
        Catch ex As Exception
            FunctionClass.showMessage("Exception found:" & ex.Message, "Contact system admin", "Contact System Admin")

        End Try
    End Sub

    Private Sub InputButton4_Click(sender As System.Object, e As System.EventArgs) Handles InputButton4.Click
        Me.Close()

    End Sub

    Private Sub HR_EmployeeRegistration_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
