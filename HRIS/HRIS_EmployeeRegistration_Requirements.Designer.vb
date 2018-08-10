<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HRIS_EmployeeRegistration_Requirement
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HRIS_EmployeeRegistration_Requirement))
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel2 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputSeparator1 = New C1.Win.C1InputPanel.InputSeparator()
        Me.InputLabel1 = New C1.Win.C1InputPanel.InputLabel()
        Me.EmployeeName = New C1.Win.C1InputPanel.InputComboBox()
        Me.InputButton1 = New C1.Win.C1InputPanel.InputButton()
        Me.C1FlexGrid8 = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1Ribbon1 = New C1.Win.C1Ribbon.C1Ribbon()
        Me.RibbonApplicationMenu1 = New C1.Win.C1Ribbon.RibbonApplicationMenu()
        Me.RibbonConfigToolBar1 = New C1.Win.C1Ribbon.RibbonConfigToolBar()
        Me.RibbonQat1 = New C1.Win.C1Ribbon.RibbonQat()
        Me.ModuleControlTab = New C1.Win.C1Ribbon.RibbonTab()
        Me.RibbonGroup1 = New C1.Win.C1Ribbon.RibbonGroup()
        Me.SaveJobOrder = New C1.Win.C1Ribbon.RibbonButton()
        Me.NewOrder = New C1.Win.C1Ribbon.RibbonButton()
        Me.CloseForm = New C1.Win.C1Ribbon.RibbonButton()
        Me.CancelSOButton = New C1.Win.C1Ribbon.RibbonButton()
        Me.C1InputPanel2 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader2 = New C1.Win.C1InputPanel.InputGroupHeader()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1FlexGrid8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Ribbon1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader1)
        Me.C1InputPanel1.Items.Add(Me.InputLabel2)
        Me.C1InputPanel1.Items.Add(Me.InputSeparator1)
        Me.C1InputPanel1.Items.Add(Me.InputLabel1)
        Me.C1InputPanel1.Items.Add(Me.EmployeeName)
        Me.C1InputPanel1.Items.Add(Me.InputButton1)
        Me.C1InputPanel1.Location = New System.Drawing.Point(0, 129)
        Me.C1InputPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(595, 99)
        Me.C1InputPanel1.TabIndex = 66
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        Me.InputGroupHeader1.Text = "Receive Pre-Employment Requirements"
        '
        'InputLabel2
        '
        Me.InputLabel2.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel2.Name = "InputLabel2"
        Me.InputLabel2.Text = "Select Employee then Click OK. Then Check the submitted Pre-Employment Requiremen" & _
            "ts" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'InputSeparator1
        '
        Me.InputSeparator1.Name = "InputSeparator1"
        Me.InputSeparator1.Width = 535
        '
        'InputLabel1
        '
        Me.InputLabel1.Name = "InputLabel1"
        Me.InputLabel1.Text = "Employee Name:"
        '
        'EmployeeName
        '
        Me.EmployeeName.Break = C1.Win.C1InputPanel.BreakType.None
        Me.EmployeeName.Name = "EmployeeName"
        Me.EmployeeName.Width = 371
        '
        'InputButton1
        '
        Me.InputButton1.Image = Global.A1plus.My.Resources.Resources.check__1_
        Me.InputButton1.Name = "InputButton1"
        Me.InputButton1.Text = "OK"
        Me.InputButton1.Width = 57
        '
        'C1FlexGrid8
        '
        Me.C1FlexGrid8.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Columns
        Me.C1FlexGrid8.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.C1FlexGrid8.AutoResize = True
        Me.C1FlexGrid8.BackColor = System.Drawing.Color.White
        Me.C1FlexGrid8.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None
        Me.C1FlexGrid8.ColumnInfo = resources.GetString("C1FlexGrid8.ColumnInfo")
        Me.C1FlexGrid8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1FlexGrid8.ExtendLastCol = True
        Me.C1FlexGrid8.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
        Me.C1FlexGrid8.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.C1FlexGrid8.ForeColor = System.Drawing.Color.Black
        Me.C1FlexGrid8.IgnoreDiacritics = True
        Me.C1FlexGrid8.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.None
        Me.C1FlexGrid8.Location = New System.Drawing.Point(0, 228)
        Me.C1FlexGrid8.Margin = New System.Windows.Forms.Padding(2)
        Me.C1FlexGrid8.Name = "C1FlexGrid8"
        Me.C1FlexGrid8.Rows.Count = 10
        Me.C1FlexGrid8.Rows.DefaultSize = 19
        Me.C1FlexGrid8.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.C1FlexGrid8.ShowCursor = True
        Me.C1FlexGrid8.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.None
        Me.C1FlexGrid8.Size = New System.Drawing.Size(595, 390)
        Me.C1FlexGrid8.StyleInfo = resources.GetString("C1FlexGrid8.StyleInfo")
        Me.C1FlexGrid8.TabIndex = 65
        Me.C1FlexGrid8.Tree.Style = CType(((C1.Win.C1FlexGrid.TreeStyleFlags.Lines Or C1.Win.C1FlexGrid.TreeStyleFlags.Symbols) _
                    Or C1.Win.C1FlexGrid.TreeStyleFlags.Leaf), C1.Win.C1FlexGrid.TreeStyleFlags)
        Me.C1FlexGrid8.UseCompatibleTextRendering = False
        Me.C1FlexGrid8.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.System
        '
        'C1Ribbon1
        '
        Me.C1Ribbon1.ApplicationMenuHolder = Me.RibbonApplicationMenu1
        Me.C1Ribbon1.ConfigToolBarHolder = Me.RibbonConfigToolBar1
        Me.C1Ribbon1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1Ribbon1.Location = New System.Drawing.Point(0, 0)
        Me.C1Ribbon1.Name = "C1Ribbon1"
        Me.C1Ribbon1.QatHolder = Me.RibbonQat1
        Me.C1Ribbon1.Size = New System.Drawing.Size(595, 129)
        Me.C1Ribbon1.Tabs.Add(Me.ModuleControlTab)
        Me.C1Ribbon1.VisualStyle = C1.Win.C1Ribbon.VisualStyle.Office2010Silver
        '
        'RibbonApplicationMenu1
        '
        Me.RibbonApplicationMenu1.ColoredButton = C1.Win.C1Ribbon.ColoredButton.Green
        Me.RibbonApplicationMenu1.Name = "RibbonApplicationMenu1"
        Me.RibbonApplicationMenu1.Text = "Module"
        Me.RibbonApplicationMenu1.Visible = False
        '
        'RibbonConfigToolBar1
        '
        Me.RibbonConfigToolBar1.Name = "RibbonConfigToolBar1"
        '
        'RibbonQat1
        '
        Me.RibbonQat1.MenuVisible = False
        Me.RibbonQat1.Name = "RibbonQat1"
        Me.RibbonQat1.Visible = False
        '
        'ModuleControlTab
        '
        Me.ModuleControlTab.Groups.Add(Me.RibbonGroup1)
        Me.ModuleControlTab.Name = "ModuleControlTab"
        Me.ModuleControlTab.Text = "Module Controls"
        '
        'RibbonGroup1
        '
        Me.RibbonGroup1.Items.Add(Me.SaveJobOrder)
        Me.RibbonGroup1.Items.Add(Me.NewOrder)
        Me.RibbonGroup1.Items.Add(Me.CloseForm)
        Me.RibbonGroup1.Items.Add(Me.CancelSOButton)
        Me.RibbonGroup1.Name = "RibbonGroup1"
        Me.RibbonGroup1.Text = "Data Manipulations"
        '
        'SaveJobOrder
        '
        Me.SaveJobOrder.CanBeAddedToQat = False
        Me.SaveJobOrder.LargeImage = CType(resources.GetObject("SaveJobOrder.LargeImage"), System.Drawing.Image)
        Me.SaveJobOrder.Name = "SaveJobOrder"
        Me.SaveJobOrder.SmallImage = Global.A1plus.My.Resources.Resources.SaveAllHS
        Me.SaveJobOrder.Text = "Save Record"
        '
        'NewOrder
        '
        Me.NewOrder.CanBeAddedToQat = False
        Me.NewOrder.LargeImage = CType(resources.GetObject("NewOrder.LargeImage"), System.Drawing.Image)
        Me.NewOrder.Name = "NewOrder"
        Me.NewOrder.SmallImage = Global.A1plus.My.Resources.Resources.new_window__1_
        Me.NewOrder.SupportedGroupSizing = C1.Win.C1Ribbon.SupportedGroupSizing.LargeImageOnly
        Me.NewOrder.Text = "Receive New Requirements"
        '
        'CloseForm
        '
        Me.CloseForm.CanBeAddedToQat = False
        Me.CloseForm.LargeImage = Global.A1plus.My.Resources.Resources.exit1
        Me.CloseForm.Name = "CloseForm"
        Me.CloseForm.SmallImage = CType(resources.GetObject("CloseForm.SmallImage"), System.Drawing.Image)
        Me.CloseForm.Text = "Close Form"
        '
        'CancelSOButton
        '
        Me.CancelSOButton.CanBeAddedToQat = False
        Me.CancelSOButton.LargeImage = Global.A1plus.My.Resources.Resources.deletered
        Me.CancelSOButton.Name = "CancelSOButton"
        Me.CancelSOButton.SmallImage = CType(resources.GetObject("CancelSOButton.SmallImage"), System.Drawing.Image)
        Me.CancelSOButton.Text = "Cancel/ Close Sales Order"
        Me.CancelSOButton.Visible = False
        '
        'C1InputPanel2
        '
        Me.C1InputPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.C1InputPanel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel2.Items.Add(Me.InputGroupHeader2)
        Me.C1InputPanel2.Location = New System.Drawing.Point(0, 618)
        Me.C1InputPanel2.Margin = New System.Windows.Forms.Padding(2)
        Me.C1InputPanel2.Name = "C1InputPanel2"
        Me.C1InputPanel2.Size = New System.Drawing.Size(595, 29)
        Me.C1InputPanel2.TabIndex = 69
        '
        'InputGroupHeader2
        '
        Me.InputGroupHeader2.Height = 22
        Me.InputGroupHeader2.Name = "InputGroupHeader2"
        Me.InputGroupHeader2.Text = "Check the OK to signifiy that the requirement has been received..."
        '
        'HRIS_EmployeeRegistration_Requirement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(595, 647)
        Me.Controls.Add(Me.C1FlexGrid8)
        Me.Controls.Add(Me.C1InputPanel2)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.Controls.Add(Me.C1Ribbon1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MinimizeBox = False
        Me.Name = "HRIS_EmployeeRegistration_Requirement"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Employee Pre-Employment Requirements"
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1FlexGrid8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Ribbon1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputLabel1 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents EmployeeName As C1.Win.C1InputPanel.InputComboBox
    Public WithEvents C1FlexGrid8 As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents InputLabel2 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputSeparator1 As C1.Win.C1InputPanel.InputSeparator
    Friend WithEvents InputButton1 As C1.Win.C1InputPanel.InputButton
    Friend WithEvents C1Ribbon1 As C1.Win.C1Ribbon.C1Ribbon
    Public WithEvents RibbonApplicationMenu1 As C1.Win.C1Ribbon.RibbonApplicationMenu
    Friend WithEvents RibbonConfigToolBar1 As C1.Win.C1Ribbon.RibbonConfigToolBar
    Friend WithEvents RibbonQat1 As C1.Win.C1Ribbon.RibbonQat
    Friend WithEvents ModuleControlTab As C1.Win.C1Ribbon.RibbonTab
    Friend WithEvents RibbonGroup1 As C1.Win.C1Ribbon.RibbonGroup
    Friend WithEvents SaveJobOrder As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents NewOrder As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents CloseForm As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents CancelSOButton As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents C1InputPanel2 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader2 As C1.Win.C1InputPanel.InputGroupHeader

End Class
