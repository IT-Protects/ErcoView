Imports System.Data.SqlClient

Public Class clsLogon
    WithEvents oFrmLogon As New frmLogOn
    Public isValid As Boolean

    Dim settingFrm As New frmSettings


    Public Sub OpenLogOnForm()
        Dim myUserName As String = My.Settings.logonName

        If myUserName <> "" Then
            oFrmLogon.txtUserName.Text = myUserName
            oFrmLogon.txtPassword.Select()
        End If

        oFrmLogon.ShowDialog()

    End Sub

    Public Sub oFrmLogon_eClickLogOn() Handles oFrmLogon.eClickLogOn
        ValidateUser()
    End Sub

    Public Sub oFrmLogon_eClickCancel() Handles oFrmLogon.eClickCancel
        oFrmLogon.Close()
    End Sub

    Private Sub ValidateUser()
        currentErcoViewUserName = oFrmLogon.txtUserName.Text
        Dim myPassword As String = oFrmLogon.txtPassword.Text
        Dim myTestPassword As String = ""
        Dim userFound As Boolean = False

        ' cbDatabase items: 0=Training, 1=Live
        ' cbLocation items: 0=Local, 1=Remote
        ' (Previously compared cbDatabase.Text = "Local", which never matched — Local lives on cbLocation.)
        isDatabaseLive = (oFrmLogon.cbDatabase.SelectedIndex = 1)
        isLocalDatabase = (oFrmLogon.cbLocation.SelectedIndex = 0)

        Dim conString As String = GetConnectionString()
        Using connection As SqlConnection = New SqlConnection(conString)
            Try
                connection.Open()
                Dim command As SqlCommand = New SqlCommand("spLogin", connection) With {.CommandType = CommandType.StoredProcedure}
                command.Parameters.AddWithValue("@userName", currentErcoViewUserName)
                Dim dr As SqlDataReader = command.ExecuteReader()
                While dr.Read
                    currentErcoViewUserID = dr(0).ToString
                    currentErcoViewFullName = String.Format("{0} {1}", dr(2), dr(1))
                    myTestPassword = dr(4).ToString
                    userPermission = dr(6)
                    userFound = True
                End While
                dr.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            Finally
                connection.Close()
            End Try
        End Using

        If Not userFound Then
            MsgBox(currentErcoViewUserName + " is not a valid user.", MsgBoxStyle.OkOnly, "ErcoView")
            Exit Sub
        End If

        If myPassword <> myTestPassword Then
            MsgBox("The password you entered was incorrect.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "ErcoView")
            Exit Sub
        Else
            isValid = True
            If Not isDatabaseLive Then
                Using frmWelcomeTraining As New frmWelcomeTraining()
                    frmWelcomeTraining.ShowDialog()
                End Using
            End If
           
        End If
        SaveSettings()
        oFrmLogon.Close()
    End Sub

    Private Sub SaveSettings()
        My.Settings.logonName = oFrmLogon.txtUserName.Text
        My.Settings.Live = oFrmLogon.cbDatabase.SelectedIndex
        My.Settings.Remote = oFrmLogon.cbLocation.SelectedIndex
        My.Settings.Save()
    End Sub

    Public Sub oFrmLogon_eClickSettings() Handles oFrmLogon.eClickSettings

        settingFrm.ShowDialog()


    End Sub
End Class
