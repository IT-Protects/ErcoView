<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmList))
        Me.lstItemList = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.SpGetVendorsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsErcoView = New ErcoView.dsErcoView()
        Me.btnOK = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.SpGetGroupsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SpGetCustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SpGetCustomersTableAdapter = New ErcoView.dsErcoViewTableAdapters.spGetCustomersTableAdapter()
        Me.SpGetJobTypesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SpGetJobTypesTableAdapter = New ErcoView.dsErcoViewTableAdapters.spGetJobTypesTableAdapter()
        Me.SpGetSalesmanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SpGetSalesmanTableAdapter = New ErcoView.dsErcoViewTableAdapters.spGetSalesmanTableAdapter()
        Me.SpGetContactsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SpGetContactsTableAdapter = New ErcoView.dsErcoViewTableAdapters.spGetContactsTableAdapter()
        Me.SpGetSuperBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SpGetSuperTableAdapter = New ErcoView.dsErcoViewTableAdapters.spGetSuperTableAdapter()
        Me.SpGetGroupsTableAdapter = New ErcoView.dsErcoViewTableAdapters.spGetGroupsTableAdapter()
        Me.SpGetVendorsTableAdapter = New ErcoView.dsErcoViewTableAdapters.spGetVendorsTableAdapter()
        CType(Me.lstItemList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpGetVendorsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsErcoView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpGetGroupsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpGetCustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpGetJobTypesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpGetSalesmanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpGetContactsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpGetSuperBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstItemList
        '
        Me.lstItemList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstItemList.CheckOnClick = True
        Me.lstItemList.Location = New System.Drawing.Point(3, 2)
        Me.lstItemList.Name = "lstItemList"
        Me.lstItemList.Size = New System.Drawing.Size(170, 260)
        Me.lstItemList.TabIndex = 5
        '
        'SpGetVendorsBindingSource
        '
        Me.SpGetVendorsBindingSource.DataMember = "spGetVendors"
        Me.SpGetVendorsBindingSource.DataSource = Me.DsErcoView
        '
        'DsErcoView
        '
        Me.DsErcoView.DataSetName = "dsErcoView"
        Me.DsErcoView.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnOK.Location = New System.Drawing.Point(3, 268)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 6
        Me.btnOK.Text = "OK"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(98, 268)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "Cancel"
        '
        'SpGetGroupsBindingSource
        '
        Me.SpGetGroupsBindingSource.DataMember = "spGetGroups"
        Me.SpGetGroupsBindingSource.DataSource = Me.DsErcoView
        '
        'SpGetCustomersBindingSource
        '
        Me.SpGetCustomersBindingSource.DataMember = "spGetCustomers"
        Me.SpGetCustomersBindingSource.DataSource = Me.DsErcoView
        '
        'SpGetCustomersTableAdapter
        '
        Me.SpGetCustomersTableAdapter.ClearBeforeFill = True
        '
        'SpGetJobTypesBindingSource
        '
        Me.SpGetJobTypesBindingSource.DataMember = "spGetJobTypes"
        Me.SpGetJobTypesBindingSource.DataSource = Me.DsErcoView
        '
        'SpGetJobTypesTableAdapter
        '
        Me.SpGetJobTypesTableAdapter.ClearBeforeFill = True
        '
        'SpGetSalesmanBindingSource
        '
        Me.SpGetSalesmanBindingSource.DataMember = "spGetSalesman"
        Me.SpGetSalesmanBindingSource.DataSource = Me.DsErcoView
        '
        'SpGetSalesmanTableAdapter
        '
        Me.SpGetSalesmanTableAdapter.ClearBeforeFill = True
        '
        'SpGetContactsBindingSource
        '
        Me.SpGetContactsBindingSource.DataMember = "spGetContacts"
        Me.SpGetContactsBindingSource.DataSource = Me.DsErcoView
        '
        'SpGetContactsTableAdapter
        '
        Me.SpGetContactsTableAdapter.ClearBeforeFill = True
        '
        'SpGetSuperBindingSource
        '
        Me.SpGetSuperBindingSource.DataMember = "spGetSuper"
        Me.SpGetSuperBindingSource.DataSource = Me.DsErcoView
        '
        'SpGetSuperTableAdapter
        '
        Me.SpGetSuperTableAdapter.ClearBeforeFill = True
        '
        'SpGetGroupsTableAdapter
        '
        Me.SpGetGroupsTableAdapter.ClearBeforeFill = True
        '
        'SpGetVendorsTableAdapter
        '
        Me.SpGetVendorsTableAdapter.ClearBeforeFill = True
        '
        'frmList
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(177, 303)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.lstItemList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.LookAndFeel.SkinName = "Seven Classic"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmList"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Job Type"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        CType(Me.lstItemList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpGetVendorsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsErcoView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpGetGroupsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpGetCustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpGetJobTypesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpGetSalesmanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpGetContactsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpGetSuperBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstItemList As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents btnOK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DsErcoView As ErcoView.dsErcoView
    Friend WithEvents SpGetSalesmanTableAdapter As ErcoView.dsErcoViewTableAdapters.spGetSalesmanTableAdapter
    Friend WithEvents SpGetJobTypesTableAdapter As ErcoView.dsErcoViewTableAdapters.spGetJobTypesTableAdapter
    Friend WithEvents SpGetCustomersTableAdapter As ErcoView.dsErcoViewTableAdapters.spGetCustomersTableAdapter
    Friend WithEvents SpGetSuperTableAdapter As ErcoView.dsErcoViewTableAdapters.spGetSuperTableAdapter
    Friend WithEvents SpGetVendorTableAdapter As ErcoView.dsErcoViewTableAdapters.spGetVendorTableAdapter

    Friend WithEvents SpGetCustomersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SpGetJobTypesBindingSource As System.Windows.Forms.BindingSource
       Friend WithEvents SpGetSalesmanBindingSource As System.Windows.Forms.BindingSource
     Friend WithEvents SpGetContactsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SpGetContactsTableAdapter As ErcoView.dsErcoViewTableAdapters.spGetContactsTableAdapter
    Friend WithEvents SpGetSuperBindingSource As System.Windows.Forms.BindingSource
      Friend WithEvents SpGetVendorsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SpGetGroupsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SpGetGroupsTableAdapter As ErcoView.dsErcoViewTableAdapters.spGetGroupsTableAdapter
    Friend WithEvents SpGetVendorsTableAdapter As ErcoView.dsErcoViewTableAdapters.spGetVendorsTableAdapter
End Class
