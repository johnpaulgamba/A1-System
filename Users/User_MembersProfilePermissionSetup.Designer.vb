<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class user_membersprofilepermissionsetup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(user_membersprofilepermissionsetup))
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel3 = New C1.Win.C1InputPanel.InputLabel()
        Me.UserName = New C1.Win.C1InputPanel.InputComboBox()
        Me.InputGroupHeader3 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputGroupHeader2 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.SaveRecordButton = New C1.Win.C1InputPanel.InputButton()
        Me.ClearButton = New C1.Win.C1InputPanel.InputButton()
        Me.InputButton3 = New C1.Win.C1InputPanel.InputButton()
        Me.HomeGrid = New C1.Win.C1FlexGrid.C1FlexGrid()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HomeGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.BackColor = System.Drawing.Color.Transparent
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader1)
        Me.C1InputPanel1.Items.Add(Me.InputLabel3)
        Me.C1InputPanel1.Items.Add(Me.UserName)
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader3)
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader2)
        Me.C1InputPanel1.Items.Add(Me.SaveRecordButton)
        Me.C1InputPanel1.Items.Add(Me.ClearButton)
        Me.C1InputPanel1.Items.Add(Me.InputButton3)
        Me.C1InputPanel1.Location = New System.Drawing.Point(12, 25)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(541, 482)
        Me.C1InputPanel1.TabIndex = 2
        Me.C1InputPanel1.VisualStyle = C1.Win.C1InputPanel.VisualStyle.System
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Height = 22
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        Me.InputGroupHeader1.Text = "Profile Details"
        '
        'InputLabel3
        '
        Me.InputLabel3.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel3.Height = 18
        Me.InputLabel3.Name = "InputLabel3"
        Me.InputLabel3.Text = "Select Profile Name:"
        '
        'UserName
        '
        Me.UserName.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.UserName.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList
        Me.UserName.Name = "UserName"
        Me.UserName.Width = 525
        '
        'InputGroupHeader3
        '
        Me.InputGroupHeader3.Height = 302
        Me.InputGroupHeader3.Name = "InputGroupHeader3"
        Me.InputGroupHeader3.Text = "Select Users to be added to this Profile."
        '
        'InputGroupHeader2
        '
        Me.InputGroupHeader2.Height = 59
        Me.InputGroupHeader2.Name = "InputGroupHeader2"
        Me.InputGroupHeader2.Padding = New System.Windows.Forms.Padding(0, 30, 0, 0)
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
        'HomeGrid
        '
        Me.HomeGrid.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.HomeGrid.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Both
        Me.HomeGrid.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
        Me.HomeGrid.ColumnInfo = resources.GetString("HomeGrid.ColumnInfo")
        Me.HomeGrid.ExtendLastCol = True
        Me.HomeGrid.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.HomeGrid.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.HomeGrid.Location = New System.Drawing.Point(14, 121)
        Me.HomeGrid.Name = "HomeGrid"
        Me.HomeGrid.Rows.Count = 1
        Me.HomeGrid.Rows.DefaultSize = 20
        Me.HomeGrid.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.ListBox
        Me.HomeGrid.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.Rows
        Me.HomeGrid.Size = New System.Drawing.Size(537, 315)
        Me.HomeGrid.StyleInfo = resources.GetString("HomeGrid.StyleInfo")
        Me.HomeGrid.TabIndex = 8
        Me.HomeGrid.Tag = "a"
        '
        'User_MembersProfilePermissionSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 517)
        Me.Controls.Add(Me.HomeGrid)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "User_MembersProfilePermissionSetup"
        Me.Text = "Access Members"
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Silver
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HomeGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputLabel3 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents UserName As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents InputGroupHeader3 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputGroupHeader2 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents SaveRecordButton As C1.Win.C1InputPanel.InputButton
    Friend WithEvents ClearButton As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputButton3 As C1.Win.C1InputPanel.InputButton
    Friend WithEvents HomeGrid As C1.Win.C1FlexGrid.C1FlexGrid
End Class
