<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class POMonitoringMainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(POMonitoringMainForm))
        Me.C1NavBarPanel1 = New C1.Win.C1Command.C1NavBarPanel()
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputLabel1 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputSeparator1 = New C1.Win.C1InputPanel.InputSeparator()
        Me.InputLabel12 = New C1.Win.C1InputPanel.InputLabel()
        Me.PONo = New C1.Win.C1InputPanel.InputTextBox()
        Me.Group = New C1.Win.C1InputPanel.InputLabel()
        Me.Items = New C1.Win.C1InputPanel.InputRadioButton()
        Me.PoNox = New C1.Win.C1InputPanel.InputRadioButton()
        Me.InputSeparator6 = New C1.Win.C1InputPanel.InputSeparator()
        Me.SearchButton = New C1.Win.C1InputPanel.InputButton()
        Me.ClearButton = New C1.Win.C1InputPanel.InputButton()
        Me.InputSeparator3 = New C1.Win.C1InputPanel.InputSeparator()
        Me.C1NavBar1 = New C1.Win.C1Command.C1NavBar()
        Me.C1NavBar2 = New C1.Win.C1Command.C1NavBar()
        Me.C1NavBarPanel2 = New C1.Win.C1Command.C1NavBarPanel()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.C1ContextMenu1 = New C1.Win.C1Command.C1ContextMenu()
        Me.C1CommandLink2 = New C1.Win.C1Command.C1CommandLink()
        Me.AddNew = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink3 = New C1.Win.C1Command.C1CommandLink()
        Me.EditRecord = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink1 = New C1.Win.C1Command.C1CommandLink()
        Me.PrintRecord = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink6 = New C1.Win.C1Command.C1CommandLink()
        Me.CancelCommand = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink7 = New C1.Win.C1Command.C1CommandLink()
        Me.ApproveCommand = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink8 = New C1.Win.C1Command.C1CommandLink()
        Me.CancelApprovedCommand = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink4 = New C1.Win.C1Command.C1CommandLink()
        Me.RefreshGrid = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink5 = New C1.Win.C1Command.C1CommandLink()
        Me.ExportGrid = New C1.Win.C1Command.C1Command()
        Me.C1CommandHolder1 = New C1.Win.C1Command.C1CommandHolder()
        Me.InputSeparator5 = New C1.Win.C1InputPanel.InputSeparator()
        Me.Delivery = New C1.Win.C1InputPanel.InputRadioButton()
        Me.C1NavBarPanel1.SuspendLayout()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NavBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1NavBar1.SuspendLayout()
        CType(Me.C1NavBar2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1NavBar2.SuspendLayout()
        Me.C1NavBarPanel2.SuspendLayout()
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
        Me.C1InputPanel1.Items.Add(Me.InputLabel12)
        Me.C1InputPanel1.Items.Add(Me.PONo)
        Me.C1InputPanel1.Items.Add(Me.Group)
        Me.C1InputPanel1.Items.Add(Me.Items)
        Me.C1InputPanel1.Items.Add(Me.PoNox)
        Me.C1InputPanel1.Items.Add(Me.Delivery)
        Me.C1InputPanel1.Items.Add(Me.InputSeparator6)
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
        Me.InputSeparator1.Width = 247
        '
        'InputLabel12
        '
        Me.InputLabel12.Name = "InputLabel12"
        Me.InputLabel12.Text = "PO No:"
        Me.InputLabel12.Width = 67
        '
        'PONo
        '
        Me.PONo.Name = "PONo"
        Me.PONo.Width = 169
        '
        'Group
        '
        Me.Group.Name = "Group"
        Me.Group.Text = "Group By:"
        Me.Group.Width = 63
        '
        'Items
        '
        Me.Items.Break = C1.Win.C1InputPanel.BreakType.None
        Me.Items.Checked = True
        Me.Items.Name = "Items"
        Me.Items.Text = "Item"
        '
        'PoNox
        '
        Me.PoNox.Break = C1.Win.C1InputPanel.BreakType.None
        Me.PoNox.Name = "PoNox"
        Me.PoNox.Text = "PONo"
        Me.PoNox.Width = 51
        '
        'InputSeparator6
        '
        Me.InputSeparator6.Name = "InputSeparator6"
        Me.InputSeparator6.Width = 245
        '
        'SearchButton
        '
        Me.SearchButton.Break = C1.Win.C1InputPanel.BreakType.None
        Me.SearchButton.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.SearchButton.Image = Global.A1plus.My.Resources.Resources._next
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Text = "&Run Report"
        Me.SearchButton.Width = 183
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
        Me.InputSeparator3.Width = 245
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
        Me.C1NavBarPanel2.Button.PanelHeader = "REPORT PREVIEW. . ."
        Me.C1NavBarPanel2.Button.SmallImage = CType(resources.GetObject("resource.SmallImage1"), System.Drawing.Image)
        Me.C1NavBarPanel2.Button.Text = "Notes"
        Me.C1NavBarPanel2.Controls.Add(Me.CrystalReportViewer1)
        Me.C1NavBarPanel2.ID = 1
        Me.C1NavBarPanel2.Name = "C1NavBarPanel2"
        Me.C1NavBarPanel2.Size = New System.Drawing.Size(736, 497)
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(736, 497)
        Me.CrystalReportViewer1.TabIndex = 2
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'C1ContextMenu1
        '
        Me.C1ContextMenu1.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink2, Me.C1CommandLink3, Me.C1CommandLink1, Me.C1CommandLink6, Me.C1CommandLink7, Me.C1CommandLink8, Me.C1CommandLink4, Me.C1CommandLink5})
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
        'C1CommandLink1
        '
        Me.C1CommandLink1.Command = Me.PrintRecord
        Me.C1CommandLink1.Delimiter = True
        Me.C1CommandLink1.SortOrder = 2
        '
        'PrintRecord
        '
        Me.PrintRecord.Image = Global.A1plus.My.Resources.Resources.printer_go
        Me.PrintRecord.Name = "PrintRecord"
        Me.PrintRecord.ShortcutText = ""
        Me.PrintRecord.Text = "Print Sales Order"
        '
        'C1CommandLink6
        '
        Me.C1CommandLink6.Command = Me.CancelCommand
        Me.C1CommandLink6.Delimiter = True
        Me.C1CommandLink6.SortOrder = 3
        '
        'CancelCommand
        '
        Me.CancelCommand.Image = Global.A1plus.My.Resources.Resources.deletered__1_
        Me.CancelCommand.Name = "CancelCommand"
        Me.CancelCommand.ShortcutText = ""
        Me.CancelCommand.Text = "Cancel Sales Order"
        '
        'C1CommandLink7
        '
        Me.C1CommandLink7.Command = Me.ApproveCommand
        Me.C1CommandLink7.SortOrder = 4
        '
        'ApproveCommand
        '
        Me.ApproveCommand.Image = Global.A1plus.My.Resources.Resources.check__1_1
        Me.ApproveCommand.Name = "ApproveCommand"
        Me.ApproveCommand.ShortcutText = ""
        Me.ApproveCommand.Text = "Approve Sales Order"
        '
        'C1CommandLink8
        '
        Me.C1CommandLink8.Command = Me.CancelApprovedCommand
        Me.C1CommandLink8.Delimiter = True
        Me.C1CommandLink8.SortOrder = 5
        '
        'CancelApprovedCommand
        '
        Me.CancelApprovedCommand.Image = Global.A1plus.My.Resources.Resources.DocumentHS1
        Me.CancelApprovedCommand.Name = "CancelApprovedCommand"
        Me.CancelApprovedCommand.ShortcutText = ""
        Me.CancelApprovedCommand.Text = "Void Approved Order"
        '
        'C1CommandLink4
        '
        Me.C1CommandLink4.Command = Me.RefreshGrid
        Me.C1CommandLink4.Delimiter = True
        Me.C1CommandLink4.SortOrder = 6
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
        Me.C1CommandLink5.SortOrder = 7
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
        Me.C1CommandHolder1.Commands.Add(Me.PrintRecord)
        Me.C1CommandHolder1.Commands.Add(Me.CancelCommand)
        Me.C1CommandHolder1.Commands.Add(Me.ApproveCommand)
        Me.C1CommandHolder1.Commands.Add(Me.CancelApprovedCommand)
        Me.C1CommandHolder1.Owner = Me
        '
        'InputSeparator5
        '
        Me.InputSeparator5.Name = "InputSeparator5"
        Me.InputSeparator5.Width = 214
        '
        'Delivery
        '
        Me.Delivery.Name = "Delivery"
        Me.Delivery.Text = "Delivery"
        '
        'POMonitoringMainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 524)
        Me.Controls.Add(Me.C1NavBar2)
        Me.Controls.Add(Me.C1NavBar1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "POMonitoringMainForm"
        Me.Text = "Reporting : PO Monitoring Register"
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Silver
        Me.C1NavBarPanel1.ResumeLayout(False)
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NavBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1NavBar1.ResumeLayout(False)
        CType(Me.C1NavBar2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1NavBar2.ResumeLayout(False)
        Me.C1NavBarPanel2.ResumeLayout(False)
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1NavBarPanel1 As C1.Win.C1Command.C1NavBarPanel
    Friend WithEvents C1NavBar1 As C1.Win.C1Command.C1NavBar
    Friend WithEvents C1NavBar2 As C1.Win.C1Command.C1NavBar
    Friend WithEvents C1NavBarPanel2 As C1.Win.C1Command.C1NavBarPanel
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents C1CommandLink2 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink3 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink4 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink5 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandHolder1 As C1.Win.C1Command.C1CommandHolder
    Private WithEvents InputLabel1 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents InputSeparator1 As C1.Win.C1InputPanel.InputSeparator
    Private WithEvents InputSeparator3 As C1.Win.C1InputPanel.InputSeparator
    Private WithEvents C1ContextMenu1 As C1.Win.C1Command.C1ContextMenu
    Friend WithEvents C1CommandLink1 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink6 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink7 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink8 As C1.Win.C1Command.C1CommandLink
    Private WithEvents PrintRecord As C1.Win.C1Command.C1Command
    Private WithEvents CancelCommand As C1.Win.C1Command.C1Command
    Private WithEvents ApproveCommand As C1.Win.C1Command.C1Command
    Private WithEvents SearchButton As C1.Win.C1InputPanel.InputButton
    Private WithEvents ClearButton As C1.Win.C1InputPanel.InputButton
    Private WithEvents AddNew As C1.Win.C1Command.C1Command
    Private WithEvents EditRecord As C1.Win.C1Command.C1Command
    Private WithEvents RefreshGrid As C1.Win.C1Command.C1Command
    Private WithEvents ExportGrid As C1.Win.C1Command.C1Command
    Private WithEvents CancelApprovedCommand As C1.Win.C1Command.C1Command
    Private WithEvents InputLabel12 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents PONo As C1.Win.C1InputPanel.InputTextBox
    Private WithEvents InputSeparator6 As C1.Win.C1InputPanel.InputSeparator
    Private WithEvents InputSeparator5 As C1.Win.C1InputPanel.InputSeparator
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Group As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents PoNox As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents Items As C1.Win.C1InputPanel.InputRadioButton
    Friend WithEvents Delivery As C1.Win.C1InputPanel.InputRadioButton
End Class
