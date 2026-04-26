using Microsoft.EntityFrameworkCore;
using CoreData.DbContexts;
using CoreData.IRepository;
using CoreData.Repositories;
using CoreData.UnitOfWork;
using CoreBussiness.IManager;
using CoreBussiness.Managers;

namespace CoreMasterAPI.Extensions
{
    public static class ServiceExtensions
    {
        public static void RegisterServices(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<MasterDbContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("Masterstring")
                ));

            services.AddScoped<IFacilityRepository, FacilityRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IFacilityManager, FacilityManager>();
        }
    }
}