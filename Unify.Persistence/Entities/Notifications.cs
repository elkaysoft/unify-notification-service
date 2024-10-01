using System.ComponentModel.DataAnnotations.Schema;
using Unify.Persistence.Enums;

namespace Unify.Persistence.Entities
{
    [Table("Notifications", Schema = "public")]
    public class Notifications: BaseEntity
    {
        public string Sender { get; set; } = string.Empty;
        public required string Recipient { get; set; }
        public string? CC { get; set; }
        public required string Subject { get; set; }
        public required string MessageContent { get; set; }
        public ChannelType ChannelType { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string? Attachments { get; set; }
        public required NotificationStatus Status { get; set; }
    }
}
