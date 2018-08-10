Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Imports A1plus.FunctionClass
Public Class HRIS_EmployeeRegistration_Memo
    Private tosave As Boolean
    Private memoid As Integer = 0
    Private ticketid As Integer = 0
    Private noofdays As Integer = 0
    Sub New(ByVal id As Integer)

        ' This call is required by the designer.
        InitializeComponent()
        loadingvaluestoComboBoxes_StoredProc("Combo_Employees_ActiveOnly", Me.EmployeeName, "Employee", "EmployeeID")
        loadingvaluestoComboBoxes_StoredProc("Combo_GeneralViolation_Activeonly", GeneralViolation, "GeneralViolation", "GeneralViolation")
        loadingvaluestoComboBoxes_StoredProc("Combo_Violations_Activeonly", violation, "violationdetails", "violationid")
        loadingvaluestoComboBoxes_StoredProc("Combo_EmployeesLevelA_ActiveOnly", IssuedBy, "Employee", "Position")
        loadingvaluestoComboBoxes_StoredProc("Combo_EmployeesLevelA_ActiveOnly", ApprovedBy1, "Employee", "Position")
        loadingvaluestoComboBoxes_StoredProc("Combo_EmployeesLevelA_ActiveOnly", Approvedby2, "Employee", "Position")
        If id = 0 Then clear() Else loaddata("Select a.*,concat(d.LastName,', ',d.FirstName,' ',d.MiddleName) as Employee, " & _
        "b.ViolationType,b.ViolationDetails, c.PenaltyLevel,c.NoofDays, e.ticketno, e.violationdate,e.issuedby,e.datereceived  from hris_memo a join hris_violation_setup b on " & _
        "a.violationid=b.violationid join hris_penaltysetup c on a.penaltyid=c.penaltyid join hris_employee d  on a.employeeid=d.employeeid " & _
        " join hris_violationticket e on a.ticketid=e.ticketid Where memoid=" & id)
        
    End Sub
    Public Sub clear()
        FunctionClass.ClearPanel(Me.C1InputPanel1)
        Me.MemoDate.Value = Now
        Me.memoid = 0
        Me.tosave = True
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

                If tosave = True Then
                    Me.Status.Text = "OPEN"
                    Me.EmployeeName.SelectedValue = .Item("EmployeeID")
                    Me.ViolationDate.Value = .Item("violationdate")
                    Me.GeneralViolation.Text = .Item("violationtype")
                    Me.violation.Text = .Item("violationdetails")
                    Me.IssuedBy.Text = .Item("issuedby")
                    Me.DateServed.Value = .Item("datereceived")
                    Me.Status.Text = .Item("status")
                    Me.IssuedBy.Text = .Item("issuedby")
                    Me.ApprovedBy1.Text = .Item("approvedby1")
                    Me.Approvedby2.Text = .Item("approvedby2")
                    Me.SuspensionStatus.Text = "OPEN"
                    Me.MemoDate.Value = Now
                    Me.datereceived.Value = Now
                    Me.ticketid = .Item("ticketid")

                    tosave = True
                Else
                    Me.EmployeeName.SelectedValue = .Item("EmployeeID")
                    Me.TicketNo.Text = .Item("ticketno")
                    Me.ticketid = .Item("ticketid")
                    Me.memoid = .Item("memoid")
                    Me.TicketNo.Text = .Item("ticketno")
                    Me.MemoDate.Value = .Item("memodate")
                    Me.GeneralViolation.Text = .Item("violationtype")
                    Me.violation.Text = .Item("violationdetails")
                    Me.ViolationDate.Value = .Item("violationdate")
                    Me.penalty.Text = .Item("penaltylevel")
                    Me.DateServed.Value = .Item("dateserved")
                    Me.ApprovedBy1.Text = .Item("approvedby1")
                    Me.Approvedby2.Text = .Item("approvedby2")
                    Me.IssuedBy.Text = .Item("issuedby")
                    Me.SuspensionStatus.Text = .Item("status")
                    Me.suspensiondatex.Text = .Item("Suspensiondate")
                    Me.remarkss.Text = .Item("remarks")
                    Me.datereceived.Value = .Item("dateserved")
                    Me.tosave = False
                    FunctionClass.loadtoGrid("Select memodateid,suspensiondate,remarks from hris_memo_dateserved where memoid='" & .Item("memoid") & "'", penaltygrid)
                End If
                Me.C1DockingTab1.SelectedIndex = 0
            End With
        Catch ex As Exception
            ' MessageBox.Show("No Violation ticket found")
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub SaveCommandButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveJobOrder.Click
        If tosave = True Then
            memoid = searchRecord("SELECT AUTO_INCREMENT FROM Information_schema.tables where  table_schema='" & database & "' and table_name='hris_memo';", 1)
            savecommand("Created")
        Else
            savecommand("Updated")
        End If

    End Sub
    Private Sub savecommand(ByVal ChangesMAdes As String)
        Try
            connect()
            con.Open()
            Dim command As New MySqlCommand
            With command
                .CommandText = "HRIS_Employee_Memo_Execute"
                .Connection = con
                .CommandType = CommandType.StoredProcedure
                With .Parameters
                    .AddWithValue("@memoids", Me.memoid)
                    .AddWithValue("@violationids", Me.violation.SelectedValue)
                    .AddWithValue("@employeeids", Me.EmployeeName.SelectedValue)
                    .AddWithValue("@Penaltyids", Me.penalty.SelectedValue)
                    .AddWithValue("@memodates", Me.MemoDate.Value)
                    .AddWithValue("@ticketids", Me.ticketid)
                    .AddWithValue("@ticketnos", Me.TicketNo.Text)
                    .AddWithValue("@dateserveds", Me.DateServed.Value)
                    .AddWithValue("@issuedbys", Me.IssuedBy.Text.ToUpper)
                    .AddWithValue("@approvedby1s", Me.ApprovedBy1.Text.ToUpper)
                    .AddWithValue("@approvedby2s", Me.Approvedby2.Text.ToUpper)
                    .AddWithValue("@approvedbyposition2s", Me.Approvedby2.SelectedValue)
                    .AddWithValue("@approvedbyposition1s", Me.ApprovedBy1.SelectedValue)
                    .AddWithValue("@suspensiondates", Me.suspensiondatex.Text)
                    .AddWithValue("@statuss", Me.SuspensionStatus.Text.ToUpper)
                    .AddWithValue("@remarkss", Me.remarkss.Text)
                    .AddWithValue("@tosave", Me.tosave)
                    .AddWithValue("@Creators", APCESMainForm.UserFullName.Text.ToUpper)
                    .AddWithValue("@DateCreateds", "" & Now)
                    .AddWithValue("@ChangesMAdes", ChangesMAdes & "  on " & Now & " at " & APCESMainForm.ComputerName.Text & " by " & APCESMainForm.UserFullName.Text & vbCrLf & vbCrLf)
                End With
                .ExecuteNonQuery()

                If Me.tosave = False Then
                    .CommandText = "delete from hris_memo_dateserved where memoid='" & memoid & "'"
                    .Connection = con
                    .CommandType = CommandType.Text
                    .ExecuteNonQuery()
                End If

                If saveorders2(memoid, penaltygrid) = "" Then
                Else
                    .CommandText = "insert into `hris_memo_dateserved` (`memoid`,`suspensiondate`,`remarks`,`creator`)" & _
                        " values " & saveorders2(memoid, penaltygrid)
                    .Connection = con
                    .CommandType = CommandType.Text
                    .ExecuteNonQuery()
                End If
            End With
            FunctionClass.showMessage("The record has been successfully saved!", "Command Executed!", "Command executed")
            con.Close()
            command.Dispose()
            Me.tosave = False
        Catch ex As Exception
            FunctionClass.showMessage("Exception found:" & ex.Message, "Contact system admin", "Contact System Admin")
        End Try
    End Sub
    Private Function saveorders2(ByVal id As Integer, ByVal flexgrid As C1.Win.C1FlexGrid.C1FlexGrid) As String
        Dim z11 As String = ""
        Try
            Dim x As Integer = 1
            Dim y As Integer = flexgrid.Rows.Count - 1
            For x = 1 To y
                With flexgrid.Rows(x)
                    'If .Item("suspensiondate") = "" Then Continue For
                    If .Item("Suspensiondate") = Nothing Then
                    Else

                        z11 = z11 & " " & "('" & id & _
                        "', '" & Format(CDate(.Item("suspensiondate")), "yyyy-MM-dd") & _
                        "', '" & .Item("remarks") & _
                         "', '" & APCESMainForm.UserFullName.Text & _
                        "')            "
                    End If
                End With

            Next
        Catch ex As Exception
        End Try
        Return LTrim(RTrim(z11)).Replace("            ", ",")
    End Function
    Private Sub InputButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub InputButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewOrder.Click
        clear()
    End Sub
    Private Sub violation_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles violation.SelectedIndexChanged
        Try
            loadingvaluestoComboBoxes("Select distinct penaltylevel, penaltyid from hris_violation_penalty where violationid='" & violation.SelectedValue & "'", penalty, "penaltylevel", "penaltyid")
        Catch ex As Exception
            ' MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub GeneralViolation_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GeneralViolation.SelectedIndexChanged
        Try
            loadingvaluestoComboBoxes("Select violationdetails,violationid from hris_violation_Setup where violationtype='" & GeneralViolation.Text & "'order by violationid", violation, "violationdetails", "violationid")
        Catch ex As Exception
        End Try
    End Sub
    Private Sub penalty_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles penalty.SelectedIndexChanged
        Try
            connect()
            con.Open()
            command = New MySqlCommand("Select * from hris_penaltysetup where penaltyid='" & penalty.SelectedValue & "'", con)
            reader = command.ExecuteReader
            If reader.Read = True Then
                Me.noofdays = reader.Item("noofdays")
                If Me.noofdays <> 0 Then
                    Me.penaltygrid.Rows.Count = reader.Item("noofdays") + 1
                Else
                    Me.penaltygrid.Rows.Count = 2
                End If
                'Me.SuspensionTo.Value = Me.SuspensionFrom.Value.AddDays(noofdays)
            End If
            Me.penaltygrid.AllowEditing = True
        Catch ex As Exception
        End Try
    End Sub

    Private Sub PenaltyGrid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles penaltygrid.KeyDown
        If e.KeyCode = Keys.Delete Then
            Dim sagot As MsgBoxResult = MessageBox.Show("performing the command will delete the entire row. do you want to proceed?", "perform delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Stop)
            If sagot = MsgBoxResult.Yes Then
                Me.penaltygrid.Rows.Remove(Me.penaltygrid.RowSel)
            End If
        End If
    End Sub
    Private Sub updatedependent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles updatedependent.Click
        'Me.penaltygrid.AddItem(violation.SelectedValue, InputBox("InputDate", "SuspensionDate", "", , ))

        'Dim x As New HRIS_GeneralViolation
        'With x
        '.StartPosition = FormStartPosition.CenterScreen
        '.ShowDialog()
        'End With
        'loadingvaluestoComboBoxes_StoredProc("Combo_GeneralViolation_Activeonly", GeneralViolation, "GeneralViolation", "GeneralViolation")
    End Sub

    Private Sub updateaddress_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles updateaddress.Click
        Dim X As New HRIS_PenaltySetUpRegistration
        With X
            .StartPosition = FormStartPosition.CenterScreen
            .ShowDialog()
        End With
    End Sub

    Private Sub updatetraining_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles updatetraining.Click
        Dim x As New HRIS_ViolationSetupRegistration(0)
        With x
            .StartPosition = FormStartPosition.CenterScreen
            .ShowDialog()
        End With
    End Sub

    Private Sub CloseForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseForm.Click
        Me.Close()
    End Sub

    Private Sub TicketNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TicketNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try

         
            Dim x As New ViolationTicketLookup("")
            With x
                .StartPosition = FormStartPosition.CenterScreen
                .ShowDialog()
                End With

            If x.DialogResult = Windows.Forms.DialogResult.OK Then
                Me.TicketNo.Text = x.C1FlexGrid1.Rows(x.C1FlexGrid1.RowSel).Item("ticketno")
            End If
            Catch ex As Exception

            End Try
        End If
    End Sub


    Private Sub penalty_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles penalty.Validated
        connect()
        con.Open()
        command = New MySqlCommand("Select * from hris_memo where violationid='" & violation.SelectedValue & "' and penaltyid='" & penalty.SelectedValue & "' and active=1 and status='OPEN'", con)
        reader = command.ExecuteReader
        If reader.Read = True Then
            MessageBox.Show("A penalty for this violation has already been issued to this employee." & vbNewLine & "Re-select penalty for this violation", "Penalty " & penalty.Text & " already exist", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        reader.Close()
        command.Dispose()
        con.Close()
    End Sub

    Private Sub PrintCreditMemo1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintCreditMemo1.Click
        Dim x As New reportpreview1
        With x
            .print("Reporting_EmployeeMemo", "id", Me.memoid, 3)
            .Show()
        End With
    End Sub

    Private Sub InputButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputButton1.Click
        Try
            If tosave = True Then
                loaddata("Select a.ticketid,a.ticketno, a.issuedby,a.approvedby1,a.approvedby2,a.employeeid,a.violationdate,a.status,a.datereceived,a.issuedby,b.* " & _
                   " from hris_violationticket a join hris_violation_setup b on a.violationid=b.violationid where ticketno ='" & TicketNo.Text & _
                   "' and a.status='OPEN'")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TicketNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TicketNo.TextChanged

    End Sub
End Class
