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
        public async Task<BaseResponse> SendNotification(SendNotificationRequest request, CancellationToken cancellationToken)
        {
            var response = new BaseResponse();

            try
            {
                var validator = new SendNotificationValidator();
                var validationResult = await validator.ValidateAsync(request, cancellationToken);
                if (validationResult.Errors.Any()) throw new ValidationException(validationResult);


                response.Message = Constants.SuccessResponse;
                response.IsSuccessful = true;
            }
            catch(ValidationException vEx)
            {
                response.Message = vEx.Message;
            }
            catch (Exception ex)
            {
                response.Message = Constants.ErrorResponse;
            }

            return response;
        }
    }
}
