using System;
using System.Net.Http;
using System.Threading.Tasks;
using Messenger.Client.Config;
using Messenger.Client.Errors;
using Messenger.Client.Objects;
using Messenger.Client.Utilities;

namespace Messenger.Client.Services.Impl
{
    public class MessengerMessageSender : IMesengerMessageSender
    {
        private const String UrlTemplate = "https://graph.facebook.com/v2.6/me/messages?access_token={0}";

        private readonly HttpClient client;
        private readonly IMessengerSerializer serializer;

        public MessengerMessageSender(HttpClient client, IMessengerSerializer serializer)
        {
            this.client = client;
            this.serializer = serializer;
        }

        public async Task<MessengerResponse> SendAsync(MessengerMessage message, MessengerUser recepient)
        {
            var url = String.Format(UrlTemplate, MessengerConfig.AccessToken);
            var request = new {recepient, message};

            var content = new StringContent(serializer.Serialize(request));
            try
            {
                var response = await client.PostAsync(url, content);
                var result = new MessengerResponse
                {
                    Succeed = response.IsSuccessStatusCode,
                    RawResponse = await response.Content.ReadAsStringAsync()
                };

                return result;
            }
            catch (Exception exc)
            {
                throw new MessengerException(exc);
            }
        }
    }
}
