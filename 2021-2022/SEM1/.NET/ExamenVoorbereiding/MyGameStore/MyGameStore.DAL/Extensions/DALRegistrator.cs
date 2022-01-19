using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyGameStore.DAL.Contexts;
using MyGameStore.DAL.Repositories;
using MyGameStore.DAL.UOW;

namespace MyGameStore.DAL.Extensions
{
    public static class DALRegistrator
    {
        public static IServiceCollection RegisterDataAccesServices(this IServiceCollection services)
        {
            services.RegisterContexts();
            services.RegisterRepositories();
            services.RegisterUnitsOfWork();

            return services;
        }

        private static IServiceCollection RegisterContexts(this IServiceCollection services)
        {
            services.AddDbContext<GameStoreContext>(options => options.UseSqlServer("name=ConnectionStrings:MyGameStore"));

            return services;
        }

        private static IServiceCollection RegisterRepositories(this IServiceCollection services)
        {
            services.AddScoped<IPeopleRepository, PeopleRepository>();
            services.AddScoped<IStoreRepository, StoreRepository>();

            return services;
        }

        private static IServiceCollection RegisterUnitsOfWork(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}
