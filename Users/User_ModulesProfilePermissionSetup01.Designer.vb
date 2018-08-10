<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class user_modulesprofilepermissionsetup01
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(user_modulesprofilepermissionsetup01))
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
        Me.SalesGrid = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1DockingTabPage4 = New C1.Win.C1Command.C1DockingTabPage()
        Me.WarehouseGrid = New C1.Win.C1FlexGrid.C1FlexGrid()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1DockingTab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1DockingTab1.SuspendLayout()
        Me.C1DockingTabPage2.SuspendLayout()
        CType(Me.AdministrationGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tablll.SuspendLayout()
        CType(Me.SalesGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1DockingTabPage4.SuspendLayout()
        CType(Me.WarehouseGrid, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.C1InputPanel1.Location = New System.Drawing.Point(12, 22)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(728, 496)
        Me.C1InputPanel1.TabIndex = 2
        Me.C1InputPanel1.VisualStyle = C1.Win.C1InputPanel.VisualStyle.System
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        Me.InputGroupHeader1.Text = "Profile Details"
        '
        'InputLabel3
        '
        Me.InputLabel3.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel3.Height = 19
        Me.InputLabel3.Name = "InputLabel3"
        Me.InputLabel3.Text = "Profile Name:"
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
        Me.InputGroupHeader3.Height = 352
        Me.InputGroupHeader3.Name = "InputGroupHeader3"
        Me.InputGroupHeader3.Text = "Permission Modules/ Groups"
        '
        'InputGroupHeader2
        '
        Me.InputGroupHeader2.Height = 30
        Me.InputGroupHeader2.Name = "InputGroupHeader2"
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
        Me.C1DockingTab1.Controls.Add(Me.C1DockingTabPage4)
        Me.C1DockingTab1.Location = New System.Drawing.Point(12, 122)
        Me.C1DockingTab1.Name = "C1DockingTab1"
        Me.C1DockingTab1.SelectedTabBold = True
        Me.C1DockingTab1.Size = New System.Drawing.Size(728, 321)
        Me.C1DockingTab1.TabIndex = 3
        Me.C1DockingTab1.TabLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1DockingTab1.TabStyle = C1.Win.C1Command.TabStyleEnum.WindowsXP
        Me.C1DockingTab1.VisualStyle = C1.Win.C1Command.VisualStyle.WindowsXP
        Me.C1DockingTab1.VisualStyleBase = C1.Win.C1Command.VisualStyle.WindowsXP
        '
        'C1DockingTabPage2
        '
        Me.C1DockingTabPage2.Controls.Add(Me.AdministrationGrid)
        Me.C1DockingTabPage2.Location = New System.Drawing.Point(2, 27)
        Me.C1DockingTabPage2.Name = "C1DockingTabPage2"
        Me.C1DockingTabPage2.Size = New System.Drawing.Size(722, 290)
        Me.C1DockingTabPage2.TabIndex = 1
        Me.C1DockingTabPage2.Text = "Administration"
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
        Me.AdministrationGrid.Size = New System.Drawing.Size(722, 290)
        Me.AdministrationGrid.StyleInfo = resources.GetString("AdministrationGrid.StyleInfo")
        Me.AdministrationGrid.TabIndex = 7
        Me.AdministrationGrid.Tag = "a"
        Me.AdministrationGrid.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.System
        '
        'Tablll
        '
        Me.Tablll.Controls.Add(Me.SalesGrid)
        Me.Tablll.Location = New System.Drawing.Point(2, 27)
        Me.Tablll.Name = "Tablll"
        Me.Tablll.Size = New System.Drawing.Size(722, 290)
        Me.Tablll.TabIndex = 2
        Me.Tablll.Text = "Main Transactions"
        '
        'SalesGrid
        '
        Me.SalesGrid.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.SalesGrid.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Both
        Me.SalesGrid.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None
        Me.SalesGrid.ColumnInfo = resources.GetString("SalesGrid.ColumnInfo")
        Me.SalesGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SalesGrid.ExtendLastCol = True
        Me.SalesGrid.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.SalesGrid.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.SalesGrid.Location = New System.Drawing.Point(0, 0)
        Me.SalesGrid.Name = "SalesGrid"
        Me.SalesGrid.Rows.Count = 1
        Me.SalesGrid.Rows.DefaultSize = 20
        Me.SalesGrid.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.ListBox
        Me.SalesGrid.Size = New System.Drawing.Size(722, 290)
        Me.SalesGrid.StyleInfo = resources.GetString("SalesGrid.StyleInfo")
        Me.SalesGrid.TabIndex = 9
        Me.SalesGrid.Tag = "a"
        Me.SalesGrid.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.System
        '
        'C1DockingTabPage4
        '
        Me.C1DockingTabPage4.Controls.Add(Me.WarehouseGrid)
        Me.C1DockingTabPage4.Location = New System.Drawing.Point(2, 27)
        Me.C1DockingTabPage4.Name = "C1DockingTabPage4"
        Me.C1DockingTabPage4.Size = New System.Drawing.Size(722, 290)
        Me.C1DockingTabPage4.TabIndex = 3
        Me.C1DockingTabPage4.Text = "Reports"
        '
        'WarehouseGrid
        '
        Me.WarehouseGrid.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.WarehouseGrid.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Both
        Me.WarehouseGrid.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None
        Me.WarehouseGrid.ColumnInfo = resources.GetString("WarehouseGrid.ColumnInfo")
        Me.WarehouseGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WarehouseGrid.ExtendLastCol = True
        Me.WarehouseGrid.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.WarehouseGrid.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.WarehouseGrid.Location = New System.Drawing.Point(0, 0)
        Me.WarehouseGrid.Name = "WarehouseGrid"
        Me.WarehouseGrid.Rows.Count = 1
        Me.WarehouseGrid.Rows.DefaultSize = 20
        Me.WarehouseGrid.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.ListBox
        Me.WarehouseGrid.Size = New System.Drawing.Size(722, 290)
        Me.WarehouseGrid.StyleInfo = resources.GetString("WarehouseGrid.StyleInfo")
        Me.WarehouseGrid.TabIndex = 9
        Me.WarehouseGrid.Tag = "a"
        Me.WarehouseGrid.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.System
        '
        'User_ModulesProfilePermissionSetup01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(753, 545)
        Me.Controls.Add(Me.C1DockingTab1)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "User_ModulesProfilePermissionSetup01"
        Me.Text = "Account Setup, Permissions and Modules"
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Silver
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1DockingTab1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1DockingTab1.ResumeLayout(False)
        Me.C1DockingTabPage2.ResumeLayout(False)
        CType(Me.AdministrationGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tablll.ResumeLayout(False)
        CType(Me.SalesGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1DockingTabPage4.ResumeLayout(False)
        CType(Me.WarehouseGrid, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents SalesGrid As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents C1DockingTabPage4 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents WarehouseGrid As C1.Win.C1FlexGrid.C1FlexGrid
End Class
