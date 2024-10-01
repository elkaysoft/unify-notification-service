using System.ComponentModel.DataAnnotations.Schema;

namespace Unify.Persistence.Entities
{
    [Table("NotificationTypes", Schema = "UserPreference")]
    public class NotificationTypes : BaseEntity, IAuditableEntity
    {
        public required string Name { get; set; }
        public string? Description { get; set; }
        public required string Subject { get; set; }
        public required string Body { get; set; }

        public required NotificationTypes NotificationTypeId { get; set; }

        public DateTime? DateModified { get; set; }
        public string? ModifiedBy { get; set; }
        public string? ModifiedByIp { get; set; }
        public required string CreatedBy { get; set; }
        public required string CreatedByIp { get; set; }
    }
}
