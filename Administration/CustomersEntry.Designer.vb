<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class customersentry
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(customersentry))
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel1 = New C1.Win.C1InputPanel.InputLabel()
        Me.Reference = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel12 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel2 = New C1.Win.C1InputPanel.InputLabel()
        Me.CustomerName = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputSeparator2 = New C1.Win.C1InputPanel.InputSeparator()
        Me.InputLabel5 = New C1.Win.C1InputPanel.InputLabel()
        Me.Businesstype = New C1.Win.C1InputPanel.InputComboBox()
        Me.InputLabel9 = New C1.Win.C1InputPanel.InputLabel()
        Me.TIN = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel11 = New C1.Win.C1InputPanel.InputLabel()
        Me.TaxType = New C1.Win.C1InputPanel.InputComboBox()
        Me.InputOption1 = New C1.Win.C1InputPanel.InputOption()
        Me.InputOption2 = New C1.Win.C1InputPanel.InputOption()
        Me.InputLabel3 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputTextBox2 = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel6 = New C1.Win.C1InputPanel.InputLabel()
        Me.VatType = New C1.Win.C1InputPanel.InputComboBox()
        Me.InputOption3 = New C1.Win.C1InputPanel.InputOption()
        Me.InputOption4 = New C1.Win.C1InputPanel.InputOption()
        Me.InputSeparator1 = New C1.Win.C1InputPanel.InputSeparator()
        Me.InputLabel15 = New C1.Win.C1InputPanel.InputLabel()
        Me.BillAddress = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel10 = New C1.Win.C1InputPanel.InputLabel()
        Me.ShipAddress = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel16 = New C1.Win.C1InputPanel.InputLabel()
        Me.ContactPerson = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel8 = New C1.Win.C1InputPanel.InputLabel()
        Me.ContactNo = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel7 = New C1.Win.C1InputPanel.InputLabel()
        Me.EmailAddress = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel4 = New C1.Win.C1InputPanel.InputLabel()
        Me.Active = New C1.Win.C1InputPanel.InputCheckBox()
        Me.InputLabel13 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputGroupHeader2 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.ButtonSave = New C1.Win.C1InputPanel.InputButton()
        Me.ButtonNew = New C1.Win.C1InputPanel.InputButton()
        Me.ButtonClose = New C1.Win.C1InputPanel.InputButton()
        Me.InputLabel14 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputTextBox1 = New C1.Win.C1InputPanel.InputTextBox()
        Me.C1FlexGrid1 = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.terms = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1FlexGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader1)
        Me.C1InputPanel1.Items.Add(Me.InputLabel1)
        Me.C1InputPanel1.Items.Add(Me.Reference)
        Me.C1InputPanel1.Items.Add(Me.InputLabel12)
        Me.C1InputPanel1.Items.Add(Me.InputLabel2)
        Me.C1InputPanel1.Items.Add(Me.CustomerName)
        Me.C1InputPanel1.Items.Add(Me.InputSeparator2)
        Me.C1InputPanel1.Items.Add(Me.InputLabel5)
        Me.C1InputPanel1.Items.Add(Me.Businesstype)
        Me.C1InputPanel1.Items.Add(Me.InputLabel9)
        Me.C1InputPanel1.Items.Add(Me.TIN)
        Me.C1InputPanel1.Items.Add(Me.InputLabel11)
        Me.C1InputPanel1.Items.Add(Me.TaxType)
        Me.C1InputPanel1.Items.Add(Me.InputLabel3)
        Me.C1InputPanel1.Items.Add(Me.InputTextBox2)
        Me.C1InputPanel1.Items.Add(Me.InputLabel6)
        Me.C1InputPanel1.Items.Add(Me.VatType)
        Me.C1InputPanel1.Items.Add(Me.InputSeparator1)
        Me.C1InputPanel1.Items.Add(Me.InputLabel15)
        Me.C1InputPanel1.Items.Add(Me.BillAddress)
        Me.C1InputPanel1.Items.Add(Me.InputLabel10)
        Me.C1InputPanel1.Items.Add(Me.ShipAddress)
        Me.C1InputPanel1.Items.Add(Me.InputLabel16)
        Me.C1InputPanel1.Items.Add(Me.ContactPerson)
        Me.C1InputPanel1.Items.Add(Me.InputLabel8)
        Me.C1InputPanel1.Items.Add(Me.ContactNo)
        Me.C1InputPanel1.Items.Add(Me.InputLabel7)
        Me.C1InputPanel1.Items.Add(Me.EmailAddress)
        Me.C1InputPanel1.Items.Add(Me.InputLabel4)
        Me.C1InputPanel1.Items.Add(Me.Active)
        Me.C1InputPanel1.Items.Add(Me.InputLabel13)
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader2)
        Me.C1InputPanel1.Items.Add(Me.ButtonSave)
        Me.C1InputPanel1.Items.Add(Me.ButtonNew)
        Me.C1InputPanel1.Items.Add(Me.ButtonClose)
        Me.C1InputPanel1.Location = New System.Drawing.Point(12, 3)
        Me.C1InputPanel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(552, 534)
        Me.C1InputPanel1.TabIndex = 0
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Height = 29
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        Me.InputGroupHeader1.Text = "Customer Details"
        '
        'InputLabel1
        '
        Me.InputLabel1.Height = 5
        Me.InputLabel1.Name = "InputLabel1"
        Me.InputLabel1.Text = "Reference:"
        Me.InputLabel1.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        Me.InputLabel1.Width = 75
        '
        'Reference
        '
        Me.Reference.Break = C1.Win.C1InputPanel.BreakType.None
        Me.Reference.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reference.Height = 10
        Me.Reference.Name = "Reference"
        Me.Reference.ReadOnly = True
        Me.Reference.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        Me.Reference.Width = 124
        '
        'InputLabel12
        '
        Me.InputLabel12.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel12.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel12.ForeColor = System.Drawing.Color.Maroon
        Me.InputLabel12.Height = 1
        Me.InputLabel12.Name = "InputLabel12"
        Me.InputLabel12.Text = "*This is system generated."
        Me.InputLabel12.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        '
        'InputLabel2
        '
        Me.InputLabel2.Name = "InputLabel2"
        Me.InputLabel2.Text = "Name:"
        Me.InputLabel2.Width = 75
        '
        'CustomerName
        '
        Me.CustomerName.Name = "CustomerName"
        Me.CustomerName.Width = 433
        '
        'InputSeparator2
        '
        Me.InputSeparator2.Height = 20
        Me.InputSeparator2.Name = "InputSeparator2"
        Me.InputSeparator2.Width = 511
        '
        'InputLabel5
        '
        Me.InputLabel5.Name = "InputLabel5"
        Me.InputLabel5.Text = "Buss. Type:"
        Me.InputLabel5.Width = 75
        '
        'Businesstype
        '
        Me.Businesstype.AutoCompleteMode = C1.Win.C1InputPanel.InputAutoCompleteMode.Suggest
        Me.Businesstype.DisableOnNoData = False
        Me.Businesstype.Name = "Businesstype"
        Me.Businesstype.Width = 430
        '
        'InputLabel9
        '
        Me.InputLabel9.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Near
        Me.InputLabel9.Name = "InputLabel9"
        Me.InputLabel9.Text = "Tax ID No:"
        Me.InputLabel9.Width = 75
        '
        'TIN
        '
        Me.TIN.Break = C1.Win.C1InputPanel.BreakType.None
        Me.TIN.Name = "TIN"
        Me.TIN.Width = 223
        '
        'InputLabel11
        '
        Me.InputLabel11.Name = "InputLabel11"
        Me.InputLabel11.Text = "Tax Type:"
        Me.InputLabel11.Width = 66
        '
        'TaxType
        '
        Me.TaxType.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.TaxType.Items.Add(Me.InputOption1)
        Me.TaxType.Items.Add(Me.InputOption2)
        Me.TaxType.Name = "TaxType"
        Me.TaxType.Text = "VATABLE"
        Me.TaxType.Width = 135
        '
        'InputOption1
        '
        Me.InputOption1.Name = "InputOption1"
        Me.InputOption1.Text = "VATABLE"
        '
        'InputOption2
        '
        Me.InputOption2.Name = "InputOption2"
        Me.InputOption2.Text = "NON-VAT"
        '
        'InputLabel3
        '
        Me.InputLabel3.Name = "InputLabel3"
        Me.InputLabel3.Text = "Pay Terms:"
        Me.InputLabel3.Width = 76
        '
        'InputTextBox2
        '
        Me.InputTextBox2.Break = C1.Win.C1InputPanel.BreakType.None
        Me.InputTextBox2.Name = "InputTextBox2"
        Me.InputTextBox2.Width = 221
        '
        'InputLabel6
        '
        Me.InputLabel6.Name = "InputLabel6"
        Me.InputLabel6.Text = "VAT Type:"
        Me.InputLabel6.Width = 67
        '
        'VatType
        '
        Me.VatType.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.VatType.Items.Add(Me.InputOption3)
        Me.VatType.Items.Add(Me.InputOption4)
        Me.VatType.Name = "VatType"
        Me.VatType.Width = 135
        '
        'InputOption3
        '
        Me.InputOption3.Name = "InputOption3"
        Me.InputOption3.Text = "VAT Exclusive"
        '
        'InputOption4
        '
        Me.InputOption4.Name = "InputOption4"
        Me.InputOption4.Text = "VAT Inclusive"
        '
        'InputSeparator1
        '
        Me.InputSeparator1.Name = "InputSeparator1"
        Me.InputSeparator1.Width = 511
        '
        'InputLabel15
        '
        Me.InputLabel15.Height = 38
        Me.InputLabel15.Name = "InputLabel15"
        Me.InputLabel15.Text = "Billing Address"
        Me.InputLabel15.Width = 75
        '
        'BillAddress
        '
        Me.BillAddress.Height = 47
        Me.BillAddress.Multiline = True
        Me.BillAddress.Name = "BillAddress"
        Me.BillAddress.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Spread
        Me.BillAddress.Width = 433
        '
        'InputLabel10
        '
        Me.InputLabel10.Height = 74
        Me.InputLabel10.Name = "InputLabel10"
        Me.InputLabel10.Text = "Shipping Address"
        Me.InputLabel10.Width = 75
        '
        'ShipAddress
        '
        Me.ShipAddress.Height = 136
        Me.ShipAddress.Multiline = True
        Me.ShipAddress.Name = "ShipAddress"
        Me.ShipAddress.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Spread
        Me.ShipAddress.Width = 433
        '
        'InputLabel16
        '
        Me.InputLabel16.Name = "InputLabel16"
        Me.InputLabel16.Text = "Cont Person"
        Me.InputLabel16.Width = 75
        '
        'ContactPerson
        '
        Me.ContactPerson.Name = "ContactPerson"
        Me.ContactPerson.Width = 433
        '
        'InputLabel8
        '
        Me.InputLabel8.Name = "InputLabel8"
        Me.InputLabel8.Text = "Contact No:"
        Me.InputLabel8.Width = 75
        '
        'ContactNo
        '
        Me.ContactNo.Break = C1.Win.C1InputPanel.BreakType.None
        Me.ContactNo.Name = "ContactNo"
        Me.ContactNo.Width = 147
        '
        'InputLabel7
        '
        Me.InputLabel7.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel7.Name = "InputLabel7"
        Me.InputLabel7.Text = "Email:"
        Me.InputLabel7.Width = 47
        '
        'EmailAddress
        '
        Me.EmailAddress.Name = "EmailAddress"
        Me.EmailAddress.Width = 231
        '
        'InputLabel4
        '
        Me.InputLabel4.Name = "InputLabel4"
        Me.InputLabel4.Text = "Status:"
        Me.InputLabel4.Width = 75
        '
        'Active
        '
        Me.Active.Break = C1.Win.C1InputPanel.BreakType.None
        Me.Active.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Active.Name = "Active"
        Me.Active.Text = "&Active"
        '
        'InputLabel13
        '
        Me.InputLabel13.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel13.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel13.ForeColor = System.Drawing.Color.Maroon
        Me.InputLabel13.Name = "InputLabel13"
        Me.InputLabel13.Text = "*Uncheck this item to disable"
        '
        'InputGroupHeader2
        '
        Me.InputGroupHeader2.Height = 36
        Me.InputGroupHeader2.Name = "InputGroupHeader2"
        Me.InputGroupHeader2.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.InputGroupHeader2.Text = "Actions and Commands"
        '
        'ButtonSave
        '
        Me.ButtonSave.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.ButtonSave.Image = Global.A1plus.My.Resources.Resources.SaveAllHS
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Text = "&Save"
        '
        'ButtonNew
        '
        Me.ButtonNew.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.ButtonNew.Image = Global.A1plus.My.Resources.Resources.documents_new
        Me.ButtonNew.Name = "ButtonNew"
        Me.ButtonNew.Text = "&New"
        '
        'ButtonClose
        '
        Me.ButtonClose.Image = Global.A1plus.My.Resources.Resources.no
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Text = "&Close"
        '
        'InputLabel14
        '
        Me.InputLabel14.Name = "InputLabel14"
        Me.InputLabel14.Text = "Address:"
        Me.InputLabel14.Width = 64
        '
        'InputTextBox1
        '
        Me.InputTextBox1.Height = 50
        Me.InputTextBox1.Multiline = True
        Me.InputTextBox1.Name = "InputTextBox1"
        Me.InputTextBox1.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Spread
        Me.InputTextBox1.Width = 433
        '
        'C1FlexGrid1
        '
        Me.C1FlexGrid1.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.C1FlexGrid1.BackColor = System.Drawing.Color.White
        Me.C1FlexGrid1.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None
        Me.C1FlexGrid1.ColumnInfo = resources.GetString("C1FlexGrid1.ColumnInfo")
        Me.C1FlexGrid1.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.C1FlexGrid1.Location = New System.Drawing.Point(94, 239)
        Me.C1FlexGrid1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.C1FlexGrid1.Name = "C1FlexGrid1"
        Me.C1FlexGrid1.Rows.DefaultSize = 24
        Me.C1FlexGrid1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.C1FlexGrid1.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.None
        Me.C1FlexGrid1.Size = New System.Drawing.Size(444, 134)
        Me.C1FlexGrid1.StyleInfo = resources.GetString("C1FlexGrid1.StyleInfo")
        Me.C1FlexGrid1.TabIndex = 1
        '
        'terms
        '
        Me.terms.AccessibleDescription = "Terms"
        Me.terms.FormattingEnabled = True
        Me.terms.Location = New System.Drawing.Point(102, 154)
        Me.terms.Name = "terms"
        Me.terms.Size = New System.Drawing.Size(222, 25)
        Me.terms.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(84, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(84, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(84, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Maroon
        Me.Label5.Location = New System.Drawing.Point(84, 264)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(16, 16)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Maroon
        Me.Label6.Location = New System.Drawing.Point(381, 154)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(16, 16)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "*"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Maroon
        Me.Label8.Location = New System.Drawing.Point(84, 196)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(16, 16)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(84, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "*"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Maroon
        Me.Label7.Location = New System.Drawing.Point(381, 127)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(16, 16)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "*"
        '
        'customersentry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 565)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.terms)
        Me.Controls.Add(Me.C1FlexGrid1)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "customersentry"
        Me.Text = "Customers Management"
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1FlexGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputLabel1 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents Reference As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel2 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel4 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents Active As C1.Win.C1InputPanel.InputCheckBox
    Friend WithEvents InputGroupHeader2 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents ButtonSave As C1.Win.C1InputPanel.InputButton
    Friend WithEvents ButtonNew As C1.Win.C1InputPanel.InputButton
    Friend WithEvents ButtonClose As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputSeparator1 As C1.Win.C1InputPanel.InputSeparator
    Friend WithEvents CustomerName As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel10 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents ShipAddress As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel8 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents ContactNo As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel9 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents TIN As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputSeparator2 As C1.Win.C1InputPanel.InputSeparator
    Friend WithEvents InputLabel5 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents Businesstype As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents InputLabel12 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel13 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel7 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents EmailAddress As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel11 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents TaxType As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents InputOption1 As C1.Win.C1InputPanel.InputOption
    Friend WithEvents InputOption2 As C1.Win.C1InputPanel.InputOption
    Friend WithEvents InputLabel15 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents BillAddress As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel14 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputTextBox1 As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel16 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents ContactPerson As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents C1FlexGrid1 As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents InputLabel3 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputTextBox2 As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel6 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents VatType As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents InputOption3 As C1.Win.C1InputPanel.InputOption
    Friend WithEvents InputOption4 As C1.Win.C1InputPanel.InputOption
    Friend WithEvents terms As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
