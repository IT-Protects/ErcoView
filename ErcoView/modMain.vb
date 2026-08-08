Imports System.Data.SqlClient
Imports System.IO

Module modMain
    Dim oMainClass As New clsFrmMain
    Public currentErcoViewUserName As String
    Public currentErcoViewUserID As Integer = 1
    Public currentErcoViewFullName As String
    Public userPermission As Integer

    Public isDatabaseLive As Boolean
    Public isLocalDatabase As Boolean = True

    Public Enum DataType
        Customer = 0
        JobType = 1
        Super = 2
        Vendor = 3
        Salesman = 4
        Contact = 5
        Group = 6
        SBSCompany = 7
    End Enum
    
    Public Function SplitStringIntoThree(ByVal CommaDelimitedString As String) As List(Of String)
        Dim oRetList As New List(Of String)
        oRetList.Add("") : oRetList.Add("") : oRetList.Add("")

        Dim items = CommaDelimitedString.Split(",")
        If items.Count() = 0 Then
            'do nothing
        ElseIf items.Count = 1 Then
            oRetList.Item(0) = items(0)
        ElseIf items.Count = 2 Then
            oRetList.Item(0) = items(0)
            oRetList.Item(1) = items(1)
        Else
            oRetList.Item(0) = items(0)
            oRetList.Item(1) = items(1)
            oRetList.Item(2) = items(2)
        End If

        Return oRetList
    End Function

    Sub Main()
        If My.Settings.callUpgrade Then
            My.Settings.Upgrade()
            My.Settings.callUpgrade = False
        End If

        Dim myVersion As String = String.Format("{0}.{1}.{2}", My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build)

        If My.Settings.evVersion <> myVersion Then
            MsgBox("Your copy of ErcoView has been updated to version: " + myVersion, vbOKOnly, "ErcoView")

            My.Settings.evVersion = myVersion
            My.Settings.Save()
        End If

        Dim oLogOnClass As New clsLogon
        oLogOnClass.OpenLogOnForm()

        If Not oLogOnClass.isValid Then
            Exit Sub
        End If


        If userPermission <> 1 Then
            oMainClass.myFrmMain.btnNewCustomer.Enabled = False
            oMainClass.myFrmMain.btnNewVendor.Enabled = False
            oMainClass.myFrmMain.pageUser.Visible = False
        End If

        If userPermission = 3 Then
            oMainClass.myFrmMain.btnNewProposal.Enabled = False
        End If

        ' March 25, 2014. Please add the ability to add/edit vendors under the vendor tab to the general user's rights. 
        If userPermission = 2 Then
            oMainClass.myFrmMain.btnNewVendor.Enabled = True
        End If

        oMainClass.ShowMainForm()
    End Sub

    Public Function GetNewProposalNumber() As Integer
        Dim conString As String = GetConnectionString()
        Dim connection As SqlConnection = New SqlConnection(conString)
        Dim pNumber As Integer = 0
        connection.Open()
        Try
            Dim command As SqlCommand = New SqlCommand("spGetNewProposalNumber", connection) With {.CommandType = CommandType.StoredProcedure}
            command.Parameters.Add("@newProposal", SqlDbType.Int).Direction = ParameterDirection.Output
            command.ExecuteNonQuery()
            pNumber = command.Parameters("@newProposal").Value
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.Close()
            connection.Dispose()
        End Try

        If pNumber = 0 Then
            MsgBox("Proposal could not be created!", vbCritical + vbOKOnly, "ErcoView")
        End If

        Return pNumber
    End Function

    Sub CopyDirectory(ByVal SourcePath As String, ByVal DestPath As String, Optional ByVal Overwrite As Boolean = False)
        Dim SourceDir As DirectoryInfo = New DirectoryInfo(SourcePath)
        Dim DestDir As DirectoryInfo = New DirectoryInfo(DestPath)

        ' the source directory must exist, otherwise throw an exception
        If SourceDir.Exists Then
            ' if destination SubDir's parent SubDir does not exist throw an exception
            If Not DestDir.Parent.Exists Then
                Throw New DirectoryNotFoundException _
                    ("Destination directory does not exist: " + DestDir.Parent.FullName)
            End If

            If Not DestDir.Exists Then
                DestDir.Create()
            End If

            ' copy all the files of the current directory
            Dim ChildFile As FileInfo
            For Each ChildFile In SourceDir.GetFiles()
                If Overwrite Then
                    ChildFile.CopyTo(Path.Combine(DestDir.FullName, ChildFile.Name), True)
                Else
                    ' if Overwrite = false, copy the file only if it does not exist
                    ' this is done to avoid an IOException if a file already exists
                    ' this way the other files can be copied anyway...
                    If Not File.Exists(Path.Combine(DestDir.FullName, ChildFile.Name)) Then
                        ChildFile.CopyTo(Path.Combine(DestDir.FullName, ChildFile.Name), False)
                    End If
                End If
            Next

            ' copy all the sub-directories by recursively calling this same routine
            Dim SubDir As DirectoryInfo
            For Each SubDir In SourceDir.GetDirectories()
                CopyDirectory(SubDir.FullName, Path.Combine(DestDir.FullName, _
                    SubDir.Name), Overwrite)
            Next
        Else
            Throw New DirectoryNotFoundException("Source directory does not exist: " + SourceDir.FullName)
        End If
    End Sub


    Public Function GetLayoutFilePath(ByVal LayoutName As String) As String


        Dim myLayoutPath As String = "File not found"
        If File.Exists(String.Format("{0}\{1}.xml", My.Settings.layoutPathLocal, LayoutName)) Then
            myLayoutPath = String.Format("{0}\{1}.xml", My.Settings.layoutPathLocal, LayoutName)
        Else
            myLayoutPath = String.Format("{0}\", My.Settings.layoutPathServer)
            If userPermission = 1 Then
                myLayoutPath += "\Admin"
            ElseIf userPermission = 2 Then
                myLayoutPath += "\General"
            ElseIf userPermission = 3 Then
                myLayoutPath += "\Super"
            Else
                Throw New Exception()
            End If
            myLayoutPath += String.Format("\{0}.xml", LayoutName)
        End If

        If Not File.Exists(myLayoutPath) Then
            Return String.Empty
        End If

        Return myLayoutPath
    End Function

    Public Class LayoutItem
        Private _layoutFile As String
        Public Sub New(ByVal FilePath As String)
            _layoutFile = FilePath
        End Sub

        Public Overrides Function ToString() As String
            Return Path.GetFileNameWithoutExtension(_layoutFile)
        End Function

        Public Function Location() As String
            Return _layoutFile
        End Function
    End Class

    Public Function GetConnectionString() As String
        Dim databaseName As String
        If isDatabaseLive Then
            databaseName = "ErcoView_Live"
        Else
            databaseName = "ErcoView_Training"
        End If

        Dim connString As String = ""
        If isLocalDatabase Then
            'connString = String.Format("Data source={0};Initial Catalog={1};User ID=PortalUser;Password=!08Portal03!", My.Settings.localIP, databaseName)
            connString = String.Format("Data source={0};Initial Catalog={1};User ID=ercoviewuser;Password=!ercoView1", My.Settings.localIP, databaseName)
        Else
            connString = String.Format("Data source={0};Initial Catalog={1};User ID=ercoviewuser;Password=!ercoView1", My.Settings.remoteIP, databaseName)
        End If

        Return connString
    End Function

End Module

	