Public Class about
    Private Sub about_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Shared Sub ShowAboutDialog()
        Dim f As New about
        f.Label3.Text = Application.getVersionInfoFromExecutable(Application.getExecutablePath())


        If Application.getVersionInfoFromExecutable(Application.getExecutablePath()) = "1.4.3.0" Then
            f.Label3.Text = f.Label3.Text & " (letzte Version aus 2019)"
        End If

        f.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://morihofi.de")
    End Sub
End Class