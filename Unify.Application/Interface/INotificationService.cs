using Unify.Application.Requests;
using Unify.Application.ViewModel;

namespace Unify.Application.Interface
{
    public interface INotificationService
    {
        Task<BaseResponse> SendNotification(SendNotificationRequest request);
    }
}
