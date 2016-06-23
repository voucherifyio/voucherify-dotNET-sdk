using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;

namespace Voucherify.Client.Serialization
{
    public class JsonSerializer<T>
        where T : class
    {
        private JsonSerializerSettings settings = new JsonSerializerSettings()
        {
            Formatting = Formatting.Indented,
            ContractResolver = new DefaultContractResolver() { IgnoreSerializableInterface = true },
            Converters = new List<JsonConverter>() { new StringEnumConverter() }
        };

        public T Deserialize(string payload)
        {
            return JsonConvert.DeserializeObject<T>(payload, this.settings);
        }

        public string Serialize(T payload)
        {
            return JsonConvert.SerializeObject(payload, this.settings);
        }
    }
}
