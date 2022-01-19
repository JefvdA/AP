using Microsoft.Extensions.DependencyInjection;
using MyGameStore.BLL.Services;
using MyGameStore.BLL.Interfaces;

namespace MyGameStore.BLL.Extensions
{
    public static class ServiceRegistrator
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IPeopleService, PeopleService>();
            services.AddScoped<IStoreService, StoreService>();

            return services;
        }
    }
}
