using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unify.Persistence
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddPersistenceDI(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<UnifyNotificationContext>(options => options.UseNpgsql(configuration.GetConnectionString("NotificationService")));

            return services;
        }
        
    }
}
