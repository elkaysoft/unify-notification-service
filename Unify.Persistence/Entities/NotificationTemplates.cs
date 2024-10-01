using System.ComponentModel.DataAnnotations.Schema;
using Unify.Persistence.Enums;

namespace Unify.Persistence.Entities
{
    [Table("NotificationTemplates", Schema = "UserPreference")]
    public class NotificationTemplates : BaseEntity, IAuditableEntity
    {
        public required string TemplateName { get; set; }
        public required string Subject { get; set; }
        public required string Body { get; set; }
        public NotificationTypes NotificationTypeId { get; set; } = default!;
        public ChannelType Channel { get; set; }
        public bool HasAttachment { get; set; }
        public DateTime? DateModified { get; set; }
        public string? ModifiedBy { get; set; }
        public string? ModifiedByIp { get; set; }
        public required string CreatedBy { get; set; }
        public required string CreatedByIp { get; set; }
    }
}
