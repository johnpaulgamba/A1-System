<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class useraccountregistration
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
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel4 = New C1.Win.C1InputPanel.InputLabel()
        Me.UserName = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel8 = New C1.Win.C1InputPanel.InputLabel()
        Me.FullName = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel9 = New C1.Win.C1InputPanel.InputLabel()
        Me.Department = New C1.Win.C1InputPanel.InputComboBox()
        Me.InputLabel5 = New C1.Win.C1InputPanel.InputLabel()
        Me.Password = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel7 = New C1.Win.C1InputPanel.InputLabel()
        Me.ConfirmPassword = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel6 = New C1.Win.C1InputPanel.InputLabel()
        Me.EmailAddress = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel2 = New C1.Win.C1InputPanel.InputLabel()
        Me.RecoveryQuestion = New C1.Win.C1InputPanel.InputComboBox()
        Me.InputLabel3 = New C1.Win.C1InputPanel.InputLabel()
        Me.Answer = New C1.Win.C1InputPanel.InputTextBox()
        Me.ActiveCheckbox = New C1.Win.C1InputPanel.InputCheckBox()
        Me.InputGroupHeader2 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.SaveRecordButton = New C1.Win.C1InputPanel.InputButton()
        Me.ClearButton = New C1.Win.C1InputPanel.InputButton()
        Me.InputButton3 = New C1.Win.C1InputPanel.InputButton()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.BackColor = System.Drawing.Color.Transparent
        Me.C1InputPanel1.ChildSpacing = New System.Drawing.Size(4, 1)
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader1)
        Me.C1InputPanel1.Items.Add(Me.InputLabel4)
        Me.C1InputPanel1.Items.Add(Me.UserName)
        Me.C1InputPanel1.Items.Add(Me.InputLabel8)
        Me.C1InputPanel1.Items.Add(Me.FullName)
        Me.C1InputPanel1.Items.Add(Me.InputLabel9)
        Me.C1InputPanel1.Items.Add(Me.Department)
        Me.C1InputPanel1.Items.Add(Me.InputLabel5)
        Me.C1InputPanel1.Items.Add(Me.Password)
        Me.C1InputPanel1.Items.Add(Me.InputLabel7)
        Me.C1InputPanel1.Items.Add(Me.ConfirmPassword)
        Me.C1InputPanel1.Items.Add(Me.InputLabel6)
        Me.C1InputPanel1.Items.Add(Me.EmailAddress)
        Me.C1InputPanel1.Items.Add(Me.InputLabel2)
        Me.C1InputPanel1.Items.Add(Me.RecoveryQuestion)
        Me.C1InputPanel1.Items.Add(Me.InputLabel3)
        Me.C1InputPanel1.Items.Add(Me.Answer)
        Me.C1InputPanel1.Items.Add(Me.ActiveCheckbox)
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader2)
        Me.C1InputPanel1.Items.Add(Me.SaveRecordButton)
        Me.C1InputPanel1.Items.Add(Me.ClearButton)
        Me.C1InputPanel1.Items.Add(Me.InputButton3)
        Me.C1InputPanel1.Location = New System.Drawing.Point(27, 25)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(361, 428)
        Me.C1InputPanel1.TabIndex = 1
        Me.C1InputPanel1.VisualStyle = C1.Win.C1InputPanel.VisualStyle.System
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        Me.InputGroupHeader1.Text = "User Details"
        '
        'InputLabel4
        '
        Me.InputLabel4.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel4.Name = "InputLabel4"
        Me.InputLabel4.Text = "Enter desired User Name:"
        '
        'UserName
        '
        Me.UserName.Break = C1.Win.C1InputPanel.BreakType.Group
        Me.UserName.Height = 25
        Me.UserName.Name = "UserName"
        Me.UserName.Width = 335
        '
        'InputLabel8
        '
        Me.InputLabel8.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel8.Name = "InputLabel8"
        Me.InputLabel8.Text = "Full Name:"
        '
        'FullName
        '
        Me.FullName.Name = "FullName"
        Me.FullName.Width = 335
        '
        'InputLabel9
        '
        Me.InputLabel9.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel9.Name = "InputLabel9"
        Me.InputLabel9.Text = "Department:"
        '
        'Department
        '
        Me.Department.Break = C1.Win.C1InputPanel.BreakType.Group
        Me.Department.Height = 26
        Me.Department.Name = "Department"
        Me.Department.Width = 335
        '
        'InputLabel5
        '
        Me.InputLabel5.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel5.Name = "InputLabel5"
        Me.InputLabel5.Text = "Password:"
        '
        'Password
        '
        Me.Password.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.Password.Name = "Password"
        Me.Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(64)
        Me.Password.Width = 162
        '
        'InputLabel7
        '
        Me.InputLabel7.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel7.Name = "InputLabel7"
        Me.InputLabel7.Text = "Confirm Password:"
        '
        'ConfirmPassword
        '
        Me.ConfirmPassword.Break = C1.Win.C1InputPanel.BreakType.Group
        Me.ConfirmPassword.Height = 30
        Me.ConfirmPassword.Name = "ConfirmPassword"
        Me.ConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(64)
        Me.ConfirmPassword.Width = 162
        '
        'InputLabel6
        '
        Me.InputLabel6.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel6.Name = "InputLabel6"
        Me.InputLabel6.Text = "Email Address:"
        '
        'EmailAddress
        '
        Me.EmailAddress.Name = "EmailAddress"
        Me.EmailAddress.Width = 335
        '
        'InputLabel2
        '
        Me.InputLabel2.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel2.Name = "InputLabel2"
        Me.InputLabel2.Text = "Recovery Question:"
        '
        'RecoveryQuestion
        '
        Me.RecoveryQuestion.Break = C1.Win.C1InputPanel.BreakType.Group
        Me.RecoveryQuestion.Name = "RecoveryQuestion"
        Me.RecoveryQuestion.Width = 335
        '
        'InputLabel3
        '
        Me.InputLabel3.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel3.Name = "InputLabel3"
        Me.InputLabel3.Text = "Answer:"
        '
        'Answer
        '
        Me.Answer.Height = 29
        Me.Answer.Name = "Answer"
        Me.Answer.Width = 335
        '
        'ActiveCheckbox
        '
        Me.ActiveCheckbox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ActiveCheckbox.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.ActiveCheckbox.Name = "ActiveCheckbox"
        Me.ActiveCheckbox.Text = "Active"
        Me.ActiveCheckbox.Width = 335
        '
        'InputGroupHeader2
        '
        Me.InputGroupHeader2.Height = 30
        Me.InputGroupHeader2.Name = "InputGroupHeader2"
        Me.InputGroupHeader2.Text = "Actions and Commands"
        '
        'SaveRecordButton
        '
        Me.SaveRecordButton.Break = C1.Win.C1InputPanel.BreakType.None
        Me.SaveRecordButton.Image = Global.A1plus.My.Resources.Resources.SaveAllHS
        Me.SaveRecordButton.Name = "SaveRecordButton"
        Me.SaveRecordButton.Text = "Save Record"
        '
        'ClearButton
        '
        Me.ClearButton.Break = C1.Win.C1InputPanel.BreakType.None
        Me.ClearButton.Image = Global.A1plus.My.Resources.Resources.DocumentHS1
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.Width = 85
        '
        'InputButton3
        '
        Me.InputButton3.Image = Global.A1plus.My.Resources.Resources.no
        Me.InputButton3.Name = "InputButton3"
        Me.InputButton3.Text = "Close"
        Me.InputButton3.Width = 84
        '
        'UserAccountRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(410, 475)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UserAccountRegistration"
        Me.Text = "User Account Entry"
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Silver
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputLabel4 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents UserName As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel8 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents FullName As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel9 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents Department As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents InputLabel5 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents Password As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel7 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents ConfirmPassword As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel6 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents EmailAddress As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel2 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents RecoveryQuestion As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents InputLabel3 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents Answer As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents ActiveCheckbox As C1.Win.C1InputPanel.InputCheckBox
    Friend WithEvents InputGroupHeader2 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents SaveRecordButton As C1.Win.C1InputPanel.InputButton
    Friend WithEvents ClearButton As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputButton3 As C1.Win.C1InputPanel.InputButton
End Class
