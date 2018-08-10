<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HRIS_Employee_Bank_Registration
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
        Me.InputButton4 = New C1.Win.C1InputPanel.InputButton()
        Me.InputLabel6 = New C1.Win.C1InputPanel.InputLabel()
        Me.Reference = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel3 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputSeparator1 = New C1.Win.C1InputPanel.InputSeparator()
        Me.EmployeeName = New C1.Win.C1InputPanel.InputComboBox()
        Me.InputLabel1 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputGroupHeader2 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.PaymentMethod = New C1.Win.C1InputPanel.InputComboBox()
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
        Me.C1InputPanel3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1InputPanel3.Items.Add(Me.InputGroupHeader5)
        Me.C1InputPanel3.Items.Add(Me.SaveCommandButton)
        Me.C1InputPanel3.Items.Add(Me.InputButton4)
        Me.C1InputPanel3.Location = New System.Drawing.Point(2, 189)
        Me.C1InputPanel3.Margin = New System.Windows.Forms.Padding(4)
        Me.C1InputPanel3.Name = "C1InputPanel3"
        Me.C1InputPanel3.Padding = New System.Windows.Forms.Padding(5, 2, 5, 5)
        Me.C1InputPanel3.Size = New System.Drawing.Size(550, 48)
        Me.C1InputPanel3.TabIndex = 68
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
        'InputButton4
        '
        Me.InputButton4.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.InputButton4.Image = Global.A1plus.My.Resources.Resources.no
        Me.InputButton4.Name = "InputButton4"
        Me.InputButton4.Text = "&Close Form"
        Me.InputButton4.Width = 121
        '
        'InputLabel6
        '
        Me.InputLabel6.Name = "InputLabel6"
        Me.InputLabel6.Text = "Payment Method:"
        Me.InputLabel6.Width = 111
        '
        'Reference
        '
        Me.Reference.Name = "Reference"
        Me.Reference.Width = 377
        '
        'InputLabel3
        '
        Me.InputLabel3.Name = "InputLabel3"
        Me.InputLabel3.Text = "ATM Account No:"
        Me.InputLabel3.Width = 111
        '
        'InputSeparator1
        '
        Me.InputSeparator1.Break = C1.Win.C1InputPanel.BreakType.Group
        Me.InputSeparator1.Name = "InputSeparator1"
        Me.InputSeparator1.Width = 509
        '
        'EmployeeName
        '
        Me.EmployeeName.Name = "EmployeeName"
        Me.EmployeeName.Width = 377
        '
        'InputLabel1
        '
        Me.InputLabel1.Name = "InputLabel1"
        Me.InputLabel1.Text = "Employee:"
        Me.InputLabel1.Width = 111
        '
        'InputGroupHeader2
        '
        Me.InputGroupHeader2.Height = 25
        Me.InputGroupHeader2.Name = "InputGroupHeader2"
        Me.InputGroupHeader2.Text = "Payroll ATM Account No:"
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1InputPanel1.BackColor = System.Drawing.SystemColors.Control
        Me.C1InputPanel1.BorderThickness = 1
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader2)
        Me.C1InputPanel1.Items.Add(Me.InputLabel1)
        Me.C1InputPanel1.Items.Add(Me.EmployeeName)
        Me.C1InputPanel1.Items.Add(Me.InputSeparator1)
        Me.C1InputPanel1.Items.Add(Me.InputLabel6)
        Me.C1InputPanel1.Items.Add(Me.PaymentMethod)
        Me.C1InputPanel1.Items.Add(Me.InputLabel3)
        Me.C1InputPanel1.Items.Add(Me.Reference)
        Me.C1InputPanel1.Location = New System.Drawing.Point(2, 1)
        Me.C1InputPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Padding = New System.Windows.Forms.Padding(5)
        Me.C1InputPanel1.Size = New System.Drawing.Size(550, 188)
        Me.C1InputPanel1.TabIndex = 69
        Me.C1InputPanel1.VisualStyle = C1.Win.C1InputPanel.VisualStyle.System
        '
        'PaymentMethod
        '
        Me.PaymentMethod.Name = "PaymentMethod"
        Me.PaymentMethod.Width = 376
        '
        'HRIS_Employee_Bank_Registration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 245)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.Controls.Add(Me.C1InputPanel3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "HRIS_Employee_Bank_Registration"
        Me.Text = "ATM Account_No Registration"
        CType(Me.C1InputPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1InputPanel3 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader5 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents SaveCommandButton As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputButton4 As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputLabel6 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents Reference As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel3 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputSeparator1 As C1.Win.C1InputPanel.InputSeparator
    Friend WithEvents EmployeeName As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents InputLabel1 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputGroupHeader2 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents PaymentMethod As C1.Win.C1InputPanel.InputComboBox
End Class
