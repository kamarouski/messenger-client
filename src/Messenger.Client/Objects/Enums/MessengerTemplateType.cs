using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Messenger.Client.Objects
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MessengerTemplateType
    {
        [EnumMember(Value = "airline_boardingpass")]
        AirlineBoardingPass,
        [EnumMember(Value = "airline_checkin")]
        AirlineCheckin,
        [EnumMember(Value = "airline_itinerary")]
        AirlineItiniery,
        [EnumMember(Value = "airline_update")]
        AirlineFlightUpdate,
        [EnumMember(Value = "button")]
        Button,
        [EnumMember(Value = "generic")]
        Generic,
        [EnumMember(Value = "list")]
        List,
        [EnumMember(Value = "receipt")]
        Receipt,
    }
}
