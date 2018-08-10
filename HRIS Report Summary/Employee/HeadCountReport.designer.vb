<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HeadCountReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HeadCountReport))
        Me.CrystalReportViewer2 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.PrintReportButton = New System.Windows.Forms.ToolStripButton()
        Me.ExportReportButton = New System.Windows.Forms.ToolStripButton()
        Me.RefreshReportButton = New System.Windows.Forms.ToolStripButton()
        Me.CloseFormButton = New System.Windows.Forms.ToolStripButton()
        Me.ExpandablePanel1 = New DevComponents.DotNetBar.ExpandablePanel()
        Me.C1InputPanel2 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.cmdPrint = New C1.Win.C1InputPanel.InputButton()
        Me.cmdClear = New C1.Win.C1InputPanel.InputButton()
        Me.RefreshDropDownsCombo = New C1.Win.C1InputPanel.InputButton()
        Me.BasicSearchOption = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader2 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel2 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel43 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel13 = New C1.Win.C1InputPanel.InputLabel()
        Me.rdoCompany = New C1.Win.C1InputPanel.InputRadioButton()
        Me.rdodepartment = New C1.Win.C1InputPanel.InputRadioButton()
        Me.rdolocation = New C1.Win.C1InputPanel.InputRadioButton()
        Me.rdoposition = New C1.Win.C1InputPanel.InputRadioButton()
        Me.rdopayrollgroup = New C1.Win.C1InputPanel.InputRadioButton()
        Me.InputLabel15 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel8 = New C1.Win.C1InputPanel.InputLabel()
        Me.company = New C1.Win.C1InputPanel.InputComboBox()
        Me.InputLabel9 = New C1.Win.C1InputPanel.InputLabel()
        Me.department = New C1.Win.C1InputPanel.InputComboBox()
        Me.InputLabel10 = New C1.Win.C1InputPanel.InputLabel()
        Me.locations = New C1.Win.C1InputPanel.InputComboBox()
        Me.InputLabel11 = New C1.Win.C1InputPanel.InputLabel()
        Me.team = New C1.Win.C1InputPanel.InputComboBox()
        Me.InputLabel12 = New C1.Win.C1InputPanel.InputLabel()
        Me.position = New C1.Win.C1InputPanel.InputComboBox()
        Me.InputLabel3 = New C1.Win.C1InputPanel.InputLabel()
        Me.payrollgroup = New C1.Win.C1InputPanel.InputComboBox()
        Me.InputLabel1 = New C1.Win.C1InputPanel.InputLabel()
        Me.employmentlevel = New C1.Win.C1InputPanel.InputComboBox()
        Me.InputLabel4 = New C1.Win.C1InputPanel.InputLabel()
        Me.employmentstatus = New C1.Win.C1InputPanel.InputComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.ExpandablePanel1.SuspendLayout()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BasicSearchOption, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CrystalReportViewer2
        '
        Me.CrystalReportViewer2.ActiveViewIndex = -1
        Me.CrystalReportViewer2.AutoSize = True
        Me.CrystalReportViewer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer2.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer2.DisplayBackgroundEdge = False
        Me.CrystalReportViewer2.DisplayStatusBar = False
        Me.CrystalReportViewer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer2.EnableDrillDown = False
        Me.CrystalReportViewer2.EnableToolTips = False
        Me.CrystalReportViewer2.Location = New System.Drawing.Point(385, 0)
        Me.CrystalReportViewer2.Name = "CrystalReportViewer2"
        Me.CrystalReportViewer2.ShowGroupTreeButton = False
        Me.CrystalReportViewer2.ShowParameterPanelButton = False
        Me.CrystalReportViewer2.ShowRefreshButton = False
        Me.CrystalReportViewer2.Size = New System.Drawing.Size(585, 533)
        Me.CrystalReportViewer2.TabIndex = 0
        Me.CrystalReportViewer2.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintReportButton, Me.ExportReportButton, Me.RefreshReportButton, Me.CloseFormButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(380, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.ShowItemToolTips = False
        Me.ToolStrip1.Size = New System.Drawing.Size(590, 25)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        Me.ToolStrip1.Visible = False
        '
        'PrintReportButton
        '
        Me.PrintReportButton.Image = CType(resources.GetObject("PrintReportButton.Image"), System.Drawing.Image)
        Me.PrintReportButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintReportButton.Name = "PrintReportButton"
        Me.PrintReportButton.Size = New System.Drawing.Size(108, 22)
        Me.PrintReportButton.Text = "&Print Report"
        '
        'ExportReportButton
        '
        Me.ExportReportButton.Image = CType(resources.GetObject("ExportReportButton.Image"), System.Drawing.Image)
        Me.ExportReportButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ExportReportButton.Name = "ExportReportButton"
        Me.ExportReportButton.Size = New System.Drawing.Size(121, 22)
        Me.ExportReportButton.Text = "&Export Report"
        '
        'RefreshReportButton
        '
        Me.RefreshReportButton.Image = CType(resources.GetObject("RefreshReportButton.Image"), System.Drawing.Image)
        Me.RefreshReportButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RefreshReportButton.Name = "RefreshReportButton"
        Me.RefreshReportButton.Size = New System.Drawing.Size(127, 22)
        Me.RefreshReportButton.Text = "&Refresh Report"
        '
        'CloseFormButton
        '
        Me.CloseFormButton.Image = CType(resources.GetObject("CloseFormButton.Image"), System.Drawing.Image)
        Me.CloseFormButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CloseFormButton.Name = "CloseFormButton"
        Me.CloseFormButton.Size = New System.Drawing.Size(103, 22)
        Me.CloseFormButton.Text = "&Close Form"
        '
        'ExpandablePanel1
        '
        Me.ExpandablePanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.ExpandablePanel1.CollapseDirection = DevComponents.DotNetBar.eCollapseDirection.RightToLeft
        Me.ExpandablePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ExpandablePanel1.Controls.Add(Me.C1InputPanel2)
        Me.ExpandablePanel1.Controls.Add(Me.BasicSearchOption)
        Me.ExpandablePanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.ExpandablePanel1.Location = New System.Drawing.Point(0, 0)
        Me.ExpandablePanel1.Name = "ExpandablePanel1"
        Me.ExpandablePanel1.Padding = New System.Windows.Forms.Padding(2)
        Me.ExpandablePanel1.Size = New System.Drawing.Size(380, 533)
        Me.ExpandablePanel1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.ExpandablePanel1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.ExpandablePanel1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.ExpandablePanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.ExpandablePanel1.Style.BorderColor.Color = System.Drawing.SystemColors.WindowFrame
        Me.ExpandablePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.ExpandablePanel1.Style.GradientAngle = 90
        Me.ExpandablePanel1.TabIndex = 4
        Me.ExpandablePanel1.TitleStyle.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ExpandablePanel1.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.ExpandablePanel1.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.ExpandablePanel1.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ExpandablePanel1.TitleStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExpandablePanel1.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.ExpandablePanel1.TitleStyle.GradientAngle = 90
        Me.ExpandablePanel1.TitleStyle.MarginLeft = 10
        Me.ExpandablePanel1.TitleText = "Search Panel"
        '
        'C1InputPanel2
        '
        Me.C1InputPanel2.AllowDrop = True
        Me.C1InputPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.C1InputPanel2.BorderColor = System.Drawing.Color.Empty
        Me.C1InputPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1InputPanel2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1InputPanel2.Items.Add(Me.cmdPrint)
        Me.C1InputPanel2.Items.Add(Me.cmdClear)
        Me.C1InputPanel2.Items.Add(Me.RefreshDropDownsCombo)
        Me.C1InputPanel2.Location = New System.Drawing.Point(2, 328)
        Me.C1InputPanel2.Name = "C1InputPanel2"
        Me.C1InputPanel2.Padding = New System.Windows.Forms.Padding(2, 3, 2, 0)
        Me.C1InputPanel2.Size = New System.Drawing.Size(376, 203)
        Me.C1InputPanel2.SmoothScrolling = True
        Me.C1InputPanel2.TabIndex = 65
        Me.C1InputPanel2.VisualStyle = C1.Win.C1InputPanel.VisualStyle.System
        '
        'cmdPrint
        '
        Me.cmdPrint.Break = C1.Win.C1InputPanel.BreakType.None
        Me.cmdPrint.ElementWidth = 110
        Me.cmdPrint.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.ImageScaling = C1.Win.C1InputPanel.InputImageScaling.Stretch
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Text = "Preview Data"
        Me.cmdPrint.ToolTipText = "Click this button to preview the report based on the data supplied"
        Me.cmdPrint.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.cmdPrint.Width = 204
        '
        'cmdClear
        '
        Me.cmdClear.Break = C1.Win.C1InputPanel.BreakType.None
        Me.cmdClear.Image = CType(resources.GetObject("cmdClear.Image"), System.Drawing.Image)
        Me.cmdClear.ImageScaling = C1.Win.C1InputPanel.InputImageScaling.TileStretchVertical
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Text = "Clear"
        Me.cmdClear.ToolTipText = "Click the button to clear all filled up fields"
        Me.cmdClear.Width = 59
        '
        'RefreshDropDownsCombo
        '
        Me.RefreshDropDownsCombo.Image = CType(resources.GetObject("RefreshDropDownsCombo.Image"), System.Drawing.Image)
        Me.RefreshDropDownsCombo.ImageScaling = C1.Win.C1InputPanel.InputImageScaling.TileStretchVertical
        Me.RefreshDropDownsCombo.Name = "RefreshDropDownsCombo"
        Me.RefreshDropDownsCombo.Text = "Refresh"
        Me.RefreshDropDownsCombo.ToolTipText = "Use this button to refresh the list of combo boxes"
        Me.RefreshDropDownsCombo.Width = 82
        '
        'BasicSearchOption
        '
        Me.BasicSearchOption.AllowDrop = True
        Me.BasicSearchOption.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.BasicSearchOption.BorderColor = System.Drawing.Color.Empty
        Me.BasicSearchOption.Dock = System.Windows.Forms.DockStyle.Top
        Me.BasicSearchOption.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicSearchOption.Items.Add(Me.InputGroupHeader2)
        Me.BasicSearchOption.Items.Add(Me.InputLabel2)
        Me.BasicSearchOption.Items.Add(Me.InputLabel43)
        Me.BasicSearchOption.Items.Add(Me.InputLabel13)
        Me.BasicSearchOption.Items.Add(Me.rdoCompany)
        Me.BasicSearchOption.Items.Add(Me.rdodepartment)
        Me.BasicSearchOption.Items.Add(Me.rdolocation)
        Me.BasicSearchOption.Items.Add(Me.rdoposition)
        Me.BasicSearchOption.Items.Add(Me.rdopayrollgroup)
        Me.BasicSearchOption.Items.Add(Me.InputLabel15)
        Me.BasicSearchOption.Items.Add(Me.InputLabel8)
        Me.BasicSearchOption.Items.Add(Me.company)
        Me.BasicSearchOption.Items.Add(Me.InputLabel9)
        Me.BasicSearchOption.Items.Add(Me.department)
        Me.BasicSearchOption.Items.Add(Me.InputLabel10)
        Me.BasicSearchOption.Items.Add(Me.locations)
        Me.BasicSearchOption.Items.Add(Me.InputLabel11)
        Me.BasicSearchOption.Items.Add(Me.team)
        Me.BasicSearchOption.Items.Add(Me.InputLabel12)
        Me.BasicSearchOption.Items.Add(Me.position)
        Me.BasicSearchOption.Items.Add(Me.InputLabel3)
        Me.BasicSearchOption.Items.Add(Me.payrollgroup)
        Me.BasicSearchOption.Items.Add(Me.InputLabel1)
        Me.BasicSearchOption.Items.Add(Me.employmentlevel)
        Me.BasicSearchOption.Items.Add(Me.InputLabel4)
        Me.BasicSearchOption.Items.Add(Me.employmentstatus)
        Me.BasicSearchOption.Location = New System.Drawing.Point(2, 28)
        Me.BasicSearchOption.Name = "BasicSearchOption"
        Me.BasicSearchOption.Padding = New System.Windows.Forms.Padding(2, 3, 2, 0)
        Me.BasicSearchOption.Size = New System.Drawing.Size(376, 300)
        Me.BasicSearchOption.SmoothScrolling = True
        Me.BasicSearchOption.TabIndex = 61
        Me.BasicSearchOption.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Silver
        '
        'InputGroupHeader2
        '
        Me.InputGroupHeader2.BackColor = System.Drawing.Color.Transparent
        Me.InputGroupHeader2.ElementHeight = 30
        Me.InputGroupHeader2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputGroupHeader2.Height = 19
        Me.InputGroupHeader2.Name = "InputGroupHeader2"
        Me.InputGroupHeader2.Padding = New System.Windows.Forms.Padding(-1, -5, 0, 0)
        Me.InputGroupHeader2.Text = "FILTER EMPLOYEE REPORT"
        '
        'InputLabel2
        '
        Me.InputLabel2.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel2.Height = 13
        Me.InputLabel2.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Near
        Me.InputLabel2.Name = "InputLabel2"
        Me.InputLabel2.Text = "Filter the records by filling up the fields below."
        Me.InputLabel2.Width = 248
        '
        'InputLabel43
        '
        Me.InputLabel43.AutoEllipsis = False
        Me.InputLabel43.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel43.ForeColor = System.Drawing.Color.Silver
        Me.InputLabel43.Height = 7
        Me.InputLabel43.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Near
        Me.InputLabel43.Name = "InputLabel43"
        Me.InputLabel43.Padding = New System.Windows.Forms.Padding(0, -5, 0, 0)
        Me.InputLabel43.Text = resources.GetString("InputLabel43.Text")
        Me.InputLabel43.Width = 353
        Me.InputLabel43.WordWrap = False
        '
        'InputLabel13
        '
        Me.InputLabel13.Name = "InputLabel13"
        Me.InputLabel13.Text = "Report By:"
        Me.InputLabel13.Width = 85
        '
        'rdoCompany
        '
        Me.rdoCompany.Break = C1.Win.C1InputPanel.BreakType.None
        Me.rdoCompany.Checked = True
        Me.rdoCompany.Name = "rdoCompany"
        Me.rdoCompany.Text = "Company"
        '
        'rdodepartment
        '
        Me.rdodepartment.Break = C1.Win.C1InputPanel.BreakType.None
        Me.rdodepartment.Name = "rdodepartment"
        Me.rdodepartment.Text = "Department"
        '
        'rdolocation
        '
        Me.rdolocation.Name = "rdolocation"
        Me.rdolocation.Text = "Location"
        '
        'rdoposition
        '
        Me.rdoposition.Break = C1.Win.C1InputPanel.BreakType.None
        Me.rdoposition.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.rdoposition.Name = "rdoposition"
        Me.rdoposition.Text = "Position"
        Me.rdoposition.Width = 158
        '
        'rdopayrollgroup
        '
        Me.rdopayrollgroup.Name = "rdopayrollgroup"
        Me.rdopayrollgroup.Text = "Payroll Group"
        Me.rdopayrollgroup.Width = 106
        '
        'InputLabel15
        '
        Me.InputLabel15.AutoEllipsis = False
        Me.InputLabel15.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel15.ForeColor = System.Drawing.Color.Silver
        Me.InputLabel15.Name = "InputLabel15"
        Me.InputLabel15.Text = resources.GetString("InputLabel15.Text")
        Me.InputLabel15.Width = 353
        '
        'InputLabel8
        '
        Me.InputLabel8.Name = "InputLabel8"
        Me.InputLabel8.Text = "Company:"
        Me.InputLabel8.Width = 85
        '
        'company
        '
        Me.company.Name = "company"
        Me.company.Width = 265
        '
        'InputLabel9
        '
        Me.InputLabel9.Name = "InputLabel9"
        Me.InputLabel9.Text = "Department:"
        Me.InputLabel9.Width = 85
        '
        'department
        '
        Me.department.Name = "department"
        Me.department.Width = 265
        '
        'InputLabel10
        '
        Me.InputLabel10.Name = "InputLabel10"
        Me.InputLabel10.Text = "Location:"
        Me.InputLabel10.Width = 85
        '
        'locations
        '
        Me.locations.Name = "locations"
        Me.locations.Width = 265
        '
        'InputLabel11
        '
        Me.InputLabel11.Name = "InputLabel11"
        Me.InputLabel11.Text = "Group/Team:"
        Me.InputLabel11.Width = 85
        '
        'team
        '
        Me.team.Name = "team"
        Me.team.Width = 265
        '
        'InputLabel12
        '
        Me.InputLabel12.Name = "InputLabel12"
        Me.InputLabel12.Text = "Position:"
        Me.InputLabel12.Width = 85
        '
        'position
        '
        Me.position.Name = "position"
        Me.position.Width = 265
        '
        'InputLabel3
        '
        Me.InputLabel3.Name = "InputLabel3"
        Me.InputLabel3.Text = "Payroll Group"
        Me.InputLabel3.Width = 85
        '
        'payrollgroup
        '
        Me.payrollgroup.Name = "payrollgroup"
        Me.payrollgroup.Width = 265
        '
        'InputLabel1
        '
        Me.InputLabel1.Name = "InputLabel1"
        Me.InputLabel1.Text = "Employ. Level:"
        Me.InputLabel1.Width = 85
        '
        'employmentlevel
        '
        Me.employmentlevel.Name = "employmentlevel"
        Me.employmentlevel.Width = 265
        '
        'InputLabel4
        '
        Me.InputLabel4.Name = "InputLabel4"
        Me.InputLabel4.Text = "Employ. Status"
        Me.InputLabel4.Width = 85
        '
        'employmentstatus
        '
        Me.employmentstatus.Name = "employmentstatus"
        Me.employmentstatus.Width = 265
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Location = New System.Drawing.Point(380, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(5, 533)
        Me.Label1.TabIndex = 5
        '
        'HeadCountReport
        '
        Me.ClientSize = New System.Drawing.Size(970, 533)
        Me.Controls.Add(Me.CrystalReportViewer2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ExpandablePanel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "HeadCountReport"
        Me.ShowIcon = False
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Silver
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ExpandablePanel1.ResumeLayout(False)
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BasicSearchOption, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents C1StatusBar1 As C1.Win.C1Ribbon.C1StatusBar
    Friend WithEvents C1Ribbon1 As C1.Win.C1Ribbon.C1Ribbon
    Friend WithEvents RibbonApplicationMenu1 As C1.Win.C1Ribbon.RibbonApplicationMenu
    Friend WithEvents RibbonConfigToolBar1 As C1.Win.C1Ribbon.RibbonConfigToolBar
    Friend WithEvents RibbonQat1 As C1.Win.C1Ribbon.RibbonQat
    Friend WithEvents RibbonTab1 As C1.Win.C1Ribbon.RibbonTab
    Friend WithEvents RibbonGroup1 As C1.Win.C1Ribbon.RibbonGroup
    Friend WithEvents RibbonButton1 As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents CrystalReportViewer2 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents C1Ribbon2 As C1.Win.C1Ribbon.C1Ribbon
    Friend WithEvents RibbonApplicationMenu2 As C1.Win.C1Ribbon.RibbonApplicationMenu
    Friend WithEvents RibbonConfigToolBar2 As C1.Win.C1Ribbon.RibbonConfigToolBar
    Friend WithEvents RibbonQat2 As C1.Win.C1Ribbon.RibbonQat
    Friend WithEvents RibbonTab2 As C1.Win.C1Ribbon.RibbonTab
    Friend WithEvents RibbonGroup2 As C1.Win.C1Ribbon.RibbonGroup
    Friend WithEvents PrintDocument As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents Export As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents C1StatusBar2 As C1.Win.C1Ribbon.C1StatusBar
    Friend WithEvents RibbonTrackBar1 As C1.Win.C1Ribbon.RibbonTrackBar
    Friend WithEvents RibbonButton6 As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents RibbonGroup3 As C1.Win.C1Ribbon.RibbonGroup
    Friend WithEvents First As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents PreviousPage As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents NextPage As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents MoveToLast As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents CloseForm As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents RibbonLabel1 As C1.Win.C1Ribbon.RibbonLabel
    Friend WithEvents CurrentPage As C1.Win.C1Ribbon.RibbonLabel
    Friend WithEvents RibbonLabel3 As C1.Win.C1Ribbon.RibbonLabel
    Friend WithEvents TotPage As C1.Win.C1Ribbon.RibbonLabel
    Friend WithEvents RibbonSeparator2 As C1.Win.C1Ribbon.RibbonSeparator
    Friend WithEvents TextBox1 As C1.Win.C1Ribbon.RibbonTextBox
    Friend WithEvents ZoomOf As C1.Win.C1Ribbon.RibbonLabel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents PrintReportButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ExportReportButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents RefreshReportButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents CloseFormButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents BasicSearchOption As C1.Win.C1InputPanel.C1InputPanel
    Private WithEvents InputGroupHeader2 As C1.Win.C1InputPanel.InputGroupHeader
    Private WithEvents InputLabel2 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents InputLabel43 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel13 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel8 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents company As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents InputLabel9 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents department As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents InputLabel10 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents locations As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents InputLabel11 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents team As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents InputLabel12 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents position As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents rdoCompany As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents rdodepartment As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents rdolocation As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents rdoposition As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rdopayrollgroup As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents InputLabel15 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel3 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents payrollgroup As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents C1InputPanel2 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents cmdPrint As C1.Win.C1InputPanel.InputButton
    Friend WithEvents cmdClear As C1.Win.C1InputPanel.InputButton
    Friend WithEvents RefreshDropDownsCombo As C1.Win.C1InputPanel.InputButton
    Private WithEvents ExpandablePanel1 As DevComponents.DotNetBar.ExpandablePanel
    Friend WithEvents InputLabel1 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents employmentlevel As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents InputLabel4 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents employmentstatus As C1.Win.C1InputPanel.InputComboBox
End Class
