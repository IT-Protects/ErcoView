<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUser
    Inherits DevExpress.XtraEditors.XtraForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUser))
        Me.SpGetUsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsErcoView1 = New ErcoView.dsErcoView()
        Me.chkSalesman = New DevExpress.XtraEditors.CheckEdit()
        Me.chkSuper = New DevExpress.XtraEditors.CheckEdit()
        Me.txtEmail = New DevExpress.XtraEditors.TextEdit()
        Me.txtPassword = New DevExpress.XtraEditors.TextEdit()
        Me.txtUserName = New DevExpress.XtraEditors.TextEdit()
        Me.txtFirstName = New DevExpress.XtraEditors.TextEdit()
        Me.txtLastName = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.lblActive = New DevExpress.XtraEditors.LabelControl()
        Me.txtActiveStatus = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cmboPermissions = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.btnExit = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarManager2 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.btnSaveUser = New DevExpress.XtraBars.BarButtonItem()
        Me.btnExitUser = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar5 = New DevExpress.XtraBars.Bar()
        Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl2 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl3 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl4 = New DevExpress.XtraBars.BarDockControl()
        Me.ImageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.SpGetUsersTableAdapter = New ErcoView.dsErcoViewTableAdapters.spGetUsersTableAdapter()
        Me.SpGetPermissionsTableAdapter = New ErcoView.dsErcoViewTableAdapters.spGetPermissionsTableAdapter()
        CType(Me.SpGetUsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsErcoView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSalesman.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSuper.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUserName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFirstName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLastName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtActiveStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmboPermissions.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SpGetUsersBindingSource
        '
        Me.SpGetUsersBindingSource.DataMember = "spGetUsers"
        Me.SpGetUsersBindingSource.DataSource = Me.DsErcoView1
        '
        'DsErcoView1
        '
        Me.DsErcoView1.DataSetName = "dsErcoView"
        Me.DsErcoView1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'chkSalesman
        '
        Me.chkSalesman.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SpGetUsersBindingSource, "SALESMAN", True))
        Me.chkSalesman.Location = New System.Drawing.Point(172, 100)
        Me.chkSalesman.Name = "chkSalesman"
        Me.chkSalesman.Properties.Caption = "Salesman"
        Me.chkSalesman.Size = New System.Drawing.Size(75, 19)
        Me.chkSalesman.TabIndex = 90
        '
        'chkSuper
        '
        Me.chkSuper.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SpGetUsersBindingSource, "SUPER", True))
        Me.chkSuper.Location = New System.Drawing.Point(63, 100)
        Me.chkSuper.Name = "chkSuper"
        Me.chkSuper.Properties.Caption = "Superindentent"
        Me.chkSuper.Size = New System.Drawing.Size(103, 19)
        Me.chkSuper.TabIndex = 80
        '
        'txtEmail
        '
        Me.txtEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SpGetUsersBindingSource, "EMAIL", True))
        Me.txtEmail.Location = New System.Drawing.Point(70, 73)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtEmail.Properties.Appearance.Options.UseBackColor = True
        Me.txtEmail.Size = New System.Drawing.Size(178, 20)
        Me.txtEmail.TabIndex = 30
        '
        'txtPassword
        '
        Me.txtPassword.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SpGetUsersBindingSource, "PASSWORD", True))
        Me.txtPassword.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.SpGetUsersBindingSource, "PASSWORD", True))
        Me.txtPassword.Location = New System.Drawing.Point(360, 49)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPassword.Properties.Appearance.Options.UseBackColor = True
        Me.txtPassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(178, 20)
        Me.txtPassword.TabIndex = 50
        '
        'txtUserName
        '
        Me.txtUserName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SpGetUsersBindingSource, "USER_NAME", True))
        Me.txtUserName.Location = New System.Drawing.Point(360, 25)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtUserName.Properties.Appearance.Options.UseBackColor = True
        Me.txtUserName.Size = New System.Drawing.Size(178, 20)
        Me.txtUserName.TabIndex = 40
        '
        'txtFirstName
        '
        Me.txtFirstName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SpGetUsersBindingSource, "FIRST_NAME", True))
        Me.txtFirstName.Location = New System.Drawing.Point(70, 25)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtFirstName.Properties.Appearance.Options.UseBackColor = True
        Me.txtFirstName.Size = New System.Drawing.Size(178, 20)
        Me.txtFirstName.TabIndex = 10
        '
        'txtLastName
        '
        Me.txtLastName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SpGetUsersBindingSource, "LAST_NAME", True))
        Me.txtLastName.Location = New System.Drawing.Point(70, 49)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtLastName.Properties.Appearance.Options.UseBackColor = True
        Me.txtLastName.Size = New System.Drawing.Size(178, 20)
        Me.txtLastName.TabIndex = 20
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.BorderColor = System.Drawing.Color.LightSteelBlue
        Me.LabelControl11.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl11.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl11.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.LabelControl11.Location = New System.Drawing.Point(5, 25)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(61, 20)
        Me.LabelControl11.TabIndex = 0
        Me.LabelControl11.Text = "First Name:"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.BorderColor = System.Drawing.Color.LightSteelBlue
        Me.LabelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl7.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.LabelControl7.Location = New System.Drawing.Point(5, 49)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(61, 20)
        Me.LabelControl7.TabIndex = 0
        Me.LabelControl7.Text = "Last Name:"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.BorderColor = System.Drawing.Color.LightSteelBlue
        Me.LabelControl8.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl8.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.LabelControl8.Location = New System.Drawing.Point(5, 73)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(61, 20)
        Me.LabelControl8.TabIndex = 0
        Me.LabelControl8.Text = "Email:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.BorderColor = System.Drawing.Color.LightSteelBlue
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.LabelControl1.Location = New System.Drawing.Point(252, 25)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(104, 20)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "ErcoView Username:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.BorderColor = System.Drawing.Color.LightSteelBlue
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.LabelControl2.Location = New System.Drawing.Point(252, 49)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(104, 20)
        Me.LabelControl2.TabIndex = 0
        Me.LabelControl2.Text = "ErcoView Password:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.BorderColor = System.Drawing.Color.LightSteelBlue
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.LabelControl3.Location = New System.Drawing.Point(252, 73)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(104, 20)
        Me.LabelControl3.TabIndex = 0
        Me.LabelControl3.Text = "Permission:"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.LabelControl11)
        Me.GroupControl1.Controls.Add(Me.chkSuper)
        Me.GroupControl1.Controls.Add(Me.chkSalesman)
        Me.GroupControl1.Controls.Add(Me.txtEmail)
        Me.GroupControl1.Controls.Add(Me.lblActive)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.txtPassword)
        Me.GroupControl1.Controls.Add(Me.txtUserName)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Controls.Add(Me.txtLastName)
        Me.GroupControl1.Controls.Add(Me.txtFirstName)
        Me.GroupControl1.Controls.Add(Me.LabelControl8)
        Me.GroupControl1.Controls.Add(Me.txtActiveStatus)
        Me.GroupControl1.Controls.Add(Me.cmboPermissions)
        Me.GroupControl1.Location = New System.Drawing.Point(0, 24)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(563, 133)
        Me.GroupControl1.TabIndex = 95
        Me.GroupControl1.Text = "User Information"
        '
        'lblActive
        '
        Me.lblActive.Appearance.BorderColor = System.Drawing.Color.LightSteelBlue
        Me.lblActive.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblActive.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblActive.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lblActive.Location = New System.Drawing.Point(252, 97)
        Me.lblActive.Name = "lblActive"
        Me.lblActive.Size = New System.Drawing.Size(104, 20)
        Me.lblActive.TabIndex = 0
        Me.lblActive.Text = "Active:"
        '
        'txtActiveStatus
        '
        Me.txtActiveStatus.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SpGetUsersBindingSource, "ACTIVE", True))
        Me.txtActiveStatus.EditValue = "Active"
        Me.txtActiveStatus.Location = New System.Drawing.Point(360, 97)
        Me.txtActiveStatus.Name = "txtActiveStatus"
        Me.txtActiveStatus.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtActiveStatus.Properties.Appearance.Options.UseBackColor = True
        Me.txtActiveStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtActiveStatus.Properties.Items.AddRange(New Object() {"Active", "Inactive"})
        Me.txtActiveStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtActiveStatus.Size = New System.Drawing.Size(178, 20)
        Me.txtActiveStatus.TabIndex = 70
        '
        'cmboPermissions
        '
        Me.cmboPermissions.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.SpGetUsersBindingSource, "PERMISSION_ID", True))
        Me.cmboPermissions.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BindingSource1, "PERMISSION", True))
        Me.cmboPermissions.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SpGetUsersBindingSource, "PERMISSION", True))
        Me.cmboPermissions.Location = New System.Drawing.Point(360, 73)
        Me.cmboPermissions.Name = "cmboPermissions"
        Me.cmboPermissions.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmboPermissions.Properties.Appearance.Options.UseBackColor = True
        Me.cmboPermissions.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmboPermissions.Properties.Items.AddRange(New Object() {"Admin", "General", "Superintendent"})
        Me.cmboPermissions.Properties.PopupSizeable = True
        Me.cmboPermissions.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmboPermissions.Size = New System.Drawing.Size(178, 20)
        Me.cmboPermissions.TabIndex = 60
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "spGetPermissions"
        Me.BindingSource1.DataSource = Me.DsErcoView1
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnSave), New DevExpress.XtraBars.LinkPersistInfo(Me.btnExit)})
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.UseWholeRow = True
        Me.Bar1.Text = "Tools"
        '
        'btnSave
        '
        Me.btnSave.Caption = "Save"
        Me.btnSave.Id = 0
        Me.btnSave.ImageIndex = 1
        Me.btnSave.Name = "btnSave"
        Me.btnSave.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'btnExit
        '
        Me.btnExit.Caption = "Exit"
        Me.btnExit.Id = 1
        Me.btnExit.ImageIndex = 0
        Me.btnExit.Name = "btnExit"
        Me.btnExit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 29)
        Me.barDockControlTop.Size = New System.Drawing.Size(563, 26)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 136)
        Me.barDockControlBottom.Size = New System.Drawing.Size(563, 22)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 55)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 81)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(563, 55)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 81)
        '
        'BarManager2
        '
        Me.BarManager2.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2, Me.Bar5})
        Me.BarManager2.DockControls.Add(Me.BarDockControl1)
        Me.BarManager2.DockControls.Add(Me.BarDockControl2)
        Me.BarManager2.DockControls.Add(Me.BarDockControl3)
        Me.BarManager2.DockControls.Add(Me.BarDockControl4)
        Me.BarManager2.Form = Me
        Me.BarManager2.Images = Me.ImageCollection1
        Me.BarManager2.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnSaveUser, Me.btnExitUser, Me.BarButtonItem1})
        Me.BarManager2.MaxItemId = 3
        Me.BarManager2.StatusBar = Me.Bar5
        '
        'Bar2
        '
        Me.Bar2.BarAppearance.Normal.Options.UseImage = True
        Me.Bar2.BarName = "Tools"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.FloatLocation = New System.Drawing.Point(336, 148)
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnSaveUser, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(CType((DevExpress.XtraBars.BarLinkUserDefines.Caption Or DevExpress.XtraBars.BarLinkUserDefines.PaintStyle), DevExpress.XtraBars.BarLinkUserDefines), Me.btnExitUser, "Exit", False, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Tools"
        '
        'btnSaveUser
        '
        Me.btnSaveUser.Caption = "Save"
        Me.btnSaveUser.Id = 0
        Me.btnSaveUser.ImageIndex = 1
        Me.btnSaveUser.Name = "btnSaveUser"
        Me.btnSaveUser.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'btnExitUser
        '
        Me.btnExitUser.Caption = "Exit"
        Me.btnExitUser.Id = 1
        Me.btnExitUser.ImageIndex = 0
        Me.btnExitUser.Name = "btnExitUser"
        '
        'Bar5
        '
        Me.Bar5.BarName = "Status bar"
        Me.Bar5.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar5.DockCol = 0
        Me.Bar5.DockRow = 0
        Me.Bar5.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar5.OptionsBar.AllowQuickCustomization = False
        Me.Bar5.OptionsBar.DrawDragBorder = False
        Me.Bar5.OptionsBar.UseWholeRow = True
        Me.Bar5.Text = "Status bar"
        '
        'BarDockControl1
        '
        Me.BarDockControl1.CausesValidation = False
        Me.BarDockControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl1.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl1.Size = New System.Drawing.Size(563, 29)
        '
        'BarDockControl2
        '
        Me.BarDockControl2.CausesValidation = False
        Me.BarDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl2.Location = New System.Drawing.Point(0, 158)
        Me.BarDockControl2.Size = New System.Drawing.Size(563, 21)
        '
        'BarDockControl3
        '
        Me.BarDockControl3.CausesValidation = False
        Me.BarDockControl3.Dock = System.Windows.Forms.DockStyle.Left
        Me.BarDockControl3.Location = New System.Drawing.Point(0, 29)
        Me.BarDockControl3.Size = New System.Drawing.Size(0, 129)
        '
        'BarDockControl4
        '
        Me.BarDockControl4.CausesValidation = False
        Me.BarDockControl4.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl4.Location = New System.Drawing.Point(563, 29)
        Me.BarDockControl4.Size = New System.Drawing.Size(0, 129)
        '
        'ImageCollection1
        '
        Me.ImageCollection1.ImageStream = CType(resources.GetObject("ImageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.ImageCollection1.Images.SetKeyName(0, "Close.png")
        Me.ImageCollection1.Images.SetKeyName(1, "Save 2.png")
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "541"
        Me.BarButtonItem1.Id = 2
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'SpGetUsersTableAdapter
        '
        Me.SpGetUsersTableAdapter.ClearBeforeFill = True
        '
        'SpGetPermissionsTableAdapter
        '
        Me.SpGetPermissionsTableAdapter.ClearBeforeFill = True
        '
        'frmUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(563, 179)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Controls.Add(Me.BarDockControl3)
        Me.Controls.Add(Me.BarDockControl4)
        Me.Controls.Add(Me.BarDockControl2)
        Me.Controls.Add(Me.BarDockControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.LookAndFeel.SkinName = "Seven Classic"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUser"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Users"
        CType(Me.SpGetUsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsErcoView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSalesman.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSuper.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUserName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFirstName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLastName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.txtActiveStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmboPermissions.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtEmail As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SpGetUsersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents txtPassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtUserName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFirstName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtLastName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents chkSalesman As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkSuper As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents SpGetPermissionsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnExit As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarManager2 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents btnSaveUser As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnExitUser As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Bar5 As DevExpress.XtraBars.Bar
    Friend WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl2 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl3 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl4 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents DsErcoView1 As ErcoView.dsErcoView
    'Friend WithEvents SpGetUsersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SpGetUsersTableAdapter As ErcoView.dsErcoViewTableAdapters.spGetUsersTableAdapter
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents SpGetPermissionsTableAdapter As ErcoView.dsErcoViewTableAdapters.spGetPermissionsTableAdapter
    Friend WithEvents lblActive As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtActiveStatus As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ImageCollection1 As DevExpress.Utils.ImageCollection
    Friend WithEvents cmboPermissions As DevExpress.XtraEditors.ComboBoxEdit
End Class
