using System;
using System.Collections.Generic;

namespace Messenger.Client.Objects
{
    public class MessengerDelivery
    {
        public ICollection<String> Mids { get; set; } = new List<string>();

        public long Watermark { get; set; }

        public int Seq { get; set; }
    }
}