using Messenger.Client.Objects.Enums;
using Newtonsoft.Json;


namespace Messenger.Client.Objects {
	public class MessengerHomeURL
	{
		[JsonProperty("url")]
		public string URL { get; set; }
		
		[JsonProperty("webview_height_ratio")]
		public MessengerWebViewHeightRatio WebviewHeightRatio = MessengerWebViewHeightRatio.Tall;
		
		[JsonProperty("webview_share_button")]
		public MessengerShareButtonVisibility? WebviewShareButton { get; set; }

		[JsonProperty("in_test")]
		public bool InTest { get; set; }
	}
}
