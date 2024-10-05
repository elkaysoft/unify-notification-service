using Unify.Application.Common;
using Unify.Application.Exceptions;
using Unify.Application.Interface;
using Unify.Application.Requests;
using Unify.Application.Validators;
using Unify.Application.ViewModel;
using Unify.Persistence.Interface;
using Unify.Persistence.Models;

namespace Unify.Application.Implementation
{
    public class NotificationService : INotificationService
    {
        private readonly Notifier _notifier;
        private readonly INotificationRepo _notificationRepo;
        private readonly ISchedulingRepo _schedulingRepo;

        public NotificationService(Notifier notifier,
            INotificationRepo notificationRepo,
            ISchedulingRepo schedulingRepo)
        {
            _notifier = notifier;
            _notificationRepo = notificationRepo;
            _schedulingRepo = schedulingRepo;
        }

        public async Task<BaseResponse> SendNotification(SendNotificationRequest request)
        {
            var response = new BaseResponse();

            try
            {
                var validator = new SendNotificationValidationRules(_notifier);
                validator.Validate(request);
                if (_notifier.hasNotifications()) return Responses.Failed(_notifier.GetNotifications());
                                                
                switch (request.NotificationType)
                {
                    case Persistence.Enums.NotificationTypeEnum.Instant:
                          var instantNotifications = SetInstantNotifications(request);
                          await _notificationRepo.AddNotifications(instantNotifications);                        
                        break;
                        case Persistence.Enums.NotificationTypeEnum.Scheduled:
                          var scheduledNotifications = SetScheduledNotification(request);
                          await _schedulingRepo.AddNotifications(scheduledNotifications);
                        break;
                }

                response.Message = Constants.SuccessResponse;
                response.IsSuccessful = true;
            }
            catch (Exception ex)
            {
                response.Message = Constants.ErrorResponse;
                ex.ToString();
            }

            return response;
        }

        private List<NotificationRequestLog> SetInstantNotifications(SendNotificationRequest model)
        {
            var notifications = new List<NotificationRequestLog>();
            if(model.Email is  not null) //set the email notification where the email object is not null
                notifications.Add(setEmailNotification(model.Email));
            if(model.Sms  is not null) // set the sms notification where sms object is not null
                notifications.Add(setSmsNotification(model.Sms));

            return notifications;
        }

        private List<ScheduledNotificationRequestLog> SetScheduledNotification(SendNotificationRequest model)
        {
            var notifications = new List<ScheduledNotificationRequestLog>();
            if (model.Email is not null)
            {
                notifications.Add(new ScheduledNotificationRequestLog
                {
                    CC = model.Email.CC,
                    ScheduleDateTime = model.ScheduleDateTime,
                    ScheduleFrequency = model.ScheduleFrequency,
                    Sender = model.Email.Sender,
                    Subject = model.Email.Subject,
                    ChannelType = Persistence.Enums.ChannelType.EMAIL,
                    Message = model.Email.Body,
                    Recipient = model.Email.Recepient
                });
            }

            if(model.Sms is not null)
            {
                notifications.Add(new ScheduledNotificationRequestLog
                {
                   ChannelType = Persistence.Enums.ChannelType.SMS,
                   Message = model.Sms.Body,
                  Recipient = model.Sms.Recipient,
                  ScheduleDateTime = model.ScheduleDateTime,
                  ScheduleFrequency= model.ScheduleFrequency,
                  Sender=model.Sms.Sender,
                  Subject = model.Sms.Subject,
                });
            }

            return notifications;
        }

        private NotificationRequestLog setEmailNotification(EmailRequestDto email) 
        {
            return new NotificationRequestLog
            {
                CC = email.CC ?? "",
                ChannelType = Persistence.Enums.ChannelType.EMAIL,
                Message = email.Body,
                Recipient = email.Recepient,
                Sender = email.Sender,
                Subject = email.Subject
            };
        }

        private NotificationRequestLog setSmsNotification(SmsRequestDto sms)
        {
            return new NotificationRequestLog
            {
                ChannelType = Persistence.Enums.ChannelType.EMAIL,
                Message = sms.Body,
                Recipient = sms.Recipient,
                Sender = sms.Sender,
                Subject = sms.Subject
            };
        }

    }
}
