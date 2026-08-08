Imports System.Data.SqlClient

Public Class frmReports
    Public pID As Int16

    Private Sub btnRpt2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRpt2.Click
        Using myForm As New frmCompletedProjectsSetup
            myForm.ShowDialog()
            Me.Close()
        End Using
    End Sub

    Private Sub btnRpt1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConstructionForecast.Click
        Using myForm As New frmReportSetup
            myForm.ShowDialog()
            Me.Close()
        End Using
    End Sub

    Private Sub btnHotSeat_Click(sender As System.Object, e As System.EventArgs) Handles btnHotSeat.Click
        Using myReport As New rptHotSeat
            Dim oConnString As String = GetConnectionString()
            myReport.SpGetProposalsTableAdapter.Connection = New SqlConnection(oConnString)
            myReport.SpGetProposalsTableAdapter.Fill(myReport.DsErcoView1.spGetProposals, pID)


            Dim myReportPreview As New frmReportViewer
            myReport.CreateDocument()
            myReportPreview.XtraUserControl11.PrintControl1.PrintingSystem = myReport.PrintingSystem
            myReportPreview.ShowDialog()

            Me.Close()
        End Using
    End Sub

    Private Sub btnBookings_Click(sender As System.Object, e As System.EventArgs) Handles btnBookings.Click
        Using myForm As New frmBookingsSetup
            myForm.ShowDialog()
            Me.Close()
        End Using
    End Sub

    Private Sub btnNORReport_Click(sender As System.Object, e As System.EventArgs) Handles btnNORReport.Click
        Using myReport As New rptNOR
            Dim oConnString As String = GetConnectionString()
            myReport.SpGetProposalsTableAdapter1.Connection = New SqlConnection(oConnString)
            myReport.SpGetProposalsTableAdapter1.Fill(myReport.DsErcoView1.spGetProposals, pID)
            ' myReport.myID = 0 Z

            Dim myReportPreview As New frmReportViewer
            myReport.CreateDocument()
            myReportPreview.XtraUserControl11.PrintControl1.PrintingSystem = myReport.PrintingSystem
            myReportPreview.ShowDialog()
            '' myReport.ShowPreview()
            Me.Close()
        End Using
    End Sub

    Private Sub btnOrderRec_Click(sender As System.Object, e As System.EventArgs) Handles btnOrderRec.Click
        Using myReport As New rptOrderReceived
            Dim oConnString As String = GetConnectionString()
            myReport.SpGetProposalsTableAdapter.Connection = New SqlConnection(oConnString)
            myReport.SpGetProposalsTableAdapter.Fill(myReport.DsErcoView1.spGetProposals, pID)
            ' myReport.myID = 0 Z

            Dim myReportPreview As New frmReportViewer
            myReport.CreateDocument()
            myReportPreview.XtraUserControl11.PrintControl1.PrintingSystem = myReport.PrintingSystem
            myReportPreview.ShowDialog()
            '' myReport.ShowPreview()
            Me.Close()

        End Using
    End Sub

    Private Sub SimpleButton1_Click(sender As System.Object, e As System.EventArgs) Handles btnConstructionSchedule.Click
        Dim myForm As New frmCompletedProjectsSetup
        myForm.fromReport = "Sch"
        myForm.ShowDialog()
        Me.Close()
    End Sub

End Class