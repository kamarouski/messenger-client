using Messenger.Client.Objects;
using Newtonsoft.Json;


namespace Messenger.Client.Services.Impl
{
    internal class MessengerSenderActionRequest
    {
        public MessengerUser Recipient { get; set; }
        
        [JsonProperty( "sender_action" )]
        public MessengerSenderAction SenderAction { get; set; }
    }
}