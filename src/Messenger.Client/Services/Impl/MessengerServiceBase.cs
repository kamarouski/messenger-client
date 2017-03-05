using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Messenger.Client.Objects;
using Messenger.Client.Utilities;

namespace Messenger.Client.Services.Impl
{
    public abstract class MessengerServiceBase
    {
        private readonly HttpClient client;
        private readonly IMessengerSerializer serializer;

        protected MessengerServiceBase(IMessengerSerializer serializer)
        {
            this.client = new HttpClient();
            this.serializer = serializer;
        }

        protected HttpClient Client => client;

        protected async Task<MessengerResponse> Post(string url, object data)
        {
            var content = new StringContent(serializer.Serialize(data));
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var httpResponse = await client.PostAsync(url, content);

            var response = new MessengerResponse();
            response.Succeed = httpResponse.IsSuccessStatusCode;
            response.RawResponse = await httpResponse.Content.ReadAsStringAsync();

            return response;
        }

        protected async Task<MessengerResponse<T>> Get<T>(string url)
        {
            var httpResponse = await client.GetAsync(url);

            var result = new MessengerResponse<T>();
            result.Succeed = httpResponse.IsSuccessStatusCode;
            result.RawResponse = await httpResponse.Content.ReadAsStringAsync();

            if (result.Succeed)
            {
                result.Result = serializer.Deserialize<T>(result.RawResponse);
            }

            return result;
        }

        protected async Task<MessengerResponse> Delete(string url, object data)
        {
            var content = new StringContent(serializer.Serialize(data));
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var message = new HttpRequestMessage();
            message.RequestUri = new Uri(url);
            message.Method = HttpMethod.Delete;
            message.Content = content;
            var httpResponse = await client.SendAsync(message);

            var response = new MessengerResponse();
            response.Succeed = httpResponse.IsSuccessStatusCode;
            response.RawResponse = await httpResponse.Content.ReadAsStringAsync();

            return response;
        }
    }
}
