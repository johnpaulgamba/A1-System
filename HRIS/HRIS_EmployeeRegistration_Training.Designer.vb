<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HRIS_EmployeeRegistration_Training
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
        Me.InputLabel6 = New C1.Win.C1InputPanel.InputLabel()
        Me.DateFrom = New C1.Win.C1InputPanel.InputDatePicker()
        Me.InputLabel7 = New C1.Win.C1InputPanel.InputLabel()
        Me.DateTo = New C1.Win.C1InputPanel.InputDatePicker()
        Me.InputLabel5 = New C1.Win.C1InputPanel.InputLabel()
        Me.NameOfSchool = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel2 = New C1.Win.C1InputPanel.InputLabel()
        Me.No_of_hours = New C1.Win.C1InputPanel.InputNumericBox()
        Me.InputLabel4 = New C1.Win.C1InputPanel.InputLabel()
        Me.Conductedby = New C1.Win.C1InputPanel.InputComboBox()
        Me.InputLabel3 = New C1.Win.C1InputPanel.InputLabel()
        Me.Remarks = New C1.Win.C1InputPanel.InputTextBox()
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
        Me.C1InputPanel3.Location = New System.Drawing.Point(16, 411)
        Me.C1InputPanel3.Margin = New System.Windows.Forms.Padding(4)
        Me.C1InputPanel3.Name = "C1InputPanel3"
        Me.C1InputPanel3.Padding = New System.Windows.Forms.Padding(5, 0, 5, 5)
        Me.C1InputPanel3.Size = New System.Drawing.Size(686, 46)
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
        Me.C1InputPanel1.Items.Add(Me.NameOfSchool)
        Me.C1InputPanel1.Items.Add(Me.InputLabel6)
        Me.C1InputPanel1.Items.Add(Me.DateFrom)
        Me.C1InputPanel1.Items.Add(Me.InputLabel7)
        Me.C1InputPanel1.Items.Add(Me.DateTo)
        Me.C1InputPanel1.Items.Add(Me.InputLabel2)
        Me.C1InputPanel1.Items.Add(Me.No_of_hours)
        Me.C1InputPanel1.Items.Add(Me.InputLabel4)
        Me.C1InputPanel1.Items.Add(Me.Conductedby)
        Me.C1InputPanel1.Items.Add(Me.InputLabel3)
        Me.C1InputPanel1.Items.Add(Me.Remarks)
        Me.C1InputPanel1.Items.Add(Me.Active)
        Me.C1InputPanel1.Location = New System.Drawing.Point(16, 15)
        Me.C1InputPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Padding = New System.Windows.Forms.Padding(5)
        Me.C1InputPanel1.Size = New System.Drawing.Size(686, 389)
        Me.C1InputPanel1.TabIndex = 65
        Me.C1InputPanel1.VisualStyle = C1.Win.C1InputPanel.VisualStyle.System
        '
        'InputGroupHeader2
        '
        Me.InputGroupHeader2.Height = 25
        Me.InputGroupHeader2.Name = "InputGroupHeader2"
        Me.InputGroupHeader2.Text = "Training, Seminars, Workshop and Short Courses Details"
        '
        'InputLabel1
        '
        Me.InputLabel1.Name = "InputLabel1"
        Me.InputLabel1.Text = "Employee Name:"
        Me.InputLabel1.Width = 91
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
        'InputLabel6
        '
        Me.InputLabel6.Name = "InputLabel6"
        Me.InputLabel6.Text = "Date From: "
        Me.InputLabel6.Width = 91
        '
        'DateFrom
        '
        Me.DateFrom.Break = C1.Win.C1InputPanel.BreakType.None
        Me.DateFrom.Name = "DateFrom"
        Me.DateFrom.Width = 126
        '
        'InputLabel7
        '
        Me.InputLabel7.Name = "InputLabel7"
        Me.InputLabel7.Text = "To:"
        Me.InputLabel7.Width = 35
        '
        'DateTo
        '
        Me.DateTo.Name = "DateTo"
        Me.DateTo.Width = 136
        '
        'InputLabel5
        '
        Me.InputLabel5.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel5.Name = "InputLabel5"
        Me.InputLabel5.Text = "Title of Seminar / Conference / Workshop / Short Courses"
        Me.InputLabel5.Width = 483
        '
        'NameOfSchool
        '
        Me.NameOfSchool.Height = 70
        Me.NameOfSchool.Multiline = True
        Me.NameOfSchool.Name = "NameOfSchool"
        Me.NameOfSchool.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Spread
        Me.NameOfSchool.Width = 482
        '
        'InputLabel2
        '
        Me.InputLabel2.Name = "InputLabel2"
        Me.InputLabel2.Text = "No of Hours:"
        Me.InputLabel2.Width = 93
        '
        'No_of_hours
        '
        Me.No_of_hours.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.No_of_hours.Name = "No_of_hours"
        '
        'InputLabel4
        '
        Me.InputLabel4.Name = "InputLabel4"
        Me.InputLabel4.Text = "Conducted By:"
        Me.InputLabel4.Width = 91
        '
        'Conductedby
        '
        Me.Conductedby.Name = "Conductedby"
        Me.Conductedby.Width = 390
        '
        'InputLabel3
        '
        Me.InputLabel3.Name = "InputLabel3"
        Me.InputLabel3.Text = "Remarks:"
        Me.InputLabel3.Width = 91
        '
        'Remarks
        '
        Me.Remarks.Height = 67
        Me.Remarks.Multiline = True
        Me.Remarks.Name = "Remarks"
        Me.Remarks.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Spread
        Me.Remarks.Width = 390
        '
        'Active
        '
        Me.Active.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Active.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.Active.Name = "Active"
        Me.Active.Text = "&Active"
        Me.Active.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        Me.Active.Width = 475
        '
        'HRIS_EmployeeRegistration_Training
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 471)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.Controls.Add(Me.C1InputPanel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "HRIS_EmployeeRegistration_Training"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Employee Training Registration"
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
    Friend WithEvents NameOfSchool As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel1 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel4 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents Conductedby As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents InputLabel3 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents Remarks As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel6 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel7 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents EmployeeName As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents Active As C1.Win.C1InputPanel.InputCheckBox
    Friend WithEvents DateFrom As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents DateTo As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents InputLabel2 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents No_of_hours As C1.Win.C1InputPanel.InputNumericBox

End Class
