using Messenger.Client.Objects.Enums;


namespace Messenger.Client.Objects
{
    public class MessengerGreetingTextSetting : MessengerThreadSetting
    {
        public override MessengerThreadSettingType SettingType => MessengerThreadSettingType.Greeting;

        public MessengerGreeting Greeting { get; set; }
    }
}
