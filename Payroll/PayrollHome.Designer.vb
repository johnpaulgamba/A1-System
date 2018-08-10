<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PayrollHome
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
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PayrollHome))
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.C1InputPanel4 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader3 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel2 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel9 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel1 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel3 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel4 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputComboBox1 = New C1.Win.C1InputPanel.InputComboBox()
        Me.payrolldatefrom = New C1.Win.C1InputPanel.InputDatePicker()
        Me.payrolldateto = New C1.Win.C1InputPanel.InputDatePicker()
        Me.InputButton1 = New C1.Win.C1InputPanel.InputButton()
        Me.InputLabel5 = New C1.Win.C1InputPanel.InputLabel()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Chart1
        '
        Me.Chart1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ChartArea2.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend2)
        Me.Chart1.Location = New System.Drawing.Point(127, 135)
        Me.Chart1.Name = "Chart1"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Size = New System.Drawing.Size(988, 402)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        '
        'C1InputPanel4
        '
        Me.C1InputPanel4.AllowDrop = True
        Me.C1InputPanel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.C1InputPanel4.BorderColor = System.Drawing.Color.Empty
        Me.C1InputPanel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1InputPanel4.Items.Add(Me.InputGroupHeader3)
        Me.C1InputPanel4.Items.Add(Me.InputLabel2)
        Me.C1InputPanel4.Items.Add(Me.InputLabel9)
        Me.C1InputPanel4.Items.Add(Me.InputLabel1)
        Me.C1InputPanel4.Items.Add(Me.InputComboBox1)
        Me.C1InputPanel4.Items.Add(Me.InputLabel5)
        Me.C1InputPanel4.Items.Add(Me.InputLabel3)
        Me.C1InputPanel4.Items.Add(Me.payrolldatefrom)
        Me.C1InputPanel4.Items.Add(Me.InputLabel4)
        Me.C1InputPanel4.Items.Add(Me.payrolldateto)
        Me.C1InputPanel4.Items.Add(Me.InputButton1)
        Me.C1InputPanel4.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel4.Name = "C1InputPanel4"
        Me.C1InputPanel4.Padding = New System.Windows.Forms.Padding(6, 3, 2, 0)
        Me.C1InputPanel4.Size = New System.Drawing.Size(1264, 111)
        Me.C1InputPanel4.TabIndex = 65
        Me.C1InputPanel4.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Silver
        '
        'InputGroupHeader3
        '
        Me.InputGroupHeader3.BackColor = System.Drawing.Color.Transparent
        Me.InputGroupHeader3.ElementHeight = 30
        Me.InputGroupHeader3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputGroupHeader3.Height = 19
        Me.InputGroupHeader3.Name = "InputGroupHeader3"
        Me.InputGroupHeader3.Padding = New System.Windows.Forms.Padding(0, -5, 0, 0)
        Me.InputGroupHeader3.Text = "SEARCH PANEL. . ."
        '
        'InputLabel2
        '
        Me.InputLabel2.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel2.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Near
        Me.InputLabel2.Name = "InputLabel2"
        Me.InputLabel2.Text = "Filter the records by filling up the fields below."
        Me.InputLabel2.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Spread
        '
        'InputLabel9
        '
        Me.InputLabel9.AutoEllipsis = False
        Me.InputLabel9.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel9.ForeColor = System.Drawing.Color.Silver
        Me.InputLabel9.Height = 6
        Me.InputLabel9.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Near
        Me.InputLabel9.Name = "InputLabel9"
        Me.InputLabel9.Padding = New System.Windows.Forms.Padding(0, -5, 0, -5)
        Me.InputLabel9.Text = ". . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . ." & _
            " . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . "
        Me.InputLabel9.Width = 262
        Me.InputLabel9.WordWrap = False
        '
        'InputLabel1
        '
        Me.InputLabel1.Name = "InputLabel1"
        Me.InputLabel1.Text = "Company:"
        '
        'InputLabel3
        '
        Me.InputLabel3.Name = "InputLabel3"
        Me.InputLabel3.Text = "Date From:"
        '
        'InputLabel4
        '
        Me.InputLabel4.Name = "InputLabel4"
        Me.InputLabel4.Text = "Date To:"
        '
        'InputComboBox1
        '
        Me.InputComboBox1.Break = C1.Win.C1InputPanel.BreakType.None
        Me.InputComboBox1.Name = "InputComboBox1"
        Me.InputComboBox1.Width = 390
        '
        'payrolldatefrom
        '
        Me.payrolldatefrom.Break = C1.Win.C1InputPanel.BreakType.None
        Me.payrolldatefrom.Name = "payrolldatefrom"
        '
        'payrolldateto
        '
        Me.payrolldateto.Break = C1.Win.C1InputPanel.BreakType.None
        Me.payrolldateto.Name = "payrolldateto"
        '
        'InputButton1
        '
        Me.InputButton1.Image = CType(resources.GetObject("InputButton1.Image"), System.Drawing.Image)
        Me.InputButton1.Name = "InputButton1"
        Me.InputButton1.Text = "Load"
        '
        'InputLabel5
        '
        Me.InputLabel5.Name = "InputLabel5"
        Me.InputLabel5.Width = 259
        '
        'PayrollHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 583)
        Me.Controls.Add(Me.C1InputPanel4)
        Me.Controls.Add(Me.Chart1)
        Me.Name = "PayrollHome"
        Me.Text = "PayrollHome"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents C1InputPanel4 As C1.Win.C1InputPanel.C1InputPanel
    Private WithEvents InputGroupHeader3 As C1.Win.C1InputPanel.InputGroupHeader
    Private WithEvents InputLabel2 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents InputLabel9 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel1 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputComboBox1 As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents InputLabel5 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel3 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents payrolldatefrom As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents InputLabel4 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents payrolldateto As C1.Win.C1InputPanel.InputDatePicker
    Friend WithEvents InputButton1 As C1.Win.C1InputPanel.InputButton
End Class
