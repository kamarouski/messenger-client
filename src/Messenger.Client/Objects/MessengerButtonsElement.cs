using System.Collections.Generic;

namespace Messenger.Client.Objects
{
    public class MessengerButtonsElement : MessengerElement
    {
        public ICollection<MessengerButton> Buttons { get; set; } = new List<MessengerButton>();
    }
}
