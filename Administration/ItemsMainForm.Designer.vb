<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class itemsmainform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(itemsmainform))
        Me.C1NavBarPanel1 = New C1.Win.C1Command.C1NavBarPanel()
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputLabel1 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputSeparator1 = New C1.Win.C1InputPanel.InputSeparator()
        Me.InputLabel2 = New C1.Win.C1InputPanel.InputLabel()
        Me.Warehouse = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel3 = New C1.Win.C1InputPanel.InputLabel()
        Me.Description = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel7 = New C1.Win.C1InputPanel.InputLabel()
        Me.UOM = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel8 = New C1.Win.C1InputPanel.InputLabel()
        Me.category = New C1.Win.C1InputPanel.InputComboBox()
        Me.InputLabel4 = New C1.Win.C1InputPanel.InputLabel()
        Me.Creator = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel5 = New C1.Win.C1InputPanel.InputLabel()
        Me.DateCreated = New C1.Win.C1InputPanel.InputDatePicker()
        Me.InputLabel6 = New C1.Win.C1InputPanel.InputLabel()
        Me.LastUpdate = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputSeparator2 = New C1.Win.C1InputPanel.InputSeparator()
        Me.SearchButton = New C1.Win.C1InputPanel.InputButton()
        Me.ClearButton = New C1.Win.C1InputPanel.InputButton()
        Me.InputSeparator3 = New C1.Win.C1InputPanel.InputSeparator()
        Me.C1NavBar1 = New C1.Win.C1Command.C1NavBar()
        Me.C1NavBar2 = New C1.Win.C1Command.C1NavBar()
        Me.C1NavBarPanel2 = New C1.Win.C1Command.C1NavBarPanel()
        Me.C1FlexGrid1 = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1ContextMenu1 = New C1.Win.C1Command.C1ContextMenu()
        Me.C1CommandLink2 = New C1.Win.C1Command.C1CommandLink()
        Me.AddNew = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink3 = New C1.Win.C1Command.C1CommandLink()
        Me.EditRecord = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink4 = New C1.Win.C1Command.C1CommandLink()
        Me.RefreshGrid = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink5 = New C1.Win.C1Command.C1CommandLink()
        Me.ExportGrid = New C1.Win.C1Command.C1Command()
        Me.C1CommandHolder1 = New C1.Win.C1Command.C1CommandHolder()
        Me.InputLabel9 = New C1.Win.C1InputPanel.InputLabel()
        Me.itemcode = New C1.Win.C1InputPanel.InputTextBox()
        Me.C1NavBarPanel1.SuspendLayout()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NavBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1NavBar1.SuspendLayout()
        CType(Me.C1NavBar2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1NavBar2.SuspendLayout()
        Me.C1NavBarPanel2.SuspendLayout()
        CType(Me.C1FlexGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1NavBarPanel1
        '
        Me.C1NavBarPanel1.Button.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.C1NavBarPanel1.Button.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.C1NavBarPanel1.Button.PanelHeader = "SEARCH PANEL"
        Me.C1NavBarPanel1.Button.SmallImage = CType(resources.GetObject("resource.SmallImage"), System.Drawing.Image)
        Me.C1NavBarPanel1.Button.Text = "Notes"
        Me.C1NavBarPanel1.Controls.Add(Me.C1InputPanel1)
        Me.C1NavBarPanel1.ID = 1
        Me.C1NavBarPanel1.Name = "C1NavBarPanel1"
        Me.C1NavBarPanel1.Size = New System.Drawing.Size(265, 497)
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.BackColor = System.Drawing.Color.Transparent
        Me.C1InputPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1InputPanel1.Items.Add(Me.InputLabel1)
        Me.C1InputPanel1.Items.Add(Me.InputSeparator1)
        Me.C1InputPanel1.Items.Add(Me.InputLabel9)
        Me.C1InputPanel1.Items.Add(Me.itemcode)
        Me.C1InputPanel1.Items.Add(Me.InputLabel2)
        Me.C1InputPanel1.Items.Add(Me.Warehouse)
        Me.C1InputPanel1.Items.Add(Me.InputLabel3)
        Me.C1InputPanel1.Items.Add(Me.Description)
        Me.C1InputPanel1.Items.Add(Me.InputLabel7)
        Me.C1InputPanel1.Items.Add(Me.UOM)
        Me.C1InputPanel1.Items.Add(Me.InputLabel8)
        Me.C1InputPanel1.Items.Add(Me.category)
        Me.C1InputPanel1.Items.Add(Me.InputLabel4)
        Me.C1InputPanel1.Items.Add(Me.Creator)
        Me.C1InputPanel1.Items.Add(Me.InputLabel5)
        Me.C1InputPanel1.Items.Add(Me.DateCreated)
        Me.C1InputPanel1.Items.Add(Me.InputLabel6)
        Me.C1InputPanel1.Items.Add(Me.LastUpdate)
        Me.C1InputPanel1.Items.Add(Me.InputSeparator2)
        Me.C1InputPanel1.Items.Add(Me.SearchButton)
        Me.C1InputPanel1.Items.Add(Me.ClearButton)
        Me.C1InputPanel1.Items.Add(Me.InputSeparator3)
        Me.C1InputPanel1.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(265, 497)
        Me.C1InputPanel1.TabIndex = 1
        Me.C1InputPanel1.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Windows7
        '
        'InputLabel1
        '
        Me.InputLabel1.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel1.Name = "InputLabel1"
        Me.InputLabel1.Text = "FIll up the filter fields below ito match " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "your search criteria."
        '
        'InputSeparator1
        '
        Me.InputSeparator1.Name = "InputSeparator1"
        Me.InputSeparator1.Width = 216
        '
        'InputLabel2
        '
        Me.InputLabel2.Name = "InputLabel2"
        Me.InputLabel2.Text = "Item Name:"
        Me.InputLabel2.Width = 67
        '
        'Warehouse
        '
        Me.Warehouse.Name = "Warehouse"
        Me.Warehouse.Width = 144
        '
        'InputLabel3
        '
        Me.InputLabel3.Name = "InputLabel3"
        Me.InputLabel3.Text = "Description:"
        Me.InputLabel3.Width = 67
        '
        'Description
        '
        Me.Description.Name = "Description"
        Me.Description.Width = 144
        '
        'InputLabel7
        '
        Me.InputLabel7.Name = "InputLabel7"
        Me.InputLabel7.Text = "UOM:"
        Me.InputLabel7.Width = 67
        '
        'UOM
        '
        Me.UOM.Name = "UOM"
        Me.UOM.Width = 144
        '
        'InputLabel8
        '
        Me.InputLabel8.Name = "InputLabel8"
        Me.InputLabel8.Text = "Category:"
        Me.InputLabel8.Width = 67
        '
        'category
        '
        Me.category.Name = "category"
        Me.category.Width = 144
        '
        'InputLabel4
        '
        Me.InputLabel4.Name = "InputLabel4"
        Me.InputLabel4.Text = "Creator:"
        Me.InputLabel4.Width = 67
        '
        'Creator
        '
        Me.Creator.Name = "Creator"
        Me.Creator.Width = 144
        '
        'InputLabel5
        '
        Me.InputLabel5.Name = "InputLabel5"
        Me.InputLabel5.Text = "Created:"
        Me.InputLabel5.Width = 67
        '
        'DateCreated
        '
        Me.DateCreated.Name = "DateCreated"
        Me.DateCreated.Width = 144
        '
        'InputLabel6
        '
        Me.InputLabel6.Name = "InputLabel6"
        Me.InputLabel6.Text = "Updated:"
        Me.InputLabel6.Width = 67
        '
        'LastUpdate
        '
        Me.LastUpdate.Name = "LastUpdate"
        Me.LastUpdate.Width = 144
        '
        'InputSeparator2
        '
        Me.InputSeparator2.Name = "InputSeparator2"
        Me.InputSeparator2.Width = 214
        '
        'SearchButton
        '
        Me.SearchButton.Break = C1.Win.C1InputPanel.BreakType.None
        Me.SearchButton.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.SearchButton.Image = Global.A1plus.My.Resources.Resources._next
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Text = "&Search"
        Me.SearchButton.Width = 153
        '
        'ClearButton
        '
        Me.ClearButton.Image = Global.A1plus.My.Resources.Resources.no
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Text = "&Clear"
        '
        'InputSeparator3
        '
        Me.InputSeparator3.Name = "InputSeparator3"
        Me.InputSeparator3.Width = 214
        '
        'C1NavBar1
        '
        Me.C1NavBar1.AllowCollapse = True
        Me.C1NavBar1.ButtonMargins = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.C1NavBar1.Collapsed = False
        Me.C1NavBar1.Controls.Add(Me.C1NavBarPanel1)
        Me.C1NavBar1.Dock = System.Windows.Forms.DockStyle.Left
        Me.C1NavBar1.GripHeight = 0
        Me.C1NavBar1.GripMargins = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.C1NavBar1.Location = New System.Drawing.Point(0, 0)
        Me.C1NavBar1.Name = "C1NavBar1"
        Me.C1NavBar1.ShowOptionsMenu = False
        Me.C1NavBar1.ShowVerticalTextOnCollapse = True
        Me.C1NavBar1.Size = New System.Drawing.Size(267, 524)
        Me.C1NavBar1.StackButtonCount = 0
        Me.C1NavBar1.StripHeight = 0
        Me.C1NavBar1.UIStrings.Content = New String() {"NavBarCollapsedBarText:SEARCH PANEL"}
        Me.C1NavBar1.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Silver
        '
        'C1NavBar2
        '
        Me.C1NavBar2.ButtonMargins = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.C1NavBar2.Collapsed = False
        Me.C1NavBar2.Controls.Add(Me.C1NavBarPanel2)
        Me.C1NavBar2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1NavBar2.GripHeight = 0
        Me.C1NavBar2.GripMargins = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.C1NavBar2.Location = New System.Drawing.Point(267, 0)
        Me.C1NavBar2.Name = "C1NavBar2"
        Me.C1NavBar2.ShowOptionsMenu = False
        Me.C1NavBar2.Size = New System.Drawing.Size(738, 524)
        Me.C1NavBar2.StackButtonCount = 0
        Me.C1NavBar2.StripHeight = 0
        Me.C1NavBar2.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Silver
        '
        'C1NavBarPanel2
        '
        Me.C1NavBarPanel2.Button.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        Me.C1NavBarPanel2.Button.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.C1NavBarPanel2.Button.PanelHeader = "LIST OF MASTER ITEMS. . ."
        Me.C1NavBarPanel2.Button.SmallImage = CType(resources.GetObject("resource.SmallImage1"), System.Drawing.Image)
        Me.C1NavBarPanel2.Button.Text = "Notes"
        Me.C1NavBarPanel2.Controls.Add(Me.C1FlexGrid1)
        Me.C1NavBarPanel2.ID = 1
        Me.C1NavBarPanel2.Name = "C1NavBarPanel2"
        Me.C1NavBarPanel2.Size = New System.Drawing.Size(736, 497)
        '
        'C1FlexGrid1
        '
        Me.C1FlexGrid1.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.C1FlexGrid1.AllowEditing = False
        Me.C1FlexGrid1.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.Light3D
        Me.C1FlexGrid1.ColumnInfo = "1,0,0,0,0,95,Columns:0{Width:45;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.C1FlexGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1FlexGrid1.Location = New System.Drawing.Point(0, 0)
        Me.C1FlexGrid1.Name = "C1FlexGrid1"
        Me.C1FlexGrid1.Rows.Count = 1
        Me.C1FlexGrid1.Rows.DefaultSize = 19
        Me.C1FlexGrid1.Size = New System.Drawing.Size(736, 497)
        Me.C1FlexGrid1.TabIndex = 0
        Me.C1FlexGrid1.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Silver
        '
        'C1ContextMenu1
        '
        Me.C1ContextMenu1.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink2, Me.C1CommandLink3, Me.C1CommandLink4, Me.C1CommandLink5})
        Me.C1ContextMenu1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1ContextMenu1.Name = "C1ContextMenu1"
        Me.C1ContextMenu1.ShortcutText = ""
        Me.C1ContextMenu1.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Black
        Me.C1ContextMenu1.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Black
        '
        'C1CommandLink2
        '
        Me.C1CommandLink2.Command = Me.AddNew
        '
        'AddNew
        '
        Me.AddNew.Image = Global.A1plus.My.Resources.Resources.plus_button
        Me.AddNew.Name = "AddNew"
        Me.AddNew.ShortcutText = ""
        Me.AddNew.Text = "Add New Entry"
        '
        'C1CommandLink3
        '
        Me.C1CommandLink3.Command = Me.EditRecord
        Me.C1CommandLink3.SortOrder = 1
        '
        'EditRecord
        '
        Me.EditRecord.Image = Global.A1plus.My.Resources.Resources.desktop__1_
        Me.EditRecord.Name = "EditRecord"
        Me.EditRecord.ShortcutText = ""
        Me.EditRecord.Text = "Modify Entry"
        '
        'C1CommandLink4
        '
        Me.C1CommandLink4.Command = Me.RefreshGrid
        Me.C1CommandLink4.Delimiter = True
        Me.C1CommandLink4.SortOrder = 2
        '
        'RefreshGrid
        '
        Me.RefreshGrid.Image = Global.A1plus.My.Resources.Resources.reload__1_
        Me.RefreshGrid.Name = "RefreshGrid"
        Me.RefreshGrid.ShortcutText = ""
        Me.RefreshGrid.Text = "Refresh Grid"
        '
        'C1CommandLink5
        '
        Me.C1CommandLink5.Command = Me.ExportGrid
        Me.C1CommandLink5.SortOrder = 3
        '
        'ExportGrid
        '
        Me.ExportGrid.Image = Global.A1plus.My.Resources.Resources.export__1_
        Me.ExportGrid.Name = "ExportGrid"
        Me.ExportGrid.ShortcutText = ""
        Me.ExportGrid.Text = "Export Grid"
        '
        'C1CommandHolder1
        '
        Me.C1CommandHolder1.Commands.Add(Me.C1ContextMenu1)
        Me.C1CommandHolder1.Commands.Add(Me.AddNew)
        Me.C1CommandHolder1.Commands.Add(Me.EditRecord)
        Me.C1CommandHolder1.Commands.Add(Me.RefreshGrid)
        Me.C1CommandHolder1.Commands.Add(Me.ExportGrid)
        Me.C1CommandHolder1.Owner = Me
        '
        'InputLabel9
        '
        Me.InputLabel9.Name = "InputLabel9"
        Me.InputLabel9.Text = "Item Code:"
        Me.InputLabel9.Width = 67
        '
        'itemcode
        '
        Me.itemcode.Name = "itemcode"
        Me.itemcode.Width = 144
        '
        'itemsmainform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 524)
        Me.Controls.Add(Me.C1NavBar2)
        Me.Controls.Add(Me.C1NavBar1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "itemsmainform"
        Me.Text = "Master Items"
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Silver
        Me.C1NavBarPanel1.ResumeLayout(False)
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NavBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1NavBar1.ResumeLayout(False)
        CType(Me.C1NavBar2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1NavBar2.ResumeLayout(False)
        Me.C1NavBarPanel2.ResumeLayout(False)
        CType(Me.C1FlexGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1NavBarPanel1 As C1.Win.C1Command.C1NavBarPanel
    Friend WithEvents C1NavBar1 As C1.Win.C1Command.C1NavBar
    Friend WithEvents C1NavBar2 As C1.Win.C1Command.C1NavBar
    Friend WithEvents C1NavBarPanel2 As C1.Win.C1Command.C1NavBarPanel
    Friend WithEvents C1FlexGrid1 As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents C1CommandLink2 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink3 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink4 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink5 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandHolder1 As C1.Win.C1Command.C1CommandHolder
    Private WithEvents InputLabel1 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents InputSeparator1 As C1.Win.C1InputPanel.InputSeparator
    Private WithEvents InputLabel2 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents Warehouse As C1.Win.C1InputPanel.InputTextBox
    Private WithEvents InputLabel3 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents Description As C1.Win.C1InputPanel.InputTextBox
    Private WithEvents InputLabel4 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents Creator As C1.Win.C1InputPanel.InputTextBox
    Private WithEvents InputLabel5 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents DateCreated As C1.Win.C1InputPanel.InputDatePicker
    Private WithEvents InputLabel6 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents LastUpdate As C1.Win.C1InputPanel.InputTextBox
    Private WithEvents InputSeparator2 As C1.Win.C1InputPanel.InputSeparator
    Private WithEvents SearchButton As C1.Win.C1InputPanel.InputButton
    Private WithEvents ClearButton As C1.Win.C1InputPanel.InputButton
    Private WithEvents InputSeparator3 As C1.Win.C1InputPanel.InputSeparator
    Private WithEvents C1ContextMenu1 As C1.Win.C1Command.C1ContextMenu
    Private WithEvents AddNew As C1.Win.C1Command.C1Command
    Private WithEvents EditRecord As C1.Win.C1Command.C1Command
    Private WithEvents RefreshGrid As C1.Win.C1Command.C1Command
    Private WithEvents ExportGrid As C1.Win.C1Command.C1Command
    Private WithEvents InputLabel7 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents UOM As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel9 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents itemcode As C1.Win.C1InputPanel.InputTextBox
    Private WithEvents InputLabel8 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents category As C1.Win.C1InputPanel.InputComboBox
End Class
