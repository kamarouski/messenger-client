using System.Collections.Generic;
using Messenger.Client.Objects.Enums;
using Newtonsoft.Json;

namespace Messenger.Client.Objects
{
    public class MessengerPersistentMenuItem
    {
        public string Title { get; set; }

        public MessengerPersistentMenuButtonType Type { get; set; }

        public string Payload { get; set; }

        public string Url { get; set; }

        [JsonProperty("webview_height_ratio")]
        public MessengerWebViewHeightRatio? WebViewHeightRatio { get; set; }

        [JsonProperty("messenger_extensions")]
        public bool? MessengerExtensions { get; set; }

        [JsonProperty("fallback_url")]
        public string FallbackUrl { get; set; }

        [JsonProperty("call_to_actions")]
        public ICollection<MessengerPersistentMenuItem> CallToActions { get; set; }
    }
}
