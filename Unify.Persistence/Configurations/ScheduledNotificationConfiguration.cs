using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Unify.Persistence.Entities;

namespace Unify.Persistence.Configurations
{
    public class ScheduledNotificationConfiguration : IEntityTypeConfiguration<ScheduledNotifications>
    {
        public void Configure(EntityTypeBuilder<ScheduledNotifications> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Content).IsRequired();
            builder.Property(x => x.Subject).IsRequired().HasMaxLength(150);
            builder.Property(x => x.Status).HasConversion<string>().IsRequired().HasMaxLength(15);
            builder.Property(x => x.Channel).HasConversion<string>().IsRequired().HasMaxLength(20);
            builder.Property(x => x.Frequency).HasConversion<string>().IsRequired().HasMaxLength(30);
            builder.Property(x => x.Recipient).IsRequired();
            builder.Property(x => x.Sender).IsRequired().HasMaxLength(100);

            builder.Property(x => x.DateCreated).IsRequired();
            builder.Property(x => x.IsDeleted).IsRequired().HasDefaultValue(false);
        }
    }
}
