using System.Collections.Generic;
using Newtonsoft.Json;

namespace Messenger.Client.Objects
{
    public class MessengerThreadSetting
    {
        [JsonProperty("setting_type")]
        public string SettingType { get; set; }

        [JsonProperty("thread_state")]
        public string ThreadState { get; set; }

        [JsonProperty("call_to_actions")]
        public ICollection<MessengerCallToAction> CallToActions { get; set; }
    }
}
