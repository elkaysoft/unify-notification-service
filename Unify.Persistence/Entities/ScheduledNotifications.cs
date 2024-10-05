using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unify.Persistence.Enums;

namespace Unify.Persistence.Entities
{
    [Table("ScheduledNotifications", Schema = "public")]
    public class ScheduledNotifications: BaseEntity
    {
        public string Sender { get; set; } = string.Empty;
        public string? CC { get; set; }
        public required string Recipient { get; set; }
        public string Subject { get; set; } = string.Empty;
        public required string Content { get; set; }
        public NotificationFrequency Frequency { get; set; }
        public required DateTime ScheduledDateTime { get; set; }
        public required ChannelType Channel { get; set; }
        public NotificationStatus Status { get; set; }        
        public string? Attachments { get; set; }

    }
}
