using System;

namespace Messenger.Client.Utilities
{
    public interface IMessengerSerializer
    {
        String Serialize<T>(T obj);
    }
}
