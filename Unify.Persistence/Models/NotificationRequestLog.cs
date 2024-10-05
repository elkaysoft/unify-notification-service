using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unify.Persistence.Enums;

namespace Unify.Persistence.Models
{
    public class NotificationRequestLog
    {
        public string Subject { get; set; } = string.Empty;
        public string Recipient { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
        public string Sender { get; set; } = string.Empty;
        public ChannelType ChannelType { get; set; }
        public string CC { get; set; }
    }
}
