using System.Threading.Tasks;
using Messenger.Client.Objects;

namespace Messenger.Client.Services
{
    public interface IMessengerThreadSettingsService
    {
        Task<MessengerResponse<string>>  Save(MessengerThreadSetting setting, string accessToken);
    }
}
