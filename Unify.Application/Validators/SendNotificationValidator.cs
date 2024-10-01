using FluentValidation;
using Unify.Application.Requests;

namespace Unify.Application.Validators
{
    public class SendNotificationValidator: AbstractValidator<SendNotificationRequest>
    {
        public SendNotificationValidator()
        {
            RuleFor(x => x.NotificationType).NotNull().NotEmpty().WithMessage("Notification type is required");
            RuleFor(x => x.Email).Must(isValidEmailObject);
            RuleFor(x => x.Sms).Must(isSmsObjectValid);

        }

        private bool isValidEmailObject(EmailRequestDto model)
        {
            if(model != null)
            {
                RuleFor(x => x.Email.Recepient).NotEmpty().NotNull().WithMessage("Email recipient(s) is required");
                RuleFor(x => x.Email.Sender).NotEmpty().NotNull().WithMessage("Email Sender is required");
                RuleFor(x => x.Email.Body).NotEmpty().NotNull().WithMessage("Email content is required");
                RuleFor(x => x.Email.Subject).NotNull().WithMessage("Email subject is required");
            }

            return true;
        }

        private bool isSmsObjectValid(SmsRequestDto model)
        {
            if(model != null)
            {
                RuleFor(x => x.Sms.Sender).NotEmpty().NotNull().WithMessage("Sms sender is required");
                RuleFor(x => x.Sms.Recipient).NotEmpty().NotNull().WithMessage("Sms recipient is required");
                RuleFor(x => x.Sms.Subject).NotEmpty().NotNull().WithMessage("Sms subject is required");
                RuleFor(x => x.Sms.Body).NotEmpty().NotNull().WithMessage("Sms body is required");
            }

            return true;
        }

    }
}
