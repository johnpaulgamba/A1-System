<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class salesinvoiceEntry
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(salesinvoiceEntry))
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel1 = New C1.Win.C1InputPanel.InputLabel()
        Me.SINo = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel2 = New C1.Win.C1InputPanel.InputLabel()
        Me.SIDate = New C1.Win.C1InputPanel.InputDatePicker()
        Me.InputLabel4 = New C1.Win.C1InputPanel.InputLabel()
        Me.CreditTerms = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel13 = New C1.Win.C1InputPanel.InputLabel()
        Me.DueDate = New C1.Win.C1InputPanel.InputDatePicker()
        Me.InputSeparator2 = New C1.Win.C1InputPanel.InputSeparator()
        Me.InputLabel16 = New C1.Win.C1InputPanel.InputLabel()
        Me.VATIn = New C1.Win.C1InputPanel.InputRadioButton()
        Me.VATEx = New C1.Win.C1InputPanel.InputRadioButton()
        Me.InputLabel17 = New C1.Win.C1InputPanel.InputLabel()
        Me.Currency = New C1.Win.C1InputPanel.InputComboBox()
        Me.InputOption1 = New C1.Win.C1InputPanel.InputOption()
        Me.InputOption2 = New C1.Win.C1InputPanel.InputOption()
        Me.InputLabel14 = New C1.Win.C1InputPanel.InputLabel()
        Me.SIAmount = New C1.Win.C1InputPanel.InputTextBox()
        Me.Paid = New C1.Win.C1InputPanel.InputCheckBox()
        Me.C1DockingTab1 = New C1.Win.C1Command.C1DockingTab()
        Me.C1DockingTabPage1 = New C1.Win.C1Command.C1DockingTabPage()
        Me.C1FlexGrid2 = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1DockingTabPage2 = New C1.Win.C1Command.C1DockingTabPage()
        Me.C1FlexGrid1 = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1InputPanel4 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputLabel20 = New C1.Win.C1InputPanel.InputLabel()
        Me.NetSalesAmount = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel19 = New C1.Win.C1InputPanel.InputLabel()
        Me.VATAmount = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel18 = New C1.Win.C1InputPanel.InputLabel()
        Me.GrossAmount = New C1.Win.C1InputPanel.InputLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.C1InputPanel2 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader2 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel6 = New C1.Win.C1InputPanel.InputLabel()
        Me.CustomerName = New C1.Win.C1InputPanel.InputComboBox()
        Me.InputLabel7 = New C1.Win.C1InputPanel.InputLabel()
        Me.Address = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel9 = New C1.Win.C1InputPanel.InputLabel()
        Me.TIN = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel8 = New C1.Win.C1InputPanel.InputLabel()
        Me.BusinessType = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputSeparator1 = New C1.Win.C1InputPanel.InputSeparator()
        Me.InputLabel12 = New C1.Win.C1InputPanel.InputLabel()
        Me.Remarks = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel5 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputTextBox1 = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputButton1 = New C1.Win.C1InputPanel.InputButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.C1InputPanel5 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputLabel11 = New C1.Win.C1InputPanel.InputLabel()
        Me.DRNox = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel3 = New C1.Win.C1InputPanel.InputLabel()
        Me.PONo = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel10 = New C1.Win.C1InputPanel.InputLabel()
        Me.RRNo = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel15 = New C1.Win.C1InputPanel.InputLabel()
        Me.orno = New C1.Win.C1InputPanel.InputTextBox()
        Me.C1Ribbon1 = New C1.Win.C1Ribbon.C1Ribbon()
        Me.RibbonApplicationMenu1 = New C1.Win.C1Ribbon.RibbonApplicationMenu()
        Me.RibbonConfigToolBar1 = New C1.Win.C1Ribbon.RibbonConfigToolBar()
        Me.RibbonQat1 = New C1.Win.C1Ribbon.RibbonQat()
        Me.ModuleControlTab = New C1.Win.C1Ribbon.RibbonTab()
        Me.RibbonGroup1 = New C1.Win.C1Ribbon.RibbonGroup()
        Me.SaveJobOrder = New C1.Win.C1Ribbon.RibbonButton()
        Me.NewSalesOrder = New C1.Win.C1Ribbon.RibbonButton()
        Me.PrintCreditMemo = New C1.Win.C1Ribbon.RibbonButton()
        Me.Cancelorder = New C1.Win.C1Ribbon.RibbonButton()
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.C1Button1 = New C1.Win.C1Input.C1Button()
        Me.C1SuperLabel1 = New C1.Win.C1SuperTooltip.C1SuperLabel()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1DockingTab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1DockingTab1.SuspendLayout()
        Me.C1DockingTabPage1.SuspendLayout()
        CType(Me.C1FlexGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1DockingTabPage2.SuspendLayout()
        CType(Me.C1FlexGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.C1InputPanel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Ribbon1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1StatusBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.C1Button1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.C1InputPanel1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader1)
        Me.C1InputPanel1.Items.Add(Me.InputLabel1)
        Me.C1InputPanel1.Items.Add(Me.SINo)
        Me.C1InputPanel1.Items.Add(Me.InputLabel2)
        Me.C1InputPanel1.Items.Add(Me.SIDate)
        Me.C1InputPanel1.Items.Add(Me.InputLabel4)
        Me.C1InputPanel1.Items.Add(Me.CreditTerms)
        Me.C1InputPanel1.Items.Add(Me.InputLabel13)
        Me.C1InputPanel1.Items.Add(Me.DueDate)
        Me.C1InputPanel1.Items.Add(Me.InputSeparator2)
        Me.C1InputPanel1.Items.Add(Me.InputLabel16)
        Me.C1InputPanel1.Items.Add(Me.VATIn)
        Me.C1InputPanel1.Items.Add(Me.VATEx)
        Me.C1InputPanel1.Items.Add(Me.InputLabel17)
        Me.C1InputPanel1.Items.Add(Me.Currency)
        Me.C1InputPanel1.Items.Add(Me.InputLabel14)
        Me.C1InputPanel1.Items.Add(Me.SIAmount)
        Me.C1InputPanel1.Items.Add(Me.Paid)
        Me.C1InputPanel1.Location = New System.Drawing.Point(644, 0)
        Me.C1InputPanel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Padding = New System.Windows.Forms.Padding(5)
        Me.C1InputPanel1.Size = New System.Drawing.Size(384, 243)
        Me.C1InputPanel1.TabIndex = 1
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Height = 20
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        Me.InputGroupHeader1.Text = "Invoice Details..."
        '
        'InputLabel1
        '
        Me.InputLabel1.Name = "InputLabel1"
        Me.InputLabel1.Text = "SI No."
        Me.InputLabel1.Width = 76
        '
        'SINo
        '
        Me.SINo.Height = 25
        Me.SINo.Name = "SINo"
        Me.SINo.Width = 237
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
        'InputLabel4
        '
        Me.InputLabel4.Name = "InputLabel4"
        Me.InputLabel4.Text = "Terms:"
        Me.InputLabel4.Width = 76
        '
        'CreditTerms
        '
        Me.CreditTerms.Name = "CreditTerms"
        Me.CreditTerms.Width = 236
        '
        'InputLabel13
        '
        Me.InputLabel13.Name = "InputLabel13"
        Me.InputLabel13.Text = "Due Date:"
        Me.InputLabel13.Width = 76
        '
        'DueDate
        '
        Me.DueDate.Name = "DueDate"
        Me.DueDate.Width = 237
        '
        'InputSeparator2
        '
        Me.InputSeparator2.Name = "InputSeparator2"
        Me.InputSeparator2.Width = 348
        '
        'InputLabel16
        '
        Me.InputLabel16.Name = "InputLabel16"
        Me.InputLabel16.Text = "Tax Code:"
        Me.InputLabel16.Width = 74
        '
        'VATIn
        '
        Me.VATIn.Break = C1.Win.C1InputPanel.BreakType.None
        Me.VATIn.Checked = True
        Me.VATIn.Name = "VATIn"
        Me.VATIn.Text = "VAT-In"
        Me.VATIn.Width = 76
        '
        'VATEx
        '
        Me.VATEx.Name = "VATEx"
        Me.VATEx.Text = "VAT-Ex"
        '
        'InputLabel17
        '
        Me.InputLabel17.Name = "InputLabel17"
        Me.InputLabel17.Text = "Currency:"
        Me.InputLabel17.Width = 76
        '
        'Currency
        '
        Me.Currency.Items.Add(Me.InputOption1)
        Me.Currency.Items.Add(Me.InputOption2)
        Me.Currency.Name = "Currency"
        Me.Currency.Text = "Philippine Peso"
        Me.Currency.Width = 236
        '
        'InputOption1
        '
        Me.InputOption1.Name = "InputOption1"
        Me.InputOption1.Text = "Philippine Peso"
        '
        'InputOption2
        '
        Me.InputOption2.Name = "InputOption2"
        Me.InputOption2.Text = "US Dollar"
        '
        'InputLabel14
        '
        Me.InputLabel14.Name = "InputLabel14"
        Me.InputLabel14.Text = "Amount:"
        Me.InputLabel14.Width = 76
        '
        'SIAmount
        '
        Me.SIAmount.Break = C1.Win.C1InputPanel.BreakType.None
        Me.SIAmount.Name = "SIAmount"
        Me.SIAmount.ReadOnly = True
        Me.SIAmount.Width = 190
        '
        'Paid
        '
        Me.Paid.Enabled = False
        Me.Paid.Name = "Paid"
        Me.Paid.Text = "Paid"
        '
        'C1DockingTab1
        '
        Me.C1DockingTab1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1DockingTab1.Controls.Add(Me.C1DockingTabPage1)
        Me.C1DockingTab1.Controls.Add(Me.C1DockingTabPage2)
        Me.C1DockingTab1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1DockingTab1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1DockingTab1.Indent = 4
        Me.C1DockingTab1.Location = New System.Drawing.Point(0, 437)
        Me.C1DockingTab1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.C1DockingTab1.Name = "C1DockingTab1"
        Me.C1DockingTab1.Padding = New System.Drawing.Point(100, 5)
        Me.C1DockingTab1.SelectedIndex = 2
        Me.C1DockingTab1.Size = New System.Drawing.Size(1028, 232)
        Me.C1DockingTab1.TabAreaSpacing = 0
        Me.C1DockingTab1.TabIndex = 7
        Me.C1DockingTab1.TabLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1DockingTab1.TabSizeMode = C1.Win.C1Command.TabSizeModeEnum.FillToEnd
        Me.C1DockingTab1.TabsSpacing = 5
        Me.C1DockingTab1.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2010
        Me.C1DockingTab1.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Silver
        Me.C1DockingTab1.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Silver
        '
        'C1DockingTabPage1
        '
        Me.C1DockingTabPage1.Controls.Add(Me.C1FlexGrid2)
        Me.C1DockingTabPage1.Location = New System.Drawing.Point(1, 29)
        Me.C1DockingTabPage1.Name = "C1DockingTabPage1"
        Me.C1DockingTabPage1.Size = New System.Drawing.Size(1026, 202)
        Me.C1DockingTabPage1.TabIndex = 0
        Me.C1DockingTabPage1.Text = "Apply to Delivery Receipt"
        '
        'C1FlexGrid2
        '
        Me.C1FlexGrid2.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.C1FlexGrid2.AllowFiltering = True
        Me.C1FlexGrid2.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Columns
        Me.C1FlexGrid2.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.C1FlexGrid2.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None
        Me.C1FlexGrid2.ColumnInfo = resources.GetString("C1FlexGrid2.ColumnInfo")
        Me.C1FlexGrid2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1FlexGrid2.DrawMode = C1.Win.C1FlexGrid.DrawModeEnum.OwnerDraw
        Me.C1FlexGrid2.DropMode = C1.Win.C1FlexGrid.DropModeEnum.Manual
        Me.C1FlexGrid2.EditOptions = CType((((((C1.Win.C1FlexGrid.EditFlags.AutoSearch Or C1.Win.C1FlexGrid.EditFlags.CycleOnDoubleClick) _
                    Or C1.Win.C1FlexGrid.EditFlags.MultiCheck) _
                    Or C1.Win.C1FlexGrid.EditFlags.UseNumericEditor) _
                    Or C1.Win.C1FlexGrid.EditFlags.ExitOnLeftRightKeys) _
                    Or C1.Win.C1FlexGrid.EditFlags.EditOnRequest), C1.Win.C1FlexGrid.EditFlags)
        Me.C1FlexGrid2.ExtendLastCol = True
        Me.C1FlexGrid2.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.C1FlexGrid2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.C1FlexGrid2.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.C1FlexGrid2.IgnoreDiacritics = True
        Me.C1FlexGrid2.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.C1FlexGrid2.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.C1FlexGrid2.Location = New System.Drawing.Point(0, 0)
        Me.C1FlexGrid2.Name = "C1FlexGrid2"
        Me.C1FlexGrid2.Rows.Count = 15
        Me.C1FlexGrid2.Rows.DefaultSize = 22
        Me.C1FlexGrid2.ShowCursor = True
        Me.C1FlexGrid2.Size = New System.Drawing.Size(1026, 202)
        Me.C1FlexGrid2.StyleInfo = resources.GetString("C1FlexGrid2.StyleInfo")
        Me.C1FlexGrid2.TabIndex = 84
        Me.C1FlexGrid2.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Silver
        '
        'C1DockingTabPage2
        '
        Me.C1DockingTabPage2.Controls.Add(Me.C1FlexGrid1)
        Me.C1DockingTabPage2.Controls.Add(Me.C1InputPanel4)
        Me.C1DockingTabPage2.Location = New System.Drawing.Point(1, 29)
        Me.C1DockingTabPage2.Name = "C1DockingTabPage2"
        Me.C1DockingTabPage2.Size = New System.Drawing.Size(1026, 202)
        Me.C1DockingTabPage2.TabIndex = 1
        Me.C1DockingTabPage2.Text = "Apply to Sales Invoice Items"
        '
        'C1FlexGrid1
        '
        Me.C1FlexGrid1.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.C1FlexGrid1.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Columns
        Me.C1FlexGrid1.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.C1FlexGrid1.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None
        Me.C1FlexGrid1.ColumnInfo = resources.GetString("C1FlexGrid1.ColumnInfo")
        Me.C1FlexGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1FlexGrid1.DrawMode = C1.Win.C1FlexGrid.DrawModeEnum.OwnerDraw
        Me.C1FlexGrid1.DropMode = C1.Win.C1FlexGrid.DropModeEnum.Manual
        Me.C1FlexGrid1.EditOptions = CType((((((C1.Win.C1FlexGrid.EditFlags.AutoSearch Or C1.Win.C1FlexGrid.EditFlags.CycleOnDoubleClick) _
                    Or C1.Win.C1FlexGrid.EditFlags.MultiCheck) _
                    Or C1.Win.C1FlexGrid.EditFlags.UseNumericEditor) _
                    Or C1.Win.C1FlexGrid.EditFlags.ExitOnLeftRightKeys) _
                    Or C1.Win.C1FlexGrid.EditFlags.EditOnRequest), C1.Win.C1FlexGrid.EditFlags)
        Me.C1FlexGrid1.ExtendLastCol = True
        Me.C1FlexGrid1.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.C1FlexGrid1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.C1FlexGrid1.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.C1FlexGrid1.IgnoreDiacritics = True
        Me.C1FlexGrid1.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.C1FlexGrid1.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.C1FlexGrid1.Location = New System.Drawing.Point(0, 0)
        Me.C1FlexGrid1.Name = "C1FlexGrid1"
        Me.C1FlexGrid1.Rows.Count = 15
        Me.C1FlexGrid1.Rows.DefaultSize = 22
        Me.C1FlexGrid1.ShowCursor = True
        Me.C1FlexGrid1.Size = New System.Drawing.Size(1026, 169)
        Me.C1FlexGrid1.StyleInfo = resources.GetString("C1FlexGrid1.StyleInfo")
        Me.C1FlexGrid1.TabIndex = 83
        Me.C1FlexGrid1.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Silver
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
        Me.C1InputPanel4.Location = New System.Drawing.Point(0, 169)
        Me.C1InputPanel4.Name = "C1InputPanel4"
        Me.C1InputPanel4.Padding = New System.Windows.Forms.Padding(5)
        Me.C1InputPanel4.Size = New System.Drawing.Size(1026, 33)
        Me.C1InputPanel4.TabIndex = 1
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
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.C1InputPanel2)
        Me.Panel1.Controls.Add(Me.C1InputPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 129)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1028, 243)
        Me.Panel1.TabIndex = 0
        '
        'C1InputPanel2
        '
        Me.C1InputPanel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.C1InputPanel2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1InputPanel2.Items.Add(Me.InputGroupHeader2)
        Me.C1InputPanel2.Items.Add(Me.InputLabel6)
        Me.C1InputPanel2.Items.Add(Me.CustomerName)
        Me.C1InputPanel2.Items.Add(Me.InputLabel7)
        Me.C1InputPanel2.Items.Add(Me.Address)
        Me.C1InputPanel2.Items.Add(Me.InputLabel9)
        Me.C1InputPanel2.Items.Add(Me.TIN)
        Me.C1InputPanel2.Items.Add(Me.InputLabel8)
        Me.C1InputPanel2.Items.Add(Me.BusinessType)
        Me.C1InputPanel2.Items.Add(Me.InputSeparator1)
        Me.C1InputPanel2.Items.Add(Me.InputLabel12)
        Me.C1InputPanel2.Items.Add(Me.Remarks)
        Me.C1InputPanel2.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.C1InputPanel2.Name = "C1InputPanel2"
        Me.C1InputPanel2.Padding = New System.Windows.Forms.Padding(5)
        Me.C1InputPanel2.Size = New System.Drawing.Size(644, 243)
        Me.C1InputPanel2.TabIndex = 0
        Me.C1InputPanel2.VisualStyle = C1.Win.C1InputPanel.VisualStyle.System
        '
        'InputGroupHeader2
        '
        Me.InputGroupHeader2.Height = 20
        Me.InputGroupHeader2.Name = "InputGroupHeader2"
        Me.InputGroupHeader2.Text = "Customer Details..."
        '
        'InputLabel6
        '
        Me.InputLabel6.Name = "InputLabel6"
        Me.InputLabel6.Text = "Customer:"
        Me.InputLabel6.Width = 96
        '
        'CustomerName
        '
        Me.CustomerName.Name = "CustomerName"
        Me.CustomerName.Width = 500
        '
        'InputLabel7
        '
        Me.InputLabel7.Height = 43
        Me.InputLabel7.Name = "InputLabel7"
        Me.InputLabel7.Text = "Billing Address:"
        Me.InputLabel7.Width = 96
        '
        'Address
        '
        Me.Address.Height = 41
        Me.Address.Multiline = True
        Me.Address.Name = "Address"
        Me.Address.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Spread
        Me.Address.Width = 499
        '
        'InputLabel9
        '
        Me.InputLabel9.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Near
        Me.InputLabel9.Name = "InputLabel9"
        Me.InputLabel9.Text = "Tax ID No:"
        Me.InputLabel9.Width = 96
        '
        'TIN
        '
        Me.TIN.Break = C1.Win.C1InputPanel.BreakType.None
        Me.TIN.Name = "TIN"
        Me.TIN.ReadOnly = True
        Me.TIN.Width = 194
        '
        'InputLabel8
        '
        Me.InputLabel8.Name = "InputLabel8"
        Me.InputLabel8.Text = "Bus Type:"
        Me.InputLabel8.Width = 82
        '
        'BusinessType
        '
        Me.BusinessType.Name = "BusinessType"
        Me.BusinessType.ReadOnly = True
        Me.BusinessType.Width = 216
        '
        'InputSeparator1
        '
        Me.InputSeparator1.Name = "InputSeparator1"
        Me.InputSeparator1.Width = 607
        '
        'InputLabel12
        '
        Me.InputLabel12.Name = "InputLabel12"
        Me.InputLabel12.Text = "Remarks:"
        Me.InputLabel12.Width = 96
        '
        'Remarks
        '
        Me.Remarks.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Remarks.Height = 87
        Me.Remarks.Multiline = True
        Me.Remarks.Name = "Remarks"
        Me.Remarks.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Spread
        Me.Remarks.Width = 500
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
        'InputButton1
        '
        Me.InputButton1.Break = C1.Win.C1InputPanel.BreakType.None
        Me.InputButton1.Height = 22
        Me.InputButton1.Image = CType(resources.GetObject("InputButton1.Image"), System.Drawing.Image)
        Me.InputButton1.ImageScaling = C1.Win.C1InputPanel.InputImageScaling.Stretch
        Me.InputButton1.Name = "InputButton1"
        Me.InputButton1.Width = 25
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.C1InputPanel5)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(0, 372)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1028, 37)
        Me.Panel2.TabIndex = 8
        '
        'C1InputPanel5
        '
        Me.C1InputPanel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.C1InputPanel5.BorderColor = System.Drawing.Color.Empty
        Me.C1InputPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1InputPanel5.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1InputPanel5.Items.Add(Me.InputLabel11)
        Me.C1InputPanel5.Items.Add(Me.DRNox)
        Me.C1InputPanel5.Items.Add(Me.InputLabel3)
        Me.C1InputPanel5.Items.Add(Me.PONo)
        Me.C1InputPanel5.Items.Add(Me.InputLabel10)
        Me.C1InputPanel5.Items.Add(Me.RRNo)
        Me.C1InputPanel5.Items.Add(Me.InputLabel15)
        Me.C1InputPanel5.Items.Add(Me.orno)
        Me.C1InputPanel5.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.C1InputPanel5.Name = "C1InputPanel5"
        Me.C1InputPanel5.Padding = New System.Windows.Forms.Padding(5)
        Me.C1InputPanel5.Size = New System.Drawing.Size(1028, 37)
        Me.C1InputPanel5.TabIndex = 0
        '
        'InputLabel11
        '
        Me.InputLabel11.Name = "InputLabel11"
        Me.InputLabel11.Text = "DR No:"
        Me.InputLabel11.Width = 84
        '
        'DRNox
        '
        Me.DRNox.Break = C1.Win.C1InputPanel.BreakType.None
        Me.DRNox.Multiline = True
        Me.DRNox.Name = "DRNox"
        Me.DRNox.ReadOnly = True
        Me.DRNox.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Spread
        Me.DRNox.Width = 130
        '
        'InputLabel3
        '
        Me.InputLabel3.Name = "InputLabel3"
        Me.InputLabel3.Text = "PO No:"
        Me.InputLabel3.Width = 74
        '
        'PONo
        '
        Me.PONo.Break = C1.Win.C1InputPanel.BreakType.None
        Me.PONo.Multiline = True
        Me.PONo.Name = "PONo"
        Me.PONo.ReadOnly = True
        Me.PONo.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Spread
        Me.PONo.Width = 196
        '
        'InputLabel10
        '
        Me.InputLabel10.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Near
        Me.InputLabel10.Name = "InputLabel10"
        Me.InputLabel10.Text = "RR No:"
        Me.InputLabel10.Width = 75
        '
        'RRNo
        '
        Me.RRNo.Break = C1.Win.C1InputPanel.BreakType.None
        Me.RRNo.Name = "RRNo"
        Me.RRNo.Width = 144
        '
        'InputLabel15
        '
        Me.InputLabel15.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Near
        Me.InputLabel15.Name = "InputLabel15"
        Me.InputLabel15.Text = "OR No:"
        Me.InputLabel15.Width = 75
        '
        'orno
        '
        Me.orno.Break = C1.Win.C1InputPanel.BreakType.None
        Me.orno.Name = "orno"
        Me.orno.ReadOnly = True
        Me.orno.ToolTipText = "Auto generated OR No"
        Me.orno.Width = 154
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
        Me.RibbonGroup1.Items.Add(Me.NewSalesOrder)
        Me.RibbonGroup1.Items.Add(Me.PrintCreditMemo)
        Me.RibbonGroup1.Items.Add(Me.Cancelorder)
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
        Me.SaveJobOrder.Text = "Save Sales Invoice"
        '
        'NewSalesOrder
        '
        Me.NewSalesOrder.CanBeAddedToQat = False
        Me.NewSalesOrder.LargeImage = CType(resources.GetObject("NewSalesOrder.LargeImage"), System.Drawing.Image)
        Me.NewSalesOrder.Name = "NewSalesOrder"
        Me.NewSalesOrder.SmallImage = Global.A1plus.My.Resources.Resources.new_window__1_
        Me.NewSalesOrder.SupportedGroupSizing = C1.Win.C1Ribbon.SupportedGroupSizing.LargeImageOnly
        Me.NewSalesOrder.Text = "New Sales Invoice"
        '
        'PrintCreditMemo
        '
        Me.PrintCreditMemo.CanBeAddedToQat = False
        Me.PrintCreditMemo.LargeImage = CType(resources.GetObject("PrintCreditMemo.LargeImage"), System.Drawing.Image)
        Me.PrintCreditMemo.Name = "PrintCreditMemo"
        Me.PrintCreditMemo.SmallImage = CType(resources.GetObject("PrintCreditMemo.SmallImage"), System.Drawing.Image)
        Me.PrintCreditMemo.SupportedGroupSizing = C1.Win.C1Ribbon.SupportedGroupSizing.LargeImageOnly
        Me.PrintCreditMemo.Text = "Print Invoice Report"
        '
        'Cancelorder
        '
        Me.Cancelorder.CanBeAddedToQat = False
        Me.Cancelorder.LargeImage = CType(resources.GetObject("Cancelorder.LargeImage"), System.Drawing.Image)
        Me.Cancelorder.Name = "Cancelorder"
        Me.Cancelorder.SmallImage = CType(resources.GetObject("Cancelorder.SmallImage"), System.Drawing.Image)
        Me.Cancelorder.SupportedGroupSizing = C1.Win.C1Ribbon.SupportedGroupSizing.LargeImageOnly
        Me.Cancelorder.Text = "Cancel Invoice"
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
        Me.cancelled.Location = New System.Drawing.Point(475, 37)
        Me.cancelled.Name = "cancelled"
        Me.cancelled.Size = New System.Drawing.Size(54, 25)
        Me.cancelled.TabIndex = 88
        Me.cancelled.Text = "       "
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
        Me.C1StatusBar1.Location = New System.Drawing.Point(0, 669)
        Me.C1StatusBar1.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.C1StatusBar1.Name = "C1StatusBar1"
        Me.C1StatusBar1.Size = New System.Drawing.Size(1028, 23)
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
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.C1Button1)
        Me.Panel3.Controls.Add(Me.C1SuperLabel1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 409)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1028, 28)
        Me.Panel3.TabIndex = 91
        '
        'C1Button1
        '
        Me.C1Button1.FlatAppearance.BorderSize = 0
        Me.C1Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.C1Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.C1Button1.Image = Global.A1plus.My.Resources.Resources.upload
        Me.C1Button1.Location = New System.Drawing.Point(4, 3)
        Me.C1Button1.Name = "C1Button1"
        Me.C1Button1.Size = New System.Drawing.Size(20, 22)
        Me.C1Button1.TabIndex = 81
        Me.C1Button1.UseVisualStyleBackColor = True
        '
        'C1SuperLabel1
        '
        Me.C1SuperLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.C1SuperLabel1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1SuperLabel1.Location = New System.Drawing.Point(26, 3)
        Me.C1SuperLabel1.Margin = New System.Windows.Forms.Padding(0)
        Me.C1SuperLabel1.Name = "C1SuperLabel1"
        Me.C1SuperLabel1.Size = New System.Drawing.Size(953, 22)
        Me.C1SuperLabel1.TabIndex = 80
        Me.C1SuperLabel1.Text = "<b>LIST OF ITEMS INCLUDED IN THIS SALES INVOICE<br></b>"
        Me.C1SuperLabel1.UseMnemonic = True
        '
        'salesinvoiceEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 692)
        Me.Controls.Add(Me.cancelled)
        Me.Controls.Add(Me.C1DockingTab1)
        Me.Controls.Add(Me.C1StatusBar1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.C1Ribbon1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "salesinvoiceEntry"
        Me.Text = "Sales Invoice Entry"
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1DockingTab1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1DockingTab1.ResumeLayout(False)
        Me.C1DockingTabPage1.ResumeLayout(False)
        CType(Me.C1FlexGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1DockingTabPage2.ResumeLayout(False)
        CType(Me.C1FlexGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.C1InputPanel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Ribbon1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1StatusBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.C1Button1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputLabel1 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents SINo As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel2 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents SIDate As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents C1DockingTab1 As C1.Win.C1Command.C1DockingTab
    Friend WithEvents C1DockingTabPage1 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents C1DockingTabPage2 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents InputSeparator2 As C1.Win.C1InputPanel.InputSeparator
    Friend WithEvents InputLabel4 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel5 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputTextBox1 As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputButton1 As C1.Win.C1InputPanel.InputButton
    Friend WithEvents C1InputPanel2 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader2 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputLabel6 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents CustomerName As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents InputLabel7 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel8 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents BusinessType As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel9 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents TIN As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputSeparator1 As C1.Win.C1InputPanel.InputSeparator
    Friend WithEvents InputLabel12 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents Remarks As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents C1InputPanel4 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputLabel18 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents GrossAmount As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel19 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents VATAmount As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel20 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents NetSalesAmount As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents CreditTerms As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents Address As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel13 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents DueDate As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents InputLabel14 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents SIAmount As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents Paid As C1.Win.C1InputPanel.InputCheckBox
    Friend WithEvents C1InputPanel5 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputLabel11 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents DRNox As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel3 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents PONo As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel10 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents RRNo As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel15 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents orno As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents VATIn As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents VATEx As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents InputLabel16 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel17 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents Currency As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents InputOption1 As C1.Win.C1InputPanel.InputOption
    Friend WithEvents InputOption2 As C1.Win.C1InputPanel.InputOption
    Friend WithEvents C1Ribbon1 As C1.Win.C1Ribbon.C1Ribbon
    Public WithEvents RibbonApplicationMenu1 As C1.Win.C1Ribbon.RibbonApplicationMenu
    Friend WithEvents RibbonConfigToolBar1 As C1.Win.C1Ribbon.RibbonConfigToolBar
    Public WithEvents RibbonQat1 As C1.Win.C1Ribbon.RibbonQat
    Public WithEvents ModuleControlTab As C1.Win.C1Ribbon.RibbonTab
    Friend WithEvents RibbonGroup1 As C1.Win.C1Ribbon.RibbonGroup
    Friend WithEvents SaveJobOrder As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents NewSalesOrder As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents CloseForm As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents CancelSOButton As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents RibbonGroup2 As C1.Win.C1Ribbon.RibbonGroup
    Friend WithEvents RibbonToolBar2 As C1.Win.C1Ribbon.RibbonToolBar
    Friend WithEvents FontName As C1.Win.C1Ribbon.RibbonFontComboBox
    Friend WithEvents FontSize As C1.Win.C1Ribbon.RibbonNumericBox
    Friend WithEvents RibbonToolBar1 As C1.Win.C1Ribbon.RibbonToolBar
    Friend WithEvents RibbonButton5 As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents RibbonButton3 As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents PrintCreditMemo As C1.Win.C1Ribbon.RibbonButton
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
    Friend WithEvents Cancelorder As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents C1Button1 As C1.Win.C1Input.C1Button
    Friend WithEvents C1SuperLabel1 As C1.Win.C1SuperTooltip.C1SuperLabel
    Friend WithEvents C1FlexGrid2 As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents C1FlexGrid1 As C1.Win.C1FlexGrid.C1FlexGrid
End Class
