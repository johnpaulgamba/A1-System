Imports System.IO
Imports System.Collections.Specialized
Imports MySql.Data.MySqlClient
Imports C1.Win.C1Ribbon
Public Class APCESMainForm

    Friend StringCollect As New StringCollection
    Friend Declare Auto Function SetWindowLong Lib "User32.Dll" (ByVal hWnd As IntPtr, ByVal nIndex As Integer, ByVal dwNewLong As Integer) As Integer
    Friend Declare Auto Function GetWindowLong Lib "User32.Dll" (ByVal hWnd As System.IntPtr, ByVal nIndex As Integer) As Integer
    Friend Const GWL_EXSTYLE = (-20)
    Friend Const WS_EX_CLIENTEDGE = &H200
    Public Sub loadall()
        'this is for loading all access modules 
        'from the specified users/groups
        'loading from ribbon,
        'then tab, then groups then group items, then items 
        'contained in the ribbon menu items
        Try
            For Each TAB As RibbonTab In Me.C1Ribbon1.Tabs
                For Each group As RibbonGroup In TAB.Groups
                    For Each items As RibbonItem In group.Items
                        Select Case items.GetType
                            Case GetType(C1.Win.C1Ribbon.RibbonMenu)
                                If items.Tag = "Exempt" Then Continue For
                                Select Case StringCollect.Contains(items.Name.ToLower)
                                    Case True : items.Enabled = True
                                        For Each items2 As RibbonItem In CType(items, RibbonMenu).Items
                                            If items2.GetType.Equals(GetType(C1.Win.C1Ribbon.RibbonLabel)) Then items2.Enabled = True : Continue For
                                            Select Case StringCollect.Contains(items2.Name.ToLower)
                                                Case True : items2.Enabled = True
                                                    Select Case items2.GetType
                                                        Case GetType(C1.Win.C1Ribbon.RibbonMenu)
                                                            For Each items3 As RibbonItem In CType(items2, RibbonMenu).Items
                                                                If items3.GetType.Equals(GetType(C1.Win.C1Ribbon.RibbonLabel)) Then items3.Enabled = True : Continue For
                                                                Select Case StringCollect.Contains(items3.Name.ToLower)
                                                                    Case True : items3.Enabled = True
                                                                        Select Case items3.GetType
                                                                            Case GetType(C1.Win.C1Ribbon.RibbonMenu)
                                                                                For Each items4 As RibbonItem In CType(items3, RibbonMenu).Items
                                                                                    If items4.GetType.Equals(GetType(C1.Win.C1Ribbon.RibbonLabel)) Then items4.Enabled = True : Continue For
                                                                                    Select Case StringCollect.Contains(items4.Name.ToLower)
                                                                                        Case True : items4.Enabled = True
                                                                                            Select Case items4.GetType
                                                                                                Case GetType(C1.Win.C1Ribbon.RibbonMenu)
                                                                                                    For Each items5 As RibbonItem In CType(items4, RibbonMenu).Items
                                                                                                        If items5.GetType.Equals(GetType(C1.Win.C1Ribbon.RibbonLabel)) Then items5.Enabled = True : Continue For
                                                                                                        Select Case StringCollect.Contains(items5.Name.ToLower)
                                                                                                            Case True : items5.Enabled = True
                                                                                                            Case False : items5.Enabled = False
                                                                                                        End Select
                                                                                                    Next
                                                                                            End Select
                                                                                        Case False : items4.Enabled = False
                                                                                    End Select
                                                                                Next
                                                                        End Select
                                                                    Case False : items3.Enabled = False
                                                                End Select
                                                            Next
                                                    End Select
                                                Case False : items2.Enabled = False
                                            End Select
                                        Next
                                    Case False : items.Enabled = False
                                End Select
                                'Case ItemPropertiesButton.GetType()
                                '    If StringCollect.Contains(items.Name.ToLower) Then items.Enabled = True Else items.Enabled = False
                                '    For Each items2 As RibbonItem In CType(items, RibbonSplitButton).Items
                                '        If items2.GetType.Equals(Me.NTUser.GetType()) Then Continue For
                                '        If StringCollect.Contains(items2.Name.ToLower) Then items2.Enabled = True Else items2.Enabled = False
                                '    Next
                            Case GetType(C1.Win.C1Ribbon.RibbonButton)
                                If StringCollect.Contains(items.Name.ToLower) Then items.Enabled = True Else items.Enabled = False
                            Case GetType(C1.Win.C1Ribbon.RibbonLabel)
                                If StringCollect.Contains(items.Name.ToLower) Then items.Enabled = True Else items.Enabled = False
                            Case Else : items.Enabled = True
                        End Select
                    Next
                Next
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Friend Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
            Me.SystemDate.Text = Format(Now, "D")
            Me.SystemTime.Text = TimeOfDay
            Dim myhost As String = System.Net.Dns.GetHostName
            Dim myip As String = System.Net.Dns.GetHostAddresses(myhost).GetValue(1).ToString.ToUpper
            Me.ComputerName.Text = myhost.ToUpper
            ' CompterNameAll = myip.ToUpper
        Catch ex As Exception
        End Try
    End Sub
    Public Sub preparealldata(ByVal a As String, ByVal b As Integer)
        Try
            connect()
            con.Open()
            Dim ds As New DataSet
            Dim adapter As New MySqlDataAdapter(a.ToString.ToLower, con)
            adapter.SelectCommand.CommandText = a
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure
            adapter.SelectCommand.Parameters.AddWithValue("ID", b)
            adapter.Fill(ds)
            For row As Integer = 0 To ds.Tables(0).Rows.Count - 1
                With ds.Tables(0).Rows(row)
                    Me.StringCollect.Add(.Item("ModuleButtonName").ToString.Replace(" ", "").ToLower)
                End With
            Next
            con.Close()
            con.Dispose()
        Catch ex As Exception
            'messagebox.show(ex.message)
        End Try
    End Sub

    Public Sub setMeBackGround()
        For Each c As Control In Me.Controls()
            If TypeOf (c) Is MdiClient Then
                c.BackColor = Me.BackgroundColor
                Dim windowLong As Integer = GetWindowLong(c.Handle, GWL_EXSTYLE)
                windowLong = windowLong And (Not WS_EX_CLIENTEDGE)
                SetWindowLong(c.Handle, GWL_EXSTYLE, windowLong)
                c.Width = c.Width + 1
                Exit For
            End If
        Next

    End Sub
    Friend Sub BorderColor(ByRef _Control As Control, ByVal _Color As Color)
        Dim g As Graphics = Me.CreateGraphics
        Dim pen As New Pen(_Color, 2.0)
        g.DrawRectangle(pen, New Rectangle(_Control.Location, _Control.Size))
        pen.Dispose()
        g = Nothing
    End Sub
    Friend Sub LoadForm(ByVal a As Form, ByVal sender As String)
        For Each x As Form In MdiChildren
            x.WindowState = FormWindowState.Maximized
            x.Hide()
        Next
        With a
            Me.SuspendLayout()
            .MdiParent = Me
            .ShowIcon = False
            .FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
            .StartPosition = FormStartPosition.CenterScreen
            .WindowState = FormWindowState.Maximized
            Me.ResumeLayout()
            .Show()
        End With
    End Sub
    Private Sub RibbonButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        departmentsmain.loadallcommands(departmentsmain.Name.ToString, "rights_useraccess_buttons_loading2")
        LoadForm(departmentsmain, "")
    End Sub

    Private Sub RibbonButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LoadForm(branchesmainform, "")
        branchesmainform.loadallcommands(branchesmainform.Name.ToString, "rights_useraccess_buttons_loading2")
    End Sub

    Private Sub RibbonButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LoadForm(customersmainform, "")
        customersmainform.loadallcommands(customersmainform.Name.ToString, "rights_useraccess_buttons_loading2")
    End Sub

    Private Sub RibbonButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        itemsmainform.loadallcommands(itemsmainform.Name.ToString, "rights_useraccess_buttons_loading2")
        LoadForm(itemsmainform, "")

    End Sub


    Private Sub PriceListButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '  Dim x As New itempricelistentry
        'With x
        '.StartPosition = FormStartPosition.centerscreen
        '.ShowDialog()
        ' End With
    End Sub

    Private Sub RibbonButton4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LoadForm(DeliveryReceiptRegisterMainForm, "")
        'salesreturnmainform.loadallcommands(salesreturnmainform.Name.ToString, "rights_useraccess_buttons_loading2")
    End Sub

    Private Sub PurchaseOrderButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        purchaseordermainform.loadallcommands(purchaseordermainform.Name.ToString, "rights_useraccess_buttons_loading2")
        LoadForm(SalesOrderMain, "")

    End Sub

    Private Sub RibbonButton18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '  Dim x As New inventory_setup_items
        ' With x
        '.StartPosition = FormStartPosition.centerscreen
        '   .ShowDialog()
        '  End With
    End Sub

    Private Sub RibbonButton5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Dim x As New inventory_transactions
        'With x
        '.StartPosition = FormStartPosition.centerscreen
        '  .ShowDialog()
        ' End With
    End Sub

    Private Sub RibbonButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '  inventory_adjustmentmainform.loadallcommands(inventory_adjustmentmainform.Name.ToString, "rights_useraccess_buttons_loading2")
        ' LoadForm(inventory_adjustmentmainform, "")

    End Sub

    'Private Sub BakeTechMainForm_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    '    loginform.Show()
    'End Sub

    Private Sub BakeTechMainForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Application.ExitThread()
    End Sub

    Private Sub BakeTechMainForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        setMeBackGround()
    End Sub

    Private Sub RibbonButton17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Dim x As New inventory_onhand(0)
        ' With x
        '.Text = "Inventory on hand"
        ' .StartPosition = FormStartPosition.centerscreen
        ' .ShowDialog()
        ' End With
    End Sub

    Private Sub RibbonButton19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' inventory_transfermainform.loadallcommands(inventory_transfermainform.Name.ToString, "rights_useraccess_buttons_loading2")
        ' LoadForm(inventory_transfermainform, "")
    End Sub

    Private Sub ShipListButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        VehicleMainForm.loadallcommands(VehicleMainForm.Name.ToString, "rights_useraccess_buttons_loading2")
        LoadForm(VehicleMainForm, "")
    End Sub

    Private Sub RibbonButton2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        servicereportmainform.loadallcommands(servicereportmainform.Name.ToString, "rights_useraccess_buttons_loading2")
        LoadForm(servicereportmainform, "")
    End Sub

    Private Sub RibbonButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'joborderticketmainform.loadallcommands(joborderticketmainform.Name.ToString, "rights_useraccess_buttons_loading2")
        'LoadForm(joborderticketmainform, "")
    End Sub

    Private Sub RibbonButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        User_AccessMain.loadallCommands(User_AccessMain.Name.ToString, "rights_useraccess_buttons_loading2")
        LoadForm(User_AccessMain, "")
    End Sub

    Private Sub RibbonButton13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        user_permission_profile_main.loadallcommands(user_permission_profile_main.Name.ToString, "rights_useraccess_buttons_loading2")
        LoadForm(user_permission_profile_main, "")

    End Sub

    Private Sub RibbonButton10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        user_permission_group_main.loadallcommands(user_permission_group_main.Name.ToString, "rights_useraccess_buttons_loading2")
        LoadForm(user_permission_group_main, "")

    End Sub

    Private Sub RibbonButton11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        user_permission_modules_main.loadallcommands(user_permission_modules_main.Name.ToString, "rights_useraccess_buttons_loading2")
        LoadForm(user_permission_modules_main, "")
    End Sub

    Private Sub RibbonButton12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        user_permission_buttons_main.loadallcommands(user_permission_buttons_main.Name.ToString, "rights_useraccess_buttons_loading2")
        LoadForm(user_permission_buttons_main, "")
    End Sub

    Private Sub PaymentTypes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        VehicleMainForm.loadallcommands(VehicleMainForm.Name.ToString, "rights_useraccess_buttons_loading2")
        LoadForm(VehicleMainForm, "")
    End Sub

    Private Sub RibbonButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        User_Access_Questions_Main.loadallCommands(User_Access_Questions_Main.Name.ToString, "rights_useraccess_buttons_loading2")
        LoadForm(User_Access_Questions_Main, "")
    End Sub

    Private Sub RibbonFontComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RibbonFontComboBox1.SelectedIndexChanged, statusTrackBar.ValueChanged
        For Each i As Form In Me.MdiChildren
            For Each x As Control In i.Controls
                If x.GetType.Equals(purchaseordermainform.C1NavBar1.GetType) = True Then
                    For Each y As Control In x.Controls
                        If y.GetType.Equals(purchaseordermainform.C1NavBarPanel1.GetType) = True Then
                            For Each z As Control In y.Controls
                                If z.GetType.Equals(GetType(C1.Win.C1FlexGrid.C1FlexGrid)) = True Then
                                    CType(z, C1.Win.C1FlexGrid.C1FlexGrid).Font = New Font(Me.RibbonFontComboBox1.Text, Me.statusTrackBar.Value, FontStyle.Regular)
                                    CType(z, C1.Win.C1FlexGrid.C1FlexGrid).Styles.Fixed.Font = New Font("Arial", Me.statusTrackBar.Value, FontStyle.Bold)
                                    CType(z, C1.Win.C1FlexGrid.C1FlexGrid).AutoSizeCols()
                                    CType(z, C1.Win.C1FlexGrid.C1FlexGrid).AutoSizeRows()
                                End If
                            Next
                        End If
                    Next
                End If
            Next
        Next
    End Sub

    Private Sub ExitAppButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Exitbuttonx.Click
        Dim sagot As MsgBoxResult = MessageBox.Show("Are you sure you want to exit the application?", "Confirm system exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If sagot = vbYes Then
            Application.ExitThread()

        End If
    End Sub

    Private Sub LogOutButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Logoffbuttonx.Click
        Dim sagot As MsgBoxResult = MessageBox.Show("Are you sure you want to logout?", "Confirm logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If sagot = vbYes Then
            For Each x As Form In MdiChildren
                x.Close()
            Next
            Me.Hide()
            loginform.Show()
        End If
    End Sub

    Private Sub AboutAppButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutButtonx.Click
        Dim x As New About
        With x
            .StartPosition = FormStartPosition.CenterScreen
            .ShowDialog()
        End With
    End Sub

    Private Sub SalesReportButton_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        LoadForm(ReportingSalesInvoiceMainForm, "")
    End Sub

    Private Sub PurchaseOrderReportButton_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        LoadForm(ReportingPurchaseOrdersMainForm, "")
    End Sub

    Private Sub SalesReturnReportButton_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        LoadForm(ReportingSalesReturnsMainForm, "")
    End Sub
    Private Sub BakeTechMainForm_MdiChildActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MdiChildActivate
        If Me.ActiveMdiChild Is Nothing Then
            Me.PictureBox1.Show()
        Else
            Me.PictureBox1.Hide()
        End If
    End Sub
    Private Sub InventoryAdjustmentReportButton_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        LoadForm(DeliveryReceiptRegisterMainForm, "")
    End Sub

    Private Sub StockTransferReportButton_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        LoadForm(ReportingInventory_TransfersMainForm, "")
    End Sub

    Private Sub ShippingAddressButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ShippingAddressMainForm.loadallcommands(ShippingAddressMainForm.Name.ToString, "rights_useraccess_buttons_loading2")
        LoadForm(ShippingAddressMainForm, "")
    End Sub

    Private Sub SalesAgentButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SalesAgentMainForm.loadallcommands(SalesAgentMainForm.Name.ToString, "rights_useraccess_buttons_loading2")
        LoadForm(SalesAgentMainForm, "")
    End Sub

    Private Sub PurchaseOrderButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LoadForm(DeliveryReceiptMain, "")
    End Sub

    Private Sub DeliveryRegisterButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LoadForm(ReportingSalesInvoiceMainForm, "")
    End Sub

    Private Sub SalesInvoiceButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LoadForm(SalesInvoiceMain, "")
    End Sub

    Private Sub ReceivingReportButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LoadForm(ReceivingReportsmainform, "")
    End Sub

    Private Sub SalesInvoiceButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LoadForm(AccountsReceivablemainform, "")
    End Sub

    Private Sub PaymentsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LoadForm(PaymentMainForm, "")
    End Sub

    Private Sub POMonitoringButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LoadForm(purchaseordermainform, "")
    End Sub
    Private Sub CreditMemoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LoadForm(CreditMemoMainForm, "")
    End Sub
    Private Sub DebitMemoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LoadForm(DebitMemoMainForm, "")
    End Sub

    Private Sub POMonitoringButton_Click1(ByVal sender As Object, ByVal e As System.EventArgs)
        LoadForm(POMonitoringMainForm, "")
    End Sub

    Private Sub DeliveryReceiptReportButton_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        LoadForm(DeliveryReceiptRegisterMainForm, "")
    End Sub

    Private Sub CustomerMasterButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub RibbonButton922_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub RibbonButton921_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LoadForm(EmployeeMainForm, "")
    End Sub

    Private Sub RibbonButton92_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LoadForm(HRIS_EmploymentHistoryHistoryMainForm, "")

    End Sub

    Private Sub RibbonButton9231_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LoadForm(HRIS_Employee_AddressMainForm, "")

    End Sub

    Private Sub RibbonButton82_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HolidaysSetupButton.Click

    End Sub

    Private Sub RibbonButton102_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub


    Private Sub RibbonButton2_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepartmentSetupButton.Click
        LoadForm(HRIS_DepartmentMainForm, "")
    End Sub

    Private Sub RibbonButton12_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PositionSetupButton.Click
        LoadForm(HRIS_PositionMainForm, "")
    End Sub

    Private Sub RibbonButton5_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupSetUpButton.Click
        LoadForm(HRIS_GroupMainForm, "")

    End Sub

    Private Sub RibbonButton6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocationSetupButton.Click
        LoadForm(HRIS_LocationMainForm, "")
    End Sub

    Private Sub RibbonButton63_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CivilStatusSetupButton.Click
        LoadForm(HRIS_CivilStatusMainForm, "")
    End Sub

    Private Sub RibbonButton64_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeTypeSetupButton.Click
        LoadForm(HRIS_EmployeeTypeMainForm, "")
    End Sub

    Private Sub RibbonButton65_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmploymentLevelSetupButton.Click
        LoadForm(HRIS_EmploymentLevelMainForm, "")
    End Sub

    Private Sub RibbonButton61_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReligionSetupButton.Click
        LoadForm(HRIS_ReligionMainForm, "")

    End Sub

    Private Sub RibbonButton62_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmploymentStatusSetUpButton.Click
        LoadForm(hris_EmploymentStatusMainForm, "")
    End Sub

    Private Sub RibbonButton121_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RequirementDocSetupButton.Click
        LoadForm(HRIS_RequirementSetupMainForm, "")
    End Sub

    Private Sub RibbonButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PayrollGroupSetupButton.Click
        LoadForm(PayrollGroupMainForm, "")
    End Sub

    Private Sub RibbonButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LoadForm(PayRateTypeMainForm, "")
    End Sub

    Private Sub RibbonButton8_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PaymentMethodSetUpButton.Click
        LoadForm(PaymentMethodMainForm, "")
    End Sub
    Private Sub RibbonButton9211_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeMasterButton.Click
        LoadForm(EmployeeMainForm, "")

    End Sub

    Private Sub RibbonButton924_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmploymentHistoryButton.Click
        LoadForm(HRIS_EmploymentHistoryHistoryMainForm, "")
    End Sub

    Private Sub RibbonButton92311_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResidenceAddressButton.Click
        LoadForm(HRIS_Employee_AddressMainForm, "")
    End Sub

    Private Sub RibbonButton92211_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubmittedRequirementsButton.Click
        LoadForm(HRIS_Employee_RequirementsMainForm, "")

    End Sub

    Private Sub RibbonButton721_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EducationalBackgroundButton.Click
        LoadForm(hris_educationalattainmentsMainForm, "")

    End Sub

    Private Sub RibbonButton821_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FamilyBackgroundButton.Click
        LoadForm(hris_dependentsMainForm, "")
    End Sub

    Private Sub RibbonButton1021_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrainingsandSeminarsButton.Click
        LoadForm(HRIS_TrainingsMainForm, "")
    End Sub

    Private Sub RecoveryQuestionButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecoveryQuestionButton.Click
        LoadForm(User_Access_Questions_Main, "")
    End Sub
    Private Sub UserAccountsButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserAccountsButton.Click
        LoadForm(User_AccessMain, "")
    End Sub

    Private Sub UserProfileButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserProfileButton.Click
        LoadForm(user_permission_profile_main, "")
    End Sub
    Private Sub PermissionGroupsButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PermissionGroupsButton.Click
        LoadForm(user_permission_group_main, "")
    End Sub
    Private Sub PermissionModulesButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PermissionModulesButton.Click
        LoadForm(user_permission_modules_main, "")
    End Sub

    Private Sub PermissionButtonsButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PermissionButtonsButton.Click
        LoadForm(user_permission_buttons_main, "")
    End Sub
    Private Sub RibbonButton1211_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViolationSetupButton.Click
        LoadForm(HRIS_ViolationSetUpMainForm, "")
    End Sub

    Private Sub RibbonButton9222_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BankAccountsButton.Click
        LoadForm(Hris_Employee_BankMainForm, "")
    End Sub

    Private Sub RibbonButton9224_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TaxMasterButton.Click
        LoadForm(Hris_Employee_TINMainForm, "")
    End Sub
    Private Sub RibbonButton9221_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SSSMasterButton.Click
        LoadForm(Hris_Employee_SSSMainForm, "")
    End Sub
    Private Sub RibbonButton9223_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PHICMasterButton.Click
        LoadForm(Hris_Employee_PHICMainForm, "")
    End Sub

    Private Sub RibbonButton9225_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HDMFMasterButton.Click
        LoadForm(Hris_Employee_HDMFMainForm, "")
    End Sub

    Private Sub RibbonButton9232122_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IssueSuspensionNoticeButton.Click
        Dim X As New HRIS_EmployeeRegistration_Memo(0)
        With X
            .StartPosition = FormStartPosition.CenterScreen
            .ShowDialog()
        End With
    End Sub

    Private Sub RibbonButton923212_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IssueViolationTicketButton.Click
        Dim X As New HRIS_EmployeeRegistration_ViolationRegistration(0)
        With X
            .StartPosition = FormStartPosition.CenterScreen
            .ShowDialog()
        End With
    End Sub

    Private Sub RibbonButton92111_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnrollEmployeeButton.Click
        Dim X As New HRIS_EmployeeInformation(0)
        With X
            .StartPosition = FormStartPosition.CenterScreen
            .ShowDialog()
        End With
    End Sub

    Private Sub RibbonButton9221111211_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HeadCountSummaryReportButton.Click
        LoadForm(HeadCountReport, "")
    End Sub

    Private Sub RibbonButton9221111212_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeSummaryReportButton.Click
        LoadForm(EmployeeSummaryReport, "")
    End Sub

    Private Sub RibbonButton9232121_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReceiveRequirementButton.Click
        Dim x As New HRIS_EmployeeRegistration_Requirement(0)
        With x
            .StartPosition = FormStartPosition.CenterScreen
            .Show()
        End With
    End Sub

    Private Sub CompanySetUpButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CompanySetUpButton.Click
        LoadForm(HRIS_CompanyNameMainForm, "")
    End Sub

    Private Sub ViolationTicketButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViolationTicketButton.Click
        LoadForm(HRIS_ViolationHistoryMainForm, "")
    End Sub
    Private Sub RibbonButton9232_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SuspensionMemoButton.Click
        LoadForm(HRIS_MemoHistoryMainForm, "")
    End Sub

    Private Sub EarningsSetupButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EarningsSetupButton.Click
        LoadForm(HRIS_IncomeDeduction, "")
    End Sub

    Private Sub DeductionSetupButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CompanyAllowanceSetupButton.Click
        LoadForm(CompanyAllowanceSetUp, "")
    End Sub

    Private Sub AssignGroupScheduleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SSSTableButton.Click
        LoadForm(SSSTableMainForm, "")
    End Sub

    Private Sub AssignGroupScheduleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PHICTableButton.Click
        LoadForm(PHICTABLEMainForm, "")
    End Sub

    Private Sub AssignGroupScheduleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HDMFTableButton.Click
        LoadForm(HDMFTABLEMainForm, "")
    End Sub

    Private Sub PayrollMasterButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PayrollMasterButton.Click
        LoadForm(PayrollPeriodMainForm, "")
    End Sub

    Private Sub PayrollRegisterButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PayrollRegisterButton.Click
        LoadForm(Payroll_Home1, "")
    End Sub

    Private Sub PayrollScheduleButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub SSS_Remittance_Report_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SSS_Remittance_Report.Click
        LoadForm(Payroll_SSS_Monthly, "")
    End Sub

    Private Sub PHIC_Remittance_Report_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PHIC_Remittance_Report.Click
        LoadForm(Payroll_PHIC_Monthly, "")
    End Sub

    Private Sub HDMF_Remittance_Report_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HDMF_Remittance_Report.Click
        LoadForm(Payroll_HDMF_Monthly, "")
    End Sub

    Private Sub TAXTableButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TAXTableButton.Click
        LoadForm(TaxTableMainForm, "")
    End Sub

    Private Sub SSS_Remittance_Report3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SSS_LoanPayment_Button.Click
        LoadForm(Payroll_SSS_LoanPayment, "")
    End Sub

    Private Sub HDMF_LoanPayment_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HDMF_LoanPayment_Button.Click
        LoadForm(Payroll_HDMF_LoanPayment, "")
    End Sub

    Private Sub Vale_Payment_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Vale_Payment_Button.Click
        LoadForm(Payroll_Vale_LoanPayment, "")
    End Sub


    Private Sub BIR_Remittance_Report_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BIR_Remittance_Report.Click
        LoadForm(Payroll_BIR_Monthly, "")
    End Sub

    Private Sub PayrollScheduleButton_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ThirteenthMonthPayButton.Click
        LoadForm(Payroll_13MonthPay, "")
    End Sub

    Private Sub TaxableAmountButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TaxableAmountButton.Click
        LoadForm(Payroll_TaxableAmount, "")
    End Sub

    Private Sub WitholdingTaxButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WitholdingTaxButton.Click
        LoadForm(Payroll_WitholdingTax, "")
    End Sub

    Private Sub PayrollHomeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PayrollHomeButton.Click
        LoadForm(PayrollHome, "")
    End Sub
End Class
