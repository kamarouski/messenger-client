using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Messenger.Client.Objects
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum MessengerShareButtonVisibility
	{
		[EnumMember(Value = "show")]
		Show,
		[EnumMember(Value = "hide")]
		Hide,
	}
}