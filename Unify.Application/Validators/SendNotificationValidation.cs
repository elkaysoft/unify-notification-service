using Unify.Application.Common;
using Unify.Application.Requests;

namespace Unify.Application.Validators
{
    public class SendNotificationValidation: AbstractNotifcator
    {
        private readonly Notifier _notifier;

        public SendNotificationValidation(Notifier notifier)
        {
            _notifier = notifier;   
        }

        public override TResponse ValidateAsync<TResponse>(SendNotificationRequest model)
        {
            
        }
    }
}
