using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Messenger.Client.Objects
{
    public class MessengerMessage
    {
        public String Mid { get; set; }

        public int Seq { get; set; }

        public String Text { get; set; }

        public ICollection<MessengerAttachment> Attachments { get; set; }

    }
}
