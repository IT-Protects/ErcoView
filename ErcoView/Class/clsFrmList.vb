
Public Class clsFrmList
    WithEvents oFrmList As New frmList
    Public m_ProposalID As Integer
    Public m_NewValue As String = ""
    Private spDelete As String
    Private spSet As String
    Private spID As String

    Private m_SelectedItem1 As String
    Private m_SelectedItem2 As String
    Private m_SelectedItem3 As String

    Private m_SelectedItemID1 As Integer
    Private m_SelectedItemID2 As Integer
    Private m_SelectedItemID3 As Integer

    Private _DataType As Integer
    Private p1 As Integer
    Private p2 As Integer
    Private p3 As Integer

    Public Sub New(ByVal currentSelectionSBSCompany As String)

        oFrmList.lstItemList.DisplayMember = "SBS_COMPANY"

        oFrmList.Text = "Select SBS Company"

        oFrmList.Show()
        oFrmList.Hide()

        Dim oSBSArray = currentSelectionSBSCompany.Split(",")
        If oSBSArray.Contains("E-Tech") Then
            oFrmList.lstItemList.Items.Add("E-Tech", True)
        Else
            oFrmList.lstItemList.Items.Add("E-Tech", False)
        End If

        If oSBSArray.Contains("E-Dyne") Then
            oFrmList.lstItemList.Items.Add("E-Dyne", True)
        Else
            oFrmList.lstItemList.Items.Add("E-Dyne", False)
        End If

        If oSBSArray.Contains("SBT") Then
            oFrmList.lstItemList.Items.Add("SBT", True)
        Else
            oFrmList.lstItemList.Items.Add("SBT", False)
        End If

    End Sub


    Public Sub New(ByVal DataTyp As Integer, ByVal ProposalID As Integer, ByRef SelectedId1 As Integer, ByRef SelectedId2 As Integer, ByRef SelectedId3 As Integer, Optional ByVal cs1 As Integer = 0, Optional ByVal cs2 As Integer = 0, Optional ByVal cs3 As Integer = 0)

        _DataType = DataTyp
        m_ProposalID = ProposalID

        m_SelectedItemID1 = SelectedId1
        m_SelectedItemID2 = SelectedId2
        m_SelectedItemID3 = SelectedId3
        p1 = cs1
        p2 = cs2
        p3 = cs3

        'm_NewValue = 
        Select Case _DataType
            Case DataType.JobType
                LoadJobTypes()
            Case DataType.SBSCompany
                LoadSBSCompany()
                Exit Sub
            Case DataType.Customer
                LoadCustomer()
            Case DataType.Salesman
                LoadSalesman()
            Case DataType.Super
                LoadSuper()
            Case DataType.Vendor
                LoadVendor()
            Case DataType.Contact
                LoadContact()
            Case DataType.Group
                LoadGroup()
            Case Else
                MsgBox("Invalid datatype")
        End Select

        ' latest Ids of selected items
        '
        SelectedId1 = m_SelectedItemID1
        SelectedId2 = m_SelectedItemID2
        SelectedId3 = m_SelectedItemID3

    End Sub

    Private Sub InitializeCheckmark()
        oFrmList.Visible = False
        oFrmList.Show()
        oFrmList.Hide()

        Dim lstCount As Integer = oFrmList.lstItemList.ItemCount
        For x As Integer = 0 To lstCount - 1
            If oFrmList.lstItemList.GetItem(x).Row.Itemarray(0).Equals(m_SelectedItemID1) Or _
                oFrmList.lstItemList.GetItem(x).Row.Itemarray(0).Equals(m_SelectedItemID2) Or _
                oFrmList.lstItemList.GetItem(x).Row.Itemarray(0).Equals(m_SelectedItemID3) Then
                oFrmList.lstItemList.SetItemCheckState(x, CheckState.Checked)
                'MsgBox(oFrmList.lstItemList.GetItemValue(x).ToString)
            End If
            '  MsgBox(oFrmList.lstItemList.GetItemValue(x).ToString)
        Next

        oFrmList.Show()
        oFrmList.WindowState = FormWindowState.Normal
        oFrmList.Hide()

        If DialogResult.Cancel = oFrmList.ShowDialog() Then
            m_NewValue = "cancel"
            Exit Sub
        End If



        m_SelectedItemID1 = 0
        m_SelectedItemID2 = 0
        m_SelectedItemID3 = 0
        Dim nCtr As Integer = 0
        For Each checkedItem As Object In oFrmList.lstItemList.CheckedItems
            If nCtr = 0 Then m_SelectedItemID1 = checkedItem.Row.ItemArray(0)
            If nCtr = 1 Then m_SelectedItemID2 = checkedItem.Row.ItemArray(0)
            If nCtr = 2 Then m_SelectedItemID3 = checkedItem.Row.ItemArray(0)
            nCtr += 1
        Next

    End Sub

    Public Function GetSBSCompany() As String
        oFrmList.Visible = False

        oFrmList.Show()
        oFrmList.WindowState = FormWindowState.Normal
        oFrmList.Hide()

        If DialogResult.Cancel = oFrmList.ShowDialog() Then
            m_NewValue = "cancel"
            Return ""
        End If

        Dim m_SelectedItemString1 As String = String.Empty
        Dim m_SelectedItemString2 As String = String.Empty
        Dim m_SelectedItemString3 As String = String.Empty

        Dim nCtr As Integer = 0
        For Each checkedItem As Object In oFrmList.lstItemList.CheckedItems
            If nCtr = 0 Then m_SelectedItemString1 = checkedItem.Value
            If nCtr = 1 Then m_SelectedItemString2 = checkedItem.Value
            If nCtr = 2 Then m_SelectedItemString3 = checkedItem.Value
            nCtr += 1
        Next

        Dim retString As String = ""
        If Not String.IsNullOrEmpty(m_SelectedItemString1) Then
            retString = m_SelectedItemString1
        End If

        If Not String.IsNullOrEmpty(m_SelectedItemString2) Then
            retString = retString + "," + m_SelectedItemString2
        End If

        If Not String.IsNullOrEmpty(m_SelectedItemString3) Then
            retString = retString + "," + m_SelectedItemString3
        End If

        If Not String.IsNullOrEmpty(retString) Then
            If retString.First() = "," Then
                retString = retString.Substring(2)
            End If

            If retString.Last() = "," Then
                retString = retString.Substring(0, retString.Length - 1)
            End If
        End If


        Return retString
    End Function

    Private Sub LoadSBSCompany()
        Try
            oFrmList.lstItemList.DisplayMember = "SBS_COMPANY"
            oFrmList.lstItemList.ValueMember = "SBS_COMPANY"

            oFrmList.Text = "Select SBS Company"

            GetSBSCompany()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub LoadJobTypes()
        Try
            oFrmList.lstItemList.DataSource = oFrmList.SpGetJobTypesBindingSource
            oFrmList.lstItemList.DisplayMember = "JOB_TYPE"
            oFrmList.lstItemList.ValueMember = "JOB_TYPE_ID"

            oFrmList.SpGetJobTypesTableAdapter.Connection = New SqlClient.SqlConnection(GetConnectionString())
            oFrmList.SpGetJobTypesTableAdapter.Fill(oFrmList.DsErcoView.spGetJobTypes)
            oFrmList.Text = "Select Job Types"
            spDelete = "spDeleteJobTypes"
            spSet = "spSetJobTypes"
            spID = "@jobTypeID"



            InitializeCheckmark()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub LoadSalesman()
        oFrmList.lstItemList.DataSource = oFrmList.SpGetSalesmanBindingSource
        oFrmList.lstItemList.DisplayMember = "SALESMAN"
        oFrmList.lstItemList.ValueMember = "USER_ID"
        oFrmList.SpGetSalesmanTableAdapter.Connection = New SqlClient.SqlConnection(GetConnectionString())
        oFrmList.SpGetSalesmanTableAdapter.Fill(oFrmList.DsErcoView.spGetSalesman)
        oFrmList.Text = "Select Salesman"
        spDelete = "spDeleteSalesman"
        spSet = "spSetSalesman"
        spID = "@userID"

        Dim fname As String = "" : Dim lname As String = ""
        Utils.GetSalesmanNameById(m_SelectedItemID1, fname, lname)
        m_SelectedItem1 = String.Format("{0} {1}", fname, lname)

        Utils.GetSalesmanNameById(m_SelectedItemID2, fname, lname)
        m_SelectedItem2 = String.Format("{0} {1}", fname, lname)

        Utils.GetSalesmanNameById(m_SelectedItemID3, fname, lname)
        m_SelectedItem3 = String.Format("{0} {1}", fname, lname)

        InitializeCheckmark()

    End Sub

    Private Sub LoadSuper()
        oFrmList.lstItemList.DataSource = oFrmList.SpGetSuperBindingSource
        oFrmList.lstItemList.DisplayMember = "SUPER"
        oFrmList.lstItemList.ValueMember = "USER_ID"

        oFrmList.SpGetSuperTableAdapter.Connection = New SqlClient.SqlConnection(GetConnectionString())
        oFrmList.SpGetSuperTableAdapter.Fill(oFrmList.DsErcoView.spGetSuper)
        oFrmList.lstItemList.Refresh()
        oFrmList.Text = "Select Superintendents"
        spDelete = "spDeleteSuper"
        spSet = "spSetSuper"
        spID = "@userID"

        InitializeCheckmark()

    End Sub

    Private Sub LoadContact()
        oFrmList.lstItemList.DataSource = oFrmList.SpGetContactsBindingSource
        oFrmList.lstItemList.DisplayMember = "CONTACT_NAME"
        oFrmList.lstItemList.ValueMember = "CONTACT_ID"
        oFrmList.SpGetContactsTableAdapter.Connection = New SqlClient.SqlConnection(GetConnectionString())
        oFrmList.SpGetContactsTableAdapter.Fill(oFrmList.DsErcoView.spGetContacts, p1, p2, p3)
        oFrmList.lstItemList.Refresh()
        oFrmList.Text = "Select Contacts"
        spDelete = "spDeleteCompanyFromProposal"
        spSet = "spSetContact"
        spID = "@companyID"

        InitializeCheckmark()

    End Sub

    Private Sub LoadGroup()
        oFrmList.lstItemList.DataSource = oFrmList.SpGetGroupsBindingSource
        oFrmList.lstItemList.DisplayMember = "GROUP_NAME"
        oFrmList.lstItemList.ValueMember = "GROUP_ID"

        oFrmList.SpGetGroupsTableAdapter.Connection = New SqlClient.SqlConnection(GetConnectionString())
        oFrmList.SpGetGroupsTableAdapter.Fill(oFrmList.DsErcoView.spGetGroups)
        oFrmList.lstItemList.Refresh()
        oFrmList.Text = "Select Groups"
        spDelete = "spDeleteCompanyFromProposal"
        spSet = "spSetGroup"
        spID = "@companyID"

        InitializeCheckmark()

    End Sub

    Private Sub LoadCustomer()
        oFrmList.lstItemList.DataSource = oFrmList.SpGetCustomersBindingSource
        oFrmList.lstItemList.DisplayMember = "CUSTOMER_NAME"
        oFrmList.lstItemList.ValueMember = "CUSTOMER_ID"
        oFrmList.SpGetCustomersTableAdapter.Connection = New SqlClient.SqlConnection(GetConnectionString())
        oFrmList.SpGetCustomersTableAdapter.Fill(oFrmList.DsErcoView.spGetCustomers)
        oFrmList.lstItemList.Refresh()
        oFrmList.Text = "Select Customers"
        spDelete = "spDeleteCompanyFromProposal"
        spSet = "spSetCustomer"
        spID = "@companyID"

        InitializeCheckmark()

    End Sub

    Private Sub LoadVendor()
        oFrmList.lstItemList.DataSource = oFrmList.SpGetVendorsBindingSource
        oFrmList.lstItemList.DisplayMember = "VENDOR_NAME"
        oFrmList.lstItemList.ValueMember = "VENDOR_ID"

        oFrmList.SpGetVendorsTableAdapter.Connection = New SqlClient.SqlConnection(GetConnectionString())
        oFrmList.SpGetVendorsTableAdapter.Fill(oFrmList.DsErcoView.spGetVendors)
        oFrmList.lstItemList.Refresh()
        oFrmList.Text = "Select Vendors"
        spDelete = "spDeleteVendor"
        spSet = "spSetVendor"
        spID = "@vendorID"

        InitializeCheckmark()

    End Sub

    Public Sub oFrmList_eClickOK() Handles oFrmList.eClickOK
        SetItems()
        oFrmList.Close()
    End Sub


    Private Sub SetItems()
        Dim sID1 As Integer = 0
        Dim sID2 As Integer = 0
        Dim sID3 As Integer = 0
        Dim Count As Integer = 0
        m_NewValue = ""
        Dim lstCount As Integer = oFrmList.lstItemList.ItemCount
        For x As Integer = 0 To lstCount - 1
            If oFrmList.lstItemList.GetItemCheckState(x) = CheckState.Checked Then
                Select Case Count
                    Case 0
                        sID1 = x
                        If m_NewValue <> "" Then
                            m_NewValue = m_NewValue + "," + oFrmList.lstItemList.GetItemText(x)
                        Else
                            m_NewValue = oFrmList.lstItemList.GetItemText(x)
                        End If
                        Count = Count + 1
                    Case 1
                        sID2 = x
                        If m_NewValue <> "" Then
                            m_NewValue = m_NewValue + "," + oFrmList.lstItemList.GetItemText(x)
                        Else
                            m_NewValue = oFrmList.lstItemList.GetItemText(x)
                        End If
                        Count = Count + 1
                    Case 2
                        sID3 = x
                        If m_NewValue <> "" Then
                            m_NewValue = m_NewValue + "," + oFrmList.lstItemList.GetItemText(x)
                        Else
                            m_NewValue = oFrmList.lstItemList.GetItemText(x)
                        End If
                        Exit For
                End Select
            End If
        Next

    End Sub

End Class
