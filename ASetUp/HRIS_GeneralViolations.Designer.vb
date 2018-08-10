<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HRIS_GeneralViolation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HRIS_GeneralViolation))
        Me.C1InputPanel3 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputLabel2 = New C1.Win.C1InputPanel.InputLabel()
        Me.Searchfield = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputButton12 = New C1.Win.C1InputPanel.InputButton()
        Me.SearchClear = New C1.Win.C1InputPanel.InputButton()
        Me.C1InputPanel2 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader2 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel1 = New C1.Win.C1InputPanel.InputLabel()
        Me.GeneralViolation = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel4 = New C1.Win.C1InputPanel.InputLabel()
        Me.Description = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel5 = New C1.Win.C1InputPanel.InputLabel()
        Me.Status = New C1.Win.C1InputPanel.InputCheckBox()
        Me.InputSeparator2 = New C1.Win.C1InputPanel.InputSeparator()
        Me.SaveRecord = New C1.Win.C1InputPanel.InputButton()
        Me.Clear = New C1.Win.C1InputPanel.InputButton()
        Me.C1ContextMenu1 = New C1.Win.C1Command.C1ContextMenu()
        Me.AddNewRecordButton = New C1.Win.C1Command.C1CommandLink()
        Me.SOAddMenu = New C1.Win.C1Command.C1Command()
        Me.EditRecordButton = New C1.Win.C1Command.C1CommandLink()
        Me.SOEditMenu = New C1.Win.C1Command.C1CommandControl()
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
        Me.C1CommandHolder1 = New C1.Win.C1Command.C1CommandHolder()
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
        Me.C1flexgrid1 = New C1.Win.C1FlexGrid.C1FlexGrid()
        CType(Me.C1InputPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1flexgrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel3
        '
        Me.C1InputPanel3.BorderThickness = 1
        Me.C1InputPanel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.C1InputPanel3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1InputPanel3.GroupIndent = 1
        Me.C1InputPanel3.Items.Add(Me.InputLabel2)
        Me.C1InputPanel3.Items.Add(Me.Searchfield)
        Me.C1InputPanel3.Items.Add(Me.InputButton12)
        Me.C1InputPanel3.Items.Add(Me.SearchClear)
        Me.C1InputPanel3.Location = New System.Drawing.Point(0, 372)
        Me.C1InputPanel3.Margin = New System.Windows.Forms.Padding(0)
        Me.C1InputPanel3.Name = "C1InputPanel3"
        Me.C1InputPanel3.Padding = New System.Windows.Forms.Padding(5)
        Me.C1InputPanel3.Size = New System.Drawing.Size(650, 42)
        Me.C1InputPanel3.TabIndex = 54
        '
        'InputLabel2
        '
        Me.InputLabel2.Name = "InputLabel2"
        Me.InputLabel2.Text = "Search Field"
        Me.InputLabel2.Width = 87
        '
        'Searchfield
        '
        Me.Searchfield.Break = C1.Win.C1InputPanel.BreakType.None
        Me.Searchfield.Height = 28
        Me.Searchfield.Name = "Searchfield"
        Me.Searchfield.Width = 339
        '
        'InputButton12
        '
        Me.InputButton12.Break = C1.Win.C1InputPanel.BreakType.None
        Me.InputButton12.Image = Global.A1plus.My.Resources.Resources.search123
        Me.InputButton12.Name = "InputButton12"
        '
        'SearchClear
        '
        Me.SearchClear.Image = Global.A1plus.My.Resources.Resources.gnome_edit_clear
        Me.SearchClear.Name = "SearchClear"
        '
        'C1InputPanel2
        '
        Me.C1InputPanel2.BorderThickness = 1
        Me.C1InputPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1InputPanel2.Items.Add(Me.InputGroupHeader2)
        Me.C1InputPanel2.Items.Add(Me.InputLabel1)
        Me.C1InputPanel2.Items.Add(Me.GeneralViolation)
        Me.C1InputPanel2.Items.Add(Me.InputLabel4)
        Me.C1InputPanel2.Items.Add(Me.Description)
        Me.C1InputPanel2.Items.Add(Me.InputLabel5)
        Me.C1InputPanel2.Items.Add(Me.Status)
        Me.C1InputPanel2.Items.Add(Me.InputSeparator2)
        Me.C1InputPanel2.Items.Add(Me.SaveRecord)
        Me.C1InputPanel2.Items.Add(Me.Clear)
        Me.C1InputPanel2.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel2.Name = "C1InputPanel2"
        Me.C1InputPanel2.Padding = New System.Windows.Forms.Padding(5)
        Me.C1InputPanel2.Size = New System.Drawing.Size(650, 180)
        Me.C1InputPanel2.TabIndex = 53
        '
        'InputGroupHeader2
        '
        Me.InputGroupHeader2.Height = 32
        Me.InputGroupHeader2.Name = "InputGroupHeader2"
        Me.InputGroupHeader2.Text = "General Violation SetUp"
        '
        'InputLabel1
        '
        Me.InputLabel1.Name = "InputLabel1"
        Me.InputLabel1.Text = "General Violation"
        Me.InputLabel1.Width = 122
        '
        'GeneralViolation
        '
        Me.GeneralViolation.Name = "GeneralViolation"
        Me.GeneralViolation.Width = 332
        '
        'InputLabel4
        '
        Me.InputLabel4.Name = "InputLabel4"
        Me.InputLabel4.Text = "Description"
        Me.InputLabel4.Width = 122
        '
        'Description
        '
        Me.Description.Height = 47
        Me.Description.Multiline = True
        Me.Description.Name = "Description"
        Me.Description.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Spread
        Me.Description.Width = 332
        '
        'InputLabel5
        '
        Me.InputLabel5.Name = "InputLabel5"
        Me.InputLabel5.Text = "Status"
        Me.InputLabel5.Width = 120
        '
        'Status
        '
        Me.Status.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Status.Name = "Status"
        Me.Status.Text = "Active"
        '
        'InputSeparator2
        '
        Me.InputSeparator2.Name = "InputSeparator2"
        Me.InputSeparator2.Width = 458
        '
        'SaveRecord
        '
        Me.SaveRecord.Break = C1.Win.C1InputPanel.BreakType.None
        Me.SaveRecord.Image = CType(resources.GetObject("SaveRecord.Image"), System.Drawing.Image)
        Me.SaveRecord.Name = "SaveRecord"
        Me.SaveRecord.Text = "&Save Record"
        '
        'Clear
        '
        Me.Clear.Break = C1.Win.C1InputPanel.BreakType.None
        Me.Clear.Image = Global.A1plus.My.Resources.Resources.document_edit1
        Me.Clear.Name = "Clear"
        Me.Clear.Text = "&Clear Record"
        '
        'C1ContextMenu1
        '
        Me.C1ContextMenu1.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.AddNewRecordButton, Me.EditRecordButton, Me.DeleteRecordButton, Me.ViewRecordButton, Me.RefreshMenu, Me.C1CommandLink2})
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
        'AddNewRecordButton
        '
        Me.AddNewRecordButton.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.AddNewRecordButton.Command = Me.SOAddMenu
        Me.AddNewRecordButton.DefaultItem = True
        Me.AddNewRecordButton.Text = "&Add New Record"
        '
        'SOAddMenu
        '
        Me.SOAddMenu.Image = Global.A1plus.My.Resources.Resources.notebook_add2
        Me.SOAddMenu.Name = "SOAddMenu"
        Me.SOAddMenu.ShortcutText = ""
        Me.SOAddMenu.Text = "New Command"
        '
        'EditRecordButton
        '
        Me.EditRecordButton.Command = Me.SOEditMenu
        Me.EditRecordButton.SortOrder = 1
        Me.EditRecordButton.Text = "&Edit Selected"
        '
        'SOEditMenu
        '
        Me.SOEditMenu.Image = Global.A1plus.My.Resources.Resources.notebook_edit
        Me.SOEditMenu.Name = "SOEditMenu"
        Me.SOEditMenu.ShortcutText = ""
        Me.SOEditMenu.Text = "Edit Selected Record"
        '
        'DeleteRecordButton
        '
        Me.DeleteRecordButton.Command = Me.SODeleteMenu
        Me.DeleteRecordButton.SortOrder = 2
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
        Me.ViewRecordButton.SortOrder = 3
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
        Me.RefreshMenu.SortOrder = 4
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
        Me.C1CommandLink2.SortOrder = 5
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
        'C1CommandHolder1
        '
        Me.C1CommandHolder1.Commands.Add(Me.C1ContextMenu1)
        Me.C1CommandHolder1.Commands.Add(Me.SOAddMenu)
        Me.C1CommandHolder1.Commands.Add(Me.SOEditMenu)
        Me.C1CommandHolder1.Commands.Add(Me.SODeleteMenu)
        Me.C1CommandHolder1.Commands.Add(Me.SOViewRecord)
        Me.C1CommandHolder1.Commands.Add(Me.SoRefresh)
        Me.C1CommandHolder1.Commands.Add(Me.SOShowAll)
        Me.C1CommandHolder1.Commands.Add(Me.ExportMenu)
        Me.C1CommandHolder1.Commands.Add(Me.SOExportCurrent)
        Me.C1CommandHolder1.Commands.Add(Me.SOExportAll)
        Me.C1CommandHolder1.Commands.Add(Me.C1Command8)
        Me.C1CommandHolder1.Commands.Add(Me.SOPrintCurrent)
        Me.C1CommandHolder1.Commands.Add(Me.SOPrintAll)
        Me.C1CommandHolder1.Commands.Add(Me.C1Command1)
        Me.C1CommandHolder1.Commands.Add(Me.C1Command10)
        Me.C1CommandHolder1.Owner = Me
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
        'C1flexgrid1
        '
        Me.C1flexgrid1.AllowEditing = False
        Me.C1flexgrid1.AllowFiltering = True
        Me.C1flexgrid1.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Columns
        Me.C1flexgrid1.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.C1flexgrid1.AutoSearch = C1.Win.C1FlexGrid.AutoSearchEnum.FromTop
        Me.C1flexgrid1.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.Light3D
        Me.C1CommandHolder1.SetC1ContextMenu(Me.C1flexgrid1, Me.C1ContextMenu1)
        Me.C1flexgrid1.ColumnInfo = "1,1,0,0,0,95,Columns:"
        Me.C1flexgrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1flexgrid1.ExtendLastCol = True
        Me.C1flexgrid1.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.C1flexgrid1.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.C1flexgrid1.IgnoreDiacritics = True
        Me.C1flexgrid1.Location = New System.Drawing.Point(0, 180)
        Me.C1flexgrid1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.C1flexgrid1.Name = "C1flexgrid1"
        Me.C1flexgrid1.Rows.Count = 1
        Me.C1flexgrid1.Rows.DefaultSize = 19
        Me.C1flexgrid1.ScrollOptions = CType(((C1.Win.C1FlexGrid.ScrollFlags.AlwaysVisible Or C1.Win.C1FlexGrid.ScrollFlags.ScrollByRowColumn) _
                    Or C1.Win.C1FlexGrid.ScrollFlags.ShowScrollTips), C1.Win.C1FlexGrid.ScrollFlags)
        Me.C1flexgrid1.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.C1flexgrid1.ShowCellLabels = True
        Me.C1flexgrid1.ShowCursor = True
        Me.C1flexgrid1.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.None
        Me.C1flexgrid1.Size = New System.Drawing.Size(650, 192)
        Me.C1flexgrid1.StyleInfo = resources.GetString("C1flexgrid1.StyleInfo")
        Me.C1flexgrid1.TabIndex = 56
        Me.C1flexgrid1.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Silver
        '
        'HRIS_GeneralViolation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 414)
        Me.Controls.Add(Me.C1flexgrid1)
        Me.Controls.Add(Me.C1InputPanel3)
        Me.Controls.Add(Me.C1InputPanel2)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "HRIS_GeneralViolation"
        Me.Text = "General Violations SetUp"
        CType(Me.C1InputPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1flexgrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1InputPanel3 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents C1InputPanel2 As C1.Win.C1InputPanel.C1InputPanel
    Private WithEvents C1ContextMenu1 As C1.Win.C1Command.C1ContextMenu
    Friend WithEvents AddNewRecordButton As C1.Win.C1Command.C1CommandLink
    Private WithEvents SOAddMenu As C1.Win.C1Command.C1Command
    Friend WithEvents EditRecordButton As C1.Win.C1Command.C1CommandLink
    Private WithEvents SOEditMenu As C1.Win.C1Command.C1CommandControl
    Friend WithEvents DeleteRecordButton As C1.Win.C1Command.C1CommandLink
    Private WithEvents SODeleteMenu As C1.Win.C1Command.C1Command
    Friend WithEvents ViewRecordButton As C1.Win.C1Command.C1CommandLink
    Private WithEvents SOViewRecord As C1.Win.C1Command.C1Command
    Friend WithEvents RefreshMenu As C1.Win.C1Command.C1CommandLink
    Private WithEvents SoRefresh As C1.Win.C1Command.C1Command
    Private WithEvents SOShowAll As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink2 As C1.Win.C1Command.C1CommandLink
    Private WithEvents ExportMenu As C1.Win.C1Command.C1CommandMenu
    Friend WithEvents ExportCurrentButton As C1.Win.C1Command.C1CommandLink
    Private WithEvents SOExportCurrent As C1.Win.C1Command.C1Command
    Friend WithEvents ExportAllButton As C1.Win.C1Command.C1CommandLink
    Private WithEvents SOExportAll As C1.Win.C1Command.C1Command
    Private WithEvents C1Command8 As C1.Win.C1Command.C1CommandMenu
    Friend WithEvents PrintCurrentMenu As C1.Win.C1Command.C1CommandLink
    Private WithEvents SOPrintCurrent As C1.Win.C1Command.C1Command
    Friend WithEvents PrintAllMenu As C1.Win.C1Command.C1CommandLink
    Private WithEvents SOPrintAll As C1.Win.C1Command.C1Command
    Private WithEvents C1Command1 As C1.Win.C1Command.C1CommandMenu
    Friend WithEvents C1CommandHolder1 As C1.Win.C1Command.C1CommandHolder
    Private WithEvents C1Command10 As C1.Win.C1Command.C1CommandMenu
    Friend WithEvents ExportCurrentMenu As C1.Win.C1Command.C1CommandLink
    Friend WithEvents ExportAllMenu As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1flexgrid1 As C1.Win.C1FlexGrid.C1FlexGrid
    Private WithEvents InputLabel2 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents Searchfield As C1.Win.C1InputPanel.InputTextBox
    Private WithEvents InputButton12 As C1.Win.C1InputPanel.InputButton
    Private WithEvents SearchClear As C1.Win.C1InputPanel.InputButton
    Private WithEvents InputGroupHeader2 As C1.Win.C1InputPanel.InputGroupHeader
    Private WithEvents InputLabel1 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents GeneralViolation As C1.Win.C1InputPanel.InputTextBox
    Private WithEvents InputLabel4 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents Description As C1.Win.C1InputPanel.InputTextBox
    Private WithEvents InputLabel5 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents Status As C1.Win.C1InputPanel.InputCheckBox
    Private WithEvents InputSeparator2 As C1.Win.C1InputPanel.InputSeparator
    Private WithEvents Clear As C1.Win.C1InputPanel.InputButton
    Private WithEvents SaveRecord As C1.Win.C1InputPanel.InputButton
End Class
