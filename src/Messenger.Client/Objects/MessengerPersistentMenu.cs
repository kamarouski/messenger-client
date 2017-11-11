using System.Collections.Generic;
using Newtonsoft.Json;

namespace Messenger.Client.Objects
{
    public class MessengerPersistentMenu
    {
        public string Locale { get; set; } = "default";

        [JsonProperty("composer_input_disabled")]
        public bool ComponserInputDisabled { get; set; } = false;

        [JsonProperty("call_to_actions")]
        public ICollection<MessengerPersistentMenuItem> CallToActions { get; set; }
    }
}
