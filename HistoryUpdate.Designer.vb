<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HistoryUpdate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HistoryUpdate))
        Me.C1Ribbon1 = New C1.Win.C1Ribbon.C1Ribbon()
        Me.RibbonApplicationMenu1 = New C1.Win.C1Ribbon.RibbonApplicationMenu()
        Me.RibbonConfigToolBar1 = New C1.Win.C1Ribbon.RibbonConfigToolBar()
        Me.RibbonQat1 = New C1.Win.C1Ribbon.RibbonQat()
        Me.RibbonTab1 = New C1.Win.C1Ribbon.RibbonTab()
        Me.RibbonGroup1 = New C1.Win.C1Ribbon.RibbonGroup()
        Me.PrinterSetup = New C1.Win.C1Ribbon.RibbonButton()
        Me.PrintPreviewButton = New C1.Win.C1Ribbon.RibbonButton()
        Me.PrintDocument = New C1.Win.C1Ribbon.RibbonButton()
        Me.CloseForm = New C1.Win.C1Ribbon.RibbonButton()
        Me.HistoryTextbox = New C1.Win.C1Input.C1TextBox()
        CType(Me.C1Ribbon1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HistoryTextbox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1Ribbon1
        '
        Me.C1Ribbon1.ApplicationMenuHolder = Me.RibbonApplicationMenu1
        Me.C1Ribbon1.ConfigToolBarHolder = Me.RibbonConfigToolBar1
        Me.C1Ribbon1.Location = New System.Drawing.Point(0, 0)
        Me.C1Ribbon1.Name = "C1Ribbon1"
        Me.C1Ribbon1.QatHolder = Me.RibbonQat1
        Me.C1Ribbon1.Size = New System.Drawing.Size(577, 152)
        Me.C1Ribbon1.Tabs.Add(Me.RibbonTab1)
        '
        'RibbonApplicationMenu1
        '
        Me.RibbonApplicationMenu1.Name = "RibbonApplicationMenu1"
        Me.RibbonApplicationMenu1.Visible = False
        '
        'RibbonConfigToolBar1
        '
        Me.RibbonConfigToolBar1.Name = "RibbonConfigToolBar1"
        Me.RibbonConfigToolBar1.Visible = False
        '
        'RibbonQat1
        '
        Me.RibbonQat1.Name = "RibbonQat1"
        Me.RibbonQat1.Visible = False
        '
        'RibbonTab1
        '
        Me.RibbonTab1.Groups.Add(Me.RibbonGroup1)
        Me.RibbonTab1.Name = "RibbonTab1"
        Me.RibbonTab1.Text = "Basic Controls"
        '
        'RibbonGroup1
        '
        Me.RibbonGroup1.Items.Add(Me.PrinterSetup)
        Me.RibbonGroup1.Items.Add(Me.PrintPreviewButton)
        Me.RibbonGroup1.Items.Add(Me.PrintDocument)
        Me.RibbonGroup1.Items.Add(Me.CloseForm)
        Me.RibbonGroup1.Name = "RibbonGroup1"
        Me.RibbonGroup1.Text = "Commands"
        '
        'PrinterSetup
        '
        Me.PrinterSetup.LargeImage = CType(resources.GetObject("PrinterSetup.LargeImage"), System.Drawing.Image)
        Me.PrinterSetup.Name = "PrinterSetup"
        Me.PrinterSetup.Text = "Page Setup"
        '
        'PrintPreviewButton
        '
        Me.PrintPreviewButton.LargeImage = CType(resources.GetObject("PrintPreviewButton.LargeImage"), System.Drawing.Image)
        Me.PrintPreviewButton.Name = "PrintPreviewButton"
        Me.PrintPreviewButton.Text = "Print Preview"
        '
        'PrintDocument
        '
        Me.PrintDocument.LargeImage = CType(resources.GetObject("PrintDocument.LargeImage"), System.Drawing.Image)
        Me.PrintDocument.Name = "PrintDocument"
        Me.PrintDocument.Text = "Print Data"
        '
        'CloseForm
        '
        Me.CloseForm.LargeImage = Global.A1plus.My.Resources.Resources.exit1
        Me.CloseForm.Name = "CloseForm"
        Me.CloseForm.Text = "Close Form"
        '
        'HistoryTextbox
        '
        Me.HistoryTextbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.HistoryTextbox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HistoryTextbox.Location = New System.Drawing.Point(0, 152)
        Me.HistoryTextbox.Multiline = True
        Me.HistoryTextbox.Name = "HistoryTextbox"
        Me.HistoryTextbox.Padding = New System.Windows.Forms.Padding(15)
        Me.HistoryTextbox.ReadOnly = True
        Me.HistoryTextbox.Size = New System.Drawing.Size(577, 344)
        Me.HistoryTextbox.TabIndex = 10
        Me.HistoryTextbox.Tag = Nothing
        Me.HistoryTextbox.TextDetached = True
        Me.HistoryTextbox.VisualStyle = C1.Win.C1Input.VisualStyle.System
        '
        'HistoryUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 496)
        Me.Controls.Add(Me.HistoryTextbox)
        Me.Controls.Add(Me.C1Ribbon1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "HistoryUpdate"
        Me.Text = "History Details. . ."
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Silver
        CType(Me.C1Ribbon1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HistoryTextbox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents C1Ribbon1 As C1.Win.C1Ribbon.C1Ribbon
    Friend WithEvents RibbonApplicationMenu1 As C1.Win.C1Ribbon.RibbonApplicationMenu
    Friend WithEvents RibbonConfigToolBar1 As C1.Win.C1Ribbon.RibbonConfigToolBar
    Friend WithEvents RibbonQat1 As C1.Win.C1Ribbon.RibbonQat
    Friend WithEvents RibbonTab1 As C1.Win.C1Ribbon.RibbonTab
    Friend WithEvents RibbonGroup1 As C1.Win.C1Ribbon.RibbonGroup
    Friend WithEvents PrinterSetup As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents PrintPreviewButton As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents PrintDocument As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents CloseForm As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents HistoryTextbox As C1.Win.C1Input.C1TextBox
End Class
