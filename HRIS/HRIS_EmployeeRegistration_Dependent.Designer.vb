<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HRIS_EmployeeRegistration_Dependent
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
        Me.C1InputPanel3 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader5 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.SaveCommandButton = New C1.Win.C1InputPanel.InputButton()
        Me.InputButton2 = New C1.Win.C1InputPanel.InputButton()
        Me.InputButton4 = New C1.Win.C1InputPanel.InputButton()
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader2 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel1 = New C1.Win.C1InputPanel.InputLabel()
        Me.EmployeeName = New C1.Win.C1InputPanel.InputComboBox()
        Me.InputSeparator1 = New C1.Win.C1InputPanel.InputSeparator()
        Me.InputLabel5 = New C1.Win.C1InputPanel.InputLabel()
        Me.DependentName = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel4 = New C1.Win.C1InputPanel.InputLabel()
        Me.RelationShip = New C1.Win.C1InputPanel.InputComboBox()
        Me.InputLabel7 = New C1.Win.C1InputPanel.InputLabel()
        Me.Occupation = New C1.Win.C1InputPanel.InputComboBox()
        Me.InputLabel8 = New C1.Win.C1InputPanel.InputLabel()
        Me.Gender = New C1.Win.C1InputPanel.InputComboBox()
        Me.InputLabel18 = New C1.Win.C1InputPanel.InputLabel()
        Me.Birthdate = New C1.Win.C1InputPanel.InputDatePicker()
        Me.InputLabel9 = New C1.Win.C1InputPanel.InputLabel()
        Me.Age = New C1.Win.C1InputPanel.InputNumericBox()
        Me.InputLabel13 = New C1.Win.C1InputPanel.InputLabel()
        Me.Address = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel3 = New C1.Win.C1InputPanel.InputLabel()
        Me.Remarks = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel6 = New C1.Win.C1InputPanel.InputLabel()
        Me.EmergencyContact = New C1.Win.C1InputPanel.InputCheckBox()
        Me.Active = New C1.Win.C1InputPanel.InputCheckBox()
        CType(Me.C1InputPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel3
        '
        Me.C1InputPanel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1InputPanel3.BackColor = System.Drawing.SystemColors.Control
        Me.C1InputPanel3.BorderThickness = 1
        Me.C1InputPanel3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1InputPanel3.Items.Add(Me.InputGroupHeader5)
        Me.C1InputPanel3.Items.Add(Me.SaveCommandButton)
        Me.C1InputPanel3.Items.Add(Me.InputButton2)
        Me.C1InputPanel3.Items.Add(Me.InputButton4)
        Me.C1InputPanel3.Location = New System.Drawing.Point(12, 256)
        Me.C1InputPanel3.Name = "C1InputPanel3"
        Me.C1InputPanel3.Padding = New System.Windows.Forms.Padding(5, 0, 5, 5)
        Me.C1InputPanel3.Size = New System.Drawing.Size(513, 37)
        Me.C1InputPanel3.TabIndex = 64
        Me.C1InputPanel3.VisualStyle = C1.Win.C1InputPanel.VisualStyle.System
        '
        'InputGroupHeader5
        '
        Me.InputGroupHeader5.BackColor = System.Drawing.Color.Transparent
        Me.InputGroupHeader5.Height = 2
        Me.InputGroupHeader5.Name = "InputGroupHeader5"
        Me.InputGroupHeader5.Text = "Purchasing : Item Details"
        '
        'SaveCommandButton
        '
        Me.SaveCommandButton.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.SaveCommandButton.Image = Global.A1plus.My.Resources.Resources.SaveAllHS
        Me.SaveCommandButton.Name = "SaveCommandButton"
        Me.SaveCommandButton.Text = "&Save Record"
        '
        'InputButton2
        '
        Me.InputButton2.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.InputButton2.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Near
        Me.InputButton2.Image = Global.A1plus.My.Resources.Resources.DocumentHS2
        Me.InputButton2.Name = "InputButton2"
        Me.InputButton2.Text = "&New Record"
        '
        'InputButton4
        '
        Me.InputButton4.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.InputButton4.Image = Global.A1plus.My.Resources.Resources.no
        Me.InputButton4.Name = "InputButton4"
        Me.InputButton4.Text = "&Close Form"
        Me.InputButton4.Width = 91
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1InputPanel1.BackColor = System.Drawing.SystemColors.Control
        Me.C1InputPanel1.BorderThickness = 1
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader2)
        Me.C1InputPanel1.Items.Add(Me.InputLabel1)
        Me.C1InputPanel1.Items.Add(Me.EmployeeName)
        Me.C1InputPanel1.Items.Add(Me.InputSeparator1)
        Me.C1InputPanel1.Items.Add(Me.InputLabel5)
        Me.C1InputPanel1.Items.Add(Me.DependentName)
        Me.C1InputPanel1.Items.Add(Me.InputLabel4)
        Me.C1InputPanel1.Items.Add(Me.RelationShip)
        Me.C1InputPanel1.Items.Add(Me.InputLabel8)
        Me.C1InputPanel1.Items.Add(Me.Gender)
        Me.C1InputPanel1.Items.Add(Me.InputLabel18)
        Me.C1InputPanel1.Items.Add(Me.Birthdate)
        Me.C1InputPanel1.Items.Add(Me.InputLabel9)
        Me.C1InputPanel1.Items.Add(Me.Age)
        Me.C1InputPanel1.Items.Add(Me.InputLabel13)
        Me.C1InputPanel1.Items.Add(Me.Address)
        Me.C1InputPanel1.Items.Add(Me.InputLabel6)
        Me.C1InputPanel1.Items.Add(Me.EmergencyContact)
        Me.C1InputPanel1.Items.Add(Me.Active)
        Me.C1InputPanel1.Items.Add(Me.InputLabel3)
        Me.C1InputPanel1.Items.Add(Me.Remarks)
        Me.C1InputPanel1.Items.Add(Me.InputLabel7)
        Me.C1InputPanel1.Items.Add(Me.Occupation)
        Me.C1InputPanel1.Location = New System.Drawing.Point(12, 12)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Padding = New System.Windows.Forms.Padding(5)
        Me.C1InputPanel1.Size = New System.Drawing.Size(513, 238)
        Me.C1InputPanel1.TabIndex = 65
        Me.C1InputPanel1.VisualStyle = C1.Win.C1InputPanel.VisualStyle.System
        '
        'InputGroupHeader2
        '
        Me.InputGroupHeader2.Height = 25
        Me.InputGroupHeader2.Name = "InputGroupHeader2"
        Me.InputGroupHeader2.Text = "Dependent/s Personal Information"
        '
        'InputLabel1
        '
        Me.InputLabel1.Name = "InputLabel1"
        Me.InputLabel1.Text = "Employee:"
        Me.InputLabel1.Width = 82
        '
        'EmployeeName
        '
        Me.EmployeeName.Name = "EmployeeName"
        Me.EmployeeName.Width = 390
        '
        'InputSeparator1
        '
        Me.InputSeparator1.Break = C1.Win.C1InputPanel.BreakType.Group
        Me.InputSeparator1.Name = "InputSeparator1"
        Me.InputSeparator1.Width = 482
        '
        'InputLabel5
        '
        Me.InputLabel5.Name = "InputLabel5"
        Me.InputLabel5.Text = "Name:"
        Me.InputLabel5.Width = 82
        '
        'DependentName
        '
        Me.DependentName.Name = "DependentName"
        Me.DependentName.Width = 390
        '
        'InputLabel4
        '
        Me.InputLabel4.Name = "InputLabel4"
        Me.InputLabel4.Text = "Relationship:"
        Me.InputLabel4.Width = 82
        '
        'RelationShip
        '
        Me.RelationShip.Name = "RelationShip"
        Me.RelationShip.Width = 390
        '
        'InputLabel7
        '
        Me.InputLabel7.Name = "InputLabel7"
        Me.InputLabel7.Text = "Occupation:"
        Me.InputLabel7.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        Me.InputLabel7.Width = 82
        '
        'Occupation
        '
        Me.Occupation.Name = "Occupation"
        Me.Occupation.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        Me.Occupation.Width = 390
        '
        'InputLabel8
        '
        Me.InputLabel8.Name = "InputLabel8"
        Me.InputLabel8.Text = "Gender:"
        Me.InputLabel8.Width = 82
        '
        'Gender
        '
        Me.Gender.Break = C1.Win.C1InputPanel.BreakType.None
        Me.Gender.Name = "Gender"
        Me.Gender.Width = 91
        '
        'InputLabel18
        '
        Me.InputLabel18.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.InputLabel18.Name = "InputLabel18"
        Me.InputLabel18.Text = "Birth Date:"
        Me.InputLabel18.Width = 63
        '
        'Birthdate
        '
        Me.Birthdate.Break = C1.Win.C1InputPanel.BreakType.None
        Me.Birthdate.Name = "Birthdate"
        Me.Birthdate.Width = 119
        '
        'InputLabel9
        '
        Me.InputLabel9.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center
        Me.InputLabel9.Name = "InputLabel9"
        Me.InputLabel9.Text = "Age:"
        Me.InputLabel9.Width = 30
        '
        'Age
        '
        Me.Age.Minimum = New Decimal(New Integer() {10000, 0, 0, -2147483648})
        Me.Age.Name = "Age"
        Me.Age.ShowSpinButtons = False
        Me.Age.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Age.Width = 71
        '
        'InputLabel13
        '
        Me.InputLabel13.Name = "InputLabel13"
        Me.InputLabel13.Text = "Address:"
        Me.InputLabel13.Width = 82
        '
        'Address
        '
        Me.Address.Name = "Address"
        Me.Address.Width = 390
        '
        'InputLabel3
        '
        Me.InputLabel3.Name = "InputLabel3"
        Me.InputLabel3.Text = "Remarks:"
        Me.InputLabel3.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        Me.InputLabel3.Width = 82
        '
        'Remarks
        '
        Me.Remarks.Name = "Remarks"
        Me.Remarks.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        Me.Remarks.Width = 390
        '
        'InputLabel6
        '
        Me.InputLabel6.Name = "InputLabel6"
        Me.InputLabel6.Text = "Options:"
        Me.InputLabel6.Width = 82
        '
        'EmergencyContact
        '
        Me.EmergencyContact.Break = C1.Win.C1InputPanel.BreakType.None
        Me.EmergencyContact.Name = "EmergencyContact"
        Me.EmergencyContact.Text = "Emergency Contact"
        Me.EmergencyContact.Width = 124
        '
        'Active
        '
        Me.Active.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Active.Name = "Active"
        Me.Active.Text = "Active"
        '
        'HRIS_EmployeeRegistration_Dependent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 320)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.Controls.Add(Me.C1InputPanel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "HRIS_EmployeeRegistration_Dependent"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Employee Dependent/s Registration"
        CType(Me.C1InputPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1InputPanel3 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader5 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents SaveCommandButton As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputButton2 As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputButton4 As C1.Win.C1InputPanel.InputButton
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader2 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputSeparator1 As C1.Win.C1InputPanel.InputSeparator
    Friend WithEvents InputLabel5 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents DependentName As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel7 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents Occupation As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents InputLabel13 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents Address As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel18 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents Birthdate As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents InputLabel4 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents RelationShip As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents InputLabel3 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents Remarks As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel6 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents EmergencyContact As C1.Win.C1InputPanel.InputCheckBox
    Friend WithEvents Active As C1.Win.C1InputPanel.InputCheckBox
    Friend WithEvents InputLabel8 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents Gender As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents InputLabel9 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents Age As C1.Win.C1InputPanel.InputNumericBox
    Friend WithEvents InputLabel1 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents EmployeeName As C1.Win.C1InputPanel.InputComboBox

End Class
