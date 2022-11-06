using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;

namespace FMA.Core.ServiceConfig;
public static class WebHostCoreExtensions
{
    public static ConfigureWebHostBuilder AddWebHostCoreConfig(this ConfigureWebHostBuilder webHost, List<int> listenPorts, bool isAdminApp = true)
    {
        //if (listenPorts != null)
        //{
        //    webHost.UseKestrel((options) =>
        //    {
        //        options.AddServerHeader = false;
        //        foreach (var port in listenPorts)
        //        {
        //            options.ListenAnyIP(port);
        //        }

        //        if (isAdminApp)
        //        {
        //            // configure 1.5GB
        //            options.Limits.MaxRequestBodySize = 1610612736;
        //        }
        //    });
        //}

        webHost.ConfigureAppConfiguration((hostingContext, config) =>
        {
            var env = hostingContext.HostingEnvironment;
            config
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true, reloadOnChange: true);
        });


        return webHost;
    }
}