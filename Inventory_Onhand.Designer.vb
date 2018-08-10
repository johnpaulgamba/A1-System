<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inventory_onhand
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(inventory_onhand))
        Me.C1FlexGrid1 = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1InputPanel2 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader3 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputButton4 = New C1.Win.C1InputPanel.InputButton()
        Me.InputButton1 = New C1.Win.C1InputPanel.InputButton()
        Me.InputButton2 = New C1.Win.C1InputPanel.InputButton()
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader2 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel4 = New C1.Win.C1InputPanel.InputLabel()
        Me.Branch = New C1.Win.C1InputPanel.InputComboBox()
        Me.InputLabel2 = New C1.Win.C1InputPanel.InputLabel()
        Me.Warehouse = New C1.Win.C1InputPanel.InputComboBox()
        Me.InputLabel3 = New C1.Win.C1InputPanel.InputLabel()
        Me.ItemName = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel1 = New C1.Win.C1InputPanel.InputLabel()
        Me.SearchButton = New C1.Win.C1InputPanel.InputButton()
        Me.InputButton3 = New C1.Win.C1InputPanel.InputButton()
        CType(Me.C1FlexGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1FlexGrid1
        '
        Me.C1FlexGrid1.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.C1FlexGrid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1FlexGrid1.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
        Me.C1FlexGrid1.ColumnInfo = resources.GetString("C1FlexGrid1.ColumnInfo")
        Me.C1FlexGrid1.ExtendLastCol = True
        Me.C1FlexGrid1.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
        Me.C1FlexGrid1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.C1FlexGrid1.Location = New System.Drawing.Point(12, 100)
        Me.C1FlexGrid1.Name = "C1FlexGrid1"
        Me.C1FlexGrid1.Rows.Count = 1
        Me.C1FlexGrid1.Rows.DefaultSize = 20
        Me.C1FlexGrid1.Size = New System.Drawing.Size(829, 376)
        Me.C1FlexGrid1.StyleInfo = resources.GetString("C1FlexGrid1.StyleInfo")
        Me.C1FlexGrid1.TabIndex = 55
        Me.C1FlexGrid1.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.System
        '
        'C1InputPanel2
        '
        Me.C1InputPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1InputPanel2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1InputPanel2.Items.Add(Me.InputGroupHeader3)
        Me.C1InputPanel2.Items.Add(Me.InputButton4)
        Me.C1InputPanel2.Items.Add(Me.InputButton1)
        Me.C1InputPanel2.Items.Add(Me.InputButton2)
        Me.C1InputPanel2.Location = New System.Drawing.Point(12, 482)
        Me.C1InputPanel2.Name = "C1InputPanel2"
        Me.C1InputPanel2.Size = New System.Drawing.Size(829, 65)
        Me.C1InputPanel2.TabIndex = 56
        '
        'InputGroupHeader3
        '
        Me.InputGroupHeader3.Height = 29
        Me.InputGroupHeader3.Name = "InputGroupHeader3"
        Me.InputGroupHeader3.Text = "Actions and Commands"
        '
        'InputButton4
        '
        Me.InputButton4.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.InputButton4.Image = Global.BakeTechSoftware.My.Resources.Resources.coin_stack_silver_share__1_
        Me.InputButton4.Name = "InputButton4"
        Me.InputButton4.Text = "View Transaction Register"
        '
        'InputButton1
        '
        Me.InputButton1.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.InputButton1.Image = Global.BakeTechSoftware.My.Resources.Resources.SaveAllHS
        Me.InputButton1.Name = "InputButton1"
        Me.InputButton1.Text = "Export Details"
        '
        'InputButton2
        '
        Me.InputButton2.Image = Global.BakeTechSoftware.My.Resources.Resources.no
        Me.InputButton2.Name = "InputButton2"
        Me.InputButton2.Text = "&Close"
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1InputPanel1.BackColor = System.Drawing.SystemColors.Control
        Me.C1InputPanel1.BorderThickness = 1
        Me.C1InputPanel1.ChildSpacing = New System.Drawing.Size(0, 2)
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1InputPanel1.GroupIndent = 0
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader2)
        Me.C1InputPanel1.Items.Add(Me.InputLabel4)
        Me.C1InputPanel1.Items.Add(Me.Branch)
        Me.C1InputPanel1.Items.Add(Me.InputLabel2)
        Me.C1InputPanel1.Items.Add(Me.Warehouse)
        Me.C1InputPanel1.Items.Add(Me.InputLabel3)
        Me.C1InputPanel1.Items.Add(Me.ItemName)
        Me.C1InputPanel1.Items.Add(Me.InputLabel1)
        Me.C1InputPanel1.Items.Add(Me.SearchButton)
        Me.C1InputPanel1.Items.Add(Me.InputButton3)
        Me.C1InputPanel1.Location = New System.Drawing.Point(12, 12)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Padding = New System.Windows.Forms.Padding(5)
        Me.C1InputPanel1.Size = New System.Drawing.Size(829, 82)
        Me.C1InputPanel1.TabIndex = 57
        Me.C1InputPanel1.VisualStyle = C1.Win.C1InputPanel.VisualStyle.System
        '
        'InputGroupHeader2
        '
        Me.InputGroupHeader2.Height = 25
        Me.InputGroupHeader2.Name = "InputGroupHeader2"
        Me.InputGroupHeader2.Text = "Filter Item"
        '
        'InputLabel4
        '
        Me.InputLabel4.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel4.Name = "InputLabel4"
        Me.InputLabel4.Text = "Branch / Site"
        '
        'Branch
        '
        Me.Branch.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.Branch.Name = "Branch"
        Me.Branch.Width = 132
        '
        'InputLabel2
        '
        Me.InputLabel2.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel2.Name = "InputLabel2"
        Me.InputLabel2.Text = "Warehouse:"
        Me.InputLabel2.Width = 63
        '
        'Warehouse
        '
        Me.Warehouse.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.Warehouse.Name = "Warehouse"
        Me.Warehouse.Width = 142
        '
        'InputLabel3
        '
        Me.InputLabel3.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel3.Height = 13
        Me.InputLabel3.Name = "InputLabel3"
        Me.InputLabel3.Text = "Item Name:"
        Me.InputLabel3.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Near
        '
        'ItemName
        '
        Me.ItemName.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.ItemName.Name = "ItemName"
        Me.ItemName.Width = 246
        '
        'InputLabel1
        '
        Me.InputLabel1.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel1.Name = "InputLabel1"
        '
        'SearchButton
        '
        Me.SearchButton.Break = C1.Win.C1InputPanel.BreakType.None
        Me.SearchButton.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.SearchButton.Image = Global.BakeTechSoftware.My.Resources.Resources._next
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.SearchButton.Text = "Search"
        Me.SearchButton.Width = 71
        '
        'InputButton3
        '
        Me.InputButton3.Break = C1.Win.C1InputPanel.BreakType.None
        Me.InputButton3.Image = Global.BakeTechSoftware.My.Resources.Resources.DocumentHS1
        Me.InputButton3.Name = "InputButton3"
        Me.InputButton3.Text = "&Clear"
        '
        'Inventory_Onhand
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(850, 559)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.Controls.Add(Me.C1InputPanel2)
        Me.Controls.Add(Me.C1FlexGrid1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(866, 598)
        Me.Name = "Inventory_Onhand"
        Me.Text = "Inventory On Hand"
        CType(Me.C1FlexGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1FlexGrid1 As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents C1InputPanel2 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader3 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputButton2 As C1.Win.C1InputPanel.InputButton
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader2 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputLabel2 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents Warehouse As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents InputLabel3 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents ItemName As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel1 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents SearchButton As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputButton3 As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputLabel4 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents Branch As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents InputButton1 As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputButton4 As C1.Win.C1InputPanel.InputButton
End Class
