<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJobNumbers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmJobNumbers))
        Me.btnNewJobNumber = New DevExpress.XtraEditors.SimpleButton()
        Me.btnOK = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.cmboJobNumbers = New DevExpress.XtraEditors.LookUpEdit()
        Me.SpGetJobNumbersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsErcoView = New ErcoView.dsErcoView()
        Me.SpGetJobNumbersTableAdapter = New ErcoView.dsErcoViewTableAdapters.spGetJobNumbersTableAdapter()
        Me.btnDelete = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.cmboJobNumbers.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpGetJobNumbersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsErcoView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnNewJobNumber
        '
        Me.btnNewJobNumber.Location = New System.Drawing.Point(3, 72)
        Me.btnNewJobNumber.Name = "btnNewJobNumber"
        Me.btnNewJobNumber.Size = New System.Drawing.Size(132, 23)
        Me.btnNewJobNumber.TabIndex = 1
        Me.btnNewJobNumber.Text = "New"
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(3, 29)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(55, 23)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "OK"
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(80, 29)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(55, 23)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel"
        '
        'cmboJobNumbers
        '
        Me.cmboJobNumbers.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.SpGetJobNumbersBindingSource, "JOB_NUMBER", True))
        Me.cmboJobNumbers.Location = New System.Drawing.Point(3, 3)
        Me.cmboJobNumbers.Name = "cmboJobNumbers"
        Me.cmboJobNumbers.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmboJobNumbers.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("JOB_NUMBER", "Job Number", 89, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.Ascending)})
        Me.cmboJobNumbers.Properties.DataSource = Me.SpGetJobNumbersBindingSource
        Me.cmboJobNumbers.Properties.DisplayMember = "JOB_NUMBER"
        Me.cmboJobNumbers.Properties.NullText = ""
        Me.cmboJobNumbers.Properties.ValueMember = "JOB_NUMBER"
        Me.cmboJobNumbers.Size = New System.Drawing.Size(132, 20)
        Me.cmboJobNumbers.TabIndex = 4
        '
        'SpGetJobNumbersBindingSource
        '
        Me.SpGetJobNumbersBindingSource.DataMember = "spGetJobNumbers"
        Me.SpGetJobNumbersBindingSource.DataSource = Me.DsErcoView
        '
        'DsErcoView
        '
        Me.DsErcoView.DataSetName = "dsErcoView"
        Me.DsErcoView.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SpGetJobNumbersTableAdapter
        '
        Me.SpGetJobNumbersTableAdapter.ClearBeforeFill = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(3, 105)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(132, 23)
        Me.btnDelete.TabIndex = 5
        Me.btnDelete.Text = "Delete"
        '
        'frmJobNumbers
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(141, 140)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.cmboJobNumbers)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnNewJobNumber)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.LookAndFeel.SkinName = "Seven Classic"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmJobNumbers"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Job Numbers"
        CType(Me.cmboJobNumbers.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpGetJobNumbersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsErcoView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnNewJobNumber As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnOK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmboJobNumbers As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents DsErcoView As ErcoView.dsErcoView
    Friend WithEvents SpGetJobNumbersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SpGetJobNumbersTableAdapter As ErcoView.dsErcoViewTableAdapters.spGetJobNumbersTableAdapter
    Friend WithEvents btnDelete As DevExpress.XtraEditors.SimpleButton
End Class
