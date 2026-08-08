Imports System.Data.SqlClient

Public Class frmCompletedProjectsSetup
    Public fromReport As String

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click

        If fromReport = "Sch" Then
            LoadSch()
        Else
            LoadCompletedPrj()

        End If

        My.Settings.reportYear = cmboYear.Text
        My.Settings.Save()
    End Sub

    Private Sub LoadCompletedPrj()
        Dim myReport As New rptCompletedProjects
        Dim myYear As Integer = cmboYear.Text
        Dim oConnString As String = GetConnectionString()
        myReport.SpRptCompletedPrjTableAdapter.Connection = New SqlConnection(oConnString)
        myReport.SpRptCompletedPrjTableAdapter.Fill(myReport.DsErcoView1.spRptCompletedPrj, myYear)
        ' myReport.myID = 0 Z

        Dim myReportPreview As New frmReportViewer
        myReport.CreateDocument()
        myReportPreview.XtraUserControl11.PrintControl1.PrintingSystem = myReport.PrintingSystem
        myReportPreview.ShowDialog()

        '' myReport.ShowPreview()
        Me.Close()
    End Sub

    Private Sub LoadSch()
        Dim myReport As New rptConstSch
        Dim myYear As Integer = cmboYear.Text
        Dim oConnString As String = GetConnectionString()
        myReport.SpRptConstSch2TableAdapter.Connection = New SqlConnection(oConnString)
        myReport.SpRptConstSch2TableAdapter.Fill(myReport.DsErcoView1.spRptConstSch2, myYear)
        ' myReport.myID = 0 Z


        Dim myReportPreview As New frmReportViewer
        myReport.CreateDocument()
        myReportPreview.XtraUserControl11.PrintControl1.PrintingSystem = myReport.PrintingSystem
        myReportPreview.ShowDialog()

        ''  myReport.ShowPreview()
        Me.Close()
    End Sub

    Private Sub frmCompletedProjectsSetup_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cmboYear.Text = My.Settings.reportYear

    End Sub

End Class