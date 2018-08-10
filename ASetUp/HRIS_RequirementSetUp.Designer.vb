<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HRIS_EmployeeRegistration_Requirements_SetUp
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
        Me.InputLabel3 = New C1.Win.C1InputPanel.InputLabel()
        Me.Requirement = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel5 = New C1.Win.C1InputPanel.InputLabel()
        Me.Description = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel6 = New C1.Win.C1InputPanel.InputLabel()
        Me.isActive = New C1.Win.C1InputPanel.InputCheckBox()
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
        Me.C1InputPanel3.Location = New System.Drawing.Point(16, 181)
        Me.C1InputPanel3.Margin = New System.Windows.Forms.Padding(4)
        Me.C1InputPanel3.Name = "C1InputPanel3"
        Me.C1InputPanel3.Padding = New System.Windows.Forms.Padding(5, 2, 5, 5)
        Me.C1InputPanel3.Size = New System.Drawing.Size(684, 46)
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
        Me.C1InputPanel1.Items.Add(Me.InputLabel3)
        Me.C1InputPanel1.Items.Add(Me.Requirement)
        Me.C1InputPanel1.Items.Add(Me.InputLabel5)
        Me.C1InputPanel1.Items.Add(Me.Description)
        Me.C1InputPanel1.Items.Add(Me.InputLabel6)
        Me.C1InputPanel1.Items.Add(Me.isActive)
        Me.C1InputPanel1.Location = New System.Drawing.Point(16, 15)
        Me.C1InputPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Padding = New System.Windows.Forms.Padding(5)
        Me.C1InputPanel1.Size = New System.Drawing.Size(684, 160)
        Me.C1InputPanel1.TabIndex = 65
        Me.C1InputPanel1.VisualStyle = C1.Win.C1InputPanel.VisualStyle.System
        '
        'InputGroupHeader2
        '
        Me.InputGroupHeader2.Height = 25
        Me.InputGroupHeader2.Name = "InputGroupHeader2"
        Me.InputGroupHeader2.Text = "Requirement SetUp"
        '
        'InputLabel3
        '
        Me.InputLabel3.Name = "InputLabel3"
        Me.InputLabel3.Text = "Requirement:"
        Me.InputLabel3.Width = 82
        '
        'Requirement
        '
        Me.Requirement.Name = "Requirement"
        Me.Requirement.Width = 390
        '
        'InputLabel5
        '
        Me.InputLabel5.Name = "InputLabel5"
        Me.InputLabel5.Text = "Description:"
        Me.InputLabel5.Width = 82
        '
        'Description
        '
        Me.Description.Height = 46
        Me.Description.Multiline = True
        Me.Description.Name = "Description"
        Me.Description.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Spread
        Me.Description.Width = 390
        '
        'InputLabel6
        '
        Me.InputLabel6.Name = "InputLabel6"
        Me.InputLabel6.Text = "Status:"
        Me.InputLabel6.Width = 82
        '
        'isActive
        '
        Me.isActive.Break = C1.Win.C1InputPanel.BreakType.None
        Me.isActive.CheckState = System.Windows.Forms.CheckState.Checked
        Me.isActive.Name = "isActive"
        Me.isActive.Text = "Active"
        '
        'HRIS_EmployeeRegistration_Requirements_SetUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 256)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.Controls.Add(Me.C1InputPanel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "HRIS_EmployeeRegistration_Requirements_SetUp"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Requirement SetUp"
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
    Friend WithEvents InputLabel5 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents Description As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel6 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents isActive As C1.Win.C1InputPanel.InputCheckBox
    Friend WithEvents InputLabel3 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents Requirement As C1.Win.C1InputPanel.InputTextBox

End Class
