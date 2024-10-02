using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Unify.Application.Interface;
using Unify.Application.Requests;

namespace Unify.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        private readonly INotificationService _notificationService;

        public NotificationController(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        [HttpPost("send-notification")]
        public async Task<IActionResult> SendNotification(SendNotificationRequest model)
        {
            var result = await _notificationService.SendNotification(model);
            if(result.IsSuccessful) 
                return Ok(result);

            return BadRequest(result.Message);
        }

    }
}
