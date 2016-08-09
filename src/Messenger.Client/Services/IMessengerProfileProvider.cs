using System;
using System.Threading.Tasks;
using Messenger.Client.Objects;

namespace Messenger.Client.Services
{
    public interface IMessengerProfileProvider
    {
        Task<MessengerResponse<MessengerUserProfile>> GetUserProfileAsync(String userId, String accessToken = null);
    }
}
