Imports MySql.Data.MySqlClient
Public Class PayrollPeriodRegistration
    Private tosave As Boolean = True
    Private payrollperiodId As Integer = 0
    Sub New(ByVal id As Integer)

        ' This call is required by the designer.
        InitializeComponent()
        loadingvaluestoComboBoxes("Select * from company where companyid<>0 ", companyname, "CompanyName", "CompanyID")
        loadingvaluestoComboBoxes_StoredProc("combo_payrollgroup_ActiveOnly", payrollgroup, "payrollgroup", "payrollgroup")
        ' loadingvaluestoComboBoxes_StoredProc("combo_PaymentMethod_ActiveOnly", paymentmethod, "paymentmethod", "paymentmethod")
        If id = 0 Then
            CLEAR()
        Else
            loaddata("Select * from payroll_period Where payrollperiodId='" & id & "'")
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
                Me.payrollperiodId = .Item("payrollperiodid")
                Me.companyname.SelectedValue = .Item("companyid")
                Me.payrollgroup.Text = .Item("payrollgroup")
                Me.payrollname.Text = .Item("payrollname")
                Me.PayrollDate.Value = .Item("payrolldate")
                Me.PeriodFrom.Value = .Item("period_from")
                Me.PeriodTo.Value = .Item("period_to")
                Me.tosave = False
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub SaveCommandButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveCommandButton.Click
        Try
            If tosave = True Then
                payrollperiodId = searchRecord("SELECT AUTO_INCREMENT FROM Information_schema.tables where  table_schema='" & database & "' and table_name='payroll_period';", 1)
                savecommand("Created")
            Else
                savecommand("Updated")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub savecommand(ByVal ChangesMAdes As String)
        '  Try
        connect()
        con.Open()
        Dim command As New MySqlCommand
        With command
            .CommandText = "Payroll_Period_Execute"
            .Connection = con
            .CommandType = CommandType.StoredProcedure
            With .Parameters
                .AddWithValue("@payrollperiodIDs", Me.payrollperiodId)
                .AddWithValue("@companyids", companyname.SelectedValue)
                .AddWithValue("@payrollgroups", payrollgroup.Text)
                '  .AddWithValue("@paymentmethods", Me.paymentmethod.Text)
                .AddWithValue("@payrollnames", Me.payrollname.Text)
                .AddWithValue("@payrolldates", Me.PayrollDate.Value)
                .AddWithValue("@period_froms", Me.PeriodFrom.Value)
                .AddWithValue("@period_tos", Me.PeriodTo.Value)
                .AddWithValue("@cut_offfroms", Me.Cut_offfrom.Value)
                .AddWithValue("@cut_offtos", Me.Cut_offto.Value)
                .AddWithValue("@tosave", Me.tosave)
                .AddWithValue("@Creators", APCESMainForm.UserFullName.Text.ToUpper)
                .AddWithValue("@ChangesMAdes", ChangesMAdes & "  on " & Now & " at " & APCESMainForm.ComputerName.Text & " by " & APCESMainForm.UserFullName.Text & vbCrLf & vbCrLf)
            End With
            .ExecuteNonQuery()
        End With
        FunctionClass.showMessage("The record has been successfully saved!", "Command Executed!", "Command executed")
        con.Close()
        command.Dispose()
        Me.tosave = False
        'Catch ex As Exception
        '  FunctionClass.showMessage("Exception found:" & ex.Message, "Contact system admin", "Contact System Admin")
        ' End Try
    End Sub
    Private Sub InputButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputButton4.Click
        Me.Close()
    End Sub
    Public Sub CLEAR()
        FunctionClass.ClearPanel(Me.C1InputPanel1)
        Me.payrollperiodId = 0
        Me.tosave = True
    End Sub
    Private Sub InputButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputButton2.Click
        CLEAR()
    End Sub
    Private Sub InputDatePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PayrollDate.ValueChanged
        If payrollgroup.Text = "SEMI-MONTHLY" Then
            Me.PeriodFrom.Value = semiperiodfrom(Me.PayrollDate.Value)
            Me.PeriodTo.Value = semiperiodto(Me.PayrollDate.Value)
            Me.Cut_offfrom.Value = semicutofffrom(Me.PayrollDate.Value)
            Me.Cut_offto.Value = semicutoffto(Me.PayrollDate.Value)
            Me.payrollname.Text = companyname.Text & vbNewLine & "PAYROLL GROUP: " & payrollgroup.Text & vbNewLine & "PAYROLL DATE:  " & Format(PayrollDate.Value, "MMMM dd, yyyy").ToUpper
        ElseIf payrollgroup.Text = "WEEKLY" Then
            Me.PeriodFrom.Value = weeklyperiodfrom(Me.PayrollDate.Value)
            Me.PeriodTo.Value = weeklyperiodto(Me.PayrollDate.Value)
            Me.Cut_offfrom.Value = weeklycutofffrom(Me.PayrollDate.Value)
            Me.Cut_offto.Value = weeklycutoffto(Me.PayrollDate.Value)
            Me.payrollname.Text = companyname.Text & vbNewLine & "PAYROLL GROUP: " & payrollgroup.Text & vbNewLine & "PAYROLL DATE:  " & Format(PayrollDate.Value, "MMMM dd, yyyy").ToUpper
        ElseIf payrollgroup.Text = "MONTHLY" Then
            Me.PeriodFrom.Value = FirstDayOfMonth(Me.PayrollDate.Value)
            Me.PeriodTo.Value = LastDayOfMonth(Me.PayrollDate.Value)
            Me.Cut_offfrom.Value = FirstDayOfMonth(Me.PayrollDate.Value)
            Me.Cut_offto.Value = LastDayOfMonth(Me.PayrollDate.Value)
            Me.payrollname.Text = companyname.Text & vbNewLine & "PAYROLL GROUP: " & payrollgroup.Text & vbNewLine & "PAYROLL DATE:  " & Format(PayrollDate.Value, "MMMM dd, yyyy").ToUpper
        End If
    End Sub

    Private Sub PayrollPeriodRegistration_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        PayrollPeriodMainForm.SearchRecords_Click(sender, e)
    End Sub
End Class