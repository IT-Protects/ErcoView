Imports System.IO

Public Class frmBrowse
    Public JobPath As String = ""
    Public JobTitle As String = ""
    Dim RootLoaded As Boolean = False

    Private _currentlySelectedNode As DevExpress.XtraTreeList.Nodes.TreeListNode
    Public Property LastFolderLoation() As String

    Private Sub Form1_Load(ByVal sender As System.Object, _
    ByVal e As System.EventArgs) Handles MyBase.Load

        TreeList1.DataSource = New Object()
        TreeListColumn1.Caption = JobTitle

        ' Following code is to open the node that was open last time, but it does not work...
        If LastFolderLoation.Length <= My.Settings.browseFolder.Length Then

        Else
            Dim op As New TreeListOperationFindNodeByText(TreeListColumn1, "<node name>")
            TreeList1.NodesIterator.DoOperation(op)
            If Not op.Node Is Nothing Then
                TreeList1.FocusedNode = op.Node
            End If
        End If

    End Sub

    Shared Function IsFile(ByVal info As DirectoryInfo) As Boolean
        Return (info.Attributes And FileAttributes.Directory) = 0
    End Function

    Private Sub TreeList1_VirtualTreeGetCellValue(ByVal sender As Object, _
    ByVal e As DevExpress.XtraTreeList.VirtualTreeGetCellValueInfo) _
    Handles TreeList1.VirtualTreeGetCellValue
        Dim di As New DirectoryInfo(CStr(e.Node))
        If e.Column Is TreeListColumn1 Then
            If Not IsFile(di) Then
                e.CellData = di.Name
                If e.Node = LastFolderLoation Then
                    TreeList1.SetFocusedNode(TreeList1.Selection(0))
                End If
            End If
        End If
    End Sub

    Private Function GetFilePath(ByVal CurrentNode As Object) As String
        Dim oPath As String = CurrentNode.Item(0)
        Dim TheNode As Object = CurrentNode
        Do While TheNode.ParentNode IsNot Nothing
            oPath = String.Format("{0}\{1}", TheNode.ParentNode.Item(0), oPath)
            TheNode = TheNode.ParentNode
        Loop

        oPath = String.Format("{0}\{1}", JobPath, oPath)

        Return oPath
    End Function

    Private Sub TreeList1_VirtualTreeGetChildNodes(ByVal sender As Object, _
    ByVal e As DevExpress.XtraTreeList.VirtualTreeGetChildNodesInfo) _
    Handles TreeList1.VirtualTreeGetChildNodes

        Try
            If RootLoaded = False Then
                If Directory.Exists(JobPath) Then
                    Dim dirs As String() = Directory.GetDirectories(JobPath)
                    Dim oDirList As List(Of String) = New List(Of String)(dirs)
                    Dim oPermittedDirList As New List(Of String)
                    ' Hide certain folders from 'Superintendent' whose userPermission is 3
                    For Each item As String In oDirList
                        If (userPermission = 3) And _
                        (UCase(Path.GetFileName(item)).Contains("PROPOSAL") Or _
                         UCase(Path.GetFileName(item)).Contains("ESTIMATE") Or _
                         UCase(Path.GetFileName(item)).Contains("INVOICE")) Then
                            ' Not for Superintendent
                        Else
                            oPermittedDirList.Add(item)
                        End If
                    Next

                    dirs = oPermittedDirList.ToArray

                    Dim arr(dirs.Length) As String
                    dirs.CopyTo(arr, 0)
                    e.Children = arr
                End If
                RootLoaded = True
            Else
                If TypeOf e.Node Is String Then
                    If Directory.Exists(e.Node) Then
                        Dim dirs As String() = Directory.GetDirectories(e.Node)
                        Dim arr(dirs.Length) As String
                        dirs.CopyTo(arr, 0)
                        e.Children = arr
                    End If
                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TreeList1_FocusedNodeChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs) Handles TreeList1.FocusedNodeChanged
        ImageListBoxControl1.Items.Clear()
        _currentlySelectedNode = e.Node
        Dim path As String = GetFilePath(e.Node)
        If Directory.Exists(path) Then
            Dim files As String() = Directory.GetFiles(path)
            Dim arr(files.Length) As String

            files.CopyTo(arr, 0)

            For Each item In files
                ImageListBoxControl1.Items.Add(System.IO.Path.GetFileName(item))
            Next
        End If
    End Sub

    Private Sub ImageListBoxControl1_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ImageListBoxControl1.DragEnter
        e.Effect = DragDropEffects.Copy
    End Sub


    Private Sub ImageListBoxControl1_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ImageListBoxControl1.MouseDoubleClick
        Try

            Dim oPath As String = GetFilePath(TreeList1.Selection(0))

            Process.Start(String.Format("{0}\{1}", oPath, ImageListBoxControl1.SelectedItems(0)))
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
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

    Private Sub btnCreateFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateFolder.Click
        If TreeList1.Selection.Count() = 0 Then

        Else
            Dim newFolderName As String = InputBox("Enter New Folder name", "Create Folder @" & GetFilePath(_currentlySelectedNode), "New Folder")
            Dim newFolderFullPath As String = String.Format("{0}\{1}", GetFilePath(_currentlySelectedNode), newFolderName)
            System.IO.Directory.CreateDirectory(newFolderFullPath)
            LastFolderLoation = newFolderFullPath
            DialogResult = DialogResult.Ignore
            Close()
        End If
    End Sub

    Private Sub btnDeleteFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteFolder.Click
        If TreeList1.Selection.Count() = 0 Then

        Else
            If DialogResult.Yes = MessageBox.Show(String.Format("Are you sure to delete {0} folder?{1} and all its sub-folders!", GetFilePath(_currentlySelectedNode), Constants.vbCrLf), "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) Then
                LastFolderLoation = GetFilePath(_currentlySelectedNode.ParentNode)
                System.IO.Directory.Delete(GetFilePath(_currentlySelectedNode), True)

                DialogResult = DialogResult.Ignore
                Close()
            End If

        End If
    End Sub

    Private Sub ImageListBoxControl1_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ImageListBoxControl1.DragDrop
        Dim a As String() = e.Data.GetData(DataFormats.FileDrop)

        For Each filePath As String In a
            Try
                System.IO.File.Copy(filePath, String.Format("{0}\{1}", GetFilePath(_currentlySelectedNode), Path.GetFileName(filePath)))
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        Next

        If UBound(a) > 0 Then
            DialogResult = DialogResult.Ignore
            Close()
        End If
    End Sub

End Class
