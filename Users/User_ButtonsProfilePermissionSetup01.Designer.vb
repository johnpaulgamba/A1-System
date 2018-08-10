<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class user_buttonsprofilepermissionsetup01
    Inherits C1.Win.C1Ribbon.C1RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(user_buttonsprofilepermissionsetup01))
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel3 = New C1.Win.C1InputPanel.InputLabel()
        Me.UserName = New C1.Win.C1InputPanel.InputComboBox()
        Me.InputGroupHeader3 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputGroupHeader2 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.SaveRecordButton = New C1.Win.C1InputPanel.InputButton()
        Me.ClearButton = New C1.Win.C1InputPanel.InputButton()
        Me.InputButton3 = New C1.Win.C1InputPanel.InputButton()
        Me.C1DockingTab1 = New C1.Win.C1Command.C1DockingTab()
        Me.C1DockingTabPage2 = New C1.Win.C1Command.C1DockingTabPage()
        Me.AdministrationGrid = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Tablll = New C1.Win.C1Command.C1DockingTabPage()
        Me.MainTransactionsGrid = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1DockingTabPage3 = New C1.Win.C1Command.C1DockingTabPage()
        Me.ReportsGrid = New C1.Win.C1FlexGrid.C1FlexGrid()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1DockingTab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1DockingTab1.SuspendLayout()
        Me.C1DockingTabPage2.SuspendLayout()
        CType(Me.AdministrationGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tablll.SuspendLayout()
        CType(Me.MainTransactionsGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1DockingTabPage3.SuspendLayout()
        CType(Me.ReportsGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.BackColor = System.Drawing.Color.Transparent
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader1)
        Me.C1InputPanel1.Items.Add(Me.InputLabel3)
        Me.C1InputPanel1.Items.Add(Me.UserName)
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader3)
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader2)
        Me.C1InputPanel1.Items.Add(Me.SaveRecordButton)
        Me.C1InputPanel1.Items.Add(Me.ClearButton)
        Me.C1InputPanel1.Items.Add(Me.InputButton3)
        Me.C1InputPanel1.Location = New System.Drawing.Point(6, 12)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(671, 557)
        Me.C1InputPanel1.TabIndex = 2
        Me.C1InputPanel1.VisualStyle = C1.Win.C1InputPanel.VisualStyle.System
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        Me.InputGroupHeader1.Text = "User Details"
        '
        'InputLabel3
        '
        Me.InputLabel3.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel3.Height = 18
        Me.InputLabel3.Name = "InputLabel3"
        Me.InputLabel3.Text = "Select Profile Name:"
        '
        'UserName
        '
        Me.UserName.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.UserName.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.UserName.Name = "UserName"
        Me.UserName.Width = 347
        '
        'InputGroupHeader3
        '
        Me.InputGroupHeader3.Height = 356
        Me.InputGroupHeader3.Name = "InputGroupHeader3"
        Me.InputGroupHeader3.Text = "Permission Modules/ Groups"
        '
        'InputGroupHeader2
        '
        Me.InputGroupHeader2.Height = 70
        Me.InputGroupHeader2.Name = "InputGroupHeader2"
        Me.InputGroupHeader2.Padding = New System.Windows.Forms.Padding(0, 45, 0, 0)
        Me.InputGroupHeader2.Text = "Actions and Commands"
        '
        'SaveRecordButton
        '
        Me.SaveRecordButton.Break = C1.Win.C1InputPanel.BreakType.None
        Me.SaveRecordButton.Image = Global.A1plus.My.Resources.Resources.SaveAllHS
        Me.SaveRecordButton.Name = "SaveRecordButton"
        Me.SaveRecordButton.Text = "Save Record"
        '
        'ClearButton
        '
        Me.ClearButton.Break = C1.Win.C1InputPanel.BreakType.None
        Me.ClearButton.Image = Global.A1plus.My.Resources.Resources.DocumentHS1
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.Width = 85
        '
        'InputButton3
        '
        Me.InputButton3.Image = Global.A1plus.My.Resources.Resources.no
        Me.InputButton3.Name = "InputButton3"
        Me.InputButton3.Text = "Close"
        Me.InputButton3.Width = 84
        '
        'C1DockingTab1
        '
        Me.C1DockingTab1.Controls.Add(Me.C1DockingTabPage2)
        Me.C1DockingTab1.Controls.Add(Me.Tablll)
        Me.C1DockingTab1.Controls.Add(Me.C1DockingTabPage3)
        Me.C1DockingTab1.Location = New System.Drawing.Point(6, 107)
        Me.C1DockingTab1.Name = "C1DockingTab1"
        Me.C1DockingTab1.SelectedTabBold = True
        Me.C1DockingTab1.Size = New System.Drawing.Size(671, 373)
        Me.C1DockingTab1.TabIndex = 3
        Me.C1DockingTab1.TabLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1DockingTab1.TabStyle = C1.Win.C1Command.TabStyleEnum.WindowsXP
        Me.C1DockingTab1.VisualStyle = C1.Win.C1Command.VisualStyle.System
        Me.C1DockingTab1.VisualStyleBase = C1.Win.C1Command.VisualStyle.System
        '
        'C1DockingTabPage2
        '
        Me.C1DockingTabPage2.Controls.Add(Me.AdministrationGrid)
        Me.C1DockingTabPage2.Location = New System.Drawing.Point(2, 27)
        Me.C1DockingTabPage2.Name = "C1DockingTabPage2"
        Me.C1DockingTabPage2.Size = New System.Drawing.Size(665, 342)
        Me.C1DockingTabPage2.TabIndex = 1
        Me.C1DockingTabPage2.Text = "Administrations"
        '
        'AdministrationGrid
        '
        Me.AdministrationGrid.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.AdministrationGrid.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Both
        Me.AdministrationGrid.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None
        Me.AdministrationGrid.ColumnInfo = resources.GetString("AdministrationGrid.ColumnInfo")
        Me.AdministrationGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AdministrationGrid.ExtendLastCol = True
        Me.AdministrationGrid.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.AdministrationGrid.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.AdministrationGrid.Location = New System.Drawing.Point(0, 0)
        Me.AdministrationGrid.Name = "AdministrationGrid"
        Me.AdministrationGrid.Rows.Count = 1
        Me.AdministrationGrid.Rows.DefaultSize = 20
        Me.AdministrationGrid.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.ListBox
        Me.AdministrationGrid.Size = New System.Drawing.Size(665, 342)
        Me.AdministrationGrid.StyleInfo = resources.GetString("AdministrationGrid.StyleInfo")
        Me.AdministrationGrid.TabIndex = 9
        Me.AdministrationGrid.Tag = "a"
        Me.AdministrationGrid.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.System
        '
        'Tablll
        '
        Me.Tablll.Controls.Add(Me.MainTransactionsGrid)
        Me.Tablll.Location = New System.Drawing.Point(2, 27)
        Me.Tablll.Name = "Tablll"
        Me.Tablll.Size = New System.Drawing.Size(665, 342)
        Me.Tablll.TabIndex = 2
        Me.Tablll.Text = "Main Transactions"
        '
        'MainTransactionsGrid
        '
        Me.MainTransactionsGrid.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.MainTransactionsGrid.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Both
        Me.MainTransactionsGrid.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None
        Me.MainTransactionsGrid.ColumnInfo = resources.GetString("MainTransactionsGrid.ColumnInfo")
        Me.MainTransactionsGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainTransactionsGrid.ExtendLastCol = True
        Me.MainTransactionsGrid.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.MainTransactionsGrid.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.MainTransactionsGrid.Location = New System.Drawing.Point(0, 0)
        Me.MainTransactionsGrid.Name = "MainTransactionsGrid"
        Me.MainTransactionsGrid.Rows.Count = 1
        Me.MainTransactionsGrid.Rows.DefaultSize = 20
        Me.MainTransactionsGrid.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.ListBox
        Me.MainTransactionsGrid.Size = New System.Drawing.Size(665, 342)
        Me.MainTransactionsGrid.StyleInfo = resources.GetString("MainTransactionsGrid.StyleInfo")
        Me.MainTransactionsGrid.TabIndex = 9
        Me.MainTransactionsGrid.Tag = "a"
        Me.MainTransactionsGrid.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.System
        '
        'C1DockingTabPage3
        '
        Me.C1DockingTabPage3.Controls.Add(Me.ReportsGrid)
        Me.C1DockingTabPage3.Location = New System.Drawing.Point(2, 27)
        Me.C1DockingTabPage3.Name = "C1DockingTabPage3"
        Me.C1DockingTabPage3.Size = New System.Drawing.Size(665, 342)
        Me.C1DockingTabPage3.TabIndex = 9
        Me.C1DockingTabPage3.Text = "Reports"
        '
        'ReportsGrid
        '
        Me.ReportsGrid.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.ReportsGrid.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Both
        Me.ReportsGrid.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None
        Me.ReportsGrid.ColumnInfo = resources.GetString("ReportsGrid.ColumnInfo")
        Me.ReportsGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportsGrid.ExtendLastCol = True
        Me.ReportsGrid.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.ReportsGrid.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.ReportsGrid.Location = New System.Drawing.Point(0, 0)
        Me.ReportsGrid.Name = "ReportsGrid"
        Me.ReportsGrid.Rows.Count = 1
        Me.ReportsGrid.Rows.DefaultSize = 20
        Me.ReportsGrid.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.ListBox
        Me.ReportsGrid.Size = New System.Drawing.Size(665, 342)
        Me.ReportsGrid.StyleInfo = resources.GetString("ReportsGrid.StyleInfo")
        Me.ReportsGrid.TabIndex = 9
        Me.ReportsGrid.Tag = "a"
        Me.ReportsGrid.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.System
        '
        'User_ButtonsProfilePermissionSetup01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(685, 573)
        Me.Controls.Add(Me.C1DockingTab1)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "User_ButtonsProfilePermissionSetup01"
        Me.Text = "Profile Access, Modules and Commands"
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Silver
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1DockingTab1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1DockingTab1.ResumeLayout(False)
        Me.C1DockingTabPage2.ResumeLayout(False)
        CType(Me.AdministrationGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tablll.ResumeLayout(False)
        CType(Me.MainTransactionsGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1DockingTabPage3.ResumeLayout(False)
        CType(Me.ReportsGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputLabel3 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents UserName As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents InputGroupHeader3 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputGroupHeader2 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents SaveRecordButton As C1.Win.C1InputPanel.InputButton
    Friend WithEvents ClearButton As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputButton3 As C1.Win.C1InputPanel.InputButton
    Friend WithEvents C1DockingTab1 As C1.Win.C1Command.C1DockingTab
    Friend WithEvents C1DockingTabPage2 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents AdministrationGrid As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Tablll As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents MainTransactionsGrid As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents C1DockingTabPage3 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents ReportsGrid As C1.Win.C1FlexGrid.C1FlexGrid
End Class
