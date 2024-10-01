using Unify.Application.Common;

namespace Unify.Application.Validators
{
    public class SendNotificationValidation: AbstractNotifcator
    {
        private readonly Notifier _notifier;

        public SendNotificationValidation(Notifier notifier)
        {
            _notifier = notifier;   
        }

        public override T ValidateAsync<T>(T model)
        {
            throw new NotImplementedException();
        }
    }
}
