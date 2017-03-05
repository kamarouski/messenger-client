using System.Collections.Generic;
using Newtonsoft.Json;

namespace Messenger.Client.Objects
{
    public class MessengerPersistentMenuAction
    {
        public string Title { get; set; }

        public string Type { get; set; }

        public string Payload { get; set; }

        public string Url { get; set; }

        [JsonProperty("webview_height_ratio")]
        public string WebViewHeightRatio { get; set; }

        [JsonProperty("messenger_extensions")]
        public bool? MessengerExtensions { get; set; }

        [JsonProperty("fallback_url")]
        public string FallbackUrl { get; set; }

        [JsonProperty("webview_share_button")]
        public string WebviewShareButton { get; set; }

        [JsonProperty("call_to_actions")]
        public ICollection<MessengerPersistentMenuAction> CallToActions { get; set; }
    }
}
