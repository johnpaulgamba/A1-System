<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class branchesentry
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
        Me.InputLabel1 = New C1.Win.C1InputPanel.InputLabel()
        Me.Reference = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel12 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputSeparator1 = New C1.Win.C1InputPanel.InputSeparator()
        Me.InputLabel2 = New C1.Win.C1InputPanel.InputLabel()
        Me.BranchName = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel11 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel10 = New C1.Win.C1InputPanel.InputLabel()
        Me.Address = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel8 = New C1.Win.C1InputPanel.InputLabel()
        Me.ContactNo = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel9 = New C1.Win.C1InputPanel.InputLabel()
        Me.TIN = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputSeparator2 = New C1.Win.C1InputPanel.InputSeparator()
        Me.InputLabel4 = New C1.Win.C1InputPanel.InputLabel()
        Me.Active = New C1.Win.C1InputPanel.InputCheckBox()
        Me.InputLabel13 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputGroupHeader2 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.ButtonSave = New C1.Win.C1InputPanel.InputButton()
        Me.ButtonNew = New C1.Win.C1InputPanel.InputButton()
        Me.ButtonClose = New C1.Win.C1InputPanel.InputButton()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader1)
        Me.C1InputPanel1.Items.Add(Me.InputLabel1)
        Me.C1InputPanel1.Items.Add(Me.Reference)
        Me.C1InputPanel1.Items.Add(Me.InputLabel12)
        Me.C1InputPanel1.Items.Add(Me.InputSeparator1)
        Me.C1InputPanel1.Items.Add(Me.InputLabel2)
        Me.C1InputPanel1.Items.Add(Me.BranchName)
        Me.C1InputPanel1.Items.Add(Me.InputLabel11)
        Me.C1InputPanel1.Items.Add(Me.InputLabel10)
        Me.C1InputPanel1.Items.Add(Me.Address)
        Me.C1InputPanel1.Items.Add(Me.InputLabel8)
        Me.C1InputPanel1.Items.Add(Me.ContactNo)
        Me.C1InputPanel1.Items.Add(Me.InputLabel9)
        Me.C1InputPanel1.Items.Add(Me.TIN)
        Me.C1InputPanel1.Items.Add(Me.InputSeparator2)
        Me.C1InputPanel1.Items.Add(Me.InputLabel4)
        Me.C1InputPanel1.Items.Add(Me.Active)
        Me.C1InputPanel1.Items.Add(Me.InputLabel13)
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader2)
        Me.C1InputPanel1.Items.Add(Me.ButtonSave)
        Me.C1InputPanel1.Items.Add(Me.ButtonNew)
        Me.C1InputPanel1.Items.Add(Me.ButtonClose)
        Me.C1InputPanel1.Location = New System.Drawing.Point(12, 12)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(525, 305)
        Me.C1InputPanel1.TabIndex = 0
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Height = 29
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        Me.InputGroupHeader1.Text = "Company Details"
        '
        'InputLabel1
        '
        Me.InputLabel1.Name = "InputLabel1"
        Me.InputLabel1.Text = "Reference:"
        Me.InputLabel1.Width = 64
        '
        'Reference
        '
        Me.Reference.Break = C1.Win.C1InputPanel.BreakType.None
        Me.Reference.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reference.Name = "Reference"
        Me.Reference.ReadOnly = True
        Me.Reference.Width = 124
        '
        'InputLabel12
        '
        Me.InputLabel12.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel12.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel12.ForeColor = System.Drawing.Color.Maroon
        Me.InputLabel12.Name = "InputLabel12"
        Me.InputLabel12.Text = "*This is system generated."
        '
        'InputSeparator1
        '
        Me.InputSeparator1.Name = "InputSeparator1"
        Me.InputSeparator1.Width = 496
        '
        'InputLabel2
        '
        Me.InputLabel2.Name = "InputLabel2"
        Me.InputLabel2.Text = "Company:"
        Me.InputLabel2.Width = 64
        '
        'BranchName
        '
        Me.BranchName.Break = C1.Win.C1InputPanel.BreakType.None
        Me.BranchName.Name = "BranchName"
        Me.BranchName.Width = 240
        '
        'InputLabel11
        '
        Me.InputLabel11.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel11.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel11.ForeColor = System.Drawing.Color.Maroon
        Me.InputLabel11.Name = "InputLabel11"
        Me.InputLabel11.Text = "*This field is required."
        '
        'InputLabel10
        '
        Me.InputLabel10.Name = "InputLabel10"
        Me.InputLabel10.Text = "Address:"
        Me.InputLabel10.Width = 64
        '
        'Address
        '
        Me.Address.Height = 50
        Me.Address.Multiline = True
        Me.Address.Name = "Address"
        Me.Address.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Spread
        Me.Address.Width = 433
        '
        'InputLabel8
        '
        Me.InputLabel8.Name = "InputLabel8"
        Me.InputLabel8.Text = "Contact No:"
        Me.InputLabel8.Width = 64
        '
        'ContactNo
        '
        Me.ContactNo.Break = C1.Win.C1InputPanel.BreakType.None
        Me.ContactNo.Name = "ContactNo"
        Me.ContactNo.Width = 186
        '
        'InputLabel9
        '
        Me.InputLabel9.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.InputLabel9.Name = "InputLabel9"
        Me.InputLabel9.Text = "Tax ID No:"
        Me.InputLabel9.Width = 64
        '
        'TIN
        '
        Me.TIN.Name = "TIN"
        Me.TIN.Width = 176
        '
        'InputSeparator2
        '
        Me.InputSeparator2.Height = 20
        Me.InputSeparator2.Name = "InputSeparator2"
        Me.InputSeparator2.Width = 501
        '
        'InputLabel4
        '
        Me.InputLabel4.Name = "InputLabel4"
        Me.InputLabel4.Text = "Status:"
        Me.InputLabel4.Width = 64
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
        'branchesentry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(545, 333)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "branchesentry"
        Me.Text = "Company "
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

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
    Friend WithEvents BranchName As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel10 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents Address As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel8 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents ContactNo As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel9 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents TIN As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputSeparator2 As C1.Win.C1InputPanel.InputSeparator
    Friend WithEvents InputLabel12 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel11 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel13 As C1.Win.C1InputPanel.InputLabel
End Class
