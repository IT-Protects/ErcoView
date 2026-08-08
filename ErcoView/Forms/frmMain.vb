Imports System.Data.SqlClient
Public Class frmMain
    ' New events
    Public Event eNewProposal()
    Public Event eNewCustomer()
    Public Event eNewUser()
    Public Event eNewVendor()
    Public Event eNewContact()
    Public Event eNewGroup()

    ' Edit Events
    Public Event eEditCustomer()
    Public Event eEditVendor()
    Public Event eEditProposal()
    Public Event eEditUser()
    Public Event eEditContact()

    'Export Events
    Public Event eExportCustomer()
    Public Event eExportVendor()
    Public Event eExportProposal()
    Public Event eExportUser()
    Public Event eExportContact()

    ' Remove Events
    Public Event eRemoveProposalLayout()

    ' SaveAs Events
    Public Event eSaveAsNewProposalLayout()

    ' Save Events
    Public Event eSaveNewProposalLayout()

    Public Event eChangeLayoutProposal()

    Public Event eSwitchGrid()
    Public Event eViewMap()
    Public Event eClickSettings()
    Public Event eHotSeat()

#Region "Edit events on double click"
    Private Sub GridProposals_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridProposals.DoubleClick
        RaiseEvent eEditProposal()
    End Sub

    Private Sub GridContacts_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridContacts.DoubleClick
        If userPermission = 1 Then ' Only Admin
            RaiseEvent eEditContact()
        Else
            MsgBox("Only Administrator edit Contact")
        End If
    End Sub

    Private Sub GridUsers_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridUsers.DoubleClick
        RaiseEvent eEditUser()
    End Sub

    Private Sub GridCustomers_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridCustomers.DoubleClick
        If userPermission = 1 Then ' Only Admin
            RaiseEvent eEditCustomer()
        Else
            MsgBox("Only Administrator edit Customer")
        End If

    End Sub

    Private Sub GridVendors_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridVendors.DoubleClick
        ' March 25, 2014. Please add the ability to add/edit vendors under the vendor tab to the general user's rights. 
        If userPermission = 1 Or userPermission = 2 Then ' Only Admin
            RaiseEvent eEditVendor()
        Else
            MsgBox("Only Administrator edit Vendor")
        End If

    End Sub

#End Region

#Region "New button events"

    Private Sub bntNewCustomer_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNewCustomer.ItemClick
        RaiseEvent eNewCustomer()
    End Sub

    Private Sub btnNewProposal_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNewProposal.ItemClick
        RaiseEvent eNewProposal()
    End Sub

    Private Sub btnNewUser_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNewUser.ItemClick
        RaiseEvent eNewUser()
    End Sub

    Private Sub btnNewPageVendor_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNewVendor.ItemClick
        RaiseEvent eNewVendor()
    End Sub

    Private Sub btnNew_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNew.ItemClick
        RaiseEvent eNewContact()
    End Sub


    Private Sub btnNewGroup_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNewGroup.ItemClick
        RaiseEvent eNewGroup()
    End Sub
#End Region

#Region "Export Events"

    Private Sub btnExportProposal_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExportProposal.ItemClick
        RaiseEvent eExportProposal()
    End Sub


    Private Sub btnExportUser_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExportUser.ItemClick
        RaiseEvent eExportUser()
    End Sub

    Private Sub btnExportVendor_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExportVendor.ItemClick
        RaiseEvent eExportVendor()
    End Sub

    Private Sub btnExportContact_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExportContact.ItemClick
        RaiseEvent eExportContact()
    End Sub

    Private Sub btnExportCustomer_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExportCustomer.ItemClick
        RaiseEvent eExportCustomer()
    End Sub

#End Region

#Region "Report Events"

    Private Sub btnReportProposal_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnReportProposal.ItemClick

        Dim pID As Integer
        Dim myEditRow As DataRow = gridViewProposal.GetDataRow(gridViewProposal.FocusedRowHandle)
        If myEditRow IsNot Nothing Then
            pID = myEditRow("PROPOSAL_ID").ToString

        End If
        Using ofrm As New frmReports()
            ofrm.pID = pID
            ofrm.ShowDialog()
        End Using
    End Sub

    Private Sub btnReportCustomer_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim myReport As New rptTest2
        'myReport.myID = 5


        Dim myReportPreview As New frmReportViewer
        myReport.CreateDocument()
        myReportPreview.XtraUserControl11.PrintControl1.PrintingSystem = myReport.PrintingSystem
        myReportPreview.ShowDialog()

        ''  myReport.ShowPreview()
    End Sub

    Private Sub btnReportContact_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnReportContact.ItemClick
        Dim myReport As New rptTest2
        ' myReport.myID = 5


        Dim myReportPreview As New frmReportViewer
        myReport.CreateDocument()
        myReportPreview.XtraUserControl11.PrintControl1.PrintingSystem = myReport.PrintingSystem
        myReportPreview.ShowDialog()
        ''  myReport.ShowPreview()
    End Sub

    Private Sub btnReportUser_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim myReport As New rptTest2
        'myReport.myID = 5


        Dim myReportPreview As New frmReportViewer
        myReport.CreateDocument()
        myReportPreview.XtraUserControl11.PrintControl1.PrintingSystem = myReport.PrintingSystem
        myReportPreview.ShowDialog()

        ''  myReport.ShowPreview()
    End Sub

    Private Sub btnReportVendorl_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim myReport As New rptTest2
        'myReport.myID = 5


        Dim myReportPreview As New frmReportViewer
        myReport.CreateDocument()
        myReportPreview.XtraUserControl11.PrintControl1.PrintingSystem = myReport.PrintingSystem
        myReportPreview.ShowDialog()

        ''  myReport.ShowPreview()
    End Sub

#End Region

#Region "Save Events"
    Private Sub btnSaveProposalLayout_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSaveProposalLayout.ItemClick
        RaiseEvent eSaveNewProposalLayout()
    End Sub

    'SaveAs
    Private Sub btnSaveAsProposalLayout_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSaveAsProposalLayout.ItemClick
        RaiseEvent eSaveAsNewProposalLayout()
    End Sub

#End Region

    Private Sub cmboProposalLayout_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmboProposalLayout.EditValueChanged
        RaiseEvent eChangeLayoutProposal()
    End Sub

    Private Sub RibbonControl_SelectedPageChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RibbonControl.SelectedPageChanged
        RaiseEvent eSwitchGrid()
    End Sub

    Private Sub btnProposalMap_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnProposalMap.ItemClick
        RaiseEvent eViewMap()
    End Sub

    Private Sub btnSettings_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSettings.ItemClick
        RaiseEvent eClickSettings()
    End Sub


    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        Const WM_KEYDOWN As Integer = &H100 ' regular key press 
        Const WM_SYSKEYDOWN As Integer = &H104 ' system key press (?) 
        Dim handled As Boolean = False ' we haven't handled this key 
        If (msg.Msg = WM_KEYDOWN) OrElse (msg.Msg = WM_SYSKEYDOWN) Then ' if they are pressing a key 
            Select Case keyData
                ' look at which key they're pressing 
                Case Keys.Escape
                    ' handle the Esc key as if they pressed "Exit" 
                    If DialogResult.Yes = MessageBox.Show("Are you sure you want to close the application?", "Application Closing?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) Then
                        DialogResult = DialogResult.Cancel
                        Close()
                    End If

                    handled = True
                    ' we handled the key press 
                    Exit Select
                Case Else
                    ' others we don't handle 
                    Exit Select
            End Select
        End If
        Return (handled OrElse MyBase.ProcessCmdKey(msg, keyData))
        ' if we haven't handled this key, pass it to the base 
    End Function

    Private Sub CreateNewProposalFolder()
        If isDatabaseLive Then
            Dim myEditRow As DataRow = gridViewProposal.GetDataRow(gridViewProposal.FocusedRowHandle)
            Dim cFrom As String = My.Settings.browseFolder + "\1-New Template"
            Dim cTo As String = String.Format("{0}\{1}", My.Settings.browseFolder, myEditRow("PROPOSAL_NUMBER").ToString)
            CopyDirectory(cFrom, cTo, True)
        End If
    End Sub
    Private Sub btnBrowseBrowse_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBrowseBrowse.ItemClick
        Dim myEditRow As DataRow = gridViewProposal.GetDataRow(gridViewProposal.FocusedRowHandle)
        Dim cPFolder As String = String.Format("{0}\{1}", My.Settings.browseFolder, myEditRow("PROPOSAL_NUMBER").ToString)
        If Not System.IO.Directory.Exists(cPFolder) Then
            Dim msgRes As Int16 = MsgBox("This folder does not exist. Do you want to create it?", vbYesNo, "ErcoView")
            If msgRes = vbYes Then
                CreateNewProposalFolder()
            Else
                Exit Sub
            End If

        End If


        Dim LastFolderLoation As String = ""
ShowAgain:
        Dim oBrowse As New frmBrowse

        If myEditRow IsNot Nothing Then
            Dim pID As String = myEditRow("PROPOSAL_NUMBER").ToString

            oBrowse.JobPath = String.Format("{0}\{1}", My.Settings.browseFolder, pID)
            oBrowse.JobTitle = pID.ToString
            oBrowse.LastFolderLoation = LastFolderLoation

            If DialogResult.Ignore = oBrowse.ShowDialog() Then
                LastFolderLoation = oBrowse.LastFolderLoation
                oBrowse.Dispose()
                GoTo ShowAgain
            End If
        End If

    End Sub

#Region "Remove layout events"

    Private Sub btnRemoveProposalLayout_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRemoveProposalLayout.ItemClick
        RaiseEvent eRemoveProposalLayout()
    End Sub

#End Region

    Private Sub gridViewProposal_ShowCustomizationForm(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridViewProposal.ShowCustomizationForm
        If userPermission = 3 Then
            gridViewProposal.HideCustomization()
        End If
    End Sub
    Private Sub btnHotSeat_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        RaiseEvent eHotSeat()
    End Sub

    Private Sub btnHotSeat_ItemClick_1(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim pID As Integer
        Dim myEditRow As DataRow = gridViewProposal.GetDataRow(gridViewProposal.FocusedRowHandle)
        If myEditRow IsNot Nothing Then
            pID = myEditRow("PROPOSAL_ID").ToString
            Dim myHotSeat As New frmHotSeat
            myHotSeat.pID = pID
            myHotSeat.Show()
        End If



        ''Dim myReport As New rptProposalByMonth(cmboBookMonth.Text, cmboBookYear.Text)
        'Dim myReport As New rptHotSeat
        ''Dim constSchStatus As String = cmboConstStatus.Text
        'Dim oConnString As String = GetConnectionString()
        'myReport.SpGetProposalsTableAdapter.Connection = New SqlConnection(oConnString)
        'myReport.SpGetProposalsTableAdapter.Fill(myReport.DsErcoView1.spGetProposals, 2222)
        '' myReport.myID = 0 Z
        'myReport.ShowPreview()
        '' Me.Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class