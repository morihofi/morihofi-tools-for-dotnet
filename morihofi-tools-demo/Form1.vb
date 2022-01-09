Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        morihofi_tools.about.ShowAboutDialog()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Application")
        ComboBox1.Items.Add("ConvertData")
        ComboBox1.Items.Add("Crypt")
        ComboBox1.Items.Add("AntiAntivirus")
        ComboBox1.Items.Add("Image")
        ComboBox1.Items.Add("Web")
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ComboBox2.Items.Clear()

        If ComboBox1.Text = "Application" Then
            ComboBox2.Items.Add("Function getStartupDirectory()")
            ComboBox2.Items.Add("Function getVersionInfoFromExecutable()")
            ComboBox2.Items.Add("Function getExecutablePath()")
        End If

        If ComboBox1.Text = "Image" Then
            ComboBox2.Items.Add("Function TakeScreenShot()")
        End If

        If ComboBox1.Text = "AntiAntivirus" Then
            ComboBox2.Items.Add("Sub Antiasquared()")
            ComboBox2.Items.Add("Sub AntiAvast()")
            ComboBox2.Items.Add("Sub AntiAVG()")
            ComboBox2.Items.Add("Sub AntiBitDefender()")
            ComboBox2.Items.Add("Sub AntiKaspersky()")
            ComboBox2.Items.Add("Sub AntiMalwarebytes()")
            ComboBox2.Items.Add("Sub AntiMcAfee()")
            ComboBox2.Items.Add("Sub AntiNOD32()")
            ComboBox2.Items.Add("Sub AntiNorton()")
            ComboBox2.Items.Add("Sub Antisandboxie()")
        End If

        If ComboBox1.Text = "Web" Then
            ComboBox2.Items.Add("GetWebSourceCode()")
        End If
    End Sub

    Private Function BytesToImage(ByVal ImageBytes() As Byte) As Image
        Dim imgNew As Image
        Dim memImage As New System.IO.MemoryStream(ImageBytes)
        imgNew = Image.FromStream(memImage)
        Return imgNew
    End Function

    Private Function ImageToBytes(ByVal Image As Image) As Byte()
        Dim memImage As New System.IO.MemoryStream
        Dim bytImage() As Byte

        Image.Save(memImage, Image.RawFormat)
        bytImage = memImage.GetBuffer()

        Return bytImage
    End Function
End Class
