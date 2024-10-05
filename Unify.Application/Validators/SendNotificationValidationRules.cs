using Unify.Application.Common;
using Unify.Application.Requests;

namespace Unify.Application.Validators
{
    public class SendNotificationValidationRules
    {
        private readonly Notifier _notifier;

        public SendNotificationValidationRules(Notifier notifier)
        {
            _notifier = notifier;              
        }

        public void Validate(SendNotificationRequest request)
        {
            EmailOrSmsValidation(request);
            EmailRuleValidation(request.Email);
            SmsRuleValidation(request.Sms);
            ScheduleRuleValidation(request);
        }

        private void EmailOrSmsValidation(SendNotificationRequest model)
        {
            if (model.Email is null && model.Sms is null)
                _notifier.AddNotification("EmailSms", "Email/Sms object cannot be null");        
        }

        private void EmailRuleValidation(EmailRequestDto? model)
        {
            if(model != null)
            {
                if (string.IsNullOrWhiteSpace(model.Subject))
                    _notifier.AddNotification(nameof(model.Subject), "Email subject is required");
                if (string.IsNullOrWhiteSpace(model.Body))
                    _notifier.AddNotification(nameof(model.Body), "Email body is required");
                if (string.IsNullOrWhiteSpace(model.Recepient))
                    _notifier.AddNotification(nameof(model.Recepient), "Email recipient is required");
                if(string.IsNullOrWhiteSpace(model.Sender))
                    _notifier.AddNotification(nameof(model.Sender), "Email sender is required");
            }
        }

        private void SmsRuleValidation(SmsRequestDto? model)
        {
            if(model != null)
            {
                if(string.IsNullOrWhiteSpace(model.Subject))
                    _notifier.AddNotification(nameof(model.Subject), "Sms Subject is required");
                if (string.IsNullOrWhiteSpace(model.Body))
                    _notifier.AddNotification(nameof(model.Body), "Sms body is required");
                if (string.IsNullOrWhiteSpace(model.Recipient))
                    _notifier.AddNotification(nameof(model.Recipient), "Sms recipient is required");
                if (string.IsNullOrWhiteSpace(model.Sender))
                    _notifier.AddNotification(nameof(model.Sender), "Sms sender is required");
            }
        }
        
        private void ScheduleRuleValidation(SendNotificationRequest model)
        {
            if (model.NotificationType == Persistence.Enums.NotificationTypeEnum.Scheduled && !model.ScheduleDateTime.HasValue)
                _notifier.AddNotification(nameof(model.NotificationType), "Schedule date is required");
        }
        
    }
}
