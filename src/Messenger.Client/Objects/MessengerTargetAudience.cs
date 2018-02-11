using System.Collections.Generic;
using Messenger.Client.Objects.Enums;
using Newtonsoft.Json;


namespace Messenger.Client.Objects {
	public class MessengerTargetAudience
	{
		[JsonProperty("audience_type")]
		public MessengerTargetAudienceType AudienceType { get; set; }
		public MessengerTargetAudienceCountries Countries { get; set; }
	}
}
