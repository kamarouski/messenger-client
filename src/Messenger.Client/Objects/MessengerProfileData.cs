using System.Collections.Generic;
using Newtonsoft.Json;

namespace Messenger.Client.Objects
{
    public class MessengerProfileData
    {
        [JsonProperty("persistent_menu")]
        public MessengerPersistentMenu PersistentMenu { get; set; }

        [JsonProperty("get_started")]
        public MessengerGetStarted GetStarted { get; set; }

        public ICollection<MessengerGreetingText> Greeting { get; set; }
    }
}
