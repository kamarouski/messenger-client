using Messenger.Client.Objects.Enums;
using Newtonsoft.Json;

namespace Messenger.Client.Objects
{
    public abstract class MessengerThreadSetting
    {
        [JsonProperty("setting_type")]
        public abstract MessengerThreadSettingType SettingType { get; }

        [JsonProperty("thread_state")]
        public string ThreadState { get; set; }
    }
}
