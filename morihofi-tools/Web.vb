Public Class Web


    Shared Function GetWebSourceCode(ByVal URL As String) As String
        Dim source As String
        source = New System.Net.WebClient().DownloadString(URL)

        Return source

    End Function

End Class
