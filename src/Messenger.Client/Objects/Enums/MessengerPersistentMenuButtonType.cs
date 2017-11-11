using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Messenger.Client.Objects.Enums
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum MessengerPersistentMenuButtonType
	{
		[EnumMember(Value = "postback")]
		Postback,
		[EnumMember(Value = "web_url")]
		WebURL,
		[EnumMember(Value = "nested")]
		Nested,
	}
}
