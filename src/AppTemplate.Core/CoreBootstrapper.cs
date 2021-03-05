using AppTemplate.Core.Data;
using AppTemplate.Core.Managers;
using AppTemplate.Core.Services;
using AppTemplate.Forms.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace AppTemplate.Core
{
    public class CoreBootstrapper
    {

        private static CoreBootstrapper _instance;
        public static CoreBootstrapper Instance => _instance ??= new();

        private CoreBootstrapper() { }

        public void ConfigureServices(IServiceCollection services)
        {
            // Data
            services.AddSingleton<IJsonSerializer, JsonSerializer>();

            // Managers
            services.AddSingleton<IWorldTimeManager, WorldTimeManager>();

            // Repositories

            // Services
            services.AddSingleton<IDateTimeService, DateTimeService>();

            // ViewModels
            services.AddTransient<HomeViewModel>();
        }
    }
}
