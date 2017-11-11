using Newtonsoft.Json;

namespace Messenger.Client.Objects
{
    public abstract class MessengerPayload
    {
        [JsonProperty("template_type")]
        public abstract MessengerTemplateType TemplateType { get; }
    }
}