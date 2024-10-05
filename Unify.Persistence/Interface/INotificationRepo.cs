using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unify.Persistence.Models;

namespace Unify.Persistence.Interface
{
    public interface INotificationRepo
    {
        Task AddNotification(NotificationRequestLog notifications);
        Task AddNotifications(List<NotificationRequestLog> notifications);
    }
}
