<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class itemsentry
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
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel9 = New C1.Win.C1InputPanel.InputLabel()
        Me.itemcode = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel2 = New C1.Win.C1InputPanel.InputLabel()
        Me.ItemsName = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel3 = New C1.Win.C1InputPanel.InputLabel()
        Me.Description = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel8 = New C1.Win.C1InputPanel.InputLabel()
        Me.UOM = New C1.Win.C1InputPanel.InputComboBox()
        Me.InputLabel10 = New C1.Win.C1InputPanel.InputLabel()
        Me.price = New C1.Win.C1InputPanel.InputNumericBox()
        Me.InputLabel4 = New C1.Win.C1InputPanel.InputLabel()
        Me.Active = New C1.Win.C1InputPanel.InputCheckBox()
        Me.InputLabel6 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel1 = New C1.Win.C1InputPanel.InputLabel()
        Me.Reference = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel5 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputGroupHeader2 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.ButtonSave = New C1.Win.C1InputPanel.InputButton()
        Me.ButtonNew = New C1.Win.C1InputPanel.InputButton()
        Me.ButtonClose = New C1.Win.C1InputPanel.InputButton()
        Me.InputLabel7 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputTextBox1 = New C1.Win.C1InputPanel.InputTextBox()
        Me.Category = New System.Windows.Forms.ComboBox()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader1)
        Me.C1InputPanel1.Items.Add(Me.InputLabel9)
        Me.C1InputPanel1.Items.Add(Me.itemcode)
        Me.C1InputPanel1.Items.Add(Me.InputLabel2)
        Me.C1InputPanel1.Items.Add(Me.ItemsName)
        Me.C1InputPanel1.Items.Add(Me.InputLabel7)
        Me.C1InputPanel1.Items.Add(Me.InputTextBox1)
        Me.C1InputPanel1.Items.Add(Me.InputLabel3)
        Me.C1InputPanel1.Items.Add(Me.Description)
        Me.C1InputPanel1.Items.Add(Me.InputLabel8)
        Me.C1InputPanel1.Items.Add(Me.UOM)
        Me.C1InputPanel1.Items.Add(Me.InputLabel10)
        Me.C1InputPanel1.Items.Add(Me.price)
        Me.C1InputPanel1.Items.Add(Me.InputLabel4)
        Me.C1InputPanel1.Items.Add(Me.Active)
        Me.C1InputPanel1.Items.Add(Me.InputLabel6)
        Me.C1InputPanel1.Items.Add(Me.InputLabel1)
        Me.C1InputPanel1.Items.Add(Me.Reference)
        Me.C1InputPanel1.Items.Add(Me.InputLabel5)
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader2)
        Me.C1InputPanel1.Items.Add(Me.ButtonSave)
        Me.C1InputPanel1.Items.Add(Me.ButtonNew)
        Me.C1InputPanel1.Items.Add(Me.ButtonClose)
        Me.C1InputPanel1.Location = New System.Drawing.Point(8, 8)
        Me.C1InputPanel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(480, 341)
        Me.C1InputPanel1.TabIndex = 0
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Height = 29
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        Me.InputGroupHeader1.Text = "Item Details"
        '
        'InputLabel9
        '
        Me.InputLabel9.Name = "InputLabel9"
        Me.InputLabel9.Text = "Item Code:"
        Me.InputLabel9.Width = 75
        '
        'itemcode
        '
        Me.itemcode.Name = "itemcode"
        Me.itemcode.Width = 181
        '
        'InputLabel2
        '
        Me.InputLabel2.Name = "InputLabel2"
        Me.InputLabel2.Text = "Item Name:"
        Me.InputLabel2.Width = 75
        '
        'ItemsName
        '
        Me.ItemsName.Name = "ItemsName"
        Me.ItemsName.Width = 350
        '
        'InputLabel3
        '
        Me.InputLabel3.Name = "InputLabel3"
        Me.InputLabel3.Text = "Description:"
        Me.InputLabel3.Width = 75
        '
        'Description
        '
        Me.Description.Height = 58
        Me.Description.Multiline = True
        Me.Description.Name = "Description"
        Me.Description.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Spread
        Me.Description.Width = 350
        '
        'InputLabel8
        '
        Me.InputLabel8.Name = "InputLabel8"
        Me.InputLabel8.Text = "Unit Meas:"
        Me.InputLabel8.Width = 75
        '
        'UOM
        '
        Me.UOM.Break = C1.Win.C1InputPanel.BreakType.None
        Me.UOM.Name = "UOM"
        Me.UOM.Width = 118
        '
        'InputLabel10
        '
        Me.InputLabel10.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel10.Name = "InputLabel10"
        Me.InputLabel10.Text = "Unit Price:"
        Me.InputLabel10.Width = 74
        '
        'price
        '
        Me.price.Maximum = New Decimal(New Integer() {1410065407, 2, 0, 0})
        Me.price.Name = "price"
        Me.price.Width = 149
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
        'InputLabel6
        '
        Me.InputLabel6.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel6.ForeColor = System.Drawing.Color.Maroon
        Me.InputLabel6.Name = "InputLabel6"
        Me.InputLabel6.Text = "*Uncheck the item of you want to disable"
        '
        'InputLabel1
        '
        Me.InputLabel1.Height = 1
        Me.InputLabel1.Name = "InputLabel1"
        Me.InputLabel1.Text = "Reference:"
        Me.InputLabel1.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        Me.InputLabel1.Width = 64
        '
        'Reference
        '
        Me.Reference.Break = C1.Win.C1InputPanel.BreakType.None
        Me.Reference.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reference.Height = 7
        Me.Reference.Name = "Reference"
        Me.Reference.ReadOnly = True
        Me.Reference.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        Me.Reference.Width = 182
        '
        'InputLabel5
        '
        Me.InputLabel5.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel5.ForeColor = System.Drawing.Color.Maroon
        Me.InputLabel5.Height = 1
        Me.InputLabel5.Name = "InputLabel5"
        Me.InputLabel5.Text = "*This is system generated"
        Me.InputLabel5.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
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
        'InputLabel7
        '
        Me.InputLabel7.Name = "InputLabel7"
        Me.InputLabel7.Text = "Category:"
        Me.InputLabel7.Width = 75
        '
        'InputTextBox1
        '
        Me.InputTextBox1.Name = "InputTextBox1"
        Me.InputTextBox1.Width = 350
        '
        'Category
        '
        Me.Category.FormattingEnabled = True
        Me.Category.Location = New System.Drawing.Point(98, 97)
        Me.Category.Name = "Category"
        Me.Category.Size = New System.Drawing.Size(350, 25)
        Me.Category.TabIndex = 1
        '
        'itemsentry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 361)
        Me.Controls.Add(Me.Category)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "itemsentry"
        Me.Text = "Items Entry"
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputLabel1 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents Reference As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel2 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents ItemsName As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel3 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents Description As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel4 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents Active As C1.Win.C1InputPanel.InputCheckBox
    Friend WithEvents InputGroupHeader2 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents ButtonSave As C1.Win.C1InputPanel.InputButton
    Friend WithEvents ButtonNew As C1.Win.C1InputPanel.InputButton
    Friend WithEvents ButtonClose As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputLabel5 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel6 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel8 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents UOM As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents InputLabel9 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents itemcode As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel10 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents price As C1.Win.C1InputPanel.InputNumericBox
    Friend WithEvents InputLabel7 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputTextBox1 As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents Category As System.Windows.Forms.ComboBox
End Class
