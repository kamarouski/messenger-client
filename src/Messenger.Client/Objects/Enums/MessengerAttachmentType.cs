using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Messenger.Client.Objects.Enums
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum MessengerAttachmentType
	{
		[EnumMember(Value = "image")]
		Image,
		[EnumMember(Value = "video")]
		Video,
		[EnumMember(Value = "audio")]
		Audio,
		[EnumMember(Value = "file")]
		File,
		[EnumMember(Value = "template")]
		Template,
	}
}
