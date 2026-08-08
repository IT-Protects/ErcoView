Public Class frmContact
    Public Event eSaveContact()
    Public Event eUndoContact()
    Public Event eCloseContact()

    Private Class clsCustomer
        Private m_id As Integer
        Private m_name As String

        Public Sub New(ByVal id As Integer, ByVal name As String)
            m_id = id
            m_name = name
        End Sub

        Public Function Name() As String
            Return String.Format("{0}", m_name)
        End Function

        Public Function Id() As String
            Return String.Format("{0}", m_id)
        End Function

        Public Overrides Function ToString() As String
            Return m_name
        End Function
    End Class

    Private Sub frmContact_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtCustomerName.Properties.Items.Clear()
        SpGetCustomersTableAdapter.Connection = New SqlClient.SqlConnection(GetConnectionString())
        Try
            SpGetCustomersTableAdapter.Fill(DsErcoView.spGetCustomers)
            For Each oRow As DataRow In DsErcoView.spGetCustomers.Rows
                txtCustomerName.Properties.Items.Add(New clsCustomer(DirectCast(oRow, ErcoView.dsErcoView.spGetCustomersRow).CUSTOMER_ID(), DirectCast(oRow, ErcoView.dsErcoView.spGetCustomersRow).CUSTOMER_NAME))
            Next


            For Each oRow As DataRow In DsErcoView.spGetCustomers.Rows
                If txtCustomerName.EditValue = oRow.Item("CUSTOMER_NAME") Then
                    txtCustomerName.EditValue = New clsCustomer(DirectCast(oRow, ErcoView.dsErcoView.spGetCustomersRow).CUSTOMER_ID(), DirectCast(oRow, ErcoView.dsErcoView.spGetCustomersRow).CUSTOMER_NAME)
                    Exit For
                End If
            Next

        Catch ex As Exception

        End Try


    End Sub

    Private Sub btnSave_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        RaiseEvent eSaveContact()
    End Sub

    Private Sub btnExit_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExit.ItemClick
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