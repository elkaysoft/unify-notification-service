using Unify.Persistence.Enums;

namespace Unify.Application.Requests
{
    public class SendNotificationRequest
    {
        public NotificationTypeEnum NotificationType { get; set; }
        public DateTime? ScheduleDateTime { get; set; }
        public NotificationFrequency ScheduleFrequency { get; set; }
        public EmailRequestDto? Email { get; set; }
        public SmsRequestDto? Sms { get; set; }

    }

    
}
