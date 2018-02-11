using System.Runtime.Serialization;


namespace Messenger.Client.Objects.Enums {
	public enum MessengerTargetAudienceType
	{
		[EnumMember(Value = "all")]
		All,
		[EnumMember(Value = "custom")]
		Custom,
		[EnumMember(Value = "none")]
		None,
	}
}
