using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Messenger.Client.Objects
{
    public class MessengerDomainWhitelistingSetting : MessengerThreadSetting
    {
        public override string SettingType => "domain_whitelisting";

        [JsonProperty("whitelisted_domains")]
        public ICollection<string> WhitelistedDomains { get; set; }

        [JsonProperty("domain_action_type")]
        public string DomainActionType { get; set; }
    }
}
