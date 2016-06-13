using System;
using System.Collections.Generic;

namespace Messenger.Client.Objects
{
    public class MessengerEntry
    {
        public String Id { get; set; }

        public long Time { get; set; }

        public ICollection<MessengerMessaging> Messaging { get; set; } = new List<MessengerMessaging>();
    }
}
