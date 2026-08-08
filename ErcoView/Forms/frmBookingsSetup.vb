Imports System.Data.SqlClient
Public Class frmBookingsSetup


    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        Dim myReport As New rptBookings
        Dim myYear As Integer = cmboYear.Text
        Dim myMonth As Int16 = cmboMonth.SelectedIndex
        Dim oConnString As String = GetConnectionString()
        myReport.SpGetBookingsTableAdapter.Connection = New SqlConnection(oConnString)
        myReport.SpGetBookingsTableAdapter.Fill(myReport.DsErcoView1.spGetBookings, myYear, myMonth)
        ' myReport.myID = 0 Z


        Dim myReportPreview As New frmReportViewer
        myReport.CreateDocument()
        myReportPreview.XtraUserControl11.PrintControl1.PrintingSystem = myReport.PrintingSystem
        myReportPreview.ShowDialog()
        '' myReport.ShowPreview()

        My.Settings.bookingMonth = cmboMonth.Text
        My.Settings.bookingYear = cmboYear.Text
        My.Settings.Save()
        Me.Close()
    End Sub


    Private Sub frmBookingsSetup_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cmboMonth.Text = My.Settings.bookingMonth
        cmboYear.Text = My.Settings.bookingYear
    End Sub
End Class