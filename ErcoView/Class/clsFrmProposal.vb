Imports System.Data.SqlClient


Public Class clsFrmProposal
    Inherits clsBase

    Public WithEvents myFrmProposal As New frmProposal()
    Public primaryCompanyID As Integer
    Private sPROPOSAL_NUMBER As String = ""
    Private sJOB_NUMBER As Integer
    Private sJOB_TYPE As String = ""
    Private sSBS_COMPANY As String = ""
    Private sJOB_TYPE_MISC As String = ""
    Private sDATE_COMPLETED As Date
    Private sDATE_NOR As Date
    Private sDATE_PROPOSAL As Date
    Private sCONST_MONTH As String = ""
    Private sCONST_YEAR As Integer
    Private sDESCRIPTION As String = ""
    Private sCOMMENTS As String = ""
    Private sBODY_OF_WATER As String = ""
    Private sDRIVING_DIRECTIONS As String = ""
    Private sSTATUS As String = ""
    Private sCITY As String = ""
    Private sCOUNTY As String = ""
    Private sSTATE As String = ""
    Private sGPS_N As Decimal
    Private sGPS_W As Decimal
    Private sMILE_POINT As String = ""
    Private sLINE_NUMBER As String = ""
    Private sDISTRICT As String = ""
    Private sCONTRACT_NO As String = ""
    Private sWORK_ORDER_NO As String = ""
    Private sPRICE_PROPOSAL As Double
    Private sPRICE_PERMIT As Double
    Private sPRICE_EXTRA As Double
    Private sPRICE_ACTUAL As Double
    Private sSUPERINTENDENT As String = ""
    Private sONE_CALL_TICKET_NO As String = ""
    Private sONE_CALL_START_DATE As Date
    Private sONE_CALL_EXPERATION_DATE As Date
    Private sESTIMATED_COST As Double
    Private sESTIMATED_MARGIN As Double
    Private sPERMITS As String = ""
    Private sFIELD_CONTACT As String = ""
    Private sPIPE_DIAMETER As String = ""
    Private sWATER_COURSE_DESC As String = ""
    Private sSPECIFIC_PERMIT_ISSUES As String = ""
    Private sCONSTRUCTION_ISSUES As String = ""
    Private sPRIORITY As Integer
    Private sADDITIONAL_WORK As Boolean
    Private sADDITIONAL_WORK_COMMENT As String = ""
    Private sCONTRACT_STATUS As String = ""
    Private sPERMIT_STATUS As String = ""
    Private sSTATUS_COMMENT As String = ""
    Private sAREA_HOTEL As String = ""
    Private sNOTES As String = ""
    Private sCUSTOMERS As String = ""
    Private sEQUIPMENT As String = ""
    Private sPRIORITY_DESCRIPTION As String = ""
    Private sPROPOSAL_STATUS As String = ""
    Private sJOB_STATUS_COMMENTS As String = ""
    Private sJOB_STATUS As String = ""
    Private sPERMIT_COST As Double
    Private sSALESMAN_ID1 As Integer
    Private sSALESMAN_ID2 As Integer
    Private sSALESMAN_ID3 As Integer
    Private sJOB_TYPE_ID1 As Integer
    Private sJOB_TYPE_ID2 As Integer
    Private sJOB_TYPE_ID3 As Integer
    Private sSUPER_ID1 As Integer
    Private sSUPER_ID2 As Integer
    Private sSUPER_ID3 As Integer
    Private sVENDOR_ID1 As Integer
    Private sVENDOR_ID2 As Integer
    Private sVENDOR_ID3 As Integer
    Private sCUSTOMER_ID1 As Integer
    Private sCUSTOMER_ID2 As Integer
    Private sCUSTOMER_ID3 As Integer
    Private sCONTACT_ID1 As Integer
    Private sCONTACT_ID2 As Integer
    Private sCONTACT_ID3 As Integer
    Private sEstDays As Integer
    Private sActDays As Integer
    Private sCONTACT_TEXT As String = ""
    Private sSALESMAN_TEXT As String = ""
    Private sCUSTOMER_TEXT As String = ""
    Private sVENDOR_TEXT As String = ""
    Private sSUPER_TEXT As String = ""
    Private sJOBTYPE_TEXT As String = ""
    Private sACTIVE As String = ""
    Private sOC_START_TIME As String = ""


    Public Sub myFrmProposal_eClickUndo() Handles myFrmProposal.eClickUndo
        myFrmProposal.SpGetProposalsBindingSource.CancelEdit()
    End Sub

    Public Sub myFrmProposal_eUpdateProposal() Handles myFrmProposal.eUpdateProposal

        Try
            Dim msgResponse As Integer = MsgBox("Are you sure you want to update this proposal?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "ErcoView")

            If msgResponse <> 6 Then
                Exit Sub
            End If

            If False = SetValues() Then
                Exit Sub
            End If

            If ID = 0 Then 'GetNewProposalNumber() Then
                ' This is new proposal

                If sPROPOSAL_NUMBER <> "PENDING" Then
                    sPROPOSAL_NUMBER = myFrmProposal.txtPROPOSAL_NO.Text
                    
                Else
                    sPROPOSAL_NUMBER = GetNewProposalNumber()
                    myFrmProposal.txtPROPOSAL_NO.Text = sPROPOSAL_NUMBER
                End If
               
                InsertRow()
                UpdateProposal(False)
                ' 
                CreateNewProposalFolder()

            Else
                UpdateProposal(False)
                myFrmProposal.txtUpdatedBy.Text = currentErcoViewFullName



                myFrmProposal.txtPRICE_TOTAL.Text = sPRICE_PROPOSAL + sPRICE_EXTRA + sPRICE_PERMIT 'myFrmProposal.txtPROPOSAL_PRICE.Text + myFrmProposal.txtPRICE_EXTRA.Text + myFrmProposal.txtPRICE_PERMIT.Text
                myFrmProposal.txtACTUAL_PROFIT.Text = (sPRICE_PROPOSAL + sPRICE_EXTRA) - (sPRICE_ACTUAL + sPERMIT_COST) '(myFrmProposal.txtPROPOSAL_PRICE.Text + myFrmProposal.txtPRICE_EXTRA.Text) - (myFrmProposal.txtPRICE_ACTUAL.Text + myFrmProposal.txtPERMIT_COST.Text)


            End If

            didUpdate = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub CreateNewProposalFolder()

        If isDatabaseLive Then
            Dim cFrom As String = My.Settings.browseFolder + "\1-New Template"
            Dim cTo As String = String.Format("{0}\{1}", My.Settings.browseFolder, myFrmProposal.txtPROPOSAL_NO.Text.ToString)
            CopyDirectory(cFrom, cTo, True)
        End If
    End Sub



    Public Sub myFrmProposal_eClickBrowse() Handles myFrmProposal.eClickBrowse
        Dim cPFolder As String = String.Format("{0}\{1}", My.Settings.browseFolder, myFrmProposal.txtPROPOSAL_NO.Text.ToString)
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
        Dim oBrowse As New frmBrowse() With {.JobPath = String.Format("{0}\{1}", My.Settings.browseFolder, myFrmProposal.txtPROPOSAL_NO.Text), .JobTitle = myFrmProposal.txtPROPOSAL_NO.Text, .LastFolderLoation = LastFolderLoation}

        If DialogResult.Ignore = oBrowse.ShowDialog() Then
            LastFolderLoation = oBrowse.LastFolderLoation
            oBrowse.Dispose()
            GoTo ShowAgain
        End If
        oBrowse.Dispose()
    End Sub


    Public Sub UpdateProposal(ByVal fromInsert As Boolean)
        Dim conString As String = GetConnectionString()
        Dim connection As SqlConnection = New SqlConnection(conString)
        connection.Open()
        Try
            Dim command As SqlCommand = New SqlCommand("spUpdateProposal", connection) With {.CommandType = CommandType.StoredProcedure}
            command.Parameters.AddWithValue("@proposalID", ID)
            command.Parameters.AddWithValue("@PROPOSAL_NUMBER", sPROPOSAL_NUMBER)
            command.Parameters.AddWithValue("@JOB_NUMBER", sJOB_NUMBER)
            command.Parameters.AddWithValue("@JOB_TYPE_MISC", sJOB_TYPE_MISC)
            command.Parameters.AddWithValue("@SBS_COMPANY", sSBS_COMPANY)
            If myFrmProposal.dateCompletion.Text <> "" Then
                command.Parameters.AddWithValue("@DATE_COMPLETED", sDATE_COMPLETED)
            Else
                command.Parameters.AddWithValue("@DATE_COMPLETED", System.DBNull.Value)
            End If

            If myFrmProposal.dateNor.Text <> "" Then
                command.Parameters.AddWithValue("@DATE_NOR", sDATE_NOR)
            Else
                command.Parameters.AddWithValue("@DATE_NOR", System.DBNull.Value)
            End If
            If myFrmProposal.txtDATE_PROPOSAL.Text <> "" Then
                command.Parameters.AddWithValue("@DATE_PROPOSAL", sDATE_PROPOSAL)
            Else
                command.Parameters.AddWithValue("@DATE_PROPOSAL", System.DBNull.Value)
            End If
            command.Parameters.AddWithValue("@DATE_UPDATED", FormatDateTime(Date.Today, DateFormat.ShortDate))
            command.Parameters.AddWithValue("@UPDATED_BY", currentErcoViewUserID)
            command.Parameters.AddWithValue("@CONST_MONTH", sCONST_MONTH)

            If myFrmProposal.cmboBookYear.Text <> "" Then
                command.Parameters.AddWithValue("@CONST_YEAR", sCONST_YEAR)
            Else
                command.Parameters.AddWithValue("@CONST_YEAR", System.DBNull.Value)
            End If
            command.Parameters.AddWithValue("@DESCRIPTION", sDESCRIPTION)
            command.Parameters.AddWithValue("@COMMENTS", sCOMMENTS)
            command.Parameters.AddWithValue("@BODY_OF_WATER", sBODY_OF_WATER)
            command.Parameters.AddWithValue("@DRIVING_DIRECTIONS", sDRIVING_DIRECTIONS)
            command.Parameters.AddWithValue("@STATUS", sSTATUS)
            command.Parameters.AddWithValue("@CITY", sCITY)
            command.Parameters.AddWithValue("@COUNTY", sCOUNTY)
            command.Parameters.AddWithValue("@STATE", sSTATE)
            command.Parameters.AddWithValue("@GPS_N", sGPS_N)
            command.Parameters.AddWithValue("@GPS_W", sGPS_W)
            command.Parameters.AddWithValue("@MILE_POINT", sMILE_POINT)
            command.Parameters.AddWithValue("@LINE_NUMBER", sLINE_NUMBER)
            command.Parameters.AddWithValue("@DISTRICT", sDISTRICT)
            command.Parameters.AddWithValue("@CONTRACT_NO", sCONTRACT_NO)
            command.Parameters.AddWithValue("@WORK_ORDER_NO", sWORK_ORDER_NO)
            command.Parameters.AddWithValue("@PRICE_PROPOSAL", sPRICE_PROPOSAL)
            command.Parameters.AddWithValue("@PRICE_PERMIT", sPRICE_PERMIT)
            command.Parameters.AddWithValue("@PRICE_EXTRA", sPRICE_EXTRA)
            command.Parameters.AddWithValue("@PRICE_ACTUAL", sPRICE_ACTUAL)
            command.Parameters.AddWithValue("@ONE_CALL_TICKET_NO", sONE_CALL_TICKET_NO)
            command.Parameters.AddWithValue("@EST_WORK", sEstDays)
            command.Parameters.AddWithValue("@ACT_WORK", sActDays)
            If myFrmProposal.txtONE_CALL_START_DATE.Text <> "" Then
                command.Parameters.AddWithValue("@ONE_CALL_START_DATE", sONE_CALL_START_DATE)
            Else
                command.Parameters.AddWithValue("@ONE_CALL_START_DATE", System.DBNull.Value)
            End If
            If myFrmProposal.txtONE_CALL_EXPERATION_DATE.Text <> "" Then
                command.Parameters.AddWithValue("@ONE_CALL_EXPERATION_DATE", sONE_CALL_EXPERATION_DATE)
            Else
                command.Parameters.AddWithValue("@ONE_CALL_EXPERATION_DATE", System.DBNull.Value)
            End If
            command.Parameters.AddWithValue("@ESTIMATED_COST", sESTIMATED_COST)
            command.Parameters.AddWithValue("@ESTIMATED_MARGIN", sESTIMATED_MARGIN)
            command.Parameters.AddWithValue("@PERMITS", sPERMITS)
            command.Parameters.AddWithValue("@FIELD_CONTACT", sFIELD_CONTACT)
            command.Parameters.AddWithValue("@PIPE_DIAMETER", sPIPE_DIAMETER)
            command.Parameters.AddWithValue("@WATER_COURSE_DESC", sWATER_COURSE_DESC)
            command.Parameters.AddWithValue("@SPECIFIC_PERMIT_ISSUES", sSPECIFIC_PERMIT_ISSUES)
            command.Parameters.AddWithValue("@CONSTRUCTION_ISSUES", sCONSTRUCTION_ISSUES)
            command.Parameters.AddWithValue("@PRIORITY", sPRIORITY)
            command.Parameters.AddWithValue("@ADDITIONAL_WORK", sADDITIONAL_WORK)
            command.Parameters.AddWithValue("@ADDITIONAL_WORK_COMMENT", sADDITIONAL_WORK_COMMENT)
            command.Parameters.AddWithValue("@CONTRACT_STATUS", sCONTRACT_STATUS)
            command.Parameters.AddWithValue("@PERMIT_STATUS", sPERMIT_STATUS)
            command.Parameters.AddWithValue("@STATUS_COMMENT", sSTATUS_COMMENT)
            command.Parameters.AddWithValue("@AREA_HOTEL", sAREA_HOTEL)
            command.Parameters.AddWithValue("@NOTES", sNOTES)
            command.Parameters.AddWithValue("@PRIORITY_DESCRIPTION", sPRIORITY_DESCRIPTION)
            command.Parameters.AddWithValue("@PROPOSAL_STATUS", sPROPOSAL_STATUS)
            command.Parameters.AddWithValue("@JOB_STATUS_COMMENTS", sJOB_STATUS_COMMENTS)
            command.Parameters.AddWithValue("@JOB_STATUS", sJOB_STATUS)
            command.Parameters.AddWithValue("@PERMIT_COST", sPERMIT_COST)
            command.Parameters.AddWithValue("@SALESMAN_ID1", sSALESMAN_ID1)
            command.Parameters.AddWithValue("@SALESMAN_ID2", sSALESMAN_ID2)
            command.Parameters.AddWithValue("@SALESMAN_ID3", sSALESMAN_ID3)
            command.Parameters.AddWithValue("@JOB_TYPE1", sJOB_TYPE_ID1)
            command.Parameters.AddWithValue("@JOB_TYPE2", sJOB_TYPE_ID2)
            command.Parameters.AddWithValue("@JOB_TYPE3", sJOB_TYPE_ID3)
            command.Parameters.AddWithValue("@SUPER_ID1", sSUPER_ID1)
            command.Parameters.AddWithValue("@SUPER_ID2", sSUPER_ID2)
            command.Parameters.AddWithValue("@SUPER_ID3", sSUPER_ID3)
            command.Parameters.AddWithValue("@VENDOR_ID1", sVENDOR_ID1)
            command.Parameters.AddWithValue("@VENDOR_ID2", sVENDOR_ID2)
            command.Parameters.AddWithValue("@VENDOR_ID3", sVENDOR_ID3)
            command.Parameters.AddWithValue("@CUSTOMER_ID1", sCUSTOMER_ID1)
            command.Parameters.AddWithValue("@CUSTOMER_ID2", sCUSTOMER_ID2)
            command.Parameters.AddWithValue("@CUSTOMER_ID3", sCUSTOMER_ID3)
            command.Parameters.AddWithValue("@CONTACT_ID1", sCONTACT_ID1)
            command.Parameters.AddWithValue("@CONTACT_ID2", sCONTACT_ID2)
            command.Parameters.AddWithValue("@CONTACT_ID3", sCONTACT_ID3)
            command.Parameters.AddWithValue("@ACTIVE", sACTIVE)
            command.Parameters.AddWithValue("@OC_START_TIME", sOC_START_TIME)
            command.ExecuteNonQuery()
            If Not fromInsert Then
                MsgBox("Proposal updated sucessfully!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "ErcoView")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.Close()
            connection.Dispose()
        End Try
    End Sub

    Public Sub myFrmProposal_eViewMap() Handles myFrmProposal.eViewMap

        Dim places As New List(Of PlaceMark)

        Dim myAppPath As String = System.Reflection.Assembly.GetExecutingAssembly.Location
        Dim templateKML As String = String.Format("{0}{1}", System.IO.Path.GetDirectoryName(myAppPath), "\ErcoViewTemplate.kml")
        Dim m_XMLPath As String = String.Format("{0}{1}", System.IO.Path.GetDirectoryName(myAppPath), "\ErcoView.kml")
        FileCopy(templateKML, m_XMLPath)

        Dim oXmlDocument As New Xml.XmlDocument()

        oXmlDocument.Load(m_XMLPath)

        Dim oPlace As New PlaceMark
        oPlace.Name = myFrmProposal.txtPROPOSAL_NO.Text.ToString
        oPlace.Desc = myFrmProposal.txtDESCRIPTION.Text
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
        oPlace.CoordX = myFrmProposal.txtGPS_W.Text.ToString
        oPlace.Coordy = myFrmProposal.txtGPS_N.Text.ToString
            places.Add(oPlace)

        Dim MapPlace As New clsMapIt
        MapPlace.AddPlaceMark(places, oXmlDocument)
        oXmlDocument.Save(m_XMLPath)

        System.Diagnostics.Process.Start(m_XMLPath) '"C:\Development\ErcoView\ErcoView.kml"

    End Sub

    Public Sub myFrmProposal_eClickJobNumber() Handles myFrmProposal.eClickJobNumber
        Dim oJobNumbers As New clsFrmJobNumbers
        Dim myCurrentJob As Integer

        If IsNumeric(myFrmProposal.txtJOB_NUMBER.Text) Then
            myCurrentJob = myFrmProposal.txtJOB_NUMBER.Text
        Else
            myCurrentJob = 0
        End If
        oJobNumbers.currentPID = ID
        oJobNumbers.currentJobNumber = myCurrentJob
        oJobNumbers.ShowJobNumbers()
        myFrmProposal.txtJOB_NUMBER.Text = oJobNumbers.currentJobNumber
        oJobNumbers = Nothing
    End Sub

    Public Sub myFrmProposal_eClickAddSales() Handles myFrmProposal.eClickAddSalesman
        If myFrmProposal.txtSALESMAN_TEXT.Tag Is Nothing Then
            Utils.GetSalesmanOfProposal(ID, sSALESMAN_ID1, sSALESMAN_ID2, sSALESMAN_ID3)
        Else
            Dim IdArray() As String = myFrmProposal.txtSALESMAN_TEXT.Tag.ToString.Split(",")
            sSALESMAN_ID1 = IdArray(0)
            sSALESMAN_ID2 = IdArray(1)
            sSALESMAN_ID3 = IdArray(2)
        End If

        Dim oSalesman As New clsFrmList(DataType.Salesman, ID, sSALESMAN_ID1, sSALESMAN_ID2, sSALESMAN_ID3, 0, 0, 0)
        If oSalesman.m_NewValue <> "cancel" Then
            myFrmProposal.txtSALESMAN_TEXT.Text = oSalesman.m_NewValue
            sSALESMAN_TEXT = myFrmProposal.txtSALESMAN_TEXT.Text
            myFrmProposal.txtSALESMAN_TEXT.Tag = String.Format("{0},{1},{2}", sSALESMAN_ID1, sSALESMAN_ID2, sSALESMAN_ID3)
        End If


    End Sub


    Public Sub myFrmProposal_eClickAddVendor() Handles myFrmProposal.eClickAddVendor
        If myFrmProposal.txtVENDOR_TEXT.Tag Is Nothing Then
            Utils.GetVendorOfProposal(ID, sVENDOR_ID1, sVENDOR_ID2, sVENDOR_ID3)
        Else
            Dim IdArray() As String = myFrmProposal.txtVENDOR_TEXT.Tag.ToString.Split(",")
            sVENDOR_ID1 = IdArray(0)
            sVENDOR_ID2 = IdArray(1)
            sVENDOR_ID3 = IdArray(2)
        End If

        Dim oVendor As New clsFrmList(DataType.Vendor, ID, sVENDOR_ID1, sVENDOR_ID2, sVENDOR_ID3, 0, 0, 0)

        If oVendor.m_NewValue <> "cancel" Then
            myFrmProposal.txtVENDOR_TEXT.Text = oVendor.m_NewValue
            sVENDOR_TEXT = myFrmProposal.txtVENDOR_TEXT.Text
            myFrmProposal.txtVENDOR_TEXT.Tag = String.Format("{0},{1},{2}", sVENDOR_ID1, sVENDOR_ID2, sVENDOR_ID3)
        End If

    End Sub


    Public Sub myFrmProposal_eClickSBSCompany() Handles myFrmProposal.eClickSBSCompany
        'MsgBox("start from here")
        Dim oSBSCompany As New clsFrmList(myFrmProposal.txtSBSCompany.Text)

        If oSBSCompany.m_NewValue <> "cancel" Then
            myFrmProposal.txtSBSCompany.Text = oSBSCompany.GetSBSCompany
        End If

    End Sub

    Public Sub myFrmProposal_eClickAddJobType() Handles myFrmProposal.eClickAddJobType

        If myFrmProposal.txtJOB_TYPE.Tag Is Nothing Then
            Utils.GetJobTypeOfProposal(ID, sJOB_TYPE_ID1, sJOB_TYPE_ID2, sJOB_TYPE_ID3)
        Else
            Dim IdArray() As String = myFrmProposal.txtJOB_TYPE.Tag.ToString.Split(",")
            sJOB_TYPE_ID1 = IdArray(0)
            sJOB_TYPE_ID2 = IdArray(1)
            sJOB_TYPE_ID3 = IdArray(2)
        End If

        IIf(sJOB_TYPE_ID1 = 0, sJOB_TYPE_ID1 = 1, Nothing)
        IIf(sJOB_TYPE_ID2 = 0, sJOB_TYPE_ID2 = 1, Nothing)
        IIf(sJOB_TYPE_ID3 = 0, sJOB_TYPE_ID3 = 1, Nothing)


        Dim oJobType As New clsFrmList(DataType.JobType, ID, sJOB_TYPE_ID1, sJOB_TYPE_ID2, sJOB_TYPE_ID3, 0, 0, 0)

        If oJobType.m_NewValue <> "cancel" Then
            myFrmProposal.txtJOB_TYPE.Text = oJobType.m_NewValue
            sJOBTYPE_TEXT = myFrmProposal.txtJOB_TYPE.Text
            myFrmProposal.txtJOB_TYPE.Tag = String.Format("{0},{1},{2}", sJOB_TYPE_ID1, sJOB_TYPE_ID2, sJOB_TYPE_ID3)
        End If

    End Sub

    Public Sub myFrmProposal_eClickAddSuper() Handles myFrmProposal.eClickAddSuper

        If myFrmProposal.txtSUPER_TEXT.Tag Is Nothing Then
            Utils.GetSuperOfProposal(ID, sSUPER_ID1, sSUPER_ID2, sSUPER_ID3)
        Else
            Dim IdArray() As String = myFrmProposal.txtSUPER_TEXT.Tag.ToString.Split(",")
            sSUPER_ID1 = IdArray(0)
            sSUPER_ID2 = IdArray(1)
            sSUPER_ID3 = IdArray(2)
        End If

        If (sSUPER_ID1 = 0) Then sSUPER_ID1 = 1
        If (sSUPER_ID2 = 0) Then sSUPER_ID2 = 1
        If (sSUPER_ID3 = 0) Then sSUPER_ID3 = 1

        Dim oSuper As New clsFrmList(DataType.Super, ID, sSUPER_ID1, sSUPER_ID2, sSUPER_ID3, 0, 0, 0)

        If oSuper.m_NewValue <> "cancel" Then
            myFrmProposal.txtSUPER_TEXT.Text = oSuper.m_NewValue
            sSUPER_TEXT = myFrmProposal.txtSUPER_TEXT.Text
            myFrmProposal.txtSUPER_TEXT.Tag = String.Format("{0},{1},{2}", sSUPER_ID1, sSUPER_ID2, sSUPER_ID3)
        End If


    End Sub


    Public Sub myFrmProposal_eClickAddCustomer() Handles myFrmProposal.eClickAddCustomer

        If myFrmProposal.txtCUSTOMER_TEXT.Tag Is Nothing Then
            Utils.GetCustomerOfProposal(ID, sCUSTOMER_ID1, sCUSTOMER_ID2, sCUSTOMER_ID3)
        Else
            Dim IdArray() As String = myFrmProposal.txtCUSTOMER_TEXT.Tag.ToString.Split(",")
            sCUSTOMER_ID1 = IdArray(0)
            sCUSTOMER_ID2 = IdArray(1)
            sCUSTOMER_ID3 = IdArray(2)
        End If

        Dim oCustomer As New clsFrmList(DataType.Customer, ID, sCUSTOMER_ID1, sCUSTOMER_ID2, sCUSTOMER_ID3, 0, 0, 0)
        If Not oCustomer.m_NewValue = "cancel" Then
            myFrmProposal.txtCUSTOMER_TEXT.Text = oCustomer.m_NewValue
            sCUSTOMER_TEXT = myFrmProposal.txtCUSTOMER_TEXT.Text

            myFrmProposal.txtCUSTOMER_TEXT.Tag = String.Format("{0},{1},{2}", sCUSTOMER_ID1, sCUSTOMER_ID2, sCUSTOMER_ID3)

            myFrmProposal.txtCONTACT_TEXT.Tag = "0,0,0"
            myFrmProposal.txtCONTACT_TEXT.Text = ""
        End If
    End Sub

    Public Sub myFrmProposal_eClickAddContact() Handles myFrmProposal.eClickAddContact

        If myFrmProposal.txtCONTACT_TEXT.Tag Is Nothing Then

            Utils.GetContactOfProposal(ID, sCONTACT_ID1, sCONTACT_ID2, sCONTACT_ID3)
        Else
            Dim IdArray() As String = myFrmProposal.txtCONTACT_TEXT.Tag.ToString.Split(",")
            If IsNumeric(IdArray(0)) Then
                sCONTACT_ID1 = IdArray(0)
            Else
                sCONTACT_ID1 = 0
            End If
            If IsNumeric(IdArray(1)) Then
                sCONTACT_ID2 = IdArray(1)
            Else
                sCONTACT_ID2 = 0
            End If
            If IsNumeric(IdArray(2)) Then
                sCONTACT_ID3 = IdArray(2)
            Else
                sCONTACT_ID3 = 0
            End If

           
        End If

        If myFrmProposal.txtCUSTOMER_TEXT.Tag Is Nothing Then
            Utils.GetCustomerOfProposal(ID, sCUSTOMER_ID1, sCUSTOMER_ID2, sCUSTOMER_ID3)
        Else
            Dim IdArray() As String = myFrmProposal.txtCUSTOMER_TEXT.Tag.ToString.Split(",")
            sCUSTOMER_ID1 = IdArray(0)
            sCUSTOMER_ID2 = IdArray(1)
            sCUSTOMER_ID3 = IdArray(2)
        End If

        'sCONTACT_ID1 = sCUSTOMER_ID1
        'sCONTACT_ID2 = sCUSTOMER_ID2
        'sCONTACT_ID3 = sCUSTOMER_ID3

        Dim oContact As New clsFrmList(DataType.Contact, ID, sCONTACT_ID1, sCONTACT_ID2, sCONTACT_ID3, sCUSTOMER_ID1, sCUSTOMER_ID2, sCUSTOMER_ID3)

        If oContact.m_NewValue <> "cancel" Then
            myFrmProposal.txtCONTACT_TEXT.Text = oContact.m_NewValue
            sCONTACT_TEXT = myFrmProposal.txtCONTACT_TEXT.Text
            myFrmProposal.txtCONTACT_TEXT.Tag = String.Format("{0},{1},{2}", sCONTACT_ID1, sCONTACT_ID2, sCONTACT_ID3)
        End If
    End Sub


    Public Overrides Sub InsertRow()

        Dim conString As String = GetConnectionString()
        Dim connection As SqlConnection = New SqlConnection(conString)

        connection.Open()
        Try
            Dim command As SqlCommand = New SqlCommand("spInsertProposal2", connection) With {.CommandType = CommandType.StoredProcedure}
            command.Parameters.AddWithValue("@pNumber", sPROPOSAL_NUMBER)
            command.Parameters.AddWithValue("@enteredBy", currentErcoViewUserID)
            command.Parameters.AddWithValue("@enteredDate", FormatDateTime(Date.Today, DateFormat.ShortDate))
            command.Parameters.Add("@pid", SqlDbType.Int).Direction = ParameterDirection.Output
            command.ExecuteNonQuery()
            ID = command.Parameters("@pid").Value
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.Close()
            connection.Dispose()
        End Try

       





















        'Dim conString As String = GetConnectionString()
        'Dim connection As SqlConnection = New SqlConnection(conString)
        'connection.Open()
        'Try
        '    Dim command As SqlCommand = New SqlCommand("spInsertProposal3", connection) With {.CommandType = CommandType.StoredProcedure}

        '    command.Parameters.AddWithValue("@proposalID", ID)
        '    command.Parameters.AddWithValue("@PROPOSAL_NUMBER", sPROPOSAL_NUMBER)
        '    command.Parameters.AddWithValue("@JOB_NUMBER", sJOB_NUMBER)
        '    command.Parameters.AddWithValue("@JOB_TYPE_MISC", sJOB_TYPE_MISC)
        '    command.Parameters.AddWithValue("@ENTERED_BY", currentErcoViewUserID)
        '    command.Parameters.AddWithValue("@DATE_ENTERED", FormatDateTime(Date.Today, DateFormat.ShortDate))
        '    command.Parameters.AddWithValue("@DATE_COMPLETED", sDATE_COMPLETED)
        '    command.Parameters.AddWithValue("@DATE_NOR", sDATE_NOR)
        '    command.Parameters.AddWithValue("@DATE_PROPOSAL", sDATE_PROPOSAL)
        '    command.Parameters.AddWithValue("@BOOK_MONTH", sBOOK_MONTH)
        '    command.Parameters.AddWithValue("@BOOK_YEAR", sBOOK_YEAR)
        '    command.Parameters.AddWithValue("@DESCRIPTION", sDESCRIPTION)
        '    command.Parameters.AddWithValue("@COMMENTS", sCOMMENTS)
        '    command.Parameters.AddWithValue("@BODY_OF_WATER", sBODY_OF_WATER)
        '    command.Parameters.AddWithValue("@DRIVING_DIRECTIONS", sDRIVING_DIRECTIONS)
        '    command.Parameters.AddWithValue("@STATUS", sSTATUS)
        '    command.Parameters.AddWithValue("@CITY", sCITY)
        '    command.Parameters.AddWithValue("@COUNTY", sCOUNTY)
        '    command.Parameters.AddWithValue("@STATE", sSTATE)
        '    command.Parameters.AddWithValue("@GPS_N", sGPS_N)
        '    command.Parameters.AddWithValue("@GPS_W", sGPS_W)
        '    command.Parameters.AddWithValue("@MILE_POINT", sMILE_POINT)
        '    command.Parameters.AddWithValue("@LINE_NUMBER", sLINE_NUMBER)
        '    command.Parameters.AddWithValue("@DISTRICT", sDISTRICT)
        '    command.Parameters.AddWithValue("@CONTRACT_NO", sCONTRACT_NO)
        '    command.Parameters.AddWithValue("@WORK_ORDER_NO", sWORK_ORDER_NO)
        '    command.Parameters.AddWithValue("@PRICE_PROPOSAL", sPRICE_PROPOSAL)
        '    command.Parameters.AddWithValue("@PRICE_PERMIT", sPRICE_PERMIT)
        '    command.Parameters.AddWithValue("@PRICE_EXTRA", sPRICE_EXTRA)
        '    command.Parameters.AddWithValue("@PRICE_ACTUAL", sPRICE_ACTUAL)
        '    command.Parameters.AddWithValue("@ONE_CALL_TICKET_NO", sONE_CALL_TICKET_NO)
        '    command.Parameters.AddWithValue("@ONE_CALL_START_DATE", sONE_CALL_START_DATE)
        '    command.Parameters.AddWithValue("@ONE_CALL_EXPERATION_DATE", sONE_CALL_EXPERATION_DATE)
        '    command.Parameters.AddWithValue("@ESTIMATED_COST", sESTIMATED_COST)
        '    command.Parameters.AddWithValue("@ESTIMATED_MARGIN", sESTIMATED_MARGIN)
        '    command.Parameters.AddWithValue("@PERMITS", sPERMITS)
        '    command.Parameters.AddWithValue("@FIELD_CONTACT", sFIELD_CONTACT)
        '    command.Parameters.AddWithValue("@PIPE_DIAMETER", sPIPE_DIAMETER)
        '    command.Parameters.AddWithValue("@WATER_COURSE_DESC", sWORK_ORDER_NO)
        '    command.Parameters.AddWithValue("@SPECIFIC_PERMIT_ISSUES", sSPECIFIC_PERMIT_ISSUES)
        '    command.Parameters.AddWithValue("@CONSTRUCTION_ISSUES", sCONSTRUCTION_ISSUES)
        '    command.Parameters.AddWithValue("@PRIORITY", sPRIORITY)
        '    command.Parameters.AddWithValue("@ADDITIONAL_WORK", sADDITIONAL_WORK)
        '    command.Parameters.AddWithValue("@ADDITIONAL_WORK_COMMENT", sADDITIONAL_WORK_COMMENT)
        '    command.Parameters.AddWithValue("@CONTRACT_STATUS", sCONSTRUCTION_ISSUES)
        '    command.Parameters.AddWithValue("@PERMIT_STATUS", sPERMIT_STATUS)
        '    command.Parameters.AddWithValue("@STATUS_COMMENT", sSTATUS_COMMENT)
        '    command.Parameters.AddWithValue("@AREA_HOTEL", sAREA_HOTEL)
        '    command.Parameters.AddWithValue("@NOTES", sNOTES)
        '    command.Parameters.AddWithValue("@PRIORITY_DESCRIPTION", sPRIORITY_DESCRIPTION)
        '    command.Parameters.AddWithValue("@PROPOSAL_STATUS", sPROPOSAL_STATUS)
        '    command.Parameters.AddWithValue("@JOB_STATUS_COMMENTS", sJOB_STATUS_COMMENTS)
        '    command.Parameters.AddWithValue("@PERMIT_COST", sPERMIT_COST)
        '    command.Parameters.AddWithValue("@SALESMAN_ID1", sSALESMAN_ID1)
        '    command.Parameters.AddWithValue("@SALESMAN_ID2", sSALESMAN_ID2)
        '    command.Parameters.AddWithValue("@SALESMAN_ID3", sSALESMAN_ID3)
        '    command.Parameters.AddWithValue("@JOB_TYPE1", sJOB_TYPE_ID1)
        '    command.Parameters.AddWithValue("@JOB_TYPE2", sJOB_TYPE_ID2)
        '    command.Parameters.AddWithValue("@JOB_TYPE3", sJOB_TYPE_ID3)
        '    command.Parameters.AddWithValue("@SUPER_ID1", sSUPER_ID1)
        '    command.Parameters.AddWithValue("@SUPER_ID2", sSUPER_ID2)
        '    command.Parameters.AddWithValue("@SUPER_ID3", sSUPER_ID3)
        '    command.Parameters.AddWithValue("@VENDOR_ID1", sVENDOR_ID1)
        '    command.Parameters.AddWithValue("@VENDOR_ID2", sVENDOR_ID2)
        '    command.Parameters.AddWithValue("@VENDOR_ID3", sVENDOR_ID3)
        '    command.Parameters.AddWithValue("@CUSTOMER_ID1", sCUSTOMER_ID1)
        '    command.Parameters.AddWithValue("@CUSTOMER_ID2", sCUSTOMER_ID2)
        '    command.Parameters.AddWithValue("@CUSTOMER_ID3", sCUSTOMER_ID3)
        '    command.Parameters.AddWithValue("@CONTACT_ID1", sCONTACT_ID1)
        '    command.Parameters.AddWithValue("@CONTACT_ID2", sCONTACT_ID2)
        '    command.Parameters.AddWithValue("@CONTACT_ID3", sCONTACT_ID3)
        '    command.Parameters.AddWithValue("@ACTIVE", sACTIVE)

        '    command.ExecuteNonQuery()

        '    UpdateRow()
        '    MsgBox("Proposal created sucessfully!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "ErcoView")

        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'Finally
        '    connection.Close()
        '    connection.Dispose()
        'End Try
    End Sub

    Public Overrides Sub SaveEvent()
        myFrmProposal_eUpdateProposal()
    End Sub

    Public Overrides Function SetValues() As Boolean
        With myFrmProposal
            If .txtPROPOSAL_NO.Text <> "" Then
                sPROPOSAL_NUMBER = .txtPROPOSAL_NO.Text
            Else
                sPROPOSAL_NUMBER = vbNull
            End If

            sPRIORITY_DESCRIPTION = .txtPRIORITY_DESCRIPTION.Text
            sPRIORITY = IIf(String.IsNullOrEmpty(.txtPRIORITY.EditValue), 0, .txtPRIORITY.EditValue)
            sCITY = .txtCITY.Text
            sCOUNTY = .txtCOUNTY.Text
            sSTATE = .txtSTATE.Text
            If .txtGPS_N.Text <> "" Then
                sGPS_N = .txtGPS_N.Text
            Else
                sGPS_N = vbNull
            End If

            If .txtGPS_W.Text <> "" Then
                sGPS_W = .txtGPS_W.Text
            Else
                sGPS_W = vbNull
            End If


            sFIELD_CONTACT = .txtFIELD_CONTACT.Text



            If .txtJOB_TYPE.Tag Is Nothing Then
                Utils.GetJobTypeOfProposal(ID, sJOB_TYPE_ID1, sJOB_TYPE_ID2, sJOB_TYPE_ID3)
            Else
                Dim salesForce = .txtJOB_TYPE.Tag.Split(",")
                sJOB_TYPE_ID1 = salesForce(0)
                sJOB_TYPE_ID2 = salesForce(1)
                sJOB_TYPE_ID3 = salesForce(2)
            End If
            If (sJOB_TYPE_ID1 = 0) Then sJOB_TYPE_ID1 = 1
            If (sJOB_TYPE_ID2 = 0) Then sJOB_TYPE_ID2 = 1
            If (sJOB_TYPE_ID3 = 0) Then sJOB_TYPE_ID3 = 1
            sJOB_TYPE = .txtJOB_TYPE.Text

            sSBS_Company = .txtSBSCompany.Text


            If .txtSALESMAN_TEXT.Tag Is Nothing Then
                Utils.GetSalesmanOfProposal(ID, sSALESMAN_ID1, sSALESMAN_ID2, sSALESMAN_ID3)
            Else
                Dim salesForce = .txtSALESMAN_TEXT.Tag.Split(",")
                sSALESMAN_ID1 = salesForce(0)
                sSALESMAN_ID2 = salesForce(1)
                sSALESMAN_ID3 = salesForce(2)
            End If
            If (sSALESMAN_ID1 = 0) Then sSALESMAN_ID1 = 1
            If (sSALESMAN_ID2 = 0) Then sSALESMAN_ID2 = 1
            If (sSALESMAN_ID3 = 0) Then sSALESMAN_ID3 = 1
            sSALESMAN_TEXT = .txtSALESMAN_TEXT.Text


            If .txtCUSTOMER_TEXT.Tag Is Nothing Then
                Utils.GetCustomerOfProposal(ID, sCUSTOMER_ID1, sCUSTOMER_ID2, sCUSTOMER_ID3)
            Else
                Dim salesForce = .txtCUSTOMER_TEXT.Tag.Split(",")
                sCUSTOMER_ID1 = salesForce(0)
                sCUSTOMER_ID2 = salesForce(1)
                sCUSTOMER_ID3 = salesForce(2)
            End If
            If (sCUSTOMER_ID1 = 0) Then sCUSTOMER_ID1 = 1
            If (sCUSTOMER_ID2 = 0) Then sCUSTOMER_ID2 = 1
            If (sCUSTOMER_ID3 = 0) Then sCUSTOMER_ID3 = 1
            sCUSTOMER_TEXT = .txtCUSTOMER_TEXT.Text




            If .txtSUPER_TEXT.Tag Is Nothing Then
                Utils.GetSuperOfProposal(ID, sSUPER_ID1, sSUPER_ID2, sSUPER_ID3)
            Else
                Dim supers = .txtSUPER_TEXT.Tag.Split(",")
                sSUPER_ID1 = supers(0)
                sSUPER_ID2 = supers(1)
                sSUPER_ID3 = supers(2)
            End If
            If (sSUPER_ID1 = 0) Then sSUPER_ID1 = 1
            If (sSUPER_ID2 = 0) Then sSUPER_ID2 = 1
            If (sSUPER_ID3 = 0) Then sSUPER_ID3 = 1
            sSUPER_TEXT = .txtSUPER_TEXT.Text



            If .txtCONTACT_TEXT.Tag Is Nothing Then
                Utils.GetContactOfProposal(ID, sCONTACT_ID1, sCONTACT_ID2, sCONTACT_ID3)
            Else
                Dim contacts = .txtCONTACT_TEXT.Tag.Split(",")
                sCONTACT_ID1 = contacts(0)
                sCONTACT_ID2 = contacts(1)
                sCONTACT_ID3 = contacts(2)
            End If
            If (sCONTACT_ID1 = 0) Then sCONTACT_ID1 = 1
            If (sCONTACT_ID2 = 0) Then sCONTACT_ID2 = 1
            If (sCONTACT_ID3 = 0) Then sCONTACT_ID3 = 1
            sCONTACT_TEXT = .txtCONTACT_TEXT.Text




            If .txtVENDOR_TEXT.Tag Is Nothing Then
                Utils.GetVendorOfProposal(ID, sVENDOR_ID1, sVENDOR_ID2, sVENDOR_ID3)
            Else
                Dim VENDORs = .txtVENDOR_TEXT.Tag.Split(",")
                sVENDOR_ID1 = VENDORs(0)
                sVENDOR_ID2 = VENDORs(1)
                sVENDOR_ID3 = VENDORs(2)
            End If
            If (sVENDOR_ID1 = 0) Then sVENDOR_ID1 = 1
            If (sVENDOR_ID2 = 0) Then sVENDOR_ID2 = 1
            If (sVENDOR_ID3 = 0) Then sVENDOR_ID3 = 1
            sVENDOR_TEXT = .txtVENDOR_TEXT.Text

            If .txtPROPOSAL_PRICE.Text <> "" Then
                sPRICE_PROPOSAL = .txtPROPOSAL_PRICE.Text
            Else
                sPRICE_PROPOSAL = 0
            End If

            If .txtPRICE_PERMIT.Text <> "" Then
                sPRICE_PERMIT = .txtPRICE_PERMIT.Text
            Else
                sPRICE_PERMIT = 0
            End If

            If .txtJOB_NUMBER.Text <> "" Then
                sJOB_NUMBER = .txtJOB_NUMBER.Text
            Else
                sJOB_NUMBER = 1
            End If

            If .txtActDays.Text <> "" Then
                sActDays = .txtActDays.Text
            Else
                sActDays = 0
            End If

            If .txtEstDays.Text <> "" Then
                sEstDays = .txtEstDays.Text
            Else
                sEstDays = 0
            End If



            If .txtDATE_PROPOSAL.Text <> "" Then
                sDATE_PROPOSAL = FormatDateTime(.txtDATE_PROPOSAL.DateTime, DateFormat.ShortDate)
            End If

            If .dateCompletion.Text <> "" Then
                sDATE_COMPLETED = FormatDateTime(.dateCompletion.DateTime, DateFormat.ShortDate)
            End If

            If .dateNor.Text <> "" Then
                sDATE_NOR = FormatDateTime(.dateNor.DateTime, DateFormat.ShortDate)
            End If

            If .txtONE_CALL_START_DATE.Text <> "" Then
                sONE_CALL_START_DATE = FormatDateTime(.txtONE_CALL_START_DATE.DateTime, DateFormat.ShortDate)
            End If

            If .txtONE_CALL_EXPERATION_DATE.Text <> "" Then
                sONE_CALL_EXPERATION_DATE = FormatDateTime(.txtONE_CALL_EXPERATION_DATE.DateTime, DateFormat.ShortDate)
            End If

            sOC_START_TIME = .txtOCStartTime.Text

            sDESCRIPTION = .txtDESCRIPTION.Text
            sCOMMENTS = .txtCOMMENTS.Text
            sBODY_OF_WATER = .txtBODY_OF_WATER.Text
            sMILE_POINT = .txtMILE_POINT.Text
            sLINE_NUMBER = .txtLINE_NUMBER.Text
            sDISTRICT = .txtDISCTRICT.Text
            sDRIVING_DIRECTIONS = .txtDRIVING_DIRECTION.Text


            If .cmboBookYear.Text <> "" Then
                sCONST_YEAR = .cmboBookYear.Text

            End If

            sCONST_MONTH = .cmboBookMonth.Text
            sSUPERINTENDENT = .txtSUPER_TEXT.Text
            sCUSTOMERS = .txtCUSTOMER_TEXT.Text

            sEQUIPMENT = .txtVENDOR_TEXT.Text
            sJOB_TYPE_MISC = .txtJOB_TYPE_MISC.Text

            sSTATUS = .txtSTATUS.Text
            sCONTRACT_NO = .txtCONTRACT_NO.Text
            sWORK_ORDER_NO = .txtWORK_ORDER_NO.Text
            sJOB_STATUS = .cmboJobStatus.Text
            sJOB_STATUS_COMMENTS = .txtJobComment.Text

            If .txtPERMIT_COST.Text <> "" Then
                sPERMIT_COST = .txtPERMIT_COST.Text
            Else
                sPERMIT_COST = 0
            End If

            If .txtPRICE_EXTRA.Text <> "" Then
                sPRICE_EXTRA = .txtPRICE_EXTRA.Text
            Else
                sPRICE_EXTRA = 0
            End If

            If .txtPRICE_ACTUAL.Text <> "" Then
                sPRICE_ACTUAL = .txtPRICE_ACTUAL.Text
            Else
                sPRICE_ACTUAL = 0
            End If

            'If .txtONE_CALL_TICKET_NO.Text <> "" Then
            sONE_CALL_TICKET_NO = .txtONE_CALL_TICKET_NO.Text
            ' Else
            '  sONE_CALL_TICKET_NO = vbNull
            '  End If

            If .txtESTIMATED_COST.Text <> "" Then
                sESTIMATED_COST = .txtESTIMATED_COST.Text
            Else
                sESTIMATED_COST = 0
            End If

            If .txtESTIMATED_MARGIN.Text <> "" Then
                sESTIMATED_MARGIN = .txtESTIMATED_MARGIN.Text
            Else
                sESTIMATED_MARGIN = 0
            End If

            sPERMITS = .txtPERMIT.Text

            sPIPE_DIAMETER = .txtPIPE_DIAMETER.Text
            sWATER_COURSE_DESC = .txtWATER_COURSE_DESC.Text
            sCONSTRUCTION_ISSUES = .txtCONSTRUCTION_ISSUES.Text

            sSPECIFIC_PERMIT_ISSUES = .txtSPECIFIC_PERMIT_ISSUES.Text


            sADDITIONAL_WORK = .chkADDITIONAL_WORK.Checked
            sADDITIONAL_WORK_COMMENT = .txtADDITIONAL_WORK_COMMENT.Text
            sCONTRACT_STATUS = .cmboContractStatus.Text
            sPERMIT_STATUS = .txtPERMIT_STATUS.Text
            sSTATUS_COMMENT = .memoPendingComments.Text
            sAREA_HOTEL = .txtAREA_HOTEL.Text
            sNOTES = .txtNOTES.Text
            sACTIVE = .txtACTIVE.Text

        End With

        ' Validation
        If False = ValidateProposalData() Then
            Return False
        End If

        Return True
    End Function

    Public Function ValidateProposalData()
        If userPermission = 1 Then
            Return True
        End If
        Dim sErrorMessage As String = "Missing fields: " & vbCrLf
        If String.IsNullOrEmpty(sPRIORITY_DESCRIPTION) Then sErrorMessage += " * Priority Description " & vbCrLf
        If String.IsNullOrEmpty(sPRIORITY) Then sErrorMessage += " * Priority " & vbCrLf
        If String.IsNullOrEmpty(sCITY) Then sErrorMessage += " * City " & vbCrLf
        If String.IsNullOrEmpty(sCOUNTY) Then sErrorMessage += " * County " & vbCrLf
        If String.IsNullOrEmpty(sSTATE) Then sErrorMessage += " * State " & vbCrLf
        If String.IsNullOrEmpty(sGPS_N) Then sErrorMessage += " * GPS N " & vbCrLf
        If String.IsNullOrEmpty(sGPS_W) Then sErrorMessage += " * GPS W " & vbCrLf
        If String.IsNullOrEmpty(sSALESMAN_TEXT) Then sErrorMessage += " * Salesman " & vbCrLf
        If String.IsNullOrEmpty(sCONTACT_TEXT) Then sErrorMessage += " * Contact " & vbCrLf
        If String.IsNullOrEmpty(sFIELD_CONTACT) Then sErrorMessage += " * Field " & vbCrLf
        If String.IsNullOrEmpty(sSTATUS) Then sErrorMessage += " * Const Sch Status " & vbCrLf
        If String.IsNullOrEmpty(sJOB_TYPE) Then sErrorMessage += " * Job Type " & vbCrLf
        If String.IsNullOrEmpty(sSBS_Company) Then sErrorMessage += " * SBS Company " & vbCrLf

        If sErrorMessage = "Missing fields: " & vbCrLf Then
            Return True
        Else
            sErrorMessage += "Please fill the missing data and try again..."
            MessageBox.Show(sErrorMessage, "Missing data")
            Return False
        End If
    End Function

    Public Overrides Sub ShowForm()
        With myFrmProposal

            Dim oConnString As String = GetConnectionString()
            .SpGetProposalsTableAdapter.Connection = New SqlConnection(oConnString)
            .ProposalID = ID
            '.txtPROPOSAL_ID.Text = ID
            If ID <> 0 Then
                .SpGetProposalsTableAdapter.Fill(.DsErcoView.spGetProposals, ID)
            Else
                .txtPROPOSAL_NO.Text = "PENDING"
                .txtUpdatedBy.Tag = currentErcoViewUserID
                .txtCreatedBy.Tag = currentErcoViewUserID
            End If

            .Show()
            .Hide()
            Dim sUserFistName As String = "" : Dim sUserLastName As String = ""
            ' Created By
            Utils.GetUserNameById(.txtCreatedBy.Tag, sUserFistName, sUserLastName)
            .txtCreatedBy.Text = String.Format("{0} {1}", sUserFistName, sUserLastName)
            ' Updated By
            Utils.GetUserNameById(.txtUpdatedBy.Tag, sUserFistName, sUserLastName)
            .txtUpdatedBy.Text = String.Format("{0} {1}", sUserFistName, sUserLastName)

            'myFrmProposal.txtSALESMAN_TEXT.Text = Utils.GetTextStringFromIDs(DataType.Salesman, ID, myFrmProposal.txtSALESMAN_TEXT.Tag)
            'myFrmProposal.txtCUSTOMER_TEXT.Text = Utils.GetTextStringFromIDs(DataType.Customer, ID, myFrmProposal.txtCUSTOMER_TEXT.Tag)
            'myFrmProposal.txtCONTACT_TEXT.Text = Utils.GetTextStringFromIDs(DataType.Contact, ID, myFrmProposal.txtCONTACT_TEXT.Tag)
            'myFrmProposal.txtVENDOR_TEXT.Text = Utils.GetTextStringFromIDs(DataType.Vendor, ID, myFrmProposal.txtVENDOR_TEXT.Tag)
            'myFrmProposal.txtSUPER_TEXT.Text = Utils.GetTextStringFromIDs(DataType.Super, ID, myFrmProposal.txtSUPER_TEXT.Tag)
            'myFrmProposal.txtJOB_TYPE.Text = Utils.GetTextStringFromIDs(DataType.JobType, ID, myFrmProposal.txtJOB_TYPE.Tag)

            If ID <> 0 Then
                .txtPRIORITY.SelectedIndex = .DsErcoView.spGetProposals.Item(0).PRIORITY - 1

            End If

            If userPermission = 1 Then
                .txtPROPOSAL_NO.Properties.ReadOnly = False
            End If
            .Show()
            .WindowState = FormWindowState.Normal
            .Hide()
            .Opacity = 1
            If .ShowDialog() = DialogResult.Cancel Then

            End If

        End With
    End Sub

    Public Overrides Sub UpdateRow()
        SetValues()
    End Sub

End Class
