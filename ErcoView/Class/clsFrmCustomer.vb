Imports System.Data.SqlClient

Public Class clsFrmCustomer
    Inherits clsBase

    Public WithEvents myFrmCustomer As New frmCustomer

    Private customerName As String = ""
    Private address1 As String = ""
    Private address2 As String = ""
    Private city As String = ""
    Private county As String = ""
    Private state As String = ""
    Private phone As String = ""
    Private fax As String = ""
    Private website As String = ""
    Private zipcode As String = ""
    Private notes As String = ""
    Private group_ID1 As Integer = -1
    Private group_ID2 As Integer = -1
    Private group_ID3 As Integer = -1
    Private group_ID_TEXT As String = ""
    Private ActiveStatus As String = ""
    Private customerType As String = ""
    Public isVendor As Integer

    Private Sub myFrmCustomer_eAddGroup() Handles myFrmCustomer.eAddGroup
        If myFrmCustomer.txtGroups.Tag Is Nothing Then
            Utils.GetGroupOfCustomer(ID, group_ID1, group_ID2, group_ID3)
        Else
            Dim IdArray() As String = myFrmCustomer.txtGroups.Tag.ToString.Split(",")
            group_ID1 = IdArray(0)
            group_ID2 = IdArray(1)
            group_ID3 = IdArray(2)
        End If

        Dim oGroups As New clsFrmList(DataType.Group, ID, group_ID1, group_ID2, group_ID3, 0, 0, 0)
        myFrmCustomer.txtGroups.Tag = String.Format("{0},{1},{2}", group_ID1, group_ID2, group_ID3)
        If oGroups.m_NewValue <> "cancel" Then
            myFrmCustomer.txtGroups.Text = oGroups.m_NewValue
        End If

    End Sub

    Public Sub myFrmCustomer_eSaveCustomer() Handles myFrmCustomer.eSaveCustomer
        If False = SetValues() Then
            Exit Sub
        End If

        Dim msgResponse As Integer = MsgBox("Are you sure you want to save changes to this customer?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ErcoView")
        If msgResponse <> 6 Then
            Exit Sub
        End If

        If ID <> 0 Then
            UpdateRow()
        Else
            InsertRow()
        End If
        didUpdate = True
        'myFrmCustomer.Close()
    End Sub

    Public Overrides Sub InsertRow()
        Dim conString As String = GetConnectionString()
        Using connection As SqlConnection = New SqlConnection(conString)
            connection.Open()
            Try
                Dim command As SqlCommand = New SqlCommand("spInsertCustomer", connection) With {.CommandType = CommandType.StoredProcedure}
                command.Parameters.AddWithValue("@cID", ID)
                command.Parameters.AddWithValue("@cName", customerName)
                command.Parameters.AddWithValue("@cAddress1", address1)
                command.Parameters.AddWithValue("@cAddress2", address2)
                command.Parameters.AddWithValue("@cCity", city)
                command.Parameters.AddWithValue("@cCounty", county)
                command.Parameters.AddWithValue("@cState", state)
                command.Parameters.AddWithValue("@cPhone", phone)
                command.Parameters.AddWithValue("@cFax", fax)
                command.Parameters.AddWithValue("@cZipCode", zipcode)
                command.Parameters.AddWithValue("@cWebSite", website)
                command.Parameters.AddWithValue("@cNotes", notes)
                command.Parameters.AddWithValue("@cEquipment", 0) 'isEquipment
                command.Parameters.AddWithValue("@cGroupID1", group_ID1)
                command.Parameters.AddWithValue("@cGroupID2", group_ID2)
                command.Parameters.AddWithValue("@cGroupID3", group_ID3)
                command.Parameters.AddWithValue("@cIsVendor", isVendor)
                command.Parameters.AddWithValue("@cType", customerType)
                command.Parameters.AddWithValue("@cActive", ActiveStatus)
                command.ExecuteNonQuery()
                MsgBox("Customer created sucessfully!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "ErcoView")
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                connection.Close()
            End Try
        End Using
    End Sub

    Public Overrides Sub SaveEvent()
        myFrmCustomer_eSaveCustomer()
    End Sub

    Public Overrides Function SetValues() As Boolean
        customerName = myFrmCustomer.txtCustomerName.Text
        address1 = myFrmCustomer.txtAddressLine1.Text
        address2 = myFrmCustomer.txtAddressLine2.Text
        city = myFrmCustomer.txtCity.Text
        county = myFrmCustomer.txtCounty.Text
        state = myFrmCustomer.cmboState.Text
        phone = myFrmCustomer.txtPhone.Text
        fax = myFrmCustomer.txtFax.Text
        website = myFrmCustomer.txtWebsite.Text
        zipcode = myFrmCustomer.txtZipCode.Text
        notes = myFrmCustomer.memoNotes.Text
        customerType = myFrmCustomer.cmboCustomerType.Text
        If myFrmCustomer.txtGroups.Tag Is Nothing Then
            Utils.GetGroupOfCustomer(ID, group_ID1, group_ID2, group_ID3)
        Else
            Dim IDs = SplitStringIntoThree(myFrmCustomer.txtGroups.Tag)
            group_ID1 = IDs(0)
            group_ID2 = IDs(1)
            group_ID3 = IDs(2)
        End If
        If (group_ID1 = 0) Then group_ID1 = 1
        If (group_ID2 = 0) Then group_ID2 = 1
        If (group_ID3 = 0) Then group_ID3 = 1

        group_ID_TEXT = myFrmCustomer.txtGroups.Text
        ActiveStatus = myFrmCustomer.txtActive.Text

        ' Validation
        If False = ValidateCustomerlData() Then
            Return False
        End If
        Return True
    End Function

    Public Function ValidateCustomerlData() As Boolean
        If userPermission = 1 Then
            Return True
        End If

        Dim sErrorMessage As String = "Missing fields: " & vbCrLf
        If String.IsNullOrEmpty(customerName) Then sErrorMessage += " * Customer name " & vbCrLf
        'If String.IsNullOrEmpty(group_ID_TEXT) Then sErrorMessage += " * Group " & vbCrLf
        If String.IsNullOrEmpty(city) Then sErrorMessage += " * City " & vbCrLf
        If String.IsNullOrEmpty(phone) Then sErrorMessage += " * Phone " & vbCrLf
        If String.IsNullOrEmpty(state) Then sErrorMessage += " * State " & vbCrLf

        If sErrorMessage = "Missing fields: " & vbCrLf Then
            Return True
        Else
            sErrorMessage += "Please fill the missing data and try again..."
            MessageBox.Show(sErrorMessage, "Missing data")
            Return False
        End If
    End Function

    Public Overrides Sub ShowForm()
        Dim oConnString As String = GetConnectionString()
        myFrmCustomer.SpGetCustomerTableAdapter.Connection = New SqlConnection(oConnString)

        If ID <> 0 Then
            myFrmCustomer.SpGetCustomerTableAdapter.Fill(myFrmCustomer.DsErcoView.spGetCustomer, ID)
        End If

        myFrmCustomer.ShowDialog()
    End Sub

    Public Overrides Sub UpdateRow()
        Dim conString As String = GetConnectionString()
        Using connection As SqlConnection = New SqlConnection(conString)
            connection.Open()
            Try
                Dim command As SqlCommand = New SqlCommand("spUpdateCustomer", connection) With {.CommandType = CommandType.StoredProcedure}
                command.Parameters.AddWithValue("@cID", ID)
                command.Parameters.AddWithValue("@cName", customerName)
                command.Parameters.AddWithValue("@cAddress1", address1)
                command.Parameters.AddWithValue("@cAddress2", address2)
                command.Parameters.AddWithValue("@cCity", city)
                command.Parameters.AddWithValue("@cCounty", county)
                command.Parameters.AddWithValue("@cState", state)
                command.Parameters.AddWithValue("@cPhone", phone)
                command.Parameters.AddWithValue("@cFax", fax)
                command.Parameters.AddWithValue("@cZipCode", zipcode)
                command.Parameters.AddWithValue("@cWebSite", website)
                command.Parameters.AddWithValue("@cNotes", notes)
                command.Parameters.AddWithValue("@cGroup_ID1", group_ID1)
                command.Parameters.AddWithValue("@cGroup_ID2", group_ID2)
                command.Parameters.AddWithValue("@cGroup_ID3", group_ID3)
                command.Parameters.AddWithValue("@cType", customerType)
                command.Parameters.AddWithValue("@cActive", ActiveStatus)
                command.ExecuteNonQuery()
                MsgBox("Customer updated sucessfully!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "ErcoView")
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                connection.Close()
            End Try
        End Using
    End Sub

End Class
