using System;
using Microsoft.Extensions.DependencyInjection;

namespace AppTemplate.Core
{
    public static class CoreServiceLocator
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        public static void SetProvider(IServiceProvider provider)
        {
            ServiceProvider = provider;
        }

        public static T Get<T>()
        {
            return ServiceProvider.GetService<T>();
        }
    }
}
