namespace Messenger.Client.Objects
{
    public class MessengerGreetingTextSetting : MessengerThreadSetting
    {
        public override string SettingType => "greeting";

        public MessengerGreeting Greeting { get; set; }
    }
}
