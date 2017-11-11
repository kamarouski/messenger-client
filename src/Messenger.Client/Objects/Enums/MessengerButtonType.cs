using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Messenger.Client.Objects.Enums
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum MessengerButtonType {
		[EnumMember(Value = "payment")]
		Payment,
		[EnumMember(Value = "phone_number")]
		PhoneNumber,
		[EnumMember(Value = "game_play")]
		GamePlay,
		[EnumMember(Value = "account_link")]
		AccountLink,
		[EnumMember(Value = "account_unlink")]
		AccountUnlink,
		[EnumMember(Value = "postback")]
		Postback,
		[EnumMember(Value = "element_share")]
		ElementShare,
		[EnumMember(Value = "web_url")]
		WebURL,
	}
}