<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CompanyAllowanceSetUp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CompanyAllowanceSetUp))
        Me.C1flexgrid1 = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1CommandHolder1 = New C1.Win.C1Command.C1CommandHolder()
        Me.C1ContextMenu1 = New C1.Win.C1Command.C1ContextMenu()
        Me.DeleteRecordButton = New C1.Win.C1Command.C1CommandLink()
        Me.SODeleteMenu = New C1.Win.C1Command.C1Command()
        Me.ViewRecordButton = New C1.Win.C1Command.C1CommandLink()
        Me.SOViewRecord = New C1.Win.C1Command.C1Command()
        Me.RefreshMenu = New C1.Win.C1Command.C1CommandLink()
        Me.SoRefresh = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink2 = New C1.Win.C1Command.C1CommandLink()
        Me.ExportMenu = New C1.Win.C1Command.C1CommandMenu()
        Me.ExportCurrentButton = New C1.Win.C1Command.C1CommandLink()
        Me.SOExportCurrent = New C1.Win.C1Command.C1Command()
        Me.ExportAllButton = New C1.Win.C1Command.C1CommandLink()
        Me.SOExportAll = New C1.Win.C1Command.C1Command()
        Me.SOAddMenu = New C1.Win.C1Command.C1Command()
        Me.SOEditMenu = New C1.Win.C1Command.C1CommandControl()
        Me.SOShowAll = New C1.Win.C1Command.C1Command()
        Me.C1Command8 = New C1.Win.C1Command.C1CommandMenu()
        Me.PrintCurrentMenu = New C1.Win.C1Command.C1CommandLink()
        Me.SOPrintCurrent = New C1.Win.C1Command.C1Command()
        Me.PrintAllMenu = New C1.Win.C1Command.C1CommandLink()
        Me.SOPrintAll = New C1.Win.C1Command.C1Command()
        Me.C1Command1 = New C1.Win.C1Command.C1CommandMenu()
        Me.C1Command10 = New C1.Win.C1Command.C1CommandMenu()
        Me.ExportCurrentMenu = New C1.Win.C1Command.C1CommandLink()
        Me.ExportAllMenu = New C1.Win.C1Command.C1CommandLink()
        Me.C1InputPanel2 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader2 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel1 = New C1.Win.C1InputPanel.InputLabel()
        Me.CompanyName = New C1.Win.C1InputPanel.InputComboBox()
        Me.Load = New C1.Win.C1InputPanel.InputButton()
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.C1Ribbon1 = New C1.Win.C1Ribbon.C1Ribbon()
        Me.RibbonApplicationMenu1 = New C1.Win.C1Ribbon.RibbonApplicationMenu()
        Me.RibbonConfigToolBar1 = New C1.Win.C1Ribbon.RibbonConfigToolBar()
        Me.RibbonQat1 = New C1.Win.C1Ribbon.RibbonQat()
        Me.ModuleControlTab = New C1.Win.C1Ribbon.RibbonTab()
        Me.RibbonGroup1 = New C1.Win.C1Ribbon.RibbonGroup()
        Me.SaveJobOrder = New C1.Win.C1Ribbon.RibbonButton()
        Me.NewSalesOrder = New C1.Win.C1Ribbon.RibbonButton()
        Me.PrintCreditMemo = New C1.Win.C1Ribbon.RibbonButton()
        Me.CloseForm = New C1.Win.C1Ribbon.RibbonButton()
        Me.CancelSOButton = New C1.Win.C1Ribbon.RibbonButton()
        Me.RibbonOrderListOfItems = New C1.Win.C1Ribbon.RibbonGroup()
        Me.SetNumberOfRows = New C1.Win.C1Ribbon.RibbonButton()
        Me.InsertRowButton = New C1.Win.C1Ribbon.RibbonButton()
        Me.DeleteRowButton = New C1.Win.C1Ribbon.RibbonButton()
        Me.ClearContentsButton = New C1.Win.C1Ribbon.RibbonButton()
        Me.RibbonGroup2 = New C1.Win.C1Ribbon.RibbonGroup()
        Me.RibbonToolBar2 = New C1.Win.C1Ribbon.RibbonToolBar()
        Me.FontName = New C1.Win.C1Ribbon.RibbonFontComboBox()
        Me.FontSize = New C1.Win.C1Ribbon.RibbonNumericBox()
        Me.RibbonToolBar1 = New C1.Win.C1Ribbon.RibbonToolBar()
        Me.RibbonButton5 = New C1.Win.C1Ribbon.RibbonButton()
        Me.RibbonButton3 = New C1.Win.C1Ribbon.RibbonButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        CType(Me.C1flexgrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Ribbon1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1flexgrid1
        '
        Me.C1flexgrid1.AllowAddNew = True
        Me.C1flexgrid1.AllowDelete = True
        Me.C1flexgrid1.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Columns
        Me.C1flexgrid1.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.C1flexgrid1.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.C1flexgrid1.AutoSearch = C1.Win.C1FlexGrid.AutoSearchEnum.FromTop
        Me.C1flexgrid1.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None
        Me.C1CommandHolder1.SetC1ContextMenu(Me.C1flexgrid1, Me.C1ContextMenu1)
        Me.C1flexgrid1.ColumnInfo = resources.GetString("C1flexgrid1.ColumnInfo")
        Me.C1flexgrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1flexgrid1.ExtendLastCol = True
        Me.C1flexgrid1.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.C1flexgrid1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.C1flexgrid1.IgnoreDiacritics = True
        Me.C1flexgrid1.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.None
        Me.C1flexgrid1.Location = New System.Drawing.Point(0, 227)
        Me.C1flexgrid1.Margin = New System.Windows.Forms.Padding(2)
        Me.C1flexgrid1.Name = "C1flexgrid1"
        Me.C1flexgrid1.Rows.Count = 20
        Me.C1flexgrid1.Rows.DefaultSize = 19
        Me.C1flexgrid1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.C1flexgrid1.ScrollOptions = CType(((C1.Win.C1FlexGrid.ScrollFlags.AlwaysVisible Or C1.Win.C1FlexGrid.ScrollFlags.ScrollByRowColumn) _
                    Or C1.Win.C1FlexGrid.ScrollFlags.ShowScrollTips), C1.Win.C1FlexGrid.ScrollFlags)
        Me.C1flexgrid1.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.C1flexgrid1.Size = New System.Drawing.Size(781, 352)
        Me.C1flexgrid1.StyleInfo = resources.GetString("C1flexgrid1.StyleInfo")
        Me.C1flexgrid1.TabIndex = 59
        Me.C1flexgrid1.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Silver
        '
        'C1CommandHolder1
        '
        Me.C1CommandHolder1.Commands.Add(Me.C1ContextMenu1)
        Me.C1CommandHolder1.Commands.Add(Me.SODeleteMenu)
        Me.C1CommandHolder1.Commands.Add(Me.SOViewRecord)
        Me.C1CommandHolder1.Commands.Add(Me.SoRefresh)
        Me.C1CommandHolder1.Commands.Add(Me.ExportMenu)
        Me.C1CommandHolder1.Commands.Add(Me.SOExportCurrent)
        Me.C1CommandHolder1.Commands.Add(Me.SOExportAll)
        Me.C1CommandHolder1.Commands.Add(Me.SOAddMenu)
        Me.C1CommandHolder1.Commands.Add(Me.SOEditMenu)
        Me.C1CommandHolder1.Commands.Add(Me.SOShowAll)
        Me.C1CommandHolder1.Commands.Add(Me.C1Command8)
        Me.C1CommandHolder1.Commands.Add(Me.SOPrintCurrent)
        Me.C1CommandHolder1.Commands.Add(Me.SOPrintAll)
        Me.C1CommandHolder1.Commands.Add(Me.C1Command1)
        Me.C1CommandHolder1.Commands.Add(Me.C1Command10)
        Me.C1CommandHolder1.Owner = Me
        '
        'C1ContextMenu1
        '
        Me.C1ContextMenu1.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.DeleteRecordButton, Me.ViewRecordButton, Me.RefreshMenu, Me.C1CommandLink2})
        Me.C1ContextMenu1.DropDown = True
        Me.C1ContextMenu1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1ContextMenu1.LargeMenuDisplay = C1.Win.C1Command.LargeMenuDisplayEnum.Scroll
        Me.C1ContextMenu1.Name = "C1ContextMenu1"
        Me.C1ContextMenu1.ShortcutText = ""
        Me.C1ContextMenu1.SideCaption.BarGradientBegin = System.Drawing.SystemColors.Control
        Me.C1ContextMenu1.SideCaption.Width = 1
        Me.C1ContextMenu1.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Black
        Me.C1ContextMenu1.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Black
        '
        'DeleteRecordButton
        '
        Me.DeleteRecordButton.Command = Me.SODeleteMenu
        Me.DeleteRecordButton.Text = "&Delete Selected"
        '
        'SODeleteMenu
        '
        Me.SODeleteMenu.Image = Global.A1plus.My.Resources.Resources.notebook_delete3
        Me.SODeleteMenu.Name = "SODeleteMenu"
        Me.SODeleteMenu.ShortcutText = ""
        Me.SODeleteMenu.Text = "New Command"
        '
        'ViewRecordButton
        '
        Me.ViewRecordButton.Command = Me.SOViewRecord
        Me.ViewRecordButton.SortOrder = 1
        '
        'SOViewRecord
        '
        Me.SOViewRecord.Image = Global.A1plus.My.Resources.Resources.notebook_information1
        Me.SOViewRecord.Name = "SOViewRecord"
        Me.SOViewRecord.ShortcutText = ""
        Me.SOViewRecord.Text = "&View Record History"
        '
        'RefreshMenu
        '
        Me.RefreshMenu.Command = Me.SoRefresh
        Me.RefreshMenu.DefaultItem = True
        Me.RefreshMenu.Delimiter = True
        Me.RefreshMenu.SortOrder = 2
        Me.RefreshMenu.Text = "&Refresh"
        '
        'SoRefresh
        '
        Me.SoRefresh.Image = Global.A1plus.My.Resources.Resources.reload__1_
        Me.SoRefresh.Name = "SoRefresh"
        Me.SoRefresh.ShortcutText = ""
        Me.SoRefresh.Text = "Refresh List"
        '
        'C1CommandLink2
        '
        Me.C1CommandLink2.Command = Me.ExportMenu
        Me.C1CommandLink2.Delimiter = True
        Me.C1CommandLink2.SortOrder = 3
        '
        'ExportMenu
        '
        Me.ExportMenu.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.ExportCurrentButton, Me.ExportAllButton})
        Me.ExportMenu.Image = Global.A1plus.My.Resources.Resources.export__1_
        Me.ExportMenu.Name = "ExportMenu"
        Me.ExportMenu.ShortcutText = ""
        Me.ExportMenu.Text = "Exp&ort Records"
        '
        'ExportCurrentButton
        '
        Me.ExportCurrentButton.Command = Me.SOExportCurrent
        Me.ExportCurrentButton.Text = "&Current View"
        '
        'SOExportCurrent
        '
        Me.SOExportCurrent.Name = "SOExportCurrent"
        Me.SOExportCurrent.ShortcutText = ""
        Me.SOExportCurrent.Text = "New Command"
        '
        'ExportAllButton
        '
        Me.ExportAllButton.Command = Me.SOExportAll
        Me.ExportAllButton.SortOrder = 1
        '
        'SOExportAll
        '
        Me.SOExportAll.Name = "SOExportAll"
        Me.SOExportAll.ShortcutText = ""
        Me.SOExportAll.Text = "&All Records"
        '
        'SOAddMenu
        '
        Me.SOAddMenu.Image = Global.A1plus.My.Resources.Resources.notebook_add2
        Me.SOAddMenu.Name = "SOAddMenu"
        Me.SOAddMenu.ShortcutText = ""
        Me.SOAddMenu.Text = "New Command"
        '
        'SOEditMenu
        '
        Me.SOEditMenu.Image = Global.A1plus.My.Resources.Resources.notebook_edit
        Me.SOEditMenu.Name = "SOEditMenu"
        Me.SOEditMenu.ShortcutText = ""
        Me.SOEditMenu.Text = "Edit Selected Record"
        '
        'SOShowAll
        '
        Me.SOShowAll.Image = Global.A1plus.My.Resources.Resources.books__1_
        Me.SOShowAll.Name = "SOShowAll"
        Me.SOShowAll.ShortcutText = ""
        Me.SOShowAll.Text = "Show All Records"
        '
        'C1Command8
        '
        Me.C1Command8.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.PrintCurrentMenu, Me.PrintAllMenu})
        Me.C1Command8.DropDown = True
        Me.C1Command8.Image = Global.A1plus.My.Resources.Resources.printer_go
        Me.C1Command8.Name = "C1Command8"
        Me.C1Command8.ShortcutText = ""
        Me.C1Command8.Text = "New Command"
        '
        'PrintCurrentMenu
        '
        Me.PrintCurrentMenu.ButtonLook = C1.Win.C1Command.ButtonLookFlags.Text
        Me.PrintCurrentMenu.Command = Me.SOPrintCurrent
        Me.PrintCurrentMenu.Text = "&Current View"
        '
        'SOPrintCurrent
        '
        Me.SOPrintCurrent.Name = "SOPrintCurrent"
        Me.SOPrintCurrent.ShortcutText = ""
        Me.SOPrintCurrent.Text = "New Command"
        '
        'PrintAllMenu
        '
        Me.PrintAllMenu.ButtonLook = C1.Win.C1Command.ButtonLookFlags.Text
        Me.PrintAllMenu.Command = Me.SOPrintAll
        Me.PrintAllMenu.SortOrder = 1
        Me.PrintAllMenu.Text = "&All Records"
        '
        'SOPrintAll
        '
        Me.SOPrintAll.Name = "SOPrintAll"
        Me.SOPrintAll.ShortcutText = ""
        Me.SOPrintAll.Text = "New Command"
        '
        'C1Command1
        '
        Me.C1Command1.CloseOnItemClick = False
        Me.C1Command1.Image = Global.A1plus.My.Resources.Resources.mark_as_read
        Me.C1Command1.Name = "C1Command1"
        Me.C1Command1.ShortcutText = ""
        Me.C1Command1.Text = "&Visible Columns"
        Me.C1Command1.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Black
        '
        'C1Command10
        '
        Me.C1Command10.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.ExportCurrentMenu, Me.ExportAllMenu})
        Me.C1Command10.LargeMenuDisplay = C1.Win.C1Command.LargeMenuDisplayEnum.Scroll
        Me.C1Command10.Name = "C1Command10"
        Me.C1Command10.ShortcutText = ""
        Me.C1Command10.SideCaption.Width = 1
        Me.C1Command10.Text = "New Command"
        Me.C1Command10.VisualStyle = C1.Win.C1Command.VisualStyle.Custom
        Me.C1Command10.VisualStyleBase = C1.Win.C1Command.VisualStyle.System
        Me.C1Command10.Width = 13333
        '
        'ExportCurrentMenu
        '
        Me.ExportCurrentMenu.ButtonLook = C1.Win.C1Command.ButtonLookFlags.Text
        Me.ExportCurrentMenu.OwnerDraw = True
        Me.ExportCurrentMenu.Text = "&Current View"
        '
        'ExportAllMenu
        '
        Me.ExportAllMenu.ButtonLook = C1.Win.C1Command.ButtonLookFlags.Text
        Me.ExportAllMenu.OwnerDraw = True
        Me.ExportAllMenu.SortOrder = 1
        Me.ExportAllMenu.Text = "&All Records"
        '
        'C1InputPanel2
        '
        Me.C1InputPanel2.BorderThickness = 1
        Me.C1InputPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1InputPanel2.Items.Add(Me.InputGroupHeader2)
        Me.C1InputPanel2.Items.Add(Me.InputLabel1)
        Me.C1InputPanel2.Items.Add(Me.CompanyName)
        Me.C1InputPanel2.Items.Add(Me.Load)
        Me.C1InputPanel2.Items.Add(Me.InputGroupHeader1)
        Me.C1InputPanel2.Location = New System.Drawing.Point(0, 129)
        Me.C1InputPanel2.Name = "C1InputPanel2"
        Me.C1InputPanel2.Padding = New System.Windows.Forms.Padding(5)
        Me.C1InputPanel2.Size = New System.Drawing.Size(781, 98)
        Me.C1InputPanel2.TabIndex = 58
        '
        'InputGroupHeader2
        '
        Me.InputGroupHeader2.Height = 25
        Me.InputGroupHeader2.Name = "InputGroupHeader2"
        Me.InputGroupHeader2.Text = "Select Company:"
        '
        'InputLabel1
        '
        Me.InputLabel1.Name = "InputLabel1"
        Me.InputLabel1.Text = "Company"
        Me.InputLabel1.Width = 72
        '
        'CompanyName
        '
        Me.CompanyName.Break = C1.Win.C1InputPanel.BreakType.None
        Me.CompanyName.Name = "CompanyName"
        Me.CompanyName.Width = 389
        '
        'Load
        '
        Me.Load.Image = Global.A1plus.My.Resources.Resources.check__1_
        Me.Load.Name = "Load"
        Me.Load.Text = "Select"
        Me.Load.Width = 80
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        Me.InputGroupHeader1.Text = "Allowance Details.."
        '
        'C1Ribbon1
        '
        Me.C1Ribbon1.ApplicationMenuHolder = Me.RibbonApplicationMenu1
        Me.C1Ribbon1.ConfigToolBarHolder = Me.RibbonConfigToolBar1
        Me.C1Ribbon1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1Ribbon1.Location = New System.Drawing.Point(0, 0)
        Me.C1Ribbon1.Name = "C1Ribbon1"
        Me.C1Ribbon1.QatHolder = Me.RibbonQat1
        Me.C1Ribbon1.Size = New System.Drawing.Size(781, 129)
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
        Me.ModuleControlTab.Groups.Add(Me.RibbonOrderListOfItems)
        Me.ModuleControlTab.Groups.Add(Me.RibbonGroup2)
        Me.ModuleControlTab.Name = "ModuleControlTab"
        Me.ModuleControlTab.Text = "Module Controls"
        '
        'RibbonGroup1
        '
        Me.RibbonGroup1.Items.Add(Me.SaveJobOrder)
        Me.RibbonGroup1.Items.Add(Me.NewSalesOrder)
        Me.RibbonGroup1.Items.Add(Me.PrintCreditMemo)
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
        Me.SaveJobOrder.Text = "Save Order"
        '
        'NewSalesOrder
        '
        Me.NewSalesOrder.CanBeAddedToQat = False
        Me.NewSalesOrder.LargeImage = CType(resources.GetObject("NewSalesOrder.LargeImage"), System.Drawing.Image)
        Me.NewSalesOrder.Name = "NewSalesOrder"
        Me.NewSalesOrder.SmallImage = Global.A1plus.My.Resources.Resources.new_window__1_
        Me.NewSalesOrder.SupportedGroupSizing = C1.Win.C1Ribbon.SupportedGroupSizing.LargeImageOnly
        Me.NewSalesOrder.Text = "New Setup"
        '
        'PrintCreditMemo
        '
        Me.PrintCreditMemo.CanBeAddedToQat = False
        Me.PrintCreditMemo.LargeImage = CType(resources.GetObject("PrintCreditMemo.LargeImage"), System.Drawing.Image)
        Me.PrintCreditMemo.Name = "PrintCreditMemo"
        Me.PrintCreditMemo.SmallImage = CType(resources.GetObject("PrintCreditMemo.SmallImage"), System.Drawing.Image)
        Me.PrintCreditMemo.SupportedGroupSizing = C1.Win.C1Ribbon.SupportedGroupSizing.LargeImageOnly
        Me.PrintCreditMemo.Text = "Print Allowance"
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
        'RibbonOrderListOfItems
        '
        Me.RibbonOrderListOfItems.Enabled = False
        Me.RibbonOrderListOfItems.Items.Add(Me.SetNumberOfRows)
        Me.RibbonOrderListOfItems.Items.Add(Me.InsertRowButton)
        Me.RibbonOrderListOfItems.Items.Add(Me.DeleteRowButton)
        Me.RibbonOrderListOfItems.Items.Add(Me.ClearContentsButton)
        Me.RibbonOrderListOfItems.Name = "RibbonOrderListOfItems"
        Me.RibbonOrderListOfItems.Text = "Grid and Item List Controls"
        '
        'SetNumberOfRows
        '
        Me.SetNumberOfRows.CanBeAddedToQat = False
        Me.SetNumberOfRows.LargeImage = CType(resources.GetObject("SetNumberOfRows.LargeImage"), System.Drawing.Image)
        Me.SetNumberOfRows.Name = "SetNumberOfRows"
        Me.SetNumberOfRows.SmallImage = CType(resources.GetObject("SetNumberOfRows.SmallImage"), System.Drawing.Image)
        Me.SetNumberOfRows.Text = "Set No. of Rows"
        '
        'InsertRowButton
        '
        Me.InsertRowButton.CanBeAddedToQat = False
        Me.InsertRowButton.LargeImage = CType(resources.GetObject("InsertRowButton.LargeImage"), System.Drawing.Image)
        Me.InsertRowButton.Name = "InsertRowButton"
        Me.InsertRowButton.SmallImage = CType(resources.GetObject("InsertRowButton.SmallImage"), System.Drawing.Image)
        Me.InsertRowButton.Text = "Insert Row"
        '
        'DeleteRowButton
        '
        Me.DeleteRowButton.CanBeAddedToQat = False
        Me.DeleteRowButton.LargeImage = CType(resources.GetObject("DeleteRowButton.LargeImage"), System.Drawing.Image)
        Me.DeleteRowButton.Name = "DeleteRowButton"
        Me.DeleteRowButton.SmallImage = CType(resources.GetObject("DeleteRowButton.SmallImage"), System.Drawing.Image)
        Me.DeleteRowButton.Text = "Delete Row"
        '
        'ClearContentsButton
        '
        Me.ClearContentsButton.CanBeAddedToQat = False
        Me.ClearContentsButton.LargeImage = CType(resources.GetObject("ClearContentsButton.LargeImage"), System.Drawing.Image)
        Me.ClearContentsButton.Name = "ClearContentsButton"
        Me.ClearContentsButton.SmallImage = CType(resources.GetObject("ClearContentsButton.SmallImage"), System.Drawing.Image)
        Me.ClearContentsButton.Text = "Clear Contents"
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
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 579)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(781, 25)
        Me.ToolStrip1.TabIndex = 61
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'CompanyAllowanceSetUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(781, 604)
        Me.Controls.Add(Me.C1flexgrid1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.C1InputPanel2)
        Me.Controls.Add(Me.C1Ribbon1)
        Me.Name = "CompanyAllowanceSetUp"
        Me.Text = "Company Allowance SetUp"
        CType(Me.C1flexgrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Ribbon1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents C1flexgrid1 As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents C1CommandHolder1 As C1.Win.C1Command.C1CommandHolder
    Private WithEvents C1ContextMenu1 As C1.Win.C1Command.C1ContextMenu
    Friend WithEvents DeleteRecordButton As C1.Win.C1Command.C1CommandLink
    Friend WithEvents SODeleteMenu As C1.Win.C1Command.C1Command
    Friend WithEvents ViewRecordButton As C1.Win.C1Command.C1CommandLink
    Friend WithEvents SOViewRecord As C1.Win.C1Command.C1Command
    Friend WithEvents RefreshMenu As C1.Win.C1Command.C1CommandLink
    Friend WithEvents SoRefresh As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink2 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents ExportMenu As C1.Win.C1Command.C1CommandMenu
    Friend WithEvents ExportCurrentButton As C1.Win.C1Command.C1CommandLink
    Friend WithEvents SOExportCurrent As C1.Win.C1Command.C1Command
    Friend WithEvents ExportAllButton As C1.Win.C1Command.C1CommandLink
    Friend WithEvents SOExportAll As C1.Win.C1Command.C1Command
    Friend WithEvents SOAddMenu As C1.Win.C1Command.C1Command
    Friend WithEvents SOEditMenu As C1.Win.C1Command.C1CommandControl
    Private WithEvents SOShowAll As C1.Win.C1Command.C1Command
    Private WithEvents C1Command8 As C1.Win.C1Command.C1CommandMenu
    Friend WithEvents PrintCurrentMenu As C1.Win.C1Command.C1CommandLink
    Private WithEvents SOPrintCurrent As C1.Win.C1Command.C1Command
    Friend WithEvents PrintAllMenu As C1.Win.C1Command.C1CommandLink
    Private WithEvents SOPrintAll As C1.Win.C1Command.C1Command
    Private WithEvents C1Command1 As C1.Win.C1Command.C1CommandMenu
    Private WithEvents C1Command10 As C1.Win.C1Command.C1CommandMenu
    Friend WithEvents ExportCurrentMenu As C1.Win.C1Command.C1CommandLink
    Friend WithEvents ExportAllMenu As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1InputPanel2 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader2 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputLabel1 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents CompanyName As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents Load As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents C1Ribbon1 As C1.Win.C1Ribbon.C1Ribbon
    Public WithEvents RibbonApplicationMenu1 As C1.Win.C1Ribbon.RibbonApplicationMenu
    Friend WithEvents RibbonConfigToolBar1 As C1.Win.C1Ribbon.RibbonConfigToolBar
    Public WithEvents RibbonQat1 As C1.Win.C1Ribbon.RibbonQat
    Public WithEvents ModuleControlTab As C1.Win.C1Ribbon.RibbonTab
    Friend WithEvents RibbonGroup1 As C1.Win.C1Ribbon.RibbonGroup
    Friend WithEvents SaveJobOrder As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents NewSalesOrder As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents PrintCreditMemo As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents CloseForm As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents CancelSOButton As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents RibbonOrderListOfItems As C1.Win.C1Ribbon.RibbonGroup
    Friend WithEvents SetNumberOfRows As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents InsertRowButton As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents DeleteRowButton As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents ClearContentsButton As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents RibbonGroup2 As C1.Win.C1Ribbon.RibbonGroup
    Friend WithEvents RibbonToolBar2 As C1.Win.C1Ribbon.RibbonToolBar
    Friend WithEvents FontName As C1.Win.C1Ribbon.RibbonFontComboBox
    Friend WithEvents FontSize As C1.Win.C1Ribbon.RibbonNumericBox
    Friend WithEvents RibbonToolBar1 As C1.Win.C1Ribbon.RibbonToolBar
    Friend WithEvents RibbonButton5 As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents RibbonButton3 As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
End Class
