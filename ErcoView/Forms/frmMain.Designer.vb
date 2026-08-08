<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Me.colADDITIONAL_WORK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.smallImages = New DevExpress.Utils.ImageCollection(Me.components)
        Me.btnNewProposal = New DevExpress.XtraBars.BarButtonItem()
        Me.txtLoginName = New DevExpress.XtraBars.BarStaticItem()
        Me.siSaveProposalLayout = New DevExpress.XtraBars.BarSubItem()
        Me.btnSaveProposalLayout = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSaveAsProposalLayout = New DevExpress.XtraBars.BarButtonItem()
        Me.btnRemoveProposalLayout = New DevExpress.XtraBars.BarButtonItem()
        Me.cmboProposalLayout = New DevExpress.XtraBars.BarEditItem()
        Me.RIProposalLayouts = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.btnNewCustomer = New DevExpress.XtraBars.BarButtonItem()
        Me.btnProposalMap = New DevExpress.XtraBars.BarButtonItem()
        Me.btnExportProposal = New DevExpress.XtraBars.BarButtonItem()
        Me.btnReportProposal = New DevExpress.XtraBars.BarButtonItem()
        Me.btnNewUser = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSettings = New DevExpress.XtraBars.BarButtonItem()
        Me.btnNewVendor = New DevExpress.XtraBars.BarButtonItem()
        Me.btnNew = New DevExpress.XtraBars.BarButtonItem()
        Me.btnRemoveCustomerLayout = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSaveContactLayout = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSaveUserLayout = New DevExpress.XtraBars.BarButtonItem()
        Me.btnExportCustomer = New DevExpress.XtraBars.BarButtonItem()
        Me.btnRemoveContactLayout = New DevExpress.XtraBars.BarButtonItem()
        Me.btnRemoveUserLayout = New DevExpress.XtraBars.BarButtonItem()
        Me.btnRemoveVendorLayout = New DevExpress.XtraBars.BarButtonItem()
        Me.btnExportUser = New DevExpress.XtraBars.BarButtonItem()
        Me.btnExportContact = New DevExpress.XtraBars.BarButtonItem()
        Me.btnExportVendor = New DevExpress.XtraBars.BarButtonItem()
        Me.btnReportContact = New DevExpress.XtraBars.BarButtonItem()
        Me.btnBrowseBrowse = New DevExpress.XtraBars.BarButtonItem()
        Me.btnNewGroup = New DevExpress.XtraBars.BarButtonItem()
        Me.cmboCustomerLayout = New DevExpress.XtraBars.BarEditItem()
        Me.RICustomerLayouts = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.cmboVendorLayout = New DevExpress.XtraBars.BarEditItem()
        Me.RIVendorLayouts = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.cmboContactLayout = New DevExpress.XtraBars.BarEditItem()
        Me.RIContactLayouts = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.btnSaveCustomerLayout = New DevExpress.XtraBars.BarButtonItem()
        Me.siSaveCustomerLayout = New DevExpress.XtraBars.BarSubItem()
        Me.btnSaveAsCustomerLayout = New DevExpress.XtraBars.BarButtonItem()
        Me.siSaveVendor = New DevExpress.XtraBars.BarSubItem()
        Me.btnSaveVendorLayout = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSaveAsVendorLayout = New DevExpress.XtraBars.BarButtonItem()
        Me.siSaveContact = New DevExpress.XtraBars.BarSubItem()
        Me.btnSaveAsContactLayout = New DevExpress.XtraBars.BarButtonItem()
        Me.BarEditItem1 = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.largeImages = New DevExpress.Utils.ImageCollection(Me.components)
        Me.pageProposal = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.rpgFileProposal = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgLayoutProposal = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgBrowse = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgMapProposal = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgReportProposal = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.pageCustomer = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.rpgFileCustomer = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgReportCustomer = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgLayout = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.pageVendor = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.rpgFileVendor = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgReportVendor = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgLayoutVendor = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.pageContact = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.rpgFileContact = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgReportContact = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgLayoutContact = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.pageUser = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.rpgFileUser = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgReportUser = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.pageGroup = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.rpgNew = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RepositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.RepositoryItemComboBox3 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.RepositoryItemComboBox4 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.RepositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
        Me.RepositoryItemComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.RepositoryItemImageComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
        Me.ClientPanel = New DevExpress.XtraEditors.PanelControl()
        Me.tabPages = New DevExpress.XtraTab.XtraTabControl()
        Me.tabProposal = New DevExpress.XtraTab.XtraTabPage()
        Me.GridProposals = New DevExpress.XtraGrid.GridControl()
        Me.SpGetProposalsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsErcoView2 = New ErcoView.dsErcoView()
        Me.gridViewProposal = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colPROPOSAL_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPROPOSAL_NUMBER = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colJOB_NUMBER = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colJOB_TYPE_TEXT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSBS_COMPANY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCUSTOMER_TEXT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCONTACT_TEXT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVENDOR_TEXT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coljob_type_misc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSALESMAN_TEXT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSUPER_TEXT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colENTERED_BY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDATE_ENTERED = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDATE_COMPLETED = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDATE_NOR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDATE_PROPOSAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldate_updated = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colupdated_by = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDESCRIPTION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCOMMENTS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBODY_OF_WATER = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDRIVING_DIRECTIONS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSTATUS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCITY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCOUNTY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSTATE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGPS_N = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGPS_W = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMILE_POINT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLINE_NUMBER = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDISTRICT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCONTRACT_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWORK_ORDER_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPRICE_PROPOSAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPRICE_PERMIT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPRICE_EXTRA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPRICE_ACTUAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPERMIT_COST = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPRICE_TOTAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPROFIT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colONE_CALL_TICKET_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colONE_CALL_START_DATE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colONE_CALL_TICKET_START_TIME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colONE_CALL_EXPERATION_DATE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colESTIMATED_COST = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colESTIMATED_MARGIN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPERMITS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFIELD_CONTACT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPIPE_DIAMETER = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWATER_COURSE_DESC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSPECIFIC_PERMIT_ISSUES = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCONSTRUCTION_ISSUES = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPRIORITY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPRIORITY_DESCRIPTION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colADDITIONAL_WORK_COMMENT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSTATUS_COMMENT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPERMIT_STATUS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCONTRACT_STATUS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAREA_HOTEL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNOTES = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPROPOSAL_STATUS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colJOB_STATUS_COMMENTS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colACTIVE_STATUS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colENTERED_BY_TEXT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUPDATED_BY_TEXT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colconst_month = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colconst_year = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGROUP_TEXT2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coljob_status = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemImageComboBox3 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
        Me.RepositoryItemImageComboBox4 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
        Me.Customers = New DevExpress.XtraTab.XtraTabPage()
        Me.GridCustomers = New DevExpress.XtraGrid.GridControl()
        Me.SpGetCustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gridViewCustomer = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCUSTOMER_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCUSTOMER_NAME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colADDRESS_LINE1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colADDRESS_LINE2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCITY1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCOUNTY1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSTATE1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPHONE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFAX = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWEBSITE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colZIP_CODE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCUSTOMER_NOTES = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGROUP_TEXT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colACTIVE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcustomer_type = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Users = New DevExpress.XtraTab.XtraTabPage()
        Me.GridUsers = New DevExpress.XtraGrid.GridControl()
        Me.SpGetUsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gridViewUser = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colUSER_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLAST_NAME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFIRST_NAME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUSER_NAME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPASSWORD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtPassword = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colEMAIL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPERMISSION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSALESMAN1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSUPER = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPERMISSION_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colACTIVE2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtTrueFalse = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.Vendors = New DevExpress.XtraTab.XtraTabPage()
        Me.GridVendors = New DevExpress.XtraGrid.GridControl()
        Me.SpGetVendorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gridViewVendor = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colVENDOR_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVENDOR_NAME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colADDRESS_LINE11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colADDRESS_LINE21 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCITY2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCOUNTY2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSTATE2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPHONE1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFAX1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWEBSITE1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colZIP_CODE1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCUSTOMER_NOTES1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGROUP_TEXT1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colACTIVE1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Contacts = New DevExpress.XtraTab.XtraTabPage()
        Me.GridContacts = New DevExpress.XtraGrid.GridControl()
        Me.SpGetContactBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gridViewContact = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCONTACT_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFIRST_NAME1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLAST_NAME1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colADDRESS_LINE12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colADDRESS_LINE22 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCITY3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colZIP_CODE2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCOUNTY3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSTATE3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPHONE2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFAX2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEMAIL1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCUSTOMER_NAME1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWEBSITE2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNOTES1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colACTIVE3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPHONE21 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tabGroup = New DevExpress.XtraTab.XtraTabPage()
        Me.grdGroup = New DevExpress.XtraGrid.GridControl()
        Me.SpGetGroupsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.grdViewGroup = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colGROUP_ID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGROUP_NAME1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SpGetContactsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DefaultBarAndDockingController1 = New DevExpress.XtraBars.DefaultBarAndDockingController(Me.components)
        Me.RibbonPageGroup9 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup10 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup11 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup12 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.SpGetCustomerTableAdapter1 = New ErcoView.dsErcoViewTableAdapters.spGetCustomerTableAdapter()
        Me.SpGetProposalsTableAdapter1 = New ErcoView.dsErcoViewTableAdapters.spGetProposalsTableAdapter()
        Me.SpGetUsersTableAdapter1 = New ErcoView.dsErcoViewTableAdapters.spGetUsersTableAdapter()
        Me.SpGetVendorTableAdapter1 = New ErcoView.dsErcoViewTableAdapters.spGetVendorTableAdapter()
        Me.SpGetContactsTableAdapter1 = New ErcoView.dsErcoViewTableAdapters.spGetContactsTableAdapter()
        Me.SpGetContactTableAdapter1 = New ErcoView.dsErcoViewTableAdapters.spGetContactTableAdapter()
        Me.SpGetGroupsTableAdapter1 = New ErcoView.dsErcoViewTableAdapters.spGetGroupsTableAdapter()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.smallImages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RIProposalLayouts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RICustomerLayouts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RIVendorLayouts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RIContactLayouts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.largeImages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemImageComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ClientPanel.SuspendLayout()
        CType(Me.tabPages, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPages.SuspendLayout()
        Me.tabProposal.SuspendLayout()
        CType(Me.GridProposals, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpGetProposalsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsErcoView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridViewProposal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemImageComboBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemImageComboBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Customers.SuspendLayout()
        CType(Me.GridCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpGetCustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridViewCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Users.SuspendLayout()
        CType(Me.GridUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpGetUsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridViewUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTrueFalse, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Vendors.SuspendLayout()
        CType(Me.GridVendors, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpGetVendorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridViewVendor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Contacts.SuspendLayout()
        CType(Me.GridContacts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpGetContactBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridViewContact, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabGroup.SuspendLayout()
        CType(Me.grdGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpGetGroupsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdViewGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpGetContactsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DefaultBarAndDockingController1.Controller, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colADDITIONAL_WORK
        '
        Me.colADDITIONAL_WORK.Caption = "Additional Work"
        Me.colADDITIONAL_WORK.FieldName = "ADDITIONAL_WORK"
        Me.colADDITIONAL_WORK.Name = "colADDITIONAL_WORK"
        Me.colADDITIONAL_WORK.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colADDITIONAL_WORK.Visible = True
        Me.colADDITIONAL_WORK.VisibleIndex = 53
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 567)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(1131, 32)
        '
        'RibbonControl
        '
        Me.RibbonControl.ApplicationButtonText = Nothing
        Me.RibbonControl.ApplicationIcon = CType(resources.GetObject("RibbonControl.ApplicationIcon"), System.Drawing.Bitmap)
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Images = Me.smallImages
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.btnNewProposal, Me.txtLoginName, Me.siSaveProposalLayout, Me.btnRemoveProposalLayout, Me.btnSaveProposalLayout, Me.btnSaveAsProposalLayout, Me.cmboProposalLayout, Me.btnNewCustomer, Me.btnProposalMap, Me.btnExportProposal, Me.btnReportProposal, Me.btnNewUser, Me.btnSettings, Me.btnNewVendor, Me.btnNew, Me.btnRemoveCustomerLayout, Me.btnSaveContactLayout, Me.btnSaveUserLayout, Me.btnExportCustomer, Me.btnRemoveContactLayout, Me.btnRemoveUserLayout, Me.btnRemoveVendorLayout, Me.btnExportUser, Me.btnExportContact, Me.btnExportVendor, Me.btnReportContact, Me.btnBrowseBrowse, Me.btnNewGroup, Me.cmboCustomerLayout, Me.cmboVendorLayout, Me.cmboContactLayout, Me.btnSaveCustomerLayout, Me.siSaveCustomerLayout, Me.btnSaveAsCustomerLayout, Me.siSaveVendor, Me.siSaveContact, Me.btnSaveAsVendorLayout, Me.btnSaveAsContactLayout, Me.btnSaveVendorLayout, Me.BarEditItem1})
        Me.RibbonControl.LargeImages = Me.largeImages
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 81
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.PageHeaderItemLinks.Add(Me.txtLoginName)
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.pageProposal, Me.pageCustomer, Me.pageVendor, Me.pageContact, Me.pageUser, Me.pageGroup})
        Me.RibbonControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RIProposalLayouts, Me.RICustomerLayouts, Me.RepositoryItemComboBox1, Me.RepositoryItemButtonEdit1, Me.RepositoryItemComboBox3, Me.RepositoryItemComboBox4, Me.RepositoryItemImageComboBox1, Me.RIVendorLayouts, Me.RIContactLayouts, Me.RepositoryItemComboBox2, Me.RepositoryItemImageComboBox2})
        Me.RibbonControl.Size = New System.Drawing.Size(1131, 145)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        Me.RibbonControl.Toolbar.ItemLinks.Add(Me.btnSettings)
        '
        'smallImages
        '
        Me.smallImages.ImageStream = CType(resources.GetObject("smallImages.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.smallImages.Images.SetKeyName(0, "Add.png")
        Me.smallImages.Images.SetKeyName(1, "Copy.png")
        Me.smallImages.Images.SetKeyName(2, "Delete.png")
        Me.smallImages.Images.SetKeyName(3, "Shield.png")
        Me.smallImages.Images.SetKeyName(4, "Save 2.png")
        Me.smallImages.Images.SetKeyName(5, "Save As.png")
        Me.smallImages.Images.SetKeyName(6, "Settings.png")
        Me.smallImages.Images.SetKeyName(7, "Folder.png")
        Me.smallImages.Images.SetKeyName(8, "Status Flag Black.png")
        Me.smallImages.Images.SetKeyName(9, "Status Flag Blue.png")
        Me.smallImages.Images.SetKeyName(10, "Status Flag Red.png")
        Me.smallImages.Images.SetKeyName(11, "Status Flag Yellow.png")
        '
        'btnNewProposal
        '
        Me.btnNewProposal.Caption = "New"
        Me.btnNewProposal.Id = 0
        Me.btnNewProposal.LargeImageIndex = 5
        Me.btnNewProposal.Name = "btnNewProposal"
        '
        'txtLoginName
        '
        Me.txtLoginName.Caption = "Login Name"
        Me.txtLoginName.Id = 2
        Me.txtLoginName.ImageIndex = 3
        Me.txtLoginName.Name = "txtLoginName"
        Me.txtLoginName.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'siSaveProposalLayout
        '
        Me.siSaveProposalLayout.Caption = "Save"
        Me.siSaveProposalLayout.Id = 7
        Me.siSaveProposalLayout.ImageIndex = 4
        Me.siSaveProposalLayout.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnSaveProposalLayout), New DevExpress.XtraBars.LinkPersistInfo(Me.btnSaveAsProposalLayout)})
        Me.siSaveProposalLayout.Name = "siSaveProposalLayout"
        '
        'btnSaveProposalLayout
        '
        Me.btnSaveProposalLayout.Caption = "Save"
        Me.btnSaveProposalLayout.Id = 9
        Me.btnSaveProposalLayout.ImageIndex = 4
        Me.btnSaveProposalLayout.Name = "btnSaveProposalLayout"
        '
        'btnSaveAsProposalLayout
        '
        Me.btnSaveAsProposalLayout.Caption = "Save As"
        Me.btnSaveAsProposalLayout.Id = 10
        Me.btnSaveAsProposalLayout.ImageIndex = 5
        Me.btnSaveAsProposalLayout.Name = "btnSaveAsProposalLayout"
        '
        'btnRemoveProposalLayout
        '
        Me.btnRemoveProposalLayout.Caption = "Remove"
        Me.btnRemoveProposalLayout.Id = 8
        Me.btnRemoveProposalLayout.ImageIndex = 2
        Me.btnRemoveProposalLayout.Name = "btnRemoveProposalLayout"
        '
        'cmboProposalLayout
        '
        Me.cmboProposalLayout.Caption = "Layout"
        Me.cmboProposalLayout.Edit = Me.RIProposalLayouts
        Me.cmboProposalLayout.Id = 13
        Me.cmboProposalLayout.Name = "cmboProposalLayout"
        Me.cmboProposalLayout.Width = 100
        '
        'RIProposalLayouts
        '
        Me.RIProposalLayouts.AutoHeight = False
        Me.RIProposalLayouts.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RIProposalLayouts.Name = "RIProposalLayouts"
        '
        'btnNewCustomer
        '
        Me.btnNewCustomer.Caption = "New"
        Me.btnNewCustomer.Id = 14
        Me.btnNewCustomer.LargeImageIndex = 5
        Me.btnNewCustomer.Name = "btnNewCustomer"
        '
        'btnProposalMap
        '
        Me.btnProposalMap.Caption = "Map"
        Me.btnProposalMap.Id = 15
        Me.btnProposalMap.LargeImageIndex = 8
        Me.btnProposalMap.Name = "btnProposalMap"
        '
        'btnExportProposal
        '
        Me.btnExportProposal.Caption = "Export"
        Me.btnExportProposal.Id = 16
        Me.btnExportProposal.LargeImageIndex = 9
        Me.btnExportProposal.Name = "btnExportProposal"
        '
        'btnReportProposal
        '
        Me.btnReportProposal.Caption = "Report"
        Me.btnReportProposal.Id = 17
        Me.btnReportProposal.LargeImageIndex = 12
        Me.btnReportProposal.Name = "btnReportProposal"
        '
        'btnNewUser
        '
        Me.btnNewUser.Caption = "New"
        Me.btnNewUser.Id = 19
        Me.btnNewUser.LargeImageIndex = 5
        Me.btnNewUser.Name = "btnNewUser"
        '
        'btnSettings
        '
        Me.btnSettings.Caption = "Settings"
        Me.btnSettings.Hint = "Settings"
        Me.btnSettings.Id = 20
        Me.btnSettings.ImageIndex = 6
        Me.btnSettings.Name = "btnSettings"
        '
        'btnNewVendor
        '
        Me.btnNewVendor.Caption = "New"
        Me.btnNewVendor.Id = 22
        Me.btnNewVendor.LargeImageIndex = 5
        Me.btnNewVendor.Name = "btnNewVendor"
        '
        'btnNew
        '
        Me.btnNew.Caption = "New"
        Me.btnNew.Id = 23
        Me.btnNew.LargeImageIndex = 5
        Me.btnNew.Name = "btnNew"
        '
        'btnRemoveCustomerLayout
        '
        Me.btnRemoveCustomerLayout.Caption = "Remove"
        Me.btnRemoveCustomerLayout.Id = 34
        Me.btnRemoveCustomerLayout.ImageIndex = 2
        Me.btnRemoveCustomerLayout.Name = "btnRemoveCustomerLayout"
        '
        'btnSaveContactLayout
        '
        Me.btnSaveContactLayout.Caption = "Save"
        Me.btnSaveContactLayout.Id = 35
        Me.btnSaveContactLayout.ImageIndex = 4
        Me.btnSaveContactLayout.Name = "btnSaveContactLayout"
        '
        'btnSaveUserLayout
        '
        Me.btnSaveUserLayout.Caption = "Save"
        Me.btnSaveUserLayout.Id = 36
        Me.btnSaveUserLayout.ImageIndex = 4
        Me.btnSaveUserLayout.Name = "btnSaveUserLayout"
        '
        'btnExportCustomer
        '
        Me.btnExportCustomer.Caption = "Export"
        Me.btnExportCustomer.Id = 39
        Me.btnExportCustomer.LargeImageIndex = 9
        Me.btnExportCustomer.Name = "btnExportCustomer"
        '
        'btnRemoveContactLayout
        '
        Me.btnRemoveContactLayout.Caption = "Remove"
        Me.btnRemoveContactLayout.Id = 42
        Me.btnRemoveContactLayout.ImageIndex = 2
        Me.btnRemoveContactLayout.Name = "btnRemoveContactLayout"
        '
        'btnRemoveUserLayout
        '
        Me.btnRemoveUserLayout.Caption = "Remove"
        Me.btnRemoveUserLayout.Id = 43
        Me.btnRemoveUserLayout.ImageIndex = 2
        Me.btnRemoveUserLayout.Name = "btnRemoveUserLayout"
        '
        'btnRemoveVendorLayout
        '
        Me.btnRemoveVendorLayout.Caption = "Remove"
        Me.btnRemoveVendorLayout.Id = 44
        Me.btnRemoveVendorLayout.ImageIndex = 2
        Me.btnRemoveVendorLayout.Name = "btnRemoveVendorLayout"
        '
        'btnExportUser
        '
        Me.btnExportUser.Caption = "Export"
        Me.btnExportUser.Id = 45
        Me.btnExportUser.LargeImageIndex = 9
        Me.btnExportUser.Name = "btnExportUser"
        '
        'btnExportContact
        '
        Me.btnExportContact.Caption = "Export"
        Me.btnExportContact.Id = 46
        Me.btnExportContact.LargeImageIndex = 9
        Me.btnExportContact.Name = "btnExportContact"
        '
        'btnExportVendor
        '
        Me.btnExportVendor.Caption = "Export"
        Me.btnExportVendor.Id = 47
        Me.btnExportVendor.LargeImageIndex = 9
        Me.btnExportVendor.Name = "btnExportVendor"
        '
        'btnReportContact
        '
        Me.btnReportContact.Caption = "Report"
        Me.btnReportContact.Id = 48
        Me.btnReportContact.Name = "btnReportContact"
        '
        'btnBrowseBrowse
        '
        Me.btnBrowseBrowse.Caption = "Browse"
        Me.btnBrowseBrowse.Id = 52
        Me.btnBrowseBrowse.ImageIndex = 7
        Me.btnBrowseBrowse.LargeImageIndex = 11
        Me.btnBrowseBrowse.Name = "btnBrowseBrowse"
        '
        'btnNewGroup
        '
        Me.btnNewGroup.Caption = "New"
        Me.btnNewGroup.Id = 53
        Me.btnNewGroup.ImageIndex = 6
        Me.btnNewGroup.LargeImageIndex = 5
        Me.btnNewGroup.Name = "btnNewGroup"
        '
        'cmboCustomerLayout
        '
        Me.cmboCustomerLayout.Caption = "Layout"
        Me.cmboCustomerLayout.Edit = Me.RICustomerLayouts
        Me.cmboCustomerLayout.Id = 56
        Me.cmboCustomerLayout.Name = "cmboCustomerLayout"
        Me.cmboCustomerLayout.Width = 100
        '
        'RICustomerLayouts
        '
        Me.RICustomerLayouts.AutoHeight = False
        Me.RICustomerLayouts.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RICustomerLayouts.Name = "RICustomerLayouts"
        '
        'cmboVendorLayout
        '
        Me.cmboVendorLayout.Caption = "Layout"
        Me.cmboVendorLayout.Edit = Me.RIVendorLayouts
        Me.cmboVendorLayout.Id = 57
        Me.cmboVendorLayout.Name = "cmboVendorLayout"
        Me.cmboVendorLayout.Width = 100
        '
        'RIVendorLayouts
        '
        Me.RIVendorLayouts.AutoHeight = False
        Me.RIVendorLayouts.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RIVendorLayouts.Name = "RIVendorLayouts"
        '
        'cmboContactLayout
        '
        Me.cmboContactLayout.Caption = "Layout"
        Me.cmboContactLayout.Edit = Me.RIContactLayouts
        Me.cmboContactLayout.Id = 58
        Me.cmboContactLayout.Name = "cmboContactLayout"
        Me.cmboContactLayout.Width = 100
        '
        'RIContactLayouts
        '
        Me.RIContactLayouts.AutoHeight = False
        Me.RIContactLayouts.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RIContactLayouts.Name = "RIContactLayouts"
        '
        'btnSaveCustomerLayout
        '
        Me.btnSaveCustomerLayout.Caption = "Save"
        Me.btnSaveCustomerLayout.Id = 59
        Me.btnSaveCustomerLayout.ImageIndex = 4
        Me.btnSaveCustomerLayout.Name = "btnSaveCustomerLayout"
        '
        'siSaveCustomerLayout
        '
        Me.siSaveCustomerLayout.Caption = "Save"
        Me.siSaveCustomerLayout.Id = 67
        Me.siSaveCustomerLayout.ImageIndex = 4
        Me.siSaveCustomerLayout.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnSaveCustomerLayout), New DevExpress.XtraBars.LinkPersistInfo(Me.btnSaveAsCustomerLayout)})
        Me.siSaveCustomerLayout.Name = "siSaveCustomerLayout"
        '
        'btnSaveAsCustomerLayout
        '
        Me.btnSaveAsCustomerLayout.Caption = "SaveAs"
        Me.btnSaveAsCustomerLayout.Id = 70
        Me.btnSaveAsCustomerLayout.ImageIndex = 5
        Me.btnSaveAsCustomerLayout.Name = "btnSaveAsCustomerLayout"
        '
        'siSaveVendor
        '
        Me.siSaveVendor.Caption = "Save"
        Me.siSaveVendor.Id = 71
        Me.siSaveVendor.ImageIndex = 4
        Me.siSaveVendor.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnSaveVendorLayout), New DevExpress.XtraBars.LinkPersistInfo(Me.btnSaveAsVendorLayout)})
        Me.siSaveVendor.Name = "siSaveVendor"
        '
        'btnSaveVendorLayout
        '
        Me.btnSaveVendorLayout.Caption = "Save"
        Me.btnSaveVendorLayout.Id = 75
        Me.btnSaveVendorLayout.ImageIndex = 4
        Me.btnSaveVendorLayout.Name = "btnSaveVendorLayout"
        '
        'btnSaveAsVendorLayout
        '
        Me.btnSaveAsVendorLayout.Caption = "SaveAs"
        Me.btnSaveAsVendorLayout.Id = 73
        Me.btnSaveAsVendorLayout.ImageIndex = 5
        Me.btnSaveAsVendorLayout.Name = "btnSaveAsVendorLayout"
        '
        'siSaveContact
        '
        Me.siSaveContact.Caption = "Save"
        Me.siSaveContact.Id = 72
        Me.siSaveContact.ImageIndex = 4
        Me.siSaveContact.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnSaveContactLayout), New DevExpress.XtraBars.LinkPersistInfo(Me.btnSaveAsContactLayout)})
        Me.siSaveContact.Name = "siSaveContact"
        '
        'btnSaveAsContactLayout
        '
        Me.btnSaveAsContactLayout.Caption = "SaveAs"
        Me.btnSaveAsContactLayout.Id = 74
        Me.btnSaveAsContactLayout.ImageIndex = 5
        Me.btnSaveAsContactLayout.Name = "btnSaveAsContactLayout"
        '
        'BarEditItem1
        '
        Me.BarEditItem1.Caption = "BarEditItem1"
        Me.BarEditItem1.Edit = Me.RepositoryItemComboBox1
        Me.BarEditItem1.Id = 78
        Me.BarEditItem1.Name = "BarEditItem1"
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'largeImages
        '
        Me.largeImages.ImageSize = New System.Drawing.Size(32, 32)
        Me.largeImages.ImageStream = CType(resources.GetObject("largeImages.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.largeImages.Images.SetKeyName(0, "Add.png")
        Me.largeImages.Images.SetKeyName(1, "Close.png")
        Me.largeImages.Images.SetKeyName(2, "Copy.png")
        Me.largeImages.Images.SetKeyName(3, "Delete.png")
        Me.largeImages.Images.SetKeyName(4, "Document.png")
        Me.largeImages.Images.SetKeyName(5, "New.png")
        Me.largeImages.Images.SetKeyName(6, "Save 2.png")
        Me.largeImages.Images.SetKeyName(7, "Undo.png")
        Me.largeImages.Images.SetKeyName(8, "ge.png")
        Me.largeImages.Images.SetKeyName(9, "Excel Icon.png")
        Me.largeImages.Images.SetKeyName(10, "New.png")
        Me.largeImages.Images.SetKeyName(11, "Folder.png")
        Me.largeImages.Images.SetKeyName(12, "Notepad.png")
        '
        'pageProposal
        '
        Me.pageProposal.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpgFileProposal, Me.rpgLayoutProposal, Me.rpgBrowse, Me.rpgMapProposal, Me.rpgReportProposal})
        Me.pageProposal.Name = "pageProposal"
        Me.pageProposal.Text = "Proposals"
        '
        'rpgFileProposal
        '
        Me.rpgFileProposal.ItemLinks.Add(Me.btnNewProposal)
        Me.rpgFileProposal.Name = "rpgFileProposal"
        Me.rpgFileProposal.ShowCaptionButton = False
        Me.rpgFileProposal.Text = "File"
        '
        'rpgLayoutProposal
        '
        Me.rpgLayoutProposal.ItemLinks.Add(Me.cmboProposalLayout)
        Me.rpgLayoutProposal.ItemLinks.Add(Me.siSaveProposalLayout)
        Me.rpgLayoutProposal.ItemLinks.Add(Me.btnRemoveProposalLayout)
        Me.rpgLayoutProposal.Name = "rpgLayoutProposal"
        Me.rpgLayoutProposal.ShowCaptionButton = False
        Me.rpgLayoutProposal.Text = "Layout"
        '
        'rpgBrowse
        '
        Me.rpgBrowse.ItemLinks.Add(Me.btnBrowseBrowse)
        Me.rpgBrowse.Name = "rpgBrowse"
        Me.rpgBrowse.ShowCaptionButton = False
        Me.rpgBrowse.Text = "Browse"
        '
        'rpgMapProposal
        '
        Me.rpgMapProposal.ItemLinks.Add(Me.btnProposalMap)
        Me.rpgMapProposal.Name = "rpgMapProposal"
        Me.rpgMapProposal.ShowCaptionButton = False
        Me.rpgMapProposal.Text = "Map"
        '
        'rpgReportProposal
        '
        Me.rpgReportProposal.ItemLinks.Add(Me.btnExportProposal)
        Me.rpgReportProposal.ItemLinks.Add(Me.btnReportProposal)
        Me.rpgReportProposal.Name = "rpgReportProposal"
        Me.rpgReportProposal.ShowCaptionButton = False
        Me.rpgReportProposal.Text = "Reports"
        '
        'pageCustomer
        '
        Me.pageCustomer.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpgFileCustomer, Me.rpgReportCustomer, Me.rpgLayout})
        Me.pageCustomer.Name = "pageCustomer"
        Me.pageCustomer.Text = "Customers"
        '
        'rpgFileCustomer
        '
        Me.rpgFileCustomer.ItemLinks.Add(Me.btnNewCustomer)
        Me.rpgFileCustomer.Name = "rpgFileCustomer"
        Me.rpgFileCustomer.ShowCaptionButton = False
        Me.rpgFileCustomer.Text = "File"
        '
        'rpgReportCustomer
        '
        Me.rpgReportCustomer.ItemLinks.Add(Me.btnExportCustomer)
        Me.rpgReportCustomer.Name = "rpgReportCustomer"
        Me.rpgReportCustomer.ShowCaptionButton = False
        Me.rpgReportCustomer.Text = "Reports"
        '
        'rpgLayout
        '
        Me.rpgLayout.ItemLinks.Add(Me.cmboCustomerLayout)
        Me.rpgLayout.ItemLinks.Add(Me.siSaveCustomerLayout)
        Me.rpgLayout.ItemLinks.Add(Me.btnRemoveCustomerLayout)
        Me.rpgLayout.Name = "rpgLayout"
        Me.rpgLayout.ShowCaptionButton = False
        Me.rpgLayout.Text = "Layout"
        Me.rpgLayout.Visible = False
        '
        'pageVendor
        '
        Me.pageVendor.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpgFileVendor, Me.rpgReportVendor, Me.rpgLayoutVendor})
        Me.pageVendor.Name = "pageVendor"
        Me.pageVendor.Text = "Vendors"
        '
        'rpgFileVendor
        '
        Me.rpgFileVendor.ItemLinks.Add(Me.btnNewVendor)
        Me.rpgFileVendor.Name = "rpgFileVendor"
        Me.rpgFileVendor.ShowCaptionButton = False
        Me.rpgFileVendor.Text = "File"
        '
        'rpgReportVendor
        '
        Me.rpgReportVendor.ItemLinks.Add(Me.btnExportVendor)
        Me.rpgReportVendor.Name = "rpgReportVendor"
        Me.rpgReportVendor.ShowCaptionButton = False
        Me.rpgReportVendor.Text = "Reports"
        '
        'rpgLayoutVendor
        '
        Me.rpgLayoutVendor.ItemLinks.Add(Me.cmboVendorLayout)
        Me.rpgLayoutVendor.ItemLinks.Add(Me.siSaveVendor)
        Me.rpgLayoutVendor.ItemLinks.Add(Me.btnRemoveVendorLayout)
        Me.rpgLayoutVendor.Name = "rpgLayoutVendor"
        Me.rpgLayoutVendor.ShowCaptionButton = False
        Me.rpgLayoutVendor.Text = "Layout"
        Me.rpgLayoutVendor.Visible = False
        '
        'pageContact
        '
        Me.pageContact.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpgFileContact, Me.rpgReportContact, Me.rpgLayoutContact})
        Me.pageContact.Name = "pageContact"
        Me.pageContact.Text = "Contacts"
        '
        'rpgFileContact
        '
        Me.rpgFileContact.ItemLinks.Add(Me.btnNew)
        Me.rpgFileContact.Name = "rpgFileContact"
        Me.rpgFileContact.ShowCaptionButton = False
        Me.rpgFileContact.Text = "File"
        '
        'rpgReportContact
        '
        Me.rpgReportContact.ItemLinks.Add(Me.btnExportContact)
        Me.rpgReportContact.Name = "rpgReportContact"
        Me.rpgReportContact.ShowCaptionButton = False
        Me.rpgReportContact.Text = "Reports"
        '
        'rpgLayoutContact
        '
        Me.rpgLayoutContact.ItemLinks.Add(Me.cmboContactLayout)
        Me.rpgLayoutContact.ItemLinks.Add(Me.siSaveContact)
        Me.rpgLayoutContact.ItemLinks.Add(Me.btnRemoveContactLayout)
        Me.rpgLayoutContact.Name = "rpgLayoutContact"
        Me.rpgLayoutContact.ShowCaptionButton = False
        Me.rpgLayoutContact.Text = "Layout"
        Me.rpgLayoutContact.Visible = False
        '
        'pageUser
        '
        Me.pageUser.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpgFileUser, Me.rpgReportUser})
        Me.pageUser.Name = "pageUser"
        Me.pageUser.Text = "Users"
        '
        'rpgFileUser
        '
        Me.rpgFileUser.ItemLinks.Add(Me.btnNewUser)
        Me.rpgFileUser.Name = "rpgFileUser"
        Me.rpgFileUser.ShowCaptionButton = False
        Me.rpgFileUser.Text = "File"
        '
        'rpgReportUser
        '
        Me.rpgReportUser.ItemLinks.Add(Me.btnExportUser)
        Me.rpgReportUser.Name = "rpgReportUser"
        Me.rpgReportUser.ShowCaptionButton = False
        Me.rpgReportUser.Text = "Reports"
        '
        'pageGroup
        '
        Me.pageGroup.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpgNew})
        Me.pageGroup.Name = "pageGroup"
        Me.pageGroup.Text = "Group"
        '
        'rpgNew
        '
        Me.rpgNew.ItemLinks.Add(Me.btnNewGroup)
        Me.rpgNew.Name = "rpgNew"
        Me.rpgNew.ShowCaptionButton = False
        Me.rpgNew.Text = "New"
        '
        'RepositoryItemButtonEdit1
        '
        Me.RepositoryItemButtonEdit1.AutoHeight = False
        Me.RepositoryItemButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemButtonEdit1.Name = "RepositoryItemButtonEdit1"
        '
        'RepositoryItemComboBox3
        '
        Me.RepositoryItemComboBox3.AutoHeight = False
        Me.RepositoryItemComboBox3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox3.Name = "RepositoryItemComboBox3"
        '
        'RepositoryItemComboBox4
        '
        Me.RepositoryItemComboBox4.AutoHeight = False
        Me.RepositoryItemComboBox4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox4.Name = "RepositoryItemComboBox4"
        '
        'RepositoryItemImageComboBox1
        '
        Me.RepositoryItemImageComboBox1.AutoHeight = False
        Me.RepositoryItemImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemImageComboBox1.Name = "RepositoryItemImageComboBox1"
        '
        'RepositoryItemComboBox2
        '
        Me.RepositoryItemComboBox2.AutoHeight = False
        Me.RepositoryItemComboBox2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox2.Name = "RepositoryItemComboBox2"
        '
        'RepositoryItemImageComboBox2
        '
        Me.RepositoryItemImageComboBox2.AutoHeight = False
        Me.RepositoryItemImageComboBox2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemImageComboBox2.Name = "RepositoryItemImageComboBox2"
        '
        'ClientPanel
        '
        Me.ClientPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.ClientPanel.Controls.Add(Me.tabPages)
        Me.ClientPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ClientPanel.Location = New System.Drawing.Point(0, 145)
        Me.ClientPanel.LookAndFeel.SkinName = "Seven Classic"
        Me.ClientPanel.Name = "ClientPanel"
        Me.ClientPanel.Size = New System.Drawing.Size(1131, 422)
        Me.ClientPanel.TabIndex = 2
        '
        'tabPages
        '
        Me.tabPages.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabPages.Location = New System.Drawing.Point(0, 0)
        Me.tabPages.Name = "tabPages"
        Me.tabPages.SelectedTabPage = Me.tabProposal
        Me.tabPages.Size = New System.Drawing.Size(1131, 422)
        Me.tabPages.TabIndex = 0
        Me.tabPages.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabProposal, Me.Customers, Me.Users, Me.Vendors, Me.Contacts, Me.tabGroup})
        '
        'tabProposal
        '
        Me.tabProposal.Controls.Add(Me.GridProposals)
        Me.tabProposal.Name = "tabProposal"
        Me.tabProposal.Size = New System.Drawing.Size(1125, 394)
        Me.tabProposal.Text = "Proposals"
        '
        'GridProposals
        '
        Me.GridProposals.DataSource = Me.SpGetProposalsBindingSource
        Me.GridProposals.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridProposals.Location = New System.Drawing.Point(0, 0)
        Me.GridProposals.LookAndFeel.SkinName = "Seven Classic"
        Me.GridProposals.MainView = Me.gridViewProposal
        Me.GridProposals.MenuManager = Me.RibbonControl
        Me.GridProposals.Name = "GridProposals"
        Me.GridProposals.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemImageComboBox3, Me.RepositoryItemImageComboBox4})
        Me.GridProposals.Size = New System.Drawing.Size(1125, 394)
        Me.GridProposals.TabIndex = 0
        Me.GridProposals.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridViewProposal})
        '
        'SpGetProposalsBindingSource
        '
        Me.SpGetProposalsBindingSource.DataMember = "spGetProposals"
        Me.SpGetProposalsBindingSource.DataSource = Me.DsErcoView2
        '
        'DsErcoView2
        '
        Me.DsErcoView2.DataSetName = "dsErcoView"
        Me.DsErcoView2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gridViewProposal
        '
        Me.gridViewProposal.Appearance.EvenRow.BackColor = System.Drawing.Color.WhiteSmoke
        Me.gridViewProposal.Appearance.EvenRow.Options.UseBackColor = True
        Me.gridViewProposal.AppearancePrint.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.gridViewProposal.AppearancePrint.EvenRow.BackColor2 = System.Drawing.Color.Gray
        Me.gridViewProposal.AppearancePrint.EvenRow.Options.UseBackColor = True
        Me.gridViewProposal.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPROPOSAL_ID, Me.colPROPOSAL_NUMBER, Me.colJOB_NUMBER, Me.colJOB_TYPE_TEXT, Me.colSBS_COMPANY, Me.colCUSTOMER_TEXT, Me.colCONTACT_TEXT, Me.colVENDOR_TEXT, Me.coljob_type_misc, Me.colSALESMAN_TEXT, Me.colSUPER_TEXT, Me.colENTERED_BY, Me.colDATE_ENTERED, Me.colDATE_COMPLETED, Me.colDATE_NOR, Me.colDATE_PROPOSAL, Me.coldate_updated, Me.colupdated_by, Me.colDESCRIPTION, Me.colCOMMENTS, Me.colBODY_OF_WATER, Me.colDRIVING_DIRECTIONS, Me.colSTATUS, Me.colCITY, Me.colCOUNTY, Me.colSTATE, Me.colGPS_N, Me.colGPS_W, Me.colMILE_POINT, Me.colLINE_NUMBER, Me.colDISTRICT, Me.colCONTRACT_NO, Me.colWORK_ORDER_NO, Me.colPRICE_PROPOSAL, Me.colPRICE_PERMIT, Me.colPRICE_EXTRA, Me.colPRICE_ACTUAL, Me.colPERMIT_COST, Me.colPRICE_TOTAL, Me.colPROFIT, Me.colONE_CALL_TICKET_NO, Me.colONE_CALL_START_DATE, Me.colONE_CALL_TICKET_START_TIME, Me.colONE_CALL_EXPERATION_DATE, Me.colESTIMATED_COST, Me.colESTIMATED_MARGIN, Me.colPERMITS, Me.colFIELD_CONTACT, Me.colPIPE_DIAMETER, Me.colWATER_COURSE_DESC, Me.colSPECIFIC_PERMIT_ISSUES, Me.colCONSTRUCTION_ISSUES, Me.colPRIORITY, Me.colPRIORITY_DESCRIPTION, Me.colADDITIONAL_WORK, Me.colADDITIONAL_WORK_COMMENT, Me.colSTATUS_COMMENT, Me.colPERMIT_STATUS, Me.colCONTRACT_STATUS, Me.colAREA_HOTEL, Me.colNOTES, Me.colPROPOSAL_STATUS, Me.colJOB_STATUS_COMMENTS, Me.colACTIVE_STATUS, Me.colENTERED_BY_TEXT, Me.colUPDATED_BY_TEXT, Me.colconst_month, Me.colconst_year, Me.colGROUP_TEXT2, Me.coljob_status})
        StyleFormatCondition1.Column = Me.colADDITIONAL_WORK
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition1.Value1 = "True"
        Me.gridViewProposal.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
        Me.gridViewProposal.GridControl = Me.GridProposals
        Me.gridViewProposal.Name = "gridViewProposal"
        Me.gridViewProposal.OptionsBehavior.Editable = False
        Me.gridViewProposal.OptionsSelection.MultiSelect = True
        Me.gridViewProposal.OptionsSelection.UseIndicatorForSelection = False
        Me.gridViewProposal.OptionsView.ColumnAutoWidth = False
        Me.gridViewProposal.OptionsView.EnableAppearanceEvenRow = True
        Me.gridViewProposal.OptionsView.ShowAutoFilterRow = True
        Me.gridViewProposal.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colPROPOSAL_NUMBER, DevExpress.Data.ColumnSortOrder.Descending)})
        '
        'colPROPOSAL_ID
        '
        Me.colPROPOSAL_ID.Caption = "Proposal ID"
        Me.colPROPOSAL_ID.FieldName = "PROPOSAL_ID"
        Me.colPROPOSAL_ID.Name = "colPROPOSAL_ID"
        Me.colPROPOSAL_ID.OptionsColumn.ReadOnly = True
        Me.colPROPOSAL_ID.Visible = True
        Me.colPROPOSAL_ID.VisibleIndex = 0
        '
        'colPROPOSAL_NUMBER
        '
        Me.colPROPOSAL_NUMBER.Caption = "Proposal No"
        Me.colPROPOSAL_NUMBER.FieldName = "PROPOSAL_NUMBER"
        Me.colPROPOSAL_NUMBER.Name = "colPROPOSAL_NUMBER"
        Me.colPROPOSAL_NUMBER.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colPROPOSAL_NUMBER.Visible = True
        Me.colPROPOSAL_NUMBER.VisibleIndex = 1
        '
        'colJOB_NUMBER
        '
        Me.colJOB_NUMBER.Caption = "Job No"
        Me.colJOB_NUMBER.FieldName = "JOB_NUMBER"
        Me.colJOB_NUMBER.Name = "colJOB_NUMBER"
        Me.colJOB_NUMBER.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colJOB_NUMBER.Visible = True
        Me.colJOB_NUMBER.VisibleIndex = 2
        '
        'colJOB_TYPE_TEXT
        '
        Me.colJOB_TYPE_TEXT.Caption = "Job Type"
        Me.colJOB_TYPE_TEXT.FieldName = "JOB_TYPE_TEXT"
        Me.colJOB_TYPE_TEXT.Name = "colJOB_TYPE_TEXT"
        Me.colJOB_TYPE_TEXT.OptionsColumn.ReadOnly = True
        Me.colJOB_TYPE_TEXT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colJOB_TYPE_TEXT.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colJOB_TYPE_TEXT.Visible = True
        Me.colJOB_TYPE_TEXT.VisibleIndex = 3
        '
        'colSBS_COMPANY
        '
        Me.colSBS_COMPANY.Caption = "SBS Company"
        Me.colSBS_COMPANY.FieldName = "SBS_COMPANY"
        Me.colSBS_COMPANY.Name = "colSBS_COMPANY"
        Me.colSBS_COMPANY.Visible = True
        Me.colSBS_COMPANY.VisibleIndex = 69
        '
        'colCUSTOMER_TEXT
        '
        Me.colCUSTOMER_TEXT.Caption = "Customer"
        Me.colCUSTOMER_TEXT.FieldName = "CUSTOMER_TEXT"
        Me.colCUSTOMER_TEXT.Name = "colCUSTOMER_TEXT"
        Me.colCUSTOMER_TEXT.OptionsColumn.ReadOnly = True
        Me.colCUSTOMER_TEXT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colCUSTOMER_TEXT.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colCUSTOMER_TEXT.Visible = True
        Me.colCUSTOMER_TEXT.VisibleIndex = 4
        '
        'colCONTACT_TEXT
        '
        Me.colCONTACT_TEXT.Caption = "Contact"
        Me.colCONTACT_TEXT.FieldName = "CONTACT_TEXT"
        Me.colCONTACT_TEXT.Name = "colCONTACT_TEXT"
        Me.colCONTACT_TEXT.OptionsColumn.ReadOnly = True
        Me.colCONTACT_TEXT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colCONTACT_TEXT.Visible = True
        Me.colCONTACT_TEXT.VisibleIndex = 5
        '
        'colVENDOR_TEXT
        '
        Me.colVENDOR_TEXT.Caption = "Vendor"
        Me.colVENDOR_TEXT.FieldName = "VENDOR_TEXT"
        Me.colVENDOR_TEXT.Name = "colVENDOR_TEXT"
        Me.colVENDOR_TEXT.OptionsColumn.ReadOnly = True
        Me.colVENDOR_TEXT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colVENDOR_TEXT.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colVENDOR_TEXT.Visible = True
        Me.colVENDOR_TEXT.VisibleIndex = 6
        '
        'coljob_type_misc
        '
        Me.coljob_type_misc.Caption = "Job Type Desc"
        Me.coljob_type_misc.FieldName = "job_type_misc"
        Me.coljob_type_misc.Name = "coljob_type_misc"
        Me.coljob_type_misc.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.coljob_type_misc.Visible = True
        Me.coljob_type_misc.VisibleIndex = 7
        '
        'colSALESMAN_TEXT
        '
        Me.colSALESMAN_TEXT.Caption = "Salesman"
        Me.colSALESMAN_TEXT.FieldName = "SALESMAN_TEXT"
        Me.colSALESMAN_TEXT.Name = "colSALESMAN_TEXT"
        Me.colSALESMAN_TEXT.OptionsColumn.ReadOnly = True
        Me.colSALESMAN_TEXT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colSALESMAN_TEXT.Visible = True
        Me.colSALESMAN_TEXT.VisibleIndex = 8
        '
        'colSUPER_TEXT
        '
        Me.colSUPER_TEXT.Caption = "Superintendent "
        Me.colSUPER_TEXT.FieldName = "SUPER_TEXT"
        Me.colSUPER_TEXT.Name = "colSUPER_TEXT"
        Me.colSUPER_TEXT.OptionsColumn.ReadOnly = True
        Me.colSUPER_TEXT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colSUPER_TEXT.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colSUPER_TEXT.Visible = True
        Me.colSUPER_TEXT.VisibleIndex = 9
        Me.colSUPER_TEXT.Width = 98
        '
        'colENTERED_BY
        '
        Me.colENTERED_BY.Caption = "Entered By"
        Me.colENTERED_BY.FieldName = "ENTERED_BY"
        Me.colENTERED_BY.Name = "colENTERED_BY"
        Me.colENTERED_BY.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colENTERED_BY.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colENTERED_BY.Visible = True
        Me.colENTERED_BY.VisibleIndex = 10
        '
        'colDATE_ENTERED
        '
        Me.colDATE_ENTERED.Caption = "Date Entered"
        Me.colDATE_ENTERED.FieldName = "DATE_ENTERED"
        Me.colDATE_ENTERED.Name = "colDATE_ENTERED"
        Me.colDATE_ENTERED.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Date]
        Me.colDATE_ENTERED.OptionsFilter.ShowEmptyDateFilter = True
        Me.colDATE_ENTERED.Visible = True
        Me.colDATE_ENTERED.VisibleIndex = 11
        '
        'colDATE_COMPLETED
        '
        Me.colDATE_COMPLETED.Caption = "Date Completed"
        Me.colDATE_COMPLETED.FieldName = "DATE_COMPLETED"
        Me.colDATE_COMPLETED.Name = "colDATE_COMPLETED"
        Me.colDATE_COMPLETED.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Date]
        Me.colDATE_COMPLETED.OptionsFilter.ShowEmptyDateFilter = True
        Me.colDATE_COMPLETED.Visible = True
        Me.colDATE_COMPLETED.VisibleIndex = 12
        '
        'colDATE_NOR
        '
        Me.colDATE_NOR.Caption = "NOR Date"
        Me.colDATE_NOR.FieldName = "DATE_NOR"
        Me.colDATE_NOR.Name = "colDATE_NOR"
        Me.colDATE_NOR.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Date]
        Me.colDATE_NOR.OptionsFilter.ShowEmptyDateFilter = True
        Me.colDATE_NOR.Visible = True
        Me.colDATE_NOR.VisibleIndex = 13
        '
        'colDATE_PROPOSAL
        '
        Me.colDATE_PROPOSAL.Caption = "Proposal Date"
        Me.colDATE_PROPOSAL.FieldName = "DATE_PROPOSAL"
        Me.colDATE_PROPOSAL.Name = "colDATE_PROPOSAL"
        Me.colDATE_PROPOSAL.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Date]
        Me.colDATE_PROPOSAL.OptionsFilter.ShowEmptyDateFilter = True
        Me.colDATE_PROPOSAL.Visible = True
        Me.colDATE_PROPOSAL.VisibleIndex = 14
        '
        'coldate_updated
        '
        Me.coldate_updated.Caption = "Date Updated"
        Me.coldate_updated.FieldName = "date_updated"
        Me.coldate_updated.Name = "coldate_updated"
        Me.coldate_updated.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Date]
        Me.coldate_updated.OptionsFilter.ShowEmptyDateFilter = True
        Me.coldate_updated.Visible = True
        Me.coldate_updated.VisibleIndex = 15
        '
        'colupdated_by
        '
        Me.colupdated_by.Caption = "Updated By"
        Me.colupdated_by.FieldName = "updated_by"
        Me.colupdated_by.Name = "colupdated_by"
        Me.colupdated_by.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colupdated_by.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colupdated_by.Visible = True
        Me.colupdated_by.VisibleIndex = 16
        '
        'colDESCRIPTION
        '
        Me.colDESCRIPTION.Caption = "Description"
        Me.colDESCRIPTION.FieldName = "DESCRIPTION"
        Me.colDESCRIPTION.Name = "colDESCRIPTION"
        Me.colDESCRIPTION.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colDESCRIPTION.Visible = True
        Me.colDESCRIPTION.VisibleIndex = 17
        '
        'colCOMMENTS
        '
        Me.colCOMMENTS.Caption = "Comments"
        Me.colCOMMENTS.FieldName = "COMMENTS"
        Me.colCOMMENTS.Name = "colCOMMENTS"
        Me.colCOMMENTS.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colCOMMENTS.Visible = True
        Me.colCOMMENTS.VisibleIndex = 18
        '
        'colBODY_OF_WATER
        '
        Me.colBODY_OF_WATER.Caption = "Body of Water"
        Me.colBODY_OF_WATER.FieldName = "BODY_OF_WATER"
        Me.colBODY_OF_WATER.Name = "colBODY_OF_WATER"
        Me.colBODY_OF_WATER.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colBODY_OF_WATER.Visible = True
        Me.colBODY_OF_WATER.VisibleIndex = 19
        '
        'colDRIVING_DIRECTIONS
        '
        Me.colDRIVING_DIRECTIONS.Caption = "Driving Directions"
        Me.colDRIVING_DIRECTIONS.FieldName = "DRIVING_DIRECTIONS"
        Me.colDRIVING_DIRECTIONS.Name = "colDRIVING_DIRECTIONS"
        Me.colDRIVING_DIRECTIONS.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colDRIVING_DIRECTIONS.Visible = True
        Me.colDRIVING_DIRECTIONS.VisibleIndex = 20
        '
        'colSTATUS
        '
        Me.colSTATUS.Caption = "Const Sched Status"
        Me.colSTATUS.FieldName = "STATUS"
        Me.colSTATUS.Name = "colSTATUS"
        Me.colSTATUS.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colSTATUS.Visible = True
        Me.colSTATUS.VisibleIndex = 21
        '
        'colCITY
        '
        Me.colCITY.Caption = "City"
        Me.colCITY.FieldName = "CITY"
        Me.colCITY.Name = "colCITY"
        Me.colCITY.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colCITY.Visible = True
        Me.colCITY.VisibleIndex = 22
        '
        'colCOUNTY
        '
        Me.colCOUNTY.Caption = "County"
        Me.colCOUNTY.FieldName = "COUNTY"
        Me.colCOUNTY.Name = "colCOUNTY"
        Me.colCOUNTY.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colCOUNTY.Visible = True
        Me.colCOUNTY.VisibleIndex = 23
        '
        'colSTATE
        '
        Me.colSTATE.Caption = "State"
        Me.colSTATE.FieldName = "STATE"
        Me.colSTATE.Name = "colSTATE"
        Me.colSTATE.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colSTATE.Visible = True
        Me.colSTATE.VisibleIndex = 24
        '
        'colGPS_N
        '
        Me.colGPS_N.Caption = "GPS N"
        Me.colGPS_N.FieldName = "GPS_N"
        Me.colGPS_N.Name = "colGPS_N"
        Me.colGPS_N.Visible = True
        Me.colGPS_N.VisibleIndex = 25
        '
        'colGPS_W
        '
        Me.colGPS_W.Caption = "GPS W"
        Me.colGPS_W.FieldName = "GPS_W"
        Me.colGPS_W.Name = "colGPS_W"
        Me.colGPS_W.Visible = True
        Me.colGPS_W.VisibleIndex = 26
        '
        'colMILE_POINT
        '
        Me.colMILE_POINT.Caption = "Mile Point"
        Me.colMILE_POINT.FieldName = "MILE_POINT"
        Me.colMILE_POINT.Name = "colMILE_POINT"
        Me.colMILE_POINT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colMILE_POINT.Visible = True
        Me.colMILE_POINT.VisibleIndex = 27
        '
        'colLINE_NUMBER
        '
        Me.colLINE_NUMBER.Caption = "Line Number"
        Me.colLINE_NUMBER.FieldName = "LINE_NUMBER"
        Me.colLINE_NUMBER.Name = "colLINE_NUMBER"
        Me.colLINE_NUMBER.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colLINE_NUMBER.Visible = True
        Me.colLINE_NUMBER.VisibleIndex = 28
        '
        'colDISTRICT
        '
        Me.colDISTRICT.Caption = "District"
        Me.colDISTRICT.FieldName = "DISTRICT"
        Me.colDISTRICT.Name = "colDISTRICT"
        Me.colDISTRICT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colDISTRICT.Visible = True
        Me.colDISTRICT.VisibleIndex = 29
        '
        'colCONTRACT_NO
        '
        Me.colCONTRACT_NO.Caption = "Contract No"
        Me.colCONTRACT_NO.FieldName = "CONTRACT_NO"
        Me.colCONTRACT_NO.Name = "colCONTRACT_NO"
        Me.colCONTRACT_NO.Visible = True
        Me.colCONTRACT_NO.VisibleIndex = 30
        '
        'colWORK_ORDER_NO
        '
        Me.colWORK_ORDER_NO.Caption = "Work Order No"
        Me.colWORK_ORDER_NO.FieldName = "WORK_ORDER_NO"
        Me.colWORK_ORDER_NO.Name = "colWORK_ORDER_NO"
        Me.colWORK_ORDER_NO.Visible = True
        Me.colWORK_ORDER_NO.VisibleIndex = 31
        '
        'colPRICE_PROPOSAL
        '
        Me.colPRICE_PROPOSAL.Caption = "Proposal Price"
        Me.colPRICE_PROPOSAL.FieldName = "PRICE_PROPOSAL"
        Me.colPRICE_PROPOSAL.Name = "colPRICE_PROPOSAL"
        Me.colPRICE_PROPOSAL.Visible = True
        Me.colPRICE_PROPOSAL.VisibleIndex = 32
        '
        'colPRICE_PERMIT
        '
        Me.colPRICE_PERMIT.Caption = "Permit Price"
        Me.colPRICE_PERMIT.FieldName = "PRICE_PERMIT"
        Me.colPRICE_PERMIT.Name = "colPRICE_PERMIT"
        Me.colPRICE_PERMIT.Visible = True
        Me.colPRICE_PERMIT.VisibleIndex = 33
        '
        'colPRICE_EXTRA
        '
        Me.colPRICE_EXTRA.Caption = "Extras Price"
        Me.colPRICE_EXTRA.FieldName = "PRICE_EXTRA"
        Me.colPRICE_EXTRA.Name = "colPRICE_EXTRA"
        Me.colPRICE_EXTRA.Visible = True
        Me.colPRICE_EXTRA.VisibleIndex = 34
        '
        'colPRICE_ACTUAL
        '
        Me.colPRICE_ACTUAL.Caption = "Actual Price"
        Me.colPRICE_ACTUAL.FieldName = "PRICE_ACTUAL"
        Me.colPRICE_ACTUAL.Name = "colPRICE_ACTUAL"
        Me.colPRICE_ACTUAL.Visible = True
        Me.colPRICE_ACTUAL.VisibleIndex = 35
        '
        'colPERMIT_COST
        '
        Me.colPERMIT_COST.Caption = "Permit Cost"
        Me.colPERMIT_COST.FieldName = "PERMIT_COST"
        Me.colPERMIT_COST.Name = "colPERMIT_COST"
        Me.colPERMIT_COST.Visible = True
        Me.colPERMIT_COST.VisibleIndex = 36
        '
        'colPRICE_TOTAL
        '
        Me.colPRICE_TOTAL.Caption = "Total Price"
        Me.colPRICE_TOTAL.FieldName = "PRICE_TOTAL"
        Me.colPRICE_TOTAL.Name = "colPRICE_TOTAL"
        Me.colPRICE_TOTAL.OptionsColumn.ReadOnly = True
        Me.colPRICE_TOTAL.Visible = True
        Me.colPRICE_TOTAL.VisibleIndex = 37
        '
        'colPROFIT
        '
        Me.colPROFIT.Caption = "Profit"
        Me.colPROFIT.FieldName = "PROFIT"
        Me.colPROFIT.Name = "colPROFIT"
        Me.colPROFIT.OptionsColumn.ReadOnly = True
        Me.colPROFIT.Visible = True
        Me.colPROFIT.VisibleIndex = 38
        '
        'colONE_CALL_TICKET_NO
        '
        Me.colONE_CALL_TICKET_NO.Caption = "One Call Ticket No"
        Me.colONE_CALL_TICKET_NO.FieldName = "ONE_CALL_TICKET_NO"
        Me.colONE_CALL_TICKET_NO.Name = "colONE_CALL_TICKET_NO"
        Me.colONE_CALL_TICKET_NO.Visible = True
        Me.colONE_CALL_TICKET_NO.VisibleIndex = 39
        '
        'colONE_CALL_START_DATE
        '
        Me.colONE_CALL_START_DATE.Caption = "One Call Start Date"
        Me.colONE_CALL_START_DATE.FieldName = "ONE_CALL_START_DATE"
        Me.colONE_CALL_START_DATE.Name = "colONE_CALL_START_DATE"
        Me.colONE_CALL_START_DATE.Visible = True
        Me.colONE_CALL_START_DATE.VisibleIndex = 41
        '
        'colONE_CALL_TICKET_START_TIME
        '
        Me.colONE_CALL_TICKET_START_TIME.Caption = "Once Call Start Time"
        Me.colONE_CALL_TICKET_START_TIME.FieldName = "ONE_CALL_TICKET_START_TIME"
        Me.colONE_CALL_TICKET_START_TIME.Name = "colONE_CALL_TICKET_START_TIME"
        Me.colONE_CALL_TICKET_START_TIME.Visible = True
        Me.colONE_CALL_TICKET_START_TIME.VisibleIndex = 40
        '
        'colONE_CALL_EXPERATION_DATE
        '
        Me.colONE_CALL_EXPERATION_DATE.Caption = "One Call Experation Date"
        Me.colONE_CALL_EXPERATION_DATE.FieldName = "ONE_CALL_EXPERATION_DATE"
        Me.colONE_CALL_EXPERATION_DATE.Name = "colONE_CALL_EXPERATION_DATE"
        Me.colONE_CALL_EXPERATION_DATE.Visible = True
        Me.colONE_CALL_EXPERATION_DATE.VisibleIndex = 42
        '
        'colESTIMATED_COST
        '
        Me.colESTIMATED_COST.Caption = "Estimated Cost"
        Me.colESTIMATED_COST.FieldName = "ESTIMATED_COST"
        Me.colESTIMATED_COST.Name = "colESTIMATED_COST"
        Me.colESTIMATED_COST.Visible = True
        Me.colESTIMATED_COST.VisibleIndex = 43
        '
        'colESTIMATED_MARGIN
        '
        Me.colESTIMATED_MARGIN.Caption = "Estimated Margin"
        Me.colESTIMATED_MARGIN.FieldName = "ESTIMATED_MARGIN"
        Me.colESTIMATED_MARGIN.Name = "colESTIMATED_MARGIN"
        Me.colESTIMATED_MARGIN.Visible = True
        Me.colESTIMATED_MARGIN.VisibleIndex = 44
        '
        'colPERMITS
        '
        Me.colPERMITS.Caption = "Permits"
        Me.colPERMITS.FieldName = "PERMITS"
        Me.colPERMITS.Name = "colPERMITS"
        Me.colPERMITS.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colPERMITS.Visible = True
        Me.colPERMITS.VisibleIndex = 45
        '
        'colFIELD_CONTACT
        '
        Me.colFIELD_CONTACT.Caption = "Field Contact"
        Me.colFIELD_CONTACT.FieldName = "FIELD_CONTACT"
        Me.colFIELD_CONTACT.Name = "colFIELD_CONTACT"
        Me.colFIELD_CONTACT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colFIELD_CONTACT.Visible = True
        Me.colFIELD_CONTACT.VisibleIndex = 46
        '
        'colPIPE_DIAMETER
        '
        Me.colPIPE_DIAMETER.Caption = "Pipe Diameter"
        Me.colPIPE_DIAMETER.FieldName = "PIPE_DIAMETER"
        Me.colPIPE_DIAMETER.Name = "colPIPE_DIAMETER"
        Me.colPIPE_DIAMETER.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colPIPE_DIAMETER.Visible = True
        Me.colPIPE_DIAMETER.VisibleIndex = 47
        '
        'colWATER_COURSE_DESC
        '
        Me.colWATER_COURSE_DESC.Caption = "Water Course Desc"
        Me.colWATER_COURSE_DESC.FieldName = "WATER_COURSE_DESC"
        Me.colWATER_COURSE_DESC.Name = "colWATER_COURSE_DESC"
        Me.colWATER_COURSE_DESC.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colWATER_COURSE_DESC.Visible = True
        Me.colWATER_COURSE_DESC.VisibleIndex = 48
        '
        'colSPECIFIC_PERMIT_ISSUES
        '
        Me.colSPECIFIC_PERMIT_ISSUES.Caption = "Specific Permit Issues"
        Me.colSPECIFIC_PERMIT_ISSUES.FieldName = "SPECIFIC_PERMIT_ISSUES"
        Me.colSPECIFIC_PERMIT_ISSUES.Name = "colSPECIFIC_PERMIT_ISSUES"
        Me.colSPECIFIC_PERMIT_ISSUES.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colSPECIFIC_PERMIT_ISSUES.Visible = True
        Me.colSPECIFIC_PERMIT_ISSUES.VisibleIndex = 49
        '
        'colCONSTRUCTION_ISSUES
        '
        Me.colCONSTRUCTION_ISSUES.Caption = "Construction Issues"
        Me.colCONSTRUCTION_ISSUES.FieldName = "CONSTRUCTION_ISSUES"
        Me.colCONSTRUCTION_ISSUES.Name = "colCONSTRUCTION_ISSUES"
        Me.colCONSTRUCTION_ISSUES.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colCONSTRUCTION_ISSUES.Visible = True
        Me.colCONSTRUCTION_ISSUES.VisibleIndex = 50
        '
        'colPRIORITY
        '
        Me.colPRIORITY.Caption = "Priority"
        Me.colPRIORITY.FieldName = "PRIORITY"
        Me.colPRIORITY.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colPRIORITY.Name = "colPRIORITY"
        Me.colPRIORITY.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colPRIORITY.Visible = True
        Me.colPRIORITY.VisibleIndex = 51
        '
        'colPRIORITY_DESCRIPTION
        '
        Me.colPRIORITY_DESCRIPTION.Caption = "Priority Desc"
        Me.colPRIORITY_DESCRIPTION.FieldName = "PRIORITY_DESCRIPTION"
        Me.colPRIORITY_DESCRIPTION.Name = "colPRIORITY_DESCRIPTION"
        Me.colPRIORITY_DESCRIPTION.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colPRIORITY_DESCRIPTION.Visible = True
        Me.colPRIORITY_DESCRIPTION.VisibleIndex = 52
        '
        'colADDITIONAL_WORK_COMMENT
        '
        Me.colADDITIONAL_WORK_COMMENT.Caption = "Additional Work Comment"
        Me.colADDITIONAL_WORK_COMMENT.FieldName = "ADDITIONAL_WORK_COMMENT"
        Me.colADDITIONAL_WORK_COMMENT.Name = "colADDITIONAL_WORK_COMMENT"
        Me.colADDITIONAL_WORK_COMMENT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colADDITIONAL_WORK_COMMENT.Visible = True
        Me.colADDITIONAL_WORK_COMMENT.VisibleIndex = 54
        '
        'colSTATUS_COMMENT
        '
        Me.colSTATUS_COMMENT.Caption = "Status Comment"
        Me.colSTATUS_COMMENT.FieldName = "STATUS_COMMENT"
        Me.colSTATUS_COMMENT.Name = "colSTATUS_COMMENT"
        Me.colSTATUS_COMMENT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colSTATUS_COMMENT.Visible = True
        Me.colSTATUS_COMMENT.VisibleIndex = 55
        '
        'colPERMIT_STATUS
        '
        Me.colPERMIT_STATUS.Caption = "Permit Status"
        Me.colPERMIT_STATUS.FieldName = "PERMIT_STATUS"
        Me.colPERMIT_STATUS.Name = "colPERMIT_STATUS"
        Me.colPERMIT_STATUS.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colPERMIT_STATUS.Visible = True
        Me.colPERMIT_STATUS.VisibleIndex = 56
        '
        'colCONTRACT_STATUS
        '
        Me.colCONTRACT_STATUS.Caption = "Contract Status"
        Me.colCONTRACT_STATUS.FieldName = "CONTRACT_STATUS"
        Me.colCONTRACT_STATUS.Name = "colCONTRACT_STATUS"
        Me.colCONTRACT_STATUS.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colCONTRACT_STATUS.Visible = True
        Me.colCONTRACT_STATUS.VisibleIndex = 57
        '
        'colAREA_HOTEL
        '
        Me.colAREA_HOTEL.Caption = "Area Hotel"
        Me.colAREA_HOTEL.FieldName = "AREA_HOTEL"
        Me.colAREA_HOTEL.Name = "colAREA_HOTEL"
        Me.colAREA_HOTEL.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colAREA_HOTEL.Visible = True
        Me.colAREA_HOTEL.VisibleIndex = 58
        '
        'colNOTES
        '
        Me.colNOTES.Caption = "Notes"
        Me.colNOTES.FieldName = "NOTES"
        Me.colNOTES.Name = "colNOTES"
        Me.colNOTES.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colNOTES.Visible = True
        Me.colNOTES.VisibleIndex = 59
        '
        'colPROPOSAL_STATUS
        '
        Me.colPROPOSAL_STATUS.Caption = "Proposal Status"
        Me.colPROPOSAL_STATUS.FieldName = "PROPOSAL_STATUS"
        Me.colPROPOSAL_STATUS.Name = "colPROPOSAL_STATUS"
        Me.colPROPOSAL_STATUS.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colPROPOSAL_STATUS.Visible = True
        Me.colPROPOSAL_STATUS.VisibleIndex = 60
        '
        'colJOB_STATUS_COMMENTS
        '
        Me.colJOB_STATUS_COMMENTS.Caption = "Job Status Comments"
        Me.colJOB_STATUS_COMMENTS.FieldName = "JOB_STATUS_COMMENTS"
        Me.colJOB_STATUS_COMMENTS.Name = "colJOB_STATUS_COMMENTS"
        Me.colJOB_STATUS_COMMENTS.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colJOB_STATUS_COMMENTS.Visible = True
        Me.colJOB_STATUS_COMMENTS.VisibleIndex = 61
        '
        'colACTIVE_STATUS
        '
        Me.colACTIVE_STATUS.Caption = "Active Status"
        Me.colACTIVE_STATUS.FieldName = "ACTIVE_STATUS"
        Me.colACTIVE_STATUS.Name = "colACTIVE_STATUS"
        Me.colACTIVE_STATUS.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colACTIVE_STATUS.Visible = True
        Me.colACTIVE_STATUS.VisibleIndex = 62
        '
        'colENTERED_BY_TEXT
        '
        Me.colENTERED_BY_TEXT.Caption = "Entered By"
        Me.colENTERED_BY_TEXT.FieldName = "ENTERED_BY_TEXT"
        Me.colENTERED_BY_TEXT.Name = "colENTERED_BY_TEXT"
        Me.colENTERED_BY_TEXT.Visible = True
        Me.colENTERED_BY_TEXT.VisibleIndex = 63
        '
        'colUPDATED_BY_TEXT
        '
        Me.colUPDATED_BY_TEXT.Caption = "Updated By"
        Me.colUPDATED_BY_TEXT.FieldName = "UPDATED_BY_TEXT"
        Me.colUPDATED_BY_TEXT.Name = "colUPDATED_BY_TEXT"
        Me.colUPDATED_BY_TEXT.Visible = True
        Me.colUPDATED_BY_TEXT.VisibleIndex = 64
        '
        'colconst_month
        '
        Me.colconst_month.Caption = "Construction Month"
        Me.colconst_month.FieldName = "const_month"
        Me.colconst_month.Name = "colconst_month"
        Me.colconst_month.Visible = True
        Me.colconst_month.VisibleIndex = 65
        '
        'colconst_year
        '
        Me.colconst_year.Caption = "Construstion Year"
        Me.colconst_year.FieldName = "const_year"
        Me.colconst_year.Name = "colconst_year"
        Me.colconst_year.Visible = True
        Me.colconst_year.VisibleIndex = 66
        '
        'colGROUP_TEXT2
        '
        Me.colGROUP_TEXT2.Caption = "Group"
        Me.colGROUP_TEXT2.FieldName = "GROUP_TEXT"
        Me.colGROUP_TEXT2.Name = "colGROUP_TEXT2"
        Me.colGROUP_TEXT2.Visible = True
        Me.colGROUP_TEXT2.VisibleIndex = 67
        '
        'coljob_status
        '
        Me.coljob_status.Caption = "Job Status"
        Me.coljob_status.FieldName = "job_status"
        Me.coljob_status.Name = "coljob_status"
        Me.coljob_status.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.coljob_status.Visible = True
        Me.coljob_status.VisibleIndex = 68
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'RepositoryItemImageComboBox3
        '
        Me.RepositoryItemImageComboBox3.AutoHeight = False
        Me.RepositoryItemImageComboBox3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemImageComboBox3.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("1", "1", 0), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("2", "2", 1)})
        Me.RepositoryItemImageComboBox3.Name = "RepositoryItemImageComboBox3"
        Me.RepositoryItemImageComboBox3.SmallImages = Me.smallImages
        '
        'RepositoryItemImageComboBox4
        '
        Me.RepositoryItemImageComboBox4.AutoHeight = False
        Me.RepositoryItemImageComboBox4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemImageComboBox4.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("1", "1", 10), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("2", "2", 11), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("3", "3", 9), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("4", "4", 8)})
        Me.RepositoryItemImageComboBox4.Name = "RepositoryItemImageComboBox4"
        Me.RepositoryItemImageComboBox4.SmallImages = Me.smallImages
        '
        'Customers
        '
        Me.Customers.Controls.Add(Me.GridCustomers)
        Me.Customers.Name = "Customers"
        Me.Customers.Size = New System.Drawing.Size(1131, 394)
        Me.Customers.Text = "Customers"
        '
        'GridCustomers
        '
        Me.GridCustomers.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.GridCustomers.DataSource = Me.SpGetCustomerBindingSource
        Me.GridCustomers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridCustomers.Location = New System.Drawing.Point(0, 0)
        Me.GridCustomers.MainView = Me.gridViewCustomer
        Me.GridCustomers.MenuManager = Me.RibbonControl
        Me.GridCustomers.Name = "GridCustomers"
        Me.GridCustomers.Size = New System.Drawing.Size(1131, 394)
        Me.GridCustomers.TabIndex = 0
        Me.GridCustomers.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridViewCustomer})
        '
        'SpGetCustomerBindingSource
        '
        Me.SpGetCustomerBindingSource.DataMember = "spGetCustomer"
        Me.SpGetCustomerBindingSource.DataSource = Me.DsErcoView2
        '
        'gridViewCustomer
        '
        Me.gridViewCustomer.Appearance.EvenRow.BackColor = System.Drawing.Color.WhiteSmoke
        Me.gridViewCustomer.Appearance.EvenRow.BackColor2 = System.Drawing.Color.Transparent
        Me.gridViewCustomer.Appearance.EvenRow.Options.UseBackColor = True
        Me.gridViewCustomer.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCUSTOMER_ID, Me.colCUSTOMER_NAME, Me.colADDRESS_LINE1, Me.colADDRESS_LINE2, Me.colCITY1, Me.colCOUNTY1, Me.colSTATE1, Me.colPHONE, Me.colFAX, Me.colWEBSITE, Me.colZIP_CODE, Me.colCUSTOMER_NOTES, Me.colGROUP_TEXT, Me.colACTIVE, Me.colcustomer_type})
        Me.gridViewCustomer.GridControl = Me.GridCustomers
        Me.gridViewCustomer.Name = "gridViewCustomer"
        Me.gridViewCustomer.OptionsView.ColumnAutoWidth = False
        Me.gridViewCustomer.OptionsView.EnableAppearanceEvenRow = True
        Me.gridViewCustomer.OptionsView.ShowAutoFilterRow = True
        Me.gridViewCustomer.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colCUSTOMER_NAME, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colCUSTOMER_ID
        '
        Me.colCUSTOMER_ID.Caption = "Customer ID"
        Me.colCUSTOMER_ID.FieldName = "CUSTOMER_ID"
        Me.colCUSTOMER_ID.Name = "colCUSTOMER_ID"
        Me.colCUSTOMER_ID.OptionsColumn.AllowEdit = False
        Me.colCUSTOMER_ID.OptionsColumn.ReadOnly = True
        '
        'colCUSTOMER_NAME
        '
        Me.colCUSTOMER_NAME.Caption = "Customer Name"
        Me.colCUSTOMER_NAME.FieldName = "CUSTOMER_NAME"
        Me.colCUSTOMER_NAME.Name = "colCUSTOMER_NAME"
        Me.colCUSTOMER_NAME.OptionsColumn.AllowEdit = False
        Me.colCUSTOMER_NAME.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colCUSTOMER_NAME.Visible = True
        Me.colCUSTOMER_NAME.VisibleIndex = 0
        Me.colCUSTOMER_NAME.Width = 207
        '
        'colADDRESS_LINE1
        '
        Me.colADDRESS_LINE1.Caption = "Address Line 1"
        Me.colADDRESS_LINE1.FieldName = "ADDRESS_LINE1"
        Me.colADDRESS_LINE1.Name = "colADDRESS_LINE1"
        Me.colADDRESS_LINE1.OptionsColumn.AllowEdit = False
        Me.colADDRESS_LINE1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colADDRESS_LINE1.Visible = True
        Me.colADDRESS_LINE1.VisibleIndex = 1
        Me.colADDRESS_LINE1.Width = 133
        '
        'colADDRESS_LINE2
        '
        Me.colADDRESS_LINE2.Caption = "Address Line 2"
        Me.colADDRESS_LINE2.FieldName = "ADDRESS_LINE2"
        Me.colADDRESS_LINE2.Name = "colADDRESS_LINE2"
        Me.colADDRESS_LINE2.OptionsColumn.AllowEdit = False
        Me.colADDRESS_LINE2.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colADDRESS_LINE2.Visible = True
        Me.colADDRESS_LINE2.VisibleIndex = 2
        Me.colADDRESS_LINE2.Width = 92
        '
        'colCITY1
        '
        Me.colCITY1.Caption = "City"
        Me.colCITY1.FieldName = "CITY"
        Me.colCITY1.Name = "colCITY1"
        Me.colCITY1.OptionsColumn.AllowEdit = False
        Me.colCITY1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colCITY1.Visible = True
        Me.colCITY1.VisibleIndex = 3
        Me.colCITY1.Width = 116
        '
        'colCOUNTY1
        '
        Me.colCOUNTY1.Caption = "County"
        Me.colCOUNTY1.FieldName = "COUNTY"
        Me.colCOUNTY1.Name = "colCOUNTY1"
        Me.colCOUNTY1.OptionsColumn.AllowEdit = False
        Me.colCOUNTY1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colCOUNTY1.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colCOUNTY1.Visible = True
        Me.colCOUNTY1.VisibleIndex = 4
        '
        'colSTATE1
        '
        Me.colSTATE1.Caption = "State"
        Me.colSTATE1.FieldName = "STATE"
        Me.colSTATE1.Name = "colSTATE1"
        Me.colSTATE1.OptionsColumn.AllowEdit = False
        Me.colSTATE1.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colSTATE1.Visible = True
        Me.colSTATE1.VisibleIndex = 5
        '
        'colPHONE
        '
        Me.colPHONE.Caption = "Phone"
        Me.colPHONE.FieldName = "PHONE"
        Me.colPHONE.Name = "colPHONE"
        Me.colPHONE.OptionsColumn.AllowEdit = False
        Me.colPHONE.Visible = True
        Me.colPHONE.VisibleIndex = 7
        Me.colPHONE.Width = 89
        '
        'colFAX
        '
        Me.colFAX.Caption = "Fax"
        Me.colFAX.FieldName = "FAX"
        Me.colFAX.Name = "colFAX"
        Me.colFAX.OptionsColumn.AllowEdit = False
        Me.colFAX.Visible = True
        Me.colFAX.VisibleIndex = 8
        Me.colFAX.Width = 91
        '
        'colWEBSITE
        '
        Me.colWEBSITE.Caption = "Website"
        Me.colWEBSITE.FieldName = "WEBSITE"
        Me.colWEBSITE.Name = "colWEBSITE"
        Me.colWEBSITE.OptionsColumn.AllowEdit = False
        Me.colWEBSITE.Visible = True
        Me.colWEBSITE.VisibleIndex = 9
        Me.colWEBSITE.Width = 122
        '
        'colZIP_CODE
        '
        Me.colZIP_CODE.Caption = "Zip Code"
        Me.colZIP_CODE.FieldName = "ZIP_CODE"
        Me.colZIP_CODE.Name = "colZIP_CODE"
        Me.colZIP_CODE.OptionsColumn.AllowEdit = False
        Me.colZIP_CODE.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colZIP_CODE.Visible = True
        Me.colZIP_CODE.VisibleIndex = 6
        '
        'colCUSTOMER_NOTES
        '
        Me.colCUSTOMER_NOTES.Caption = "Notes"
        Me.colCUSTOMER_NOTES.FieldName = "CUSTOMER_NOTES"
        Me.colCUSTOMER_NOTES.Name = "colCUSTOMER_NOTES"
        Me.colCUSTOMER_NOTES.OptionsColumn.AllowEdit = False
        Me.colCUSTOMER_NOTES.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colCUSTOMER_NOTES.Visible = True
        Me.colCUSTOMER_NOTES.VisibleIndex = 10
        Me.colCUSTOMER_NOTES.Width = 152
        '
        'colGROUP_TEXT
        '
        Me.colGROUP_TEXT.Caption = "Group"
        Me.colGROUP_TEXT.FieldName = "GROUP_TEXT"
        Me.colGROUP_TEXT.Name = "colGROUP_TEXT"
        Me.colGROUP_TEXT.OptionsColumn.AllowEdit = False
        Me.colGROUP_TEXT.OptionsColumn.ReadOnly = True
        Me.colGROUP_TEXT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colGROUP_TEXT.Visible = True
        Me.colGROUP_TEXT.VisibleIndex = 11
        Me.colGROUP_TEXT.Width = 151
        '
        'colACTIVE
        '
        Me.colACTIVE.Caption = "Active Status"
        Me.colACTIVE.FieldName = "ACTIVE"
        Me.colACTIVE.Name = "colACTIVE"
        Me.colACTIVE.OptionsColumn.AllowEdit = False
        Me.colACTIVE.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colACTIVE.Visible = True
        Me.colACTIVE.VisibleIndex = 12
        Me.colACTIVE.Width = 86
        '
        'colcustomer_type
        '
        Me.colcustomer_type.Caption = "Tyoe"
        Me.colcustomer_type.FieldName = "customer_type"
        Me.colcustomer_type.Name = "colcustomer_type"
        Me.colcustomer_type.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colcustomer_type.Visible = True
        Me.colcustomer_type.VisibleIndex = 13
        '
        'Users
        '
        Me.Users.Controls.Add(Me.GridUsers)
        Me.Users.Name = "Users"
        Me.Users.Size = New System.Drawing.Size(1131, 394)
        Me.Users.Text = "Users"
        '
        'GridUsers
        '
        Me.GridUsers.DataSource = Me.SpGetUsersBindingSource
        Me.GridUsers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridUsers.Location = New System.Drawing.Point(0, 0)
        Me.GridUsers.MainView = Me.gridViewUser
        Me.GridUsers.MenuManager = Me.RibbonControl
        Me.GridUsers.Name = "GridUsers"
        Me.GridUsers.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtPassword, Me.txtTrueFalse})
        Me.GridUsers.Size = New System.Drawing.Size(1131, 394)
        Me.GridUsers.TabIndex = 0
        Me.GridUsers.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridViewUser})
        '
        'SpGetUsersBindingSource
        '
        Me.SpGetUsersBindingSource.DataMember = "spGetUsers"
        Me.SpGetUsersBindingSource.DataSource = Me.DsErcoView2
        '
        'gridViewUser
        '
        Me.gridViewUser.Appearance.EvenRow.BackColor = System.Drawing.Color.WhiteSmoke
        Me.gridViewUser.Appearance.EvenRow.Options.UseBackColor = True
        Me.gridViewUser.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.gridViewUser.Appearance.OddRow.BorderColor = System.Drawing.Color.White
        Me.gridViewUser.Appearance.OddRow.Options.UseBackColor = True
        Me.gridViewUser.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colUSER_ID, Me.colLAST_NAME, Me.colFIRST_NAME, Me.colUSER_NAME, Me.colPASSWORD, Me.colEMAIL, Me.colPERMISSION, Me.colSALESMAN1, Me.colSUPER, Me.colPERMISSION_ID, Me.colACTIVE2})
        Me.gridViewUser.GridControl = Me.GridUsers
        Me.gridViewUser.Name = "gridViewUser"
        Me.gridViewUser.OptionsBehavior.Editable = False
        Me.gridViewUser.OptionsView.EnableAppearanceEvenRow = True
        Me.gridViewUser.OptionsView.ShowAutoFilterRow = True
        Me.gridViewUser.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colLAST_NAME, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colUSER_ID
        '
        Me.colUSER_ID.Caption = "User ID"
        Me.colUSER_ID.FieldName = "USER_ID"
        Me.colUSER_ID.Name = "colUSER_ID"
        Me.colUSER_ID.OptionsColumn.AllowEdit = False
        '
        'colLAST_NAME
        '
        Me.colLAST_NAME.Caption = "Last Name"
        Me.colLAST_NAME.FieldName = "LAST_NAME"
        Me.colLAST_NAME.Name = "colLAST_NAME"
        Me.colLAST_NAME.OptionsColumn.AllowEdit = False
        Me.colLAST_NAME.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colLAST_NAME.Visible = True
        Me.colLAST_NAME.VisibleIndex = 0
        Me.colLAST_NAME.Width = 186
        '
        'colFIRST_NAME
        '
        Me.colFIRST_NAME.Caption = "First Name"
        Me.colFIRST_NAME.FieldName = "FIRST_NAME"
        Me.colFIRST_NAME.Name = "colFIRST_NAME"
        Me.colFIRST_NAME.OptionsColumn.AllowEdit = False
        Me.colFIRST_NAME.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colFIRST_NAME.Visible = True
        Me.colFIRST_NAME.VisibleIndex = 1
        Me.colFIRST_NAME.Width = 210
        '
        'colUSER_NAME
        '
        Me.colUSER_NAME.Caption = "User Name"
        Me.colUSER_NAME.FieldName = "USER_NAME"
        Me.colUSER_NAME.Name = "colUSER_NAME"
        Me.colUSER_NAME.OptionsColumn.AllowEdit = False
        Me.colUSER_NAME.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colUSER_NAME.Visible = True
        Me.colUSER_NAME.VisibleIndex = 2
        Me.colUSER_NAME.Width = 177
        '
        'colPASSWORD
        '
        Me.colPASSWORD.Caption = "Password"
        Me.colPASSWORD.ColumnEdit = Me.txtPassword
        Me.colPASSWORD.FieldName = "PASSWORD"
        Me.colPASSWORD.Name = "colPASSWORD"
        Me.colPASSWORD.OptionsColumn.AllowEdit = False
        Me.colPASSWORD.OptionsFilter.AllowAutoFilter = False
        Me.colPASSWORD.OptionsFilter.AllowFilter = False
        Me.colPASSWORD.Visible = True
        Me.colPASSWORD.VisibleIndex = 3
        Me.colPASSWORD.Width = 134
        '
        'txtPassword
        '
        Me.txtPassword.AutoHeight = False
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        '
        'colEMAIL
        '
        Me.colEMAIL.Caption = "Email"
        Me.colEMAIL.FieldName = "EMAIL"
        Me.colEMAIL.Name = "colEMAIL"
        Me.colEMAIL.OptionsColumn.AllowEdit = False
        Me.colEMAIL.Visible = True
        Me.colEMAIL.VisibleIndex = 4
        Me.colEMAIL.Width = 192
        '
        'colPERMISSION
        '
        Me.colPERMISSION.Caption = "Permission"
        Me.colPERMISSION.FieldName = "PERMISSION"
        Me.colPERMISSION.Name = "colPERMISSION"
        Me.colPERMISSION.OptionsColumn.AllowEdit = False
        Me.colPERMISSION.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colPERMISSION.Visible = True
        Me.colPERMISSION.VisibleIndex = 5
        Me.colPERMISSION.Width = 153
        '
        'colSALESMAN1
        '
        Me.colSALESMAN1.Caption = "Salesman"
        Me.colSALESMAN1.FieldName = "SALESMAN"
        Me.colSALESMAN1.Name = "colSALESMAN1"
        Me.colSALESMAN1.OptionsColumn.AllowEdit = False
        Me.colSALESMAN1.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colSALESMAN1.Visible = True
        Me.colSALESMAN1.VisibleIndex = 7
        Me.colSALESMAN1.Width = 227
        '
        'colSUPER
        '
        Me.colSUPER.Caption = "Superintendent"
        Me.colSUPER.FieldName = "SUPER"
        Me.colSUPER.Name = "colSUPER"
        Me.colSUPER.OptionsColumn.AllowEdit = False
        Me.colSUPER.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colSUPER.Visible = True
        Me.colSUPER.VisibleIndex = 6
        Me.colSUPER.Width = 211
        '
        'colPERMISSION_ID
        '
        Me.colPERMISSION_ID.Caption = "Permission ID"
        Me.colPERMISSION_ID.FieldName = "PERMISSION_ID"
        Me.colPERMISSION_ID.Name = "colPERMISSION_ID"
        Me.colPERMISSION_ID.OptionsColumn.AllowEdit = False
        Me.colPERMISSION_ID.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        '
        'colACTIVE2
        '
        Me.colACTIVE2.Caption = "Active Status"
        Me.colACTIVE2.FieldName = "ACTIVE"
        Me.colACTIVE2.Name = "colACTIVE2"
        Me.colACTIVE2.OptionsColumn.AllowEdit = False
        Me.colACTIVE2.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colACTIVE2.Visible = True
        Me.colACTIVE2.VisibleIndex = 8
        '
        'txtTrueFalse
        '
        Me.txtTrueFalse.AutoHeight = False
        Me.txtTrueFalse.Name = "txtTrueFalse"
        '
        'Vendors
        '
        Me.Vendors.Controls.Add(Me.GridVendors)
        Me.Vendors.Name = "Vendors"
        Me.Vendors.Size = New System.Drawing.Size(1131, 394)
        Me.Vendors.Text = "Vendors"
        '
        'GridVendors
        '
        Me.GridVendors.DataSource = Me.SpGetVendorBindingSource
        Me.GridVendors.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridVendors.Location = New System.Drawing.Point(0, 0)
        Me.GridVendors.MainView = Me.gridViewVendor
        Me.GridVendors.MenuManager = Me.RibbonControl
        Me.GridVendors.Name = "GridVendors"
        Me.GridVendors.Size = New System.Drawing.Size(1131, 394)
        Me.GridVendors.TabIndex = 0
        Me.GridVendors.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridViewVendor})
        '
        'SpGetVendorBindingSource
        '
        Me.SpGetVendorBindingSource.DataMember = "spGetVendor"
        Me.SpGetVendorBindingSource.DataSource = Me.DsErcoView2
        '
        'gridViewVendor
        '
        Me.gridViewVendor.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colVENDOR_ID, Me.colVENDOR_NAME, Me.colADDRESS_LINE11, Me.colADDRESS_LINE21, Me.colCITY2, Me.colCOUNTY2, Me.colSTATE2, Me.colPHONE1, Me.colFAX1, Me.colWEBSITE1, Me.colZIP_CODE1, Me.colCUSTOMER_NOTES1, Me.colGROUP_TEXT1, Me.colACTIVE1})
        Me.gridViewVendor.GridControl = Me.GridVendors
        Me.gridViewVendor.Name = "gridViewVendor"
        Me.gridViewVendor.OptionsView.ShowAutoFilterRow = True
        Me.gridViewVendor.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colVENDOR_NAME, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colVENDOR_ID
        '
        Me.colVENDOR_ID.Caption = "Vendor ID"
        Me.colVENDOR_ID.FieldName = "VENDOR_ID"
        Me.colVENDOR_ID.Name = "colVENDOR_ID"
        Me.colVENDOR_ID.OptionsColumn.AllowEdit = False
        Me.colVENDOR_ID.OptionsColumn.ReadOnly = True
        '
        'colVENDOR_NAME
        '
        Me.colVENDOR_NAME.Caption = "Vendor Name"
        Me.colVENDOR_NAME.FieldName = "VENDOR_NAME"
        Me.colVENDOR_NAME.Name = "colVENDOR_NAME"
        Me.colVENDOR_NAME.OptionsColumn.AllowEdit = False
        Me.colVENDOR_NAME.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colVENDOR_NAME.Visible = True
        Me.colVENDOR_NAME.VisibleIndex = 0
        Me.colVENDOR_NAME.Width = 191
        '
        'colADDRESS_LINE11
        '
        Me.colADDRESS_LINE11.Caption = "Address Line 1"
        Me.colADDRESS_LINE11.FieldName = "ADDRESS_LINE1"
        Me.colADDRESS_LINE11.Name = "colADDRESS_LINE11"
        Me.colADDRESS_LINE11.OptionsColumn.AllowEdit = False
        Me.colADDRESS_LINE11.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colADDRESS_LINE11.Visible = True
        Me.colADDRESS_LINE11.VisibleIndex = 1
        Me.colADDRESS_LINE11.Width = 154
        '
        'colADDRESS_LINE21
        '
        Me.colADDRESS_LINE21.Caption = "Address Line 2"
        Me.colADDRESS_LINE21.FieldName = "ADDRESS_LINE2"
        Me.colADDRESS_LINE21.Name = "colADDRESS_LINE21"
        Me.colADDRESS_LINE21.OptionsColumn.AllowEdit = False
        Me.colADDRESS_LINE21.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colADDRESS_LINE21.Visible = True
        Me.colADDRESS_LINE21.VisibleIndex = 2
        Me.colADDRESS_LINE21.Width = 102
        '
        'colCITY2
        '
        Me.colCITY2.Caption = "City"
        Me.colCITY2.FieldName = "CITY"
        Me.colCITY2.Name = "colCITY2"
        Me.colCITY2.OptionsColumn.AllowEdit = False
        Me.colCITY2.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colCITY2.Visible = True
        Me.colCITY2.VisibleIndex = 3
        Me.colCITY2.Width = 102
        '
        'colCOUNTY2
        '
        Me.colCOUNTY2.Caption = "County"
        Me.colCOUNTY2.FieldName = "COUNTY"
        Me.colCOUNTY2.Name = "colCOUNTY2"
        Me.colCOUNTY2.OptionsColumn.AllowEdit = False
        Me.colCOUNTY2.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colCOUNTY2.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colCOUNTY2.Visible = True
        Me.colCOUNTY2.VisibleIndex = 4
        Me.colCOUNTY2.Width = 102
        '
        'colSTATE2
        '
        Me.colSTATE2.Caption = "State"
        Me.colSTATE2.FieldName = "STATE"
        Me.colSTATE2.Name = "colSTATE2"
        Me.colSTATE2.OptionsColumn.AllowEdit = False
        Me.colSTATE2.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colSTATE2.Visible = True
        Me.colSTATE2.VisibleIndex = 5
        Me.colSTATE2.Width = 102
        '
        'colPHONE1
        '
        Me.colPHONE1.Caption = "Phone"
        Me.colPHONE1.FieldName = "PHONE"
        Me.colPHONE1.Name = "colPHONE1"
        Me.colPHONE1.OptionsColumn.AllowEdit = False
        Me.colPHONE1.Visible = True
        Me.colPHONE1.VisibleIndex = 7
        Me.colPHONE1.Width = 102
        '
        'colFAX1
        '
        Me.colFAX1.Caption = "Fax"
        Me.colFAX1.FieldName = "FAX"
        Me.colFAX1.Name = "colFAX1"
        Me.colFAX1.OptionsColumn.AllowEdit = False
        Me.colFAX1.Visible = True
        Me.colFAX1.VisibleIndex = 8
        Me.colFAX1.Width = 102
        '
        'colWEBSITE1
        '
        Me.colWEBSITE1.Caption = "Website"
        Me.colWEBSITE1.FieldName = "WEBSITE"
        Me.colWEBSITE1.Name = "colWEBSITE1"
        Me.colWEBSITE1.OptionsColumn.AllowEdit = False
        Me.colWEBSITE1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Like]
        Me.colWEBSITE1.Visible = True
        Me.colWEBSITE1.VisibleIndex = 9
        Me.colWEBSITE1.Width = 102
        '
        'colZIP_CODE1
        '
        Me.colZIP_CODE1.Caption = "Zip Code"
        Me.colZIP_CODE1.FieldName = "ZIP_CODE"
        Me.colZIP_CODE1.Name = "colZIP_CODE1"
        Me.colZIP_CODE1.OptionsColumn.AllowEdit = False
        Me.colZIP_CODE1.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colZIP_CODE1.Visible = True
        Me.colZIP_CODE1.VisibleIndex = 6
        Me.colZIP_CODE1.Width = 102
        '
        'colCUSTOMER_NOTES1
        '
        Me.colCUSTOMER_NOTES1.Caption = "Notes"
        Me.colCUSTOMER_NOTES1.FieldName = "CUSTOMER_NOTES"
        Me.colCUSTOMER_NOTES1.Name = "colCUSTOMER_NOTES1"
        Me.colCUSTOMER_NOTES1.OptionsColumn.AllowEdit = False
        Me.colCUSTOMER_NOTES1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colCUSTOMER_NOTES1.Visible = True
        Me.colCUSTOMER_NOTES1.VisibleIndex = 10
        Me.colCUSTOMER_NOTES1.Width = 102
        '
        'colGROUP_TEXT1
        '
        Me.colGROUP_TEXT1.Caption = "Group"
        Me.colGROUP_TEXT1.FieldName = "GROUP_TEXT"
        Me.colGROUP_TEXT1.Name = "colGROUP_TEXT1"
        Me.colGROUP_TEXT1.OptionsColumn.AllowEdit = False
        Me.colGROUP_TEXT1.OptionsColumn.ReadOnly = True
        Me.colGROUP_TEXT1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Equals
        Me.colGROUP_TEXT1.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colGROUP_TEXT1.Visible = True
        Me.colGROUP_TEXT1.VisibleIndex = 11
        Me.colGROUP_TEXT1.Width = 123
        '
        'colACTIVE1
        '
        Me.colACTIVE1.Caption = "Active Status"
        Me.colACTIVE1.FieldName = "ACTIVE"
        Me.colACTIVE1.Name = "colACTIVE1"
        Me.colACTIVE1.OptionsColumn.AllowEdit = False
        Me.colACTIVE1.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colACTIVE1.Visible = True
        Me.colACTIVE1.VisibleIndex = 12
        Me.colACTIVE1.Width = 104
        '
        'Contacts
        '
        Me.Contacts.Controls.Add(Me.GridContacts)
        Me.Contacts.Name = "Contacts"
        Me.Contacts.Size = New System.Drawing.Size(1131, 394)
        Me.Contacts.Text = "Contacts"
        '
        'GridContacts
        '
        Me.GridContacts.DataSource = Me.SpGetContactBindingSource
        Me.GridContacts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridContacts.Location = New System.Drawing.Point(0, 0)
        Me.GridContacts.MainView = Me.gridViewContact
        Me.GridContacts.MenuManager = Me.RibbonControl
        Me.GridContacts.Name = "GridContacts"
        Me.GridContacts.Size = New System.Drawing.Size(1131, 394)
        Me.GridContacts.TabIndex = 1
        Me.GridContacts.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridViewContact})
        '
        'SpGetContactBindingSource
        '
        Me.SpGetContactBindingSource.DataMember = "spGetContact"
        Me.SpGetContactBindingSource.DataSource = Me.DsErcoView2
        '
        'gridViewContact
        '
        Me.gridViewContact.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCONTACT_ID, Me.colFIRST_NAME1, Me.colLAST_NAME1, Me.colADDRESS_LINE12, Me.colADDRESS_LINE22, Me.colCITY3, Me.colZIP_CODE2, Me.colCOUNTY3, Me.colSTATE3, Me.colPHONE2, Me.colFAX2, Me.colEMAIL1, Me.colCUSTOMER_NAME1, Me.colWEBSITE2, Me.colNOTES1, Me.colACTIVE3, Me.colPHONE21})
        Me.gridViewContact.GridControl = Me.GridContacts
        Me.gridViewContact.Name = "gridViewContact"
        Me.gridViewContact.OptionsView.ShowAutoFilterRow = True
        Me.gridViewContact.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colLAST_NAME1, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colCONTACT_ID
        '
        Me.colCONTACT_ID.Caption = "Contact ID"
        Me.colCONTACT_ID.FieldName = "CONTACT_ID"
        Me.colCONTACT_ID.Name = "colCONTACT_ID"
        Me.colCONTACT_ID.OptionsColumn.AllowEdit = False
        '
        'colFIRST_NAME1
        '
        Me.colFIRST_NAME1.Caption = "First Name"
        Me.colFIRST_NAME1.FieldName = "FIRST_NAME"
        Me.colFIRST_NAME1.Name = "colFIRST_NAME1"
        Me.colFIRST_NAME1.OptionsColumn.AllowEdit = False
        Me.colFIRST_NAME1.Visible = True
        Me.colFIRST_NAME1.VisibleIndex = 1
        Me.colFIRST_NAME1.Width = 129
        '
        'colLAST_NAME1
        '
        Me.colLAST_NAME1.Caption = "Last Name"
        Me.colLAST_NAME1.FieldName = "LAST_NAME"
        Me.colLAST_NAME1.Name = "colLAST_NAME1"
        Me.colLAST_NAME1.OptionsColumn.AllowEdit = False
        Me.colLAST_NAME1.Visible = True
        Me.colLAST_NAME1.VisibleIndex = 0
        Me.colLAST_NAME1.Width = 157
        '
        'colADDRESS_LINE12
        '
        Me.colADDRESS_LINE12.Caption = "Address Line 1"
        Me.colADDRESS_LINE12.FieldName = "ADDRESS_LINE1"
        Me.colADDRESS_LINE12.Name = "colADDRESS_LINE12"
        Me.colADDRESS_LINE12.OptionsColumn.AllowEdit = False
        Me.colADDRESS_LINE12.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colADDRESS_LINE12.Visible = True
        Me.colADDRESS_LINE12.VisibleIndex = 2
        Me.colADDRESS_LINE12.Width = 166
        '
        'colADDRESS_LINE22
        '
        Me.colADDRESS_LINE22.Caption = "Address Line 2"
        Me.colADDRESS_LINE22.FieldName = "ADDRESS_LINE2"
        Me.colADDRESS_LINE22.Name = "colADDRESS_LINE22"
        Me.colADDRESS_LINE22.OptionsColumn.AllowEdit = False
        Me.colADDRESS_LINE22.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colADDRESS_LINE22.Visible = True
        Me.colADDRESS_LINE22.VisibleIndex = 3
        Me.colADDRESS_LINE22.Width = 92
        '
        'colCITY3
        '
        Me.colCITY3.Caption = "City"
        Me.colCITY3.FieldName = "CITY"
        Me.colCITY3.Name = "colCITY3"
        Me.colCITY3.OptionsColumn.AllowEdit = False
        Me.colCITY3.Visible = True
        Me.colCITY3.VisibleIndex = 4
        Me.colCITY3.Width = 101
        '
        'colZIP_CODE2
        '
        Me.colZIP_CODE2.Caption = "Zip Code"
        Me.colZIP_CODE2.FieldName = "ZIP_CODE"
        Me.colZIP_CODE2.Name = "colZIP_CODE2"
        Me.colZIP_CODE2.OptionsColumn.AllowEdit = False
        Me.colZIP_CODE2.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colZIP_CODE2.Visible = True
        Me.colZIP_CODE2.VisibleIndex = 7
        Me.colZIP_CODE2.Width = 83
        '
        'colCOUNTY3
        '
        Me.colCOUNTY3.Caption = "County"
        Me.colCOUNTY3.FieldName = "COUNTY"
        Me.colCOUNTY3.Name = "colCOUNTY3"
        Me.colCOUNTY3.OptionsColumn.AllowEdit = False
        Me.colCOUNTY3.Visible = True
        Me.colCOUNTY3.VisibleIndex = 5
        Me.colCOUNTY3.Width = 81
        '
        'colSTATE3
        '
        Me.colSTATE3.Caption = "State"
        Me.colSTATE3.FieldName = "STATE"
        Me.colSTATE3.Name = "colSTATE3"
        Me.colSTATE3.OptionsColumn.AllowEdit = False
        Me.colSTATE3.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colSTATE3.Visible = True
        Me.colSTATE3.VisibleIndex = 6
        Me.colSTATE3.Width = 56
        '
        'colPHONE2
        '
        Me.colPHONE2.Caption = "Office"
        Me.colPHONE2.FieldName = "PHONE"
        Me.colPHONE2.Name = "colPHONE2"
        Me.colPHONE2.OptionsColumn.AllowEdit = False
        Me.colPHONE2.Visible = True
        Me.colPHONE2.VisibleIndex = 8
        Me.colPHONE2.Width = 83
        '
        'colFAX2
        '
        Me.colFAX2.Caption = "Fax"
        Me.colFAX2.FieldName = "FAX"
        Me.colFAX2.Name = "colFAX2"
        Me.colFAX2.OptionsColumn.AllowEdit = False
        Me.colFAX2.Visible = True
        Me.colFAX2.VisibleIndex = 10
        Me.colFAX2.Width = 83
        '
        'colEMAIL1
        '
        Me.colEMAIL1.Caption = "Email"
        Me.colEMAIL1.FieldName = "EMAIL"
        Me.colEMAIL1.Name = "colEMAIL1"
        Me.colEMAIL1.OptionsColumn.AllowEdit = False
        Me.colEMAIL1.Visible = True
        Me.colEMAIL1.VisibleIndex = 11
        Me.colEMAIL1.Width = 83
        '
        'colCUSTOMER_NAME1
        '
        Me.colCUSTOMER_NAME1.Caption = "Customer"
        Me.colCUSTOMER_NAME1.FieldName = "CUSTOMER_NAME"
        Me.colCUSTOMER_NAME1.Name = "colCUSTOMER_NAME1"
        Me.colCUSTOMER_NAME1.OptionsColumn.AllowEdit = False
        Me.colCUSTOMER_NAME1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colCUSTOMER_NAME1.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colCUSTOMER_NAME1.Visible = True
        Me.colCUSTOMER_NAME1.VisibleIndex = 12
        Me.colCUSTOMER_NAME1.Width = 150
        '
        'colWEBSITE2
        '
        Me.colWEBSITE2.Caption = "Website"
        Me.colWEBSITE2.FieldName = "WEBSITE"
        Me.colWEBSITE2.Name = "colWEBSITE2"
        Me.colWEBSITE2.OptionsColumn.AllowEdit = False
        Me.colWEBSITE2.Visible = True
        Me.colWEBSITE2.VisibleIndex = 13
        Me.colWEBSITE2.Width = 63
        '
        'colNOTES1
        '
        Me.colNOTES1.Caption = "Notes"
        Me.colNOTES1.FieldName = "NOTES"
        Me.colNOTES1.Name = "colNOTES1"
        Me.colNOTES1.OptionsColumn.AllowEdit = False
        Me.colNOTES1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colNOTES1.Visible = True
        Me.colNOTES1.VisibleIndex = 14
        Me.colNOTES1.Width = 82
        '
        'colACTIVE3
        '
        Me.colACTIVE3.Caption = "Active Status"
        Me.colACTIVE3.FieldName = "ACTIVE"
        Me.colACTIVE3.Name = "colACTIVE3"
        Me.colACTIVE3.OptionsColumn.AllowEdit = False
        Me.colACTIVE3.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colACTIVE3.Visible = True
        Me.colACTIVE3.VisibleIndex = 15
        Me.colACTIVE3.Width = 81
        '
        'colPHONE21
        '
        Me.colPHONE21.Caption = "Cell"
        Me.colPHONE21.FieldName = "PHONE2"
        Me.colPHONE21.Name = "colPHONE21"
        Me.colPHONE21.Visible = True
        Me.colPHONE21.VisibleIndex = 9
        '
        'tabGroup
        '
        Me.tabGroup.Controls.Add(Me.grdGroup)
        Me.tabGroup.Name = "tabGroup"
        Me.tabGroup.Size = New System.Drawing.Size(1131, 394)
        Me.tabGroup.Text = "Group"
        '
        'grdGroup
        '
        Me.grdGroup.DataSource = Me.SpGetGroupsBindingSource
        Me.grdGroup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdGroup.Location = New System.Drawing.Point(0, 0)
        Me.grdGroup.MainView = Me.grdViewGroup
        Me.grdGroup.MenuManager = Me.RibbonControl
        Me.grdGroup.Name = "grdGroup"
        Me.grdGroup.Size = New System.Drawing.Size(1131, 394)
        Me.grdGroup.TabIndex = 2
        Me.grdGroup.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdViewGroup})
        '
        'SpGetGroupsBindingSource
        '
        Me.SpGetGroupsBindingSource.DataMember = "spGetGroups"
        Me.SpGetGroupsBindingSource.DataSource = Me.DsErcoView2
        '
        'grdViewGroup
        '
        Me.grdViewGroup.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colGROUP_ID1, Me.colGROUP_NAME1})
        Me.grdViewGroup.GridControl = Me.grdGroup
        Me.grdViewGroup.Name = "grdViewGroup"
        Me.grdViewGroup.OptionsView.ShowAutoFilterRow = True
        Me.grdViewGroup.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colGROUP_NAME1, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colGROUP_ID1
        '
        Me.colGROUP_ID1.Caption = "Group ID"
        Me.colGROUP_ID1.FieldName = "GROUP_ID"
        Me.colGROUP_ID1.Name = "colGROUP_ID1"
        Me.colGROUP_ID1.OptionsColumn.AllowEdit = False
        '
        'colGROUP_NAME1
        '
        Me.colGROUP_NAME1.Caption = "Group Name"
        Me.colGROUP_NAME1.FieldName = "GROUP_NAME"
        Me.colGROUP_NAME1.Name = "colGROUP_NAME1"
        Me.colGROUP_NAME1.OptionsColumn.AllowEdit = False
        Me.colGROUP_NAME1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colGROUP_NAME1.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colGROUP_NAME1.Visible = True
        Me.colGROUP_NAME1.VisibleIndex = 0
        '
        'SpGetContactsBindingSource
        '
        Me.SpGetContactsBindingSource.DataMember = "spGetContacts"
        Me.SpGetContactsBindingSource.DataSource = Me.DsErcoView2
        '
        'DefaultBarAndDockingController1
        '
        '
        '
        '
        Me.DefaultBarAndDockingController1.Controller.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.DefaultBarAndDockingController1.Controller.LookAndFeel.UseDefaultLookAndFeel = False
        Me.DefaultBarAndDockingController1.Controller.PropertiesBar.DefaultGlyphSize = New System.Drawing.Size(16, 16)
        Me.DefaultBarAndDockingController1.Controller.PropertiesBar.DefaultLargeGlyphSize = New System.Drawing.Size(32, 32)
        '
        'RibbonPageGroup9
        '
        Me.RibbonPageGroup9.Name = "RibbonPageGroup9"
        Me.RibbonPageGroup9.ShowCaptionButton = False
        Me.RibbonPageGroup9.Text = "Layout"
        '
        'RibbonPageGroup10
        '
        Me.RibbonPageGroup10.Name = "RibbonPageGroup10"
        Me.RibbonPageGroup10.ShowCaptionButton = False
        Me.RibbonPageGroup10.Text = "Reports"
        '
        'RibbonPageGroup11
        '
        Me.RibbonPageGroup11.Name = "RibbonPageGroup11"
        Me.RibbonPageGroup11.ShowCaptionButton = False
        Me.RibbonPageGroup11.Text = "Layout"
        '
        'RibbonPageGroup12
        '
        Me.RibbonPageGroup12.Name = "RibbonPageGroup12"
        Me.RibbonPageGroup12.ShowCaptionButton = False
        Me.RibbonPageGroup12.Text = "Reports"
        '
        'SpGetCustomerTableAdapter1
        '
        Me.SpGetCustomerTableAdapter1.ClearBeforeFill = True
        '
        'SpGetProposalsTableAdapter1
        '
        Me.SpGetProposalsTableAdapter1.ClearBeforeFill = True
        '
        'SpGetUsersTableAdapter1
        '
        Me.SpGetUsersTableAdapter1.ClearBeforeFill = True
        '
        'SpGetVendorTableAdapter1
        '
        Me.SpGetVendorTableAdapter1.ClearBeforeFill = True
        '
        'SpGetContactsTableAdapter1
        '
        Me.SpGetContactsTableAdapter1.ClearBeforeFill = True
        '
        'SpGetContactTableAdapter1
        '
        Me.SpGetContactTableAdapter1.ClearBeforeFill = True
        '
        'SpGetGroupsTableAdapter1
        '
        Me.SpGetGroupsTableAdapter1.ClearBeforeFill = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1131, 599)
        Me.Controls.Add(Me.ClientPanel)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.Ribbon = Me.RibbonControl
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "EV2"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.smallImages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RIProposalLayouts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RICustomerLayouts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RIVendorLayouts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RIContactLayouts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.largeImages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemImageComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ClientPanel.ResumeLayout(False)
        CType(Me.tabPages, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPages.ResumeLayout(False)
        Me.tabProposal.ResumeLayout(False)
        CType(Me.GridProposals, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpGetProposalsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsErcoView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridViewProposal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemImageComboBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemImageComboBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Customers.ResumeLayout(False)
        CType(Me.GridCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpGetCustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridViewCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Users.ResumeLayout(False)
        CType(Me.GridUsers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpGetUsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridViewUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPassword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTrueFalse, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Vendors.ResumeLayout(False)
        CType(Me.GridVendors, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpGetVendorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridViewVendor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Contacts.ResumeLayout(False)
        CType(Me.GridContacts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpGetContactBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridViewContact, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabGroup.ResumeLayout(False)
        CType(Me.grdGroup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpGetGroupsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdViewGroup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpGetContactsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DefaultBarAndDockingController1.Controller, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents ClientPanel As DevExpress.XtraEditors.PanelControl
    Friend WithEvents DefaultBarAndDockingController1 As DevExpress.XtraBars.DefaultBarAndDockingController
    Friend WithEvents tabPages As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabProposal As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Customers As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents gridViewProposal As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridCustomers As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridViewCustomer As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents Users As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridUsers As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridViewUser As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colUSER_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLAST_NAME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIRST_NAME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUSER_NAME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPASSWORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEMAIL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPERMISSION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSUPER As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPERMISSION_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SpGetUsersTableAdapter As ErcoView.dsErcoViewTableAdapters.spGetUsersTableAdapter
    Friend WithEvents txtPassword As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colSALESMAN1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtTrueFalse As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents Vendors As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridVendors As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridViewVendor As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SpGetCustomersTableAdapter As ErcoView.dsErcoViewTableAdapters.spGetCustomersTableAdapter
    Friend WithEvents SpGetCustomerTableAdapter As ErcoView.dsErcoViewTableAdapters.spGetCustomerTableAdapter
    Friend WithEvents RibbonPageGroup9 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup10 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup11 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup12 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents DsErcoView As ErcoView.dsErcoView
    Friend WithEvents SpGetProposalsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SpGetCustomerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SpGetUsersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SpGetProposalsTableAdapter As ErcoView.dsErcoViewTableAdapters.spGetProposalsTableAdapter
    Friend WithEvents SpGetVendorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SpGetVendorTableAdapter As ErcoView.dsErcoViewTableAdapters.spGetVendorTableAdapter
    Friend WithEvents Contacts As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridContacts As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridViewContact As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SpGetContactsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SpGetContactsTableAdapter As ErcoView.dsErcoViewTableAdapters.spGetContactsTableAdapter
    Friend WithEvents SpGetContactBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SpGetContactTableAdapter As ErcoView.dsErcoViewTableAdapters.spGetContactTableAdapter
    Friend WithEvents colACTIVE2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridProposals As DevExpress.XtraGrid.GridControl
    Friend WithEvents tabGroup As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents grdGroup As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdViewGroup As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SpGetGroupsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SpGetGroupsTableAdapter As ErcoView.dsErcoViewTableAdapters.spGetGroupsTableAdapter
    Friend WithEvents colGROUP_ID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGROUP_NAME1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPROPOSAL_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPROPOSAL_NUMBER As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colJOB_NUMBER As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colJOB_TYPE_TEXT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCUSTOMER_TEXT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCONTACT_TEXT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVENDOR_TEXT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coljob_type_misc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSALESMAN_TEXT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSUPER_TEXT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colENTERED_BY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDATE_ENTERED As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDATE_COMPLETED As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDATE_NOR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDATE_PROPOSAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldate_updated As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colupdated_by As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDESCRIPTION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCOMMENTS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBODY_OF_WATER As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDRIVING_DIRECTIONS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSTATUS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCITY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCOUNTY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSTATE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGPS_N As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGPS_W As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMILE_POINT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLINE_NUMBER As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDISTRICT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCONTRACT_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWORK_ORDER_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRICE_PROPOSAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRICE_PERMIT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRICE_EXTRA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRICE_ACTUAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPERMIT_COST As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRICE_TOTAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPROFIT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colONE_CALL_TICKET_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colONE_CALL_START_DATE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colONE_CALL_EXPERATION_DATE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colESTIMATED_COST As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colESTIMATED_MARGIN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPERMITS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIELD_CONTACT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPIPE_DIAMETER As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWATER_COURSE_DESC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSPECIFIC_PERMIT_ISSUES As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCONSTRUCTION_ISSUES As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRIORITY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRIORITY_DESCRIPTION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colADDITIONAL_WORK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colADDITIONAL_WORK_COMMENT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSTATUS_COMMENT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPERMIT_STATUS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCONTRACT_STATUS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAREA_HOTEL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOTES As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPROPOSAL_STATUS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colJOB_STATUS_COMMENTS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colACTIVE_STATUS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCUSTOMER_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCUSTOMER_NAME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colADDRESS_LINE1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colADDRESS_LINE2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCITY1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCOUNTY1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSTATE1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPHONE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFAX As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWEBSITE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colZIP_CODE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCUSTOMER_NOTES As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGROUP_TEXT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colACTIVE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVENDOR_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVENDOR_NAME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colADDRESS_LINE11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colADDRESS_LINE21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCITY2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCOUNTY2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSTATE2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPHONE1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFAX1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWEBSITE1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colZIP_CODE1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCUSTOMER_NOTES1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGROUP_TEXT1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colACTIVE1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCONTACT_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIRST_NAME1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLAST_NAME1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colADDRESS_LINE12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colADDRESS_LINE22 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCITY3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colZIP_CODE2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCOUNTY3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSTATE3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPHONE2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFAX2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEMAIL1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCUSTOMER_NAME1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWEBSITE2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOTES1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colACTIVE3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents smallImages As DevExpress.Utils.ImageCollection
    Friend WithEvents btnNewProposal As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents txtLoginName As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents siSaveProposalLayout As DevExpress.XtraBars.BarSubItem
    Friend WithEvents btnSaveProposalLayout As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSaveAsProposalLayout As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnRemoveProposalLayout As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmboProposalLayout As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RIProposalLayouts As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents btnNewCustomer As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnProposalMap As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnExportProposal As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnReportProposal As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnNewUser As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSettings As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnNewVendor As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnNew As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnRemoveCustomerLayout As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSaveContactLayout As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSaveUserLayout As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnExportCustomer As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnRemoveContactLayout As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnRemoveUserLayout As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnRemoveVendorLayout As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnExportUser As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnExportContact As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnExportVendor As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnReportContact As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnBrowseBrowse As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnNewGroup As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmboCustomerLayout As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RICustomerLayouts As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents cmboVendorLayout As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RIVendorLayouts As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents cmboContactLayout As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RIContactLayouts As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents btnSaveCustomerLayout As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents siSaveCustomerLayout As DevExpress.XtraBars.BarSubItem
    Friend WithEvents btnSaveAsCustomerLayout As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents siSaveVendor As DevExpress.XtraBars.BarSubItem
    Friend WithEvents btnSaveVendorLayout As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSaveAsVendorLayout As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents siSaveContact As DevExpress.XtraBars.BarSubItem
    Friend WithEvents btnSaveAsContactLayout As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarEditItem1 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents largeImages As DevExpress.Utils.ImageCollection
    Friend WithEvents pageProposal As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents rpgFileProposal As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rpgLayoutProposal As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rpgBrowse As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rpgMapProposal As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rpgReportProposal As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents pageCustomer As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents rpgFileCustomer As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rpgLayout As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rpgReportCustomer As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents pageVendor As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents rpgFileVendor As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rpgLayoutVendor As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rpgReportVendor As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents pageContact As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents rpgFileContact As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rpgLayoutContact As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rpgReportContact As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents pageUser As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents rpgFileUser As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rpgReportUser As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents pageGroup As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents rpgNew As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RepositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepositoryItemComboBox3 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemComboBox4 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
    Friend WithEvents RepositoryItemComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemImageComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
    Friend WithEvents RepositoryItemImageComboBox3 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
    Friend WithEvents RepositoryItemImageComboBox4 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
    Friend WithEvents colcustomer_type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DsErcoView1 As ErcoView.dsErcoView
    Friend WithEvents DsErcoView2 As ErcoView.dsErcoView
    Friend WithEvents SpGetCustomerTableAdapter1 As ErcoView.dsErcoViewTableAdapters.spGetCustomerTableAdapter
    Friend WithEvents SpGetProposalsTableAdapter1 As ErcoView.dsErcoViewTableAdapters.spGetProposalsTableAdapter
    Friend WithEvents SpGetUsersTableAdapter1 As ErcoView.dsErcoViewTableAdapters.spGetUsersTableAdapter
    Friend WithEvents SpGetVendorTableAdapter1 As ErcoView.dsErcoViewTableAdapters.spGetVendorTableAdapter
    Friend WithEvents SpGetContactsTableAdapter1 As ErcoView.dsErcoViewTableAdapters.spGetContactsTableAdapter
    Friend WithEvents SpGetContactTableAdapter1 As ErcoView.dsErcoViewTableAdapters.spGetContactTableAdapter
    Friend WithEvents SpGetGroupsTableAdapter1 As ErcoView.dsErcoViewTableAdapters.spGetGroupsTableAdapter
    Friend WithEvents colENTERED_BY_TEXT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUPDATED_BY_TEXT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colconst_month As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colconst_year As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colONE_CALL_TICKET_START_TIME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGROUP_TEXT2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coljob_status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPHONE21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSBS_COMPANY As DevExpress.XtraGrid.Columns.GridColumn


End Class
