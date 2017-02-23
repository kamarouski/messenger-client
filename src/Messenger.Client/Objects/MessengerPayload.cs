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

        [JsonProperty("top_element_style")]
        public String TopElementStyle { get; set; }

        public ICollection<MessengerButton> Buttons { get; set; }

        public ICollection<MessengerElement> Elements { get; set; }

        public MessengerAddress Address { get; set; }

        public MessengerOrderSummary Summary { get; set; }

        public ICollection<MessengerOrderAdjustment> Adjustments { get; set; }

        [JsonProperty("recipient_type")]
        public String RecipientType { get; set; }

        [JsonProperty("recipient_name")]
        public String RecipientName { get; set; }

        [JsonProperty("order_number")]
        public String OrderNumber { get; set; }

        public String Currency { get; set; }

        [JsonProperty("payment_method")]
        public String PaymentMethod { get; set; }

        [JsonProperty("order_url")]
        public String OrderUrl { get; set; }

        public String Timestamp { get; set; }
    }
}