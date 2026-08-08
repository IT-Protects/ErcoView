Public Class frmUser 
    Public Event eClickSave()
    Public Event eClickUndo()
    Public Event eClickClose()
    Public Event eClickChangePassword()

    Private Sub btnChangePassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RaiseEvent eClickChangePassword()
    End Sub

    Private Sub btnSaveUser_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSaveUser.ItemClick
        RaiseEvent eClickSave()
    End Sub

    Private Sub btnExitUser_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExitUser.ItemClick
        Close()
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