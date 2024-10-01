using Microsoft.EntityFrameworkCore;
using Unify.Persistence.Entities;

namespace Unify.Persistence
{
    public class UnifyNotificationContext: DbContext
    {
        public UnifyNotificationContext(DbContextOptions options)
            :base(options)
        {            
        }

        public DbSet<Notifications> Notifications { get; set; }
        public DbSet<NotificationTemplates> EmailTemplates { get; set; }
        public DbSet<EmailTemplateAttachments> EmailTemplateAttachments { get; set; }        
        public DbSet<NotificationTypes> NotificationTypes { get; set; }
        public DbSet<ScheduledNotifications> ScheduledNotifications { get; set; }
    }
}
