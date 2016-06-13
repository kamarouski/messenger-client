using System;

namespace Messenger.Client.Objects
{
    public class MessengerResponse
    {
        public bool Succeed { get; set; } = true;

        public String RawResponse { get; set; }
    }
}
