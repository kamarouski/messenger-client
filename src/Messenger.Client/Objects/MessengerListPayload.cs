using System.Collections.Generic;
using Messenger.Client.Objects.Enums;
using Newtonsoft.Json;

namespace Messenger.Client.Objects
{
    public class MessengerListPayload : MessengerPayload
    {
        public ICollection<MessengerListElement> Elements { get; set; }

        public ICollection<MessengerButton> Buttons { get; set; }

        public override MessengerTemplateType TemplateType => MessengerTemplateType.List;

        [JsonProperty("top_element_style")]
        public MessengerTopElementStyle TopElementStyle { get; set; }
    }
}
