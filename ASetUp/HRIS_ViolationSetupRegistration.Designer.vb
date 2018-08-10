<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HRIS_ViolationSetupRegistration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HRIS_ViolationSetupRegistration))
        Me.C1InputPanel3 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader5 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.SaveCommandButton = New C1.Win.C1InputPanel.InputButton()
        Me.InputButton2 = New C1.Win.C1InputPanel.InputButton()
        Me.InputButton4 = New C1.Win.C1InputPanel.InputButton()
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader2 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel3 = New C1.Win.C1InputPanel.InputLabel()
        Me.ViolationCode = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel2 = New C1.Win.C1InputPanel.InputLabel()
        Me.GeneralViolation = New C1.Win.C1InputPanel.InputComboBox()
        Me.InputButton1 = New C1.Win.C1InputPanel.InputButton()
        Me.InputLabel5 = New C1.Win.C1InputPanel.InputLabel()
        Me.ViolationDetails = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel6 = New C1.Win.C1InputPanel.InputLabel()
        Me.isActive = New C1.Win.C1InputPanel.InputCheckBox()
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.C1FlexGrid8 = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1ComboBox1 = New C1.Win.C1Input.C1ComboBox()
        CType(Me.C1InputPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1FlexGrid8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1ComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.C1InputPanel3.Location = New System.Drawing.Point(7, 449)
        Me.C1InputPanel3.Name = "C1InputPanel3"
        Me.C1InputPanel3.Padding = New System.Windows.Forms.Padding(5, 2, 5, 5)
        Me.C1InputPanel3.Size = New System.Drawing.Size(552, 37)
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
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader2)
        Me.C1InputPanel1.Items.Add(Me.InputLabel3)
        Me.C1InputPanel1.Items.Add(Me.ViolationCode)
        Me.C1InputPanel1.Items.Add(Me.InputLabel2)
        Me.C1InputPanel1.Items.Add(Me.GeneralViolation)
        Me.C1InputPanel1.Items.Add(Me.InputButton1)
        Me.C1InputPanel1.Items.Add(Me.InputLabel5)
        Me.C1InputPanel1.Items.Add(Me.ViolationDetails)
        Me.C1InputPanel1.Items.Add(Me.InputLabel6)
        Me.C1InputPanel1.Items.Add(Me.isActive)
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader1)
        Me.C1InputPanel1.Location = New System.Drawing.Point(8, 12)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Padding = New System.Windows.Forms.Padding(5)
        Me.C1InputPanel1.Size = New System.Drawing.Size(552, 235)
        Me.C1InputPanel1.TabIndex = 65
        Me.C1InputPanel1.VisualStyle = C1.Win.C1InputPanel.VisualStyle.System
        '
        'InputGroupHeader2
        '
        Me.InputGroupHeader2.Height = 25
        Me.InputGroupHeader2.Name = "InputGroupHeader2"
        Me.InputGroupHeader2.Text = "Violation SetUp"
        '
        'InputLabel3
        '
        Me.InputLabel3.Name = "InputLabel3"
        Me.InputLabel3.Text = "Violation Code"
        Me.InputLabel3.Width = 109
        '
        'ViolationCode
        '
        Me.ViolationCode.Name = "ViolationCode"
        Me.ViolationCode.Width = 279
        '
        'InputLabel2
        '
        Me.InputLabel2.Name = "InputLabel2"
        Me.InputLabel2.Text = "General Violation"
        Me.InputLabel2.Width = 109
        '
        'GeneralViolation
        '
        Me.GeneralViolation.Break = C1.Win.C1InputPanel.BreakType.None
        Me.GeneralViolation.Name = "GeneralViolation"
        Me.GeneralViolation.Width = 279
        '
        'InputButton1
        '
        Me.InputButton1.Image = Global.A1plus.My.Resources.Resources.add_over
        Me.InputButton1.Name = "InputButton1"
        Me.InputButton1.Width = 25
        '
        'InputLabel5
        '
        Me.InputLabel5.Name = "InputLabel5"
        Me.InputLabel5.Text = "Specific Violation"
        Me.InputLabel5.Width = 109
        '
        'ViolationDetails
        '
        Me.ViolationDetails.Height = 76
        Me.ViolationDetails.Multiline = True
        Me.ViolationDetails.Name = "ViolationDetails"
        Me.ViolationDetails.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Spread
        Me.ViolationDetails.Width = 400
        '
        'InputLabel6
        '
        Me.InputLabel6.Name = "InputLabel6"
        Me.InputLabel6.Text = "Status:"
        Me.InputLabel6.Width = 108
        '
        'isActive
        '
        Me.isActive.Break = C1.Win.C1InputPanel.BreakType.None
        Me.isActive.CheckState = System.Windows.Forms.CheckState.Checked
        Me.isActive.Name = "isActive"
        Me.isActive.Text = "Active"
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        Me.InputGroupHeader1.Text = "Penalty for the Violation"
        '
        'C1FlexGrid8
        '
        Me.C1FlexGrid8.AllowAddNew = True
        Me.C1FlexGrid8.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Columns
        Me.C1FlexGrid8.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.C1FlexGrid8.AutoResize = True
        Me.C1FlexGrid8.BackColor = System.Drawing.Color.White
        Me.C1FlexGrid8.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None
        Me.C1FlexGrid8.ColumnInfo = resources.GetString("C1FlexGrid8.ColumnInfo")
        Me.C1FlexGrid8.ExtendLastCol = True
        Me.C1FlexGrid8.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
        Me.C1FlexGrid8.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.C1FlexGrid8.ForeColor = System.Drawing.Color.Black
        Me.C1FlexGrid8.IgnoreDiacritics = True
        Me.C1FlexGrid8.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.None
        Me.C1FlexGrid8.Location = New System.Drawing.Point(8, 219)
        Me.C1FlexGrid8.Margin = New System.Windows.Forms.Padding(2)
        Me.C1FlexGrid8.Name = "C1FlexGrid8"
        Me.C1FlexGrid8.Rows.Count = 10
        Me.C1FlexGrid8.Rows.DefaultSize = 19
        Me.C1FlexGrid8.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.C1FlexGrid8.ShowCursor = True
        Me.C1FlexGrid8.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.None
        Me.C1FlexGrid8.Size = New System.Drawing.Size(545, 225)
        Me.C1FlexGrid8.StyleInfo = resources.GetString("C1FlexGrid8.StyleInfo")
        Me.C1FlexGrid8.TabIndex = 66
        Me.C1FlexGrid8.Tree.Style = CType(((C1.Win.C1FlexGrid.TreeStyleFlags.Lines Or C1.Win.C1FlexGrid.TreeStyleFlags.Symbols) _
                    Or C1.Win.C1FlexGrid.TreeStyleFlags.Leaf), C1.Win.C1FlexGrid.TreeStyleFlags)
        Me.C1FlexGrid8.UseCompatibleTextRendering = False
        Me.C1FlexGrid8.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.System
        '
        'C1ComboBox1
        '
        Me.C1ComboBox1.AllowSpinLoop = False
        Me.C1ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.C1ComboBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.C1ComboBox1.GapHeight = 0
        Me.C1ComboBox1.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1ComboBox1.Items.Add("Warning")
        Me.C1ComboBox1.Items.Add("First Warning")
        Me.C1ComboBox1.Items.Add("Suspension (3 Days)")
        Me.C1ComboBox1.Items.Add("Suspension (6 Days)")
        Me.C1ComboBox1.Items.Add("Suspension (12 Days)")
        Me.C1ComboBox1.Items.Add("Suspension (30 Days)")
        Me.C1ComboBox1.Items.Add("Dismissal")
        Me.C1ComboBox1.ItemsDisplayMember = ""
        Me.C1ComboBox1.ItemsValueMember = ""
        Me.C1ComboBox1.Location = New System.Drawing.Point(458, 219)
        Me.C1ComboBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.C1ComboBox1.Name = "C1ComboBox1"
        Me.C1ComboBox1.Size = New System.Drawing.Size(75, 18)
        Me.C1ComboBox1.TabIndex = 67
        Me.C1ComboBox1.Tag = Nothing
        '
        'HRIS_ViolationSetupRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 496)
        Me.Controls.Add(Me.C1ComboBox1)
        Me.Controls.Add(Me.C1FlexGrid8)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.Controls.Add(Me.C1InputPanel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "HRIS_ViolationSetupRegistration"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Violation and Penalty SetUp"
        CType(Me.C1InputPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1FlexGrid8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1ComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ViolationDetails As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel6 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents isActive As C1.Win.C1InputPanel.InputCheckBox
    Friend WithEvents InputLabel3 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents ViolationCode As C1.Win.C1InputPanel.InputTextBox
    Public WithEvents C1FlexGrid8 As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents C1ComboBox1 As C1.Win.C1Input.C1ComboBox
    Friend WithEvents InputLabel2 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents GeneralViolation As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents InputButton1 As C1.Win.C1InputPanel.InputButton

End Class
