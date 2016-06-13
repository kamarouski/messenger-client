using System;

namespace Messenger.Client.Objects
{
    public class MessengerReceiptElement : MessengerElement
    {
        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public String Currency { get; set; }
    }
}
