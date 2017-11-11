using System;
using Messenger.Client.Objects.Enums;
using Newtonsoft.Json;

namespace Messenger.Client.Objects
{
    public class MessengerButton
    {
        public MessengerButtonType Type { get; set; }

        public String Url { get; set; }

        public String Title { get; set; }

        public String Payload { get; set; }

        [JsonProperty("webview_height_ratio")]
        public MessengerWebViewHeightRatio? WebviewHeightRatio { get; set; }

        [JsonProperty("messenger_extensions")]
        public bool? MessengerExtensions { get; set; }

        [JsonProperty("fallback_url")]
        public string FallbackUrl { get; set; }
    }
}
