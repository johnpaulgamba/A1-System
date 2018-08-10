<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class hris_EmploymentStatusRegistration
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
        Me.InputLabel18 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel9 = New C1.Win.C1InputPanel.InputLabel()
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader2 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.SaveRecord = New C1.Win.C1InputPanel.InputButton()
        Me.CreateNewrecord = New C1.Win.C1InputPanel.InputButton()
        Me.CloseForm = New C1.Win.C1InputPanel.InputButton()
        Me.C1InputPanel6 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputImage1 = New C1.Win.C1InputPanel.InputImage()
        Me.InputLabel2 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel4 = New C1.Win.C1InputPanel.InputLabel()
        Me.EmploymentStatus = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel1 = New C1.Win.C1InputPanel.InputLabel()
        Me.Description = New C1.Win.C1InputPanel.InputTextBox()
        Me.Status = New C1.Win.C1InputPanel.InputCheckBox()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'InputLabel18
        '
        Me.InputLabel18.ForeColor = System.Drawing.Color.DarkGray
        Me.InputLabel18.Height = 11
        Me.InputLabel18.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Near
        Me.InputLabel18.Name = "InputLabel18"
        Me.InputLabel18.Text = "- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -" & _
            " - - - - - - - - - - - - - - - - - - - "
        Me.InputLabel18.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Near
        Me.InputLabel18.Width = 270
        Me.InputLabel18.WordWrap = False
        '
        'InputLabel9
        '
        Me.InputLabel9.ForeColor = System.Drawing.Color.DarkGray
        Me.InputLabel9.Height = 11
        Me.InputLabel9.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Near
        Me.InputLabel9.Name = "InputLabel9"
        Me.InputLabel9.Text = "- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -" & _
            " - - - - - - - - - - - - - - - - - - - "
        Me.InputLabel9.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Near
        Me.InputLabel9.Width = 270
        Me.InputLabel9.WordWrap = False
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.C1InputPanel1.BorderColor = System.Drawing.Color.Silver
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader2)
        Me.C1InputPanel1.Items.Add(Me.SaveRecord)
        Me.C1InputPanel1.Items.Add(Me.CreateNewrecord)
        Me.C1InputPanel1.Items.Add(Me.CloseForm)
        Me.C1InputPanel1.Location = New System.Drawing.Point(47, 310)
        Me.C1InputPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.C1InputPanel1.Size = New System.Drawing.Size(411, 100)
        Me.C1InputPanel1.TabIndex = 2
        Me.C1InputPanel1.VisualStyle = C1.Win.C1InputPanel.VisualStyle.System
        '
        'InputGroupHeader2
        '
        Me.InputGroupHeader2.Height = 25
        Me.InputGroupHeader2.Name = "InputGroupHeader2"
        Me.InputGroupHeader2.Text = "Actions and Commands"
        '
        'SaveRecord
        '
        Me.SaveRecord.Break = C1.Win.C1InputPanel.BreakType.None
        Me.SaveRecord.Image = Global.A1plus.My.Resources.Resources.SaveAllHS
        Me.SaveRecord.Name = "SaveRecord"
        Me.SaveRecord.Text = "&Save Record"
        Me.SaveRecord.Width = 90
        '
        'CreateNewrecord
        '
        Me.CreateNewrecord.Break = C1.Win.C1InputPanel.BreakType.None
        Me.CreateNewrecord.Image = Global.A1plus.My.Resources.Resources.plus_button
        Me.CreateNewrecord.Name = "CreateNewrecord"
        Me.CreateNewrecord.Text = "&New Record"
        '
        'CloseForm
        '
        Me.CloseForm.Break = C1.Win.C1InputPanel.BreakType.None
        Me.CloseForm.Image = Global.A1plus.My.Resources.Resources.no
        Me.CloseForm.Name = "CloseForm"
        Me.CloseForm.Text = "&Close"
        Me.CloseForm.Width = 58
        '
        'C1InputPanel6
        '
        Me.C1InputPanel6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.C1InputPanel6.BorderColor = System.Drawing.Color.Silver
        Me.C1InputPanel6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1InputPanel6.Items.Add(Me.InputImage1)
        Me.C1InputPanel6.Items.Add(Me.InputLabel2)
        Me.C1InputPanel6.Items.Add(Me.InputGroupHeader1)
        Me.C1InputPanel6.Items.Add(Me.InputLabel4)
        Me.C1InputPanel6.Items.Add(Me.EmploymentStatus)
        Me.C1InputPanel6.Items.Add(Me.InputLabel1)
        Me.C1InputPanel6.Items.Add(Me.Description)
        Me.C1InputPanel6.Items.Add(Me.Status)
        Me.C1InputPanel6.Location = New System.Drawing.Point(44, 31)
        Me.C1InputPanel6.Margin = New System.Windows.Forms.Padding(13, 4, 4, 4)
        Me.C1InputPanel6.Name = "C1InputPanel6"
        Me.C1InputPanel6.Padding = New System.Windows.Forms.Padding(0)
        Me.C1InputPanel6.Size = New System.Drawing.Size(411, 263)
        Me.C1InputPanel6.TabIndex = 0
        Me.C1InputPanel6.VisualStyle = C1.Win.C1InputPanel.VisualStyle.System
        '
        'InputImage1
        '
        Me.InputImage1.Break = C1.Win.C1InputPanel.BreakType.None
        Me.InputImage1.Height = 47
        Me.InputImage1.Image = Global.A1plus.My.Resources.Resources._1363081024_gtk_sort_descending
        Me.InputImage1.Name = "InputImage1"
        Me.InputImage1.Width = 44
        '
        'InputLabel2
        '
        Me.InputLabel2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel2.Name = "InputLabel2"
        Me.InputLabel2.Text = "Add / Modify Existing Employee Type"
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        Me.InputGroupHeader1.Text = "Basic Details"
        '
        'InputLabel4
        '
        Me.InputLabel4.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel4.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Near
        Me.InputLabel4.Name = "InputLabel4"
        Me.InputLabel4.Text = "Employee Type:"
        Me.InputLabel4.Width = 180
        '
        'EmploymentStatus
        '
        Me.EmploymentStatus.Name = "EmploymentStatus"
        Me.EmploymentStatus.Width = 288
        '
        'InputLabel1
        '
        Me.InputLabel1.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel1.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Near
        Me.InputLabel1.Name = "InputLabel1"
        Me.InputLabel1.Text = "Description:"
        Me.InputLabel1.Width = 71
        '
        'Description
        '
        Me.Description.Height = 53
        Me.Description.Multiline = True
        Me.Description.Name = "Description"
        Me.Description.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Spread
        Me.Description.Width = 289
        '
        'Status
        '
        Me.Status.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Status.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.Status.Name = "Status"
        Me.Status.Text = "&Active"
        Me.Status.Width = 286
        '
        'HRIS_Requirements_SetUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(494, 434)
        Me.Controls.Add(Me.C1InputPanel6)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "HRIS_Requirements_SetUp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Type Entry"
        Me.TopMost = True
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Silver
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents InputLabel18 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel9 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents SaveRecord As C1.Win.C1InputPanel.InputButton
    Friend WithEvents CreateNewrecord As C1.Win.C1InputPanel.InputButton
    Friend WithEvents CloseForm As C1.Win.C1InputPanel.InputButton
    Friend WithEvents C1InputPanel6 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents EmploymentStatus As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel4 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents Status As C1.Win.C1InputPanel.InputCheckBox
    Friend WithEvents InputLabel1 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents Description As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputGroupHeader2 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputImage1 As C1.Win.C1InputPanel.InputImage
    Friend WithEvents InputLabel2 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
End Class
