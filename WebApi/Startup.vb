Imports Microsoft.AspNetCore.Builder
Imports Microsoft.AspNetCore.Hosting
Imports Microsoft.Extensions.DependencyInjection

Public Class Startup
    Public Sub ConfigureServices(services As IServiceCollection)
        services.AddMvc()
    End Sub

    Public Sub Configure(app As IApplicationBuilder, env As IHostingEnvironment)
        If (env.IsDevelopment()) Then
            app.UseDeveloperExceptionPage()
        End If

        app.UseMvc()

        ' 静的ファイルのデフォルト設定を有効にする
        app.UseDefaultFiles()

        ' 静的ファイルを使用する
        app.UseStaticFiles()
    End Sub
End Class