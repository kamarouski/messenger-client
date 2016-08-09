using System;
using Newtonsoft.Json;

namespace Messenger.Client.Objects
{
    public class MessengerQuickReply
    {
        [JsonProperty("content_type")]
        public String ContentType { get; set; }

        public String Title { get; set; }

        public String Payload { get; set; }
    }
}
