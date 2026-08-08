<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVendor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVendor))
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.cmboGroup = New DevExpress.XtraEditors.LookUpEdit()
        Me.SpGetGroupsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsErcoView = New ErcoView.dsErcoView()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCustomerName = New DevExpress.XtraEditors.TextEdit()
        Me.SpGetCustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.memoNotes = New DevExpress.XtraEditors.MemoEdit()
        Me.txtCity = New DevExpress.XtraEditors.TextEdit()
        Me.txtAddressLine2 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl()
        Me.txtAddressLine1 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCounty = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.txtWebsite = New DevExpress.XtraEditors.TextEdit()
        Me.cmboState = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.txtFax = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPhone = New DevExpress.XtraEditors.TextEdit()
        Me.txtZipCode = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.txtActiveStatus = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.btnExit = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.ImageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.SpGetCustomerTableAdapter = New ErcoView.dsErcoViewTableAdapters.spGetCustomerTableAdapter()
        Me.SpGetGroupsTableAdapter = New ErcoView.dsErcoViewTableAdapters.spGetGroupsTableAdapter()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.cmboGroup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpGetGroupsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsErcoView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustomerName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpGetCustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.memoNotes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCity.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAddressLine2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAddressLine1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCounty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtWebsite.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmboState.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFax.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPhone.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtZipCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtActiveStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.cmboGroup)
        Me.GroupControl2.Controls.Add(Me.LabelControl2)
        Me.GroupControl2.Controls.Add(Me.LabelControl1)
        Me.GroupControl2.Controls.Add(Me.LabelControl11)
        Me.GroupControl2.Controls.Add(Me.txtCustomerName)
        Me.GroupControl2.Controls.Add(Me.memoNotes)
        Me.GroupControl2.Controls.Add(Me.txtCity)
        Me.GroupControl2.Controls.Add(Me.txtAddressLine2)
        Me.GroupControl2.Controls.Add(Me.LabelControl20)
        Me.GroupControl2.Controls.Add(Me.txtAddressLine1)
        Me.GroupControl2.Controls.Add(Me.LabelControl3)
        Me.GroupControl2.Controls.Add(Me.LabelControl19)
        Me.GroupControl2.Controls.Add(Me.txtCounty)
        Me.GroupControl2.Controls.Add(Me.LabelControl18)
        Me.GroupControl2.Controls.Add(Me.LabelControl12)
        Me.GroupControl2.Controls.Add(Me.txtWebsite)
        Me.GroupControl2.Controls.Add(Me.cmboState)
        Me.GroupControl2.Controls.Add(Me.LabelControl17)
        Me.GroupControl2.Controls.Add(Me.txtFax)
        Me.GroupControl2.Controls.Add(Me.LabelControl13)
        Me.GroupControl2.Controls.Add(Me.txtPhone)
        Me.GroupControl2.Controls.Add(Me.txtZipCode)
        Me.GroupControl2.Controls.Add(Me.LabelControl14)
        Me.GroupControl2.Controls.Add(Me.LabelControl15)
        Me.GroupControl2.Controls.Add(Me.LabelControl16)
        Me.GroupControl2.Controls.Add(Me.txtActiveStatus)
        Me.GroupControl2.Location = New System.Drawing.Point(5, 31)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(608, 219)
        Me.GroupControl2.TabIndex = 3
        Me.GroupControl2.Text = "Customer Information"
        '
        'cmboGroup
        '
        Me.cmboGroup.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SpGetGroupsBindingSource, "GROUP_ID", True))
        Me.cmboGroup.Location = New System.Drawing.Point(94, 50)
        Me.cmboGroup.Name = "cmboGroup"
        Me.cmboGroup.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmboGroup.Properties.Appearance.Options.UseBackColor = True
        Me.cmboGroup.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmboGroup.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("GROUP_ID", "GROUP_ID", 75, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("GROUP_NAME", "GROUP_NAME", 79, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmboGroup.Properties.DataSource = Me.SpGetGroupsBindingSource
        Me.cmboGroup.Properties.DisplayMember = "GROUP_NAME"
        Me.cmboGroup.Properties.ShowHeader = False
        Me.cmboGroup.Properties.ValueMember = "GROUP_ID"
        Me.cmboGroup.Size = New System.Drawing.Size(507, 20)
        Me.cmboGroup.TabIndex = 3
        '
        'SpGetGroupsBindingSource
        '
        Me.SpGetGroupsBindingSource.DataMember = "spGetGroups"
        Me.SpGetGroupsBindingSource.DataSource = Me.DsErcoView
        '
        'DsErcoView
        '
        Me.DsErcoView.DataSetName = "dsErcoView"
        Me.DsErcoView.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.BorderColor = System.Drawing.Color.LightSteelBlue
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.LabelControl2.Location = New System.Drawing.Point(5, 50)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(83, 20)
        Me.LabelControl2.TabIndex = 89
        Me.LabelControl2.Text = "Group:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.BorderColor = System.Drawing.Color.LightSteelBlue
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.LabelControl1.Location = New System.Drawing.Point(5, 27)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(83, 20)
        Me.LabelControl1.TabIndex = 89
        Me.LabelControl1.Text = "Vendor Name:"
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.BorderColor = System.Drawing.Color.LightSteelBlue
        Me.LabelControl11.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl11.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl11.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.LabelControl11.Location = New System.Drawing.Point(5, 74)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(83, 20)
        Me.LabelControl11.TabIndex = 88
        Me.LabelControl11.Text = "Address Line 1:"
        '
        'txtCustomerName
        '
        Me.txtCustomerName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SpGetCustomerBindingSource, "CUSTOMER_NAME", True))
        Me.txtCustomerName.Location = New System.Drawing.Point(94, 24)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCustomerName.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtCustomerName.Properties.Appearance.Options.UseBackColor = True
        Me.txtCustomerName.Properties.Appearance.Options.UseFont = True
        Me.txtCustomerName.Size = New System.Drawing.Size(507, 22)
        Me.txtCustomerName.TabIndex = 0
        '
        'SpGetCustomerBindingSource
        '
        Me.SpGetCustomerBindingSource.DataMember = "spGetCustomer"
        Me.SpGetCustomerBindingSource.DataSource = Me.DsErcoView
        '
        'memoNotes
        '
        Me.memoNotes.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SpGetCustomerBindingSource, "CUSTOMER_NOTES", True))
        Me.memoNotes.Location = New System.Drawing.Point(380, 146)
        Me.memoNotes.Name = "memoNotes"
        Me.memoNotes.Size = New System.Drawing.Size(221, 44)
        Me.memoNotes.TabIndex = 19
        '
        'txtCity
        '
        Me.txtCity.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SpGetCustomerBindingSource, "CITY", True))
        Me.txtCity.Location = New System.Drawing.Point(94, 122)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCity.Properties.Appearance.Options.UseBackColor = True
        Me.txtCity.Size = New System.Drawing.Size(221, 20)
        Me.txtCity.TabIndex = 4
        '
        'txtAddressLine2
        '
        Me.txtAddressLine2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SpGetCustomerBindingSource, "ADDRESS_LINE2", True))
        Me.txtAddressLine2.Location = New System.Drawing.Point(94, 98)
        Me.txtAddressLine2.Name = "txtAddressLine2"
        Me.txtAddressLine2.Size = New System.Drawing.Size(221, 20)
        Me.txtAddressLine2.TabIndex = 2
        '
        'LabelControl20
        '
        Me.LabelControl20.Appearance.BorderColor = System.Drawing.Color.LightSteelBlue
        Me.LabelControl20.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl20.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl20.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.LabelControl20.Location = New System.Drawing.Point(321, 146)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(53, 20)
        Me.LabelControl20.TabIndex = 97
        Me.LabelControl20.Text = "Notes:"
        '
        'txtAddressLine1
        '
        Me.txtAddressLine1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SpGetCustomerBindingSource, "ADDRESS_LINE1", True))
        Me.txtAddressLine1.Location = New System.Drawing.Point(94, 74)
        Me.txtAddressLine1.Name = "txtAddressLine1"
        Me.txtAddressLine1.Size = New System.Drawing.Size(221, 20)
        Me.txtAddressLine1.TabIndex = 0
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.BorderColor = System.Drawing.Color.LightSteelBlue
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.LabelControl3.Location = New System.Drawing.Point(321, 194)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(53, 20)
        Me.LabelControl3.TabIndex = 96
        Me.LabelControl3.Text = "Active:"
        '
        'LabelControl19
        '
        Me.LabelControl19.Appearance.BorderColor = System.Drawing.Color.LightSteelBlue
        Me.LabelControl19.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl19.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl19.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.LabelControl19.Location = New System.Drawing.Point(321, 122)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(53, 20)
        Me.LabelControl19.TabIndex = 96
        Me.LabelControl19.Text = "Website:"
        '
        'txtCounty
        '
        Me.txtCounty.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SpGetCustomerBindingSource, "COUNTY", True))
        Me.txtCounty.Location = New System.Drawing.Point(94, 146)
        Me.txtCounty.Name = "txtCounty"
        Me.txtCounty.Size = New System.Drawing.Size(221, 20)
        Me.txtCounty.TabIndex = 6
        '
        'LabelControl18
        '
        Me.LabelControl18.Appearance.BorderColor = System.Drawing.Color.LightSteelBlue
        Me.LabelControl18.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl18.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl18.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.LabelControl18.Location = New System.Drawing.Point(321, 98)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(53, 20)
        Me.LabelControl18.TabIndex = 95
        Me.LabelControl18.Text = "Fax:"
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.BorderColor = System.Drawing.Color.LightSteelBlue
        Me.LabelControl12.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl12.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl12.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.LabelControl12.Location = New System.Drawing.Point(5, 98)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(83, 20)
        Me.LabelControl12.TabIndex = 89
        Me.LabelControl12.Text = "Address Line 2:"
        '
        'txtWebsite
        '
        Me.txtWebsite.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SpGetCustomerBindingSource, "WEBSITE", True))
        Me.txtWebsite.Location = New System.Drawing.Point(380, 122)
        Me.txtWebsite.Name = "txtWebsite"
        Me.txtWebsite.Size = New System.Drawing.Size(221, 20)
        Me.txtWebsite.TabIndex = 12
        '
        'cmboState
        '
        Me.cmboState.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SpGetCustomerBindingSource, "STATE", True))
        Me.cmboState.Location = New System.Drawing.Point(94, 170)
        Me.cmboState.Name = "cmboState"
        Me.cmboState.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmboState.Properties.Appearance.Options.UseBackColor = True
        Me.cmboState.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmboState.Properties.Items.AddRange(New Object() {"AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "DC", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY", "Other"})
        Me.cmboState.Size = New System.Drawing.Size(221, 20)
        Me.cmboState.TabIndex = 16
        '
        'LabelControl17
        '
        Me.LabelControl17.Appearance.BorderColor = System.Drawing.Color.LightSteelBlue
        Me.LabelControl17.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl17.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl17.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.LabelControl17.Location = New System.Drawing.Point(321, 74)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(53, 20)
        Me.LabelControl17.TabIndex = 94
        Me.LabelControl17.Text = "Phone:"
        '
        'txtFax
        '
        Me.txtFax.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SpGetCustomerBindingSource, "FAX", True))
        Me.txtFax.Location = New System.Drawing.Point(380, 98)
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Size = New System.Drawing.Size(221, 20)
        Me.txtFax.TabIndex = 10
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.BorderColor = System.Drawing.Color.LightSteelBlue
        Me.LabelControl13.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl13.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl13.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.LabelControl13.Location = New System.Drawing.Point(5, 122)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(83, 20)
        Me.LabelControl13.TabIndex = 90
        Me.LabelControl13.Text = "City:"
        '
        'txtPhone
        '
        Me.txtPhone.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SpGetCustomerBindingSource, "PHONE", True))
        Me.txtPhone.Location = New System.Drawing.Point(380, 74)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPhone.Properties.Appearance.Options.UseBackColor = True
        Me.txtPhone.Size = New System.Drawing.Size(221, 20)
        Me.txtPhone.TabIndex = 8
        '
        'txtZipCode
        '
        Me.txtZipCode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SpGetCustomerBindingSource, "ZIP_CODE", True))
        Me.txtZipCode.Location = New System.Drawing.Point(94, 194)
        Me.txtZipCode.Name = "txtZipCode"
        Me.txtZipCode.Size = New System.Drawing.Size(221, 20)
        Me.txtZipCode.TabIndex = 14
        '
        'LabelControl14
        '
        Me.LabelControl14.Appearance.BorderColor = System.Drawing.Color.LightSteelBlue
        Me.LabelControl14.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl14.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl14.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.LabelControl14.Location = New System.Drawing.Point(5, 146)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(83, 20)
        Me.LabelControl14.TabIndex = 91
        Me.LabelControl14.Text = "County:"
        '
        'LabelControl15
        '
        Me.LabelControl15.Appearance.BorderColor = System.Drawing.Color.LightSteelBlue
        Me.LabelControl15.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl15.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl15.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.LabelControl15.Location = New System.Drawing.Point(5, 170)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(83, 20)
        Me.LabelControl15.TabIndex = 92
        Me.LabelControl15.Text = "State:"
        '
        'LabelControl16
        '
        Me.LabelControl16.Appearance.BorderColor = System.Drawing.Color.LightSteelBlue
        Me.LabelControl16.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl16.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl16.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.LabelControl16.Location = New System.Drawing.Point(5, 194)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(83, 20)
        Me.LabelControl16.TabIndex = 93
        Me.LabelControl16.Text = "Zip Code:"
        '
        'txtActiveStatus
        '
        Me.txtActiveStatus.EditValue = "Active"
        Me.txtActiveStatus.Location = New System.Drawing.Point(380, 194)
        Me.txtActiveStatus.Name = "txtActiveStatus"
        Me.txtActiveStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtActiveStatus.Properties.Items.AddRange(New Object() {"Active", "Inactive"})
        Me.txtActiveStatus.Size = New System.Drawing.Size(221, 20)
        Me.txtActiveStatus.TabIndex = 12
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1, Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Images = Me.ImageCollection1
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnSave, Me.btnExit})
        Me.BarManager1.MaxItemId = 2
        Me.BarManager1.StatusBar = Me.Bar3
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
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(614, 29)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 252)
        Me.barDockControlBottom.Size = New System.Drawing.Size(614, 21)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 29)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 223)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(614, 29)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 223)
        '
        'ImageCollection1
        '
        Me.ImageCollection1.ImageStream = CType(resources.GetObject("ImageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.ImageCollection1.Images.SetKeyName(0, "Close.png")
        Me.ImageCollection1.Images.SetKeyName(1, "Save 2.png")
        '
        'SpGetCustomerTableAdapter
        '
        Me.SpGetCustomerTableAdapter.ClearBeforeFill = True
        '
        'SpGetGroupsTableAdapter
        '
        Me.SpGetGroupsTableAdapter.ClearBeforeFill = True
        '
        'frmVendor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 273)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.LookAndFeel.SkinName = "Seven Classic"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmVendor"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Vendor"
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.cmboGroup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpGetGroupsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsErcoView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustomerName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpGetCustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.memoNotes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCity.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAddressLine2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAddressLine1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCounty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtWebsite.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmboState.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFax.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPhone.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtZipCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtActiveStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cmboGroup As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCustomerName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents memoNotes As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtCity As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAddressLine2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAddressLine1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCounty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtWebsite As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmboState As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFax As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPhone As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtZipCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnExit As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents ImageCollection1 As DevExpress.Utils.ImageCollection
    Friend WithEvents SpGetCustomerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsErcoView As ErcoView.dsErcoView
    Friend WithEvents SpGetCustomerTableAdapter As ErcoView.dsErcoViewTableAdapters.spGetCustomerTableAdapter
    Friend WithEvents SpGetGroupsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SpGetGroupsTableAdapter As ErcoView.dsErcoViewTableAdapters.spGetGroupsTableAdapter
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtActiveStatus As DevExpress.XtraEditors.ComboBoxEdit
End Class
