Imports System.Data.SqlClient

Public Class clsFrmMain
    Public WithEvents myFrmMain As New frmMain
    Private isLoading As Boolean


    Public Sub ShowMainForm()

        With myFrmMain

            Dim oConnString As String = GetConnectionString()
            .SpGetProposalsTableAdapter1.Connection = New SqlConnection(oConnString)
            .SpGetContactsTableAdapter1.Connection = New SqlConnection(oConnString)
            .SpGetContactTableAdapter1.Connection = New SqlConnection(oConnString)
            .SpGetCustomerTableAdapter1.Connection = New SqlConnection(oConnString)
            .SpGetGroupsTableAdapter1.Connection = New SqlConnection(oConnString)
            .SpGetUsersTableAdapter1.Connection = New SqlConnection(oConnString)
            .SpGetVendorTableAdapter1.Connection = New SqlConnection(oConnString)


            ' .cmboCustomerLayout.EditValue = My.Settings.layoutCustomer
            '.cmboContactLayout.EditValue = My.Settings.layoutContact
            '.cmboVendorLayout.EditValue = My.Settings.layoutVendor

            .txtLoginName.Caption = currentErcoViewFullName
            If isLoading Then
                Exit Sub
            End If
            isLoading = True
            GetProposalLayouts()
            .cmboProposalLayout.EditValue = My.Settings.layoutProposal
            GetCurrentLayout()
            myFrmMain.gridViewProposal.Focus()
            isLoading = False
            .RibbonControl.SelectedPage.Name = "pageProposal"
            .tabPages.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False
            .tabPages.SelectedTabPageIndex = 0

            ' As Proposal page is the default page, populate its grid here.
            myFrmMain.SpGetProposalsTableAdapter1.Fill(myFrmMain.DsErcoView2.spGetProposals, 0)

            Dim ErcoviewVer As String = String.Format("v{0}.{1}.{2}", My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build)
            If isDatabaseLive Then
                .Text = String.Format("EV2 [{0}] [LIVE DATABASE]", ErcoviewVer)
            Else
                .Text = String.Format("EV2 [{0}] [TRAINING DATABASE]", ErcoviewVer)
            End If

            .ShowDialog()
        End With
    End Sub

    Public Sub myFrmMain_eClickSettings() Handles myFrmMain.eClickSettings
        Using mySettings As New frmSettings()
            mySettings.ShowDialog()
        End Using
    End Sub

    Public Sub myFrmMain_eSwitchGrid() Handles myFrmMain.eSwitchGrid
        Select Case myFrmMain.RibbonControl.SelectedPage.Name
            Case "pageProposal"
                myFrmMain.tabPages.SelectedTabPageIndex = 0
                myFrmMain.SpGetProposalsTableAdapter1.Fill(myFrmMain.DsErcoView2.spGetProposals, 0)
            Case "pageCustomer"
                myFrmMain.tabPages.SelectedTabPageIndex = 1
                myFrmMain.SpGetCustomerTableAdapter1.Fill(myFrmMain.DsErcoView2.spGetCustomer, 0)
            Case "pageUser"
                myFrmMain.tabPages.SelectedTabPageIndex = 2
                myFrmMain.SpGetUsersTableAdapter1.Fill(myFrmMain.DsErcoView2.spGetUsers, 0)
            Case "pageVendor"
                myFrmMain.tabPages.SelectedTabPageIndex = 3
                myFrmMain.SpGetVendorTableAdapter1.Fill(myFrmMain.DsErcoView2.spGetVendor, 0)
            Case "pageContact"
                myFrmMain.tabPages.SelectedTabPageIndex = 4
                myFrmMain.SpGetContactTableAdapter1.Fill(myFrmMain.DsErcoView2.spGetContact, 0)
            Case "pageGroup"
                myFrmMain.tabPages.SelectedTabPageIndex = 5
                myFrmMain.SpGetGroupsTableAdapter1.Fill(myFrmMain.DsErcoView2.spGetGroups)
        End Select
    End Sub

    Public Sub myFrmMain_eViewMap() Handles myFrmMain.eViewMap
        Dim rowTotal As Integer = myFrmMain.gridViewProposal.SelectedRowsCount
        Dim rowArray As Array = myFrmMain.gridViewProposal.GetSelectedRows
        Dim rowCount As Integer
        If rowTotal < 1 Then
            Exit Sub
        End If
        Dim myDataRow As DataRow = myFrmMain.gridViewProposal.GetDataRow(rowArray(rowCount))
        Dim kmlPointName(rowTotal) As String
        Dim kmlDescription(rowTotal) As String
        Dim kmlLongitude(rowTotal) As Double
        Dim kmlLatitude(rowTotal) As Double


        Dim places As New List(Of PlaceMark)

        Dim myAppPath As String = System.Reflection.Assembly.GetExecutingAssembly.Location
        Dim templateKML As String = String.Format("{0}{1}", System.IO.Path.GetDirectoryName(myAppPath), "\ErcoViewTemplate.kml")
        Dim m_XMLPath As String = String.Format("{0}{1}", System.IO.Path.GetDirectoryName(myAppPath), "\ErcoView.kml")
        FileCopy(templateKML, m_XMLPath)


        ' Dim m_XMLPath As String = Replace(System.Reflection.Assembly.GetExecutingAssembly.Location, "exe", "kml") '"c:\temp\7121.kml"
        Dim oXmlDocument As New Xml.XmlDocument()

        oXmlDocument.Load(m_XMLPath)

        For rowCount = 0 To rowTotal - 1
            myDataRow = myFrmMain.gridViewProposal.GetDataRow(rowArray(rowCount))
            Dim oPlace As New PlaceMark
            oPlace.Name = myDataRow("PROPOSAL_NUMBER").ToString
            oPlace.Desc = myDataRow("DESCRIPTION").ToString
            'Select Case myDataRow("PRIORITY")
            '    Case 0
            '        oPlace.url = "#msn_wht-pushpin"
            '    Case 1
            '        oPlace.url = "#msn_red-pushpin"
            '    Case 2
            '        oPlace.url = "#msn_ylw-pushpin"
            '    Case 3
            '        oPlace.url = "#msn_blue-pushpin"
            '    Case 4
            '        oPlace.url = "#msn_pink-pushpin"
            '    Case Else
            '        oPlace.url = "#msn_wht-pushpin"

            'End Select
            oPlace.url = "#msn_wht-pushpin"
            oPlace.CoordX = myDataRow("GPS_W").ToString
            oPlace.Coordy = myDataRow("GPS_N").ToString
            places.Add(oPlace)
        Next
        Dim MapPlace As New clsMapIt
        MapPlace.AddPlaceMark(places, oXmlDocument)
        oXmlDocument.Save(m_XMLPath)

        'Dim txtout As String = clsKmlMaker.GetKml("ErcoView", kmlPointName, kmlDescription, kmlLongitude, kmlLatitude)
        'Dim kmlPath As String = Replace(System.Reflection.Assembly.GetExecutingAssembly.Location, "exe", "kml")
        System.Diagnostics.Process.Start(m_XMLPath) '"C:\Development\ErcoView\ErcoView.kml"
    End Sub


    Private Sub EditProposal(ByVal pID As Integer)

        Dim myProposal As New clsFrmProposal() With {.ID = pID}

        myProposal.ShowForm()

        If myProposal.didUpdate Then
            myFrmMain.gridViewProposal.BeginDataUpdate()
            myFrmMain.SpGetProposalsTableAdapter1.Fill(myFrmMain.DsErcoView2.spGetProposals, 0)
            myFrmMain.gridViewProposal.EndDataUpdate()
        End If
        myProposal = Nothing
    End Sub


#Region "New' events Handlers"

    Public Sub myFrmMain_eNewProposal() Handles myFrmMain.eNewProposal
        'Dim nProposalNumber As Integer = GetNewProposalNumber()

        'EditProposal(nProposalNumber)
        EditProposal(0)

    End Sub

    Public Sub myFrmMain_eNewVendor() Handles myFrmMain.eNewVendor

        Dim myVendor As New clsFrmVendor() With {.ID = 0}
        If myVendor.isVendor = 1 Then
            myVendor.myFrmCustomer.Text = "Vendors"
        End If
        myVendor.ShowForm()
        If myVendor.didUpdate Then
            myFrmMain.SpGetVendorTableAdapter1.Fill(myFrmMain.DsErcoView2.spGetVendor, 0)
        End If
    End Sub

    Public Sub myFrmMain_eNewUser() Handles myFrmMain.eNewUser

        Dim myUser As New clsFrmUsers() With {.ID = 0}
        myUser.ShowForm()
        If myUser.didUpdate Then
            myFrmMain.SpGetUsersTableAdapter1.Fill(myFrmMain.DsErcoView2.spGetUsers, 0)
        End If
    End Sub

    Public Sub myFrmMain_eNewContact() Handles myFrmMain.eNewContact

        Dim myContact As New clsFrmContact() With {.ID = 0}
        myContact.ShowForm()
        If myContact.didUpdate Then
            myFrmMain.SpGetContactTableAdapter1.Fill(myFrmMain.DsErcoView2.spGetContact, 0)
        End If
    End Sub


    Private Sub myFrmMain_eNewGroup() Handles myFrmMain.eNewGroup

        Dim conString As String = GetConnectionString()
        Using connection As SqlConnection = New SqlConnection(conString)
            connection.Open()
            Try
                Dim command As SqlCommand = New SqlCommand("spInsertGroup", connection) With {.CommandType = CommandType.StoredProcedure}

                Dim GroupName As String = InputBox("Enter new group name")
                If Not String.IsNullOrEmpty(GroupName) Then
                    command.Parameters.AddWithValue("@cGroupName", GroupName)
                    command.ExecuteNonQuery()
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                connection.Close()
            End Try
        End Using
        myFrmMain.SpGetGroupsTableAdapter1.Fill(myFrmMain.DsErcoView2.spGetGroups)

    End Sub


    Public Sub myFrmMain_eNewCustomer() Handles myFrmMain.eNewCustomer

        Dim myCustomer As New clsFrmCustomer() With {.ID = 0}
        myCustomer.ShowForm()
        If myCustomer.didUpdate Then
            myFrmMain.SpGetCustomerTableAdapter1.Fill(myFrmMain.DsErcoView2.spGetCustomer, 0)
        End If
    End Sub

#End Region

#Region "'Edit' event handler"

    Public Sub myFrmMain_eEditProposal() Handles myFrmMain.eEditProposal

        Dim myEditRow As DataRow = myFrmMain.gridViewProposal.GetDataRow(myFrmMain.gridViewProposal.FocusedRowHandle)
        If myEditRow IsNot Nothing Then
            Dim pID As Integer = myEditRow("PROPOSAL_ID").ToString
            EditProposal(pID)
        End If

    End Sub

    Public Sub myFrmMain_eEditVendor() Handles myFrmMain.eEditVendor

        Dim myEditRow As DataRow = myFrmMain.gridViewVendor.GetDataRow(myFrmMain.gridViewVendor.FocusedRowHandle)
        Dim myVendor As New clsFrmVendor() With {.ID = myEditRow("VENDOR_ID").ToString}

        myVendor.ShowForm()

        If myVendor.didUpdate Then
            myFrmMain.gridViewVendor.BeginDataUpdate()

            myFrmMain.SpGetVendorTableAdapter1.Fill(myFrmMain.DsErcoView2.spGetVendor, 0)
            myFrmMain.gridViewVendor.EndDataUpdate()
            myFrmMain.gridViewVendor.RefreshData()

        End If
        myVendor = Nothing

    End Sub

    Public Sub myFrmMain_eEditCustomer() Handles myFrmMain.eEditCustomer

        Dim myEditRow As DataRow = myFrmMain.gridViewCustomer.GetDataRow(myFrmMain.gridViewCustomer.FocusedRowHandle)
        Dim myCustomer As New clsFrmCustomer() With {.ID = myEditRow("CUSTOMER_ID").ToString}

        myCustomer.ShowForm()

        If myCustomer.didUpdate Then
            myFrmMain.gridViewCustomer.BeginDataUpdate()

            myFrmMain.SpGetCustomerTableAdapter1.Fill(myFrmMain.DsErcoView2.spGetCustomer, 0)
            myFrmMain.gridViewCustomer.EndDataUpdate()
            myFrmMain.gridViewCustomer.RefreshData()

        End If
        myCustomer = Nothing

    End Sub

    Public Sub myFrmMain_eEditContact() Handles myFrmMain.eEditContact

        Dim myEditRow As DataRow = myFrmMain.gridViewContact.GetDataRow(myFrmMain.gridViewContact.FocusedRowHandle)
        Dim myContact As New clsFrmContact() With {.ID = myEditRow("CONTACT_ID").ToString}

        myContact.ShowForm()

        If myContact.didUpdate Then
            myFrmMain.SpGetContactTableAdapter1.Fill(myFrmMain.DsErcoView2.spGetContact, 0)
        End If
        myContact = Nothing

    End Sub

    Public Sub myFrmMain_eEditUser() Handles myFrmMain.eEditUser

        Dim myEditRow As DataRow = myFrmMain.gridViewUser.GetDataRow(myFrmMain.gridViewUser.FocusedRowHandle)
        Dim myUser As New clsFrmUsers() With {.ID = myEditRow("USER_ID").ToString}

        myUser.ShowForm()

        If myUser.didUpdate Then
            myFrmMain.SpGetUsersTableAdapter1.Fill(myFrmMain.DsErcoView2.spGetUsers, 0)
        End If
        myUser = Nothing

    End Sub


#End Region

#Region "'Export' event handlers"

    Public Sub myFrmMain_eExportProposal() Handles myFrmMain.eExportProposal
        Dim xlPath As String = System.IO.Path.GetTempFileName
        xlPath = xlPath.Remove(xlPath.LastIndexOf(".") + 1)
        xlPath = String.Concat(xlPath, "xls")
        myFrmMain.gridViewProposal.ExportToXls(xlPath)
        Dim startInfo As System.Diagnostics.ProcessStartInfo = New System.Diagnostics.ProcessStartInfo(xlPath, String.Format("/r", xlPath))
        System.Diagnostics.Process.Start(startInfo)
    End Sub

    Public Sub myFrmMain_eExportCustomer() Handles myFrmMain.eExportCustomer
        Dim xlPath As String = System.IO.Path.GetTempFileName
        xlPath = xlPath.Remove(xlPath.LastIndexOf(".") + 1)
        xlPath = String.Concat(xlPath, "xls")
        myFrmMain.gridViewCustomer.ExportToXls(xlPath)
        Dim startInfo As System.Diagnostics.ProcessStartInfo = New System.Diagnostics.ProcessStartInfo(xlPath, String.Format("/r", xlPath))
        System.Diagnostics.Process.Start(startInfo)
    End Sub

    Public Sub myFrmMain_eExportContact() Handles myFrmMain.eExportContact
        Dim xlPath As String = System.IO.Path.GetTempFileName
        xlPath = xlPath.Remove(xlPath.LastIndexOf(".") + 1)
        xlPath = String.Concat(xlPath, "xls")
        myFrmMain.gridViewContact.ExportToXls(xlPath)
        Dim startInfo As System.Diagnostics.ProcessStartInfo = New System.Diagnostics.ProcessStartInfo(xlPath, String.Format("/r", xlPath))
        System.Diagnostics.Process.Start(startInfo)
    End Sub

    Public Sub myFrmMain_eExportVendor() Handles myFrmMain.eExportVendor
        Dim xlPath As String = System.IO.Path.GetTempFileName
        xlPath = xlPath.Remove(xlPath.LastIndexOf(".") + 1)
        xlPath = String.Concat(xlPath, "xls")
        myFrmMain.gridViewVendor.ExportToXls(xlPath)
        Dim startInfo As System.Diagnostics.ProcessStartInfo = New System.Diagnostics.ProcessStartInfo(xlPath, String.Format("/r", xlPath))
        System.Diagnostics.Process.Start(startInfo)
    End Sub

    Public Sub myFrmMain_eExportUsers() Handles myFrmMain.eExportUser
        Dim xlPath As String = System.IO.Path.GetTempFileName
        xlPath = xlPath.Remove(xlPath.LastIndexOf(".") + 1)
        xlPath = String.Concat(xlPath, "xls")
        myFrmMain.gridViewUser.ExportToXls(xlPath)
        Dim startInfo As System.Diagnostics.ProcessStartInfo = New System.Diagnostics.ProcessStartInfo(xlPath, String.Format("/r", xlPath))
        System.Diagnostics.Process.Start(startInfo)
    End Sub

#End Region


    Public Sub myFrmMain_eChangeLayoutProposal() Handles myFrmMain.eChangeLayoutProposal
        If isLoading Then
            Exit Sub
        End If
        My.Settings.layoutProposal = myFrmMain.cmboProposalLayout.EditValue.ToString
        My.Settings.Save()
        isLoading = True
        GetCurrentLayout()
        myFrmMain.gridViewProposal.Focus()
        isLoading = False
    End Sub


    Private Function DeleteLayout(ByVal LayoutName As String) As Boolean
        Dim LayoutPath As String = GetLayoutFilePath(LayoutName)
        If Not LayoutPath.Contains(My.Settings.layoutPathLocal) Then
            MsgBox("Not allowed to edit this layout", , "Server layout")
            Exit Function
        End If

        If MessageBox.Show("Are you sure you want to delete this layout", "Remove Layout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            System.IO.File.Delete(LayoutPath)
        End If
    End Function


    Private Sub GetCurrentLayout()

        Dim myFile1 As String = GetLayoutFilePath(My.Settings.layoutProposal.ToString)
        If String.IsNullOrEmpty(myFile1) Then
            Return
        End If

        myFrmMain.gridViewProposal.RestoreLayoutFromXml(myFile1)
    End Sub

    Private Sub SaveLayout()
        Dim LayoutPath As String = GetLayoutFilePath(myFrmMain.cmboProposalLayout.EditValue.ToString)
        If Not LayoutPath.Contains(My.Settings.layoutPathLocal) Then
            MsgBox("Not allowed to edit this layout", , "Server layout")
            Exit Sub
        End If

        If MessageBox.Show("Are you sure you want to override this layout", "Layout Exists", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            System.IO.File.Delete(LayoutPath)
            myFrmMain.gridViewProposal.OptionsLayout.StoreAllOptions = True
            myFrmMain.gridViewProposal.SaveLayoutToXml(LayoutPath)
        End If
    End Sub

    Private Sub myFrmMain_eRemoveProposalLayout() Handles myFrmMain.eRemoveProposalLayout
        DeleteLayout(myFrmMain.cmboProposalLayout.EditValue.ToString)
        GetProposalLayouts()
    End Sub

    Private Sub GetProposalLayouts()
        myFrmMain.RIProposalLayouts.Items.Clear()

        'Load proposal layouts from local
        Dim layoutPath_Local As String = String.Format("{0}\", My.Settings.layoutPathLocal)

        Dim di As New System.IO.DirectoryInfo(layoutPath_Local)
        If Not System.IO.Directory.Exists(layoutPath_Local) Then
            Exit Sub
        End If


        Dim aryFi As System.IO.FileInfo() = di.GetFiles("*.xml")
        Dim fi As System.IO.FileInfo

        For Each fi In aryFi
            Dim oLayoutItem As New LayoutItem(fi.FullName)
            Dim oItem As New DevExpress.XtraEditors.Controls.ComboBoxItem(oLayoutItem)
            myFrmMain.RIProposalLayouts.Items.Add(oItem)
        Next
        ' My.Settings.layoutPathServer = "I:\Software"
        'Load proposal layouts from Server
        Dim layoutPath_server As String = String.Format("{0}\", My.Settings.layoutPathServer)
        If userPermission = 1 Then
            layoutPath_server += "\Admin"
        ElseIf userPermission = 2 Then
            layoutPath_server += "\General"
        ElseIf userPermission = 3 Then
            layoutPath_server += "\Super"
        End If

        di = New System.IO.DirectoryInfo(layoutPath_server)
        If System.IO.Directory.Exists(layoutPath_server) Then
            aryFi = di.GetFiles("*.xml")

            For Each fi In aryFi
                Dim oLayoutItem As New LayoutItem(fi.FullName)
                Dim oItem As New DevExpress.XtraEditors.Controls.ComboBoxItem(oLayoutItem)
                myFrmMain.RIProposalLayouts.Items.Add(oItem)
            Next

        End If

        myFrmMain.RIProposalLayouts.BestFitWidth = True

        Dim bLayoutSet As Boolean = False
        For Each item As LayoutItem In myFrmMain.RIProposalLayouts.Items
            If item.ToString = My.Settings.layoutCustomer Then
                myFrmMain.cmboProposalLayout.EditValue = item
                bLayoutSet = True
                Exit For
            End If
        Next

        If bLayoutSet = False Then
            If myFrmMain.RIProposalLayouts.Items.Count > 0 Then
                myFrmMain.cmboProposalLayout.EditValue = myFrmMain.RIProposalLayouts.Items(0)
            Else
                myFrmMain.cmboProposalLayout.EditValue = ""
            End If
        End If

    End Sub

    Private Sub myFrmMain_eSaveNewProposalLayout() Handles myFrmMain.eSaveNewProposalLayout
        SaveLayout()
    End Sub

    Public Sub myFrmMain_eSaveAsNewProposalLayout() Handles myFrmMain.eSaveAsNewProposalLayout
        Using ofrmLayoutSave As New frmLayoutSave()

            'ofrmLayoutSave.txtLayoutName.Text = My.Settings.layoutPathServer
            If DialogResult.Cancel = ofrmLayoutSave.ShowDialog() Then
                Return
            End If

            Dim myLayoutPath As String = String.Format("{0}\{1}.xml", My.Settings.layoutPathLocal, ofrmLayoutSave.txtLayoutName.Text)

            If String.IsNullOrEmpty(ofrmLayoutSave.txtLayoutName.Text) Then
                Exit Sub
            Else
                Dim layoutCount As Integer = myFrmMain.RIProposalLayouts.Items.Count
                Dim Count As Integer
                For Count = 0 To layoutCount - 1
                    If System.IO.File.Exists(myLayoutPath) Then
                        MsgBox("A layout with that name already exists.  Please Save again as a different name.", MsgBoxStyle.OkOnly, "IMAGE")
                        Exit Sub
                    End If
                Next
            End If
            myFrmMain.gridViewProposal.OptionsLayout.StoreAllOptions = True
            ' Saves Layout
            If IO.Directory.Exists(My.Settings.layoutPathLocal) Then
                myFrmMain.gridViewProposal.SaveLayoutToXml(myLayoutPath)
                My.Settings.layoutProposal = ofrmLayoutSave.txtLayoutName.Text
            Else
                MsgBox("Layout Folder specified in Settings does not exist" & vbCrLf & My.Settings.layoutPathLocal & vbCrLf & "Please see System administrator", MsgBoxStyle.Critical, "Layouts not available")
            End If
        End Using
        My.Settings.Save()
        isLoading = True

        GetProposalLayouts()
        myFrmMain.cmboProposalLayout.EditValue = My.Settings.layoutProposal
        GetCurrentLayout()
        isLoading = False
    End Sub

    Public Sub myFrmMain_eHotSeat() Handles myFrmMain.eHotSeat

        Dim myEditRow As DataRow = myFrmMain.gridViewProposal.GetDataRow(myFrmMain.gridViewProposal.FocusedRowHandle)

        Try
            If myEditRow IsNot Nothing Then
                Dim pID As Integer = myEditRow("PROPOSAL_ID").ToString
                Dim myReport As New rptHotSeat
                Dim oConnString As String = GetConnectionString()
                myReport.SpGetProposalsTableAdapter.Connection = New SqlConnection(oConnString)

                myReport.SpGetProposalsTableAdapter.Fill(myReport.DsErcoView1.spGetProposals, pID)

                Dim myReportPreview As New frmReportViewer
                myReport.CreateDocument()
                myReportPreview.XtraUserControl11.PrintControl1.PrintingSystem = myReport.PrintingSystem
                myReportPreview.ShowDialog()
            End If
        Catch ex As Exception

        End Try



    End Sub
End Class
