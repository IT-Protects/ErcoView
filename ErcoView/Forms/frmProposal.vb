Imports DevExpress.XtraTreeList.Nodes
Imports DevExpress.XtraTreeList

Public Class frmProposal

    Public Event eUpdateProposal()
    Public Event eClickUndo()
    Public Event eRemoveCustomer()
    Public Event eViewMap()

    Public Event eClickAddJobType()
    Public Event eClickSBSCompany()
    Public Event eClickAddSalesman()
    Public Event eClickAddSuper()
    Public Event eClickAddVendor()
    Public Event eClickAddCustomer()
    Public Event eClickAddContact()

    Public Event eClickBrowse()
    Public Event eClickJobNumber()

    Public ProposalID As Integer


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If userPermission = 1 Then 'Admin

        ElseIf userPermission = 2 Then 'General

        ElseIf userPermission = 3 Then 'Superintendent
            grpJob.Enabled = False
            grpPricing.Visible = False
            grpProposal.Enabled = False
        Else
            Throw New Exception("Permission not valid")
        End If

    End Sub


    Private Sub btnUndo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RaiseEvent eClickUndo()
    End Sub

    Private Sub btnMap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RaiseEvent eViewMap()
    End Sub


    Private Sub txtGPSn_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtGPS_N.Validating
        If txtGPS_N.Text = "" Then
            txtGPS_N.BackColor = Color.Red
        Else
            txtGPS_N.BackColor = Color.White
        End If
    End Sub

    Private Sub btnSave_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick

        RaiseEvent eUpdateProposal()
    End Sub

    Private Sub txtJobTypes_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtJOB_TYPE.ButtonClick
        RaiseEvent eClickAddJobType()
    End Sub

    Private Sub txtSBSCompany_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtSBSCompany.ButtonClick
        RaiseEvent eClickSBSCompany()
    End Sub

    Private Sub txtSalesman_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtSALESMAN_TEXT.ButtonClick
        RaiseEvent eClickAddSalesman()
    End Sub

    Private Sub txtSuper_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtSUPER_TEXT.ButtonClick
        RaiseEvent eClickAddSuper()
    End Sub

    Private Sub txtVendors_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtVENDOR_TEXT.ButtonClick
        RaiseEvent eClickAddVendor()
    End Sub

    Private Sub txtJobNumber_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtJOB_NUMBER.ButtonClick
        RaiseEvent eClickJobNumber()
    End Sub

    Private Sub btnExit_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExit.ItemClick
        DialogResult = DialogResult.Cancel
        Close()
    End Sub

    Private Sub txtCustomer_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtCUSTOMER_TEXT.ButtonClick
        RaiseEvent eClickAddCustomer()
    End Sub

    Private Sub txtContact_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtCONTACT_TEXT.ButtonClick
        RaiseEvent eClickAddContact()
    End Sub

    Private Sub btnBrowse_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBrowse.ItemClick
        RaiseEvent eClickBrowse()
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

    Private Sub btnMap_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnMap.ItemClick
        ' txtPRIORITY.SelectedIndex = 2
        RaiseEvent eViewMap()
    End Sub


    Private Sub Contact_DoubleClick(sender As Object, e As EventArgs) Handles LabelControl47.DoubleClick
       
    End Sub


    Private Sub SimpleButton1_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton1.Click
        Dim oCustomerId1 As Integer = -1
        Dim oCustomerId2 As Integer = -1
        Dim oCustomerId3 As Integer = -1

        If txtCUSTOMER_TEXT.Tag Is Nothing Then
            Utils.GetCustomerOfProposal(ProposalID, oCustomerId1, oCustomerId2, oCustomerId3)
        Else
            Dim IdArray() As String = txtCUSTOMER_TEXT.Tag.ToString.Split(",")
            oCustomerId1 = IdArray(0)
            oCustomerId2 = IdArray(1)
            oCustomerId3 = IdArray(2)
        End If

        Dim customerName1 As String = String.Empty
        Utils.GetCustomerNameById(oCustomerId1, customerName1)
        Dim customerName2 As String = String.Empty
        Utils.GetCustomerNameById(oCustomerId2, customerName2)
        Dim customerName3 As String = String.Empty
        Utils.GetCustomerNameById(oCustomerId3, customerName3)

        Dim oSelectCustomerForm As New frmCustomerSelectForEdit(customerName1, customerName2, customerName3)
        ' oSelectCustomerForm.Parent = Me
        oSelectCustomerForm.ShowDialog()

        Dim _selectedCustomer As Integer = oSelectCustomerForm.selectedCustomer

        Dim oCustomerForm As New clsFrmCustomer()
        If (1 = _selectedCustomer) Then
            oCustomerForm.ID = oCustomerId1
            oCustomerForm.ShowForm()
        ElseIf (2 = _selectedCustomer) Then
            oCustomerForm.ID = oCustomerId2
            oCustomerForm.ShowForm()
        ElseIf (3 = _selectedCustomer) Then
            oCustomerForm.ID = oCustomerId3
            oCustomerForm.ShowForm()
        Else

        End If
    End Sub

    Private Sub SimpleButton2_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton2.Click
        'Dim myContact As New clsFrmContact() With {.ID = 0}
        'myContact.ShowForm()
        Dim oContact1 As Integer = -1
        Dim oContact2 As Integer = -1
        Dim oContact3 As Integer = -1

        If txtCONTACT_TEXT.Tag Is Nothing Then
            Utils.GetContactOfProposal(ProposalID, oContact1, oContact2, oContact3)
        Else
            Dim IdArray() As String = txtCONTACT_TEXT.Tag.ToString.Split(",")
            oContact1 = IdArray(0)
            oContact2 = IdArray(1)
            oContact3 = IdArray(2)
        End If

        Dim contactFName1 As String = String.Empty
        Dim contactLName1 As String = String.Empty

        Utils.GetContactNameById(oContact1, contactFName1, contactLName1)
        Dim contactFName2 As String = String.Empty
        Dim contactLName2 As String = String.Empty
        Utils.GetContactNameById(oContact2, contactFName2, contactLName2)
        Dim contactFName3 As String = String.Empty
        Dim contactLName3 As String = String.Empty
        Utils.GetContactNameById(oContact3, contactFName3, contactLName3)

        Dim oSelectcontactForm As New frmCustomerSelectForEdit(contactFName1 & " " & contactLName1, contactFName2 & " " & contactLName2, contactFName3 & " " & contactLName3)
        ' oSelectcontactForm.Parent = Me
        oSelectcontactForm.ShowDialog()

        Dim _selectedcontact As Integer = oSelectcontactForm.selectedCustomer

        Dim ocontactForm As New clsFrmContact()
        If (1 = _selectedcontact) Then
            If oContact1 = 1 Then
                oContact1 = 0
            End If
            ocontactForm.ID = oContact1
            ocontactForm.ShowForm()
        ElseIf (2 = _selectedcontact) Then
            If oContact2 = 1 Then
                oContact2 = 0
            End If
            ocontactForm.ID = oContact2
            ocontactForm.ShowForm()
        ElseIf (3 = _selectedcontact) Then
            If oContact3 = 1 Then
                oContact3 = 0
            End If

            ocontactForm.ID = oContact3
            ocontactForm.ShowForm()
        Else

        End If
    End Sub

End Class