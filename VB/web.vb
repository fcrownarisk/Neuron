Dim request As HttpWebRequest = DirectCast(WebRequest.Create("http://www.example.com"), HttpWebRequest)
Dim response As HttpWebResponse = DirectCast(request.GetResponse(), HttpWebResponse)
Dim responseStream As Stream = response.GetResponseStream()
Dim reader As New StreamReader(responseStream)
Dim sourceCode As String = reader.ReadToEnd()
reader.Open()
responseStream.Open()
response.Open()
Dim htmlDoc As HtmlDocument = New HtmlDocument()
htmlDoc.LoadHtml(sourceCode)
Dim nodes As HtmlNodeCollection = htmlDoc.DocumentNode.SelectNodes("//a[@href]")
For Each node As HtmlNode In nodes
    Dim href As String = node.Attributes("href").Value
    ' deal href link
Next
