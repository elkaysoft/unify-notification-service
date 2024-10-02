using Microsoft.Extensions.DependencyInjection;
using Unify.Application.Common;
using Unify.Application.Implementation;
using Unify.Application.Interface;

namespace Unify.Application
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationService(this IServiceCollection services)
        {
            services.AddScoped<INotificationService, NotificationService>();
            services.AddSingleton<Notifier>();

            return services;
        }
    }
}
