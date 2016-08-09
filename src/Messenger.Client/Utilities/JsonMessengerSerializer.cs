using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Messenger.Client.Utilities
{
    public class JsonMessengerSerializer : IMessengerSerializer
    {
        public string Serialize<T>(T obj)
        {
            return JsonConvert.SerializeObject(obj, Settings);
        }

        public T Deserialize<T>(String value)
        {
            return JsonConvert.DeserializeObject<T>(value);
        }

        private JsonSerializerSettings Settings => new JsonSerializerSettings
        {
            ContractResolver = new CamelCasePropertyNamesContractResolver(),
            NullValueHandling = NullValueHandling.Ignore
        };

    }
}
