Imports System.Data.SqlClient
Imports System.Xml

Public Enum eStyle
    red = 0
    yellow = 1
    blue = 2
    black = 3
End Enum

Public Class PlaceMark
    Public Name As String
    Public Desc As String
    Public url As String
    Public CoordX As String
    Public Coordy As String
    'Public Style As String
End Class


Public Class clsMapIt
    'Protected m_XMLPath As String = Replace(System.Reflection.Assembly.GetExecutingAssembly.Location, "exe", "kml") '"c:\temp\7121.kml"
    'Private oXmlDocument As New Xml.XmlDocument()

    Public Sub MapPoints()



        'Dim lo_XmlNodeList = oXmlDocument.GetElementsByTagName("Placemark")

        'Dim places As New List(Of PlaceMark)

        'Dim oPlace1 As New PlaceMark
        'oPlace1.Name = "my House"
        'oPlace1.Desc = "This is great place"
        'oPlace1.url = "#msn_blue-pushpin"
        'oPlace1.CoordX = "-96"
        'oPlace1.Coordy = "30"
        'places.Add(oPlace1)

        'Dim oPlace2 As New PlaceMark
        'oPlace2.Name = "your house"
        'oPlace2.Desc = "This one too!"
        'oPlace2.url = "#msn_grn-pushpin"
        'oPlace2.CoordX = "-96.5"
        'oPlace2.Coordy = "30.8"
        'places.Add(oPlace2)
        'AddPlaceMark(places)
        'oXmlDocument.Save("c:\temp\7121.kml")
    End Sub


    Public Sub AddPlaceMark(ByVal _places As List(Of PlaceMark), ByRef oXmlDocument As Xml.XmlDocument)

        Dim oDocumentNode As XmlNode = oXmlDocument.GetElementsByTagName("Folder")(0)

        For Each place In _places
            Dim oNewPlacementNode As XmlNode = oXmlDocument.CreateElement("Placemark")
            oDocumentNode.AppendChild(oNewPlacementNode)

            Dim oNameNode As XmlNode = oXmlDocument.CreateElement("name")
            oNameNode.InnerText = place.Name
            oNewPlacementNode.AppendChild(oNameNode)

            Dim oDescNode As XmlNode = oXmlDocument.CreateElement("description")
            oDescNode.InnerText = place.Desc
            oNewPlacementNode.AppendChild(oDescNode)

            Dim oUrlNode As XmlNode = oXmlDocument.CreateElement("styleUrl")
            oUrlNode.InnerText = place.url
            oNewPlacementNode.AppendChild(oUrlNode)

            Dim oPointNode As XmlNode = oXmlDocument.CreateElement("Point")
            Dim oCoordNode As XmlNode = oXmlDocument.CreateElement("coordinates")
            oCoordNode.InnerText = String.Format("{0},{1},0", place.CoordX, place.Coordy)
            oPointNode.AppendChild(oCoordNode)
            oNewPlacementNode.AppendChild(oPointNode)

            'Dim oStyleNode As XmlNode = oXmlDocument.CreateElement("styleid")
            'oStyleNode.InnerText = place.Style
            'oNewPlacementNode.AppendChild(oStyleNode)
        Next

    End Sub


    Protected Sub ReadType(ByRef EquipTypeControl As Control)

        Try
            Dim node As XmlNode = EquipTypeControl.Tag
            Dim child As Xml.XmlNode = node.FirstChild


            For i = 0 To node.ChildNodes.Count - 1 Step 1
                If 0 = i Then
                    MsgBox(child.Name)
                Else
                    child = child.NextSibling
                    MsgBox(child.Name)
                End If
            Next

            'If cmboLayouts.Properties.Items.Count > 0 Then
            '    cmboLayouts.SelectedIndex = 0
            'End If

        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub LoadListBox2(ByRef PlacemarkNode As XmlNode)
        Dim child = PlacemarkNode.FirstChild

        For i = 0 To PlacemarkNode.ChildNodes.Count - 1 Step 1
            If 0 = i Then
                MsgBox(child.Name)
            Else
                child = child.NextSibling
                MsgBox(child.Name)
            End If
        Next
    End Sub




End Class
