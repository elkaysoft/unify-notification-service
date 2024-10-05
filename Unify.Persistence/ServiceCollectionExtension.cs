using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Unify.Persistence.DAL;
using Unify.Persistence.Interface;

namespace Unify.Persistence
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddPersistenceDI(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<UnifyNotificationContext>(options => options.UseNpgsql(configuration.GetConnectionString("NotificationService")));

            services.AddScoped<INotificationRepo, NotificationRepo>();
            services.AddScoped<ISchedulingRepo, SchedulingRepo>();

            return services;
        }
        
    }
}
