using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Messenger.Client.Objects
{
    public class MessengerPayload
    {
        public String Url { get; set; }

        public String Text { get; set; }

        [JsonProperty("template_type")]
        public String TemplateType { get; set; }

        public ICollection<MessengerButton> Buttons { get; set; }

        public ICollection<MessengerElement> Elements { get; set; }

        public MessengerAddress Address { get; set; }

        public MessengerOrderSummary Summary { get; set; }

        public ICollection<MessengerOrderAdjustment> Adjustments { get; set; }
    }
}