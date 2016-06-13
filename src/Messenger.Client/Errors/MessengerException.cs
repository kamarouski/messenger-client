using System;

namespace Messenger.Client.Errors
{
    public class MessengerException : Exception 
    {
        public MessengerException(String message, Exception innerException = null) : base(message, innerException) { }

        public MessengerException(Exception innerException) : base(innerException.Message, innerException) { }
    }
}
