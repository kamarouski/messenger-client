using System.Collections.Generic;
using Newtonsoft.Json;

namespace Messenger.Client.Objects
{
    public class MessengerPersistentMenuSetting : MessengerThreadSetting
    {
        public MessengerPersistentMenuSetting()
        {
            ThreadState = "existing_thread";
        }

        public override string SettingType => "call_to_actions";

        [JsonProperty("call_to_actions")]
        public ICollection<MessengerCallToAction> CallToActions { get; set; }

    }
}
