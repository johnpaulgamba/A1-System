<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inventory_transfer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(inventory_transfer))
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel1 = New C1.Win.C1InputPanel.InputLabel()
        Me.TRReference = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel2 = New C1.Win.C1InputPanel.InputLabel()
        Me.TransferDate = New C1.Win.C1InputPanel.InputDatePicker()
        Me.InputLabel7 = New C1.Win.C1InputPanel.InputLabel()
        Me.ShippingName = New C1.Win.C1InputPanel.InputComboBox()
        Me.InputLabel8 = New C1.Win.C1InputPanel.InputLabel()
        Me.Cost = New C1.Win.C1InputPanel.InputNumericBox()
        Me.C1InputPanel2 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader2 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel4 = New C1.Win.C1InputPanel.InputLabel()
        Me.BranchFrom = New C1.Win.C1InputPanel.InputComboBox()
        Me.InputLabel3 = New C1.Win.C1InputPanel.InputLabel()
        Me.BranchTo = New C1.Win.C1InputPanel.InputComboBox()
        Me.InputLabel5 = New C1.Win.C1InputPanel.InputLabel()
        Me.WarehouseFrom = New C1.Win.C1InputPanel.InputComboBox()
        Me.InputLabel6 = New C1.Win.C1InputPanel.InputLabel()
        Me.WarehouseTo = New C1.Win.C1InputPanel.InputComboBox()
        Me.InputLabel12 = New C1.Win.C1InputPanel.InputLabel()
        Me.Remarks = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputTextBox4 = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel10 = New C1.Win.C1InputPanel.InputLabel()
        Me.C1FlexGrid1 = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1InputPanel3 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader3 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.SaveRecord = New C1.Win.C1InputPanel.InputButton()
        Me.InputButton3 = New C1.Win.C1InputPanel.InputButton()
        Me.InputButton2 = New C1.Win.C1InputPanel.InputButton()
        Me.InputButton4 = New C1.Win.C1InputPanel.InputButton()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1FlexGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.BorderThickness = 1
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader1)
        Me.C1InputPanel1.Items.Add(Me.InputLabel1)
        Me.C1InputPanel1.Items.Add(Me.TRReference)
        Me.C1InputPanel1.Items.Add(Me.InputLabel2)
        Me.C1InputPanel1.Items.Add(Me.TransferDate)
        Me.C1InputPanel1.Items.Add(Me.InputLabel7)
        Me.C1InputPanel1.Items.Add(Me.ShippingName)
        Me.C1InputPanel1.Items.Add(Me.InputLabel8)
        Me.C1InputPanel1.Items.Add(Me.Cost)
        Me.C1InputPanel1.Location = New System.Drawing.Point(12, 13)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Padding = New System.Windows.Forms.Padding(5)
        Me.C1InputPanel1.Size = New System.Drawing.Size(295, 138)
        Me.C1InputPanel1.TabIndex = 1
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Height = 20
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        Me.InputGroupHeader1.Text = "Transfer Details"
        '
        'InputLabel1
        '
        Me.InputLabel1.Name = "InputLabel1"
        Me.InputLabel1.Text = "TR Reference:"
        Me.InputLabel1.Width = 82
        '
        'TRReference
        '
        Me.TRReference.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TRReference.Name = "TRReference"
        Me.TRReference.ReadOnly = True
        Me.TRReference.Width = 181
        '
        'InputLabel2
        '
        Me.InputLabel2.Name = "InputLabel2"
        Me.InputLabel2.Text = "Transfer Date:"
        Me.InputLabel2.Width = 82
        '
        'TransferDate
        '
        Me.TransferDate.Name = "TransferDate"
        Me.TransferDate.Width = 181
        '
        'InputLabel7
        '
        Me.InputLabel7.Name = "InputLabel7"
        Me.InputLabel7.Text = "Delivered By:"
        Me.InputLabel7.Width = 82
        '
        'ShippingName
        '
        Me.ShippingName.Name = "ShippingName"
        Me.ShippingName.Width = 181
        '
        'InputLabel8
        '
        Me.InputLabel8.Name = "InputLabel8"
        Me.InputLabel8.Text = "Delivery Cost:"
        Me.InputLabel8.Width = 82
        '
        'Cost
        '
        Me.Cost.Format = "n2"
        Me.Cost.Maximum = New Decimal(New Integer() {276447231, 23283, 0, 0})
        Me.Cost.Name = "Cost"
        Me.Cost.ShowSpinButtons = False
        Me.Cost.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Cost.Width = 181
        '
        'C1InputPanel2
        '
        Me.C1InputPanel2.BorderThickness = 1
        Me.C1InputPanel2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1InputPanel2.Items.Add(Me.InputGroupHeader2)
        Me.C1InputPanel2.Items.Add(Me.InputLabel4)
        Me.C1InputPanel2.Items.Add(Me.BranchFrom)
        Me.C1InputPanel2.Items.Add(Me.InputLabel3)
        Me.C1InputPanel2.Items.Add(Me.BranchTo)
        Me.C1InputPanel2.Items.Add(Me.InputLabel5)
        Me.C1InputPanel2.Items.Add(Me.WarehouseFrom)
        Me.C1InputPanel2.Items.Add(Me.InputLabel6)
        Me.C1InputPanel2.Items.Add(Me.WarehouseTo)
        Me.C1InputPanel2.Items.Add(Me.InputLabel12)
        Me.C1InputPanel2.Items.Add(Me.Remarks)
        Me.C1InputPanel2.Location = New System.Drawing.Point(313, 13)
        Me.C1InputPanel2.Name = "C1InputPanel2"
        Me.C1InputPanel2.Padding = New System.Windows.Forms.Padding(5)
        Me.C1InputPanel2.Size = New System.Drawing.Size(700, 138)
        Me.C1InputPanel2.TabIndex = 2
        '
        'InputGroupHeader2
        '
        Me.InputGroupHeader2.Height = 20
        Me.InputGroupHeader2.Name = "InputGroupHeader2"
        Me.InputGroupHeader2.Text = "Location and  Sources"
        '
        'InputLabel4
        '
        Me.InputLabel4.Name = "InputLabel4"
        Me.InputLabel4.Text = "Branch From:"
        Me.InputLabel4.Width = 95
        '
        'BranchFrom
        '
        Me.BranchFrom.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.BranchFrom.Name = "BranchFrom"
        Me.BranchFrom.Width = 213
        '
        'InputLabel3
        '
        Me.InputLabel3.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel3.Name = "InputLabel3"
        Me.InputLabel3.Text = "Branch To:"
        Me.InputLabel3.Width = 122
        '
        'BranchTo
        '
        Me.BranchTo.Break = C1.Win.C1InputPanel.BreakType.Group
        Me.BranchTo.Name = "BranchTo"
        Me.BranchTo.Width = 213
        '
        'InputLabel5
        '
        Me.InputLabel5.Name = "InputLabel5"
        Me.InputLabel5.Text = "Warehouse From:"
        Me.InputLabel5.Width = 95
        '
        'WarehouseFrom
        '
        Me.WarehouseFrom.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.WarehouseFrom.Name = "WarehouseFrom"
        Me.WarehouseFrom.Width = 213
        '
        'InputLabel6
        '
        Me.InputLabel6.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel6.Name = "InputLabel6"
        Me.InputLabel6.Text = "Warehouse To:"
        Me.InputLabel6.Width = 122
        '
        'WarehouseTo
        '
        Me.WarehouseTo.Break = C1.Win.C1InputPanel.BreakType.Group
        Me.WarehouseTo.Name = "WarehouseTo"
        Me.WarehouseTo.Width = 213
        '
        'InputLabel12
        '
        Me.InputLabel12.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Near
        Me.InputLabel12.Name = "InputLabel12"
        Me.InputLabel12.Text = "Remarks:"
        Me.InputLabel12.Width = 95
        '
        'Remarks
        '
        Me.Remarks.Height = 42
        Me.Remarks.Multiline = True
        Me.Remarks.Name = "Remarks"
        Me.Remarks.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Spread
        Me.Remarks.Width = 566
        '
        'InputTextBox4
        '
        Me.InputTextBox4.Name = "InputTextBox4"
        '
        'InputLabel10
        '
        Me.InputLabel10.Name = "InputLabel10"
        Me.InputLabel10.Text = "Warehouse:"
        Me.InputLabel10.Width = 82
        '
        'C1FlexGrid1
        '
        Me.C1FlexGrid1.AllowAddNew = True
        Me.C1FlexGrid1.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.C1FlexGrid1.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
        Me.C1FlexGrid1.ColumnInfo = resources.GetString("C1FlexGrid1.ColumnInfo")
        Me.C1FlexGrid1.ExtendLastCol = True
        Me.C1FlexGrid1.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
        Me.C1FlexGrid1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.C1FlexGrid1.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.None
        Me.C1FlexGrid1.Location = New System.Drawing.Point(12, 157)
        Me.C1FlexGrid1.Name = "C1FlexGrid1"
        Me.C1FlexGrid1.Rows.Count = 10
        Me.C1FlexGrid1.Rows.DefaultSize = 20
        Me.C1FlexGrid1.Size = New System.Drawing.Size(1001, 319)
        Me.C1FlexGrid1.StyleInfo = resources.GetString("C1FlexGrid1.StyleInfo")
        Me.C1FlexGrid1.TabIndex = 3
        Me.C1FlexGrid1.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.System
        '
        'C1InputPanel3
        '
        Me.C1InputPanel3.BorderThickness = 1
        Me.C1InputPanel3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1InputPanel3.Items.Add(Me.InputGroupHeader3)
        Me.C1InputPanel3.Items.Add(Me.SaveRecord)
        Me.C1InputPanel3.Items.Add(Me.InputButton3)
        Me.C1InputPanel3.Items.Add(Me.InputButton2)
        Me.C1InputPanel3.Items.Add(Me.InputButton4)
        Me.C1InputPanel3.Location = New System.Drawing.Point(12, 482)
        Me.C1InputPanel3.Name = "C1InputPanel3"
        Me.C1InputPanel3.Padding = New System.Windows.Forms.Padding(5)
        Me.C1InputPanel3.Size = New System.Drawing.Size(1001, 65)
        Me.C1InputPanel3.TabIndex = 4
        '
        'InputGroupHeader3
        '
        Me.InputGroupHeader3.Height = 24
        Me.InputGroupHeader3.Name = "InputGroupHeader3"
        Me.InputGroupHeader3.Text = "Actions and Commands"
        '
        'SaveRecord
        '
        Me.SaveRecord.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.SaveRecord.Image = Global.BakeTechSoftware.My.Resources.Resources.SaveAllHS
        Me.SaveRecord.Name = "SaveRecord"
        Me.SaveRecord.Text = "&Save Record"
        '
        'InputButton3
        '
        Me.InputButton3.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.InputButton3.Image = Global.BakeTechSoftware.My.Resources.Resources.documents_new
        Me.InputButton3.Name = "InputButton3"
        Me.InputButton3.Text = "&New Transfer"
        '
        'InputButton2
        '
        Me.InputButton2.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.InputButton2.Image = Global.BakeTechSoftware.My.Resources.Resources.printer_go
        Me.InputButton2.Name = "InputButton2"
        Me.InputButton2.Text = "&Print Transfer Slip"
        '
        'InputButton4
        '
        Me.InputButton4.Image = Global.BakeTechSoftware.My.Resources.Resources.no
        Me.InputButton4.Name = "InputButton4"
        Me.InputButton4.Text = "&Close"
        '
        'inventory_transfer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1020, 554)
        Me.Controls.Add(Me.C1FlexGrid1)
        Me.Controls.Add(Me.C1InputPanel3)
        Me.Controls.Add(Me.C1InputPanel2)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "inventory_transfer"
        Me.Text = "Inventory Transfer"
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1FlexGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputLabel1 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents TRReference As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel2 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents TransferDate As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents C1InputPanel2 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader2 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputTextBox4 As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel10 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents C1FlexGrid1 As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents C1InputPanel3 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader3 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents SaveRecord As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputButton2 As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputButton3 As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputButton4 As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputLabel12 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents Remarks As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel7 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents ShippingName As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents InputLabel8 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents Cost As C1.Win.C1InputPanel.InputNumericBox
    Friend WithEvents InputLabel4 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents BranchFrom As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents InputLabel3 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents BranchTo As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents InputLabel5 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents WarehouseFrom As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents InputLabel6 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents WarehouseTo As C1.Win.C1InputPanel.InputComboBox
End Class
