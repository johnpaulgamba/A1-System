<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class salesreturnentry
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(salesreturnentry))
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel1 = New C1.Win.C1InputPanel.InputLabel()
        Me.SOReference = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel2 = New C1.Win.C1InputPanel.InputLabel()
        Me.DateOrdered = New C1.Win.C1InputPanel.InputDatePicker()
        Me.InputLabel3 = New C1.Win.C1InputPanel.InputLabel()
        Me.DeliveryDate = New C1.Win.C1InputPanel.InputDatePicker()
        Me.InputLabel12 = New C1.Win.C1InputPanel.InputLabel()
        Me.Remarks = New C1.Win.C1InputPanel.InputTextBox()
        Me.C1InputPanel2 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader2 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel6 = New C1.Win.C1InputPanel.InputLabel()
        Me.CustomerName = New C1.Win.C1InputPanel.InputComboBox()
        Me.InputLabel7 = New C1.Win.C1InputPanel.InputLabel()
        Me.Address = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel8 = New C1.Win.C1InputPanel.InputLabel()
        Me.BusinessType = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel9 = New C1.Win.C1InputPanel.InputLabel()
        Me.TIN = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel11 = New C1.Win.C1InputPanel.InputLabel()
        Me.ContactNo = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputTextBox4 = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel10 = New C1.Win.C1InputPanel.InputLabel()
        Me.C1FlexGrid1 = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1InputPanel3 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader3 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.SaveRecord = New C1.Win.C1InputPanel.InputButton()
        Me.InputButton3 = New C1.Win.C1InputPanel.InputButton()
        Me.InputButton2 = New C1.Win.C1InputPanel.InputButton()
        Me.InputButton4 = New C1.Win.C1InputPanel.InputButton()
        Me.C1InputPanel4 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputLabel13 = New C1.Win.C1InputPanel.InputLabel()
        Me.GrossAmount = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel14 = New C1.Win.C1InputPanel.InputLabel()
        Me.VATAmount = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel15 = New C1.Win.C1InputPanel.InputLabel()
        Me.NetSalesAmount = New C1.Win.C1InputPanel.InputLabel()
        Me.C1InputPanel5 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader4 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel16 = New C1.Win.C1InputPanel.InputLabel()
        Me.SRReference = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel17 = New C1.Win.C1InputPanel.InputLabel()
        Me.ReturnDate = New C1.Win.C1InputPanel.InputDatePicker()
        Me.InputLabel4 = New C1.Win.C1InputPanel.InputLabel()
        Me.BranchName = New C1.Win.C1InputPanel.InputComboBox()
        Me.InputLabel5 = New C1.Win.C1InputPanel.InputLabel()
        Me.WarehouseName = New C1.Win.C1InputPanel.InputComboBox()
        Me.C1InputPanel6 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputLabel18 = New C1.Win.C1InputPanel.InputLabel()
        Me.FilterSOReference = New C1.Win.C1InputPanel.InputTextBox()
        Me.LoadDataButton = New C1.Win.C1InputPanel.InputButton()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1FlexGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.BorderThickness = 1
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader1)
        Me.C1InputPanel1.Items.Add(Me.InputLabel1)
        Me.C1InputPanel1.Items.Add(Me.SOReference)
        Me.C1InputPanel1.Items.Add(Me.InputLabel2)
        Me.C1InputPanel1.Items.Add(Me.DateOrdered)
        Me.C1InputPanel1.Items.Add(Me.InputLabel3)
        Me.C1InputPanel1.Items.Add(Me.DeliveryDate)
        Me.C1InputPanel1.Items.Add(Me.InputLabel12)
        Me.C1InputPanel1.Items.Add(Me.Remarks)
        Me.C1InputPanel1.Location = New System.Drawing.Point(255, 49)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Padding = New System.Windows.Forms.Padding(5)
        Me.C1InputPanel1.ReadOnly = True
        Me.C1InputPanel1.Size = New System.Drawing.Size(234, 135)
        Me.C1InputPanel1.TabIndex = 1
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Height = 20
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        Me.InputGroupHeader1.Text = "Order Details"
        '
        'InputLabel1
        '
        Me.InputLabel1.Name = "InputLabel1"
        Me.InputLabel1.Text = "SO Reference:"
        Me.InputLabel1.Width = 82
        '
        'SOReference
        '
        Me.SOReference.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SOReference.Name = "SOReference"
        Me.SOReference.ReadOnly = True
        Me.SOReference.Width = 118
        '
        'InputLabel2
        '
        Me.InputLabel2.Name = "InputLabel2"
        Me.InputLabel2.Text = "Date Ordered:"
        Me.InputLabel2.Width = 82
        '
        'DateOrdered
        '
        Me.DateOrdered.Name = "DateOrdered"
        Me.DateOrdered.ReadOnly = True
        Me.DateOrdered.Width = 118
        '
        'InputLabel3
        '
        Me.InputLabel3.Name = "InputLabel3"
        Me.InputLabel3.Text = "Delivery Date:"
        Me.InputLabel3.Width = 82
        '
        'DeliveryDate
        '
        Me.DeliveryDate.Name = "DeliveryDate"
        Me.DeliveryDate.Width = 118
        '
        'InputLabel12
        '
        Me.InputLabel12.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Near
        Me.InputLabel12.Name = "InputLabel12"
        Me.InputLabel12.Text = "Remarks: "
        Me.InputLabel12.Width = 58
        '
        'Remarks
        '
        Me.Remarks.Name = "Remarks"
        Me.Remarks.Width = 142
        '
        'C1InputPanel2
        '
        Me.C1InputPanel2.BorderThickness = 1
        Me.C1InputPanel2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1InputPanel2.Items.Add(Me.InputGroupHeader2)
        Me.C1InputPanel2.Items.Add(Me.InputLabel6)
        Me.C1InputPanel2.Items.Add(Me.CustomerName)
        Me.C1InputPanel2.Items.Add(Me.InputLabel7)
        Me.C1InputPanel2.Items.Add(Me.Address)
        Me.C1InputPanel2.Items.Add(Me.InputLabel8)
        Me.C1InputPanel2.Items.Add(Me.BusinessType)
        Me.C1InputPanel2.Items.Add(Me.InputLabel9)
        Me.C1InputPanel2.Items.Add(Me.TIN)
        Me.C1InputPanel2.Items.Add(Me.InputLabel11)
        Me.C1InputPanel2.Items.Add(Me.ContactNo)
        Me.C1InputPanel2.Location = New System.Drawing.Point(495, 49)
        Me.C1InputPanel2.Name = "C1InputPanel2"
        Me.C1InputPanel2.Padding = New System.Windows.Forms.Padding(5)
        Me.C1InputPanel2.ReadOnly = True
        Me.C1InputPanel2.Size = New System.Drawing.Size(536, 135)
        Me.C1InputPanel2.TabIndex = 2
        '
        'InputGroupHeader2
        '
        Me.InputGroupHeader2.Height = 20
        Me.InputGroupHeader2.Name = "InputGroupHeader2"
        Me.InputGroupHeader2.Text = "Customer Details"
        '
        'InputLabel6
        '
        Me.InputLabel6.Name = "InputLabel6"
        Me.InputLabel6.Text = "Customer:"
        Me.InputLabel6.Width = 82
        '
        'CustomerName
        '
        Me.CustomerName.Name = "CustomerName"
        Me.CustomerName.Width = 420
        '
        'InputLabel7
        '
        Me.InputLabel7.Name = "InputLabel7"
        Me.InputLabel7.Text = "Address:"
        Me.InputLabel7.Width = 82
        '
        'Address
        '
        Me.Address.Height = 22
        Me.Address.Name = "Address"
        Me.Address.ReadOnly = True
        Me.Address.Width = 421
        '
        'InputLabel8
        '
        Me.InputLabel8.Name = "InputLabel8"
        Me.InputLabel8.Text = "Business Type:"
        Me.InputLabel8.Width = 82
        '
        'BusinessType
        '
        Me.BusinessType.Break = C1.Win.C1InputPanel.BreakType.None
        Me.BusinessType.Name = "BusinessType"
        Me.BusinessType.ReadOnly = True
        Me.BusinessType.Width = 208
        '
        'InputLabel9
        '
        Me.InputLabel9.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel9.Name = "InputLabel9"
        Me.InputLabel9.Text = "Tax ID No:"
        Me.InputLabel9.Width = 58
        '
        'TIN
        '
        Me.TIN.Name = "TIN"
        Me.TIN.ReadOnly = True
        Me.TIN.Width = 148
        '
        'InputLabel11
        '
        Me.InputLabel11.Name = "InputLabel11"
        Me.InputLabel11.Text = "Contact No:"
        Me.InputLabel11.Width = 82
        '
        'ContactNo
        '
        Me.ContactNo.Break = C1.Win.C1InputPanel.BreakType.None
        Me.ContactNo.Name = "ContactNo"
        Me.ContactNo.ReadOnly = True
        Me.ContactNo.Width = 422
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
        Me.C1FlexGrid1.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.C1FlexGrid1.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
        Me.C1FlexGrid1.ColumnInfo = resources.GetString("C1FlexGrid1.ColumnInfo")
        Me.C1FlexGrid1.ExtendLastCol = True
        Me.C1FlexGrid1.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
        Me.C1FlexGrid1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.C1FlexGrid1.Location = New System.Drawing.Point(12, 190)
        Me.C1FlexGrid1.Name = "C1FlexGrid1"
        Me.C1FlexGrid1.Rows.Count = 1
        Me.C1FlexGrid1.Rows.DefaultSize = 20
        Me.C1FlexGrid1.Size = New System.Drawing.Size(1019, 255)
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
        Me.C1InputPanel3.Location = New System.Drawing.Point(12, 489)
        Me.C1InputPanel3.Name = "C1InputPanel3"
        Me.C1InputPanel3.Padding = New System.Windows.Forms.Padding(5)
        Me.C1InputPanel3.Size = New System.Drawing.Size(1019, 65)
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
        Me.SaveRecord.Image = Global.A1plus.My.Resources.Resources.SaveAllHS
        Me.SaveRecord.Name = "SaveRecord"
        Me.SaveRecord.Text = "&Save Record"
        '
        'InputButton3
        '
        Me.InputButton3.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.InputButton3.Image = Global.A1plus.My.Resources.Resources.documents_new
        Me.InputButton3.Name = "InputButton3"
        Me.InputButton3.Text = "&New Return"
        '
        'InputButton2
        '
        Me.InputButton2.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.InputButton2.Image = Global.A1plus.My.Resources.Resources.printer_go
        Me.InputButton2.Name = "InputButton2"
        Me.InputButton2.Text = "&Print Return"
        '
        'InputButton4
        '
        Me.InputButton4.Image = Global.A1plus.My.Resources.Resources.no
        Me.InputButton4.Name = "InputButton4"
        Me.InputButton4.Text = "&Close"
        '
        'C1InputPanel4
        '
        Me.C1InputPanel4.BorderThickness = 1
        Me.C1InputPanel4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1InputPanel4.Items.Add(Me.InputLabel13)
        Me.C1InputPanel4.Items.Add(Me.GrossAmount)
        Me.C1InputPanel4.Items.Add(Me.InputLabel14)
        Me.C1InputPanel4.Items.Add(Me.VATAmount)
        Me.C1InputPanel4.Items.Add(Me.InputLabel15)
        Me.C1InputPanel4.Items.Add(Me.NetSalesAmount)
        Me.C1InputPanel4.Location = New System.Drawing.Point(12, 444)
        Me.C1InputPanel4.Name = "C1InputPanel4"
        Me.C1InputPanel4.Padding = New System.Windows.Forms.Padding(5)
        Me.C1InputPanel4.Size = New System.Drawing.Size(1019, 33)
        Me.C1InputPanel4.TabIndex = 5
        '
        'InputLabel13
        '
        Me.InputLabel13.Name = "InputLabel13"
        Me.InputLabel13.Text = "Total Gross (Vat Inc):"
        '
        'GrossAmount
        '
        Me.GrossAmount.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.GrossAmount.Font = New System.Drawing.Font("Segoe UI", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrossAmount.Name = "GrossAmount"
        Me.GrossAmount.Text = "PHP 0.00"
        '
        'InputLabel14
        '
        Me.InputLabel14.Name = "InputLabel14"
        Me.InputLabel14.Text = "VAT Amt:"
        '
        'VATAmount
        '
        Me.VATAmount.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.VATAmount.Font = New System.Drawing.Font("Segoe UI", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VATAmount.Name = "VATAmount"
        Me.VATAmount.Text = "PHP 0.00"
        '
        'InputLabel15
        '
        Me.InputLabel15.Name = "InputLabel15"
        Me.InputLabel15.Text = "Net Sales:"
        '
        'NetSalesAmount
        '
        Me.NetSalesAmount.Font = New System.Drawing.Font("Segoe UI", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NetSalesAmount.Name = "NetSalesAmount"
        Me.NetSalesAmount.Text = "PHP 0.00"
        '
        'C1InputPanel5
        '
        Me.C1InputPanel5.BorderThickness = 1
        Me.C1InputPanel5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1InputPanel5.Items.Add(Me.InputGroupHeader4)
        Me.C1InputPanel5.Items.Add(Me.InputLabel16)
        Me.C1InputPanel5.Items.Add(Me.SRReference)
        Me.C1InputPanel5.Items.Add(Me.InputLabel17)
        Me.C1InputPanel5.Items.Add(Me.ReturnDate)
        Me.C1InputPanel5.Items.Add(Me.InputLabel4)
        Me.C1InputPanel5.Items.Add(Me.BranchName)
        Me.C1InputPanel5.Items.Add(Me.InputLabel5)
        Me.C1InputPanel5.Items.Add(Me.WarehouseName)
        Me.C1InputPanel5.Location = New System.Drawing.Point(12, 49)
        Me.C1InputPanel5.Name = "C1InputPanel5"
        Me.C1InputPanel5.Padding = New System.Windows.Forms.Padding(5)
        Me.C1InputPanel5.Size = New System.Drawing.Size(234, 135)
        Me.C1InputPanel5.TabIndex = 6
        '
        'InputGroupHeader4
        '
        Me.InputGroupHeader4.Height = 20
        Me.InputGroupHeader4.Name = "InputGroupHeader4"
        Me.InputGroupHeader4.Text = "Sales Return Details"
        '
        'InputLabel16
        '
        Me.InputLabel16.Name = "InputLabel16"
        Me.InputLabel16.Text = "SR Reference:"
        Me.InputLabel16.Width = 82
        '
        'SRReference
        '
        Me.SRReference.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SRReference.Name = "SRReference"
        Me.SRReference.ReadOnly = True
        Me.SRReference.Width = 118
        '
        'InputLabel17
        '
        Me.InputLabel17.Name = "InputLabel17"
        Me.InputLabel17.Text = "Return Date:"
        Me.InputLabel17.Width = 82
        '
        'ReturnDate
        '
        Me.ReturnDate.Name = "ReturnDate"
        Me.ReturnDate.Width = 118
        '
        'InputLabel4
        '
        Me.InputLabel4.Name = "InputLabel4"
        Me.InputLabel4.Text = "Branch:"
        Me.InputLabel4.Width = 82
        '
        'BranchName
        '
        Me.BranchName.Name = "BranchName"
        Me.BranchName.Width = 118
        '
        'InputLabel5
        '
        Me.InputLabel5.Name = "InputLabel5"
        Me.InputLabel5.Text = "Warehouse:"
        Me.InputLabel5.Width = 82
        '
        'WarehouseName
        '
        Me.WarehouseName.Name = "WarehouseName"
        Me.WarehouseName.Width = 118
        '
        'C1InputPanel6
        '
        Me.C1InputPanel6.BorderThickness = 1
        Me.C1InputPanel6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1InputPanel6.Items.Add(Me.InputLabel18)
        Me.C1InputPanel6.Items.Add(Me.FilterSOReference)
        Me.C1InputPanel6.Items.Add(Me.LoadDataButton)
        Me.C1InputPanel6.Location = New System.Drawing.Point(12, 12)
        Me.C1InputPanel6.Name = "C1InputPanel6"
        Me.C1InputPanel6.Padding = New System.Windows.Forms.Padding(5)
        Me.C1InputPanel6.Size = New System.Drawing.Size(1019, 465)
        Me.C1InputPanel6.TabIndex = 7
        '
        'InputLabel18
        '
        Me.InputLabel18.Name = "InputLabel18"
        Me.InputLabel18.Text = "Enter S/O #:"
        Me.InputLabel18.Width = 82
        '
        'FilterSOReference
        '
        Me.FilterSOReference.Break = C1.Win.C1InputPanel.BreakType.None
        Me.FilterSOReference.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FilterSOReference.Name = "FilterSOReference"
        Me.FilterSOReference.Width = 118
        '
        'LoadDataButton
        '
        Me.LoadDataButton.Image = Global.A1plus.My.Resources.Resources.coin_stack_silver_share__1_
        Me.LoadDataButton.Name = "LoadDataButton"
        Me.LoadDataButton.Text = "Load Data"
        '
        'salesreturnentry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1040, 566)
        Me.Controls.Add(Me.C1InputPanel5)
        Me.Controls.Add(Me.C1InputPanel3)
        Me.Controls.Add(Me.C1FlexGrid1)
        Me.Controls.Add(Me.C1InputPanel2)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.Controls.Add(Me.C1InputPanel4)
        Me.Controls.Add(Me.C1InputPanel6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "salesreturnentry"
        Me.Text = "Sales Return"
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1FlexGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputLabel1 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents SOReference As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel2 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents DateOrdered As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents InputLabel3 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents DeliveryDate As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents C1InputPanel2 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader2 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputLabel6 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents CustomerName As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents InputLabel7 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents Address As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel8 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents BusinessType As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel9 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents TIN As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel11 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents ContactNo As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputTextBox4 As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel10 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents C1FlexGrid1 As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents C1InputPanel3 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader3 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents SaveRecord As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputButton2 As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputButton3 As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputButton4 As C1.Win.C1InputPanel.InputButton
    Friend WithEvents C1InputPanel4 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputLabel13 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents GrossAmount As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel14 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents VATAmount As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel15 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents NetSalesAmount As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents C1InputPanel5 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader4 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputLabel16 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents SRReference As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel17 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents ReturnDate As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents InputLabel12 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents Remarks As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel4 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents BranchName As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents InputLabel5 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents WarehouseName As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents C1InputPanel6 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputLabel18 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents FilterSOReference As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents LoadDataButton As C1.Win.C1InputPanel.InputButton
End Class
