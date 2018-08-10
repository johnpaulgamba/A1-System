<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inventory_transactions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(inventory_transactions))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.C1FlexGrid1 = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1InputPanel2 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.C1InputPanel3 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader3 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel1 = New C1.Win.C1InputPanel.InputLabel()
        Me.DateFrom = New C1.Win.C1InputPanel.InputDatePicker()
        Me.InputLabel11 = New C1.Win.C1InputPanel.InputLabel()
        Me.DateTo = New C1.Win.C1InputPanel.InputDatePicker()
        Me.InputLabel2 = New C1.Win.C1InputPanel.InputLabel()
        Me.Warehouse = New C1.Win.C1InputPanel.InputComboBox()
        Me.InputLabel12 = New C1.Win.C1InputPanel.InputLabel()
        Me.TransactionType = New C1.Win.C1InputPanel.InputComboBox()
        Me.InputOption5 = New C1.Win.C1InputPanel.InputOption()
        Me.InputOption6 = New C1.Win.C1InputPanel.InputOption()
        Me.InputOption7 = New C1.Win.C1InputPanel.InputOption()
        Me.InputOption8 = New C1.Win.C1InputPanel.InputOption()
        Me.InputOption9 = New C1.Win.C1InputPanel.InputOption()
        Me.InputLabel7 = New C1.Win.C1InputPanel.InputLabel()
        Me.ItemName = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel10 = New C1.Win.C1InputPanel.InputLabel()
        Me.WithOnHandOnly = New C1.Win.C1InputPanel.InputCheckBox()
        Me.InputLabel8 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel9 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel3 = New C1.Win.C1InputPanel.InputLabel()
        Me.Branch = New C1.Win.C1InputPanel.InputComboBox()
        Me.SearchButton = New C1.Win.C1InputPanel.InputButton()
        Me.InputButton2 = New C1.Win.C1InputPanel.InputButton()
        Me.SaveRecordButton = New C1.Win.C1InputPanel.InputButton()
        Me.InputButton4 = New C1.Win.C1InputPanel.InputButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.C1FlexGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(54, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(310, 15)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "Displays the summary of onhand inventory transactions..."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(54, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(199, 20)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Inventory Transaction Details"
        '
        'C1FlexGrid1
        '
        Me.C1FlexGrid1.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.C1FlexGrid1.AllowEditing = False
        Me.C1FlexGrid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1FlexGrid1.AutoResize = True
        Me.C1FlexGrid1.BackColor = System.Drawing.Color.White
        Me.C1FlexGrid1.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
        Me.C1FlexGrid1.ColumnInfo = resources.GetString("C1FlexGrid1.ColumnInfo")
        Me.C1FlexGrid1.ExtendLastCol = True
        Me.C1FlexGrid1.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
        Me.C1FlexGrid1.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.C1FlexGrid1.ForeColor = System.Drawing.Color.Black
        Me.C1FlexGrid1.IgnoreDiacritics = True
        Me.C1FlexGrid1.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.None
        Me.C1FlexGrid1.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.C1FlexGrid1.Location = New System.Drawing.Point(10, 118)
        Me.C1FlexGrid1.Name = "C1FlexGrid1"
        Me.C1FlexGrid1.Rows.Count = 1
        Me.C1FlexGrid1.Rows.DefaultSize = 19
        Me.C1FlexGrid1.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.C1FlexGrid1.ShowCursor = True
        Me.C1FlexGrid1.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.None
        Me.C1FlexGrid1.Size = New System.Drawing.Size(1162, 419)
        Me.C1FlexGrid1.StyleInfo = resources.GetString("C1FlexGrid1.StyleInfo")
        Me.C1FlexGrid1.TabIndex = 51
        Me.C1FlexGrid1.Tree.Style = CType(((C1.Win.C1FlexGrid.TreeStyleFlags.Lines Or C1.Win.C1FlexGrid.TreeStyleFlags.Symbols) _
            Or C1.Win.C1FlexGrid.TreeStyleFlags.Leaf), C1.Win.C1FlexGrid.TreeStyleFlags)
        Me.C1FlexGrid1.UseCompatibleTextRendering = False
        Me.C1FlexGrid1.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.System
        '
        'C1InputPanel2
        '
        Me.C1InputPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1InputPanel2.BackColor = System.Drawing.SystemColors.Control
        Me.C1InputPanel2.BorderThickness = 1
        Me.C1InputPanel2.ChildSpacing = New System.Drawing.Size(4, 3)
        Me.C1InputPanel2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1InputPanel2.Items.Add(Me.InputGroupHeader1)
        Me.C1InputPanel2.Items.Add(Me.SaveRecordButton)
        Me.C1InputPanel2.Items.Add(Me.InputButton4)
        Me.C1InputPanel2.Location = New System.Drawing.Point(10, 543)
        Me.C1InputPanel2.Name = "C1InputPanel2"
        Me.C1InputPanel2.Padding = New System.Windows.Forms.Padding(5)
        Me.C1InputPanel2.Size = New System.Drawing.Size(1162, 68)
        Me.C1InputPanel2.TabIndex = 64
        Me.C1InputPanel2.VisualStyle = C1.Win.C1InputPanel.VisualStyle.System
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Height = 23
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        Me.InputGroupHeader1.Text = "Actions and Commands"
        '
        'C1InputPanel3
        '
        Me.C1InputPanel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1InputPanel3.BackColor = System.Drawing.SystemColors.Control
        Me.C1InputPanel3.BorderThickness = 1
        Me.C1InputPanel3.ChildSpacing = New System.Drawing.Size(0, 2)
        Me.C1InputPanel3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1InputPanel3.GroupIndent = 0
        Me.C1InputPanel3.Items.Add(Me.InputGroupHeader3)
        Me.C1InputPanel3.Items.Add(Me.InputLabel1)
        Me.C1InputPanel3.Items.Add(Me.DateFrom)
        Me.C1InputPanel3.Items.Add(Me.InputLabel11)
        Me.C1InputPanel3.Items.Add(Me.DateTo)
        Me.C1InputPanel3.Items.Add(Me.InputLabel3)
        Me.C1InputPanel3.Items.Add(Me.Branch)
        Me.C1InputPanel3.Items.Add(Me.InputLabel2)
        Me.C1InputPanel3.Items.Add(Me.Warehouse)
        Me.C1InputPanel3.Items.Add(Me.InputLabel12)
        Me.C1InputPanel3.Items.Add(Me.TransactionType)
        Me.C1InputPanel3.Items.Add(Me.InputLabel7)
        Me.C1InputPanel3.Items.Add(Me.ItemName)
        Me.C1InputPanel3.Items.Add(Me.InputLabel10)
        Me.C1InputPanel3.Items.Add(Me.WithOnHandOnly)
        Me.C1InputPanel3.Items.Add(Me.InputLabel8)
        Me.C1InputPanel3.Items.Add(Me.SearchButton)
        Me.C1InputPanel3.Items.Add(Me.InputLabel9)
        Me.C1InputPanel3.Items.Add(Me.InputButton2)
        Me.C1InputPanel3.Location = New System.Drawing.Point(10, 47)
        Me.C1InputPanel3.Name = "C1InputPanel3"
        Me.C1InputPanel3.Padding = New System.Windows.Forms.Padding(5)
        Me.C1InputPanel3.Size = New System.Drawing.Size(1162, 84)
        Me.C1InputPanel3.TabIndex = 65
        Me.C1InputPanel3.VisualStyle = C1.Win.C1InputPanel.VisualStyle.System
        '
        'InputGroupHeader3
        '
        Me.InputGroupHeader3.Height = 22
        Me.InputGroupHeader3.Name = "InputGroupHeader3"
        Me.InputGroupHeader3.Text = "Filter Inventory"
        '
        'InputLabel1
        '
        Me.InputLabel1.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel1.Name = "InputLabel1"
        Me.InputLabel1.Text = "Date From:"
        '
        'DateFrom
        '
        Me.DateFrom.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.DateFrom.Name = "DateFrom"
        Me.DateFrom.Width = 93
        '
        'InputLabel11
        '
        Me.InputLabel11.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel11.Name = "InputLabel11"
        Me.InputLabel11.Text = "Date To:"
        '
        'DateTo
        '
        Me.DateTo.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.DateTo.Name = "DateTo"
        Me.DateTo.Width = 82
        '
        'InputLabel2
        '
        Me.InputLabel2.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel2.Name = "InputLabel2"
        Me.InputLabel2.Text = "Source:"
        Me.InputLabel2.Width = 91
        '
        'Warehouse
        '
        Me.Warehouse.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.Warehouse.Name = "Warehouse"
        Me.Warehouse.Width = 103
        '
        'InputLabel12
        '
        Me.InputLabel12.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel12.Name = "InputLabel12"
        Me.InputLabel12.Text = "Transaction Type:"
        Me.InputLabel12.Width = 91
        '
        'TransactionType
        '
        Me.TransactionType.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.TransactionType.Items.Add(Me.InputOption5)
        Me.TransactionType.Items.Add(Me.InputOption6)
        Me.TransactionType.Items.Add(Me.InputOption7)
        Me.TransactionType.Items.Add(Me.InputOption8)
        Me.TransactionType.Items.Add(Me.InputOption9)
        Me.TransactionType.Name = "TransactionType"
        Me.TransactionType.Width = 103
        '
        'InputOption5
        '
        Me.InputOption5.Name = "InputOption5"
        Me.InputOption5.Text = "Item Setup"
        '
        'InputOption6
        '
        Me.InputOption6.Name = "InputOption6"
        Me.InputOption6.Text = "Material Issuance"
        '
        'InputOption7
        '
        Me.InputOption7.Name = "InputOption7"
        Me.InputOption7.Text = "Adjustment"
        '
        'InputOption8
        '
        Me.InputOption8.Name = "InputOption8"
        Me.InputOption8.Text = "Releasing"
        '
        'InputOption9
        '
        Me.InputOption9.Name = "InputOption9"
        Me.InputOption9.Text = "Receiving Report"
        '
        'InputLabel7
        '
        Me.InputLabel7.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel7.Name = "InputLabel7"
        Me.InputLabel7.Text = "Item Name / Description"
        '
        'ItemName
        '
        Me.ItemName.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.ItemName.Name = "ItemName"
        Me.ItemName.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.ItemName.Width = 191
        '
        'InputLabel10
        '
        Me.InputLabel10.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel10.Name = "InputLabel10"
        '
        'WithOnHandOnly
        '
        Me.WithOnHandOnly.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.WithOnHandOnly.CheckState = System.Windows.Forms.CheckState.Indeterminate
        Me.WithOnHandOnly.Height = 23
        Me.WithOnHandOnly.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.WithOnHandOnly.Name = "WithOnHandOnly"
        Me.WithOnHandOnly.Padding = New System.Windows.Forms.Padding(0, 2, 2, 2)
        Me.WithOnHandOnly.Text = "    w/ Onhand Only"
        Me.WithOnHandOnly.ThreeState = True
        Me.WithOnHandOnly.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        Me.WithOnHandOnly.Width = 2
        '
        'InputLabel8
        '
        Me.InputLabel8.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel8.Name = "InputLabel8"
        '
        'InputLabel9
        '
        Me.InputLabel9.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel9.Name = "InputLabel9"
        '
        'InputLabel3
        '
        Me.InputLabel3.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel3.Name = "InputLabel3"
        Me.InputLabel3.Text = "Branch / Site:"
        '
        'Branch
        '
        Me.Branch.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.Branch.Name = "Branch"
        '
        'SearchButton
        '
        Me.SearchButton.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.SearchButton.Height = 23
        Me.SearchButton.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.SearchButton.Image = Global.BakeTechSoftware.My.Resources.Resources.coin_stack_silver_share__1_
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Width = 23
        '
        'InputButton2
        '
        Me.InputButton2.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.InputButton2.Height = 23
        Me.InputButton2.Image = Global.BakeTechSoftware.My.Resources.Resources.reload__1_
        Me.InputButton2.Name = "InputButton2"
        '
        'SaveRecordButton
        '
        Me.SaveRecordButton.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.SaveRecordButton.Image = Global.BakeTechSoftware.My.Resources.Resources.SaveAllHS
        Me.SaveRecordButton.Name = "SaveRecordButton"
        Me.SaveRecordButton.Text = "Export Details"
        Me.SaveRecordButton.Width = 119
        '
        'InputButton4
        '
        Me.InputButton4.Image = Global.BakeTechSoftware.My.Resources.Resources.no
        Me.InputButton4.Name = "InputButton4"
        Me.InputButton4.Text = "Close"
        Me.InputButton4.Width = 74
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.BakeTechSoftware.My.Resources.Resources._1363082161_storage
        Me.PictureBox1.Location = New System.Drawing.Point(10, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 32)
        Me.PictureBox1.TabIndex = 60
        Me.PictureBox1.TabStop = False
        '
        'Inventory_Transactions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1174, 622)
        Me.Controls.Add(Me.C1FlexGrid1)
        Me.Controls.Add(Me.C1InputPanel3)
        Me.Controls.Add(Me.C1InputPanel2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1105, 660)
        Me.Name = "Inventory_Transactions"
        Me.Text = "Inventory Transaction Register"
        CType(Me.C1FlexGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Public WithEvents C1FlexGrid1 As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents C1InputPanel2 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents SaveRecordButton As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputButton4 As C1.Win.C1InputPanel.InputButton
    Friend WithEvents C1InputPanel3 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader3 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputLabel1 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents DateFrom As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents InputLabel11 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents DateTo As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents InputLabel2 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents Warehouse As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents InputLabel7 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents ItemName As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel10 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents WithOnHandOnly As C1.Win.C1InputPanel.InputCheckBox
    Friend WithEvents InputLabel8 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents SearchButton As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputLabel9 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputButton2 As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputLabel12 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents TransactionType As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents InputOption5 As C1.Win.C1InputPanel.InputOption
    Friend WithEvents InputOption6 As C1.Win.C1InputPanel.InputOption
    Friend WithEvents InputOption7 As C1.Win.C1InputPanel.InputOption
    Friend WithEvents InputOption8 As C1.Win.C1InputPanel.InputOption
    Friend WithEvents InputOption9 As C1.Win.C1InputPanel.InputOption
    Friend WithEvents InputLabel3 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents Branch As C1.Win.C1InputPanel.InputComboBox
End Class
