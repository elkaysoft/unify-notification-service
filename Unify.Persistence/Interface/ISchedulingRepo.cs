using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unify.Persistence.Models;

namespace Unify.Persistence.Interface
{
    public interface ISchedulingRepo
    {
        Task AddNotification(ScheduledNotificationRequestLog model);
        Task AddNotifications(List<ScheduledNotificationRequestLog> model);
    }
}
