using System.Collections.Generic;

namespace Messenger.Client.Objects
{
    internal class MessengerProfileResponse
    {
        public ICollection<MessengerProfileData> Data { get; set; } = new List<MessengerProfileData>();
    }
}
