using System;
using Newtonsoft.Json;

namespace Messenger.Client.Objects
{
    public abstract class MessengerElement
    {
        public String Title { get; set; }

        [JsonProperty("image_url")]
        public String ImageUrl { get; set; }

        public String Subtitle { get; set; }
    }
}
