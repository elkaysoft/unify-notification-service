using Unify.Persistence.Enums;

namespace Unify.Persistence.Models
{
    public class ScheduledNotificationRequestLog
    {
        public DateTime? ScheduleDateTime { get; set; }
        public NotificationFrequency ScheduleFrequency { get; set; }
        public string Subject { get; set; } = string.Empty;
        public string Recipient { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
        public string Sender { get; set; } = string.Empty;
        public ChannelType ChannelType { get; set; }
        public string? CC { get; set; }
    }
}
