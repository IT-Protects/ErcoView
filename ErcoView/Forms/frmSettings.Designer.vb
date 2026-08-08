<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSettings))
        Me.txtProposalFolder = New DevExpress.XtraEditors.TextEdit()
        Me.txtLayoutFolderLocal = New DevExpress.XtraEditors.TextEdit()
        Me.txtExternalIP = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.btnOK = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btnPassword = New DevExpress.XtraEditors.SimpleButton()
        Me.txtLayoutFolderServer = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtInternalIP = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.txtProposalFolder.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLayoutFolderLocal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExternalIP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLayoutFolderServer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInternalIP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtProposalFolder
        '
        Me.txtProposalFolder.Location = New System.Drawing.Point(40, 31)
        Me.txtProposalFolder.Name = "txtProposalFolder"
        Me.txtProposalFolder.Size = New System.Drawing.Size(318, 20)
        Me.txtProposalFolder.TabIndex = 0
        '
        'txtLayoutFolderLocal
        '
        Me.txtLayoutFolderLocal.Location = New System.Drawing.Point(40, 124)
        Me.txtLayoutFolderLocal.Name = "txtLayoutFolderLocal"
        Me.txtLayoutFolderLocal.Size = New System.Drawing.Size(318, 20)
        Me.txtLayoutFolderLocal.TabIndex = 1
        '
        'txtExternalIP
        '
        Me.txtExternalIP.Location = New System.Drawing.Point(40, 215)
        Me.txtExternalIP.Name = "txtExternalIP"
        Me.txtExternalIP.Properties.Mask.BeepOnError = True
        Me.txtExternalIP.Properties.Mask.EditMask = "(([0-1]?[0-9]{1,2}\.)|(2[0-4][0-9]\.)|(25[0-5]\.)){3}(([0-1]?[0-9]{1,2})|(2[0-4][" & _
    "0-9])|(25[0-5]))"
        Me.txtExternalIP.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.txtExternalIP.Properties.Mask.PlaceHolder = Global.Microsoft.VisualBasic.ChrW(46)
        Me.txtExternalIP.Properties.Mask.ShowPlaceHolders = False
        Me.txtExternalIP.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtExternalIP.Size = New System.Drawing.Size(318, 20)
        Me.txtExternalIP.TabIndex = 2
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(78, 13)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "Proposal Folder:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(12, 105)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(102, 13)
        Me.LabelControl2.TabIndex = 4
        Me.LabelControl2.Text = "Layouts Local Folder:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(9, 196)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(76, 13)
        Me.LabelControl3.TabIndex = 5
        Me.LabelControl3.Text = "Remote SQL IP:"
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(199, 287)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "OK"
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(280, 287)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "Cancel"
        '
        'btnPassword
        '
        Me.btnPassword.Location = New System.Drawing.Point(9, 258)
        Me.btnPassword.Name = "btnPassword"
        Me.btnPassword.Size = New System.Drawing.Size(346, 23)
        Me.btnPassword.TabIndex = 8
        Me.btnPassword.Text = "Reset Password"
        '
        'txtLayoutFolderServer
        '
        Me.txtLayoutFolderServer.Location = New System.Drawing.Point(40, 79)
        Me.txtLayoutFolderServer.Name = "txtLayoutFolderServer"
        Me.txtLayoutFolderServer.Size = New System.Drawing.Size(318, 20)
        Me.txtLayoutFolderServer.TabIndex = 1
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(12, 60)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(110, 13)
        Me.LabelControl4.TabIndex = 4
        Me.LabelControl4.Text = "Layouts Server Folder:"
        '
        'txtInternalIP
        '
        Me.txtInternalIP.Location = New System.Drawing.Point(40, 169)
        Me.txtInternalIP.Name = "txtInternalIP"
        Me.txtInternalIP.Size = New System.Drawing.Size(318, 20)
        Me.txtInternalIP.TabIndex = 2
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(12, 150)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl5.TabIndex = 5
        Me.LabelControl5.Text = "Local SQL IP:"
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(362, 317)
        Me.Controls.Add(Me.btnPassword)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtInternalIP)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtExternalIP)
        Me.Controls.Add(Me.txtLayoutFolderServer)
        Me.Controls.Add(Me.txtLayoutFolderLocal)
        Me.Controls.Add(Me.txtProposalFolder)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.LookAndFeel.SkinName = "Seven Classic"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSettings"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Settings"
        CType(Me.txtProposalFolder.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLayoutFolderLocal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExternalIP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLayoutFolderServer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInternalIP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtProposalFolder As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtLayoutFolderLocal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtExternalIP As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnOK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnPassword As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtLayoutFolderServer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtInternalIP As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
End Class
