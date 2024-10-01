using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Unify.Persistence.Entities;

namespace Unify.Persistence.Configurations
{
    public class EmailTemplateAttachmentConfiguration : IEntityTypeConfiguration<EmailTemplateAttachments>
    {
        public void Configure(EntityTypeBuilder<EmailTemplateAttachments> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.EmailTemplatesId).IsRequired();
            builder.Property(x => x.FileName).IsRequired().HasMaxLength(150);
            builder.Property(x => x.FileUrl).IsRequired();
            builder.Property(x => x.CreatedBy).IsRequired().HasMaxLength(50);
            builder.Property(x => x.DateCreated).IsRequired();
            builder.Property(x => x.IsDeleted).IsRequired().HasDefaultValue(false);
        }
    }
}
