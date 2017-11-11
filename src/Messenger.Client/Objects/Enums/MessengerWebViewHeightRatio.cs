using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Messenger.Client.Objects.Enums
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum MessengerWebViewHeightRatio
	{
		[EnumMember(Value = "compact")]
		Compact,
		[EnumMember(Value = "tall")]
		Tall,
		[EnumMember(Value = "full")]
		Full,
	}
}