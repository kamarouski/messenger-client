using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Messenger.Client.Objects
{
    public class MessengerReceiptPayload : MessengerPayload
    {
        public override MessengerTemplateType TemplateType => MessengerTemplateType.Receipt;

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

        public MessengerAddress Address { get; set; }

        public MessengerOrderSummary Summary { get; set; }

        public ICollection<MessengerOrderAdjustment> Adjustments { get; set; }

        public ICollection<MessengerReceiptElement> Elements { get; set; }
    }
}
