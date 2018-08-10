<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalesAgentEntry
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
        Me.InputLabel5 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel2 = New C1.Win.C1InputPanel.InputLabel()
        Me.SalesAgent = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel4 = New C1.Win.C1InputPanel.InputLabel()
        Me.Active = New C1.Win.C1InputPanel.InputCheckBox()
        Me.InputLabel6 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputGroupHeader2 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.ButtonSave = New C1.Win.C1InputPanel.InputButton()
        Me.ButtonNew = New C1.Win.C1InputPanel.InputButton()
        Me.ButtonClose = New C1.Win.C1InputPanel.InputButton()
        Me.InputLabel3 = New C1.Win.C1InputPanel.InputLabel()
        Me.ContactNo = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel7 = New C1.Win.C1InputPanel.InputLabel()
        Me.Email = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel8 = New C1.Win.C1InputPanel.InputLabel()
        Me.Description = New C1.Win.C1InputPanel.InputTextBox()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader1)
        Me.C1InputPanel1.Items.Add(Me.InputLabel1)
        Me.C1InputPanel1.Items.Add(Me.Reference)
        Me.C1InputPanel1.Items.Add(Me.InputLabel5)
        Me.C1InputPanel1.Items.Add(Me.InputLabel2)
        Me.C1InputPanel1.Items.Add(Me.SalesAgent)
        Me.C1InputPanel1.Items.Add(Me.InputLabel3)
        Me.C1InputPanel1.Items.Add(Me.ContactNo)
        Me.C1InputPanel1.Items.Add(Me.InputLabel7)
        Me.C1InputPanel1.Items.Add(Me.Email)
        Me.C1InputPanel1.Items.Add(Me.InputLabel8)
        Me.C1InputPanel1.Items.Add(Me.Description)
        Me.C1InputPanel1.Items.Add(Me.InputLabel4)
        Me.C1InputPanel1.Items.Add(Me.Active)
        Me.C1InputPanel1.Items.Add(Me.InputLabel6)
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader2)
        Me.C1InputPanel1.Items.Add(Me.ButtonSave)
        Me.C1InputPanel1.Items.Add(Me.ButtonNew)
        Me.C1InputPanel1.Items.Add(Me.ButtonClose)
        Me.C1InputPanel1.Location = New System.Drawing.Point(12, 12)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(454, 305)
        Me.C1InputPanel1.TabIndex = 0
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Height = 29
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        Me.InputGroupHeader1.Text = "Sales Agent Details"
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
        Me.Reference.Width = 182
        '
        'InputLabel5
        '
        Me.InputLabel5.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel5.ForeColor = System.Drawing.Color.Maroon
        Me.InputLabel5.Name = "InputLabel5"
        Me.InputLabel5.Text = "*This is system generated"
        '
        'InputLabel2
        '
        Me.InputLabel2.Name = "InputLabel2"
        Me.InputLabel2.Text = "Sales Agent:"
        Me.InputLabel2.Width = 64
        '
        'SalesAgent
        '
        Me.SalesAgent.Name = "SalesAgent"
        Me.SalesAgent.Width = 350
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
        'InputLabel6
        '
        Me.InputLabel6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel6.ForeColor = System.Drawing.Color.Maroon
        Me.InputLabel6.Name = "InputLabel6"
        Me.InputLabel6.Text = "*Uncheck the item of you want to disable"
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
        'InputLabel3
        '
        Me.InputLabel3.Name = "InputLabel3"
        Me.InputLabel3.Text = "Contact No:"
        Me.InputLabel3.Width = 64
        '
        'ContactNo
        '
        Me.ContactNo.Name = "ContactNo"
        Me.ContactNo.Width = 349
        '
        'InputLabel7
        '
        Me.InputLabel7.Name = "InputLabel7"
        Me.InputLabel7.Text = "Email:"
        Me.InputLabel7.Width = 64
        '
        'Email
        '
        Me.Email.Name = "Email"
        Me.Email.Width = 349
        '
        'InputLabel8
        '
        Me.InputLabel8.Name = "InputLabel8"
        Me.InputLabel8.Text = "Description:"
        Me.InputLabel8.Width = 64
        '
        'Description
        '
        Me.Description.Height = 55
        Me.Description.Multiline = True
        Me.Description.Name = "Description"
        Me.Description.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Spread
        Me.Description.Width = 349
        '
        'SalesAgentEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 334)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SalesAgentEntry"
        Me.Text = "Sales Agent Entry"
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputLabel1 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents Reference As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel2 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents SalesAgent As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel4 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents Active As C1.Win.C1InputPanel.InputCheckBox
    Friend WithEvents InputGroupHeader2 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents ButtonSave As C1.Win.C1InputPanel.InputButton
    Friend WithEvents ButtonNew As C1.Win.C1InputPanel.InputButton
    Friend WithEvents ButtonClose As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputLabel5 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel6 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel3 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents ContactNo As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel7 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents Email As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel8 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents Description As C1.Win.C1InputPanel.InputTextBox
End Class
