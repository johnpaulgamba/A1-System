<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HRIS_EmployeeInformation
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HRIS_EmployeeInformation))
        Me.C1DockingTabPage6 = New C1.Win.C1Command.C1DockingTabPage()
        Me.ToolStrip5 = New System.Windows.Forms.ToolStrip()
        Me.NewEmployment = New System.Windows.Forms.ToolStripButton()
        Me.EditEmployment = New System.Windows.Forms.ToolStripButton()
        Me.DeleteEmployment = New System.Windows.Forms.ToolStripButton()
        Me.employmentotal = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel10 = New System.Windows.Forms.ToolStripLabel()
        Me.EmploymentRefresh = New System.Windows.Forms.ToolStripButton()
        Me.EmploymentGrid = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1InputPanel12 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader17 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.C1DockingTabPage5 = New C1.Win.C1Command.C1DockingTabPage()
        Me.C1SplitContainer2 = New C1.Win.C1SplitContainer.C1SplitContainer()
        Me.C1SplitterPanel3 = New C1.Win.C1SplitContainer.C1SplitterPanel()
        Me.EducationGrid = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.ToolStrip4 = New System.Windows.Forms.ToolStrip()
        Me.NewEducation = New System.Windows.Forms.ToolStripButton()
        Me.EditEducation = New System.Windows.Forms.ToolStripButton()
        Me.DeleteEducation = New System.Windows.Forms.ToolStripButton()
        Me.educationtotal = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel8 = New System.Windows.Forms.ToolStripLabel()
        Me.EducationRefresh = New System.Windows.Forms.ToolStripButton()
        Me.C1SplitterPanel4 = New C1.Win.C1SplitContainer.C1SplitterPanel()
        Me.TrainingGrid = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.NewTraining = New System.Windows.Forms.ToolStripButton()
        Me.EditTraining = New System.Windows.Forms.ToolStripButton()
        Me.DeleteTraining = New System.Windows.Forms.ToolStripButton()
        Me.trainingtotal = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel6 = New System.Windows.Forms.ToolStripLabel()
        Me.TrainingRefresh = New System.Windows.Forms.ToolStripButton()
        Me.C1DockingTabPage3 = New C1.Win.C1Command.C1DockingTabPage()
        Me.C1SplitContainer1 = New C1.Win.C1SplitContainer.C1SplitContainer()
        Me.C1SplitterPanel1 = New C1.Win.C1SplitContainer.C1SplitterPanel()
        Me.PaySetUpGrid = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.ToolStrip7 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.C1SplitterPanel2 = New C1.Win.C1SplitContainer.C1SplitterPanel()
        Me.ToolStrip8 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel5 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel7 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton9 = New System.Windows.Forms.ToolStripButton()
        Me.AllowanceGrid = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1InputPanel4 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader8 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel45 = New C1.Win.C1InputPanel.InputLabel()
        Me.payrollgroup = New C1.Win.C1InputPanel.InputComboBox()
        Me.InputLabel44 = New C1.Win.C1InputPanel.InputLabel()
        Me.paymentmethod = New C1.Win.C1InputPanel.InputComboBox()
        Me.InputLabel55 = New C1.Win.C1InputPanel.InputLabel()
        Me.MonthlyPay = New C1.Win.C1InputPanel.InputNumericBox()
        Me.InputLabel43 = New C1.Win.C1InputPanel.InputLabel()
        Me.MonthlyHours = New C1.Win.C1InputPanel.InputNumericBox()
        Me.InputGroupHeader14 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel54 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel51 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel42 = New C1.Win.C1InputPanel.InputLabel()
        Me.BasicSalary = New C1.Win.C1InputPanel.InputNumericBox()
        Me.InputLabel61 = New C1.Win.C1InputPanel.InputLabel()
        Me.BasicPayHourly = New C1.Win.C1InputPanel.InputNumericBox()
        Me.InputLabel28 = New C1.Win.C1InputPanel.InputLabel()
        Me.HiddenAllowance = New C1.Win.C1InputPanel.InputNumericBox()
        Me.InputLabel30 = New C1.Win.C1InputPanel.InputLabel()
        Me.HiddenAllowanceRate = New C1.Win.C1InputPanel.InputNumericBox()
        Me.InputLabel27 = New C1.Win.C1InputPanel.InputLabel()
        Me.LegalAllowance = New C1.Win.C1InputPanel.InputNumericBox()
        Me.InputLabel67 = New C1.Win.C1InputPanel.InputLabel()
        Me.cola = New C1.Win.C1InputPanel.InputNumericBox()
        Me.InputLabel66 = New C1.Win.C1InputPanel.InputLabel()
        Me.SSSEEShare = New C1.Win.C1InputPanel.InputNumericBox()
        Me.InputLabel71 = New C1.Win.C1InputPanel.InputLabel()
        Me.PHICEEShare = New C1.Win.C1InputPanel.InputNumericBox()
        Me.InputLabel69 = New C1.Win.C1InputPanel.InputLabel()
        Me.HDMFEEShare = New C1.Win.C1InputPanel.InputNumericBox()
        Me.InputLabel52 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputLabel31 = New C1.Win.C1InputPanel.InputLabel()
        Me.GrossPay = New C1.Win.C1InputPanel.InputNumericBox()
        Me.InputSeparator5 = New C1.Win.C1InputPanel.InputSeparator()
        Me.InputLabel70 = New C1.Win.C1InputPanel.InputLabel()
        Me.BasicPay = New C1.Win.C1InputPanel.InputNumericBox()
        Me.InputLabel68 = New C1.Win.C1InputPanel.InputLabel()
        Me.Exception = New C1.Win.C1InputPanel.InputNumericBox()
        Me.InputLabel72 = New C1.Win.C1InputPanel.InputLabel()
        Me.Mandatory = New C1.Win.C1InputPanel.InputNumericBox()
        Me.InputSeparator6 = New C1.Win.C1InputPanel.InputSeparator()
        Me.InputLabel29 = New C1.Win.C1InputPanel.InputLabel()
        Me.TaxableIncome = New C1.Win.C1InputPanel.InputNumericBox()
        Me.InputLabel73 = New C1.Win.C1InputPanel.InputLabel()
        Me.wtax = New C1.Win.C1InputPanel.InputNumericBox()
        Me.InputSeparator4 = New C1.Win.C1InputPanel.InputSeparator()
        Me.InputLabel32 = New C1.Win.C1InputPanel.InputLabel()
        Me.NetPay = New C1.Win.C1InputPanel.InputNumericBox()
        Me.InputGroupHeader22 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.deducttax = New C1.Win.C1InputPanel.InputCheckBox()
        Me.deductsss = New C1.Win.C1InputPanel.InputCheckBox()
        Me.deducthdmf = New C1.Win.C1InputPanel.InputCheckBox()
        Me.deductphic = New C1.Win.C1InputPanel.InputCheckBox()
        Me.InputSeparator3 = New C1.Win.C1InputPanel.InputSeparator()
        Me.ChargetoCompany = New C1.Win.C1InputPanel.InputCheckBox()
        Me.C1DockingTabPage2 = New C1.Win.C1Command.C1DockingTabPage()
        Me.ResidenceGrid = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.NewAddress = New System.Windows.Forms.ToolStripButton()
        Me.EditAddress = New System.Windows.Forms.ToolStripButton()
        Me.DeleteAddress = New System.Windows.Forms.ToolStripButton()
        Me.addresstotal = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.AddressRefresh = New System.Windows.Forms.ToolStripButton()
        Me.C1ToolBar1 = New C1.Win.C1Command.C1ToolBar()
        Me.C1InputPanel6 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader7 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.C1InputPanel3 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader12 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel35 = New C1.Win.C1InputPanel.InputLabel()
        Me.DateofBirth = New C1.Win.C1InputPanel.InputDatePicker()
        Me.InputLabel37 = New C1.Win.C1InputPanel.InputLabel()
        Me.PlaceOfBirth = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel38 = New C1.Win.C1InputPanel.InputLabel()
        Me.CivilStatus = New C1.Win.C1InputPanel.InputComboBox()
        Me.InputOption15 = New C1.Win.C1InputPanel.InputOption()
        Me.InputOption16 = New C1.Win.C1InputPanel.InputOption()
        Me.InputOption17 = New C1.Win.C1InputPanel.InputOption()
        Me.InputOption18 = New C1.Win.C1InputPanel.InputOption()
        Me.InputLabel39 = New C1.Win.C1InputPanel.InputLabel()
        Me.Religion = New C1.Win.C1InputPanel.InputComboBox()
        Me.InputLabel40 = New C1.Win.C1InputPanel.InputLabel()
        Me.Height = New C1.Win.C1InputPanel.InputNumericBox()
        Me.InputLabel41 = New C1.Win.C1InputPanel.InputLabel()
        Me.Weight = New C1.Win.C1InputPanel.InputNumericBox()
        Me.InputLabel46 = New C1.Win.C1InputPanel.InputLabel()
        Me.BloodType = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel47 = New C1.Win.C1InputPanel.InputLabel()
        Me.BodyBuild = New C1.Win.C1InputPanel.InputTextBox()
        Me.C1DockingTabPage1 = New C1.Win.C1Command.C1DockingTabPage()
        Me.RequirementGrid = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1InputPanel17 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader24 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.C1InputPanel5 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader9 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel64 = New C1.Win.C1InputPanel.InputLabel()
        Me.DateHired = New C1.Win.C1InputPanel.InputDatePicker()
        Me.InputLabel65 = New C1.Win.C1InputPanel.InputLabel()
        Me.DateRegular = New C1.Win.C1InputPanel.InputDatePicker()
        Me.InputLabel18 = New C1.Win.C1InputPanel.InputLabel()
        Me.DateSeparated = New C1.Win.C1InputPanel.InputDatePicker()
        Me.InputLabel19 = New C1.Win.C1InputPanel.InputLabel()
        Me.DateResigned = New C1.Win.C1InputPanel.InputDatePicker()
        Me.Rehirable = New C1.Win.C1InputPanel.InputCheckBox()
        Me.InputGroupHeader4 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel20 = New C1.Win.C1InputPanel.InputLabel()
        Me.ContractStartDate = New C1.Win.C1InputPanel.InputDatePicker()
        Me.InputLabel21 = New C1.Win.C1InputPanel.InputLabel()
        Me.ContractEndDate = New C1.Win.C1InputPanel.InputDatePicker()
        Me.InputGroupHeader10 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel22 = New C1.Win.C1InputPanel.InputLabel()
        Me.ClearanceStatus = New C1.Win.C1InputPanel.InputComboBox()
        Me.InputOption1 = New C1.Win.C1InputPanel.InputOption()
        Me.InputOption2 = New C1.Win.C1InputPanel.InputOption()
        Me.InputOption4 = New C1.Win.C1InputPanel.InputOption()
        Me.InputLabel23 = New C1.Win.C1InputPanel.InputLabel()
        Me.DateCleared = New C1.Win.C1InputPanel.InputDatePicker()
        Me.InputLabel24 = New C1.Win.C1InputPanel.InputLabel()
        Me.IssuedBy = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel53 = New C1.Win.C1InputPanel.InputLabel()
        Me.Remarks = New C1.Win.C1InputPanel.InputTextBox()
        Me.C1InputPanel2 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader3 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel16 = New C1.Win.C1InputPanel.InputLabel()
        Me.CompanyName = New C1.Win.C1InputPanel.InputComboBox()
        Me.InputLabel26 = New C1.Win.C1InputPanel.InputLabel()
        Me.Department = New C1.Win.C1InputPanel.InputComboBox()
        Me.InputLabel49 = New C1.Win.C1InputPanel.InputLabel()
        Me.Position = New C1.Win.C1InputPanel.InputComboBox()
        Me.InputLabel25 = New C1.Win.C1InputPanel.InputLabel()
        Me.ImmediateSuperior = New C1.Win.C1InputPanel.InputComboBox()
        Me.InputLabel36 = New C1.Win.C1InputPanel.InputLabel()
        Me.EmploymentLevel = New C1.Win.C1InputPanel.InputComboBox()
        Me.InputLabel14 = New C1.Win.C1InputPanel.InputLabel()
        Me.EmployeeType = New C1.Win.C1InputPanel.InputComboBox()
        Me.InputOption10 = New C1.Win.C1InputPanel.InputOption()
        Me.InputOption11 = New C1.Win.C1InputPanel.InputOption()
        Me.InputOption12 = New C1.Win.C1InputPanel.InputOption()
        Me.InputOption13 = New C1.Win.C1InputPanel.InputOption()
        Me.InputOption14 = New C1.Win.C1InputPanel.InputOption()
        Me.InputLabel8 = New C1.Win.C1InputPanel.InputLabel()
        Me.Team = New C1.Win.C1InputPanel.InputComboBox()
        Me.InputLabel15 = New C1.Win.C1InputPanel.InputLabel()
        Me.Location = New C1.Win.C1InputPanel.InputComboBox()
        Me.InputLabel75 = New C1.Win.C1InputPanel.InputLabel()
        Me.EmploymentStatus = New C1.Win.C1InputPanel.InputComboBox()
        Me.InputGroupHeader11 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel7 = New C1.Win.C1InputPanel.InputLabel()
        Me.TimeSheetApproval = New C1.Win.C1InputPanel.InputComboBox()
        Me.InputLabel50 = New C1.Win.C1InputPanel.InputLabel()
        Me.OvertimeApproval = New C1.Win.C1InputPanel.InputComboBox()
        Me.C1DockingTab1 = New C1.Win.C1Command.C1DockingTab()
        Me.C1DockingTabPage4 = New C1.Win.C1Command.C1DockingTabPage()
        Me.DependentsGrid = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.NewDependent = New System.Windows.Forms.ToolStripButton()
        Me.EditDependent = New System.Windows.Forms.ToolStripButton()
        Me.DeleteDependent = New System.Windows.Forms.ToolStripButton()
        Me.dependentstotal = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.DependenceRefresh = New System.Windows.Forms.ToolStripButton()
        Me.C1InputPanel11 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader16 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.C1DockingTabPage12 = New C1.Win.C1Command.C1DockingTabPage()
        Me.ToolStrip6 = New System.Windows.Forms.ToolStrip()
        Me.memototal = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel12 = New System.Windows.Forms.ToolStripLabel()
        Me.MemoGrid = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1InputPanel20 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader6 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputComboBox5 = New C1.Win.C1InputPanel.InputComboBox()
        Me.InputComboBox6 = New C1.Win.C1InputPanel.InputComboBox()
        Me.InputComboBox7 = New C1.Win.C1InputPanel.InputComboBox()
        Me.C1Ribbon1 = New C1.Win.C1Ribbon.C1Ribbon()
        Me.RibbonApplicationMenu1 = New C1.Win.C1Ribbon.RibbonApplicationMenu()
        Me.RibbonConfigToolBar1 = New C1.Win.C1Ribbon.RibbonConfigToolBar()
        Me.RibbonQat1 = New C1.Win.C1Ribbon.RibbonQat()
        Me.ModuleControlTab = New C1.Win.C1Ribbon.RibbonTab()
        Me.RibbonGroup1 = New C1.Win.C1Ribbon.RibbonGroup()
        Me.SaveJobOrder = New C1.Win.C1Ribbon.RibbonButton()
        Me.NewOrder = New C1.Win.C1Ribbon.RibbonButton()
        Me.PrintCreditMemo = New C1.Win.C1Ribbon.RibbonButton()
        Me.CloseForm = New C1.Win.C1Ribbon.RibbonButton()
        Me.CancelSOButton = New C1.Win.C1Ribbon.RibbonButton()
        Me.RibbonGroup2 = New C1.Win.C1Ribbon.RibbonGroup()
        Me.updateaddress = New C1.Win.C1Ribbon.RibbonButton()
        Me.updatedependent = New C1.Win.C1Ribbon.RibbonButton()
        Me.updatetraining = New C1.Win.C1Ribbon.RibbonButton()
        Me.updateeducation = New C1.Win.C1Ribbon.RibbonButton()
        Me.updateemployment = New C1.Win.C1Ribbon.RibbonButton()
        Me.updatememo = New C1.Win.C1Ribbon.RibbonButton()
        Me.RibbonGroup3 = New C1.Win.C1Ribbon.RibbonGroup()
        Me.RibbonButton9 = New C1.Win.C1Ribbon.RibbonButton()
        Me.RibbonButton7 = New C1.Win.C1Ribbon.RibbonButton()
        Me.RibbonButton8 = New C1.Win.C1Ribbon.RibbonButton()
        Me.InputGroupHeader23 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.InputGroupHeader1 = New C1.Win.C1InputPanel.InputGroupHeader()
        Me.InputLabel6 = New C1.Win.C1InputPanel.InputLabel()
        Me.EmployeeNo = New C1.Win.C1InputPanel.InputTextBox()
        Me.Search = New C1.Win.C1InputPanel.InputButton()
        Me.InputSeparator1 = New C1.Win.C1InputPanel.InputSeparator()
        Me.InputLabel1 = New C1.Win.C1InputPanel.InputLabel()
        Me.FirstName = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel2 = New C1.Win.C1InputPanel.InputLabel()
        Me.MiddleName = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel3 = New C1.Win.C1InputPanel.InputLabel()
        Me.LastName = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel4 = New C1.Win.C1InputPanel.InputLabel()
        Me.Suffix = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel9 = New C1.Win.C1InputPanel.InputLabel()
        Me.Gender = New C1.Win.C1InputPanel.InputComboBox()
        Me.InputOption3 = New C1.Win.C1InputPanel.InputOption()
        Me.InputOption5 = New C1.Win.C1InputPanel.InputOption()
        Me.InputLabel13 = New C1.Win.C1InputPanel.InputLabel()
        Me.ContactNo = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel17 = New C1.Win.C1InputPanel.InputLabel()
        Me.Email = New C1.Win.C1InputPanel.InputTextBox()
        Me.active = New C1.Win.C1InputPanel.InputCheckBox()
        Me.InputSeparator2 = New C1.Win.C1InputPanel.InputSeparator()
        Me.InputLabel5 = New C1.Win.C1InputPanel.InputLabel()
        Me.TIN = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel11 = New C1.Win.C1InputPanel.InputLabel()
        Me.SSS = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel10 = New C1.Win.C1InputPanel.InputLabel()
        Me.PHIC = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel12 = New C1.Win.C1InputPanel.InputLabel()
        Me.HDMF = New C1.Win.C1InputPanel.InputTextBox()
        Me.InputLabel48 = New C1.Win.C1InputPanel.InputLabel()
        Me.BankAccount = New C1.Win.C1InputPanel.InputTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.C1CommandHolder1 = New C1.Win.C1Command.C1CommandHolder()
        Me.C1Command1 = New C1.Win.C1Command.C1Command()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.InputLabel33 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputNumericBox1 = New C1.Win.C1InputPanel.InputNumericBox()
        Me.InputLabel34 = New C1.Win.C1InputPanel.InputLabel()
        Me.InputNumericBox2 = New C1.Win.C1InputPanel.InputNumericBox()
        Me.C1DockingTabPage6.SuspendLayout()
        Me.ToolStrip5.SuspendLayout()
        CType(Me.EmploymentGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1DockingTabPage5.SuspendLayout()
        CType(Me.C1SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1SplitContainer2.SuspendLayout()
        Me.C1SplitterPanel3.SuspendLayout()
        CType(Me.EducationGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip4.SuspendLayout()
        Me.C1SplitterPanel4.SuspendLayout()
        CType(Me.TrainingGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip3.SuspendLayout()
        Me.C1DockingTabPage3.SuspendLayout()
        CType(Me.C1SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1SplitContainer1.SuspendLayout()
        Me.C1SplitterPanel1.SuspendLayout()
        CType(Me.PaySetUpGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip7.SuspendLayout()
        Me.C1SplitterPanel2.SuspendLayout()
        Me.ToolStrip8.SuspendLayout()
        CType(Me.AllowanceGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1DockingTabPage2.SuspendLayout()
        CType(Me.ResidenceGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.C1InputPanel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1DockingTabPage1.SuspendLayout()
        CType(Me.RequirementGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1DockingTab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1DockingTab1.SuspendLayout()
        Me.C1DockingTabPage4.SuspendLayout()
        CType(Me.DependentsGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.C1InputPanel11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1DockingTabPage12.SuspendLayout()
        Me.ToolStrip6.SuspendLayout()
        CType(Me.MemoGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Ribbon1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1DockingTabPage6
        '
        Me.C1DockingTabPage6.Controls.Add(Me.ToolStrip5)
        Me.C1DockingTabPage6.Controls.Add(Me.EmploymentGrid)
        Me.C1DockingTabPage6.Controls.Add(Me.C1InputPanel12)
        Me.C1DockingTabPage6.Location = New System.Drawing.Point(1, 26)
        Me.C1DockingTabPage6.Name = "C1DockingTabPage6"
        Me.C1DockingTabPage6.Size = New System.Drawing.Size(1257, 471)
        Me.C1DockingTabPage6.TabIndex = 5
        Me.C1DockingTabPage6.Text = "Employment History"
        '
        'ToolStrip5
        '
        Me.ToolStrip5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip5.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewEmployment, Me.EditEmployment, Me.DeleteEmployment, Me.employmentotal, Me.ToolStripSeparator5, Me.ToolStripLabel10, Me.EmploymentRefresh})
        Me.ToolStrip5.Location = New System.Drawing.Point(0, 446)
        Me.ToolStrip5.Name = "ToolStrip5"
        Me.ToolStrip5.Size = New System.Drawing.Size(1257, 25)
        Me.ToolStrip5.TabIndex = 66
        Me.ToolStrip5.Text = "ToolStrip5"
        '
        'NewEmployment
        '
        Me.NewEmployment.Image = Global.A1plus.My.Resources.Resources.DocumentHS
        Me.NewEmployment.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewEmployment.Name = "NewEmployment"
        Me.NewEmployment.Size = New System.Drawing.Size(51, 22)
        Me.NewEmployment.Text = "New"
        '
        'EditEmployment
        '
        Me.EditEmployment.Image = Global.A1plus.My.Resources.Resources.document_edit
        Me.EditEmployment.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EditEmployment.Name = "EditEmployment"
        Me.EditEmployment.Size = New System.Drawing.Size(47, 22)
        Me.EditEmployment.Text = "Edit"
        '
        'DeleteEmployment
        '
        Me.DeleteEmployment.Image = Global.A1plus.My.Resources.Resources.deletered__1_
        Me.DeleteEmployment.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DeleteEmployment.Name = "DeleteEmployment"
        Me.DeleteEmployment.Size = New System.Drawing.Size(60, 22)
        Me.DeleteEmployment.Text = "Delete"
        '
        'employmentotal
        '
        Me.employmentotal.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.employmentotal.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employmentotal.Name = "employmentotal"
        Me.employmentotal.Size = New System.Drawing.Size(14, 22)
        Me.employmentotal.Text = "0"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel10
        '
        Me.ToolStripLabel10.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel10.Name = "ToolStripLabel10"
        Me.ToolStripLabel10.Size = New System.Drawing.Size(108, 22)
        Me.ToolStripLabel10.Text = "No of Employment"
        '
        'EmploymentRefresh
        '
        Me.EmploymentRefresh.Image = Global.A1plus.My.Resources.Resources.reload__1_
        Me.EmploymentRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EmploymentRefresh.Name = "EmploymentRefresh"
        Me.EmploymentRefresh.Size = New System.Drawing.Size(66, 22)
        Me.EmploymentRefresh.Text = "Refresh"
        '
        'EmploymentGrid
        '
        Me.EmploymentGrid.AllowEditing = False
        Me.EmploymentGrid.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Columns
        Me.EmploymentGrid.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.EmploymentGrid.AutoResize = True
        Me.EmploymentGrid.BackColor = System.Drawing.Color.White
        Me.EmploymentGrid.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None
        Me.EmploymentGrid.ColumnInfo = resources.GetString("EmploymentGrid.ColumnInfo")
        Me.EmploymentGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EmploymentGrid.ExtendLastCol = True
        Me.EmploymentGrid.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
        Me.EmploymentGrid.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.EmploymentGrid.ForeColor = System.Drawing.Color.Black
        Me.EmploymentGrid.IgnoreDiacritics = True
        Me.EmploymentGrid.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.None
        Me.EmploymentGrid.Location = New System.Drawing.Point(0, 33)
        Me.EmploymentGrid.Name = "EmploymentGrid"
        Me.EmploymentGrid.Rows.Count = 1
        Me.EmploymentGrid.Rows.DefaultSize = 19
        Me.EmploymentGrid.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.EmploymentGrid.ShowCursor = True
        Me.EmploymentGrid.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.None
        Me.EmploymentGrid.Size = New System.Drawing.Size(1257, 438)
        Me.EmploymentGrid.StyleInfo = resources.GetString("EmploymentGrid.StyleInfo")
        Me.EmploymentGrid.TabIndex = 61
        Me.EmploymentGrid.Tree.Style = CType(((C1.Win.C1FlexGrid.TreeStyleFlags.Lines Or C1.Win.C1FlexGrid.TreeStyleFlags.Symbols) _
                    Or C1.Win.C1FlexGrid.TreeStyleFlags.Leaf), C1.Win.C1FlexGrid.TreeStyleFlags)
        Me.EmploymentGrid.UseCompatibleTextRendering = False
        Me.EmploymentGrid.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Silver
        '
        'C1InputPanel12
        '
        Me.C1InputPanel12.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel12.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel12.Items.Add(Me.InputGroupHeader17)
        Me.C1InputPanel12.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel12.Name = "C1InputPanel12"
        Me.C1InputPanel12.Size = New System.Drawing.Size(1257, 33)
        Me.C1InputPanel12.TabIndex = 63
        Me.C1InputPanel12.VisualStyle = C1.Win.C1InputPanel.VisualStyle.System
        '
        'InputGroupHeader17
        '
        Me.InputGroupHeader17.Name = "InputGroupHeader17"
        Me.InputGroupHeader17.Text = "EMPLOYMENT HISTORY LIST"
        '
        'C1DockingTabPage5
        '
        Me.C1DockingTabPage5.Controls.Add(Me.C1SplitContainer2)
        Me.C1DockingTabPage5.Location = New System.Drawing.Point(1, 26)
        Me.C1DockingTabPage5.Name = "C1DockingTabPage5"
        Me.C1DockingTabPage5.Size = New System.Drawing.Size(1257, 471)
        Me.C1DockingTabPage5.TabIndex = 4
        Me.C1DockingTabPage5.Text = "Education and Trainings"
        '
        'C1SplitContainer2
        '
        Me.C1SplitContainer2.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.C1SplitContainer2.CollapsingCueColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.C1SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1SplitContainer2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.C1SplitContainer2.LineBelowHeader = False
        Me.C1SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.C1SplitContainer2.Name = "C1SplitContainer2"
        Me.C1SplitContainer2.Panels.Add(Me.C1SplitterPanel3)
        Me.C1SplitContainer2.Panels.Add(Me.C1SplitterPanel4)
        Me.C1SplitContainer2.Size = New System.Drawing.Size(1257, 471)
        Me.C1SplitContainer2.SplitterWidth = 5
        Me.C1SplitContainer2.TabIndex = 69
        Me.C1SplitContainer2.UseParentVisualStyle = False
        '
        'C1SplitterPanel3
        '
        Me.C1SplitterPanel3.Collapsible = True
        Me.C1SplitterPanel3.Controls.Add(Me.EducationGrid)
        Me.C1SplitterPanel3.Controls.Add(Me.ToolStrip4)
        Me.C1SplitterPanel3.Height = 206
        Me.C1SplitterPanel3.Location = New System.Drawing.Point(0, 21)
        Me.C1SplitterPanel3.Name = "C1SplitterPanel3"
        Me.C1SplitterPanel3.Size = New System.Drawing.Size(1257, 178)
        Me.C1SplitterPanel3.SizeRatio = 44.298R
        Me.C1SplitterPanel3.TabIndex = 0
        Me.C1SplitterPanel3.Text = "EDUCATIONAL BACKGROUND"
        Me.C1SplitterPanel3.Width = 586
        '
        'EducationGrid
        '
        Me.EducationGrid.AllowEditing = False
        Me.EducationGrid.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Columns
        Me.EducationGrid.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.EducationGrid.AutoResize = True
        Me.EducationGrid.BackColor = System.Drawing.Color.White
        Me.EducationGrid.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None
        Me.EducationGrid.ColumnInfo = resources.GetString("EducationGrid.ColumnInfo")
        Me.EducationGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EducationGrid.ExtendLastCol = True
        Me.EducationGrid.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
        Me.EducationGrid.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.EducationGrid.ForeColor = System.Drawing.Color.Black
        Me.EducationGrid.IgnoreDiacritics = True
        Me.EducationGrid.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.None
        Me.EducationGrid.Location = New System.Drawing.Point(0, 0)
        Me.EducationGrid.Name = "EducationGrid"
        Me.EducationGrid.Rows.Count = 1
        Me.EducationGrid.Rows.DefaultSize = 19
        Me.EducationGrid.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.EducationGrid.ShowCursor = True
        Me.EducationGrid.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.None
        Me.EducationGrid.Size = New System.Drawing.Size(1257, 153)
        Me.EducationGrid.StyleInfo = resources.GetString("EducationGrid.StyleInfo")
        Me.EducationGrid.TabIndex = 60
        Me.EducationGrid.Tree.Style = CType(((C1.Win.C1FlexGrid.TreeStyleFlags.Lines Or C1.Win.C1FlexGrid.TreeStyleFlags.Symbols) _
                    Or C1.Win.C1FlexGrid.TreeStyleFlags.Leaf), C1.Win.C1FlexGrid.TreeStyleFlags)
        Me.EducationGrid.UseCompatibleTextRendering = False
        Me.EducationGrid.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Silver
        '
        'ToolStrip4
        '
        Me.ToolStrip4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewEducation, Me.EditEducation, Me.DeleteEducation, Me.educationtotal, Me.ToolStripSeparator4, Me.ToolStripLabel8, Me.EducationRefresh})
        Me.ToolStrip4.Location = New System.Drawing.Point(0, 153)
        Me.ToolStrip4.Name = "ToolStrip4"
        Me.ToolStrip4.Size = New System.Drawing.Size(1257, 25)
        Me.ToolStrip4.TabIndex = 66
        Me.ToolStrip4.Text = "ToolStrip4"
        '
        'NewEducation
        '
        Me.NewEducation.Image = Global.A1plus.My.Resources.Resources.DocumentHS
        Me.NewEducation.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewEducation.Name = "NewEducation"
        Me.NewEducation.Size = New System.Drawing.Size(51, 22)
        Me.NewEducation.Text = "New"
        '
        'EditEducation
        '
        Me.EditEducation.Image = Global.A1plus.My.Resources.Resources.document_edit
        Me.EditEducation.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EditEducation.Name = "EditEducation"
        Me.EditEducation.Size = New System.Drawing.Size(47, 22)
        Me.EditEducation.Text = "Edit"
        '
        'DeleteEducation
        '
        Me.DeleteEducation.Image = Global.A1plus.My.Resources.Resources.deletered__1_
        Me.DeleteEducation.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DeleteEducation.Name = "DeleteEducation"
        Me.DeleteEducation.Size = New System.Drawing.Size(60, 22)
        Me.DeleteEducation.Text = "Delete"
        '
        'educationtotal
        '
        Me.educationtotal.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.educationtotal.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.educationtotal.Name = "educationtotal"
        Me.educationtotal.Size = New System.Drawing.Size(14, 22)
        Me.educationtotal.Text = "0"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel8
        '
        Me.ToolStripLabel8.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel8.Name = "ToolStripLabel8"
        Me.ToolStripLabel8.Size = New System.Drawing.Size(141, 22)
        Me.ToolStripLabel8.Text = "No of Education Attained"
        '
        'EducationRefresh
        '
        Me.EducationRefresh.Image = Global.A1plus.My.Resources.Resources.reload__1_
        Me.EducationRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EducationRefresh.Name = "EducationRefresh"
        Me.EducationRefresh.Size = New System.Drawing.Size(66, 22)
        Me.EducationRefresh.Text = "Refresh"
        '
        'C1SplitterPanel4
        '
        Me.C1SplitterPanel4.Controls.Add(Me.TrainingGrid)
        Me.C1SplitterPanel4.Controls.Add(Me.ToolStrip3)
        Me.C1SplitterPanel4.Height = 100
        Me.C1SplitterPanel4.Location = New System.Drawing.Point(0, 232)
        Me.C1SplitterPanel4.Name = "C1SplitterPanel4"
        Me.C1SplitterPanel4.Size = New System.Drawing.Size(1257, 239)
        Me.C1SplitterPanel4.TabIndex = 1
        Me.C1SplitterPanel4.Text = "TRAININGS, SEMINARS, SHORT COURSES ATTENDED"
        '
        'TrainingGrid
        '
        Me.TrainingGrid.AllowEditing = False
        Me.TrainingGrid.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Columns
        Me.TrainingGrid.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.TrainingGrid.AutoResize = True
        Me.TrainingGrid.BackColor = System.Drawing.Color.White
        Me.TrainingGrid.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None
        Me.TrainingGrid.ColumnInfo = resources.GetString("TrainingGrid.ColumnInfo")
        Me.TrainingGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TrainingGrid.ExtendLastCol = True
        Me.TrainingGrid.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
        Me.TrainingGrid.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.TrainingGrid.ForeColor = System.Drawing.Color.Black
        Me.TrainingGrid.IgnoreDiacritics = True
        Me.TrainingGrid.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.None
        Me.TrainingGrid.Location = New System.Drawing.Point(0, 0)
        Me.TrainingGrid.Name = "TrainingGrid"
        Me.TrainingGrid.Rows.Count = 1
        Me.TrainingGrid.Rows.DefaultSize = 19
        Me.TrainingGrid.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.TrainingGrid.ShowCursor = True
        Me.TrainingGrid.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.None
        Me.TrainingGrid.Size = New System.Drawing.Size(1257, 214)
        Me.TrainingGrid.StyleInfo = resources.GetString("TrainingGrid.StyleInfo")
        Me.TrainingGrid.TabIndex = 64
        Me.TrainingGrid.Tree.Style = CType(((C1.Win.C1FlexGrid.TreeStyleFlags.Lines Or C1.Win.C1FlexGrid.TreeStyleFlags.Symbols) _
                    Or C1.Win.C1FlexGrid.TreeStyleFlags.Leaf), C1.Win.C1FlexGrid.TreeStyleFlags)
        Me.TrainingGrid.UseCompatibleTextRendering = False
        Me.TrainingGrid.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Silver
        '
        'ToolStrip3
        '
        Me.ToolStrip3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewTraining, Me.EditTraining, Me.DeleteTraining, Me.trainingtotal, Me.ToolStripSeparator3, Me.ToolStripLabel6, Me.TrainingRefresh})
        Me.ToolStrip3.Location = New System.Drawing.Point(0, 214)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Size = New System.Drawing.Size(1257, 25)
        Me.ToolStrip3.TabIndex = 65
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'NewTraining
        '
        Me.NewTraining.Image = Global.A1plus.My.Resources.Resources.DocumentHS
        Me.NewTraining.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewTraining.Name = "NewTraining"
        Me.NewTraining.Size = New System.Drawing.Size(51, 22)
        Me.NewTraining.Text = "New"
        '
        'EditTraining
        '
        Me.EditTraining.Image = Global.A1plus.My.Resources.Resources.document_edit
        Me.EditTraining.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EditTraining.Name = "EditTraining"
        Me.EditTraining.Size = New System.Drawing.Size(47, 22)
        Me.EditTraining.Text = "Edit"
        '
        'DeleteTraining
        '
        Me.DeleteTraining.Image = Global.A1plus.My.Resources.Resources.deletered__1_
        Me.DeleteTraining.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DeleteTraining.Name = "DeleteTraining"
        Me.DeleteTraining.Size = New System.Drawing.Size(60, 22)
        Me.DeleteTraining.Text = "Delete"
        '
        'trainingtotal
        '
        Me.trainingtotal.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.trainingtotal.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.trainingtotal.Name = "trainingtotal"
        Me.trainingtotal.Size = New System.Drawing.Size(14, 22)
        Me.trainingtotal.Text = "0"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel6
        '
        Me.ToolStripLabel6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel6.Name = "ToolStripLabel6"
        Me.ToolStripLabel6.Size = New System.Drawing.Size(88, 22)
        Me.ToolStripLabel6.Text = "No of Trainings"
        '
        'TrainingRefresh
        '
        Me.TrainingRefresh.Image = Global.A1plus.My.Resources.Resources.reload__1_
        Me.TrainingRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TrainingRefresh.Name = "TrainingRefresh"
        Me.TrainingRefresh.Size = New System.Drawing.Size(66, 22)
        Me.TrainingRefresh.Text = "Refresh"
        '
        'C1DockingTabPage3
        '
        Me.C1DockingTabPage3.Controls.Add(Me.C1SplitContainer1)
        Me.C1DockingTabPage3.Controls.Add(Me.C1InputPanel4)
        Me.C1DockingTabPage3.Location = New System.Drawing.Point(1, 26)
        Me.C1DockingTabPage3.Name = "C1DockingTabPage3"
        Me.C1DockingTabPage3.Size = New System.Drawing.Size(1257, 471)
        Me.C1DockingTabPage3.TabIndex = 2
        Me.C1DockingTabPage3.Text = "Payroll Info"
        '
        'C1SplitContainer1
        '
        Me.C1SplitContainer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.C1SplitContainer1.CollapsingCueColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.C1SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1SplitContainer1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.C1SplitContainer1.LineBelowHeader = False
        Me.C1SplitContainer1.Location = New System.Drawing.Point(572, 0)
        Me.C1SplitContainer1.Name = "C1SplitContainer1"
        Me.C1SplitContainer1.Panels.Add(Me.C1SplitterPanel1)
        Me.C1SplitContainer1.Panels.Add(Me.C1SplitterPanel2)
        Me.C1SplitContainer1.Size = New System.Drawing.Size(685, 471)
        Me.C1SplitContainer1.SplitterWidth = 1
        Me.C1SplitContainer1.TabIndex = 71
        Me.C1SplitContainer1.UseParentVisualStyle = False
        '
        'C1SplitterPanel1
        '
        Me.C1SplitterPanel1.Collapsible = True
        Me.C1SplitterPanel1.Controls.Add(Me.PaySetUpGrid)
        Me.C1SplitterPanel1.Controls.Add(Me.ToolStrip7)
        Me.C1SplitterPanel1.Dock = C1.Win.C1SplitContainer.PanelDockStyle.Left
        Me.C1SplitterPanel1.Height = 258
        Me.C1SplitterPanel1.Location = New System.Drawing.Point(0, 21)
        Me.C1SplitterPanel1.Name = "C1SplitterPanel1"
        Me.C1SplitterPanel1.Size = New System.Drawing.Size(326, 450)
        Me.C1SplitterPanel1.SizeRatio = 48.669R
        Me.C1SplitterPanel1.TabIndex = 0
        Me.C1SplitterPanel1.Text = "Earnings, Deductions and Other Income"
        Me.C1SplitterPanel1.Width = 333
        '
        'PaySetUpGrid
        '
        Me.PaySetUpGrid.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Columns
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
        Me.PaySetUpGrid.Location = New System.Drawing.Point(0, 0)
        Me.PaySetUpGrid.Name = "PaySetUpGrid"
        Me.PaySetUpGrid.Rows.Count = 1
        Me.PaySetUpGrid.Rows.DefaultSize = 19
        Me.PaySetUpGrid.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.PaySetUpGrid.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.PaySetUpGrid.ShowCursor = True
        Me.PaySetUpGrid.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.None
        Me.PaySetUpGrid.Size = New System.Drawing.Size(326, 450)
        Me.PaySetUpGrid.StyleInfo = resources.GetString("PaySetUpGrid.StyleInfo")
        Me.PaySetUpGrid.TabIndex = 60
        Me.PaySetUpGrid.Tree.Style = CType(((C1.Win.C1FlexGrid.TreeStyleFlags.Lines Or C1.Win.C1FlexGrid.TreeStyleFlags.Symbols) _
                    Or C1.Win.C1FlexGrid.TreeStyleFlags.Leaf), C1.Win.C1FlexGrid.TreeStyleFlags)
        Me.PaySetUpGrid.UseCompatibleTextRendering = False
        Me.PaySetUpGrid.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Silver
        '
        'ToolStrip7
        '
        Me.ToolStrip7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip7.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton2, Me.ToolStripLabel1, Me.ToolStripSeparator7, Me.ToolStripLabel2, Me.ToolStripButton5})
        Me.ToolStrip7.Location = New System.Drawing.Point(0, 350)
        Me.ToolStrip7.Name = "ToolStrip7"
        Me.ToolStrip7.Size = New System.Drawing.Size(379, 25)
        Me.ToolStrip7.TabIndex = 66
        Me.ToolStrip7.Text = "ToolStrip7"
        Me.ToolStrip7.Visible = False
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = Global.A1plus.My.Resources.Resources.add_over
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(49, 22)
        Me.ToolStripButton2.Text = "Add"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(14, 22)
        Me.ToolStripLabel1.Text = "0"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(59, 22)
        Me.ToolStripLabel2.Text = "No of Pay"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.Image = Global.A1plus.My.Resources.Resources.reload__1_
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(66, 22)
        Me.ToolStripButton5.Text = "Refresh"
        '
        'C1SplitterPanel2
        '
        Me.C1SplitterPanel2.Controls.Add(Me.ToolStrip8)
        Me.C1SplitterPanel2.Controls.Add(Me.AllowanceGrid)
        Me.C1SplitterPanel2.Height = 100
        Me.C1SplitterPanel2.Location = New System.Drawing.Point(334, 21)
        Me.C1SplitterPanel2.Name = "C1SplitterPanel2"
        Me.C1SplitterPanel2.Size = New System.Drawing.Size(351, 450)
        Me.C1SplitterPanel2.TabIndex = 1
        Me.C1SplitterPanel2.Text = "Other Allowances..."
        '
        'ToolStrip8
        '
        Me.ToolStrip8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip8.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton6, Me.ToolStripLabel5, Me.ToolStripSeparator8, Me.ToolStripLabel7, Me.ToolStripButton9})
        Me.ToolStrip8.Location = New System.Drawing.Point(0, 350)
        Me.ToolStrip8.Name = "ToolStrip8"
        Me.ToolStrip8.Size = New System.Drawing.Size(407, 25)
        Me.ToolStrip8.TabIndex = 65
        Me.ToolStrip8.Text = "ToolStrip8"
        Me.ToolStrip8.Visible = False
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.Image = Global.A1plus.My.Resources.Resources.add_over
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(49, 22)
        Me.ToolStripButton6.Text = "Add"
        '
        'ToolStripLabel5
        '
        Me.ToolStripLabel5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel5.Name = "ToolStripLabel5"
        Me.ToolStripLabel5.Size = New System.Drawing.Size(14, 22)
        Me.ToolStripLabel5.Text = "0"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel7
        '
        Me.ToolStripLabel7.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel7.Name = "ToolStripLabel7"
        Me.ToolStripLabel7.Size = New System.Drawing.Size(100, 22)
        Me.ToolStripLabel7.Text = "No of Allowances"
        '
        'ToolStripButton9
        '
        Me.ToolStripButton9.Image = Global.A1plus.My.Resources.Resources.reload__1_
        Me.ToolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton9.Name = "ToolStripButton9"
        Me.ToolStripButton9.Size = New System.Drawing.Size(66, 22)
        Me.ToolStripButton9.Text = "Refresh"
        '
        'AllowanceGrid
        '
        Me.AllowanceGrid.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Columns
        Me.AllowanceGrid.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.AllowanceGrid.AutoResize = True
        Me.AllowanceGrid.BackColor = System.Drawing.Color.White
        Me.AllowanceGrid.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None
        Me.AllowanceGrid.ColumnInfo = resources.GetString("AllowanceGrid.ColumnInfo")
        Me.AllowanceGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AllowanceGrid.ExtendLastCol = True
        Me.AllowanceGrid.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
        Me.AllowanceGrid.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.AllowanceGrid.ForeColor = System.Drawing.Color.Black
        Me.AllowanceGrid.IgnoreDiacritics = True
        Me.AllowanceGrid.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.None
        Me.AllowanceGrid.Location = New System.Drawing.Point(0, 0)
        Me.AllowanceGrid.Name = "AllowanceGrid"
        Me.AllowanceGrid.Rows.Count = 1
        Me.AllowanceGrid.Rows.DefaultSize = 19
        Me.AllowanceGrid.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.AllowanceGrid.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.AllowanceGrid.ShowCursor = True
        Me.AllowanceGrid.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.None
        Me.AllowanceGrid.Size = New System.Drawing.Size(351, 450)
        Me.AllowanceGrid.StyleInfo = resources.GetString("AllowanceGrid.StyleInfo")
        Me.AllowanceGrid.TabIndex = 64
        Me.AllowanceGrid.Tree.Style = CType(((C1.Win.C1FlexGrid.TreeStyleFlags.Lines Or C1.Win.C1FlexGrid.TreeStyleFlags.Symbols) _
                    Or C1.Win.C1FlexGrid.TreeStyleFlags.Leaf), C1.Win.C1FlexGrid.TreeStyleFlags)
        Me.AllowanceGrid.UseCompatibleTextRendering = False
        Me.AllowanceGrid.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Silver
        '
        'C1InputPanel4
        '
        Me.C1InputPanel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.C1InputPanel4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel4.Items.Add(Me.InputGroupHeader8)
        Me.C1InputPanel4.Items.Add(Me.InputLabel45)
        Me.C1InputPanel4.Items.Add(Me.payrollgroup)
        Me.C1InputPanel4.Items.Add(Me.InputLabel44)
        Me.C1InputPanel4.Items.Add(Me.paymentmethod)
        Me.C1InputPanel4.Items.Add(Me.InputLabel55)
        Me.C1InputPanel4.Items.Add(Me.MonthlyPay)
        Me.C1InputPanel4.Items.Add(Me.InputLabel43)
        Me.C1InputPanel4.Items.Add(Me.MonthlyHours)
        Me.C1InputPanel4.Items.Add(Me.InputGroupHeader14)
        Me.C1InputPanel4.Items.Add(Me.InputLabel54)
        Me.C1InputPanel4.Items.Add(Me.InputLabel51)
        Me.C1InputPanel4.Items.Add(Me.InputLabel42)
        Me.C1InputPanel4.Items.Add(Me.BasicSalary)
        Me.C1InputPanel4.Items.Add(Me.InputLabel61)
        Me.C1InputPanel4.Items.Add(Me.BasicPayHourly)
        Me.C1InputPanel4.Items.Add(Me.InputLabel28)
        Me.C1InputPanel4.Items.Add(Me.HiddenAllowance)
        Me.C1InputPanel4.Items.Add(Me.InputLabel30)
        Me.C1InputPanel4.Items.Add(Me.HiddenAllowanceRate)
        Me.C1InputPanel4.Items.Add(Me.InputLabel27)
        Me.C1InputPanel4.Items.Add(Me.LegalAllowance)
        Me.C1InputPanel4.Items.Add(Me.InputLabel67)
        Me.C1InputPanel4.Items.Add(Me.cola)
        Me.C1InputPanel4.Items.Add(Me.InputLabel66)
        Me.C1InputPanel4.Items.Add(Me.SSSEEShare)
        Me.C1InputPanel4.Items.Add(Me.InputLabel71)
        Me.C1InputPanel4.Items.Add(Me.PHICEEShare)
        Me.C1InputPanel4.Items.Add(Me.InputLabel69)
        Me.C1InputPanel4.Items.Add(Me.HDMFEEShare)
        Me.C1InputPanel4.Items.Add(Me.InputLabel52)
        Me.C1InputPanel4.Items.Add(Me.InputLabel31)
        Me.C1InputPanel4.Items.Add(Me.GrossPay)
        Me.C1InputPanel4.Items.Add(Me.InputSeparator5)
        Me.C1InputPanel4.Items.Add(Me.InputLabel70)
        Me.C1InputPanel4.Items.Add(Me.BasicPay)
        Me.C1InputPanel4.Items.Add(Me.InputLabel68)
        Me.C1InputPanel4.Items.Add(Me.Exception)
        Me.C1InputPanel4.Items.Add(Me.InputLabel72)
        Me.C1InputPanel4.Items.Add(Me.Mandatory)
        Me.C1InputPanel4.Items.Add(Me.InputSeparator6)
        Me.C1InputPanel4.Items.Add(Me.InputLabel29)
        Me.C1InputPanel4.Items.Add(Me.TaxableIncome)
        Me.C1InputPanel4.Items.Add(Me.InputLabel73)
        Me.C1InputPanel4.Items.Add(Me.wtax)
        Me.C1InputPanel4.Items.Add(Me.InputSeparator4)
        Me.C1InputPanel4.Items.Add(Me.InputLabel32)
        Me.C1InputPanel4.Items.Add(Me.NetPay)
        Me.C1InputPanel4.Items.Add(Me.InputGroupHeader22)
        Me.C1InputPanel4.Items.Add(Me.deducttax)
        Me.C1InputPanel4.Items.Add(Me.deductsss)
        Me.C1InputPanel4.Items.Add(Me.deducthdmf)
        Me.C1InputPanel4.Items.Add(Me.deductphic)
        Me.C1InputPanel4.Items.Add(Me.InputSeparator3)
        Me.C1InputPanel4.Items.Add(Me.ChargetoCompany)
        Me.C1InputPanel4.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel4.Name = "C1InputPanel4"
        Me.C1InputPanel4.Size = New System.Drawing.Size(572, 471)
        Me.C1InputPanel4.TabIndex = 7
        Me.C1InputPanel4.VisualStyle = C1.Win.C1InputPanel.VisualStyle.System
        '
        'InputGroupHeader8
        '
        Me.InputGroupHeader8.Name = "InputGroupHeader8"
        Me.InputGroupHeader8.Text = "PAYROLL INFORMATION"
        '
        'InputLabel45
        '
        Me.InputLabel45.Name = "InputLabel45"
        Me.InputLabel45.Text = "Payroll Group:"
        Me.InputLabel45.Width = 79
        '
        'payrollgroup
        '
        Me.payrollgroup.Break = C1.Win.C1InputPanel.BreakType.None
        Me.payrollgroup.Name = "payrollgroup"
        Me.payrollgroup.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.payrollgroup.Width = 175
        '
        'InputLabel44
        '
        Me.InputLabel44.Name = "InputLabel44"
        Me.InputLabel44.Text = "Payment Method:"
        Me.InputLabel44.Width = 112
        '
        'paymentmethod
        '
        Me.paymentmethod.Name = "paymentmethod"
        Me.paymentmethod.Width = 124
        '
        'InputLabel55
        '
        Me.InputLabel55.Name = "InputLabel55"
        Me.InputLabel55.Text = "Monthly Pay"
        Me.InputLabel55.Width = 78
        '
        'MonthlyPay
        '
        Me.MonthlyPay.Break = C1.Win.C1InputPanel.BreakType.None
        Me.MonthlyPay.DecimalPlaces = 3
        Me.MonthlyPay.Format = "n"
        Me.MonthlyPay.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.MonthlyPay.Name = "MonthlyPay"
        Me.MonthlyPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.MonthlyPay.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.MonthlyPay.Width = 175
        '
        'InputLabel43
        '
        Me.InputLabel43.Name = "InputLabel43"
        Me.InputLabel43.Text = "Work Hours/Month"
        Me.InputLabel43.Width = 112
        '
        'MonthlyHours
        '
        Me.MonthlyHours.DecimalPlaces = 0
        Me.MonthlyHours.Format = "n"
        Me.MonthlyHours.Maximum = New Decimal(New Integer() {-727379969, 232, 0, 0})
        Me.MonthlyHours.Name = "MonthlyHours"
        Me.MonthlyHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.MonthlyHours.Value = New Decimal(New Integer() {208, 0, 0, 0})
        Me.MonthlyHours.Width = 126
        '
        'InputGroupHeader14
        '
        Me.InputGroupHeader14.Name = "InputGroupHeader14"
        Me.InputGroupHeader14.Text = "MONTHLY EARNINGS AND GOVERNMENT DEDUCTIONS"
        '
        'InputLabel54
        '
        Me.InputLabel54.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel54.Name = "InputLabel54"
        Me.InputLabel54.Text = "Basic Pay and Mandatory"
        Me.InputLabel54.Width = 211
        '
        'InputLabel51
        '
        Me.InputLabel51.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel51.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel51.Name = "InputLabel51"
        Me.InputLabel51.Text = "Rate/Hour"
        Me.InputLabel51.Width = 70
        '
        'InputLabel42
        '
        Me.InputLabel42.Name = "InputLabel42"
        Me.InputLabel42.Text = "Basic Salary"
        Me.InputLabel42.Width = 78
        '
        'BasicSalary
        '
        Me.BasicSalary.Break = C1.Win.C1InputPanel.BreakType.None
        Me.BasicSalary.DecimalPlaces = 3
        Me.BasicSalary.Format = "n"
        Me.BasicSalary.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.BasicSalary.Name = "BasicSalary"
        Me.BasicSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.BasicSalary.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.BasicSalary.Width = 125
        '
        'InputLabel61
        '
        Me.InputLabel61.Name = "InputLabel61"
        Me.InputLabel61.Width = 1
        '
        'BasicPayHourly
        '
        Me.BasicPayHourly.DecimalPlaces = 4
        Me.BasicPayHourly.Format = "n"
        Me.BasicPayHourly.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.BasicPayHourly.Name = "BasicPayHourly"
        Me.BasicPayHourly.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.BasicPayHourly.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.BasicPayHourly.Width = 84
        '
        'InputLabel28
        '
        Me.InputLabel28.Name = "InputLabel28"
        Me.InputLabel28.Text = "On Voucher"
        Me.InputLabel28.Width = 78
        '
        'HiddenAllowance
        '
        Me.HiddenAllowance.Break = C1.Win.C1InputPanel.BreakType.None
        Me.HiddenAllowance.DecimalPlaces = 3
        Me.HiddenAllowance.Format = "n"
        Me.HiddenAllowance.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.HiddenAllowance.Name = "HiddenAllowance"
        Me.HiddenAllowance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.HiddenAllowance.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.HiddenAllowance.Width = 125
        '
        'InputLabel30
        '
        Me.InputLabel30.Name = "InputLabel30"
        Me.InputLabel30.Width = 1
        '
        'HiddenAllowanceRate
        '
        Me.HiddenAllowanceRate.DecimalPlaces = 4
        Me.HiddenAllowanceRate.Format = "n"
        Me.HiddenAllowanceRate.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.HiddenAllowanceRate.Name = "HiddenAllowanceRate"
        Me.HiddenAllowanceRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.HiddenAllowanceRate.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.HiddenAllowanceRate.Width = 84
        '
        'InputLabel27
        '
        Me.InputLabel27.Name = "InputLabel27"
        Me.InputLabel27.Text = "Legal Exemption"
        Me.InputLabel27.Width = 78
        '
        'LegalAllowance
        '
        Me.LegalAllowance.DecimalPlaces = 3
        Me.LegalAllowance.Format = "n"
        Me.LegalAllowance.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.LegalAllowance.Name = "LegalAllowance"
        Me.LegalAllowance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.LegalAllowance.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.LegalAllowance.Width = 125
        '
        'InputLabel67
        '
        Me.InputLabel67.Name = "InputLabel67"
        Me.InputLabel67.Text = "COLA per Day"
        Me.InputLabel67.Width = 78
        '
        'cola
        '
        Me.cola.DecimalPlaces = 3
        Me.cola.Format = "n"
        Me.cola.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.cola.Name = "cola"
        Me.cola.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.cola.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.cola.Width = 125
        '
        'InputLabel66
        '
        Me.InputLabel66.Name = "InputLabel66"
        Me.InputLabel66.Text = "SSS Share"
        Me.InputLabel66.Width = 78
        '
        'SSSEEShare
        '
        Me.SSSEEShare.DecimalPlaces = 3
        Me.SSSEEShare.Format = "n"
        Me.SSSEEShare.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.SSSEEShare.Name = "SSSEEShare"
        Me.SSSEEShare.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SSSEEShare.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SSSEEShare.Width = 125
        '
        'InputLabel71
        '
        Me.InputLabel71.Name = "InputLabel71"
        Me.InputLabel71.Text = "PHIC Share"
        Me.InputLabel71.Width = 78
        '
        'PHICEEShare
        '
        Me.PHICEEShare.DecimalPlaces = 3
        Me.PHICEEShare.Format = "n"
        Me.PHICEEShare.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.PHICEEShare.Name = "PHICEEShare"
        Me.PHICEEShare.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.PHICEEShare.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.PHICEEShare.Width = 125
        '
        'InputLabel69
        '
        Me.InputLabel69.Name = "InputLabel69"
        Me.InputLabel69.Text = "HDMF Share"
        Me.InputLabel69.Width = 78
        '
        'HDMFEEShare
        '
        Me.HDMFEEShare.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.HDMFEEShare.DecimalPlaces = 3
        Me.HDMFEEShare.Format = "n"
        Me.HDMFEEShare.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.HDMFEEShare.Name = "HDMFEEShare"
        Me.HDMFEEShare.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.HDMFEEShare.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.HDMFEEShare.Width = 125
        '
        'InputLabel52
        '
        Me.InputLabel52.Break = C1.Win.C1InputPanel.BreakType.Row
        Me.InputLabel52.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel52.Name = "InputLabel52"
        Me.InputLabel52.Text = "Payroll Breakdown"
        Me.InputLabel52.Width = 231
        '
        'InputLabel31
        '
        Me.InputLabel31.Name = "InputLabel31"
        Me.InputLabel31.Text = "Gross Pay"
        Me.InputLabel31.Width = 63
        '
        'GrossPay
        '
        Me.GrossPay.DecimalPlaces = 3
        Me.GrossPay.Format = "n"
        Me.GrossPay.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.GrossPay.Minimum = New Decimal(New Integer() {99999999, 0, 0, -2147483648})
        Me.GrossPay.Name = "GrossPay"
        Me.GrossPay.ReadOnly = True
        Me.GrossPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.GrossPay.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.GrossPay.Width = 125
        '
        'InputSeparator5
        '
        Me.InputSeparator5.Height = 1
        Me.InputSeparator5.Name = "InputSeparator5"
        Me.InputSeparator5.Width = 208
        '
        'InputLabel70
        '
        Me.InputLabel70.Name = "InputLabel70"
        Me.InputLabel70.Text = "Basic Pay"
        Me.InputLabel70.Width = 63
        '
        'BasicPay
        '
        Me.BasicPay.DecimalPlaces = 3
        Me.BasicPay.Format = "n"
        Me.BasicPay.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.BasicPay.Minimum = New Decimal(New Integer() {99999999, 0, 0, -2147483648})
        Me.BasicPay.Name = "BasicPay"
        Me.BasicPay.ReadOnly = True
        Me.BasicPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.BasicPay.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.BasicPay.Width = 125
        '
        'InputLabel68
        '
        Me.InputLabel68.Name = "InputLabel68"
        Me.InputLabel68.Text = "Tax Exempt"
        Me.InputLabel68.Width = 63
        '
        'Exception
        '
        Me.Exception.DecimalPlaces = 3
        Me.Exception.Format = "n"
        Me.Exception.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.Exception.Minimum = New Decimal(New Integer() {99999999, 0, 0, -2147483648})
        Me.Exception.Name = "Exception"
        Me.Exception.ReadOnly = True
        Me.Exception.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Exception.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Exception.Width = 125
        '
        'InputLabel72
        '
        Me.InputLabel72.Name = "InputLabel72"
        Me.InputLabel72.Text = "Mandatory"
        Me.InputLabel72.Width = 63
        '
        'Mandatory
        '
        Me.Mandatory.DecimalPlaces = 3
        Me.Mandatory.Format = "n"
        Me.Mandatory.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.Mandatory.Minimum = New Decimal(New Integer() {99999999, 0, 0, -2147483648})
        Me.Mandatory.Name = "Mandatory"
        Me.Mandatory.ReadOnly = True
        Me.Mandatory.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Mandatory.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Mandatory.Width = 125
        '
        'InputSeparator6
        '
        Me.InputSeparator6.Height = 1
        Me.InputSeparator6.Name = "InputSeparator6"
        Me.InputSeparator6.Width = 208
        '
        'InputLabel29
        '
        Me.InputLabel29.Name = "InputLabel29"
        Me.InputLabel29.Text = "Taxable"
        Me.InputLabel29.Width = 63
        '
        'TaxableIncome
        '
        Me.TaxableIncome.DecimalPlaces = 3
        Me.TaxableIncome.Format = "n"
        Me.TaxableIncome.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.TaxableIncome.Minimum = New Decimal(New Integer() {99999999, 0, 0, -2147483648})
        Me.TaxableIncome.Name = "TaxableIncome"
        Me.TaxableIncome.ReadOnly = True
        Me.TaxableIncome.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TaxableIncome.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.TaxableIncome.Width = 125
        '
        'InputLabel73
        '
        Me.InputLabel73.Name = "InputLabel73"
        Me.InputLabel73.Text = "W-Tax"
        Me.InputLabel73.Width = 63
        '
        'wtax
        '
        Me.wtax.DecimalPlaces = 3
        Me.wtax.Format = "n"
        Me.wtax.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.wtax.Minimum = New Decimal(New Integer() {99999999, 0, 0, -2147483648})
        Me.wtax.Name = "wtax"
        Me.wtax.ReadOnly = True
        Me.wtax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.wtax.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.wtax.Width = 125
        '
        'InputSeparator4
        '
        Me.InputSeparator4.Height = 1
        Me.InputSeparator4.Name = "InputSeparator4"
        Me.InputSeparator4.Width = 208
        '
        'InputLabel32
        '
        Me.InputLabel32.Name = "InputLabel32"
        Me.InputLabel32.Text = "Net Pay"
        Me.InputLabel32.Width = 63
        '
        'NetPay
        '
        Me.NetPay.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.NetPay.DecimalPlaces = 3
        Me.NetPay.Format = "n"
        Me.NetPay.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.NetPay.Minimum = New Decimal(New Integer() {99999999, 0, 0, -2147483648})
        Me.NetPay.Name = "NetPay"
        Me.NetPay.ReadOnly = True
        Me.NetPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NetPay.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.NetPay.Width = 125
        '
        'InputGroupHeader22
        '
        Me.InputGroupHeader22.Name = "InputGroupHeader22"
        Me.InputGroupHeader22.Text = "MANDATORY SETUP"
        '
        'deducttax
        '
        Me.deducttax.CheckState = System.Windows.Forms.CheckState.Checked
        Me.deducttax.Name = "deducttax"
        Me.deducttax.Text = "Deduct Witholding Tax"
        Me.deducttax.Width = 228
        '
        'deductsss
        '
        Me.deductsss.Break = C1.Win.C1InputPanel.BreakType.Column
        Me.deductsss.CheckState = System.Windows.Forms.CheckState.Checked
        Me.deductsss.Name = "deductsss"
        Me.deductsss.Text = "Deduct for SSS Contribution"
        Me.deductsss.Width = 228
        '
        'deducthdmf
        '
        Me.deducthdmf.CheckState = System.Windows.Forms.CheckState.Checked
        Me.deducthdmf.Name = "deducthdmf"
        Me.deducthdmf.Text = "Deduct for HDMF Contribution"
        Me.deducthdmf.Width = 250
        '
        'deductphic
        '
        Me.deductphic.Break = C1.Win.C1InputPanel.BreakType.Group
        Me.deductphic.CheckState = System.Windows.Forms.CheckState.Checked
        Me.deductphic.Name = "deductphic"
        Me.deductphic.Text = "Deduct Philhealth Contribution"
        Me.deductphic.Width = 250
        '
        'InputSeparator3
        '
        Me.InputSeparator3.Name = "InputSeparator3"
        Me.InputSeparator3.Width = 501
        '
        'ChargetoCompany
        '
        Me.ChargetoCompany.Name = "ChargetoCompany"
        Me.ChargetoCompany.Text = "Charge to Company Witholding Tax"
        '
        'C1DockingTabPage2
        '
        Me.C1DockingTabPage2.CaptionText = "Basic Info"
        Me.C1DockingTabPage2.Controls.Add(Me.ResidenceGrid)
        Me.C1DockingTabPage2.Controls.Add(Me.ToolStrip1)
        Me.C1DockingTabPage2.Controls.Add(Me.C1ToolBar1)
        Me.C1DockingTabPage2.Controls.Add(Me.C1InputPanel6)
        Me.C1DockingTabPage2.Controls.Add(Me.C1InputPanel3)
        Me.C1DockingTabPage2.Location = New System.Drawing.Point(1, 26)
        Me.C1DockingTabPage2.Name = "C1DockingTabPage2"
        Me.C1DockingTabPage2.Size = New System.Drawing.Size(1257, 471)
        Me.C1DockingTabPage2.TabIndex = 1
        Me.C1DockingTabPage2.Text = "Basic Info"
        '
        'ResidenceGrid
        '
        Me.ResidenceGrid.AllowEditing = False
        Me.ResidenceGrid.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Columns
        Me.ResidenceGrid.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.ResidenceGrid.AutoResize = True
        Me.ResidenceGrid.BackColor = System.Drawing.Color.White
        Me.ResidenceGrid.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None
        Me.ResidenceGrid.ColumnInfo = resources.GetString("ResidenceGrid.ColumnInfo")
        Me.ResidenceGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ResidenceGrid.ExtendLastCol = True
        Me.ResidenceGrid.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
        Me.ResidenceGrid.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.ResidenceGrid.ForeColor = System.Drawing.Color.Black
        Me.ResidenceGrid.IgnoreDiacritics = True
        Me.ResidenceGrid.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.None
        Me.ResidenceGrid.Location = New System.Drawing.Point(294, 33)
        Me.ResidenceGrid.Name = "ResidenceGrid"
        Me.ResidenceGrid.Rows.Count = 1
        Me.ResidenceGrid.Rows.DefaultSize = 19
        Me.ResidenceGrid.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.ResidenceGrid.ShowCursor = True
        Me.ResidenceGrid.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.None
        Me.ResidenceGrid.Size = New System.Drawing.Size(963, 413)
        Me.ResidenceGrid.StyleInfo = resources.GetString("ResidenceGrid.StyleInfo")
        Me.ResidenceGrid.TabIndex = 62
        Me.ResidenceGrid.Tree.Style = CType(((C1.Win.C1FlexGrid.TreeStyleFlags.Lines Or C1.Win.C1FlexGrid.TreeStyleFlags.Symbols) _
                    Or C1.Win.C1FlexGrid.TreeStyleFlags.Leaf), C1.Win.C1FlexGrid.TreeStyleFlags)
        Me.ResidenceGrid.UseCompatibleTextRendering = False
        Me.ResidenceGrid.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Silver
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewAddress, Me.EditAddress, Me.DeleteAddress, Me.addresstotal, Me.ToolStripSeparator1, Me.ToolStripLabel3, Me.AddressRefresh})
        Me.ToolStrip1.Location = New System.Drawing.Point(294, 446)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(963, 25)
        Me.ToolStrip1.TabIndex = 64
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'NewAddress
        '
        Me.NewAddress.Image = Global.A1plus.My.Resources.Resources.DocumentHS
        Me.NewAddress.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewAddress.Name = "NewAddress"
        Me.NewAddress.Size = New System.Drawing.Size(51, 22)
        Me.NewAddress.Text = "New"
        '
        'EditAddress
        '
        Me.EditAddress.Image = Global.A1plus.My.Resources.Resources.document_edit
        Me.EditAddress.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EditAddress.Name = "EditAddress"
        Me.EditAddress.Size = New System.Drawing.Size(47, 22)
        Me.EditAddress.Text = "Edit"
        '
        'DeleteAddress
        '
        Me.DeleteAddress.Image = Global.A1plus.My.Resources.Resources.deletered__1_
        Me.DeleteAddress.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DeleteAddress.Name = "DeleteAddress"
        Me.DeleteAddress.Size = New System.Drawing.Size(60, 22)
        Me.DeleteAddress.Text = "Delete"
        '
        'addresstotal
        '
        Me.addresstotal.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.addresstotal.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addresstotal.Name = "addresstotal"
        Me.addresstotal.Size = New System.Drawing.Size(14, 22)
        Me.addresstotal.Text = "0"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(82, 22)
        Me.ToolStripLabel3.Text = "No of Address"
        '
        'AddressRefresh
        '
        Me.AddressRefresh.Image = Global.A1plus.My.Resources.Resources.reload__1_
        Me.AddressRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AddressRefresh.Name = "AddressRefresh"
        Me.AddressRefresh.Size = New System.Drawing.Size(66, 22)
        Me.AddressRefresh.Text = "Refresh"
        '
        'C1ToolBar1
        '
        Me.C1ToolBar1.AccessibleName = "Tool Bar"
        Me.C1ToolBar1.CommandHolder = Nothing
        Me.C1ToolBar1.Location = New System.Drawing.Point(1001, 334)
        Me.C1ToolBar1.Name = "C1ToolBar1"
        Me.C1ToolBar1.Size = New System.Drawing.Size(24, 24)
        Me.C1ToolBar1.Text = "C1ToolBar1"
        '
        'C1InputPanel6
        '
        Me.C1InputPanel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel6.Items.Add(Me.InputGroupHeader7)
        Me.C1InputPanel6.Location = New System.Drawing.Point(294, 0)
        Me.C1InputPanel6.Name = "C1InputPanel6"
        Me.C1InputPanel6.Size = New System.Drawing.Size(963, 33)
        Me.C1InputPanel6.TabIndex = 60
        Me.C1InputPanel6.VisualStyle = C1.Win.C1InputPanel.VisualStyle.System
        '
        'InputGroupHeader7
        '
        Me.InputGroupHeader7.Name = "InputGroupHeader7"
        Me.InputGroupHeader7.Text = "RESIDENTIAL ADDRESS"
        '
        'C1InputPanel3
        '
        Me.C1InputPanel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.C1InputPanel3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel3.Items.Add(Me.InputGroupHeader12)
        Me.C1InputPanel3.Items.Add(Me.InputLabel35)
        Me.C1InputPanel3.Items.Add(Me.DateofBirth)
        Me.C1InputPanel3.Items.Add(Me.InputLabel37)
        Me.C1InputPanel3.Items.Add(Me.PlaceOfBirth)
        Me.C1InputPanel3.Items.Add(Me.InputLabel38)
        Me.C1InputPanel3.Items.Add(Me.CivilStatus)
        Me.C1InputPanel3.Items.Add(Me.InputLabel39)
        Me.C1InputPanel3.Items.Add(Me.Religion)
        Me.C1InputPanel3.Items.Add(Me.InputLabel40)
        Me.C1InputPanel3.Items.Add(Me.Height)
        Me.C1InputPanel3.Items.Add(Me.InputLabel41)
        Me.C1InputPanel3.Items.Add(Me.Weight)
        Me.C1InputPanel3.Items.Add(Me.InputLabel46)
        Me.C1InputPanel3.Items.Add(Me.BloodType)
        Me.C1InputPanel3.Items.Add(Me.InputLabel47)
        Me.C1InputPanel3.Items.Add(Me.BodyBuild)
        Me.C1InputPanel3.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel3.Name = "C1InputPanel3"
        Me.C1InputPanel3.Size = New System.Drawing.Size(294, 471)
        Me.C1InputPanel3.TabIndex = 66
        Me.C1InputPanel3.VisualStyle = C1.Win.C1InputPanel.VisualStyle.System
        '
        'InputGroupHeader12
        '
        Me.InputGroupHeader12.Name = "InputGroupHeader12"
        Me.InputGroupHeader12.Text = "PERSONAL INFORMATION"
        '
        'InputLabel35
        '
        Me.InputLabel35.Name = "InputLabel35"
        Me.InputLabel35.Text = "Date of Birth"
        Me.InputLabel35.Width = 78
        '
        'DateofBirth
        '
        Me.DateofBirth.Name = "DateofBirth"
        Me.DateofBirth.Width = 180
        '
        'InputLabel37
        '
        Me.InputLabel37.Name = "InputLabel37"
        Me.InputLabel37.Text = "Place of Birth"
        Me.InputLabel37.Width = 78
        '
        'PlaceOfBirth
        '
        Me.PlaceOfBirth.Name = "PlaceOfBirth"
        Me.PlaceOfBirth.Width = 180
        '
        'InputLabel38
        '
        Me.InputLabel38.Name = "InputLabel38"
        Me.InputLabel38.Text = "Civil Status:"
        Me.InputLabel38.Width = 78
        '
        'CivilStatus
        '
        Me.CivilStatus.AutoCompleteMode = C1.Win.C1InputPanel.InputAutoCompleteMode.Suggest
        Me.CivilStatus.Items.Add(Me.InputOption15)
        Me.CivilStatus.Items.Add(Me.InputOption16)
        Me.CivilStatus.Items.Add(Me.InputOption17)
        Me.CivilStatus.Items.Add(Me.InputOption18)
        Me.CivilStatus.Name = "CivilStatus"
        Me.CivilStatus.Width = 180
        '
        'InputOption15
        '
        Me.InputOption15.Name = "InputOption15"
        Me.InputOption15.Text = "Single"
        '
        'InputOption16
        '
        Me.InputOption16.Name = "InputOption16"
        Me.InputOption16.Text = "Married"
        '
        'InputOption17
        '
        Me.InputOption17.Name = "InputOption17"
        Me.InputOption17.Text = "Legally Separated"
        '
        'InputOption18
        '
        Me.InputOption18.Name = "InputOption18"
        Me.InputOption18.Text = "Widowed"
        '
        'InputLabel39
        '
        Me.InputLabel39.Name = "InputLabel39"
        Me.InputLabel39.Text = "Religion"
        Me.InputLabel39.Width = 78
        '
        'Religion
        '
        Me.Religion.Name = "Religion"
        Me.Religion.Width = 180
        '
        'InputLabel40
        '
        Me.InputLabel40.Name = "InputLabel40"
        Me.InputLabel40.Text = "Height(cm)"
        Me.InputLabel40.Width = 78
        '
        'Height
        '
        Me.Height.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.Height.Name = "Height"
        Me.Height.Width = 180
        '
        'InputLabel41
        '
        Me.InputLabel41.Name = "InputLabel41"
        Me.InputLabel41.Text = "Weight(kg)"
        Me.InputLabel41.Width = 78
        '
        'Weight
        '
        Me.Weight.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.Weight.Name = "Weight"
        Me.Weight.Width = 180
        '
        'InputLabel46
        '
        Me.InputLabel46.Name = "InputLabel46"
        Me.InputLabel46.Text = "Blood Type"
        Me.InputLabel46.Width = 79
        '
        'BloodType
        '
        Me.BloodType.Name = "BloodType"
        Me.BloodType.Width = 180
        '
        'InputLabel47
        '
        Me.InputLabel47.Name = "InputLabel47"
        Me.InputLabel47.Text = "Body Build"
        Me.InputLabel47.Width = 79
        '
        'BodyBuild
        '
        Me.BodyBuild.Name = "BodyBuild"
        Me.BodyBuild.Width = 180
        '
        'C1DockingTabPage1
        '
        Me.C1DockingTabPage1.Controls.Add(Me.RequirementGrid)
        Me.C1DockingTabPage1.Controls.Add(Me.C1InputPanel17)
        Me.C1DockingTabPage1.Controls.Add(Me.C1InputPanel5)
        Me.C1DockingTabPage1.Controls.Add(Me.C1InputPanel2)
        Me.C1DockingTabPage1.Location = New System.Drawing.Point(1, 26)
        Me.C1DockingTabPage1.Name = "C1DockingTabPage1"
        Me.C1DockingTabPage1.Size = New System.Drawing.Size(1257, 471)
        Me.C1DockingTabPage1.TabIndex = 0
        Me.C1DockingTabPage1.Text = "Employment Info"
        '
        'RequirementGrid
        '
        Me.RequirementGrid.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Columns
        Me.RequirementGrid.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.RequirementGrid.AutoResize = True
        Me.RequirementGrid.BackColor = System.Drawing.Color.White
        Me.RequirementGrid.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None
        Me.RequirementGrid.ColumnInfo = resources.GetString("RequirementGrid.ColumnInfo")
        Me.RequirementGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RequirementGrid.ExtendLastCol = True
        Me.RequirementGrid.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
        Me.RequirementGrid.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.RequirementGrid.ForeColor = System.Drawing.Color.Black
        Me.RequirementGrid.IgnoreDiacritics = True
        Me.RequirementGrid.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.None
        Me.RequirementGrid.Location = New System.Drawing.Point(664, 26)
        Me.RequirementGrid.Name = "RequirementGrid"
        Me.RequirementGrid.Rows.Count = 1
        Me.RequirementGrid.Rows.DefaultSize = 19
        Me.RequirementGrid.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.RequirementGrid.ShowCursor = True
        Me.RequirementGrid.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.None
        Me.RequirementGrid.Size = New System.Drawing.Size(593, 445)
        Me.RequirementGrid.StyleInfo = resources.GetString("RequirementGrid.StyleInfo")
        Me.RequirementGrid.TabIndex = 63
        Me.RequirementGrid.Tree.Style = CType(((C1.Win.C1FlexGrid.TreeStyleFlags.Lines Or C1.Win.C1FlexGrid.TreeStyleFlags.Symbols) _
                    Or C1.Win.C1FlexGrid.TreeStyleFlags.Leaf), C1.Win.C1FlexGrid.TreeStyleFlags)
        Me.RequirementGrid.UseCompatibleTextRendering = False
        Me.RequirementGrid.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.System
        '
        'C1InputPanel17
        '
        Me.C1InputPanel17.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel17.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel17.Items.Add(Me.InputGroupHeader24)
        Me.C1InputPanel17.Location = New System.Drawing.Point(664, 0)
        Me.C1InputPanel17.Name = "C1InputPanel17"
        Me.C1InputPanel17.Size = New System.Drawing.Size(593, 26)
        Me.C1InputPanel17.TabIndex = 64
        Me.C1InputPanel17.VisualStyle = C1.Win.C1InputPanel.VisualStyle.System
        '
        'InputGroupHeader24
        '
        Me.InputGroupHeader24.Name = "InputGroupHeader24"
        Me.InputGroupHeader24.Text = "SUBMITTED PRE-EMPLOYMENT REQUIREMENTS"
        '
        'C1InputPanel5
        '
        Me.C1InputPanel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.C1InputPanel5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel5.Items.Add(Me.InputGroupHeader9)
        Me.C1InputPanel5.Items.Add(Me.InputLabel64)
        Me.C1InputPanel5.Items.Add(Me.DateHired)
        Me.C1InputPanel5.Items.Add(Me.InputLabel65)
        Me.C1InputPanel5.Items.Add(Me.DateRegular)
        Me.C1InputPanel5.Items.Add(Me.InputLabel18)
        Me.C1InputPanel5.Items.Add(Me.DateSeparated)
        Me.C1InputPanel5.Items.Add(Me.InputLabel19)
        Me.C1InputPanel5.Items.Add(Me.DateResigned)
        Me.C1InputPanel5.Items.Add(Me.Rehirable)
        Me.C1InputPanel5.Items.Add(Me.InputGroupHeader4)
        Me.C1InputPanel5.Items.Add(Me.InputLabel20)
        Me.C1InputPanel5.Items.Add(Me.ContractStartDate)
        Me.C1InputPanel5.Items.Add(Me.InputLabel21)
        Me.C1InputPanel5.Items.Add(Me.ContractEndDate)
        Me.C1InputPanel5.Items.Add(Me.InputGroupHeader10)
        Me.C1InputPanel5.Items.Add(Me.InputLabel22)
        Me.C1InputPanel5.Items.Add(Me.ClearanceStatus)
        Me.C1InputPanel5.Items.Add(Me.InputLabel23)
        Me.C1InputPanel5.Items.Add(Me.DateCleared)
        Me.C1InputPanel5.Items.Add(Me.InputLabel24)
        Me.C1InputPanel5.Items.Add(Me.IssuedBy)
        Me.C1InputPanel5.Items.Add(Me.InputLabel53)
        Me.C1InputPanel5.Items.Add(Me.Remarks)
        Me.C1InputPanel5.Location = New System.Drawing.Point(342, 0)
        Me.C1InputPanel5.Name = "C1InputPanel5"
        Me.C1InputPanel5.Size = New System.Drawing.Size(322, 471)
        Me.C1InputPanel5.TabIndex = 7
        Me.C1InputPanel5.VisualStyle = C1.Win.C1InputPanel.VisualStyle.System
        '
        'InputGroupHeader9
        '
        Me.InputGroupHeader9.Name = "InputGroupHeader9"
        Me.InputGroupHeader9.Text = "EMPLOYMENT DETAILS"
        '
        'InputLabel64
        '
        Me.InputLabel64.Name = "InputLabel64"
        Me.InputLabel64.Text = "Date Hired"
        Me.InputLabel64.Width = 100
        '
        'DateHired
        '
        Me.DateHired.Name = "DateHired"
        Me.DateHired.Width = 178
        '
        'InputLabel65
        '
        Me.InputLabel65.Name = "InputLabel65"
        Me.InputLabel65.Text = "Date Regular"
        Me.InputLabel65.Width = 100
        '
        'DateRegular
        '
        Me.DateRegular.Name = "DateRegular"
        Me.DateRegular.Width = 178
        '
        'InputLabel18
        '
        Me.InputLabel18.Name = "InputLabel18"
        Me.InputLabel18.Text = "Date Separated"
        Me.InputLabel18.Width = 100
        '
        'DateSeparated
        '
        Me.DateSeparated.Name = "DateSeparated"
        Me.DateSeparated.Width = 178
        '
        'InputLabel19
        '
        Me.InputLabel19.Height = 43
        Me.InputLabel19.Name = "InputLabel19"
        Me.InputLabel19.Text = "Date Filed of Resignation"
        Me.InputLabel19.Width = 100
        '
        'DateResigned
        '
        Me.DateResigned.Name = "DateResigned"
        Me.DateResigned.Width = 178
        '
        'Rehirable
        '
        Me.Rehirable.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Rehirable.Name = "Rehirable"
        Me.Rehirable.Text = "Rehirable"
        '
        'InputGroupHeader4
        '
        Me.InputGroupHeader4.Name = "InputGroupHeader4"
        Me.InputGroupHeader4.Text = "Contract Terms"
        '
        'InputLabel20
        '
        Me.InputLabel20.Name = "InputLabel20"
        Me.InputLabel20.Text = "Contract Starts"
        Me.InputLabel20.Width = 100
        '
        'ContractStartDate
        '
        Me.ContractStartDate.Name = "ContractStartDate"
        Me.ContractStartDate.Width = 178
        '
        'InputLabel21
        '
        Me.InputLabel21.Name = "InputLabel21"
        Me.InputLabel21.Text = "Contract Ends"
        Me.InputLabel21.Width = 100
        '
        'ContractEndDate
        '
        Me.ContractEndDate.Name = "ContractEndDate"
        Me.ContractEndDate.Width = 178
        '
        'InputGroupHeader10
        '
        Me.InputGroupHeader10.Name = "InputGroupHeader10"
        Me.InputGroupHeader10.Text = "Clearance"
        '
        'InputLabel22
        '
        Me.InputLabel22.Name = "InputLabel22"
        Me.InputLabel22.Text = "Status"
        Me.InputLabel22.Width = 100
        '
        'ClearanceStatus
        '
        Me.ClearanceStatus.Items.Add(Me.InputOption1)
        Me.ClearanceStatus.Items.Add(Me.InputOption2)
        Me.ClearanceStatus.Items.Add(Me.InputOption4)
        Me.ClearanceStatus.Name = "ClearanceStatus"
        Me.ClearanceStatus.Width = 178
        '
        'InputOption1
        '
        Me.InputOption1.Name = "InputOption1"
        Me.InputOption1.Text = "In Process"
        '
        'InputOption2
        '
        Me.InputOption2.Name = "InputOption2"
        Me.InputOption2.Text = "Pending"
        '
        'InputOption4
        '
        Me.InputOption4.Name = "InputOption4"
        Me.InputOption4.Text = "Cleared"
        '
        'InputLabel23
        '
        Me.InputLabel23.Name = "InputLabel23"
        Me.InputLabel23.Text = "Date Cleared"
        Me.InputLabel23.Width = 100
        '
        'DateCleared
        '
        Me.DateCleared.Name = "DateCleared"
        Me.DateCleared.Width = 178
        '
        'InputLabel24
        '
        Me.InputLabel24.Name = "InputLabel24"
        Me.InputLabel24.Text = "Issued By"
        Me.InputLabel24.Width = 100
        '
        'IssuedBy
        '
        Me.IssuedBy.Name = "IssuedBy"
        Me.IssuedBy.Width = 178
        '
        'InputLabel53
        '
        Me.InputLabel53.Name = "InputLabel53"
        Me.InputLabel53.Text = "Remarks"
        Me.InputLabel53.Width = 100
        '
        'Remarks
        '
        Me.Remarks.Name = "Remarks"
        Me.Remarks.Width = 178
        '
        'C1InputPanel2
        '
        Me.C1InputPanel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.C1InputPanel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel2.Items.Add(Me.InputGroupHeader3)
        Me.C1InputPanel2.Items.Add(Me.InputLabel16)
        Me.C1InputPanel2.Items.Add(Me.CompanyName)
        Me.C1InputPanel2.Items.Add(Me.InputLabel26)
        Me.C1InputPanel2.Items.Add(Me.Department)
        Me.C1InputPanel2.Items.Add(Me.InputLabel49)
        Me.C1InputPanel2.Items.Add(Me.Position)
        Me.C1InputPanel2.Items.Add(Me.InputLabel25)
        Me.C1InputPanel2.Items.Add(Me.ImmediateSuperior)
        Me.C1InputPanel2.Items.Add(Me.InputLabel36)
        Me.C1InputPanel2.Items.Add(Me.EmploymentLevel)
        Me.C1InputPanel2.Items.Add(Me.InputLabel14)
        Me.C1InputPanel2.Items.Add(Me.EmployeeType)
        Me.C1InputPanel2.Items.Add(Me.InputLabel8)
        Me.C1InputPanel2.Items.Add(Me.Team)
        Me.C1InputPanel2.Items.Add(Me.InputLabel15)
        Me.C1InputPanel2.Items.Add(Me.Location)
        Me.C1InputPanel2.Items.Add(Me.InputLabel75)
        Me.C1InputPanel2.Items.Add(Me.EmploymentStatus)
        Me.C1InputPanel2.Items.Add(Me.InputGroupHeader11)
        Me.C1InputPanel2.Items.Add(Me.InputLabel7)
        Me.C1InputPanel2.Items.Add(Me.TimeSheetApproval)
        Me.C1InputPanel2.Items.Add(Me.InputLabel50)
        Me.C1InputPanel2.Items.Add(Me.OvertimeApproval)
        Me.C1InputPanel2.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel2.Name = "C1InputPanel2"
        Me.C1InputPanel2.Size = New System.Drawing.Size(342, 471)
        Me.C1InputPanel2.TabIndex = 6
        Me.C1InputPanel2.VisualStyle = C1.Win.C1InputPanel.VisualStyle.System
        '
        'InputGroupHeader3
        '
        Me.InputGroupHeader3.Name = "InputGroupHeader3"
        Me.InputGroupHeader3.Text = "EMPLOYMENT INFORMATION"
        '
        'InputLabel16
        '
        Me.InputLabel16.Name = "InputLabel16"
        Me.InputLabel16.Text = "Company:"
        Me.InputLabel16.Width = 122
        '
        'CompanyName
        '
        Me.CompanyName.Name = "CompanyName"
        Me.CompanyName.Width = 180
        '
        'InputLabel26
        '
        Me.InputLabel26.Name = "InputLabel26"
        Me.InputLabel26.Text = "Department"
        Me.InputLabel26.Width = 122
        '
        'Department
        '
        Me.Department.Name = "Department"
        Me.Department.Width = 180
        '
        'InputLabel49
        '
        Me.InputLabel49.Name = "InputLabel49"
        Me.InputLabel49.Text = "Position"
        Me.InputLabel49.Width = 122
        '
        'Position
        '
        Me.Position.Name = "Position"
        Me.Position.Width = 180
        '
        'InputLabel25
        '
        Me.InputLabel25.Name = "InputLabel25"
        Me.InputLabel25.Text = "Immediate Superior"
        Me.InputLabel25.Width = 122
        '
        'ImmediateSuperior
        '
        Me.ImmediateSuperior.Name = "ImmediateSuperior"
        Me.ImmediateSuperior.Width = 180
        '
        'InputLabel36
        '
        Me.InputLabel36.Name = "InputLabel36"
        Me.InputLabel36.Text = "Employment Level"
        Me.InputLabel36.Width = 122
        '
        'EmploymentLevel
        '
        Me.EmploymentLevel.Name = "EmploymentLevel"
        Me.EmploymentLevel.Width = 180
        '
        'InputLabel14
        '
        Me.InputLabel14.Name = "InputLabel14"
        Me.InputLabel14.Text = "Employee Type:"
        Me.InputLabel14.Width = 122
        '
        'EmployeeType
        '
        Me.EmployeeType.Items.Add(Me.InputOption10)
        Me.EmployeeType.Items.Add(Me.InputOption11)
        Me.EmployeeType.Items.Add(Me.InputOption12)
        Me.EmployeeType.Items.Add(Me.InputOption13)
        Me.EmployeeType.Items.Add(Me.InputOption14)
        Me.EmployeeType.Name = "EmployeeType"
        Me.EmployeeType.Width = 180
        '
        'InputOption10
        '
        Me.InputOption10.Name = "InputOption10"
        Me.InputOption10.Text = "Trainee"
        '
        'InputOption11
        '
        Me.InputOption11.Name = "InputOption11"
        Me.InputOption11.Text = "Contractual"
        '
        'InputOption12
        '
        Me.InputOption12.Name = "InputOption12"
        Me.InputOption12.Text = "Probationary"
        '
        'InputOption13
        '
        Me.InputOption13.Name = "InputOption13"
        Me.InputOption13.Text = "Regular"
        '
        'InputOption14
        '
        Me.InputOption14.Name = "InputOption14"
        Me.InputOption14.Text = "Resigned"
        '
        'InputLabel8
        '
        Me.InputLabel8.Name = "InputLabel8"
        Me.InputLabel8.Text = "Group:"
        Me.InputLabel8.Width = 122
        '
        'Team
        '
        Me.Team.Name = "Team"
        Me.Team.Width = 180
        '
        'InputLabel15
        '
        Me.InputLabel15.Name = "InputLabel15"
        Me.InputLabel15.Text = "Location:"
        Me.InputLabel15.Width = 122
        '
        'Location
        '
        Me.Location.Name = "Location"
        Me.Location.Width = 180
        '
        'InputLabel75
        '
        Me.InputLabel75.Name = "InputLabel75"
        Me.InputLabel75.Text = "Status:"
        Me.InputLabel75.Width = 122
        '
        'EmploymentStatus
        '
        Me.EmploymentStatus.Name = "EmploymentStatus"
        Me.EmploymentStatus.Width = 180
        '
        'InputGroupHeader11
        '
        Me.InputGroupHeader11.Name = "InputGroupHeader11"
        Me.InputGroupHeader11.Text = "Attendance Approval"
        '
        'InputLabel7
        '
        Me.InputLabel7.Name = "InputLabel7"
        Me.InputLabel7.Text = "Time Sheet Approval"
        Me.InputLabel7.Width = 122
        '
        'TimeSheetApproval
        '
        Me.TimeSheetApproval.Name = "TimeSheetApproval"
        Me.TimeSheetApproval.Width = 180
        '
        'InputLabel50
        '
        Me.InputLabel50.Name = "InputLabel50"
        Me.InputLabel50.Text = "Overtime Approval"
        Me.InputLabel50.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        Me.InputLabel50.Width = 122
        '
        'OvertimeApproval
        '
        Me.OvertimeApproval.Name = "OvertimeApproval"
        Me.OvertimeApproval.Visibility = C1.Win.C1InputPanel.Visibility.Hidden
        Me.OvertimeApproval.Width = 180
        '
        'C1DockingTab1
        '
        Me.C1DockingTab1.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.C1DockingTab1.Controls.Add(Me.C1DockingTabPage1)
        Me.C1DockingTab1.Controls.Add(Me.C1DockingTabPage2)
        Me.C1DockingTab1.Controls.Add(Me.C1DockingTabPage4)
        Me.C1DockingTab1.Controls.Add(Me.C1DockingTabPage5)
        Me.C1DockingTab1.Controls.Add(Me.C1DockingTabPage6)
        Me.C1DockingTab1.Controls.Add(Me.C1DockingTabPage12)
        Me.C1DockingTab1.Controls.Add(Me.C1DockingTabPage3)
        Me.C1DockingTab1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1DockingTab1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1DockingTab1.Location = New System.Drawing.Point(0, 285)
        Me.C1DockingTab1.Name = "C1DockingTab1"
        Me.C1DockingTab1.SelectedIndex = 11
        Me.C1DockingTab1.Size = New System.Drawing.Size(1259, 498)
        Me.C1DockingTab1.TabIndex = 0
        Me.C1DockingTab1.TabLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1DockingTab1.TabsSpacing = 5
        Me.C1DockingTab1.TabStyle = C1.Win.C1Command.TabStyleEnum.Sloping
        '
        'C1DockingTabPage4
        '
        Me.C1DockingTabPage4.Controls.Add(Me.DependentsGrid)
        Me.C1DockingTabPage4.Controls.Add(Me.ToolStrip2)
        Me.C1DockingTabPage4.Controls.Add(Me.C1InputPanel11)
        Me.C1DockingTabPage4.Location = New System.Drawing.Point(1, 26)
        Me.C1DockingTabPage4.Name = "C1DockingTabPage4"
        Me.C1DockingTabPage4.Size = New System.Drawing.Size(1257, 471)
        Me.C1DockingTabPage4.TabIndex = 11
        Me.C1DockingTabPage4.Text = "Dependents"
        '
        'DependentsGrid
        '
        Me.DependentsGrid.AllowEditing = False
        Me.DependentsGrid.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Columns
        Me.DependentsGrid.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.DependentsGrid.AutoResize = True
        Me.DependentsGrid.BackColor = System.Drawing.Color.White
        Me.DependentsGrid.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None
        Me.DependentsGrid.ColumnInfo = resources.GetString("DependentsGrid.ColumnInfo")
        Me.DependentsGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DependentsGrid.ExtendLastCol = True
        Me.DependentsGrid.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
        Me.DependentsGrid.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.DependentsGrid.ForeColor = System.Drawing.Color.Black
        Me.DependentsGrid.IgnoreDiacritics = True
        Me.DependentsGrid.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.None
        Me.DependentsGrid.Location = New System.Drawing.Point(0, 34)
        Me.DependentsGrid.Name = "DependentsGrid"
        Me.DependentsGrid.Rows.Count = 1
        Me.DependentsGrid.Rows.DefaultSize = 19
        Me.DependentsGrid.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.DependentsGrid.ShowCursor = True
        Me.DependentsGrid.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.None
        Me.DependentsGrid.Size = New System.Drawing.Size(1257, 412)
        Me.DependentsGrid.StyleInfo = resources.GetString("DependentsGrid.StyleInfo")
        Me.DependentsGrid.TabIndex = 59
        Me.DependentsGrid.Tree.Style = CType(((C1.Win.C1FlexGrid.TreeStyleFlags.Lines Or C1.Win.C1FlexGrid.TreeStyleFlags.Symbols) _
                    Or C1.Win.C1FlexGrid.TreeStyleFlags.Leaf), C1.Win.C1FlexGrid.TreeStyleFlags)
        Me.DependentsGrid.UseCompatibleTextRendering = False
        Me.DependentsGrid.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Silver
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewDependent, Me.EditDependent, Me.DeleteDependent, Me.dependentstotal, Me.ToolStripSeparator2, Me.ToolStripLabel4, Me.DependenceRefresh})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 446)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(1257, 25)
        Me.ToolStrip2.TabIndex = 65
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'NewDependent
        '
        Me.NewDependent.Image = Global.A1plus.My.Resources.Resources.DocumentHS
        Me.NewDependent.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewDependent.Name = "NewDependent"
        Me.NewDependent.Size = New System.Drawing.Size(51, 22)
        Me.NewDependent.Text = "New"
        '
        'EditDependent
        '
        Me.EditDependent.Image = Global.A1plus.My.Resources.Resources.document_edit
        Me.EditDependent.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EditDependent.Name = "EditDependent"
        Me.EditDependent.Size = New System.Drawing.Size(47, 22)
        Me.EditDependent.Text = "Edit"
        '
        'DeleteDependent
        '
        Me.DeleteDependent.Image = Global.A1plus.My.Resources.Resources.deletered__1_
        Me.DeleteDependent.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DeleteDependent.Name = "DeleteDependent"
        Me.DeleteDependent.Size = New System.Drawing.Size(60, 22)
        Me.DeleteDependent.Text = "Delete"
        '
        'dependentstotal
        '
        Me.dependentstotal.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.dependentstotal.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dependentstotal.Name = "dependentstotal"
        Me.dependentstotal.Size = New System.Drawing.Size(14, 22)
        Me.dependentstotal.Text = "0"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(103, 22)
        Me.ToolStripLabel4.Text = "No of Dependents"
        '
        'DependenceRefresh
        '
        Me.DependenceRefresh.Image = Global.A1plus.My.Resources.Resources.reload__1_
        Me.DependenceRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DependenceRefresh.Name = "DependenceRefresh"
        Me.DependenceRefresh.Size = New System.Drawing.Size(66, 22)
        Me.DependenceRefresh.Text = "Refresh"
        '
        'C1InputPanel11
        '
        Me.C1InputPanel11.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel11.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel11.Items.Add(Me.InputGroupHeader16)
        Me.C1InputPanel11.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel11.Name = "C1InputPanel11"
        Me.C1InputPanel11.Size = New System.Drawing.Size(1257, 34)
        Me.C1InputPanel11.TabIndex = 63
        Me.C1InputPanel11.VisualStyle = C1.Win.C1InputPanel.VisualStyle.System
        '
        'InputGroupHeader16
        '
        Me.InputGroupHeader16.Name = "InputGroupHeader16"
        Me.InputGroupHeader16.Text = "LIST OF QUALIFIED DEPENDENTS"
        '
        'C1DockingTabPage12
        '
        Me.C1DockingTabPage12.Controls.Add(Me.ToolStrip6)
        Me.C1DockingTabPage12.Controls.Add(Me.MemoGrid)
        Me.C1DockingTabPage12.Controls.Add(Me.C1InputPanel20)
        Me.C1DockingTabPage12.Location = New System.Drawing.Point(1, 26)
        Me.C1DockingTabPage12.Name = "C1DockingTabPage12"
        Me.C1DockingTabPage12.Size = New System.Drawing.Size(1257, 471)
        Me.C1DockingTabPage12.TabIndex = 12
        Me.C1DockingTabPage12.Text = "Memo"
        '
        'ToolStrip6
        '
        Me.ToolStrip6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip6.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.memototal, Me.ToolStripSeparator6, Me.ToolStripLabel12})
        Me.ToolStrip6.Location = New System.Drawing.Point(0, 446)
        Me.ToolStrip6.Name = "ToolStrip6"
        Me.ToolStrip6.Size = New System.Drawing.Size(1257, 25)
        Me.ToolStrip6.TabIndex = 66
        Me.ToolStrip6.Text = "ToolStrip6"
        '
        'memototal
        '
        Me.memototal.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.memototal.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.memototal.Name = "memototal"
        Me.memototal.Size = New System.Drawing.Size(14, 22)
        Me.memototal.Text = "0"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel12
        '
        Me.ToolStripLabel12.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel12.Name = "ToolStripLabel12"
        Me.ToolStripLabel12.Size = New System.Drawing.Size(114, 22)
        Me.ToolStripLabel12.Text = "No of Memo Issued:"
        '
        'MemoGrid
        '
        Me.MemoGrid.AllowEditing = False
        Me.MemoGrid.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Columns
        Me.MemoGrid.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.MemoGrid.AutoResize = True
        Me.MemoGrid.BackColor = System.Drawing.Color.White
        Me.MemoGrid.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None
        Me.MemoGrid.ColumnInfo = resources.GetString("MemoGrid.ColumnInfo")
        Me.MemoGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MemoGrid.ExtendLastCol = True
        Me.MemoGrid.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
        Me.MemoGrid.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.MemoGrid.ForeColor = System.Drawing.Color.Black
        Me.MemoGrid.IgnoreDiacritics = True
        Me.MemoGrid.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.None
        Me.MemoGrid.Location = New System.Drawing.Point(0, 33)
        Me.MemoGrid.Name = "MemoGrid"
        Me.MemoGrid.Rows.Count = 1
        Me.MemoGrid.Rows.DefaultSize = 19
        Me.MemoGrid.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.MemoGrid.ShowCursor = True
        Me.MemoGrid.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.None
        Me.MemoGrid.Size = New System.Drawing.Size(1257, 438)
        Me.MemoGrid.StyleInfo = resources.GetString("MemoGrid.StyleInfo")
        Me.MemoGrid.TabIndex = 62
        Me.MemoGrid.Tree.Style = CType(((C1.Win.C1FlexGrid.TreeStyleFlags.Lines Or C1.Win.C1FlexGrid.TreeStyleFlags.Symbols) _
                    Or C1.Win.C1FlexGrid.TreeStyleFlags.Leaf), C1.Win.C1FlexGrid.TreeStyleFlags)
        Me.MemoGrid.UseCompatibleTextRendering = False
        Me.MemoGrid.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Silver
        '
        'C1InputPanel20
        '
        Me.C1InputPanel20.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1InputPanel20.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel20.Items.Add(Me.InputGroupHeader6)
        Me.C1InputPanel20.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel20.Name = "C1InputPanel20"
        Me.C1InputPanel20.Size = New System.Drawing.Size(1257, 33)
        Me.C1InputPanel20.TabIndex = 64
        Me.C1InputPanel20.VisualStyle = C1.Win.C1InputPanel.VisualStyle.System
        '
        'InputGroupHeader6
        '
        Me.InputGroupHeader6.Name = "InputGroupHeader6"
        Me.InputGroupHeader6.Text = "EMPLOYEE RELATIONS - ISSUED MEMORANDUM / VIOLATIONS"
        '
        'InputComboBox5
        '
        Me.InputComboBox5.Name = "InputComboBox5"
        '
        'InputComboBox6
        '
        Me.InputComboBox6.Name = "InputComboBox6"
        '
        'InputComboBox7
        '
        Me.InputComboBox7.Name = "InputComboBox7"
        '
        'C1Ribbon1
        '
        Me.C1Ribbon1.ApplicationMenuHolder = Me.RibbonApplicationMenu1
        Me.C1Ribbon1.ConfigToolBarHolder = Me.RibbonConfigToolBar1
        Me.C1Ribbon1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1Ribbon1.Location = New System.Drawing.Point(0, 0)
        Me.C1Ribbon1.Name = "C1Ribbon1"
        Me.C1Ribbon1.QatHolder = Me.RibbonQat1
        Me.C1Ribbon1.Size = New System.Drawing.Size(1259, 129)
        Me.C1Ribbon1.Tabs.Add(Me.ModuleControlTab)
        Me.C1Ribbon1.VisualStyle = C1.Win.C1Ribbon.VisualStyle.Office2010Silver
        '
        'RibbonApplicationMenu1
        '
        Me.RibbonApplicationMenu1.ColoredButton = C1.Win.C1Ribbon.ColoredButton.Green
        Me.RibbonApplicationMenu1.Name = "RibbonApplicationMenu1"
        Me.RibbonApplicationMenu1.Text = "Module"
        Me.RibbonApplicationMenu1.Visible = False
        '
        'RibbonConfigToolBar1
        '
        Me.RibbonConfigToolBar1.Name = "RibbonConfigToolBar1"
        '
        'RibbonQat1
        '
        Me.RibbonQat1.MenuVisible = False
        Me.RibbonQat1.Name = "RibbonQat1"
        Me.RibbonQat1.Visible = False
        '
        'ModuleControlTab
        '
        Me.ModuleControlTab.Groups.Add(Me.RibbonGroup1)
        Me.ModuleControlTab.Groups.Add(Me.RibbonGroup2)
        Me.ModuleControlTab.Groups.Add(Me.RibbonGroup3)
        Me.ModuleControlTab.Name = "ModuleControlTab"
        Me.ModuleControlTab.Text = "Module Controls"
        '
        'RibbonGroup1
        '
        Me.RibbonGroup1.Items.Add(Me.SaveJobOrder)
        Me.RibbonGroup1.Items.Add(Me.NewOrder)
        Me.RibbonGroup1.Items.Add(Me.PrintCreditMemo)
        Me.RibbonGroup1.Items.Add(Me.CloseForm)
        Me.RibbonGroup1.Items.Add(Me.CancelSOButton)
        Me.RibbonGroup1.Name = "RibbonGroup1"
        Me.RibbonGroup1.Text = "Data Manipulations"
        '
        'SaveJobOrder
        '
        Me.SaveJobOrder.CanBeAddedToQat = False
        Me.SaveJobOrder.LargeImage = CType(resources.GetObject("SaveJobOrder.LargeImage"), System.Drawing.Image)
        Me.SaveJobOrder.Name = "SaveJobOrder"
        Me.SaveJobOrder.SmallImage = Global.A1plus.My.Resources.Resources.SaveAllHS
        Me.SaveJobOrder.Text = "Save Record"
        '
        'NewOrder
        '
        Me.NewOrder.CanBeAddedToQat = False
        Me.NewOrder.LargeImage = CType(resources.GetObject("NewOrder.LargeImage"), System.Drawing.Image)
        Me.NewOrder.Name = "NewOrder"
        Me.NewOrder.SmallImage = Global.A1plus.My.Resources.Resources.new_window__1_
        Me.NewOrder.SupportedGroupSizing = C1.Win.C1Ribbon.SupportedGroupSizing.LargeImageOnly
        Me.NewOrder.Text = "New Employee"
        '
        'PrintCreditMemo
        '
        Me.PrintCreditMemo.CanBeAddedToQat = False
        Me.PrintCreditMemo.LargeImage = CType(resources.GetObject("PrintCreditMemo.LargeImage"), System.Drawing.Image)
        Me.PrintCreditMemo.Name = "PrintCreditMemo"
        Me.PrintCreditMemo.SmallImage = CType(resources.GetObject("PrintCreditMemo.SmallImage"), System.Drawing.Image)
        Me.PrintCreditMemo.SupportedGroupSizing = C1.Win.C1Ribbon.SupportedGroupSizing.LargeImageOnly
        Me.PrintCreditMemo.Text = "Print 201 File"
        '
        'CloseForm
        '
        Me.CloseForm.CanBeAddedToQat = False
        Me.CloseForm.LargeImage = Global.A1plus.My.Resources.Resources.exit1
        Me.CloseForm.Name = "CloseForm"
        Me.CloseForm.SmallImage = CType(resources.GetObject("CloseForm.SmallImage"), System.Drawing.Image)
        Me.CloseForm.Text = "Close Form"
        '
        'CancelSOButton
        '
        Me.CancelSOButton.CanBeAddedToQat = False
        Me.CancelSOButton.LargeImage = Global.A1plus.My.Resources.Resources.deletered
        Me.CancelSOButton.Name = "CancelSOButton"
        Me.CancelSOButton.SmallImage = CType(resources.GetObject("CancelSOButton.SmallImage"), System.Drawing.Image)
        Me.CancelSOButton.Text = "Cancel/ Close Sales Order"
        Me.CancelSOButton.Visible = False
        '
        'RibbonGroup2
        '
        Me.RibbonGroup2.Items.Add(Me.updateaddress)
        Me.RibbonGroup2.Items.Add(Me.updatedependent)
        Me.RibbonGroup2.Items.Add(Me.updatetraining)
        Me.RibbonGroup2.Items.Add(Me.updateeducation)
        Me.RibbonGroup2.Items.Add(Me.updateemployment)
        Me.RibbonGroup2.Items.Add(Me.updatememo)
        Me.RibbonGroup2.Name = "RibbonGroup2"
        Me.RibbonGroup2.Text = "Employee Information Update"
        '
        'updateaddress
        '
        Me.updateaddress.Name = "updateaddress"
        Me.updateaddress.SmallImage = CType(resources.GetObject("updateaddress.SmallImage"), System.Drawing.Image)
        Me.updateaddress.Text = "Add Address"
        '
        'updatedependent
        '
        Me.updatedependent.Name = "updatedependent"
        Me.updatedependent.SmallImage = CType(resources.GetObject("updatedependent.SmallImage"), System.Drawing.Image)
        Me.updatedependent.Text = "Add New Dependents"
        '
        'updatetraining
        '
        Me.updatetraining.Name = "updatetraining"
        Me.updatetraining.SmallImage = CType(resources.GetObject("updatetraining.SmallImage"), System.Drawing.Image)
        Me.updatetraining.Text = "Add New Trainings"
        '
        'updateeducation
        '
        Me.updateeducation.Name = "updateeducation"
        Me.updateeducation.SmallImage = CType(resources.GetObject("updateeducation.SmallImage"), System.Drawing.Image)
        Me.updateeducation.Text = "Add Educational Background"
        '
        'updateemployment
        '
        Me.updateemployment.Name = "updateemployment"
        Me.updateemployment.SmallImage = CType(resources.GetObject("updateemployment.SmallImage"), System.Drawing.Image)
        Me.updateemployment.Text = "Add Employment"
        '
        'updatememo
        '
        Me.updatememo.Name = "updatememo"
        Me.updatememo.SmallImage = CType(resources.GetObject("updatememo.SmallImage"), System.Drawing.Image)
        Me.updatememo.Text = "Add Memo"
        '
        'RibbonGroup3
        '
        Me.RibbonGroup3.Items.Add(Me.RibbonButton9)
        Me.RibbonGroup3.Items.Add(Me.RibbonButton7)
        Me.RibbonGroup3.Items.Add(Me.RibbonButton8)
        Me.RibbonGroup3.Name = "RibbonGroup3"
        Me.RibbonGroup3.Text = "Schedule and Payroll Update"
        '
        'RibbonButton9
        '
        Me.RibbonButton9.Name = "RibbonButton9"
        Me.RibbonButton9.SmallImage = CType(resources.GetObject("RibbonButton9.SmallImage"), System.Drawing.Image)
        Me.RibbonButton9.Text = "Update Schedule"
        '
        'RibbonButton7
        '
        Me.RibbonButton7.Name = "RibbonButton7"
        Me.RibbonButton7.SmallImage = CType(resources.GetObject("RibbonButton7.SmallImage"), System.Drawing.Image)
        Me.RibbonButton7.Text = "Update Earnings and Allowance"
        '
        'RibbonButton8
        '
        Me.RibbonButton8.Name = "RibbonButton8"
        Me.RibbonButton8.SmallImage = CType(resources.GetObject("RibbonButton8.SmallImage"), System.Drawing.Image)
        Me.RibbonButton8.Text = "Update Deductions"
        '
        'InputGroupHeader23
        '
        Me.InputGroupHeader23.Name = "InputGroupHeader23"
        Me.InputGroupHeader23.Text = "Addresses:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.C1InputPanel1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 129)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1259, 156)
        Me.Panel1.TabIndex = 9
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel1.Items.Add(Me.InputGroupHeader1)
        Me.C1InputPanel1.Items.Add(Me.InputLabel6)
        Me.C1InputPanel1.Items.Add(Me.EmployeeNo)
        Me.C1InputPanel1.Items.Add(Me.Search)
        Me.C1InputPanel1.Items.Add(Me.InputSeparator1)
        Me.C1InputPanel1.Items.Add(Me.InputLabel1)
        Me.C1InputPanel1.Items.Add(Me.FirstName)
        Me.C1InputPanel1.Items.Add(Me.InputLabel2)
        Me.C1InputPanel1.Items.Add(Me.MiddleName)
        Me.C1InputPanel1.Items.Add(Me.InputLabel3)
        Me.C1InputPanel1.Items.Add(Me.LastName)
        Me.C1InputPanel1.Items.Add(Me.InputLabel4)
        Me.C1InputPanel1.Items.Add(Me.Suffix)
        Me.C1InputPanel1.Items.Add(Me.InputLabel9)
        Me.C1InputPanel1.Items.Add(Me.Gender)
        Me.C1InputPanel1.Items.Add(Me.InputLabel13)
        Me.C1InputPanel1.Items.Add(Me.ContactNo)
        Me.C1InputPanel1.Items.Add(Me.InputLabel17)
        Me.C1InputPanel1.Items.Add(Me.Email)
        Me.C1InputPanel1.Items.Add(Me.active)
        Me.C1InputPanel1.Items.Add(Me.InputSeparator2)
        Me.C1InputPanel1.Items.Add(Me.InputLabel5)
        Me.C1InputPanel1.Items.Add(Me.TIN)
        Me.C1InputPanel1.Items.Add(Me.InputLabel11)
        Me.C1InputPanel1.Items.Add(Me.SSS)
        Me.C1InputPanel1.Items.Add(Me.InputLabel10)
        Me.C1InputPanel1.Items.Add(Me.PHIC)
        Me.C1InputPanel1.Items.Add(Me.InputLabel12)
        Me.C1InputPanel1.Items.Add(Me.HDMF)
        Me.C1InputPanel1.Items.Add(Me.InputLabel48)
        Me.C1InputPanel1.Items.Add(Me.BankAccount)
        Me.C1InputPanel1.Location = New System.Drawing.Point(157, 0)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(1102, 156)
        Me.C1InputPanel1.TabIndex = 6
        Me.C1InputPanel1.VisualStyle = C1.Win.C1InputPanel.VisualStyle.System
        '
        'InputGroupHeader1
        '
        Me.InputGroupHeader1.Name = "InputGroupHeader1"
        Me.InputGroupHeader1.Text = "EMPLOYEE PRIMARY INFORMATION"
        '
        'InputLabel6
        '
        Me.InputLabel6.Name = "InputLabel6"
        Me.InputLabel6.Text = "ID No:"
        Me.InputLabel6.Width = 64
        '
        'EmployeeNo
        '
        Me.EmployeeNo.Break = C1.Win.C1InputPanel.BreakType.None
        Me.EmployeeNo.Name = "EmployeeNo"
        Me.EmployeeNo.Width = 130
        '
        'Search
        '
        Me.Search.Image = Global.A1plus.My.Resources.Resources.search123
        Me.Search.Name = "Search"
        Me.Search.Text = "Search"
        '
        'InputSeparator1
        '
        Me.InputSeparator1.Name = "InputSeparator1"
        Me.InputSeparator1.Width = 937
        '
        'InputLabel1
        '
        Me.InputLabel1.Name = "InputLabel1"
        Me.InputLabel1.Text = "First Name"
        Me.InputLabel1.Width = 64
        '
        'FirstName
        '
        Me.FirstName.Break = C1.Win.C1InputPanel.BreakType.None
        Me.FirstName.Name = "FirstName"
        Me.FirstName.Width = 130
        '
        'InputLabel2
        '
        Me.InputLabel2.Name = "InputLabel2"
        Me.InputLabel2.Text = "Middle Name"
        Me.InputLabel2.Width = 75
        '
        'MiddleName
        '
        Me.MiddleName.Break = C1.Win.C1InputPanel.BreakType.None
        Me.MiddleName.Name = "MiddleName"
        Me.MiddleName.Width = 130
        '
        'InputLabel3
        '
        Me.InputLabel3.Name = "InputLabel3"
        Me.InputLabel3.Text = "Last Name"
        Me.InputLabel3.Width = 64
        '
        'LastName
        '
        Me.LastName.Break = C1.Win.C1InputPanel.BreakType.None
        Me.LastName.Name = "LastName"
        Me.LastName.Width = 130
        '
        'InputLabel4
        '
        Me.InputLabel4.Name = "InputLabel4"
        Me.InputLabel4.Text = "Suffix"
        Me.InputLabel4.Width = 50
        '
        'Suffix
        '
        Me.Suffix.Name = "Suffix"
        Me.Suffix.Width = 57
        '
        'InputLabel9
        '
        Me.InputLabel9.Name = "InputLabel9"
        Me.InputLabel9.Text = "Gender"
        Me.InputLabel9.Width = 64
        '
        'Gender
        '
        Me.Gender.Break = C1.Win.C1InputPanel.BreakType.None
        Me.Gender.Items.Add(Me.InputOption3)
        Me.Gender.Items.Add(Me.InputOption5)
        Me.Gender.Name = "Gender"
        Me.Gender.Width = 130
        '
        'InputOption3
        '
        Me.InputOption3.Name = "InputOption3"
        Me.InputOption3.Text = "Male"
        '
        'InputOption5
        '
        Me.InputOption5.Name = "InputOption5"
        Me.InputOption5.Text = "Female"
        '
        'InputLabel13
        '
        Me.InputLabel13.Name = "InputLabel13"
        Me.InputLabel13.Text = "Contact No"
        Me.InputLabel13.Width = 75
        '
        'ContactNo
        '
        Me.ContactNo.Break = C1.Win.C1InputPanel.BreakType.None
        Me.ContactNo.Name = "ContactNo"
        Me.ContactNo.Width = 130
        '
        'InputLabel17
        '
        Me.InputLabel17.Name = "InputLabel17"
        Me.InputLabel17.Text = "Email "
        Me.InputLabel17.Width = 64
        '
        'Email
        '
        Me.Email.Break = C1.Win.C1InputPanel.BreakType.None
        Me.Email.Name = "Email"
        Me.Email.Width = 245
        '
        'active
        '
        Me.active.Break = C1.Win.C1InputPanel.BreakType.Group
        Me.active.CheckState = System.Windows.Forms.CheckState.Checked
        Me.active.Name = "active"
        Me.active.Text = "Active"
        Me.active.Width = 212
        '
        'InputSeparator2
        '
        Me.InputSeparator2.Name = "InputSeparator2"
        Me.InputSeparator2.Width = 937
        '
        'InputLabel5
        '
        Me.InputLabel5.Name = "InputLabel5"
        Me.InputLabel5.Text = "Tax ID No"
        Me.InputLabel5.Width = 65
        '
        'TIN
        '
        Me.TIN.Break = C1.Win.C1InputPanel.BreakType.None
        Me.TIN.Name = "TIN"
        Me.TIN.Width = 129
        '
        'InputLabel11
        '
        Me.InputLabel11.Name = "InputLabel11"
        Me.InputLabel11.Text = "SSS"
        Me.InputLabel11.Width = 28
        '
        'SSS
        '
        Me.SSS.Break = C1.Win.C1InputPanel.BreakType.None
        Me.SSS.Name = "SSS"
        Me.SSS.Width = 106
        '
        'InputLabel10
        '
        Me.InputLabel10.Name = "InputLabel10"
        Me.InputLabel10.Text = "PHIC"
        Me.InputLabel10.Width = 54
        '
        'PHIC
        '
        Me.PHIC.Break = C1.Win.C1InputPanel.BreakType.None
        Me.PHIC.Name = "PHIC"
        Me.PHIC.Width = 129
        '
        'InputLabel12
        '
        Me.InputLabel12.Name = "InputLabel12"
        Me.InputLabel12.Text = "HDMF"
        Me.InputLabel12.Width = 40
        '
        'HDMF
        '
        Me.HDMF.Break = C1.Win.C1InputPanel.BreakType.None
        Me.HDMF.Name = "HDMF"
        Me.HDMF.Width = 106
        '
        'InputLabel48
        '
        Me.InputLabel48.Name = "InputLabel48"
        Me.InputLabel48.Text = "Bank Acct No" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.InputLabel48.Width = 74
        '
        'BankAccount
        '
        Me.BankAccount.Name = "BankAccount"
        Me.BankAccount.Width = 106
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = Global.A1plus.My.Resources.Resources.y_u_no_photo_Square
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(157, 156)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'C1CommandHolder1
        '
        Me.C1CommandHolder1.Commands.Add(Me.C1Command1)
        Me.C1CommandHolder1.ImageList = Me.ImageList1
        Me.C1CommandHolder1.Owner = Me
        '
        'C1Command1
        '
        Me.C1Command1.ImageIndex = 1
        Me.C1Command1.Name = "C1Command1"
        Me.C1Command1.ShortcutText = ""
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "checkbox_no.png")
        Me.ImageList1.Images.SetKeyName(1, "checkbox.png")
        Me.ImageList1.Images.SetKeyName(2, "header.png")
        '
        'InputLabel33
        '
        Me.InputLabel33.Name = "InputLabel33"
        Me.InputLabel33.Text = "Daily Rate"
        Me.InputLabel33.Width = 100
        '
        'InputNumericBox1
        '
        Me.InputNumericBox1.DecimalPlaces = 2
        Me.InputNumericBox1.Format = "n"
        Me.InputNumericBox1.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.InputNumericBox1.Name = "InputNumericBox1"
        Me.InputNumericBox1.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.InputNumericBox1.Width = 138
        '
        'InputLabel34
        '
        Me.InputLabel34.Name = "InputLabel34"
        Me.InputLabel34.Text = "Daily Rate"
        Me.InputLabel34.Width = 100
        '
        'InputNumericBox2
        '
        Me.InputNumericBox2.DecimalPlaces = 2
        Me.InputNumericBox2.Format = "n"
        Me.InputNumericBox2.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.InputNumericBox2.Name = "InputNumericBox2"
        Me.InputNumericBox2.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.InputNumericBox2.Width = 138
        '
        'HRIS_EmployeeInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1259, 783)
        Me.Controls.Add(Me.C1DockingTab1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.C1Ribbon1)
        Me.Name = "HRIS_EmployeeInformation"
        Me.Text = "Employee Information Management"
        Me.C1DockingTabPage6.ResumeLayout(False)
        Me.C1DockingTabPage6.PerformLayout()
        Me.ToolStrip5.ResumeLayout(False)
        Me.ToolStrip5.PerformLayout()
        CType(Me.EmploymentGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1DockingTabPage5.ResumeLayout(False)
        CType(Me.C1SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1SplitContainer2.ResumeLayout(False)
        Me.C1SplitterPanel3.ResumeLayout(False)
        Me.C1SplitterPanel3.PerformLayout()
        CType(Me.EducationGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip4.ResumeLayout(False)
        Me.ToolStrip4.PerformLayout()
        Me.C1SplitterPanel4.ResumeLayout(False)
        Me.C1SplitterPanel4.PerformLayout()
        CType(Me.TrainingGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        Me.C1DockingTabPage3.ResumeLayout(False)
        CType(Me.C1SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1SplitContainer1.ResumeLayout(False)
        Me.C1SplitterPanel1.ResumeLayout(False)
        Me.C1SplitterPanel1.PerformLayout()
        CType(Me.PaySetUpGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip7.ResumeLayout(False)
        Me.ToolStrip7.PerformLayout()
        Me.C1SplitterPanel2.ResumeLayout(False)
        Me.C1SplitterPanel2.PerformLayout()
        Me.ToolStrip8.ResumeLayout(False)
        Me.ToolStrip8.PerformLayout()
        CType(Me.AllowanceGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1DockingTabPage2.ResumeLayout(False)
        Me.C1DockingTabPage2.PerformLayout()
        CType(Me.ResidenceGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.C1InputPanel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1DockingTabPage1.ResumeLayout(False)
        CType(Me.RequirementGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1DockingTab1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1DockingTab1.ResumeLayout(False)
        Me.C1DockingTabPage4.ResumeLayout(False)
        Me.C1DockingTabPage4.PerformLayout()
        CType(Me.DependentsGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.C1InputPanel11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1DockingTabPage12.ResumeLayout(False)
        Me.C1DockingTabPage12.PerformLayout()
        Me.ToolStrip6.ResumeLayout(False)
        Me.ToolStrip6.PerformLayout()
        CType(Me.MemoGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Ribbon1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents C1DockingTab1 As C1.Win.C1Command.C1DockingTab
    Friend WithEvents C1DockingTabPage1 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents C1InputPanel5 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents C1InputPanel2 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents C1DockingTabPage2 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents C1DockingTabPage3 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents C1DockingTabPage5 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents C1DockingTabPage6 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents C1InputPanel4 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents C1InputPanel6 As C1.Win.C1InputPanel.C1InputPanel
    Public WithEvents ResidenceGrid As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents C1DockingTabPage4 As C1.Win.C1Command.C1DockingTabPage
    Public WithEvents DependentsGrid As C1.Win.C1FlexGrid.C1FlexGrid
    Public WithEvents EmploymentGrid As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents C1InputPanel11 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents C1InputPanel12 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents C1Ribbon1 As C1.Win.C1Ribbon.C1Ribbon
    Public WithEvents RibbonApplicationMenu1 As C1.Win.C1Ribbon.RibbonApplicationMenu
    Friend WithEvents RibbonConfigToolBar1 As C1.Win.C1Ribbon.RibbonConfigToolBar
    Friend WithEvents RibbonGroup1 As C1.Win.C1Ribbon.RibbonGroup
    Friend WithEvents SaveJobOrder As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents NewOrder As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents PrintCreditMemo As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents CloseForm As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents CancelSOButton As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents RibbonGroup2 As C1.Win.C1Ribbon.RibbonGroup
    Friend WithEvents updatetraining As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents updatedependent As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents updateaddress As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents updateeducation As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents updateemployment As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents RibbonGroup3 As C1.Win.C1Ribbon.RibbonGroup
    Friend WithEvents RibbonButton7 As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents RibbonButton8 As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents RibbonButton9 As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents updatememo As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents C1InputPanel17 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents C1DockingTabPage12 As C1.Win.C1Command.C1DockingTabPage
    Public WithEvents MemoGrid As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Public WithEvents RequirementGrid As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents C1InputPanel20 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents C1ToolBar1 As C1.Win.C1Command.C1ToolBar
    Friend WithEvents C1CommandHolder1 As C1.Win.C1Command.C1CommandHolder
    Friend WithEvents C1Command1 As C1.Win.C1Command.C1Command
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents NewAddress As System.Windows.Forms.ToolStripButton
    Friend WithEvents EditAddress As System.Windows.Forms.ToolStripButton
    Friend WithEvents DeleteAddress As System.Windows.Forms.ToolStripButton
    Friend WithEvents C1SplitContainer2 As C1.Win.C1SplitContainer.C1SplitContainer
    Friend WithEvents addresstotal As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents NewDependent As System.Windows.Forms.ToolStripButton
    Friend WithEvents EditDependent As System.Windows.Forms.ToolStripButton
    Friend WithEvents DeleteDependent As System.Windows.Forms.ToolStripButton
    Friend WithEvents dependentstotal As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel4 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStrip5 As System.Windows.Forms.ToolStrip
    Friend WithEvents NewEmployment As System.Windows.Forms.ToolStripButton
    Friend WithEvents EditEmployment As System.Windows.Forms.ToolStripButton
    Friend WithEvents DeleteEmployment As System.Windows.Forms.ToolStripButton
    Friend WithEvents employmentotal As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel10 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStrip6 As System.Windows.Forms.ToolStrip
    Friend WithEvents memototal As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel12 As System.Windows.Forms.ToolStripLabel
    Private WithEvents InputGroupHeader9 As C1.Win.C1InputPanel.InputGroupHeader
    Private WithEvents InputLabel64 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents InputLabel65 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents InputGroupHeader3 As C1.Win.C1InputPanel.InputGroupHeader
    Private WithEvents InputLabel25 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents ImmediateSuperior As C1.Win.C1InputPanel.InputComboBox
    Private WithEvents InputLabel26 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents Department As C1.Win.C1InputPanel.InputComboBox
    Private WithEvents InputLabel8 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents Team As C1.Win.C1InputPanel.InputComboBox
    Private WithEvents InputLabel14 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents EmployeeType As C1.Win.C1InputPanel.InputComboBox
    Private WithEvents InputLabel15 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents Location As C1.Win.C1InputPanel.InputComboBox
    Private WithEvents InputLabel16 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents CompanyName As C1.Win.C1InputPanel.InputComboBox
    Private WithEvents InputComboBox5 As C1.Win.C1InputPanel.InputComboBox
    Private WithEvents InputComboBox6 As C1.Win.C1InputPanel.InputComboBox
    Private WithEvents InputComboBox7 As C1.Win.C1InputPanel.InputComboBox
    Private WithEvents DateHired As C1.Win.C1InputPanel.InputDatePicker
    Private WithEvents DateRegular As C1.Win.C1InputPanel.InputDatePicker
    Private WithEvents InputLabel18 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents DateSeparated As C1.Win.C1InputPanel.InputDatePicker
    Private WithEvents InputLabel19 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents DateResigned As C1.Win.C1InputPanel.InputDatePicker
    Private WithEvents Rehirable As C1.Win.C1InputPanel.InputCheckBox
    Private WithEvents InputGroupHeader4 As C1.Win.C1InputPanel.InputGroupHeader
    Private WithEvents InputLabel20 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents ContractStartDate As C1.Win.C1InputPanel.InputDatePicker
    Private WithEvents InputLabel21 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents ContractEndDate As C1.Win.C1InputPanel.InputDatePicker
    Private WithEvents InputGroupHeader10 As C1.Win.C1InputPanel.InputGroupHeader
    Private WithEvents InputLabel22 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents ClearanceStatus As C1.Win.C1InputPanel.InputComboBox
    Private WithEvents InputLabel23 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents DateCleared As C1.Win.C1InputPanel.InputDatePicker
    Private WithEvents InputLabel24 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents IssuedBy As C1.Win.C1InputPanel.InputTextBox
    Private WithEvents InputLabel53 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents Remarks As C1.Win.C1InputPanel.InputTextBox
    Private WithEvents InputGroupHeader8 As C1.Win.C1InputPanel.InputGroupHeader
    Private WithEvents InputLabel45 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents payrollgroup As C1.Win.C1InputPanel.InputComboBox
    Private WithEvents InputLabel42 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents BasicSalary As C1.Win.C1InputPanel.InputNumericBox
    Private WithEvents InputLabel43 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents InputLabel44 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents paymentmethod As C1.Win.C1InputPanel.InputComboBox
    Private WithEvents InputGroupHeader7 As C1.Win.C1InputPanel.InputGroupHeader
    Private WithEvents InputGroupHeader16 As C1.Win.C1InputPanel.InputGroupHeader
    Private WithEvents InputGroupHeader17 As C1.Win.C1InputPanel.InputGroupHeader
    Private WithEvents RibbonQat1 As C1.Win.C1Ribbon.RibbonQat
    Private WithEvents ModuleControlTab As C1.Win.C1Ribbon.RibbonTab
    Private WithEvents InputGroupHeader22 As C1.Win.C1InputPanel.InputGroupHeader
    Private WithEvents deducttax As C1.Win.C1InputPanel.InputCheckBox
    Private WithEvents deductsss As C1.Win.C1InputPanel.InputCheckBox
    Private WithEvents deducthdmf As C1.Win.C1InputPanel.InputCheckBox
    Private WithEvents deductphic As C1.Win.C1InputPanel.InputCheckBox
    Private WithEvents InputOption1 As C1.Win.C1InputPanel.InputOption
    Private WithEvents InputOption2 As C1.Win.C1InputPanel.InputOption
    Private WithEvents InputOption4 As C1.Win.C1InputPanel.InputOption
    Private WithEvents InputLabel49 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents Position As C1.Win.C1InputPanel.InputComboBox
    Private WithEvents InputGroupHeader11 As C1.Win.C1InputPanel.InputGroupHeader
    Private WithEvents InputLabel7 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents TimeSheetApproval As C1.Win.C1InputPanel.InputComboBox
    Private WithEvents InputLabel50 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents OvertimeApproval As C1.Win.C1InputPanel.InputComboBox
    Private WithEvents InputGroupHeader24 As C1.Win.C1InputPanel.InputGroupHeader
    Private WithEvents InputGroupHeader23 As C1.Win.C1InputPanel.InputGroupHeader
    Private WithEvents InputOption10 As C1.Win.C1InputPanel.InputOption
    Private WithEvents InputOption11 As C1.Win.C1InputPanel.InputOption
    Private WithEvents InputOption12 As C1.Win.C1InputPanel.InputOption
    Private WithEvents InputOption13 As C1.Win.C1InputPanel.InputOption
    Private WithEvents InputOption14 As C1.Win.C1InputPanel.InputOption
    Private WithEvents InputGroupHeader1 As C1.Win.C1InputPanel.InputGroupHeader
    Private WithEvents InputLabel6 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents EmployeeNo As C1.Win.C1InputPanel.InputTextBox
    Private WithEvents InputSeparator1 As C1.Win.C1InputPanel.InputSeparator
    Private WithEvents InputLabel1 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents FirstName As C1.Win.C1InputPanel.InputTextBox
    Private WithEvents InputLabel2 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents MiddleName As C1.Win.C1InputPanel.InputTextBox
    Private WithEvents InputLabel3 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents LastName As C1.Win.C1InputPanel.InputTextBox
    Private WithEvents InputLabel4 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents Suffix As C1.Win.C1InputPanel.InputTextBox
    Private WithEvents InputLabel9 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents Gender As C1.Win.C1InputPanel.InputComboBox
    Private WithEvents InputOption3 As C1.Win.C1InputPanel.InputOption
    Private WithEvents InputOption5 As C1.Win.C1InputPanel.InputOption
    Private WithEvents InputLabel13 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents ContactNo As C1.Win.C1InputPanel.InputTextBox
    Private WithEvents InputLabel17 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents Email As C1.Win.C1InputPanel.InputTextBox
    Private WithEvents active As C1.Win.C1InputPanel.InputCheckBox
    Private WithEvents InputLabel5 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents InputLabel10 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents InputLabel11 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents InputLabel12 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents InputLabel48 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents InputLabel36 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents EmploymentLevel As C1.Win.C1InputPanel.InputComboBox
    Private WithEvents InputGroupHeader6 As C1.Win.C1InputPanel.InputGroupHeader
    Friend WithEvents AddressRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents EmploymentRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents DependenceRefresh As System.Windows.Forms.ToolStripButton
    Private WithEvents InputLabel61 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents BasicPayHourly As C1.Win.C1InputPanel.InputNumericBox
    Private WithEvents InputLabel67 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents cola As C1.Win.C1InputPanel.InputNumericBox
    Private WithEvents InputLabel73 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents wtax As C1.Win.C1InputPanel.InputNumericBox
    Private WithEvents InputLabel66 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents SSSEEShare As C1.Win.C1InputPanel.InputNumericBox
    Private WithEvents InputLabel70 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents BasicPay As C1.Win.C1InputPanel.InputNumericBox
    Private WithEvents InputLabel71 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents PHICEEShare As C1.Win.C1InputPanel.InputNumericBox
    Private WithEvents InputLabel68 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents Exception As C1.Win.C1InputPanel.InputNumericBox
    Private WithEvents InputLabel69 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents HDMFEEShare As C1.Win.C1InputPanel.InputNumericBox
    Private WithEvents InputLabel72 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents Mandatory As C1.Win.C1InputPanel.InputNumericBox
    Private WithEvents InputLabel75 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents EmploymentStatus As C1.Win.C1InputPanel.InputComboBox
    Friend WithEvents C1SplitterPanel3 As C1.Win.C1SplitContainer.C1SplitterPanel
    Public WithEvents EducationGrid As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents ToolStrip4 As System.Windows.Forms.ToolStrip
    Friend WithEvents NewEducation As System.Windows.Forms.ToolStripButton
    Friend WithEvents EditEducation As System.Windows.Forms.ToolStripButton
    Friend WithEvents DeleteEducation As System.Windows.Forms.ToolStripButton
    Friend WithEvents educationtotal As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel8 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents EducationRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents C1SplitterPanel4 As C1.Win.C1SplitContainer.C1SplitterPanel
    Public WithEvents TrainingGrid As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
    Friend WithEvents NewTraining As System.Windows.Forms.ToolStripButton
    Friend WithEvents EditTraining As System.Windows.Forms.ToolStripButton
    Friend WithEvents DeleteTraining As System.Windows.Forms.ToolStripButton
    Friend WithEvents trainingtotal As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel6 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents TrainingRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents C1SplitContainer1 As C1.Win.C1SplitContainer.C1SplitContainer
    Friend WithEvents C1SplitterPanel1 As C1.Win.C1SplitContainer.C1SplitterPanel
    Public WithEvents PaySetUpGrid As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents ToolStrip7 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents C1SplitterPanel2 As C1.Win.C1SplitContainer.C1SplitterPanel
    Public WithEvents AllowanceGrid As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents ToolStrip8 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel5 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel7 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton9 As System.Windows.Forms.ToolStripButton
    Private WithEvents InputGroupHeader14 As C1.Win.C1InputPanel.InputGroupHeader
    Private WithEvents Search As C1.Win.C1InputPanel.InputButton
    Private WithEvents InputLabel33 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents InputNumericBox1 As C1.Win.C1InputPanel.InputNumericBox
    Private WithEvents InputLabel34 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents InputNumericBox2 As C1.Win.C1InputPanel.InputNumericBox
    Friend WithEvents C1InputPanel3 As C1.Win.C1InputPanel.C1InputPanel
    Private WithEvents InputSeparator3 As C1.Win.C1InputPanel.InputSeparator
    Private WithEvents ChargetoCompany As C1.Win.C1InputPanel.InputCheckBox
    Private WithEvents TIN As C1.Win.C1InputPanel.InputTextBox
    Private WithEvents PHIC As C1.Win.C1InputPanel.InputTextBox
    Private WithEvents SSS As C1.Win.C1InputPanel.InputTextBox
    Private WithEvents HDMF As C1.Win.C1InputPanel.InputTextBox
    Private WithEvents BankAccount As C1.Win.C1InputPanel.InputTextBox
    Private WithEvents InputGroupHeader12 As C1.Win.C1InputPanel.InputGroupHeader
    Private WithEvents InputLabel35 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents DateofBirth As C1.Win.C1InputPanel.InputDatePicker
    Private WithEvents InputLabel37 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents PlaceOfBirth As C1.Win.C1InputPanel.InputTextBox
    Private WithEvents InputLabel38 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents CivilStatus As C1.Win.C1InputPanel.InputComboBox
    Private WithEvents InputOption15 As C1.Win.C1InputPanel.InputOption
    Private WithEvents InputOption16 As C1.Win.C1InputPanel.InputOption
    Private WithEvents InputOption17 As C1.Win.C1InputPanel.InputOption
    Private WithEvents InputOption18 As C1.Win.C1InputPanel.InputOption
    Private WithEvents InputLabel39 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents Religion As C1.Win.C1InputPanel.InputComboBox
    Private WithEvents InputLabel40 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents Height As C1.Win.C1InputPanel.InputNumericBox
    Private WithEvents InputLabel41 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents Weight As C1.Win.C1InputPanel.InputNumericBox
    Private WithEvents InputLabel46 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents BloodType As C1.Win.C1InputPanel.InputTextBox
    Private WithEvents InputLabel47 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents BodyBuild As C1.Win.C1InputPanel.InputTextBox
    Private WithEvents InputSeparator2 As C1.Win.C1InputPanel.InputSeparator
    Private WithEvents InputLabel27 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents InputLabel28 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents InputLabel29 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents InputLabel30 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents HiddenAllowanceRate As C1.Win.C1InputPanel.InputNumericBox
    Private WithEvents InputLabel54 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents InputLabel51 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents InputLabel52 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents InputLabel31 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents GrossPay As C1.Win.C1InputPanel.InputNumericBox
    Private WithEvents InputLabel32 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents NetPay As C1.Win.C1InputPanel.InputNumericBox
    Private WithEvents HiddenAllowance As C1.Win.C1InputPanel.InputNumericBox
    Private WithEvents LegalAllowance As C1.Win.C1InputPanel.InputNumericBox
    Private WithEvents TaxableIncome As C1.Win.C1InputPanel.InputNumericBox
    Private WithEvents InputSeparator5 As C1.Win.C1InputPanel.InputSeparator
    Private WithEvents InputSeparator6 As C1.Win.C1InputPanel.InputSeparator
    Private WithEvents InputSeparator4 As C1.Win.C1InputPanel.InputSeparator
    Private WithEvents InputLabel55 As C1.Win.C1InputPanel.InputLabel
    Private WithEvents MonthlyPay As C1.Win.C1InputPanel.InputNumericBox
    Friend WithEvents MonthlyHours As C1.Win.C1InputPanel.InputNumericBox
End Class
