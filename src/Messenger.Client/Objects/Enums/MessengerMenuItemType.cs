using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Messenger.Client.Objects.Enums
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum MessengerMenuItemType {
		[EnumMember(Value = "web_url")]
		WebURL,
		[EnumMember(Value = "postback")]
		Postback,
		[EnumMember(Value = "nested")]
		Nested,
	}
}