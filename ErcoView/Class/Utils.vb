Imports System.Data.SqlClient

Public Class Utils

    Public Shared Sub GetUserNameById(ByVal UserId As Integer, ByRef fName As String, ByRef lName As String)

        Dim conString As String = GetConnectionString()
        Dim connection As SqlConnection = New SqlConnection(conString)
        connection.Open()
        Try
            Dim command As SqlCommand = New SqlCommand("spGetUserById", connection) With {.CommandType = CommandType.StoredProcedure}

            command.Parameters.AddWithValue("@id", UserId)

            Dim param1 As New SqlParameter("@fname", "") With {.Direction = ParameterDirection.Output, .Size = 50, .SqlDbType = SqlDbType.VarChar}
            command.Parameters.Add(param1)

            Dim param2 As New SqlParameter("@lname", "") With {.Direction = ParameterDirection.Output, .Size = 50, .SqlDbType = SqlDbType.VarChar}
            command.Parameters.Add(param2)

            command.ExecuteNonQuery()

            fName = param1.SqlValue.ToString
            lName = param2.SqlValue.ToString

        Catch ex As Exception
            'm_NewValue = "error..."
            MsgBox(ex.Message)
        Finally
            connection.Close()
            connection.Dispose()
        End Try


    End Sub


    Public Shared Sub GetSalesmanNameById(ByVal SalesmanId As Integer, ByRef fName As String, ByRef lName As String)

        Dim conString As String = GetConnectionString()
        Dim connection As SqlConnection = New SqlConnection(conString)
        connection.Open()
        Try
            Dim command As SqlCommand = New SqlCommand("spGetSalesmanById", connection) With {.CommandType = CommandType.StoredProcedure}

            command.Parameters.AddWithValue("@id", SalesmanId)

            Dim param1 As New SqlParameter("@fname", "") With {.Direction = ParameterDirection.Output, .Size = 50, .SqlDbType = SqlDbType.VarChar}
            command.Parameters.Add(param1)

            Dim param2 As New SqlParameter("@lname", "") With {.Direction = ParameterDirection.Output, .Size = 50, .SqlDbType = SqlDbType.VarChar}
            command.Parameters.Add(param2)

            command.ExecuteNonQuery()

            fName = param1.SqlValue.ToString
            lName = param2.SqlValue.ToString

        Catch ex As Exception
            'm_NewValue = "error..."
            MsgBox(ex.Message)
        Finally
            connection.Close()
            connection.Dispose()
        End Try


    End Sub

    Public Shared Sub GetSalesmanOfProposal(ByVal ProposalId As Integer, ByRef salesmanId1 As Integer, ByRef salesmanId2 As Integer, ByRef salesmanId3 As Integer)

        Dim conString As String = GetConnectionString()
        Dim connection As SqlConnection = New SqlConnection(conString)
        connection.Open()
        Try
            Dim command As SqlCommand = New SqlCommand("spGetSalesmanOfProposalId", connection) With {.CommandType = CommandType.StoredProcedure}

            command.Parameters.AddWithValue("@Proposalid", ProposalId)

            Dim param1 As New SqlParameter("@salesmanId1", "") With {.Direction = ParameterDirection.Output, .SqlDbType = SqlDbType.Int}
            command.Parameters.Add(param1)

            Dim param2 As New SqlParameter("@salesmanId2", "") With {.Direction = ParameterDirection.Output, .SqlDbType = SqlDbType.Int}
            command.Parameters.Add(param2)

            Dim param3 As New SqlParameter("@salesmanId3", "") With {.Direction = ParameterDirection.Output, .SqlDbType = SqlDbType.Int}
            command.Parameters.Add(param3)

            command.ExecuteNonQuery()

            salesmanId1 = param1.SqlValue.ToString
            salesmanId2 = param2.SqlValue.ToString
            salesmanId3 = param3.SqlValue.ToString

        Catch ex As Exception
            'm_NewValue = "error..."
            'MsgBox(ex.Message)
        Finally
            connection.Close()
            connection.Dispose()
        End Try
    End Sub


    Public Shared Sub GetSBSCOMPANYOfProposal(ByVal ProposalId As Integer, ByRef sbs As String)

        Dim conString As String = GetConnectionString()
        Dim connection As SqlConnection = New SqlConnection(conString)
        connection.Open()
        Try
            Dim command As SqlCommand = New SqlCommand("spGetSBSOfProposalId", connection) With {.CommandType = CommandType.StoredProcedure}

            command.Parameters.AddWithValue("@Proposalid", ProposalId)

            Dim param1 As New SqlParameter("@sbs", "") With {.Direction = ParameterDirection.Output, .SqlDbType = SqlDbType.Int}
            command.Parameters.Add(param1)

            command.ExecuteNonQuery()

            sbs = param1.SqlValue

        Catch ex As Exception
            'm_NewValue = "error..."
            'MsgBox(ex.Message)
        Finally
            connection.Close()
            connection.Dispose()
        End Try
    End Sub

    Public Shared Sub GetCustomerNameById(ByVal CustomerId As Integer, ByRef CustomerName As String)

        Dim conString As String = GetConnectionString()
        Dim connection As SqlConnection = New SqlConnection(conString)
        connection.Open()
        Try
            Dim command As SqlCommand = New SqlCommand("spGetCustomerById", connection) With {.CommandType = CommandType.StoredProcedure}

            command.Parameters.AddWithValue("@id", CustomerId)

            Dim param1 As New SqlParameter("@name", "") With {.Direction = ParameterDirection.Output, .Size = 150, .SqlDbType = SqlDbType.VarChar}
            command.Parameters.Add(param1)

            command.ExecuteNonQuery()

            CustomerName = param1.SqlValue.ToString

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.Close()
            connection.Dispose()
        End Try


    End Sub


    Public Shared Sub GetCustomers(ByVal CustomerId As Integer, ByRef CustomerName As String)

        Dim conString As String = GetConnectionString()
        Dim connection As SqlConnection = New SqlConnection(conString)
        connection.Open()
        Try
            Dim command As SqlCommand = New SqlCommand("spGetCustomerById", connection) With {.CommandType = CommandType.StoredProcedure}

            command.Parameters.AddWithValue("@id", CustomerId)

            Dim param1 As New SqlParameter("@name", "") With {.Direction = ParameterDirection.Output, .Size = 150, .SqlDbType = SqlDbType.VarChar}
            command.Parameters.Add(param1)

            command.ExecuteNonQuery()

            CustomerName = param1.SqlValue.ToString

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.Close()
            connection.Dispose()
        End Try


    End Sub


    Public Shared Sub GetCustomerOfProposal(ByVal ProposalId As Integer, ByRef customerId1 As Integer, ByRef customerId2 As Integer, ByRef customerId3 As Integer)

        Dim conString As String = GetConnectionString()
        Dim connection As SqlConnection = New SqlConnection(conString)
        connection.Open()
        Try
            Dim command As SqlCommand = New SqlCommand("spGetCustomerOfProposalId", connection) With {.CommandType = CommandType.StoredProcedure}

            command.Parameters.AddWithValue("@Proposalid", ProposalId)

            Dim param1 As New SqlParameter("@customerId1", "") With {.Direction = ParameterDirection.Output, .SqlDbType = SqlDbType.Int}
            command.Parameters.Add(param1)

            Dim param2 As New SqlParameter("@customerId2", "") With {.Direction = ParameterDirection.Output, .SqlDbType = SqlDbType.Int}
            command.Parameters.Add(param2)

            Dim param3 As New SqlParameter("@customerId3", "") With {.Direction = ParameterDirection.Output, .SqlDbType = SqlDbType.Int}
            command.Parameters.Add(param3)

            command.ExecuteNonQuery()

            ' Assign slot 1/2/3 correctly (was writing param2 into customerId3, dropping customer #2).
            If param1.Value IsNot Nothing AndAlso param1.Value IsNot DBNull.Value Then customerId1 = CInt(param1.Value)
            If param2.Value IsNot Nothing AndAlso param2.Value IsNot DBNull.Value Then customerId2 = CInt(param2.Value)
            If param3.Value IsNot Nothing AndAlso param3.Value IsNot DBNull.Value Then customerId3 = CInt(param3.Value)

        Catch ex As Exception
            'm_NewValue = "error..."
            'MsgBox(ex.Message)
        Finally
            connection.Close()
            connection.Dispose()
        End Try
    End Sub



    Public Shared Sub GetContactNameById(ByVal ContactId As Integer, ByRef fName As String, ByRef lName As String)

        Dim conString As String = GetConnectionString()
        Dim connection As SqlConnection = New SqlConnection(conString)
        connection.Open()
        Try
            Dim command As SqlCommand = New SqlCommand("spGetContactById", connection) With {.CommandType = CommandType.StoredProcedure}

            command.Parameters.AddWithValue("@id", ContactId)

            Dim param1 As New SqlParameter("@fname", "") With {.Direction = ParameterDirection.Output, .Size = 50, .SqlDbType = SqlDbType.VarChar}
            command.Parameters.Add(param1)

            Dim param2 As New SqlParameter("@lname", "") With {.Direction = ParameterDirection.Output, .Size = 50, .SqlDbType = SqlDbType.VarChar}
            command.Parameters.Add(param2)

            command.ExecuteNonQuery()

            If param1.SqlValue.ToString <> "Null" Then fName = param1.SqlValue.ToString
            If param2.SqlValue.ToString <> "Null" Then lName = param2.SqlValue.ToString

        Catch ex As Exception
            'm_NewValue = "error..."
            'MsgBox(ex.Message)
        Finally
            connection.Close()
            connection.Dispose()
        End Try


    End Sub

    Public Shared Sub GetContactOfProposal(ByVal ProposalId As Integer, ByRef contactId1 As Integer, ByRef contactId2 As Integer, ByRef contactId3 As Integer)

        Dim conString As String = GetConnectionString()
        Dim connection As SqlConnection = New SqlConnection(conString)
        connection.Open()
        Try
            Dim command As SqlCommand = New SqlCommand("spGetContactOfProposalId", connection) With {.CommandType = CommandType.StoredProcedure}

            command.Parameters.AddWithValue("@Proposalid", ProposalId)

            Dim param1 As New SqlParameter("@contactId1", "") With {.Direction = ParameterDirection.Output, .SqlDbType = SqlDbType.Int}
            command.Parameters.Add(param1)

            Dim param2 As New SqlParameter("@contactId2", "") With {.Direction = ParameterDirection.Output, .SqlDbType = SqlDbType.Int}
            command.Parameters.Add(param2)

            Dim param3 As New SqlParameter("@contactId3", "") With {.Direction = ParameterDirection.Output, .SqlDbType = SqlDbType.Int}
            command.Parameters.Add(param3)

            command.ExecuteNonQuery()

            If param1.SqlValue IsNot Nothing Then contactId1 = param1.SqlValue.ToString
            If param2.SqlValue IsNot Nothing Then contactId2 = param2.SqlValue.ToString
            If param3.SqlValue IsNot Nothing Then contactId3 = param3.SqlValue.ToString

        Catch ex As Exception
            'MsgBox(ex.Message)
        Finally
            connection.Close()
            connection.Dispose()
        End Try
    End Sub



    Public Shared Sub GetVendorNameById(ByVal VendorId As Integer, ByRef VendorName As String)

        Dim conString As String = GetConnectionString()
        Dim connection As SqlConnection = New SqlConnection(conString)
        connection.Open()
        Try
            Dim command As SqlCommand = New SqlCommand("spGetVendorById", connection) With {.CommandType = CommandType.StoredProcedure}

            command.Parameters.AddWithValue("@id", VendorId)

            Dim param1 As New SqlParameter("@name", "") With {.Direction = ParameterDirection.Output, .Size = 50, .SqlDbType = SqlDbType.VarChar}
            command.Parameters.Add(param1)

            command.ExecuteNonQuery()

            VendorName = param1.SqlValue.ToString

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.Close()
            connection.Dispose()
        End Try


    End Sub

    Public Shared Sub GetVendorOfProposal(ByVal ProposalId As Integer, ByRef VendorId1 As Integer, ByRef VendorId2 As Integer, ByRef VendorId3 As Integer)

        Dim conString As String = GetConnectionString()
        Dim connection As SqlConnection = New SqlConnection(conString)
        connection.Open()
        Try
            Dim command As SqlCommand = New SqlCommand("spGetVendorOfProposalId", connection) With {.CommandType = CommandType.StoredProcedure}

            command.Parameters.AddWithValue("@Proposalid", ProposalId)

            Dim param1 As New SqlParameter("@VendorId1", "") With {.Direction = ParameterDirection.Output, .SqlDbType = SqlDbType.Int}
            command.Parameters.Add(param1)

            Dim param2 As New SqlParameter("@VendorId2", "") With {.Direction = ParameterDirection.Output, .SqlDbType = SqlDbType.Int}
            command.Parameters.Add(param2)

            Dim param3 As New SqlParameter("@VendorId3", "") With {.Direction = ParameterDirection.Output, .SqlDbType = SqlDbType.Int}
            command.Parameters.Add(param3)

            command.ExecuteNonQuery()

            VendorId1 = param1.SqlValue.ToString
            VendorId2 = param2.SqlValue.ToString
            VendorId3 = param3.SqlValue.ToString

        Catch ex As Exception
            'MsgBox(ex.Message)
        Finally
            connection.Close()
            connection.Dispose()
        End Try
    End Sub



    Public Shared Sub GetSuperNameById(ByVal SuperId As Integer, ByRef fName As String, ByRef lName As String)

        Dim conString As String = GetConnectionString()
        Dim connection As SqlConnection = New SqlConnection(conString)
        connection.Open()
        Try
            Dim command As SqlCommand = New SqlCommand("spGetSuperById", connection) With {.CommandType = CommandType.StoredProcedure}

            command.Parameters.AddWithValue("@id", SuperId)

            Dim param1 As New SqlParameter("@fname", "") With {.Direction = ParameterDirection.Output, .Size = 50, .SqlDbType = SqlDbType.VarChar}
            command.Parameters.Add(param1)

            Dim param2 As New SqlParameter("@lname", "") With {.Direction = ParameterDirection.Output, .Size = 50, .SqlDbType = SqlDbType.VarChar}
            command.Parameters.Add(param2)

            command.ExecuteNonQuery()

            fName = param1.SqlValue.ToString
            lName = param2.SqlValue.ToString

        Catch ex As Exception
            'm_NewValue = "error..."
            MsgBox(ex.Message)
        Finally
            connection.Close()
            connection.Dispose()
        End Try


    End Sub

    Public Shared Sub GetSuperOfProposal(ByVal ProposalId As Integer, ByRef SuperId1 As Integer, ByRef SuperId2 As Integer, ByRef SuperId3 As Integer)

        Dim conString As String = GetConnectionString()
        Dim connection As SqlConnection = New SqlConnection(conString)
        connection.Open()
        Try
            Dim command As SqlCommand = New SqlCommand("spGetSuperOfProposalId", connection) With {.CommandType = CommandType.StoredProcedure}

            command.Parameters.AddWithValue("@Proposalid", ProposalId)

            Dim param1 As New SqlParameter("@SuperId1", "") With {.Direction = ParameterDirection.Output, .SqlDbType = SqlDbType.Int}
            command.Parameters.Add(param1)

            Dim param2 As New SqlParameter("@SuperId2", "") With {.Direction = ParameterDirection.Output, .SqlDbType = SqlDbType.Int}
            command.Parameters.Add(param2)

            Dim param3 As New SqlParameter("@SuperId3", "") With {.Direction = ParameterDirection.Output, .SqlDbType = SqlDbType.Int}
            command.Parameters.Add(param3)

            command.ExecuteNonQuery()

            SuperId1 = param1.SqlValue.ToString
            SuperId2 = param2.SqlValue.ToString
            SuperId3 = param3.SqlValue.ToString

        Catch ex As Exception
            'MsgBox(ex.Message)
        Finally
            connection.Close()
            connection.Dispose()
        End Try
    End Sub



    Public Shared Sub GetJobTypeNameById(ByVal JobTypeId As Integer, ByRef name As String)

        Dim conString As String = GetConnectionString()
        Dim connection As SqlConnection = New SqlConnection(conString)
        connection.Open()
        Try
            Dim command As SqlCommand = New SqlCommand("spGetJobNameById", connection) With {.CommandType = CommandType.StoredProcedure}

            command.Parameters.AddWithValue("@id", JobTypeId)

            Dim param1 As New SqlParameter("@name", "") With {.Direction = ParameterDirection.Output, .Size = 50, .SqlDbType = SqlDbType.VarChar}
            command.Parameters.Add(param1)

            command.ExecuteNonQuery()

            Name = param1.SqlValue.ToString

        Catch ex As Exception
            'm_NewValue = "error..."
            MsgBox(ex.Message)
        Finally
            connection.Close()
            connection.Dispose()
        End Try


    End Sub

    Public Shared Sub GetJobTypeOfProposal(ByVal ProposalId As Integer, ByRef JobTypeId1 As Integer, ByRef JobTypeId2 As Integer, ByRef JobTypeId3 As Integer)

        Dim conString As String = GetConnectionString()
        Dim connection As SqlConnection = New SqlConnection(conString)
        connection.Open()
        Try
            Dim command As SqlCommand = New SqlCommand("spGetJobTypeOfProposalId", connection) With {.CommandType = CommandType.StoredProcedure}

            command.Parameters.AddWithValue("@Proposalid", ProposalId)

            Dim param1 As New SqlParameter("@JobTypeId1", "") With {.Direction = ParameterDirection.Output, .SqlDbType = SqlDbType.Int}
            command.Parameters.Add(param1)

            Dim param2 As New SqlParameter("@JobTypeId2", "") With {.Direction = ParameterDirection.Output, .SqlDbType = SqlDbType.Int}
            command.Parameters.Add(param2)

            Dim param3 As New SqlParameter("@JobTypeId3", "") With {.Direction = ParameterDirection.Output, .SqlDbType = SqlDbType.Int}
            command.Parameters.Add(param3)

            command.ExecuteNonQuery()

            JobTypeId1 = param1.SqlValue.ToString
            JobTypeId2 = param2.SqlValue.ToString
            JobTypeId3 = param3.SqlValue.ToString

        Catch ex As Exception
            'MsgBox(ex.Message)
        Finally
            connection.Close()
            connection.Dispose()
        End Try
    End Sub

    Public Shared Sub GetGroupOfCustomer(ByVal CustomerId As Integer, ByRef GroupId1 As Integer, ByRef GroupId2 As Integer, ByRef GroupId3 As Integer)

        Dim conString As String = GetConnectionString()
        Dim connection As SqlConnection = New SqlConnection(conString)
        connection.Open()
        Try
            Dim command As SqlCommand = New SqlCommand("spGetGroupOfCustomerId", connection) With {.CommandType = CommandType.StoredProcedure}

            command.Parameters.AddWithValue("@customerId", CustomerId)

            Dim param1 As New SqlParameter("@GroupId1", "") With {.Direction = ParameterDirection.Output, .SqlDbType = SqlDbType.Int}
            command.Parameters.Add(param1)

            Dim param2 As New SqlParameter("@GroupId2", "") With {.Direction = ParameterDirection.Output, .SqlDbType = SqlDbType.Int}
            command.Parameters.Add(param2)

            Dim param3 As New SqlParameter("@GroupId3", "") With {.Direction = ParameterDirection.Output, .SqlDbType = SqlDbType.Int}
            command.Parameters.Add(param3)

            command.ExecuteNonQuery()

            GroupId1 = param1.SqlValue.ToString
            GroupId2 = param2.SqlValue.ToString
            GroupId3 = param3.SqlValue.ToString

        Catch ex As Exception
            'MsgBox(ex.Message)
        Finally
            connection.Close()
            connection.Dispose()
        End Try
    End Sub


    Public Shared Function GetTextStringFromIDs(ByVal nDataType As Integer, ByVal ProposalID As Integer, ByVal IDString As String) As String
        ' Salesman
        Dim TextID1 As Integer
        Dim TextID2 As Integer
        Dim TextID3 As Integer

        Dim TextString1 As String = ""
        Dim TextString2 As String = ""
        Dim TextString3 As String = ""


        If IDString Is Nothing Then
            Select Case nDataType
                Case DataType.Salesman
                    Utils.GetSalesmanOfProposal(ProposalID, TextID1, TextID2, TextID3)
                Case DataType.Customer
                    Utils.GetCustomerOfProposal(ProposalID, TextID1, TextID2, TextID3)
                Case DataType.Contact
                    Utils.GetContactOfProposal(ProposalID, TextID1, TextID2, TextID3)
                Case DataType.JobType
                    Utils.GetJobTypeOfProposal(ProposalID, TextID1, TextID2, TextID3)
                Case DataType.Super
                    Utils.GetSuperOfProposal(ProposalID, TextID1, TextID2, TextID3)
                Case DataType.Vendor
                    Utils.GetVendorOfProposal(ProposalID, TextID1, TextID2, TextID3)
                Case Else
                    MsgBox("Invalid")

            End Select

        Else
            Dim IdArray() As String = IDString.Split(",")
            TextID1 = IdArray(0)
            TextID2 = IdArray(1)
            TextID3 = IdArray(2)
        End If

        Dim fname As String = "" : Dim lname As String = ""
        Select Case nDataType
            Case DataType.Salesman
                Utils.GetSalesmanNameById(TextID1, fname, lname)
                TextString1 = String.Format("{0} {1}", fname, lname)

                Utils.GetSalesmanNameById(TextID2, fname, lname)
                TextString2 = String.Format("{0} {1}", fname, lname)

                Utils.GetSalesmanNameById(TextID3, fname, lname)
                TextString3 = String.Format("{0} {1}", fname, lname)
            Case DataType.Customer
                Utils.GetCustomerNameById(TextID1, fname)
                TextString1 = String.Format("{0}", fname)

                Utils.GetCustomerNameById(TextID2, fname)
                TextString2 = String.Format("{0}", fname)

                Utils.GetCustomerNameById(TextID3, fname)
                TextString3 = String.Format("{0}", fname)
            Case DataType.Contact
                Utils.GetContactNameById(TextID1, fname, lname)
                TextString1 = String.Format("{0} {1}", fname, lname)

                Utils.GetContactNameById(TextID2, fname, lname)
                TextString2 = String.Format("{0} {1}", fname, lname)

                Utils.GetContactNameById(TextID3, fname, lname)
                TextString3 = String.Format("{0} {1}", fname, lname)
            Case DataType.JobType
                Utils.GetJobTypeNameById(TextID1, fname)
                TextString1 = String.Format("{0}", fname)

                Utils.GetJobTypeNameById(TextID2, fname)
                TextString2 = String.Format("{0}", fname)

                Utils.GetJobTypeNameById(TextID3, fname)
                TextString3 = String.Format("{0}", fname)
            Case DataType.Super
                Utils.GetSuperNameById(TextID1, fname, lname)
                TextString1 = String.Format("{0} {1}", fname, lname)

                Utils.GetSuperNameById(TextID2, fname, lname)
                TextString2 = String.Format("{0} {1}", fname, lname)

                Utils.GetSuperNameById(TextID3, fname, lname)
                TextString3 = String.Format("{0} {1}", fname, lname)
            Case DataType.Vendor
                Utils.GetVendorNameById(TextID1, fname)
                TextString1 = String.Format("{0}", fname)

                Utils.GetVendorNameById(TextID2, fname)
                TextString2 = String.Format("{0}", fname)

                Utils.GetVendorNameById(TextID3, fname)
                TextString3 = String.Format("{0}", fname)
            Case Else
                MsgBox("Invalid")

        End Select


        Dim sConcatinatedString As String
        If Not String.IsNullOrEmpty(TextString1) Then
            sConcatinatedString = TextString1
        Else
            sConcatinatedString = ""
        End If
        If Not String.IsNullOrEmpty(TextString2) Then
            sConcatinatedString = String.Format("{0}, {1}", sConcatinatedString, TextString2)
        End If
        If Not String.IsNullOrEmpty(TextString3) Then
            sConcatinatedString = String.Format("{0}, {1}", sConcatinatedString, TextString3)
        End If
        Return sConcatinatedString
    End Function

End Class
