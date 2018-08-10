<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportFormPrinting
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportFormPrinting))
        Me.CrystalReportViewer2 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.C1Ribbon2 = New C1.Win.C1Ribbon.C1Ribbon()
        Me.RibbonApplicationMenu2 = New C1.Win.C1Ribbon.RibbonApplicationMenu()
        Me.RibbonConfigToolBar2 = New C1.Win.C1Ribbon.RibbonConfigToolBar()
        Me.RibbonQat2 = New C1.Win.C1Ribbon.RibbonQat()
        Me.RibbonTab2 = New C1.Win.C1Ribbon.RibbonTab()
        Me.RibbonGroup2 = New C1.Win.C1Ribbon.RibbonGroup()
        Me.Export = New C1.Win.C1Ribbon.RibbonButton()
        Me.RibbonButton6 = New C1.Win.C1Ribbon.RibbonButton()
        Me.PrintDocument = New C1.Win.C1Ribbon.RibbonButton()
        Me.CloseForm = New C1.Win.C1Ribbon.RibbonButton()
        Me.RibbonGroup3 = New C1.Win.C1Ribbon.RibbonGroup()
        Me.First = New C1.Win.C1Ribbon.RibbonButton()
        Me.PreviousPage = New C1.Win.C1Ribbon.RibbonButton()
        Me.NextPage = New C1.Win.C1Ribbon.RibbonButton()
        Me.MoveToLast = New C1.Win.C1Ribbon.RibbonButton()
        Me.C1StatusBar2 = New C1.Win.C1Ribbon.C1StatusBar()
        Me.RibbonLabel1 = New C1.Win.C1Ribbon.RibbonLabel()
        Me.CurrentPage = New C1.Win.C1Ribbon.RibbonLabel()
        Me.RibbonLabel3 = New C1.Win.C1Ribbon.RibbonLabel()
        Me.TotPage = New C1.Win.C1Ribbon.RibbonLabel()
        Me.RibbonSeparator2 = New C1.Win.C1Ribbon.RibbonSeparator()
        Me.TextBox1 = New C1.Win.C1Ribbon.RibbonTextBox()
        Me.ZoomOf = New C1.Win.C1Ribbon.RibbonLabel()
        Me.RibbonTrackBar1 = New C1.Win.C1Ribbon.RibbonTrackBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.C1Ribbon2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1StatusBar2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CrystalReportViewer2
        '
        Me.CrystalReportViewer2.ActiveViewIndex = -1
        Me.CrystalReportViewer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer2.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer2.DisplayBackgroundEdge = False
        Me.CrystalReportViewer2.DisplayStatusBar = False
        Me.CrystalReportViewer2.DisplayToolbar = False
        Me.CrystalReportViewer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer2.EnableDrillDown = False
        Me.CrystalReportViewer2.EnableToolTips = False
        Me.CrystalReportViewer2.Location = New System.Drawing.Point(0, 152)
        Me.CrystalReportViewer2.Name = "CrystalReportViewer2"
        Me.CrystalReportViewer2.ShowCloseButton = False
        Me.CrystalReportViewer2.Size = New System.Drawing.Size(659, 277)
        Me.CrystalReportViewer2.TabIndex = 0
        Me.CrystalReportViewer2.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'C1Ribbon2
        '
        Me.C1Ribbon2.ApplicationMenuHolder = Me.RibbonApplicationMenu2
        Me.C1Ribbon2.ConfigToolBarHolder = Me.RibbonConfigToolBar2
        Me.C1Ribbon2.Location = New System.Drawing.Point(0, 0)
        Me.C1Ribbon2.Name = "C1Ribbon2"
        Me.C1Ribbon2.QatHolder = Me.RibbonQat2
        Me.C1Ribbon2.Size = New System.Drawing.Size(659, 152)
        Me.C1Ribbon2.Tabs.Add(Me.RibbonTab2)
        '
        'RibbonApplicationMenu2
        '
        Me.RibbonApplicationMenu2.Name = "RibbonApplicationMenu2"
        Me.RibbonApplicationMenu2.Visible = False
        '
        'RibbonConfigToolBar2
        '
        Me.RibbonConfigToolBar2.Name = "RibbonConfigToolBar2"
        '
        'RibbonQat2
        '
        Me.RibbonQat2.Name = "RibbonQat2"
        Me.RibbonQat2.Visible = False
        '
        'RibbonTab2
        '
        Me.RibbonTab2.Groups.Add(Me.RibbonGroup2)
        Me.RibbonTab2.Groups.Add(Me.RibbonGroup3)
        Me.RibbonTab2.Image = CType(resources.GetObject("RibbonTab2.Image"), System.Drawing.Image)
        Me.RibbonTab2.Name = "RibbonTab2"
        Me.RibbonTab2.Text = "Report Controls"
        '
        'RibbonGroup2
        '
        Me.RibbonGroup2.Items.Add(Me.Export)
        Me.RibbonGroup2.Items.Add(Me.RibbonButton6)
        Me.RibbonGroup2.Items.Add(Me.PrintDocument)
        Me.RibbonGroup2.Items.Add(Me.CloseForm)
        Me.RibbonGroup2.Name = "RibbonGroup2"
        Me.RibbonGroup2.Text = "Report Document Options"
        '
        'Export
        '
        Me.Export.LargeImage = CType(resources.GetObject("Export.LargeImage"), System.Drawing.Image)
        Me.Export.Name = "Export"
        Me.Export.Text = "Export Report"
        '
        'RibbonButton6
        '
        Me.RibbonButton6.LargeImage = CType(resources.GetObject("RibbonButton6.LargeImage"), System.Drawing.Image)
        Me.RibbonButton6.Name = "RibbonButton6"
        Me.RibbonButton6.Text = "Refresh Report"
        '
        'PrintDocument
        '
        Me.PrintDocument.LargeImage = CType(resources.GetObject("PrintDocument.LargeImage"), System.Drawing.Image)
        Me.PrintDocument.Name = "PrintDocument"
        Me.PrintDocument.Text = "Print Report"
        '
        'CloseForm
        '
        Me.CloseForm.LargeImage = Global.A1plus.My.Resources.Resources.exit1
        Me.CloseForm.Name = "CloseForm"
        Me.CloseForm.Text = "Close Form"
        '
        'RibbonGroup3
        '
        Me.RibbonGroup3.Items.Add(Me.First)
        Me.RibbonGroup3.Items.Add(Me.PreviousPage)
        Me.RibbonGroup3.Items.Add(Me.NextPage)
        Me.RibbonGroup3.Items.Add(Me.MoveToLast)
        Me.RibbonGroup3.Name = "RibbonGroup3"
        Me.RibbonGroup3.Text = "Document Page Navigation"
        '
        'First
        '
        Me.First.LargeImage = CType(resources.GetObject("First.LargeImage"), System.Drawing.Image)
        Me.First.Name = "First"
        Me.First.Text = "First Page"
        '
        'PreviousPage
        '
        Me.PreviousPage.LargeImage = Global.A1plus.My.Resources.Resources.gnome_go_previous
        Me.PreviousPage.Name = "PreviousPage"
        Me.PreviousPage.Text = "Previous Page"
        '
        'NextPage
        '
        Me.NextPage.LargeImage = Global.A1plus.My.Resources.Resources.gnome_go_next
        Me.NextPage.Name = "NextPage"
        Me.NextPage.Text = "Next Page"
        '
        'MoveToLast
        '
        Me.MoveToLast.LargeImage = Global.A1plus.My.Resources.Resources.gnome_go_last
        Me.MoveToLast.Name = "MoveToLast"
        Me.MoveToLast.Text = "Last Page"
        '
        'C1StatusBar2
        '
        Me.C1StatusBar2.LeftPaneItems.Add(Me.RibbonLabel1)
        Me.C1StatusBar2.LeftPaneItems.Add(Me.CurrentPage)
        Me.C1StatusBar2.LeftPaneItems.Add(Me.RibbonLabel3)
        Me.C1StatusBar2.LeftPaneItems.Add(Me.TotPage)
        Me.C1StatusBar2.LeftPaneItems.Add(Me.RibbonSeparator2)
        Me.C1StatusBar2.LeftPaneItems.Add(Me.TextBox1)
        Me.C1StatusBar2.Location = New System.Drawing.Point(0, 429)
        Me.C1StatusBar2.Name = "C1StatusBar2"
        Me.C1StatusBar2.RightPaneItems.Add(Me.ZoomOf)
        Me.C1StatusBar2.RightPaneItems.Add(Me.RibbonTrackBar1)
        Me.C1StatusBar2.Size = New System.Drawing.Size(659, 23)
        '
        'RibbonLabel1
        '
        Me.RibbonLabel1.Name = "RibbonLabel1"
        Me.RibbonLabel1.Text = "Page"
        '
        'CurrentPage
        '
        Me.CurrentPage.Name = "CurrentPage"
        Me.CurrentPage.Text = "1"
        '
        'RibbonLabel3
        '
        Me.RibbonLabel3.Name = "RibbonLabel3"
        Me.RibbonLabel3.Text = "of"
        '
        'TotPage
        '
        Me.TotPage.Name = "TotPage"
        Me.TotPage.Text = "20"
        '
        'RibbonSeparator2
        '
        Me.RibbonSeparator2.Name = "RibbonSeparator2"
        '
        'TextBox1
        '
        Me.TextBox1.Label = "Navigate to Page:"
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.TextAreaWidth = 30
        Me.TextBox1.Visible = False
        '
        'ZoomOf
        '
        Me.ZoomOf.Name = "ZoomOf"
        Me.ZoomOf.Text = "100%"
        '
        'RibbonTrackBar1
        '
        Me.RibbonTrackBar1.ButtonPressDelay = 1
        Me.RibbonTrackBar1.ButtonPressInterval = 1
        Me.RibbonTrackBar1.Maximum = 200
        Me.RibbonTrackBar1.Name = "RibbonTrackBar1"
        Me.RibbonTrackBar1.StepFrequency = 1
        Me.RibbonTrackBar1.TickFrequency = 1
        Me.RibbonTrackBar1.Value = 100
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'ReportFormPrinting
        '
        Me.ClientSize = New System.Drawing.Size(659, 452)
        Me.Controls.Add(Me.CrystalReportViewer2)
        Me.Controls.Add(Me.C1StatusBar2)
        Me.Controls.Add(Me.C1Ribbon2)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "ReportFormPrinting"
        Me.ShowIcon = False
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Silver
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.C1Ribbon2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1StatusBar2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents C1StatusBar1 As C1.Win.C1Ribbon.C1StatusBar
    Friend WithEvents C1Ribbon1 As C1.Win.C1Ribbon.C1Ribbon
    Friend WithEvents RibbonApplicationMenu1 As C1.Win.C1Ribbon.RibbonApplicationMenu
    Friend WithEvents RibbonConfigToolBar1 As C1.Win.C1Ribbon.RibbonConfigToolBar
    Friend WithEvents RibbonQat1 As C1.Win.C1Ribbon.RibbonQat
    Friend WithEvents RibbonTab1 As C1.Win.C1Ribbon.RibbonTab
    Friend WithEvents RibbonGroup1 As C1.Win.C1Ribbon.RibbonGroup
    Friend WithEvents RibbonButton1 As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents CrystalReportViewer2 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents C1Ribbon2 As C1.Win.C1Ribbon.C1Ribbon
    Friend WithEvents RibbonApplicationMenu2 As C1.Win.C1Ribbon.RibbonApplicationMenu
    Friend WithEvents RibbonConfigToolBar2 As C1.Win.C1Ribbon.RibbonConfigToolBar
    Friend WithEvents RibbonQat2 As C1.Win.C1Ribbon.RibbonQat
    Friend WithEvents RibbonTab2 As C1.Win.C1Ribbon.RibbonTab
    Friend WithEvents RibbonGroup2 As C1.Win.C1Ribbon.RibbonGroup
    Friend WithEvents PrintDocument As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents Export As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents C1StatusBar2 As C1.Win.C1Ribbon.C1StatusBar
    Friend WithEvents RibbonTrackBar1 As C1.Win.C1Ribbon.RibbonTrackBar
    Friend WithEvents RibbonButton6 As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents RibbonGroup3 As C1.Win.C1Ribbon.RibbonGroup
    Friend WithEvents First As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents PreviousPage As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents NextPage As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents MoveToLast As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents CloseForm As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents RibbonLabel1 As C1.Win.C1Ribbon.RibbonLabel
    Friend WithEvents CurrentPage As C1.Win.C1Ribbon.RibbonLabel
    Friend WithEvents RibbonLabel3 As C1.Win.C1Ribbon.RibbonLabel
    Friend WithEvents TotPage As C1.Win.C1Ribbon.RibbonLabel
    Friend WithEvents RibbonSeparator2 As C1.Win.C1Ribbon.RibbonSeparator
    Friend WithEvents TextBox1 As C1.Win.C1Ribbon.RibbonTextBox
    Friend WithEvents ZoomOf As C1.Win.C1Ribbon.RibbonLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
