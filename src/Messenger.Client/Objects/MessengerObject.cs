using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Messenger.Client.Objects
{
    public class MessengerObject
    {
        public String Object { get; set; }

        [JsonProperty("entry")]
        public ICollection<MessengerEntry> Entries { get; set; } = new List<MessengerEntry>();
    }
}