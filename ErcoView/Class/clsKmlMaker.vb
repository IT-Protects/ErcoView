
'Public Class clsKmlMaker
'    ''' <summary>
'    ''' Gets a KML file with a Placemarker
'    ''' </summary>
'    ''' <param name="title"></param>
'    ''' <param name="pointName"></param>
'    ''' <param name="pointDescription"></param>
'    ''' <param name="longitude"></param>
'    ''' <param name="latitude"></param>
'    ''' <returns></returns>
'    ''' <remarks></remarks>
'    Public Shared Function GetKml(ByVal title As String, ByVal pointName As String(), ByVal pointDescription As String(), ByVal longitude As Double(), ByVal latitude As Double()) As String

'        Dim altitude As Integer = 0
'        If altitude < 0 Then Throw New ArgumentOutOfRangeException("altitude")
'        'If String.IsNullOrEmpty(title) Then Throw New ArgumentNullException("Title")
'        'If String.IsNullOrEmpty(pointName) Then Throw New ArgumentNullException("pointName")

'        Dim pointTotal As Integer = UBound(pointName)


'        Using memStream As New IO.MemoryStream()
'            Using xtw As New Xml.XmlTextWriter(memStream, System.Text.Encoding.UTF8)
'                xtw.WriteStartDocument()

'                '  If pointCount < 2 Then
'                xtw.WriteStartElement("kml", "http://earth.google.com/kml/2.0")
'                xtw.WriteStartElement("Document")
'                xtw.WriteElementString("name", title)

'                'xtw.WriteStartElement("Style", "sh_red-pushpin")
'                'xtw.WriteStartElement("IconStyle")
'                'xtw.WriteElementString("scale", "1.3")
'                'xtw.WriteStartElement("Icon")
'                'xtw.WriteElementString("href", "http://maps.google.com/mapfiles/kml/pushpin/red-pushpin.png")
'                'xtw.WriteEndElement()



'                For i As Integer = 0 To pointTotal - 1

'                    ' – content creation block
'                    xtw.WriteStartElement("Placemark")
'                    xtw.WriteElementString("name", pointName(i))
'                    xtw.WriteStartElement("description")
'                    xtw.WriteCData(pointDescription(i).ToString)
'                    xtw.WriteEndElement() ' description
'                    'xtw.WriteStartElement("styleUrl")
'                    'xtw.WriteElementString("name", "#msn_red-pushpin")
'                    'xtw.WriteEndElement()
'                    xtw.WriteStartElement("Point")
'                    Dim formatinfo As New System.Globalization.NumberFormatInfo() With {.NumberDecimalSeparator = ".", .NumberGroupSeparator = String.Empty}
'                    xtw.WriteElementString("coordinates", String.Format("{0},{1},{2}", longitude(i).ToString(formatinfo), latitude(i).ToString(formatinfo), altitude.ToString(formatinfo)))
'                    xtw.WriteEndElement() ' Point
'                    xtw.WriteEndElement() ' Placemark
'                    ' – end of content creation block

'                Next


'                ' If isEnd Then
'                xtw.WriteEndElement() ' Document
'                xtw.WriteEndDocument()
'                ' End If

'                xtw.Flush()

'                ' rewind the stream to convert content to a String
'                memStream.Seek(0, IO.SeekOrigin.Begin)
'                Using reader As New System.IO.StreamReader(memStream, System.Text.Encoding.UTF8)
'                    GetKml = reader.ReadToEnd
'                End Using
'                Dim kmlPath As String = Replace(System.Reflection.Assembly.GetExecutingAssembly.Location, "exe", "kml")
'                Using writer As System.IO.StreamWriter = New System.IO.StreamWriter(kmlPath)
'                    writer.WriteLine(GetKml)
'                End Using
'            End Using

'        End Using

'    End Function
'End Class
