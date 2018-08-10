<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HRIS_TAXTable
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HRIS_TAXTable))
        Me.PaySetUpGrid = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader4 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel1 = New C1.Win.C1InputPanel.InputLabel()
        Me.C1InputPanel2 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader2 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputButton1 = New C1.Win.C1InputPanel.InputButton()
        Me.InputButton2 = New C1.Win.C1InputPanel.InputButton()
        Me.InputButton3 = New C1.Win.C1InputPanel.InputButton()
        Me.PayrollGroup = New C1.Win.C1InputPanel.InputComboBox()
        Me.InputLabel2 = New C1.Win.C1InputPanel.InputLabel()
        Me.Description = New C1.Win.C1InputPanel.InputTextBox()
        CType(Me.PaySetUpGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PaySetUpGrid
        '
        Me.PaySetUpGrid.AllowAddNew = True
        Me.PaySetUpGrid.AllowDelete = True
        Me.PaySetUpGrid.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Columns
        Me.PaySetUpGrid.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.PaySetUpGrid.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.PaySetUpGrid.AutoResize = True
        Me.PaySetUpGrid.BackColor = System.Drawing.Color.White
        Me.PaySetUpGrid.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None
        Me.PaySetUpGrid.ColumnInfo = resources.GetString("PaySetUpGrid.ColumnInfo")
        Me.PaySetUpGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PaySetUpGrid.ExtendLastCol = True
        Me.PaySetUpGrid.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
        Me.PaySetUpGrid.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.PaySetUpGrid.ForeColor = System.Drawing.Color.Black
        Me.PaySetUpGrid.IgnoreDiacritics = True
        Me.PaySetUpGrid.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.None
        Me.PaySetUpGrid.Location = New System.Drawing.Point(0, 115)
        Me.PaySetUpGrid.Name = "PaySetUpGrid"
        Me.PaySetUpGrid.Rows.Count = 10
        Me.PaySetUpGrid.Rows.DefaultSize = 19
        Me.PaySetUpGrid.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.PaySetUpGrid.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.PaySetUpGrid.ShowCursor = True
        Me.PaySetUpGrid.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.None
        Me.PaySetUpGrid.Size = New System.Drawing.Size(781, 327)
        Me.PaySetUpGrid.StyleInfo = resources.GetString("PaySetUpGrid.StyleInfo")
        Me.PaySetUpGrid.TabIndex = 61
        Me.PaySetUpGrid.Tree.Style = CType(((C1.Win.C1FlexGrid.TreeStyleFlags.Lines Or C1.Win.C1FlexGrid.TreeStyleFlags.Symbols) _
                    Or C1.Win.C1FlexGrid.TreeStyleFlags.Leaf), C1.Win.C1FlexGrid.TreeStyleFlags)
        Me.PaySetUpGrid.UseCompatibleTextRendering = False
        Me.PaySetUpGrid.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Silver
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.BorderThickness = 1
        Me.C1InputPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader4)
        Me.C1InputPanel1.Items.Add(Me.InputLabel1)
        Me.C1InputPanel1.Items.Add(Me.PayrollGroup)
        Me.C1InputPanel1.Items.Add(Me.InputLabel2)
        Me.C1InputPanel1.Items.Add(Me.Description)
        Me.C1InputPanel1.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(781, 115)
        Me.C1InputPanel1.TabIndex = 62
        Me.C1InputPanel1.VisualStyle = C1.Win.C1InputPanel.VisualStyle.System
        '
        'InputGroupHeader4
        '
        Me.InputGroupHeader4.Name = "InputGroupHeader4"
        Me.InputGroupHeader4.Text = "BIR TAX Table Setup"
        '
        'InputLabel1
        '
        Me.InputLabel1.Name = "InputLabel1"
        Me.InputLabel1.Text = "Payroll Group:"
        Me.InputLabel1.Width = 86
        '
        'C1InputPanel2
        '
        Me.C1InputPanel2.BorderThickness = 1
        Me.C1InputPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.C1InputPanel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel2.Items.Add(Me.InputGroupHeader2)
        Me.C1InputPanel2.Items.Add(Me.InputButton1)
        Me.C1InputPanel2.Items.Add(Me.InputButton2)
        Me.C1InputPanel2.Items.Add(Me.InputButton3)
        Me.C1InputPanel2.Location = New System.Drawing.Point(0, 442)
        Me.C1InputPanel2.Name = "C1InputPanel2"
        Me.C1InputPanel2.Size = New System.Drawing.Size(781, 65)
        Me.C1InputPanel2.TabIndex = 63
        Me.C1InputPanel2.VisualStyle = C1.Win.C1InputPanel.VisualStyle.System
        '
        'InputGroupHeader2
        '
        Me.InputGroupHeader2.Name = "InputGroupHeader2"
        Me.InputGroupHeader2.Text = "Actions and Command"
        '
        'InputButton1
        '
        Me.InputButton1.Break = C1.Win.C1InputPanel.BreakType.None
        Me.InputButton1.Image = CType(resources.GetObject("InputButton1.Image"), System.Drawing.Image)
        Me.InputButton1.Name = "InputButton1"
        Me.InputButton1.Text = "Save Record"
        '
        'InputButton2
        '
        Me.InputButton2.Break = C1.Win.C1InputPanel.BreakType.None
        Me.InputButton2.Image = CType(resources.GetObject("InputButton2.Image"), System.Drawing.Image)
        Me.InputButton2.Name = "InputButton2"
        Me.InputButton2.Text = "New Record"
        '
        'InputButton3
        '
        Me.InputButton3.Image = CType(resources.GetObject("InputButton3.Image"), System.Drawing.Image)
        Me.InputButton3.Name = "InputButton3"
        Me.InputButton3.Text = "Close Form"
        '
        'PayrollGroup
        '
        Me.PayrollGroup.Name = "PayrollGroup"
        Me.PayrollGroup.Width = 338
        '
        'InputLabel2
        '
        Me.InputLabel2.Name = "InputLabel2"
        Me.InputLabel2.Text = "Description:"
        Me.InputLabel2.Width = 86
        '
        'Description
        '
        Me.Description.Height = 52
        Me.Description.Multiline = True
        Me.Description.Name = "Description"
        Me.Description.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Spread
        Me.Description.Width = 338
        '
        'HRIS_TAXTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(781, 507)
        Me.Controls.Add(Me.PaySetUpGrid)
        Me.Controls.Add(Me.C1InputPanel2)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.Name = "HRIS_TAXTable"
        Me.Text = "HRIS_TAXTable"
        CType(Me.PaySetUpGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents PaySetUpGrid As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader4 As C1.Win.C1InputPanel.InputGroupHeader
    Private WithEvents InputLabel1 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents PayrollGroup As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents InputLabel2 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents Description As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents C1InputPanel2 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader2 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputButton1 As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputButton2 As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputButton3 As C1.Win.C1InputPanel.InputButton
End Class
