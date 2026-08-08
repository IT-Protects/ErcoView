<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportViewer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReportViewer))
        Me.XtraUserControl11 = New ErcoView.XtraUserControl1()
        Me.SuspendLayout()
        '
        'XtraUserControl11
        '
        Me.XtraUserControl11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraUserControl11.Location = New System.Drawing.Point(0, 0)
        Me.XtraUserControl11.LookAndFeel.SkinName = "Seven Classic"
        Me.XtraUserControl11.Name = "XtraUserControl11"
        Me.XtraUserControl11.Size = New System.Drawing.Size(796, 831)
        Me.XtraUserControl11.TabIndex = 1
        '
        'frmReportViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 831)
        Me.Controls.Add(Me.XtraUserControl11)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmReportViewer"
        Me.Text = "Report Viewer"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents XtraUserControl11 As ErcoView.XtraUserControl1
End Class
