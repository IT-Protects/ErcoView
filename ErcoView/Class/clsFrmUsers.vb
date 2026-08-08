Imports System.Data.SqlClient

Public Class clsFrmUsers
    Inherits clsBase

    Public WithEvents myFrmUsers As New frmUser
    Private lastName As String
    Private firstName As String
    Private userName As String
    Private password As String
    Private email As String
    Private permissionID As Integer
    Private salesman As Boolean
    Private super As Boolean
    Private activeStatus As String


    Public Sub myFrmUsers_eClickChangePassword() Handles myFrmUsers.eClickChangePassword
        Dim myFrmPassword As New frmPassword
        myFrmPassword.ShowDialog()

        If myFrmPassword.isNew Then
            myFrmUsers.txtPassword.Text = myFrmPassword.newPassword
        End If

        myFrmPassword.Dispose()
    End Sub

    Public Overrides Sub InsertRow()
        Dim conString As String = GetConnectionString()
        Using connection As SqlConnection = New SqlConnection(conString)
            connection.Open()
            Try
                Dim command As SqlCommand = New SqlCommand("spInsertUser", connection) With {.CommandType = CommandType.StoredProcedure}
                command.Parameters.AddWithValue("@userID", ID)
                command.Parameters.AddWithValue("@lastName", lastName)
                command.Parameters.AddWithValue("@firstName", firstName)
                command.Parameters.AddWithValue("@userName", userName)
                command.Parameters.AddWithValue("@password", password)
                command.Parameters.AddWithValue("@email", email)
                command.Parameters.AddWithValue("@permissionID", permissionID)
                command.Parameters.AddWithValue("@salesman", salesman)
                command.Parameters.AddWithValue("@super", super)
                command.Parameters.AddWithValue("@active", activeStatus)
                command.ExecuteNonQuery()
                MsgBox("User created sucessfully!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "ErcoView")
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                connection.Close()
            End Try
        End Using
    End Sub

    Public Overrides Sub SaveEvent()
        Dim msgResponse As Integer = MsgBox("Are you sure you want to save changes to this user?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ErcoView")
        If msgResponse <> 6 Then
            Exit Sub
        End If
        If False = SetValues() Then
            Exit Sub
        End If

        If ID <> 0 Then
            UpdateRow()
        Else
            InsertRow()
        End If

        didUpdate = True
        myFrmUsers.Close()
    End Sub

    Public Overrides Function SetValues() As Boolean
        Try
            lastName = myFrmUsers.txtLastName.Text
            firstName = myFrmUsers.txtFirstName.Text
            userName = myFrmUsers.txtUserName.Text
            password = myFrmUsers.txtPassword.Text
            email = myFrmUsers.txtEmail.Text
            permissionID = myFrmUsers.cmboPermissions.SelectedIndex + 1
            salesman = myFrmUsers.chkSalesman.Checked
            super = myFrmUsers.chkSuper.Checked
            activeStatus = myFrmUsers.txtActiveStatus.Text

            ' Validation
            If False = ValidateUserlData() Then
                Return False
            End If

            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function


    Public Function ValidateUserlData() As Boolean
        Dim sErrorMessage As String = "Missing fields: " & vbCrLf
        If String.IsNullOrEmpty(lastName) Then sErrorMessage += " * Last name " & vbCrLf
        If String.IsNullOrEmpty(firstName) Then sErrorMessage += " * First name " & vbCrLf
        If String.IsNullOrEmpty(userName) Then sErrorMessage += " * UserName " & vbCrLf
        If String.IsNullOrEmpty(password) Then sErrorMessage += " * Password " & vbCrLf
        If String.IsNullOrEmpty(email) Then sErrorMessage += " * Email " & vbCrLf
        If String.IsNullOrEmpty(permissionID) Then sErrorMessage += " * Permission " & vbCrLf

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
        myFrmUsers.SpGetUsersTableAdapter.Connection = New SqlConnection(oConnString)
        myFrmUsers.SpGetPermissionsTableAdapter.Connection = New SqlConnection(oConnString)

        If ID <> 0 Then
            myFrmUsers.SpGetUsersTableAdapter.Fill(myFrmUsers.DsErcoView1.spGetUsers, ID)
            myFrmUsers.SpGetPermissionsTableAdapter.Fill(myFrmUsers.DsErcoView1.spGetPermissions)
        End If
        myFrmUsers.ShowDialog()

    End Sub

    Public Overrides Sub UpdateRow()
        Dim conString As String = GetConnectionString()
        Using connection As SqlConnection = New SqlConnection(conString)
            connection.Open()
            Try
                Dim command As SqlCommand = New SqlCommand("spUpdateUser", connection) With {.CommandType = CommandType.StoredProcedure}
                command.Parameters.AddWithValue("@userID", ID)
                command.Parameters.AddWithValue("@lastName", lastName)
                command.Parameters.AddWithValue("@firstName", firstName)
                command.Parameters.AddWithValue("@userName", userName)
                command.Parameters.AddWithValue("@password", password)
                command.Parameters.AddWithValue("@email", email)
                command.Parameters.AddWithValue("@permissionID", permissionID)
                command.Parameters.AddWithValue("@salesman", salesman)
                command.Parameters.AddWithValue("@super", super)
                command.Parameters.AddWithValue("@active", activeStatus)
                command.ExecuteNonQuery()
                MsgBox("User updated sucessfully!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "ErcoView")
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                connection.Close()
            End Try
        End Using
    End Sub


    Private Sub myFrmUsers_eClickSave() Handles myFrmUsers.eClickSave
        SaveEvent()
    End Sub
End Class
