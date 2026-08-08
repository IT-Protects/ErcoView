Imports System.Data.SqlClient

Public Class frmSettings

    Private Sub frmSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetCurrentSettings()

        ' Add any initialization after the InitializeComponent() call.
        If userPermission = 1 Then 'Admin
            txtLayoutFolderServer.Visible = True
        ElseIf userPermission = 2 Then 'General
            txtLayoutFolderServer.Visible = True
        ElseIf userPermission = 3 Then 'Superintendent
            txtLayoutFolderServer.Visible = False
        Else
            'MessageBox.Show("Invalid permission")
        End If
    End Sub

    Private Sub GetCurrentSettings()
        txtProposalFolder.Text = My.Settings.browseFolder
        txtLayoutFolderLocal.Text = My.Settings.layoutPathLocal
        txtLayoutFolderServer.Text = My.Settings.layoutPathServer
        txtExternalIP.Text = My.Settings.remoteIP.ToString
        txtInternalIP.Text = My.Settings.localIP.ToString
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        My.Settings.browseFolder = txtProposalFolder.Text
        My.Settings.layoutPathLocal = txtLayoutFolderLocal.Text
        My.Settings.layoutPathServer = txtLayoutFolderServer.Text
        My.Settings.remoteIP = txtExternalIP.Text
        My.Settings.localIP = txtInternalIP.Text
        My.Settings.Save()
        MsgBox("Your settings have been saved.", vbOKOnly + vbInformation, "ErcoView")
        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub

    Private Sub btnPassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPassword.Click
        Dim myPassword As New frmPassword
        myPassword.ShowDialog()
        If myPassword.isNew Then
            UpdatePassword(myPassword.newPassword)
        End If
        myPassword.Dispose()
    End Sub

    Private Sub UpdatePassword(ByVal pWord As String)
        Dim conString As String = GetConnectionString()
        Using connection As SqlConnection = New SqlConnection(conString)
            connection.Open()
            Try
                Dim command As SqlCommand = New SqlCommand("spUpdatePassword", connection) With {.CommandType = CommandType.StoredProcedure}
                command.Parameters.AddWithValue("@userID", currentErcoViewUserID)
                command.Parameters.AddWithValue("@password", pWord)
                command.ExecuteNonQuery()
                MsgBox("Password updated sucessfully!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "ErcoView")
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                connection.Close()
            End Try
        End Using

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
                    DialogResult = DialogResult.Cancel
                    Close()
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


End Class