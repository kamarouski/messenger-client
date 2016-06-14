using Messenger.Client.Objects;

namespace Messenger.Client.Services.Impl
{
    internal class MessengerSendMessageRequest
    {
        public MessengerUser Recipient { get; set; }

        public MessengerMessage Message { get; set; }
    }
}
