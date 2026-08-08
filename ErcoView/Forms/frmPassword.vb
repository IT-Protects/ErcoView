Public Class frmPassword 
    Public newPassword As String
    Public isNew As Boolean

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If txtNewPassword.Text <> txtConfirmPassword.Text Then
            MsgBox("Passwords do not match.", vbOKOnly + vbExclamation, "ErcoView")
            Exit Sub
        End If

        newPassword = txtNewPassword.Text
        isNew = True
        Close()
    End Sub


    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Close()
    End Sub
End Class