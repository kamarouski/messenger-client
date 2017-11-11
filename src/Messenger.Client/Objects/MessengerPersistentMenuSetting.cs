using System;
using System.Collections.Generic;
using Messenger.Client.Objects.Enums;
using Newtonsoft.Json;

namespace Messenger.Client.Objects
{
    [Obsolete]
    public class MessengerPersistentMenuSetting : MessengerThreadSetting
    {
        public MessengerPersistentMenuSetting()
        {
            ThreadState = "existing_thread";
        }

        public override MessengerThreadSettingType SettingType => MessengerThreadSettingType.CallToActions;

        [JsonProperty("call_to_actions")]
        public ICollection<MessengerCallToAction> CallToActions { get; set; }

    }
}
