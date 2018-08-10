<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DTR
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
        Dim ControlHandler1 As C1.Win.Data.ControlHandler = New C1.Win.Data.ControlHandler()
        Dim ControlHandler2 As C1.Win.Data.ControlHandler = New C1.Win.Data.ControlHandler()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Col1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C1DataSource1 = New C1.Win.Data.Entities.C1DataSource()
        Me.dt1 = New System.Windows.Forms.DateTimePicker()
        Me.DT2 = New System.Windows.Forms.DateTimePicker()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.num1 = New System.Windows.Forms.NumericUpDown()
        Me.TabControl1 = New DevComponents.DotNetBar.TabControl()
        Me.TabControlPanel1 = New DevComponents.DotNetBar.TabControlPanel()
        Me.DependentGrid = New C1.Win.C1FlexGrid.C1FlexGrid()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1DataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        CType(Me.DependentGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(5, 13)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 42)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Load DTR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(137, 13)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(124, 42)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Process DTR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Col1, Me.Col2, Me.Col3, Me.Col4, Me.Col5, Me.Col6, Me.Col7})
        ControlHandler1.AutoLookup = False
        ControlHandler1.VirtualMode = False
        Me.C1DataSource1.SetControlHandler(Me.DataGridView1, ControlHandler1)
        Me.DataGridView1.Location = New System.Drawing.Point(302, 262)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(263, 196)
        Me.DataGridView1.TabIndex = 1
        '
        'Col1
        '
        Me.Col1.HeaderText = "Col1"
        Me.Col1.Name = "Col1"
        '
        'Col2
        '
        Me.Col2.HeaderText = "Col2"
        Me.Col2.Name = "Col2"
        '
        'Col3
        '
        Me.Col3.HeaderText = "Col3"
        Me.Col3.Name = "Col3"
        '
        'Col4
        '
        Me.Col4.HeaderText = "Col4"
        Me.Col4.Name = "Col4"
        '
        'Col5
        '
        Me.Col5.HeaderText = "Col5"
        Me.Col5.Name = "Col5"
        '
        'Col6
        '
        Me.Col6.HeaderText = "Col6"
        Me.Col6.Name = "Col6"
        '
        'Col7
        '
        Me.Col7.HeaderText = "Col7"
        Me.Col7.Name = "Col7"
        '
        'dt1
        '
        Me.dt1.CustomFormat = "dd/mm/yyyy HH:mm:ss"
        Me.dt1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt1.Location = New System.Drawing.Point(335, 22)
        Me.dt1.Name = "dt1"
        Me.dt1.Size = New System.Drawing.Size(201, 22)
        Me.dt1.TabIndex = 2
        '
        'DT2
        '
        Me.DT2.CustomFormat = "dd/mm/yyyy HH:mm:ss"
        Me.DT2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DT2.Location = New System.Drawing.Point(542, 21)
        Me.DT2.Name = "DT2"
        Me.DT2.Size = New System.Drawing.Size(201, 22)
        Me.DT2.TabIndex = 2
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(335, 50)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'num1
        '
        Me.num1.DecimalPlaces = 2
        Me.num1.Location = New System.Drawing.Point(776, 21)
        Me.num1.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.num1.Name = "num1"
        Me.num1.Size = New System.Drawing.Size(120, 22)
        Me.num1.TabIndex = 4
        '
        'TabControl1
        '
        Me.TabControl1.CanReorderTabs = True
        Me.TabControl1.Controls.Add(Me.TabControlPanel1)
        Me.TabControl1.Controls.Add(Me.DependentGrid)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl"
        Me.TabControl1.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold)
        Me.TabControl1.SelectedTabIndex = -1
        Me.TabControl1.Size = New System.Drawing.Size(256, 152)
        Me.TabControl1.TabIndex = 0
        Me.TabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        '
        'TabControlPanel1
        '
        Me.TabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TabControlPanel1.Name = "TabControlPanel1"
        Me.TabControlPanel1.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel1.Size = New System.Drawing.Size(955, 268)
        Me.TabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.TabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.TabControlPanel1.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel1.Style.GradientAngle = 90
        Me.TabControlPanel1.TabIndex = 2
        Me.TabControlPanel1.Visible = False
        '
        'DependentGrid
        '
        Me.DependentGrid.AllowEditing = False
        Me.DependentGrid.AutoResize = True
        Me.DependentGrid.ColumnInfo = "10,1,0,0,0,105,Columns:"
        ControlHandler2.AutoLookup = False
        ControlHandler2.VirtualMode = False
        Me.C1DataSource1.SetControlHandler(Me.DependentGrid, ControlHandler2)
        Me.DependentGrid.Location = New System.Drawing.Point(0, 0)
        Me.DependentGrid.Name = "DependentGrid"
        Me.DependentGrid.Rows.Count = 1
        Me.DependentGrid.Rows.DefaultSize = 21
        Me.DependentGrid.Size = New System.Drawing.Size(240, 150)
        Me.DependentGrid.TabIndex = 3
        '
        'DTR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(967, 662)
        Me.Controls.Add(Me.num1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.DT2)
        Me.Controls.Add(Me.dt1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "DTR"
        Me.Text = "DTR"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1DataSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        CType(Me.DependentGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents C1DataSource1 As C1.Win.Data.Entities.C1DataSource
    Friend WithEvents Col1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dt1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DT2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents num1 As System.Windows.Forms.NumericUpDown
    Private WithEvents TabControl1 As DevComponents.DotNetBar.TabControl
    Private WithEvents TabItem1 As DevComponents.DotNetBar.TabItem
    Friend WithEvents DependentGrid As C1.Win.C1FlexGrid.C1FlexGrid
    Private WithEvents TabControlPanel1 As DevComponents.DotNetBar.TabControlPanel
End Class
