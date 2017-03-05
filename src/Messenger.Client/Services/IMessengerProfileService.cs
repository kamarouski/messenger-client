using System.Collections.Generic;
using System.Threading.Tasks;
using Messenger.Client.Objects;

namespace Messenger.Client.Services
{
    public interface IMessengerProfileService
    {
        Task<MessengerResponse> SetMenu(string accessToken, params MessengerPersistentMenu[] menus);

        Task<MessengerPersistentMenu> GetMenu(string accessToken);

        Task<MessengerResponse> DeleteMenu(string accessToken);

        Task<MessengerResponse> SetGetStartedButton(string accessToken, string payload);

        Task<MessengerGetStarted> GetGetStartedPayload(string accessToken);

        Task<MessengerResponse> DeleteGetStarted(string accessToken);

        Task<MessengerResponse> SetGreetingText(string accessToken, params MessengerGreetingText[] texts);

        Task<ICollection<MessengerGreetingText>> GetGreetingTexts(string accessToken);

        Task<MessengerResponse> DeleteGreetingText(string accessToken);

        Task<MessengerResponse> WhitelistDomains(string accessToken, params string[] domains);
    }
}
