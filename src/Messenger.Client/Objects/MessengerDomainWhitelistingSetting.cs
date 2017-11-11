using System.Collections.Generic;
using Messenger.Client.Objects.Enums;
using Newtonsoft.Json;

namespace Messenger.Client.Objects
{
    public class MessengerDomainWhitelistingSetting : MessengerThreadSetting
    {
        public override MessengerThreadSettingType SettingType => MessengerThreadSettingType.DomainWhitelisting;

        [JsonProperty("whitelisted_domains")]
        public ICollection<string> WhitelistedDomains { get; set; }

        [JsonProperty("domain_action_type")]
        public MessengerDomainActionType DomainActionType { get; set; }
    }
}
