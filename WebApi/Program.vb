Imports System
Imports Microsoft.AspNetCore
Imports Microsoft.AspNetCore.Hosting

' dotnet publish --configuration Release -r win-x64 -o publish
Module Program
    Sub Main(args As String())
            BuildWebHost(args).Run()
    End Sub

    Function BuildWebHost(args as string()) as IWebHost
            return WebHost.CreateDefaultBuilder(args).UseStartup(Of Startup)().Build()
    End Function
   
End Module
