<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PayrollPeriodRegistration
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
        Me.InputLabel3 = New C1.Win.C1InputPanel.InputLabel()
        Me.companyname = New C1.Win.C1InputPanel.InputComboBox()
        Me.InputSeparator1 = New C1.Win.C1InputPanel.InputSeparator()
        Me.InputLabel4 = New C1.Win.C1InputPanel.InputLabel()
        Me.payrollgroup = New C1.Win.C1InputPanel.InputComboBox()
        Me.InputLabel5 = New C1.Win.C1InputPanel.InputLabel()
        Me.PayrollDate = New C1.Win.C1InputPanel.InputDatePicker()
        Me.InputLabel6 = New C1.Win.C1InputPanel.InputLabel()
        Me.PeriodFrom = New C1.Win.C1InputPanel.InputDatePicker()
        Me.InputLabel2 = New C1.Win.C1InputPanel.InputLabel()
        Me.PeriodTo = New C1.Win.C1InputPanel.InputDatePicker()
        Me.InputLabel7 = New C1.Win.C1InputPanel.InputLabel()
        Me.Cut_offfrom = New C1.Win.C1InputPanel.InputDatePicker()
        Me.InputLabel8 = New C1.Win.C1InputPanel.InputLabel()
        Me.Cut_offto = New C1.Win.C1InputPanel.InputDatePicker()
        Me.InputLabel1 = New C1.Win.C1InputPanel.InputLabel()
        Me.payrollname = New C1.Win.C1InputPanel.InputTextBox()
        Me.C1InputPanel3 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader5 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.SaveCommandButton = New C1.Win.C1InputPanel.InputButton()
        Me.InputButton2 = New C1.Win.C1InputPanel.InputButton()
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
        Me.C1InputPanel1.BorderThickness = 1
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader1)
        Me.C1InputPanel1.Items.Add(Me.InputLabel3)
        Me.C1InputPanel1.Items.Add(Me.companyname)
        Me.C1InputPanel1.Items.Add(Me.InputSeparator1)
        Me.C1InputPanel1.Items.Add(Me.InputLabel4)
        Me.C1InputPanel1.Items.Add(Me.payrollgroup)
        Me.C1InputPanel1.Items.Add(Me.InputLabel5)
        Me.C1InputPanel1.Items.Add(Me.PayrollDate)
        Me.C1InputPanel1.Items.Add(Me.InputLabel6)
        Me.C1InputPanel1.Items.Add(Me.PeriodFrom)
        Me.C1InputPanel1.Items.Add(Me.InputLabel2)
        Me.C1InputPanel1.Items.Add(Me.PeriodTo)
        Me.C1InputPanel1.Items.Add(Me.InputLabel7)
        Me.C1InputPanel1.Items.Add(Me.Cut_offfrom)
        Me.C1InputPanel1.Items.Add(Me.InputLabel8)
        Me.C1InputPanel1.Items.Add(Me.Cut_offto)
        Me.C1InputPanel1.Items.Add(Me.InputLabel1)
        Me.C1InputPanel1.Items.Add(Me.payrollname)
        Me.C1InputPanel1.Location = New System.Drawing.Point(0, 3)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(505, 269)
        Me.C1InputPanel1.TabIndex = 8
        Me.C1InputPanel1.VisualStyle = C1.Win.C1InputPanel.VisualStyle.System
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        Me.InputGroupHeader1.Text = "Payroll Period Registration"
        '
        'InputLabel3
        '
        Me.InputLabel3.Name = "InputLabel3"
        Me.InputLabel3.Text = "Company:"
        Me.InputLabel3.Width = 100
        '
        'companyname
        '
        Me.companyname.Name = "companyname"
        Me.companyname.Width = 300
        '
        'InputSeparator1
        '
        Me.InputSeparator1.Name = "InputSeparator1"
        Me.InputSeparator1.Width = 425
        '
        'InputLabel4
        '
        Me.InputLabel4.Name = "InputLabel4"
        Me.InputLabel4.Text = "Payroll Group:"
        Me.InputLabel4.Width = 100
        '
        'payrollgroup
        '
        Me.payrollgroup.Name = "payrollgroup"
        Me.payrollgroup.Width = 300
        '
        'InputLabel5
        '
        Me.InputLabel5.Name = "InputLabel5"
        Me.InputLabel5.Text = "Payroll Date:"
        Me.InputLabel5.Width = 100
        '
        'PayrollDate
        '
        Me.PayrollDate.Name = "PayrollDate"
        Me.PayrollDate.Width = 300
        '
        'InputLabel6
        '
        Me.InputLabel6.Name = "InputLabel6"
        Me.InputLabel6.Text = "Payroll Period"
        Me.InputLabel6.Width = 100
        '
        'PeriodFrom
        '
        Me.PeriodFrom.Break = C1.Win.C1InputPanel.BreakType.None
        Me.PeriodFrom.Name = "PeriodFrom"
        Me.PeriodFrom.Width = 137
        '
        'InputLabel2
        '
        Me.InputLabel2.Name = "InputLabel2"
        Me.InputLabel2.Text = "To"
        Me.InputLabel2.Width = 17
        '
        'PeriodTo
        '
        Me.PeriodTo.Name = "PeriodTo"
        Me.PeriodTo.Width = 137
        '
        'InputLabel7
        '
        Me.InputLabel7.Name = "InputLabel7"
        Me.InputLabel7.Text = "Cut-Off Date"
        Me.InputLabel7.Width = 100
        '
        'Cut_offfrom
        '
        Me.Cut_offfrom.Break = C1.Win.C1InputPanel.BreakType.None
        Me.Cut_offfrom.Name = "Cut_offfrom"
        Me.Cut_offfrom.Width = 137
        '
        'InputLabel8
        '
        Me.InputLabel8.Name = "InputLabel8"
        Me.InputLabel8.Text = "To"
        Me.InputLabel8.Width = 17
        '
        'Cut_offto
        '
        Me.Cut_offto.Name = "Cut_offto"
        Me.Cut_offto.Width = 137
        '
        'InputLabel1
        '
        Me.InputLabel1.Name = "InputLabel1"
        Me.InputLabel1.Text = "Payroll Name:"
        Me.InputLabel1.Width = 100
        '
        'payrollname
        '
        Me.payrollname.Height = 71
        Me.payrollname.Multiline = True
        Me.payrollname.Name = "payrollname"
        Me.payrollname.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Spread
        Me.payrollname.Width = 300
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
        Me.C1InputPanel3.Location = New System.Drawing.Point(0, 269)
        Me.C1InputPanel3.Name = "C1InputPanel3"
        Me.C1InputPanel3.Padding = New System.Windows.Forms.Padding(5, 2, 5, 5)
        Me.C1InputPanel3.Size = New System.Drawing.Size(505, 37)
        Me.C1InputPanel3.TabIndex = 65
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
        'PayrollPeriodRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(505, 318)
        Me.Controls.Add(Me.C1InputPanel3)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PayrollPeriodRegistration"
        Me.Text = "Payroll Registration"
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
    Private WithEvents InputLabel1 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents payrollname As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel3 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents companyname As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents InputLabel4 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents payrollgroup As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents InputLabel5 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents PayrollDate As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents InputLabel6 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents PeriodFrom As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents InputLabel2 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents PeriodTo As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents InputSeparator1 As C1.Win.C1InputPanel.InputSeparator
    Friend WithEvents C1InputPanel3 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader5 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents SaveCommandButton As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputButton2 As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputButton4 As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputLabel7 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents Cut_offfrom As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents InputLabel8 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents Cut_offto As C1.Win.C1InputPanel.InputDatePicker
End Class
