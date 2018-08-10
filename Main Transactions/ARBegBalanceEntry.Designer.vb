<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ARBegBalanceEntry
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ARBegBalanceEntry))
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel1 = New C1.Win.C1InputPanel.InputLabel()
        Me.BBNo = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel2 = New C1.Win.C1InputPanel.InputLabel()
        Me.SIDate = New C1.Win.C1InputPanel.InputDatePicker()
        Me.InputSeparator2 = New C1.Win.C1InputPanel.InputSeparator()
        Me.C1FlexGrid1 = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.C1InputPanel2 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader2 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel12 = New C1.Win.C1InputPanel.InputLabel()
        Me.Remarks = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel5 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputTextBox1 = New C1.Win.C1InputPanel.InputTextBox()
        Me.C1InputPanel4 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputLabel20 = New C1.Win.C1InputPanel.InputLabel()
        Me.NetSalesAmount = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel19 = New C1.Win.C1InputPanel.InputLabel()
        Me.VATAmount = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel18 = New C1.Win.C1InputPanel.InputLabel()
        Me.GrossAmount = New C1.Win.C1InputPanel.InputLabel()
        Me.InputButton1 = New C1.Win.C1InputPanel.InputButton()
        Me.C1Ribbon1 = New C1.Win.C1Ribbon.C1Ribbon()
        Me.RibbonApplicationMenu1 = New C1.Win.C1Ribbon.RibbonApplicationMenu()
        Me.RibbonConfigToolBar1 = New C1.Win.C1Ribbon.RibbonConfigToolBar()
        Me.RibbonQat1 = New C1.Win.C1Ribbon.RibbonQat()
        Me.ModuleControlTab = New C1.Win.C1Ribbon.RibbonTab()
        Me.RibbonGroup1 = New C1.Win.C1Ribbon.RibbonGroup()
        Me.SaveJobOrder = New C1.Win.C1Ribbon.RibbonButton()
        Me.NewArBegBalance = New C1.Win.C1Ribbon.RibbonButton()
        Me.PrintARBegBalance = New C1.Win.C1Ribbon.RibbonButton()
        Me.CancelOrder = New C1.Win.C1Ribbon.RibbonButton()
        Me.CloseForm = New C1.Win.C1Ribbon.RibbonButton()
        Me.CancelSOButton = New C1.Win.C1Ribbon.RibbonButton()
        Me.RibbonGroup2 = New C1.Win.C1Ribbon.RibbonGroup()
        Me.RibbonToolBar2 = New C1.Win.C1Ribbon.RibbonToolBar()
        Me.FontName = New C1.Win.C1Ribbon.RibbonFontComboBox()
        Me.FontSize = New C1.Win.C1Ribbon.RibbonNumericBox()
        Me.RibbonToolBar1 = New C1.Win.C1Ribbon.RibbonToolBar()
        Me.RibbonButton5 = New C1.Win.C1Ribbon.RibbonButton()
        Me.RibbonButton3 = New C1.Win.C1Ribbon.RibbonButton()
        Me.cancelled = New System.Windows.Forms.Label()
        Me.C1StatusBar1 = New C1.Win.C1Ribbon.C1StatusBar()
        Me.StatusLabel = New C1.Win.C1Ribbon.RibbonLabel()
        Me.RibbonSeparator1 = New C1.Win.C1Ribbon.RibbonSeparator()
        Me.CapsLockButton = New C1.Win.C1Ribbon.RibbonLabel()
        Me.CapsSep = New C1.Win.C1Ribbon.RibbonSeparator()
        Me.NumLockButton = New C1.Win.C1Ribbon.RibbonLabel()
        Me.NumSep = New C1.Win.C1Ribbon.RibbonSeparator()
        Me.ScrollLockButton = New C1.Win.C1Ribbon.RibbonLabel()
        Me.LineRow = New C1.Win.C1Ribbon.RibbonLabel()
        Me.Newcreditmemo = New C1.Win.C1Ribbon.RibbonButton()
        Me.PrintCreditMemo = New C1.Win.C1Ribbon.RibbonButton()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1FlexGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Ribbon1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1StatusBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.C1InputPanel1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader1)
        Me.C1InputPanel1.Items.Add(Me.InputLabel1)
        Me.C1InputPanel1.Items.Add(Me.BBNo)
        Me.C1InputPanel1.Items.Add(Me.InputLabel2)
        Me.C1InputPanel1.Items.Add(Me.SIDate)
        Me.C1InputPanel1.Items.Add(Me.InputSeparator2)
        Me.C1InputPanel1.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Padding = New System.Windows.Forms.Padding(5)
        Me.C1InputPanel1.Size = New System.Drawing.Size(384, 129)
        Me.C1InputPanel1.TabIndex = 0
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Height = 20
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        Me.InputGroupHeader1.Text = "Beginning Balance Details:"
        '
        'InputLabel1
        '
        Me.InputLabel1.Name = "InputLabel1"
        Me.InputLabel1.Text = "BB No:"
        Me.InputLabel1.Width = 76
        '
        'BBNo
        '
        Me.BBNo.Height = 25
        Me.BBNo.Name = "BBNo"
        Me.BBNo.Width = 237
        '
        'InputLabel2
        '
        Me.InputLabel2.Name = "InputLabel2"
        Me.InputLabel2.Text = "Date:"
        Me.InputLabel2.Width = 76
        '
        'SIDate
        '
        Me.SIDate.Name = "SIDate"
        Me.SIDate.Width = 237
        '
        'InputSeparator2
        '
        Me.InputSeparator2.Name = "InputSeparator2"
        Me.InputSeparator2.Width = 348
        '
        'C1FlexGrid1
        '
        Me.C1FlexGrid1.AllowAddNew = True
        Me.C1FlexGrid1.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.C1FlexGrid1.AllowFiltering = True
        Me.C1FlexGrid1.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.MultiColumn
        Me.C1FlexGrid1.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
        Me.C1FlexGrid1.ColumnInfo = resources.GetString("C1FlexGrid1.ColumnInfo")
        Me.C1FlexGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1FlexGrid1.ExtendLastCol = True
        Me.C1FlexGrid1.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
        Me.C1FlexGrid1.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.C1FlexGrid1.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.None
        Me.C1FlexGrid1.Location = New System.Drawing.Point(0, 258)
        Me.C1FlexGrid1.Name = "C1FlexGrid1"
        Me.C1FlexGrid1.Rows.Count = 10
        Me.C1FlexGrid1.Rows.DefaultSize = 25
        Me.C1FlexGrid1.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.C1FlexGrid1.Size = New System.Drawing.Size(1028, 316)
        Me.C1FlexGrid1.StyleInfo = resources.GetString("C1FlexGrid1.StyleInfo")
        Me.C1FlexGrid1.TabIndex = 0
        Me.C1FlexGrid1.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.System
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.C1InputPanel2)
        Me.Panel1.Controls.Add(Me.C1InputPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 129)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1028, 129)
        Me.Panel1.TabIndex = 0
        '
        'C1InputPanel2
        '
        Me.C1InputPanel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.C1InputPanel2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1InputPanel2.Items.Add(Me.InputGroupHeader2)
        Me.C1InputPanel2.Items.Add(Me.InputLabel12)
        Me.C1InputPanel2.Items.Add(Me.Remarks)
        Me.C1InputPanel2.Location = New System.Drawing.Point(384, 0)
        Me.C1InputPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.C1InputPanel2.Name = "C1InputPanel2"
        Me.C1InputPanel2.Padding = New System.Windows.Forms.Padding(5)
        Me.C1InputPanel2.Size = New System.Drawing.Size(644, 129)
        Me.C1InputPanel2.TabIndex = 1
        Me.C1InputPanel2.VisualStyle = C1.Win.C1InputPanel.VisualStyle.System
        '
        'InputGroupHeader2
        '
        Me.InputGroupHeader2.Height = 20
        Me.InputGroupHeader2.Name = "InputGroupHeader2"
        '
        'InputLabel12
        '
        Me.InputLabel12.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel12.Name = "InputLabel12"
        Me.InputLabel12.Text = "Remarks:"
        Me.InputLabel12.Width = 96
        '
        'Remarks
        '
        Me.Remarks.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Remarks.Height = 61
        Me.Remarks.Multiline = True
        Me.Remarks.Name = "Remarks"
        Me.Remarks.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Spread
        Me.Remarks.Width = 500
        Me.Remarks.WordWrap = False
        '
        'InputLabel5
        '
        Me.InputLabel5.Name = "InputLabel5"
        Me.InputLabel5.Text = "LC No:"
        Me.InputLabel5.Width = 47
        '
        'InputTextBox1
        '
        Me.InputTextBox1.Break = C1.Win.C1InputPanel.BreakType.None
        Me.InputTextBox1.Name = "InputTextBox1"
        Me.InputTextBox1.Width = 89
        '
        'C1InputPanel4
        '
        Me.C1InputPanel4.BackColor = System.Drawing.SystemColors.Control
        Me.C1InputPanel4.BorderThickness = 1
        Me.C1InputPanel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.C1InputPanel4.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1InputPanel4.Items.Add(Me.InputLabel20)
        Me.C1InputPanel4.Items.Add(Me.NetSalesAmount)
        Me.C1InputPanel4.Items.Add(Me.InputLabel19)
        Me.C1InputPanel4.Items.Add(Me.VATAmount)
        Me.C1InputPanel4.Items.Add(Me.InputLabel18)
        Me.C1InputPanel4.Items.Add(Me.GrossAmount)
        Me.C1InputPanel4.Location = New System.Drawing.Point(0, 574)
        Me.C1InputPanel4.Name = "C1InputPanel4"
        Me.C1InputPanel4.Padding = New System.Windows.Forms.Padding(5)
        Me.C1InputPanel4.Size = New System.Drawing.Size(1028, 33)
        Me.C1InputPanel4.TabIndex = 2
        '
        'InputLabel20
        '
        Me.InputLabel20.ForeColor = System.Drawing.Color.Black
        Me.InputLabel20.Name = "InputLabel20"
        Me.InputLabel20.Text = "Vatable Sales"
        '
        'NetSalesAmount
        '
        Me.NetSalesAmount.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NetSalesAmount.ForeColor = System.Drawing.Color.Black
        Me.NetSalesAmount.Name = "NetSalesAmount"
        Me.NetSalesAmount.Text = "PHP 0.00"
        '
        'InputLabel19
        '
        Me.InputLabel19.ForeColor = System.Drawing.Color.Black
        Me.InputLabel19.Name = "InputLabel19"
        Me.InputLabel19.Text = "VAT(12%):"
        Me.InputLabel19.Width = 84
        '
        'VATAmount
        '
        Me.VATAmount.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.VATAmount.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VATAmount.ForeColor = System.Drawing.Color.Black
        Me.VATAmount.Name = "VATAmount"
        Me.VATAmount.Text = "PHP 0.00"
        '
        'InputLabel18
        '
        Me.InputLabel18.ForeColor = System.Drawing.Color.Black
        Me.InputLabel18.Name = "InputLabel18"
        Me.InputLabel18.Text = "Total Sales Amount: "
        '
        'GrossAmount
        '
        Me.GrossAmount.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.GrossAmount.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrossAmount.ForeColor = System.Drawing.Color.Black
        Me.GrossAmount.Name = "GrossAmount"
        Me.GrossAmount.Text = "PHP 0.00"
        '
        'InputButton1
        '
        Me.InputButton1.Break = C1.Win.C1InputPanel.BreakType.None
        Me.InputButton1.Height = 22
        Me.InputButton1.Image = CType(resources.GetObject("InputButton1.Image"), System.Drawing.Image)
        Me.InputButton1.ImageScaling = C1.Win.C1InputPanel.InputImageScaling.Stretch
        Me.InputButton1.Name = "InputButton1"
        Me.InputButton1.Width = 25
        '
        'C1Ribbon1
        '
        Me.C1Ribbon1.ApplicationMenuHolder = Me.RibbonApplicationMenu1
        Me.C1Ribbon1.ConfigToolBarHolder = Me.RibbonConfigToolBar1
        Me.C1Ribbon1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1Ribbon1.Location = New System.Drawing.Point(0, 0)
        Me.C1Ribbon1.Name = "C1Ribbon1"
        Me.C1Ribbon1.QatHolder = Me.RibbonQat1
        Me.C1Ribbon1.Size = New System.Drawing.Size(1028, 129)
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
        Me.ModuleControlTab.Groups.Add(Me.RibbonGroup2)
        Me.ModuleControlTab.Name = "ModuleControlTab"
        Me.ModuleControlTab.Text = "Module Controls"
        '
        'RibbonGroup1
        '
        Me.RibbonGroup1.Items.Add(Me.SaveJobOrder)
        Me.RibbonGroup1.Items.Add(Me.NewArBegBalance)
        Me.RibbonGroup1.Items.Add(Me.PrintARBegBalance)
        Me.RibbonGroup1.Items.Add(Me.CancelOrder)
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
        Me.SaveJobOrder.Text = "Save Beg Balance"
        '
        'NewArBegBalance
        '
        Me.NewArBegBalance.CanBeAddedToQat = False
        Me.NewArBegBalance.LargeImage = CType(resources.GetObject("NewArBegBalance.LargeImage"), System.Drawing.Image)
        Me.NewArBegBalance.Name = "NewArBegBalance"
        Me.NewArBegBalance.SmallImage = Global.A1plus.My.Resources.Resources.new_window__1_
        Me.NewArBegBalance.SupportedGroupSizing = C1.Win.C1Ribbon.SupportedGroupSizing.LargeImageOnly
        Me.NewArBegBalance.Text = "New Beg. Balance"
        '
        'PrintARBegBalance
        '
        Me.PrintARBegBalance.CanBeAddedToQat = False
        Me.PrintARBegBalance.LargeImage = CType(resources.GetObject("PrintARBegBalance.LargeImage"), System.Drawing.Image)
        Me.PrintARBegBalance.Name = "PrintARBegBalance"
        Me.PrintARBegBalance.SmallImage = CType(resources.GetObject("PrintARBegBalance.SmallImage"), System.Drawing.Image)
        Me.PrintARBegBalance.SupportedGroupSizing = C1.Win.C1Ribbon.SupportedGroupSizing.LargeImageOnly
        Me.PrintARBegBalance.Text = "Print Beg. Balance"
        '
        'CancelOrder
        '
        Me.CancelOrder.CanBeAddedToQat = False
        Me.CancelOrder.LargeImage = CType(resources.GetObject("CancelOrder.LargeImage"), System.Drawing.Image)
        Me.CancelOrder.Name = "CancelOrder"
        Me.CancelOrder.SmallImage = CType(resources.GetObject("CancelOrder.SmallImage"), System.Drawing.Image)
        Me.CancelOrder.SupportedGroupSizing = C1.Win.C1Ribbon.SupportedGroupSizing.LargeImageOnly
        Me.CancelOrder.Text = "Cancel Beg. Balance"
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
        'RibbonGroup2
        '
        Me.RibbonGroup2.Items.Add(Me.RibbonToolBar2)
        Me.RibbonGroup2.Items.Add(Me.RibbonToolBar1)
        Me.RibbonGroup2.Name = "RibbonGroup2"
        Me.RibbonGroup2.Text = "Zoom and Grid Styles"
        '
        'RibbonToolBar2
        '
        Me.RibbonToolBar2.Items.Add(Me.FontName)
        Me.RibbonToolBar2.Items.Add(Me.FontSize)
        Me.RibbonToolBar2.Name = "RibbonToolBar2"
        '
        'FontName
        '
        Me.FontName.Name = "FontName"
        Me.FontName.Text = "Tahoma"
        Me.FontName.TextAreaWidth = 115
        '
        'FontSize
        '
        Me.FontSize.Name = "FontSize"
        Me.FontSize.TextAreaWidth = 25
        Me.FontSize.Value = New Decimal(New Integer() {8, 0, 0, 0})
        '
        'RibbonToolBar1
        '
        Me.RibbonToolBar1.Items.Add(Me.RibbonButton5)
        Me.RibbonToolBar1.Items.Add(Me.RibbonButton3)
        Me.RibbonToolBar1.Name = "RibbonToolBar1"
        '
        'RibbonButton5
        '
        Me.RibbonButton5.Name = "RibbonButton5"
        Me.RibbonButton5.SmallImage = CType(resources.GetObject("RibbonButton5.SmallImage"), System.Drawing.Image)
        Me.RibbonButton5.Text = "Shrink Font"
        '
        'RibbonButton3
        '
        Me.RibbonButton3.Name = "RibbonButton3"
        Me.RibbonButton3.SmallImage = CType(resources.GetObject("RibbonButton3.SmallImage"), System.Drawing.Image)
        Me.RibbonButton3.Text = "Grow Font"
        '
        'cancelled
        '
        Me.cancelled.AutoSize = True
        Me.cancelled.BackColor = System.Drawing.Color.Transparent
        Me.cancelled.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelled.ForeColor = System.Drawing.Color.Maroon
        Me.cancelled.Location = New System.Drawing.Point(510, 38)
        Me.cancelled.Name = "cancelled"
        Me.cancelled.Size = New System.Drawing.Size(42, 25)
        Me.cancelled.TabIndex = 88
        Me.cancelled.Text = "     "
        '
        'C1StatusBar1
        '
        Me.C1StatusBar1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1StatusBar1.LeftPaneItems.Add(Me.StatusLabel)
        Me.C1StatusBar1.LeftPaneItems.Add(Me.RibbonSeparator1)
        Me.C1StatusBar1.LeftPaneItems.Add(Me.CapsLockButton)
        Me.C1StatusBar1.LeftPaneItems.Add(Me.CapsSep)
        Me.C1StatusBar1.LeftPaneItems.Add(Me.NumLockButton)
        Me.C1StatusBar1.LeftPaneItems.Add(Me.NumSep)
        Me.C1StatusBar1.LeftPaneItems.Add(Me.ScrollLockButton)
        Me.C1StatusBar1.LeftPaneItems.Add(Me.LineRow)
        Me.C1StatusBar1.Location = New System.Drawing.Point(0, 607)
        Me.C1StatusBar1.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.C1StatusBar1.Name = "C1StatusBar1"
        Me.C1StatusBar1.Size = New System.Drawing.Size(1028, 22)
        Me.C1StatusBar1.VisualStyle = C1.Win.C1Ribbon.VisualStyle.Office2010Silver
        '
        'StatusLabel
        '
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Text = "Ready"
        '
        'RibbonSeparator1
        '
        Me.RibbonSeparator1.Name = "RibbonSeparator1"
        '
        'CapsLockButton
        '
        Me.CapsLockButton.Name = "CapsLockButton"
        Me.CapsLockButton.Text = "Caps Lock"
        Me.CapsLockButton.Visible = False
        '
        'CapsSep
        '
        Me.CapsSep.Name = "CapsSep"
        Me.CapsSep.Visible = False
        '
        'NumLockButton
        '
        Me.NumLockButton.Name = "NumLockButton"
        Me.NumLockButton.Text = "Num Lock"
        Me.NumLockButton.Visible = False
        '
        'NumSep
        '
        Me.NumSep.Name = "NumSep"
        Me.NumSep.Visible = False
        '
        'ScrollLockButton
        '
        Me.ScrollLockButton.Name = "ScrollLockButton"
        Me.ScrollLockButton.Text = "Scroll Lock"
        Me.ScrollLockButton.Visible = False
        '
        'LineRow
        '
        Me.LineRow.Name = "LineRow"
        Me.LineRow.Text = "LineRow"
        Me.LineRow.Visible = False
        '
        'Newcreditmemo
        '
        Me.Newcreditmemo.CanBeAddedToQat = False
        Me.Newcreditmemo.LargeImage = CType(resources.GetObject("Newcreditmemo.LargeImage"), System.Drawing.Image)
        Me.Newcreditmemo.Name = "Newcreditmemo"
        Me.Newcreditmemo.SmallImage = Global.A1plus.My.Resources.Resources.new_window__1_
        Me.Newcreditmemo.SupportedGroupSizing = C1.Win.C1Ribbon.SupportedGroupSizing.LargeImageOnly
        Me.Newcreditmemo.Text = "New Beg. Balance"
        '
        'PrintCreditMemo
        '
        Me.PrintCreditMemo.CanBeAddedToQat = False
        Me.PrintCreditMemo.LargeImage = CType(resources.GetObject("PrintCreditMemo.LargeImage"), System.Drawing.Image)
        Me.PrintCreditMemo.Name = "PrintCreditMemo"
        Me.PrintCreditMemo.SmallImage = CType(resources.GetObject("PrintCreditMemo.SmallImage"), System.Drawing.Image)
        Me.PrintCreditMemo.SupportedGroupSizing = C1.Win.C1Ribbon.SupportedGroupSizing.LargeImageOnly
        Me.PrintCreditMemo.Text = "Print Beg. Balance"
        '
        'ARBegBalanceEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 629)
        Me.Controls.Add(Me.cancelled)
        Me.Controls.Add(Me.C1FlexGrid1)
        Me.Controls.Add(Me.C1InputPanel4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.C1Ribbon1)
        Me.Controls.Add(Me.C1StatusBar1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ARBegBalanceEntry"
        Me.Text = "Beginning Balance Entry"
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1FlexGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Ribbon1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1StatusBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputLabel1 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents BBNo As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel2 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents SIDate As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents InputSeparator2 As C1.Win.C1InputPanel.InputSeparator
    Friend WithEvents InputLabel5 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputTextBox1 As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputButton1 As C1.Win.C1InputPanel.InputButton
    Friend WithEvents C1FlexGrid1 As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents C1InputPanel2 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader2 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputLabel12 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents Remarks As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents C1InputPanel4 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputLabel20 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents NetSalesAmount As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel19 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents VATAmount As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel18 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents GrossAmount As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents C1Ribbon1 As C1.Win.C1Ribbon.C1Ribbon
    Public WithEvents RibbonApplicationMenu1 As C1.Win.C1Ribbon.RibbonApplicationMenu
    Friend WithEvents RibbonConfigToolBar1 As C1.Win.C1Ribbon.RibbonConfigToolBar
    Public WithEvents RibbonQat1 As C1.Win.C1Ribbon.RibbonQat
    Public WithEvents ModuleControlTab As C1.Win.C1Ribbon.RibbonTab
    Friend WithEvents RibbonGroup1 As C1.Win.C1Ribbon.RibbonGroup
    Friend WithEvents SaveJobOrder As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents NewArBegBalance As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents CloseForm As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents CancelSOButton As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents RibbonGroup2 As C1.Win.C1Ribbon.RibbonGroup
    Friend WithEvents RibbonToolBar2 As C1.Win.C1Ribbon.RibbonToolBar
    Friend WithEvents FontName As C1.Win.C1Ribbon.RibbonFontComboBox
    Friend WithEvents FontSize As C1.Win.C1Ribbon.RibbonNumericBox
    Friend WithEvents RibbonToolBar1 As C1.Win.C1Ribbon.RibbonToolBar
    Friend WithEvents RibbonButton5 As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents RibbonButton3 As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents PrintARBegBalance As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents CancelOrder As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents cancelled As System.Windows.Forms.Label
    Friend WithEvents C1StatusBar1 As C1.Win.C1Ribbon.C1StatusBar
    Friend WithEvents StatusLabel As C1.Win.C1Ribbon.RibbonLabel
    Friend WithEvents RibbonSeparator1 As C1.Win.C1Ribbon.RibbonSeparator
    Friend WithEvents CapsLockButton As C1.Win.C1Ribbon.RibbonLabel
    Friend WithEvents CapsSep As C1.Win.C1Ribbon.RibbonSeparator
    Friend WithEvents NumLockButton As C1.Win.C1Ribbon.RibbonLabel
    Friend WithEvents NumSep As C1.Win.C1Ribbon.RibbonSeparator
    Friend WithEvents ScrollLockButton As C1.Win.C1Ribbon.RibbonLabel
    Friend WithEvents LineRow As C1.Win.C1Ribbon.RibbonLabel
    Friend WithEvents Newcreditmemo As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents PrintCreditMemo As C1.Win.C1Ribbon.RibbonButton
End Class
