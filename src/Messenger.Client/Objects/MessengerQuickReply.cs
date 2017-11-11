using System;
using Messenger.Client.Objects.Enums;
using Newtonsoft.Json;

namespace Messenger.Client.Objects
{
    public class MessengerQuickReply
    {
        [JsonProperty("content_type")]
        public MessengerQuickReplyContentType ContentType { get; set; }

        public String Title { get; set; }

        public String Payload { get; set; }
    }
}
