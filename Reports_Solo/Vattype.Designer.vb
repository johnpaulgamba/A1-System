<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vattype
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
        Me.InputGroupHeader3 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel2 = New C1.Win.C1InputPanel.InputLabel()
        Me.vattypex = New C1.Win.C1InputPanel.InputComboBox()
        Me.InputOption1 = New C1.Win.C1InputPanel.InputOption()
        Me.InputOption2 = New C1.Win.C1InputPanel.InputOption()
        Me.InputLabel1 = New C1.Win.C1InputPanel.InputLabel()
        Me.Currency = New C1.Win.C1InputPanel.InputComboBox()
        Me.InputOption4 = New C1.Win.C1InputPanel.InputOption()
        Me.InputOption3 = New C1.Win.C1InputPanel.InputOption()
        Me.InputSeparator1 = New C1.Win.C1InputPanel.InputSeparator()
        Me.btnsave = New C1.Win.C1InputPanel.InputButton()
        Me.btclose = New C1.Win.C1InputPanel.InputButton()
        CType(Me.C1InputPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1InputPanel3
        '
        Me.C1InputPanel3.BorderThickness = 1
        Me.C1InputPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1InputPanel3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1InputPanel3.Items.Add(Me.InputGroupHeader3)
        Me.C1InputPanel3.Items.Add(Me.InputLabel2)
        Me.C1InputPanel3.Items.Add(Me.vattypex)
        Me.C1InputPanel3.Items.Add(Me.InputLabel1)
        Me.C1InputPanel3.Items.Add(Me.Currency)
        Me.C1InputPanel3.Items.Add(Me.InputSeparator1)
        Me.C1InputPanel3.Items.Add(Me.btnsave)
        Me.C1InputPanel3.Items.Add(Me.btclose)
        Me.C1InputPanel3.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.C1InputPanel3.Name = "C1InputPanel3"
        Me.C1InputPanel3.Padding = New System.Windows.Forms.Padding(5)
        Me.C1InputPanel3.Size = New System.Drawing.Size(396, 154)
        Me.C1InputPanel3.TabIndex = 2
        Me.C1InputPanel3.VisualStyle = C1.Win.C1InputPanel.VisualStyle.System
        '
        'InputGroupHeader3
        '
        Me.InputGroupHeader3.Height = 32
        Me.InputGroupHeader3.Name = "InputGroupHeader3"
        Me.InputGroupHeader3.Text = "Select type of Invoice form:"
        '
        'InputLabel2
        '
        Me.InputLabel2.Name = "InputLabel2"
        Me.InputLabel2.Text = "VAT Type:"
        Me.InputLabel2.Width = 80
        '
        'vattypex
        '
        Me.vattypex.Height = 27
        Me.vattypex.Items.Add(Me.InputOption1)
        Me.vattypex.Items.Add(Me.InputOption2)
        Me.vattypex.Name = "vattypex"
        Me.vattypex.Text = "VAT Inclusive"
        Me.vattypex.Width = 256
        '
        'InputOption1
        '
        Me.InputOption1.Name = "InputOption1"
        Me.InputOption1.Text = "VAT Inclusive"
        '
        'InputOption2
        '
        Me.InputOption2.Name = "InputOption2"
        Me.InputOption2.Text = "VAT Exclusive"
        '
        'InputLabel1
        '
        Me.InputLabel1.Name = "InputLabel1"
        Me.InputLabel1.Text = "Currency:"
        Me.InputLabel1.Width = 80
        '
        'Currency
        '
        Me.Currency.Items.Add(Me.InputOption4)
        Me.Currency.Items.Add(Me.InputOption3)
        Me.Currency.Name = "Currency"
        Me.Currency.Text = "Philippine Peso"
        Me.Currency.Width = 254
        '
        'InputOption4
        '
        Me.InputOption4.Name = "InputOption4"
        Me.InputOption4.Text = "Philippine Peso"
        '
        'InputOption3
        '
        Me.InputOption3.Name = "InputOption3"
        Me.InputOption3.Text = "US Dollar"
        '
        'InputSeparator1
        '
        Me.InputSeparator1.Name = "InputSeparator1"
        Me.InputSeparator1.Width = 364
        '
        'btnsave
        '
        Me.btnsave.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btnsave.Image = Global.A1plus.My.Resources.Resources.check__1_1
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Text = "&OK "
        '
        'btclose
        '
        Me.btclose.Break = C1.Win.C1InputPanel.BreakType.None
        Me.btclose.Image = Global.A1plus.My.Resources.Resources.no
        Me.btclose.Name = "btclose"
        Me.btclose.Text = "&Close"
        '
        'Vattype
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(396, 154)
        Me.Controls.Add(Me.C1InputPanel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Vattype"
        Me.Text = "Vattype"
        CType(Me.C1InputPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1InputPanel3 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents InputGroupHeader3 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents btnsave As C1.Win.C1InputPanel.InputButton
    Friend WithEvents btclose As C1.Win.C1InputPanel.InputButton
    Friend WithEvents vattypex As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents InputOption1 As C1.Win.C1InputPanel.InputOption
    Friend WithEvents InputOption2 As C1.Win.C1InputPanel.InputOption
    Friend WithEvents InputLabel2 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents InputLabel1 As C1.Win.C1InputPanel.InputLabel
    Friend WithEvents Currency As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents InputOption4 As C1.Win.C1InputPanel.InputOption
    Friend WithEvents InputOption3 As C1.Win.C1InputPanel.InputOption
    Friend WithEvents InputSeparator1 As C1.Win.C1InputPanel.InputSeparator
End Class
