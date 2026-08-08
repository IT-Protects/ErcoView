<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLayoutSave
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLayoutSave))
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.btnOk = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkSuperintendentUser = New DevExpress.XtraEditors.CheckEdit()
        Me.chkGeneralUser = New DevExpress.XtraEditors.CheckEdit()
        Me.txtLayoutName = New DevExpress.XtraEditors.TextEdit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.chkSuperintendentUser.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkGeneralUser.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLayoutName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 31)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Layout Name"
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(200, 56)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 2
        Me.btnOk.Text = "Ok"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(286, 56)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkSuperintendentUser)
        Me.GroupBox1.Controls.Add(Me.chkGeneralUser)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 85)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(349, 53)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Who sees it?"
        Me.GroupBox1.Visible = False
        '
        'chkSuperintendentUser
        '
        Me.chkSuperintendentUser.Location = New System.Drawing.Point(186, 19)
        Me.chkSuperintendentUser.Name = "chkSuperintendentUser"
        Me.chkSuperintendentUser.Properties.Caption = "Superintendent"
        Me.chkSuperintendentUser.Size = New System.Drawing.Size(98, 19)
        Me.chkSuperintendentUser.TabIndex = 0
        '
        'chkGeneralUser
        '
        Me.chkGeneralUser.Location = New System.Drawing.Point(67, 19)
        Me.chkGeneralUser.Name = "chkGeneralUser"
        Me.chkGeneralUser.Properties.Caption = "General User"
        Me.chkGeneralUser.Size = New System.Drawing.Size(90, 19)
        Me.chkGeneralUser.TabIndex = 0
        '
        'txtLayoutName
        '
        Me.txtLayoutName.EditValue = ""
        Me.txtLayoutName.Location = New System.Drawing.Point(81, 28)
        Me.txtLayoutName.Name = "txtLayoutName"
        Me.txtLayoutName.Size = New System.Drawing.Size(280, 20)
        Me.txtLayoutName.TabIndex = 0
        '
        'frmLayoutSave
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(368, 87)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtLayoutName)
        Me.Controls.Add(Me.btnOk)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLayoutSave"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Save Layout"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.chkSuperintendentUser.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkGeneralUser.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLayoutName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnOk As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkSuperintendentUser As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkGeneralUser As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtLayoutName As DevExpress.XtraEditors.TextEdit
End Class
