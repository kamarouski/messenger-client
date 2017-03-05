using System.Collections.Generic;
using Newtonsoft.Json;

namespace Messenger.Client.Objects
{
    public class MessengerGenericElement : MessengerElement
    {
        [JsonProperty("default_action")]
        public MessengerButton DefaultAction { get; set; }

        public ICollection<MessengerButton> Buttons { get; set; }
    }
}
