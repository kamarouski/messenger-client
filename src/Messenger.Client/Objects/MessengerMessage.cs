using System;

namespace Messenger.Client.Objects
{
    public class MessengerMessage
    {
        public String Mid { get; set; }

        public int? Seq { get; set; } = null;

        public String Text { get; set; }

        public MessengerAttachment Attachment { get; set; }

    }
}
