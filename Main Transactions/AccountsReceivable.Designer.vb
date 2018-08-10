<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccountsReceivable
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AccountsReceivable))
        Me.C1FlexGrid1 = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1InputPanel4 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputLabel13 = New C1.Win.C1InputPanel.InputLabel()
        Me.vatablesales = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel14 = New C1.Win.C1InputPanel.InputLabel()
        Me.VATAmount = New C1.Win.C1InputPanel.InputLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.C1InputPanel2 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader2 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel6 = New C1.Win.C1InputPanel.InputLabel()
        Me.CustomerName = New C1.Win.C1InputPanel.InputComboBox()
        Me.InputLabel9 = New C1.Win.C1InputPanel.InputLabel()
        Me.TIN = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel7 = New C1.Win.C1InputPanel.InputLabel()
        Me.Address = New C1.Win.C1InputPanel.InputTextBox()
        Me.C1InputPanel3 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader3 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputButton2 = New C1.Win.C1InputPanel.InputButton()
        Me.InputButton4 = New C1.Win.C1InputPanel.InputButton()
        Me.InputLabel1 = New C1.Win.C1InputPanel.InputLabel()
        Me.totalsales = New C1.Win.C1InputPanel.InputLabel()
        CType(Me.C1FlexGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1FlexGrid1
        '
        Me.C1FlexGrid1.AllowAddNew = True
        Me.C1FlexGrid1.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.C1FlexGrid1.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
        Me.C1FlexGrid1.ColumnInfo = resources.GetString("C1FlexGrid1.ColumnInfo")
        Me.C1FlexGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1FlexGrid1.ExtendLastCol = True
        Me.C1FlexGrid1.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
        Me.C1FlexGrid1.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.C1FlexGrid1.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.None
        Me.C1FlexGrid1.Location = New System.Drawing.Point(0, 154)
        Me.C1FlexGrid1.Name = "C1FlexGrid1"
        Me.C1FlexGrid1.Rows.Count = 10
        Me.C1FlexGrid1.Rows.DefaultSize = 25
        Me.C1FlexGrid1.Size = New System.Drawing.Size(865, 223)
        Me.C1FlexGrid1.StyleInfo = resources.GetString("C1FlexGrid1.StyleInfo")
        Me.C1FlexGrid1.TabIndex = 7
        Me.C1FlexGrid1.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2007Silver
        '
        'C1InputPanel4
        '
        Me.C1InputPanel4.BorderThickness = 1
        Me.C1InputPanel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.C1InputPanel4.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1InputPanel4.Items.Add(Me.InputLabel13)
        Me.C1InputPanel4.Items.Add(Me.vatablesales)
        Me.C1InputPanel4.Items.Add(Me.InputLabel14)
        Me.C1InputPanel4.Items.Add(Me.VATAmount)
        Me.C1InputPanel4.Items.Add(Me.InputLabel1)
        Me.C1InputPanel4.Items.Add(Me.totalsales)
        Me.C1InputPanel4.Location = New System.Drawing.Point(0, 377)
        Me.C1InputPanel4.Name = "C1InputPanel4"
        Me.C1InputPanel4.Padding = New System.Windows.Forms.Padding(5)
        Me.C1InputPanel4.Size = New System.Drawing.Size(865, 33)
        Me.C1InputPanel4.TabIndex = 9
        '
        'InputLabel13
        '
        Me.InputLabel13.Name = "InputLabel13"
        Me.InputLabel13.Text = "Vatable Sales"
        '
        'vatablesales
        '
        Me.vatablesales.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.vatablesales.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vatablesales.Name = "vatablesales"
        Me.vatablesales.Text = "PHP 0.00"
        '
        'InputLabel14
        '
        Me.InputLabel14.Name = "InputLabel14"
        Me.InputLabel14.Text = "VAT Amount"
        '
        'VATAmount
        '
        Me.VATAmount.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.VATAmount.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VATAmount.Name = "VATAmount"
        Me.VATAmount.Text = "PHP 0.00"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.C1InputPanel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(865, 154)
        Me.Panel1.TabIndex = 6
        '
        'C1InputPanel2
        '
        Me.C1InputPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1InputPanel2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1InputPanel2.Items.Add(Me.InputGroupHeader2)
        Me.C1InputPanel2.Items.Add(Me.InputLabel6)
        Me.C1InputPanel2.Items.Add(Me.CustomerName)
        Me.C1InputPanel2.Items.Add(Me.InputLabel9)
        Me.C1InputPanel2.Items.Add(Me.TIN)
        Me.C1InputPanel2.Items.Add(Me.InputLabel7)
        Me.C1InputPanel2.Items.Add(Me.Address)
        Me.C1InputPanel2.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel2.Name = "C1InputPanel2"
        Me.C1InputPanel2.Padding = New System.Windows.Forms.Padding(5)
        Me.C1InputPanel2.Size = New System.Drawing.Size(865, 154)
        Me.C1InputPanel2.TabIndex = 0
        Me.C1InputPanel2.VisualStyle = C1.Win.C1InputPanel.VisualStyle.System
        '
        'InputGroupHeader2
        '
        Me.InputGroupHeader2.Height = 30
        Me.InputGroupHeader2.Name = "InputGroupHeader2"
        Me.InputGroupHeader2.Text = "Customer Details"
        '
        'InputLabel6
        '
        Me.InputLabel6.Name = "InputLabel6"
        Me.InputLabel6.Text = "Customer"
        Me.InputLabel6.Width = 82
        '
        'CustomerName
        '
        Me.CustomerName.Name = "CustomerName"
        Me.CustomerName.Width = 500
        '
        'InputLabel9
        '
        Me.InputLabel9.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Near
        Me.InputLabel9.Name = "InputLabel9"
        Me.InputLabel9.Text = "TIN:"
        Me.InputLabel9.Width = 82
        '
        'TIN
        '
        Me.TIN.Name = "TIN"
        Me.TIN.ReadOnly = True
        Me.TIN.Width = 500
        '
        'InputLabel7
        '
        Me.InputLabel7.Name = "InputLabel7"
        Me.InputLabel7.Text = "Address:"
        Me.InputLabel7.Width = 82
        '
        'Address
        '
        Me.Address.Height = 42
        Me.Address.Multiline = True
        Me.Address.Name = "Address"
        Me.Address.ReadOnly = True
        Me.Address.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Spread
        Me.Address.Width = 500
        '
        'C1InputPanel3
        '
        Me.C1InputPanel3.BorderThickness = 1
        Me.C1InputPanel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.C1InputPanel3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1InputPanel3.Items.Add(Me.InputGroupHeader3)
        Me.C1InputPanel3.Items.Add(Me.InputButton2)
        Me.C1InputPanel3.Items.Add(Me.InputButton4)
        Me.C1InputPanel3.Location = New System.Drawing.Point(0, 410)
        Me.C1InputPanel3.Name = "C1InputPanel3"
        Me.C1InputPanel3.Padding = New System.Windows.Forms.Padding(5)
        Me.C1InputPanel3.Size = New System.Drawing.Size(865, 92)
        Me.C1InputPanel3.TabIndex = 8
        '
        'InputGroupHeader3
        '
        Me.InputGroupHeader3.Height = 24
        Me.InputGroupHeader3.Name = "InputGroupHeader3"
        Me.InputGroupHeader3.Text = "Actions and Commands"
        '
        'InputButton2
        '
        Me.InputButton2.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.InputButton2.Image = Global.A1plus.My.Resources.Resources.printer_go
        Me.InputButton2.Name = "InputButton2"
        Me.InputButton2.Text = "&Print Statement of Account"
        Me.InputButton2.Width = 211
        '
        'InputButton4
        '
        Me.InputButton4.Break = C1.Win.C1InputPanel.BreakType.None
        Me.InputButton4.Image = Global.A1plus.My.Resources.Resources.no
        Me.InputButton4.Name = "InputButton4"
        Me.InputButton4.Text = "&Close"
        '
        'InputLabel1
        '
        Me.InputLabel1.Name = "InputLabel1"
        Me.InputLabel1.Text = "Total Sales"
        '
        'totalsales
        '
        Me.totalsales.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.totalsales.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalsales.Name = "totalsales"
        Me.totalsales.Text = "PHP 0.00"
        '
        'AccountsReceivable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(865, 502)
        Me.Controls.Add(Me.C1FlexGrid1)
        Me.Controls.Add(Me.C1InputPanel4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.C1InputPanel3)
        Me.Name = "AccountsReceivable"
        Me.Text = "Accounts Receivable"
        CType(Me.C1FlexGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1FlexGrid1 As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents C1InputPanel4 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputLabel13 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents vatablesales As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel14 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents VATAmount As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents C1InputPanel2 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader2 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputLabel6 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents CustomerName As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents InputLabel9 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents TIN As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel7 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents Address As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents C1InputPanel3 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader3 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputButton2 As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputButton4 As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputLabel1 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents totalsales As C1.Win.C1InputPanel.InputLabel
End Class
