Imports System.Data.SqlClient

Public Class frmReportSetup

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        'Dim myReport As New rptProposalByMonth(cmboBookMonth.Text, cmboBookYear.Text)
        Dim myReport As New rptConstForcast
        Dim constSchStatus As String = cmboConstStatus.Text
        Dim oConnString As String = GetConnectionString()
        myReport.SpRptConstSchTableAdapter.Connection = New SqlConnection(oConnString)
        myReport.SpRptConstSchTableAdapter.Fill(myReport.DsErcoView1.spRptConstSch, constSchStatus)

        Dim myReportPreview As New frmReportViewer
        myReport.CreateDocument()
        myReportPreview.XtraUserControl11.PrintControl1.PrintingSystem = myReport.PrintingSystem
        myReportPreview.ShowDialog()
        ''  myReport.ShowPreview()

        Me.Close()
    End Sub

    
End Class