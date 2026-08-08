<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReports
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReports))
        Me.btnConstructionForecast = New DevExpress.XtraEditors.SimpleButton()
        Me.btnRpt2 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnHotSeat = New DevExpress.XtraEditors.SimpleButton()
        Me.btnBookings = New DevExpress.XtraEditors.SimpleButton()
        Me.btnOrderRec = New DevExpress.XtraEditors.SimpleButton()
        Me.btnConstructionSchedule = New DevExpress.XtraEditors.SimpleButton()
        Me.btnNORReport = New DevExpress.XtraEditors.SimpleButton()
        Me.SuspendLayout()
        '
        'btnConstructionForecast
        '
        Me.btnConstructionForecast.Location = New System.Drawing.Point(16, 15)
        Me.btnConstructionForecast.Name = "btnConstructionForecast"
        Me.btnConstructionForecast.Size = New System.Drawing.Size(148, 23)
        Me.btnConstructionForecast.TabIndex = 0
        Me.btnConstructionForecast.Text = "Revenue Forcast"
        '
        'btnRpt2
        '
        Me.btnRpt2.Location = New System.Drawing.Point(16, 77)
        Me.btnRpt2.Name = "btnRpt2"
        Me.btnRpt2.Size = New System.Drawing.Size(148, 23)
        Me.btnRpt2.TabIndex = 1
        Me.btnRpt2.Text = "Completed Projects"
        '
        'btnHotSeat
        '
        Me.btnHotSeat.Location = New System.Drawing.Point(16, 139)
        Me.btnHotSeat.Name = "btnHotSeat"
        Me.btnHotSeat.Size = New System.Drawing.Size(148, 23)
        Me.btnHotSeat.TabIndex = 2
        Me.btnHotSeat.Text = "Hot Seat"
        '
        'btnBookings
        '
        Me.btnBookings.Location = New System.Drawing.Point(16, 108)
        Me.btnBookings.Name = "btnBookings"
        Me.btnBookings.Size = New System.Drawing.Size(148, 23)
        Me.btnBookings.TabIndex = 3
        Me.btnBookings.Text = "Bookings Report"
        '
        'btnOrderRec
        '
        Me.btnOrderRec.Location = New System.Drawing.Point(16, 170)
        Me.btnOrderRec.Name = "btnOrderRec"
        Me.btnOrderRec.Size = New System.Drawing.Size(148, 23)
        Me.btnOrderRec.TabIndex = 4
        Me.btnOrderRec.Text = "Order Received"
        '
        'btnConstructionSchedule
        '
        Me.btnConstructionSchedule.Location = New System.Drawing.Point(16, 46)
        Me.btnConstructionSchedule.Name = "btnConstructionSchedule"
        Me.btnConstructionSchedule.Size = New System.Drawing.Size(148, 23)
        Me.btnConstructionSchedule.TabIndex = 5
        Me.btnConstructionSchedule.Text = "Construction Schedule"
        '
        'btnNORReport
        '
        Me.btnNORReport.Location = New System.Drawing.Point(16, 201)
        Me.btnNORReport.Name = "btnNORReport"
        Me.btnNORReport.Size = New System.Drawing.Size(148, 23)
        Me.btnNORReport.TabIndex = 4
        Me.btnNORReport.Text = "NOR Report"
        '
        'frmReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(178, 236)
        Me.Controls.Add(Me.btnConstructionSchedule)
        Me.Controls.Add(Me.btnNORReport)
        Me.Controls.Add(Me.btnOrderRec)
        Me.Controls.Add(Me.btnBookings)
        Me.Controls.Add(Me.btnHotSeat)
        Me.Controls.Add(Me.btnRpt2)
        Me.Controls.Add(Me.btnConstructionForecast)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.LookAndFeel.SkinName = "Seven Classic"
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmReports"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Reports"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnConstructionForecast As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRpt2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnHotSeat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnBookings As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnOrderRec As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnConstructionSchedule As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnNORReport As DevExpress.XtraEditors.SimpleButton
End Class
