using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Messenger.Client.Objects
{
    public class MessengerOrderSummary
    {
        public decimal Subtotal { get; set; }

        [JsonProperty("shipping_cost")]
        public decimal ShippingCost { get; set; }

        [JsonProperty("total_tax")]
        public decimal TotalTax { get; set; }

        [JsonProperty("total_cost")]
        public decimal TotalCost { get; set; }
    }
}
