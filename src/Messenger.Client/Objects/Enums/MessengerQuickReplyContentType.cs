using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Messenger.Client.Objects.Enums
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum MessengerQuickReplyContentType {
		[EnumMember(Value = "text")]
		Text,
		[EnumMember(Value = "location")]
		Location,
	}
}