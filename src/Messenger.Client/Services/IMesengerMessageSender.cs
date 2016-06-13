using System.Threading.Tasks;
using Messenger.Client.Objects;

namespace Messenger.Client.Services
{
    public interface IMesengerMessageSender
    {
        Task<MessengerResponse> SendAsync(MessengerMessage message, MessengerUser recepient);
    }
}
