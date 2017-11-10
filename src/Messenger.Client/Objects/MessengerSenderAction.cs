using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Messenger.Client.Objects
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MessengerSenderAction
    {
        [EnumMember(Value = "mark_seen")]
        MarkSeen,
        [EnumMember(Value = "typiong_on")]
        TypingOn,
        [EnumMember(Value = "typing_off")]
        TypingOff,
    }
}