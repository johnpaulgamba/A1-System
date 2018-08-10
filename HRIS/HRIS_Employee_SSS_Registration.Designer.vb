<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HRIS_Employee_SSS_Registration
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
        Me.InputGroupHeader2 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel1 = New C1.Win.C1InputPanel.InputLabel()
        Me.EmployeeName = New C1.Win.C1InputPanel.InputComboBox()
        Me.InputSeparator1 = New C1.Win.C1InputPanel.InputSeparator()
        Me.InputLabel3 = New C1.Win.C1InputPanel.InputLabel()
        Me.Reference = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel6 = New C1.Win.C1InputPanel.InputLabel()
        Me.basicsalary = New C1.Win.C1InputPanel.InputNumericBox()
        Me.InputSeparator2 = New C1.Win.C1InputPanel.InputSeparator()
        Me.InputLabel4 = New C1.Win.C1InputPanel.InputLabel()
        Me.eeshare = New C1.Win.C1InputPanel.InputNumericBox()
        Me.InputLabel5 = New C1.Win.C1InputPanel.InputLabel()
        Me.ecshare = New C1.Win.C1InputPanel.InputNumericBox()
        Me.InputLabel9 = New C1.Win.C1InputPanel.InputLabel()
        Me.ershare = New C1.Win.C1InputPanel.InputNumericBox()
        Me.InputLabel7 = New C1.Win.C1InputPanel.InputLabel()
        Me.ertotal = New C1.Win.C1InputPanel.InputNumericBox()
        Me.InputLabel2 = New C1.Win.C1InputPanel.InputLabel()
        Me.total = New C1.Win.C1InputPanel.InputNumericBox()
        Me.C1InputPanel3 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader5 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.SaveCommandButton = New C1.Win.C1InputPanel.InputButton()
        Me.InputButton4 = New C1.Win.C1InputPanel.InputButton()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.C1InputPanel1.Items.Add(Me.InputLabel3)
        Me.C1InputPanel1.Items.Add(Me.Reference)
        Me.C1InputPanel1.Items.Add(Me.InputLabel6)
        Me.C1InputPanel1.Items.Add(Me.basicsalary)
        Me.C1InputPanel1.Items.Add(Me.InputSeparator2)
        Me.C1InputPanel1.Items.Add(Me.InputLabel4)
        Me.C1InputPanel1.Items.Add(Me.eeshare)
        Me.C1InputPanel1.Items.Add(Me.InputLabel9)
        Me.C1InputPanel1.Items.Add(Me.ershare)
        Me.C1InputPanel1.Items.Add(Me.InputLabel5)
        Me.C1InputPanel1.Items.Add(Me.ecshare)
        Me.C1InputPanel1.Items.Add(Me.InputLabel7)
        Me.C1InputPanel1.Items.Add(Me.ertotal)
        Me.C1InputPanel1.Items.Add(Me.InputLabel2)
        Me.C1InputPanel1.Items.Add(Me.total)
        Me.C1InputPanel1.Location = New System.Drawing.Point(7, 6)
        Me.C1InputPanel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Padding = New System.Windows.Forms.Padding(5)
        Me.C1InputPanel1.Size = New System.Drawing.Size(557, 238)
        Me.C1InputPanel1.TabIndex = 67
        Me.C1InputPanel1.VisualStyle = C1.Win.C1InputPanel.VisualStyle.System
        '
        'InputGroupHeader2
        '
        Me.InputGroupHeader2.Height = 25
        Me.InputGroupHeader2.Name = "InputGroupHeader2"
        Me.InputGroupHeader2.Text = "Employee SSS Premium Contribution"
        '
        'InputLabel1
        '
        Me.InputLabel1.Name = "InputLabel1"
        Me.InputLabel1.Text = "Employee:"
        Me.InputLabel1.Width = 89
        '
        'EmployeeName
        '
        Me.EmployeeName.Name = "EmployeeName"
        Me.EmployeeName.Width = 411
        '
        'InputSeparator1
        '
        Me.InputSeparator1.Break = C1.Win.C1InputPanel.BreakType.Group
        Me.InputSeparator1.Name = "InputSeparator1"
        Me.InputSeparator1.Width = 503
        '
        'InputLabel3
        '
        Me.InputLabel3.Name = "InputLabel3"
        Me.InputLabel3.Text = "SSS No:"
        Me.InputLabel3.Width = 89
        '
        'Reference
        '
        Me.Reference.Name = "Reference"
        Me.Reference.Width = 411
        '
        'InputLabel6
        '
        Me.InputLabel6.Name = "InputLabel6"
        Me.InputLabel6.Text = "Basic Salary:"
        Me.InputLabel6.Width = 89
        '
        'basicsalary
        '
        Me.basicsalary.DecimalPlaces = 2
        Me.basicsalary.Format = "n"
        Me.basicsalary.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.basicsalary.Name = "basicsalary"
        Me.basicsalary.Width = 411
        '
        'InputSeparator2
        '
        Me.InputSeparator2.Name = "InputSeparator2"
        Me.InputSeparator2.Width = 503
        '
        'InputLabel4
        '
        Me.InputLabel4.Name = "InputLabel4"
        Me.InputLabel4.Text = "EE Share:"
        Me.InputLabel4.Width = 89
        '
        'eeshare
        '
        Me.eeshare.DecimalPlaces = 2
        Me.eeshare.Format = "n"
        Me.eeshare.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.eeshare.Name = "eeshare"
        Me.eeshare.Width = 409
        '
        'InputLabel5
        '
        Me.InputLabel5.Name = "InputLabel5"
        Me.InputLabel5.Text = "EC Share:"
        Me.InputLabel5.Width = 59
        '
        'ecshare
        '
        Me.ecshare.Break = C1.Win.C1InputPanel.BreakType.None
        Me.ecshare.DecimalPlaces = 2
        Me.ecshare.Format = "n"
        Me.ecshare.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.ecshare.Name = "ecshare"
        Me.ecshare.Width = 74
        '
        'InputLabel9
        '
        Me.InputLabel9.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Near
        Me.InputLabel9.Name = "InputLabel9"
        Me.InputLabel9.Text = "ER Share:"
        Me.InputLabel9.Width = 89
        '
        'ershare
        '
        Me.ershare.Break = C1.Win.C1InputPanel.BreakType.None
        Me.ershare.DecimalPlaces = 2
        Me.ershare.Format = "n"
        Me.ershare.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.ershare.Name = "ershare"
        Me.ershare.Width = 105
        '
        'InputLabel7
        '
        Me.InputLabel7.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Near
        Me.InputLabel7.Name = "InputLabel7"
        Me.InputLabel7.Text = "ER Total:"
        Me.InputLabel7.Width = 52
        '
        'ertotal
        '
        Me.ertotal.DecimalPlaces = 2
        Me.ertotal.Format = "n"
        Me.ertotal.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.ertotal.Name = "ertotal"
        Me.ertotal.Width = 105
        '
        'InputLabel2
        '
        Me.InputLabel2.Name = "InputLabel2"
        Me.InputLabel2.Text = "Total Premium:"
        Me.InputLabel2.Width = 89
        '
        'total
        '
        Me.total.DecimalPlaces = 2
        Me.total.Format = "n"
        Me.total.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.total.Name = "total"
        Me.total.Width = 409
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
        Me.C1InputPanel3.Location = New System.Drawing.Point(4, 248)
        Me.C1InputPanel3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.C1InputPanel3.Name = "C1InputPanel3"
        Me.C1InputPanel3.Padding = New System.Windows.Forms.Padding(5, 2, 5, 5)
        Me.C1InputPanel3.Size = New System.Drawing.Size(560, 46)
        Me.C1InputPanel3.TabIndex = 66
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
        'HRIS_Employee_SSS_Registration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 312)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.Controls.Add(Me.C1InputPanel3)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "HRIS_Employee_SSS_Registration"
        Me.Text = "Employee SSS Premium"
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader2 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputLabel1 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents EmployeeName As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents InputSeparator1 As C1.Win.C1InputPanel.InputSeparator
    Friend WithEvents InputLabel3 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents Reference As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel6 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents basicsalary As C1.Win.C1InputPanel.InputNumericBox
    Friend WithEvents InputSeparator2 As C1.Win.C1InputPanel.InputSeparator
    Friend WithEvents InputLabel4 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents eeshare As C1.Win.C1InputPanel.InputNumericBox
    Friend WithEvents InputLabel5 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents ecshare As C1.Win.C1InputPanel.InputNumericBox
    Friend WithEvents InputLabel9 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents ershare As C1.Win.C1InputPanel.InputNumericBox
    Friend WithEvents InputLabel2 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents total As C1.Win.C1InputPanel.InputNumericBox
    Friend WithEvents C1InputPanel3 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader5 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents SaveCommandButton As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputButton4 As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputLabel7 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents ertotal As C1.Win.C1InputPanel.InputNumericBox
End Class
