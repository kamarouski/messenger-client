using System.Collections.Generic;

namespace Messenger.Client.Objects
{
    public class MessengerGenericPayload : MessengerPayload
    {
        public ICollection<MessengerElement> Elements { get; set; }

        public override string TemplateType => MessengerTemplateType.Generic;
    }
}
