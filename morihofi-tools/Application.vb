Public Class Application

    Shared Function getStartupDirectory()
        Return System.AppDomain.CurrentDomain.BaseDirectory()

    End Function

    Shared Function getVersionInfoFromExecutable(ByVal ExePath As String)
        Dim versionInfo = FileVersionInfo.GetVersionInfo(ExePath)
        Dim version = versionInfo.ProductVersion ' Will typically Return "1.0.0" In your Case
        Return version
    End Function

    Shared Function getExecutablePath()
        Return System.Reflection.Assembly.GetExecutingAssembly().Location
    End Function

End Class
