using AppTemplate.Core;
using AppTemplate.Core.Services;
using AppTemplate.Forms.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Shiny;
using System;

namespace AppTemplate.Forms
{
    public class Startup : ShinyStartup
    {
        public override void ConfigureServices(IServiceCollection services, IPlatform platform)
        {
            Extensions.RegisterPostBuildAction(services, sp => CoreServiceLocator.SetProvider(sp));
            CoreBootstrapper.Instance.ConfigureServices(services);

            services.AddHttpClient();

            // Register any dependencies here that are implemented by AppTemplate.Forms

            services.AddSingleton<IAppInfoService, AppInfoService>();

        }        

        public override void ConfigureLogging(ILoggingBuilder builder, IPlatform platform)
        {
            base.ConfigureLogging(builder, platform);
            builder.AddConsole();
        }
    }
}
