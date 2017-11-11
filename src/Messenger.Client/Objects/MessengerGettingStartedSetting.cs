using System.Collections.Generic;
using Messenger.Client.Objects.Enums;
using Newtonsoft.Json;

namespace Messenger.Client.Objects
{
    public class MessengerGettingStartedSetting : MessengerThreadSetting
    {
        public MessengerGettingStartedSetting()
        {
            ThreadState = "new_thread";
        }

        public override MessengerThreadSettingType SettingType => MessengerThreadSettingType.CallToActions;

        [JsonProperty("call_to_actions")]
        public ICollection<MessengerPayloadCallToAction> CallToActions { get; set; }

    }
}
