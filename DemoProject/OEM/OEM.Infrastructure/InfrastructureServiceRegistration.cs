using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OEM.Application.Contracts.Persistence;
using OEM.Infrastructure.Persistence;
using OEM.Infrastructure.Repositories;

namespace OEM.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<OEMContext>(options =>
               options.UseSqlServer(configuration.GetConnectionString("OEMConnectionString")));
            services.AddScoped(typeof(IAsyncRepository<>), typeof(RepositoryBase<>));
            services.AddScoped<IOEMRepository, OEMCampaignRepository>();


            return services;
        }
    }
}
