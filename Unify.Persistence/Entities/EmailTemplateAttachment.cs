using System.ComponentModel.DataAnnotations.Schema;

namespace Unify.Persistence.Entities
{
    [Table("EmailTemplateAttachments", Schema = "UserPreference")]
    public class EmailTemplateAttachments : BaseEntity, IAuditableEntity
    {
        public long EmailTemplatesId { get; set; }
        public required string FileName { get; set; }
        public required string FileUrl { get; set; }
        public required string ContentType { get; set; }

        public DateTime? DateModified { get; set; }
        public string? ModifiedBy { get; set; }
        public string? ModifiedByIp { get; set; }
        public required string CreatedBy { get; set; }
        public required string CreatedByIp { get; set; }
    }
}
