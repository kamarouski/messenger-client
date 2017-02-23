using System.Collections.Generic;
using Newtonsoft.Json;

namespace Messenger.Client.Objects
{
    public class MessengerListPayload : MessengerPayload
    {
        public ICollection<MessengerListElement> Elements { get; set; }

        public ICollection<MessengerButton> Buttons { get; set; }

        public override string TemplateType => MessengerTemplateType.List;

        [JsonProperty("top_element_style")]
        public string TopElementStyle { get; set; }
    }
}
