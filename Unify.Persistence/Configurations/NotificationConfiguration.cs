using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Unify.Persistence.Entities;

namespace Unify.Persistence.Configurations
{
    public class NotificationConfiguration : IEntityTypeConfiguration<Notifications>
    {
        public void Configure(EntityTypeBuilder<Notifications> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Subject).IsRequired().HasMaxLength(100);
            builder.Property(x => x.MessageContent).IsRequired();
            builder.Property(x => x.Status).HasConversion<string>().IsRequired().HasMaxLength(15);
            builder.Property(x => x.DateCreated).IsRequired();
            builder.Property(x => x.Recipient).IsRequired();
            builder.Property(x => x.Sender).IsRequired().HasMaxLength(100);
            builder.Property(x => x.IsDeleted).IsRequired().HasDefaultValue(false);
            builder.Property(x => x.ChannelType).HasConversion<string>().IsRequired().HasMaxLength(15);
            builder.Property(x => x.RetryCount).HasDefaultValue(0);
        }
    }
}
