using AppTemplate.Core;
using AppTemplate.Core.Services;
using AppTemplate.Forms.Services;
using Microsoft.Extensions.DependencyInjection;
using Shiny;
using System;

namespace AppTemplate.Forms
{
    public class Startup : ShinyStartup
    {
        public override void ConfigureServices(IServiceCollection services)
        {
            CoreBootstrapper.Instance.ConfigureServices(services);

            // Register any dependencies here that are implemented by AppTemplate.Forms

            services.AddSingleton<IAppInfoService, AppInfoService>();
        }

        public override void ConfigureApp(IServiceProvider provider)
        {
            base.ConfigureApp(provider);

            // Sets the container in CoreServiceLocator so we can resolve dependencies without DI
            CoreServiceLocator.SetProvider(provider);
        }
    }
}
