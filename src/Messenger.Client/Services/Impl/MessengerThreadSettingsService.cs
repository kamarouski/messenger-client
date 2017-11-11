using System.Collections.Generic;
using System.Threading.Tasks;
using Messenger.Client.Objects;
using Messenger.Client.Objects.Enums;
using Messenger.Client.Utilities;

namespace Messenger.Client.Services.Impl
{
    public class MessengerThreadSettingsService : IMessengerThreadSettingsService
    {
        private readonly IMessengerRestClient restClient;

        public MessengerThreadSettingsService(IMessengerRestClient restClient)
        {
            this.restClient = restClient;
        }

        public async Task<MessengerResponse<string>>  Save(MessengerThreadSetting setting, string accessToken)
        {
            var url = $"https://graph.facebook.com/v2.6/me/thread_settings?access_token={accessToken}";
            var response = await restClient.Post<string, MessengerThreadSetting>(url, setting);

            if (response.Failed)
            {
                return new MessengerResponse<string>
                {
                    Succeed = false,
                    RawResponse = response.RawResponse
                };
            }

            return new MessengerResponse<string>
            {
                RawResponse = response.RawResponse,
                Result = response.Result
            };
        }

        public Task<MessengerResponse<string>> WhitelistDomains(IEnumerable<string> domains, string accessToken)
        {
            var setting = new MessengerDomainWhitelistingSetting
            {
                DomainActionType = MessengerDomainActionType.Add,
                WhitelistedDomains = new List<string>(domains)
            };

            return Save(setting, accessToken);
        }
    }
}
