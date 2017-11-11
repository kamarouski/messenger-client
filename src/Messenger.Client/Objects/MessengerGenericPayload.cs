using System.Collections.Generic;
using Messenger.Client.Objects.Enums;

namespace Messenger.Client.Objects
{
    public class MessengerGenericPayload : MessengerPayload
    {
        public ICollection<MessengerElement> Elements { get; set; }

        public override MessengerTemplateType TemplateType => MessengerTemplateType.Generic;
    }
}
