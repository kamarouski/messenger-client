using System.Collections.Generic;


namespace Messenger.Client.Objects {
	public class MessengerTargetAudienceCountries
	{
		public IEnumerable<string> Whitelist { get; set; }
		public IEnumerable<string> Blacklist { get; set; }
	}
}
