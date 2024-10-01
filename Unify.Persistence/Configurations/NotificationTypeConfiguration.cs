using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Unify.Persistence.Entities;

namespace Unify.Persistence.Configurations
{
    public class NotificationTypeConfiguration : IEntityTypeConfiguration<NotificationTypes>
    {
        public void Configure(EntityTypeBuilder<NotificationTypes> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(150);
            builder.Property(x => x.Description).HasMaxLength(250);
            builder.Property(x => x.CreatedBy).IsRequired().HasMaxLength(50);
            builder.Property(x => x.DateCreated).IsRequired();
            builder.Property(x => x.IsDeleted).IsRequired().HasDefaultValue(false);
        }
    }
}
