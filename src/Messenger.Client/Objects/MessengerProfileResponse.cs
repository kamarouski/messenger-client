using System;
using System.Collections.Generic;
using System.Text;

namespace Messenger.Client.Objects
{
    internal class MessengerProfileResponse
    {
        public ICollection<MessengerProfileData> Data { get; set; } = new List<MessengerProfileData>();
    }
}
