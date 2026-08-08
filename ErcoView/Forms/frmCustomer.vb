Public Class frmCustomer 
    Public Event eSaveCustomer()
    Public Event eUndoCustomer()
    Public Event eCloseCustomer()
    Public Event eAddGroup()


    Private Sub frmCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SpGetGroupsTableAdapter.Connection = New SqlClient.SqlConnection(GetConnectionString())
        SpGetGroupsTableAdapter.Fill(Me.DsErcoView.spGetGroups)
    End Sub

    Private Sub btnSave_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        RaiseEvent eSaveCustomer()
    End Sub

    Private Sub btnExit_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExit.ItemClick
        Close()
    End Sub

    Private Sub txtGroups_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtGroups.ButtonClick
        RaiseEvent eAddGroup()
    End Sub

    Private Sub txtGroups_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtGroups.Click
        RaiseEvent eAddGroup()
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