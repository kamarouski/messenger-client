using System;
using Newtonsoft.Json;

namespace Messenger.Client.Objects
{
    public class MessengerButton
    {
        public String Type { get; set; }

        public String Url { get; set; }

        public String Title { get; set; }

        public String Payload { get; set; }

        [JsonProperty("webview_height_ratio")]
        public string WebviewHeightRatio { get; set; }

        [JsonProperty("messenger_extensions")]
        public bool? MessengerExtensions { get; set; }
    }
}
