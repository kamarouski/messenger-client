using System;
using System.Collections.Generic;

namespace Messenger.Client.Objects
{
    public class MessengerButtonsPayload : MessengerPayload
    {
        public String Text { get; set; }

        public ICollection<MessengerButton> Buttons { get; set; }

        public override MessengerTemplateType TemplateType => MessengerTemplateType.Button;
    }
}
