Imports System.Data.SqlClient

Public Class clsFrmContact
    Inherits clsBase

    Public WithEvents myFrmContact As New frmContact

    Private ContactFirstName As String
    Private ContactLastName As String
    Private customerName As String
    Private customerID As String
    Private address1 As String
    Private address2 As String
    Private email As String
    Private city As String
    Private county As String
    Private state As String
    Private phone1 As String
    Private phone2 As String
    Private fax As String
    Private website As String
    Private zipcode As String
    Private notes As String
    Private activeStatus As String


    Public Sub myFrmContact_eSaveContact() Handles myFrmContact.eSaveContact
        If False = SetValues() Then
            Exit Sub
        End If

        Dim msgResponse As Integer = MsgBox("Are you sure you want to save changes to this Contact?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ErcoView")
        If msgResponse <> 6 Then
            Exit Sub
        End If

        If ID <> 0 Then
            UpdateRow()
        Else
            InsertRow()
        End If
        didUpdate = True
    End Sub

    Public Overrides Sub SaveEvent()
        myFrmContact_eSaveContact()
    End Sub

    Public Overrides Function SetValues() As Boolean
        Try
            ContactFirstName = myFrmContact.txtFirstName.Text
            ContactLastName = myFrmContact.txtLastName.Text
            customerName = myFrmContact.txtCustomerName.Text


            customerID = myFrmContact.txtCustomerName.SelectedItem.Id
            address1 = myFrmContact.txtAddressLine1.Text
            address2 = myFrmContact.txtAddressLine2.Text
            email = myFrmContact.txtEmail.Text
            city = myFrmContact.txtCity.Text
            county = myFrmContact.txtCounty.Text
            state = myFrmContact.cmboState.Text
            phone1 = myFrmContact.txtPhone.Text
            phone2 = myFrmContact.txtPhone2.Text
            fax = myFrmContact.txtFax.Text
            website = myFrmContact.txtWebsite.Text
            zipcode = myFrmContact.txtZipCode.Text
            activeStatus = myFrmContact.txtActiveStatus.Text
            notes = myFrmContact.memoNotes.Text

            ' Validation
            If False = ValidateContactlData() Then
                Return False
            End If

            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function


    Public Function ValidateContactlData() As Boolean
        'If userPermission = 1 Then
        '    Return True
        'End If

        Dim sErrorMessage As String = "Missing fields: " & vbCrLf
        If String.IsNullOrEmpty(ContactFirstName) Then sErrorMessage += " * First name " & vbCrLf
        If String.IsNullOrEmpty(ContactLastName) Then sErrorMessage += " * Last name " & vbCrLf
        If String.IsNullOrEmpty(customerName) Then sErrorMessage += " * Customer name " & vbCrLf
        If String.IsNullOrEmpty(city) Then sErrorMessage += " * City " & vbCrLf
        If String.IsNullOrEmpty(phone1) Then sErrorMessage += " * Phone " & vbCrLf
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
        myFrmContact.SpGetContactTableAdapter.Connection = New SqlConnection(oConnString)

        If ID > 0 Then
            myFrmContact.SpGetContactTableAdapter.Fill(myFrmContact.DsErcoView.spGetContact, ID)
            myFrmContact.txtCustomerName.EditValue = myFrmContact.DsErcoView.spGetContact.Rows(0).Item("CUSTOMER_NAME")
            'myFrmContact.txtCustomerName.SelectedItem.id = myFrmContact.DsErcoView.spGetContact.Rows(0).Item("CUSTOMER_NAME")
        End If

        myFrmContact.ShowDialog()
    End Sub

    Public Overrides Sub UpdateRow()
        Dim conString As String = GetConnectionString()
        Using connection As SqlConnection = New SqlConnection(conString)
            connection.Open()
            Try
                Dim command As SqlCommand = New SqlCommand("spUpdateContact", connection) With {.CommandType = CommandType.StoredProcedure}
                command.Parameters.AddWithValue("@cID", ID)
                command.Parameters.AddWithValue("@cFirstName", ContactFirstName)
                command.Parameters.AddWithValue("@cLastName", ContactLastName)
                command.Parameters.AddWithValue("@cCustomerID", customerID)
                command.Parameters.AddWithValue("@cEmail", email)
                command.Parameters.AddWithValue("@AddressLine1", address1)
                command.Parameters.AddWithValue("@AddressLine2", address2)
                command.Parameters.AddWithValue("@cCity", city)
                command.Parameters.AddWithValue("@cCounty", county)
                command.Parameters.AddWithValue("@cState", state)
                command.Parameters.AddWithValue("@cPhone", phone1)
                command.Parameters.AddWithValue("@cPhone2", phone2)
                command.Parameters.AddWithValue("@cFax", fax)
                command.Parameters.AddWithValue("@cZipCode", zipcode)
                command.Parameters.AddWithValue("@cWebsite", website)
                command.Parameters.AddWithValue("@cNotes", notes)
                command.Parameters.AddWithValue("@cActive", activeStatus)
                command.ExecuteNonQuery()
                MsgBox("Contact updated sucessfully!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "ErcoView")
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                connection.Close()
            End Try
        End Using
    End Sub

    Public Overrides Sub InsertRow()
        Dim conString As String = GetConnectionString()
        Using connection As SqlConnection = New SqlConnection(conString)
            connection.Open()
            Try
                Dim command As SqlCommand = New SqlCommand("spInsertContact", connection) With {.CommandType = CommandType.StoredProcedure}
                command.Parameters.AddWithValue("@cID", ID)
                command.Parameters.AddWithValue("@cFirstName", ContactFirstName)
                command.Parameters.AddWithValue("@cLastName", ContactLastName)
                command.Parameters.AddWithValue("@AddressLine1", address1)
                command.Parameters.AddWithValue("@AddressLine2", address2)
                command.Parameters.AddWithValue("@cCity", city)
                command.Parameters.AddWithValue("@cZipCode", zipcode)
                command.Parameters.AddWithValue("@cCounty", county)
                command.Parameters.AddWithValue("@cState", state)
                command.Parameters.AddWithValue("@cPhone", phone1)
                command.Parameters.AddWithValue("@cPhone2", phone2)
                command.Parameters.AddWithValue("@cFax", fax)
                command.Parameters.AddWithValue("@cEmail", email)
                command.Parameters.AddWithValue("@cCustomerID", customerID)
                command.Parameters.AddWithValue("@cNotes", notes)
                command.Parameters.AddWithValue("@cActive", activeStatus)
                command.ExecuteNonQuery()
                MsgBox("Contact created sucessfully!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "ErcoView")
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                connection.Close()
            End Try
        End Using
    End Sub
End Class

