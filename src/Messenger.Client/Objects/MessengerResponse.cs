using System;

namespace Messenger.Client.Objects
{
    public class MessengerResponse
    {
        public bool Succeed { get; set; } = true;

        public bool Failed => !Succeed;

        public String RawResponse { get; set; }
    }

    public class MessengerResponse<T> : MessengerResponse
    {
        public T Result { get; set; }
    }
}
