using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Unify.Persistence.Entities;

namespace Unify.Persistence
{
    public class UnifyNotificationContext: DbContext
    {
        public UnifyNotificationContext(DbContextOptions options)
            :base(options)
        {            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly(), p => p.Namespace == "Unify.Persistence.Configurations");

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Notifications> Notifications { get; set; }
        public DbSet<NotificationTemplates> EmailTemplates { get; set; }
        public DbSet<EmailTemplateAttachments> EmailTemplateAttachments { get; set; }        
        public DbSet<NotificationTypes> NotificationTypes { get; set; }
        public DbSet<ScheduledNotifications> ScheduledNotifications { get; set; }
    }
}
