<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViolationTicketLookup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViolationTicketLookup))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.C1InputPanel4 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel4 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputSeparator1 = New C1.Win.C1InputPanel.InputSeparator()
        Me.InputLabel9 = New C1.Win.C1InputPanel.InputLabel()
        Me.employee = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel2 = New C1.Win.C1InputPanel.InputLabel()
        Me.violation = New C1.Win.C1InputPanel.InputTextBox()
        Me.Searchbutton = New C1.Win.C1InputPanel.InputButton()
        Me.ClearButton = New C1.Win.C1InputPanel.InputButton()
        Me.InputSeparator3 = New C1.Win.C1InputPanel.InputSeparator()
        Me.C1FlexGrid1 = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1InputPanel2 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader5 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputButton4 = New C1.Win.C1InputPanel.InputButton()
        CType(Me.C1InputPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1FlexGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(827, 371)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(60, 19)
        Me.Button1.TabIndex = 55
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'C1InputPanel4
        '
        Me.C1InputPanel4.BackColor = System.Drawing.Color.Transparent
        Me.C1InputPanel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1InputPanel4.Items.Add(Me.InputGroupHeader1)
        Me.C1InputPanel4.Items.Add(Me.InputLabel4)
        Me.C1InputPanel4.Items.Add(Me.InputSeparator1)
        Me.C1InputPanel4.Items.Add(Me.InputLabel9)
        Me.C1InputPanel4.Items.Add(Me.employee)
        Me.C1InputPanel4.Items.Add(Me.InputLabel2)
        Me.C1InputPanel4.Items.Add(Me.violation)
        Me.C1InputPanel4.Items.Add(Me.Searchbutton)
        Me.C1InputPanel4.Items.Add(Me.ClearButton)
        Me.C1InputPanel4.Items.Add(Me.InputSeparator3)
        Me.C1InputPanel4.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel4.Name = "C1InputPanel4"
        Me.C1InputPanel4.Size = New System.Drawing.Size(765, 86)
        Me.C1InputPanel4.TabIndex = 0
        Me.C1InputPanel4.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Windows7
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        Me.InputGroupHeader1.Text = "Violation Ticket Search Panel"
        Me.InputGroupHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'InputLabel4
        '
        Me.InputLabel4.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel4.Name = "InputLabel4"
        Me.InputLabel4.Text = "Fill up the filter fields below ito match your search criteria."
        Me.InputLabel4.Width = 750
        '
        'InputSeparator1
        '
        Me.InputSeparator1.Name = "InputSeparator1"
        Me.InputSeparator1.Width = 745
        '
        'InputLabel9
        '
        Me.InputLabel9.Name = "InputLabel9"
        Me.InputLabel9.Text = "Employee:"
        Me.InputLabel9.Width = 64
        '
        'employee
        '
        Me.employee.Break = C1.Win.C1InputPanel.BreakType.None
        Me.employee.Name = "employee"
        Me.employee.Width = 232
        '
        'InputLabel2
        '
        Me.InputLabel2.Name = "InputLabel2"
        Me.InputLabel2.Text = "Violation"
        Me.InputLabel2.Width = 75
        '
        'violation
        '
        Me.violation.Break = C1.Win.C1InputPanel.BreakType.None
        Me.violation.Name = "violation"
        Me.violation.Width = 131
        '
        'Searchbutton
        '
        Me.Searchbutton.Break = C1.Win.C1InputPanel.BreakType.None
        Me.Searchbutton.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far
        Me.Searchbutton.Image = Global.A1plus.My.Resources.Resources.search123
        Me.Searchbutton.Name = "Searchbutton"
        Me.Searchbutton.Text = "&Search"
        Me.Searchbutton.Width = 70
        '
        'ClearButton
        '
        Me.ClearButton.Image = Global.A1plus.My.Resources.Resources.remove__1_
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Text = "&Clear"
        '
        'InputSeparator3
        '
        Me.InputSeparator3.Height = 4
        Me.InputSeparator3.Name = "InputSeparator3"
        Me.InputSeparator3.Width = 744
        '
        'C1FlexGrid1
        '
        Me.C1FlexGrid1.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.C1FlexGrid1.AllowEditing = False
        Me.C1FlexGrid1.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
        Me.C1FlexGrid1.ColumnInfo = resources.GetString("C1FlexGrid1.ColumnInfo")
        Me.C1FlexGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1FlexGrid1.ExtendLastCol = True
        Me.C1FlexGrid1.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.C1FlexGrid1.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.C1FlexGrid1.Location = New System.Drawing.Point(0, 86)
        Me.C1FlexGrid1.Name = "C1FlexGrid1"
        Me.C1FlexGrid1.Rows.Count = 1
        Me.C1FlexGrid1.Rows.DefaultSize = 22
        Me.C1FlexGrid1.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.ListBox
        Me.C1FlexGrid1.Size = New System.Drawing.Size(765, 297)
        Me.C1FlexGrid1.StyleInfo = resources.GetString("C1FlexGrid1.StyleInfo")
        Me.C1FlexGrid1.TabIndex = 3
        Me.C1FlexGrid1.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.System
        '
        'C1InputPanel2
        '
        Me.C1InputPanel2.BackColor = System.Drawing.SystemColors.Control
        Me.C1InputPanel2.BorderThickness = 1
        Me.C1InputPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.C1InputPanel2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1InputPanel2.Items.Add(Me.InputGroupHeader5)
        Me.C1InputPanel2.Items.Add(Me.InputButton4)
        Me.C1InputPanel2.Location = New System.Drawing.Point(0, 383)
        Me.C1InputPanel2.Name = "C1InputPanel2"
        Me.C1InputPanel2.Padding = New System.Windows.Forms.Padding(5, 0, 5, 5)
        Me.C1InputPanel2.Size = New System.Drawing.Size(765, 38)
        Me.C1InputPanel2.TabIndex = 2
        Me.C1InputPanel2.VisualStyle = C1.Win.C1InputPanel.VisualStyle.System
        '
        'InputGroupHeader5
        '
        Me.InputGroupHeader5.BackColor = System.Drawing.Color.Transparent
        Me.InputGroupHeader5.Height = 2
        Me.InputGroupHeader5.Name = "InputGroupHeader5"
        Me.InputGroupHeader5.Text = "Purchasing : Item Details"
        '
        'InputButton4
        '
        Me.InputButton4.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.InputButton4.Image = Global.A1plus.My.Resources.Resources.closex
        Me.InputButton4.Name = "InputButton4"
        Me.InputButton4.Text = "Close"
        '
        'ViolationTicketLookup
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(765, 421)
        Me.Controls.Add(Me.C1FlexGrid1)
        Me.Controls.Add(Me.C1InputPanel2)
        Me.Controls.Add(Me.C1InputPanel4)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ViolationTicketLookup"
        Me.ShowInTaskbar = False
        CType(Me.C1InputPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1FlexGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents C1InputPanel4 As C1.Win.C1InputPanel.C1InputPanel
    Private WithEvents InputLabel4 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents InputSeparator1 As C1.Win.C1InputPanel.InputSeparator
    Friend WithEvents InputLabel9 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents employee As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents InputLabel2 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents violation As C1.Win.C1InputPanel.InputTextBox
    Friend WithEvents Searchbutton As C1.Win.C1InputPanel.InputButton
    Friend WithEvents ClearButton As C1.Win.C1InputPanel.InputButton
    Private WithEvents InputSeparator3 As C1.Win.C1InputPanel.InputSeparator
    Friend WithEvents C1FlexGrid1 As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents C1InputPanel2 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader5 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents InputButton4 As C1.Win.C1InputPanel.InputButton
    Friend WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
End Class
