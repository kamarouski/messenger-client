using System;
using Newtonsoft.Json;

namespace Messenger.Client.Objects
{
    public class MessengerAddress
    {
        [JsonProperty("street_1")]
        public String Street1 { get; set; }

        [JsonProperty("street_2")]
        public String Street2 { get; set; }

        public String City { get; set; }

        [JsonProperty("postal_code")]
        public String PostalCode { get; set; }

        public String State { get; set; }

        public String Country { get; set; }
    }
}
