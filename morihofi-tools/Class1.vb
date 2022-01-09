Public Class ConvertData
    '------------------Daten(Bytearray) in String und zurück-------------------
    Shared Function StringToByteArray(ByRef str As String) As Byte()
        Return Convert.FromBase64String(str)
    End Function

    Shared Function ByteArrayToString(ByRef Barr() As Byte) As String
        Return Convert.ToBase64String(Barr)
    End Function

    '------------------Text in Bytearray und zurück-------------------
    Shared Function TextStringToByteArray(ByRef str As String) As Byte()
        Dim enc As System.Text.Encoding = System.Text.Encoding.Default

        Return enc.GetBytes(str)
    End Function


    Shared Function ImageToBase64(ByVal oImage As Image) As String
        If oImage IsNot Nothing Then
            With New System.Drawing.ImageConverter
                ' Image in Byte-Array umwandeln
                Dim nBytes() As Byte = CType(.ConvertTo(oImage, GetType(Byte())), Byte())

                ' Byte-Array in Base64-codierten String umwandeln
                Return (Convert.ToBase64String(nBytes,
                  Base64FormattingOptions.InsertLineBreaks))
            End With
        Else
            ' Leerstring zurückgeben
            Return ("")
        End If
    End Function

    Shared Function Base64ToImage(ByVal sData As String) As Image
        Dim oImage As Image = Nothing

        If sData.Length > 0 Then
            ' String decodieren und in Byte-Array umwandeln
            Dim nBytes() As Byte = Convert.FromBase64String(sData)
            If nBytes IsNot Nothing AndAlso nBytes.Length > 0 Then
                ' Byte-Array in Image-Objekt umwandeln
                With New System.Drawing.ImageConverter
                    oImage = CType(.ConvertFrom(nBytes), Image)
                End With
            End If
        End If
        Return (oImage)
    End Function




End Class
