using System;
using System.Net.Http;
using System.Threading.Tasks;
using Messenger.Client.Config;
using Messenger.Client.Objects;
using Messenger.Client.Utilities;

namespace Messenger.Client.Services.Impl
{
    public class MessengerProfileProvider : IMessengerProfileProvider
    {
        private const String UrlTemplate = "https://graph.facebook.com/v2.6/{0}?access_token={1}";

        private readonly HttpClient client = new HttpClient();
        private readonly IMessengerSerializer serializer;

        public MessengerProfileProvider(IMessengerSerializer serializer)
        {
            this.serializer = serializer;
        }

        public async Task<MessengerResponse<MessengerUserProfile>> GetUserProfileAsync(string userId, string accessToken = null)
        {
            var token = accessToken ?? MessengerConfig.AccessToken;
            var url = String.Format(UrlTemplate, userId, token);

            var httpResponse = await client.GetAsync(url);
            var response = new MessengerResponse<MessengerUserProfile>();
            response.Succeed = httpResponse.IsSuccessStatusCode;

            var content = await httpResponse.Content.ReadAsStringAsync();
            response.RawResponse = content;

            if (httpResponse.IsSuccessStatusCode)
            {
                response.Result = serializer.Deserialize<MessengerUserProfile>(content);
            }

            return response;
        }
    }
}
