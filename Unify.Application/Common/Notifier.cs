using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unify.Application.Common
{
    public class Notifier
    {
        private  List<Notification> _notifications { get; set; }

        public Notifier()
        {
            _notifications = new List<Notification>();
        }

        public void AddNotification(string property, string message)
        {
            _notifications.Add(new Notification(property, message));
        }

        public void AddNotification(Notification notification)
        {
            _notifications.Add(notification);
        }

        public void AddNotifications(IEnumerable<Notification> notifications)
        {
            _notifications.AddRange(notifications);
        }
       
        public string GetNotifications() => string.Join(',', _notifications.Select(x => x.Message).ToList());

        public bool hasNotifications() => _notifications.Any();

    }
}
