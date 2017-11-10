using System;
using System.Threading.Tasks;
using Messenger.Client.Objects;

namespace Messenger.Client.Services
{
    public interface IMessengerMessageSender
    {
        Task<MessengerResponse> SendAsync(MessengerMessage message, MessengerUser recipient);

        Task<MessengerResponse> SendAsync(MessengerMessage message, MessengerUser recipient, String accessToken);

        Task<MessengerResponse> SetSenderActionAsync(MessengerSenderAction senderAction, MessengerUser recipient);
        
        Task<MessengerResponse> SetSenderActionAsync(MessengerSenderAction senderAction, MessengerUser recipient, String accessToken);
    }
}
