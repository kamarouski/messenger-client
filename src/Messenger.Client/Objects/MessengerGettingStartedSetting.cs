using System.Collections.Generic;
using Newtonsoft.Json;

namespace Messenger.Client.Objects
{
    public class MessengerGettingStartedSetting : MessengerThreadSetting
    {
        public MessengerGettingStartedSetting()
        {
            ThreadState = "new_thread";
        }

        public override string SettingType => "call_to_actions";

        [JsonProperty("call_to_actions")]
        public ICollection<MessengerPayloadCallToAction> CallToActions { get; set; }

    }
}
