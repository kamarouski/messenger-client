using System;
using Newtonsoft.Json;

namespace Messenger.Client.Objects
{
    public class MessengerUserProfile
    {
        public String Id { get; set; }

        public String About { get; set; }

        public String Bio { get; set; }

        public String Birthday { get; set; }

        public String Email { get; set; }

        public String Gender { get; set; }

        [JsonProperty("first_name")]
        public String FirstName { get; set; }

        [JsonProperty("last_name")]
        public String LastName { get; set; }

        public String Website { get; set; }

        [JsonProperty("profile_pic")]
        public String ProfilePicture { get; set; }
    }
}
