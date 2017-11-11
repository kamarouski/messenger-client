using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Messenger.Client.Objects.Enums
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum MessengerTopElementStyle {
		[EnumMember(Value = "compact")]
		Compact,
		[EnumMember(Value = "large")]
		Large,
	}
}