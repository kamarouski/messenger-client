using System.Threading.Tasks;
using Messenger.Client.Objects;

namespace Messenger.Client.Utilities
{
    public interface IMessengerRestClient
    {
        Task<MessengerResponse<TResponse>> Post<TResponse, TRequest>(string url, TRequest data);
    }
}
