<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBookingsSetup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBookingsSetup))
        Me.cmboYear = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.btnOK = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.cmboMonth = New DevExpress.XtraEditors.ComboBoxEdit()
        CType(Me.cmboYear.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmboMonth.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmboYear
        '
        Me.cmboYear.Location = New System.Drawing.Point(165, 42)
        Me.cmboYear.Name = "cmboYear"
        Me.cmboYear.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmboYear.Properties.Items.AddRange(New Object() {"2018", "2017", "2016", "2015", "2014", "2013", "2012", "2011", "2010", "2009", "2008", "2007", "2006", "2005", "2004", "2003", "2002", "2001", "2000", "1999"})
        Me.cmboYear.Size = New System.Drawing.Size(67, 20)
        Me.cmboYear.TabIndex = 3
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(103, 82)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "OK"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(165, 23)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(22, 13)
        Me.LabelControl1.TabIndex = 4
        Me.LabelControl1.Text = "Year"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(57, 23)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(30, 13)
        Me.LabelControl2.TabIndex = 6
        Me.LabelControl2.Text = "Month"
        '
        'cmboMonth
        '
        Me.cmboMonth.Location = New System.Drawing.Point(57, 42)
        Me.cmboMonth.Name = "cmboMonth"
        Me.cmboMonth.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmboMonth.Properties.Items.AddRange(New Object() {"All", "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"})
        Me.cmboMonth.Size = New System.Drawing.Size(67, 20)
        Me.cmboMonth.TabIndex = 5
        '
        'frmBookingsSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 133)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.cmboMonth)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.cmboYear)
        Me.Controls.Add(Me.btnOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.LookAndFeel.SkinName = "Seven Classic"
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBookingsSetup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Setup"
        CType(Me.cmboYear.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmboMonth.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmboYear As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents btnOK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmboMonth As DevExpress.XtraEditors.ComboBoxEdit
End Class
