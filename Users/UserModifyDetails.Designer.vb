<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class useraccountmodifydetails
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
        Me.InputLabel6 = New C1.Win.C1InputPanel.InputLabel()
        Me.EmailAddress = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputGroupHeader2 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.SaveRecordButton = New C1.Win.C1InputPanel.InputButton()
        Me.InputButton3 = New C1.Win.C1InputPanel.InputButton()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.BackColor = System.Drawing.Color.Transparent
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader1)
        Me.C1InputPanel1.Items.Add(Me.InputLabel4)
        Me.C1InputPanel1.Items.Add(Me.UserName)
        Me.C1InputPanel1.Items.Add(Me.InputLabel8)
        Me.C1InputPanel1.Items.Add(Me.FullName)
        Me.C1InputPanel1.Items.Add(Me.InputLabel9)
        Me.C1InputPanel1.Items.Add(Me.Department)
        Me.C1InputPanel1.Items.Add(Me.InputLabel6)
        Me.C1InputPanel1.Items.Add(Me.EmailAddress)
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader2)
        Me.C1InputPanel1.Items.Add(Me.SaveRecordButton)
        Me.C1InputPanel1.Items.Add(Me.InputButton3)
        Me.C1InputPanel1.Location = New System.Drawing.Point(23, 29)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(431, 210)
        Me.C1InputPanel1.TabIndex = 1
        Me.C1InputPanel1.VisualStyle = C1.Win.C1InputPanel.VisualStyle.System
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Height = 22
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        Me.InputGroupHeader1.Text = "User Details"
        '
        'InputLabel4
        '
        Me.InputLabel4.Name = "InputLabel4"
        Me.InputLabel4.Text = "User Name:"
        Me.InputLabel4.Width = 70
        '
        'UserName
        '
        Me.UserName.Name = "UserName"
        Me.UserName.ReadOnly = True
        Me.UserName.Width = 335
        '
        'InputLabel8
        '
        Me.InputLabel8.Name = "InputLabel8"
        Me.InputLabel8.Text = "Full Name:"
        Me.InputLabel8.Width = 70
        '
        'FullName
        '
        Me.FullName.Name = "FullName"
        Me.FullName.Width = 335
        '
        'InputLabel9
        '
        Me.InputLabel9.Name = "InputLabel9"
        Me.InputLabel9.Text = "Department:"
        Me.InputLabel9.Width = 70
        '
        'Department
        '
        Me.Department.Name = "Department"
        Me.Department.Width = 335
        '
        'InputLabel6
        '
        Me.InputLabel6.Name = "InputLabel6"
        Me.InputLabel6.Text = "Email:"
        Me.InputLabel6.Width = 70
        '
        'EmailAddress
        '
        Me.EmailAddress.Name = "EmailAddress"
        Me.EmailAddress.Width = 335
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
        Me.SaveRecordButton.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.SaveRecordButton.Image = Global.A1plus.My.Resources.Resources.SaveAllHS
        Me.SaveRecordButton.Name = "SaveRecordButton"
        Me.SaveRecordButton.Text = "Save Record"
        Me.SaveRecordButton.Width = 322
        '
        'InputButton3
        '
        Me.InputButton3.Image = Global.A1plus.My.Resources.Resources.no
        Me.InputButton3.Name = "InputButton3"
        Me.InputButton3.Text = "Close"
        Me.InputButton3.Width = 84
        '
        'UserAccountModifyDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(472, 269)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UserAccountModifyDetails"
        Me.Text = "Modify User details"
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
    Friend WithEvents InputLabel6 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents EmailAddress As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputGroupHeader2 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents SaveRecordButton As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputButton3 As C1.Win.C1InputPanel.InputButton
End Class
