<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class user_permission_modules_entry
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
        Me.InputLabel2 = New C1.Win.C1InputPanel.InputLabel()
        Me.GroupNameComboBox = New C1.Win.C1InputPanel.InputComboBox()
        Me.InputLabel5 = New C1.Win.C1InputPanel.InputLabel()
        Me.ModuleNameTxtBox = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel3 = New C1.Win.C1InputPanel.InputLabel()
        Me.ButtonNameTextBox = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel6 = New C1.Win.C1InputPanel.InputLabel()
        Me.ClassName = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel4 = New C1.Win.C1InputPanel.InputLabel()
        Me.DescriptionTextBox = New C1.Win.C1InputPanel.InputTextBox()
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
        Me.C1InputPanel1.BorderColor = System.Drawing.SystemColors.Control
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader1)
        Me.C1InputPanel1.Items.Add(Me.InputLabel2)
        Me.C1InputPanel1.Items.Add(Me.GroupNameComboBox)
        Me.C1InputPanel1.Items.Add(Me.InputLabel5)
        Me.C1InputPanel1.Items.Add(Me.ModuleNameTxtBox)
        Me.C1InputPanel1.Items.Add(Me.InputLabel3)
        Me.C1InputPanel1.Items.Add(Me.ButtonNameTextBox)
        Me.C1InputPanel1.Items.Add(Me.InputLabel6)
        Me.C1InputPanel1.Items.Add(Me.ClassName)
        Me.C1InputPanel1.Items.Add(Me.InputLabel4)
        Me.C1InputPanel1.Items.Add(Me.DescriptionTextBox)
        Me.C1InputPanel1.Items.Add(Me.ActiveCheckbox)
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader2)
        Me.C1InputPanel1.Items.Add(Me.SaveRecordButton)
        Me.C1InputPanel1.Items.Add(Me.ClearButton)
        Me.C1InputPanel1.Items.Add(Me.InputButton3)
        Me.C1InputPanel1.Location = New System.Drawing.Point(12, 12)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(539, 330)
        Me.C1InputPanel1.TabIndex = 1
        Me.C1InputPanel1.VisualStyle = C1.Win.C1InputPanel.VisualStyle.System
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        Me.InputGroupHeader1.Text = "Module Details"
        '
        'InputLabel2
        '
        Me.InputLabel2.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel2.Name = "InputLabel2"
        Me.InputLabel2.Text = "User Permission Group Name:"
        '
        'GroupNameComboBox
        '
        Me.GroupNameComboBox.Break = C1.Win.C1InputPanel.BreakType.Group
        Me.GroupNameComboBox.Name = "GroupNameComboBox"
        Me.GroupNameComboBox.Width = 519
        '
        'InputLabel5
        '
        Me.InputLabel5.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel5.Name = "InputLabel5"
        Me.InputLabel5.Text = "User Permission Module Name:"
        '
        'ModuleNameTxtBox
        '
        Me.ModuleNameTxtBox.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.ModuleNameTxtBox.Height = 82
        Me.ModuleNameTxtBox.Multiline = True
        Me.ModuleNameTxtBox.Name = "ModuleNameTxtBox"
        Me.ModuleNameTxtBox.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Spread
        Me.ModuleNameTxtBox.Width = 263
        '
        'InputLabel3
        '
        Me.InputLabel3.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel3.Name = "InputLabel3"
        Me.InputLabel3.Text = "Button Name:"
        '
        'ButtonNameTextBox
        '
        Me.ButtonNameTextBox.Height = 26
        Me.ButtonNameTextBox.Name = "ButtonNameTextBox"
        Me.ButtonNameTextBox.Width = 242
        '
        'InputLabel6
        '
        Me.InputLabel6.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel6.Name = "InputLabel6"
        Me.InputLabel6.Text = "Class Name:"
        '
        'ClassName
        '
        Me.ClassName.Break = C1.Win.C1InputPanel.BreakType.Group
        Me.ClassName.Height = 37
        Me.ClassName.Name = "ClassName"
        Me.ClassName.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Spread
        Me.ClassName.Width = 242
        '
        'InputLabel4
        '
        Me.InputLabel4.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel4.Name = "InputLabel4"
        Me.InputLabel4.Text = "Description:"
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.Height = 46
        Me.DescriptionTextBox.Multiline = True
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Spread
        Me.DescriptionTextBox.Width = 518
        '
        'ActiveCheckbox
        '
        Me.ActiveCheckbox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ActiveCheckbox.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.ActiveCheckbox.Name = "ActiveCheckbox"
        Me.ActiveCheckbox.Text = "Active"
        Me.ActiveCheckbox.Width = 515
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
        'User_Permission_Modules_Entry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(569, 386)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "User_Permission_Modules_Entry"
        Me.Text = "Access Modules Entry"
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Silver
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputLabel2 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents GroupNameComboBox As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents InputLabel5 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents ModuleNameTxtBox As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel3 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents ButtonNameTextBox As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel6 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents ClassName As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel4 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents DescriptionTextBox As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents ActiveCheckbox As C1.Win.C1InputPanel.InputCheckBox
    Friend WithEvents InputGroupHeader2 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents SaveRecordButton As C1.Win.C1InputPanel.InputButton
    Friend WithEvents ClearButton As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputButton3 As C1.Win.C1InputPanel.InputButton
End Class
