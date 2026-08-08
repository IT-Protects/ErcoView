Public Class frmLogOn 
    Public Event eClickLogOn()
    Public Event eClickCancel()
    Public Event eClickSettings()

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        cbDatabase.SelectedIndex = Int(My.Settings.Live)
        cbLocation.SelectedIndex = Int(My.Settings.Remote)
    End Sub

    Private Sub btnLogOn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogOn.Click
        RaiseEvent eClickLogOn()
    End Sub

    Private Sub btnSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RaiseEvent eClickSettings()
    End Sub

    Private Sub btnSettings_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSettings.Click
        RaiseEvent eClickSettings()
    End Sub

End Class