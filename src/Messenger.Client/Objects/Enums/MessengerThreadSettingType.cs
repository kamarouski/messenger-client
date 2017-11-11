using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Messenger.Client.Objects.Enums
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum MessengerThreadSettingType {
		[EnumMember(Value = "domain_whitelisting")]
		DomainWhitelisting,
		[EnumMember(Value = "greeting")]
		Greeting,
		[EnumMember(Value = "call_to_actions")]
		CallToActions,
	}
}