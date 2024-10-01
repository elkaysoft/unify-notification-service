using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unify.Persistence.Entities;

namespace Unify.Persistence.Configurations
{
    public class NotificationTemplateConfiguration : IEntityTypeConfiguration<NotificationTemplates>
    {
        public void Configure(EntityTypeBuilder<NotificationTemplates> builder)
        {
            builder.HasKey(x  => x.Id);
            builder.Property(x => x.Subject).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Body).IsRequired();
            builder.Property(x => x.Channel).IsRequired().HasConversion<string>().HasMaxLength(20);

            builder.Property(x => x.CreatedBy).IsRequired().HasMaxLength(50);
            builder.Property(x => x.DateCreated).IsRequired();
            builder.Property(x => x.TemplateName).IsRequired();
            builder.Property(x => x.NotificationTypeId).IsRequired();
            builder.Property(x => x.IsDeleted).IsRequired().HasDefaultValue(false);
        }
    }
}
