using System;
using System.Collections.Generic;
using System.Text;

namespace Messenger.Client.Objects
{
    public class MessengerButtonsPayload : MessengerPayload
    {
        public String Text { get; set; }

        public ICollection<MessengerButton> Buttons { get; set; }

        public override string TemplateType => MessengerTemplateType.Button;
    }
}
