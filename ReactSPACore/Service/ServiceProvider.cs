using Microsoft.Extensions.DependencyInjection;

namespace ReactSPACore.Service
{
    public static class ServiceProvider
    {
        private static IServiceCollection services;
        public static IServiceCollection Services
        {
            get
            {
                return services;
            }
            set
            {
                if (services == null) { services = value; }
            }
        }


        public static T GetService<T>()
        {
            IServiceCollection services = Services;
            var provider = services.BuildServiceProvider();
            return provider.GetService<T>();
        }
    }
}