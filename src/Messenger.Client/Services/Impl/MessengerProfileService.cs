using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Messenger.Client.Objects;
using Messenger.Client.Utilities;

namespace Messenger.Client.Services.Impl
{
    public class MessengerProfileService : MessengerServiceBase, IMessengerProfileService
    {
        private const string UrlTemplate = "https://graph.facebook.com/v2.6/me/messenger_profile?access_token={0}";


        public MessengerProfileService(IMessengerSerializer serializer) : base(serializer)
        {
        }

        public Task<MessengerResponse> SetMenu(string accessToken, params MessengerPersistentMenu[] menus)
        {
            var url = String.Format(UrlTemplate, accessToken);
            var request = new
            {
                persistent_menu = menus
            };

            return Post(url, request);
        }

        public async Task<MessengerPersistentMenu> GetMenu(string accessToken)
        {
            var data = await GetProfileData(accessToken, "persistent_menu");
            return data?.PersistentMenu;
        }

        public Task<MessengerResponse> DeleteMenu(string accessToken)
        {
            return DeleteField(accessToken, "persistent_menu");
        }

        public Task<MessengerResponse> SetGetStartedButton(string accessToken, string payload)
        {
            var url = String.Format(UrlTemplate, accessToken);

            var data = new
            {
                get_started = new {payload}
            };

            return Post(url, data);
        }

        public async Task<MessengerGetStarted> GetGetStartedPayload(string accessToken)
        {
            var data = await GetProfileData(accessToken, "get_started");
            return data?.GetStarted;
        }

        public Task<MessengerResponse> DeleteGetStarted(string accessToken)
        {
            return DeleteField(accessToken, "get_started");
        }

        public Task<MessengerResponse> SetGreetingText(string accessToken, params MessengerGreetingText[] texts)
        {
            var url = String.Format(UrlTemplate, accessToken);

            var data = new
            {
                greeting = texts
            };

            return Post(url, data);
        }

        public async Task<ICollection<MessengerGreetingText>> GetGreetingTexts(string accessToken)
        {
            var data = await GetProfileData(accessToken, "get_started");
            return data?.Greeting ?? new List<MessengerGreetingText>();
        }

        public Task<MessengerResponse> DeleteGreetingText(string accessToken)
        {
            return DeleteField(accessToken, "greeting");
        }

        public Task<MessengerResponse> WhitelistDomains(string accessToken, params string[] domains)
        {
            var url = String.Format(UrlTemplate, accessToken);

            var data = new
            {
                whitelisted_domains = domains
            };

            return Post(url, data);
        }

        private async Task<MessengerProfileData> GetProfileData(string accessToken, string field)
        {
            var url = $"{String.Format(UrlTemplate, accessToken)}&fields={field}";

            var response = await Get<MessengerProfileResponse>(url);
            if (response.Failed || response.Result.Data == null || !response.Result.Data.Any())
            {
                return null;
            }

            return response.Result.Data.First();
        }

        private Task<MessengerResponse> DeleteField(string accessToken, string field)
        {
            var url = String.Format(UrlTemplate, accessToken);
            var request = new
            {
                fields = new[] {field}
            };

            return Delete(url, request);
        }
    }
}
