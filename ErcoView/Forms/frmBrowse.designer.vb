<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBrowse
    Inherits DevExpress.XtraEditors.XtraForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBrowse))
        Me.TreeList1 = New DevExpress.XtraTreeList.TreeList()
        Me.TreeListColumn1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.ImageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.ImageListBoxControl1 = New DevExpress.XtraEditors.ImageListBoxControl()
        Me.btnCreateFolder = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDeleteFolder = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.TreeList1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageListBoxControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TreeList1
        '
        Me.TreeList1.AllowDrop = True
        Me.TreeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.TreeListColumn1})
        Me.TreeList1.ColumnsImageList = Me.ImageCollection1
        Me.TreeList1.CustomizationFormBounds = New System.Drawing.Rectangle(1712, 452, 208, 170)
        Me.TreeList1.Location = New System.Drawing.Point(6, 8)
        Me.TreeList1.Name = "TreeList1"
        Me.TreeList1.OptionsLayout.AddNewColumns = False
        Me.TreeList1.OptionsView.ShowIndicator = False
        Me.TreeList1.OptionsView.ShowPreview = True
        Me.TreeList1.SelectImageList = Me.ImageCollection1
        Me.TreeList1.ShowButtonMode = DevExpress.XtraTreeList.ShowButtonModeEnum.ShowForFocusedRow
        Me.TreeList1.Size = New System.Drawing.Size(219, 407)
        Me.TreeList1.TabIndex = 1
        '
        'TreeListColumn1
        '
        Me.TreeListColumn1.Caption = "Job Explorer"
        Me.TreeListColumn1.FieldName = "TreeListColumn1"
        Me.TreeListColumn1.ImageIndex = 0
        Me.TreeListColumn1.MinWidth = 33
        Me.TreeListColumn1.Name = "TreeListColumn1"
        Me.TreeListColumn1.OptionsColumn.AllowEdit = False
        Me.TreeListColumn1.OptionsColumn.AllowSort = False
        Me.TreeListColumn1.OptionsColumn.ReadOnly = True
        Me.TreeListColumn1.Visible = True
        Me.TreeListColumn1.VisibleIndex = 0
        Me.TreeListColumn1.Width = 92
        '
        'ImageCollection1
        '
        Me.ImageCollection1.ImageStream = CType(resources.GetObject("ImageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.ImageCollection1.Images.SetKeyName(0, "Folder.png")
        Me.ImageCollection1.Images.SetKeyName(1, "image.ico")
        '
        'ImageListBoxControl1
        '
        Me.ImageListBoxControl1.AllowDrop = True
        Me.ImageListBoxControl1.Location = New System.Drawing.Point(231, 8)
        Me.ImageListBoxControl1.Name = "ImageListBoxControl1"
        Me.ImageListBoxControl1.Size = New System.Drawing.Size(383, 438)
        Me.ImageListBoxControl1.TabIndex = 2
        '
        'btnCreateFolder
        '
        Me.btnCreateFolder.Location = New System.Drawing.Point(6, 423)
        Me.btnCreateFolder.Name = "btnCreateFolder"
        Me.btnCreateFolder.Size = New System.Drawing.Size(100, 23)
        Me.btnCreateFolder.TabIndex = 3
        Me.btnCreateFolder.Text = "Create Folder"
        '
        'btnDeleteFolder
        '
        Me.btnDeleteFolder.Location = New System.Drawing.Point(112, 423)
        Me.btnDeleteFolder.Name = "btnDeleteFolder"
        Me.btnDeleteFolder.Size = New System.Drawing.Size(113, 23)
        Me.btnDeleteFolder.TabIndex = 4
        Me.btnDeleteFolder.Text = "Delete Folder"
        '
        'frmBrowse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(621, 451)
        Me.Controls.Add(Me.btnDeleteFolder)
        Me.Controls.Add(Me.btnCreateFolder)
        Me.Controls.Add(Me.ImageListBoxControl1)
        Me.Controls.Add(Me.TreeList1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.LookAndFeel.SkinName = "Seven Classic"
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBrowse"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Explorer"
        CType(Me.TreeList1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageListBoxControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TreeList1 As DevExpress.XtraTreeList.TreeList
    Friend WithEvents ImageListBoxControl1 As DevExpress.XtraEditors.ImageListBoxControl
    Friend WithEvents ImageCollection1 As DevExpress.Utils.ImageCollection
    Friend WithEvents TreeListColumn1 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents btnCreateFolder As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDeleteFolder As DevExpress.XtraEditors.SimpleButton

End Class
