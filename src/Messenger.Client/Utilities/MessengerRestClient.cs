using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Messenger.Client.Objects;

namespace Messenger.Client.Utilities
{
    public class MessengerRestClient : IMessengerRestClient
    {
        private readonly HttpClient client = new HttpClient();
        private readonly IMessengerSerializer serializer;

        public MessengerRestClient(IMessengerSerializer serializer)
        {
            this.serializer = serializer;
        }

        public async Task<MessengerResponse<TResponse>> Post<TResponse, TRequest>(string url, TRequest data)
        {
            var content = new StringContent(serializer.Serialize(data));
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var response = await client.PostAsync(url, content);

            var result = new MessengerResponse<TResponse>();
            result.RawResponse = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                result.Succeed = false;
                return result;
            }

            if (typeof(TResponse) == typeof(string))
            {
                object raw = result.RawResponse;
                result.Result = (TResponse)raw;
            }
            else
            {
                result.Result = serializer.Deserialize<TResponse>(result.RawResponse);
            }

            return result;
        }
    }
}
