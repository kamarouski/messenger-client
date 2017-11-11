using Messenger.Client.Objects.Enums;


namespace Messenger.Client.Objects
{
    public class MessengerAttachment
    {
        public MessengerAttachmentType Type { get; set; }

        public MessengerPayload Payload { get; set; }
    }
}
