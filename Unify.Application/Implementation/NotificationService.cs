using Unify.Application.Common;
using Unify.Application.Exceptions;
using Unify.Application.Interface;
using Unify.Application.Requests;
using Unify.Application.Validators;
using Unify.Application.ViewModel;

namespace Unify.Application.Implementation
{
    public class NotificationService : INotificationService
    {
        private readonly Notifier _notifier;

        public NotificationService(Notifier notifier)
        {
            _notifier = notifier;
        }

        public async Task<BaseResponse> SendNotification(SendNotificationRequest request)
        {
            var response = new BaseResponse();

            try
            {
                var validator = new SendNotificationValidationRules(_notifier);
                validator.Validate(request);
                if (_notifier.hasNotifications()) return Responses.Failed(_notifier.GetNotifications());



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
    }
}
