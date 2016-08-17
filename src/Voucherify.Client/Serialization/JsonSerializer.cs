using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;

namespace Voucherify.Client.Serialization
{
    public class JsonSerializer<T>
        where T : class
    {
        private JsonSerializerSettings settings;

        public JsonSerializer() : this(null)
        {
        }

        public JsonSerializer(JsonSerializerSettings settings) {
            this.settings = settings ?? new JsonSerializerSettings()
            {
                Formatting = Formatting.None,
                ContractResolver = new DefaultContractResolver() { IgnoreSerializableInterface = true },
                Converters = new List<JsonConverter>() { new JsonEnumValueConverter(), new IsoDateTimeConverter(), new MetadataConverter() },
            };
        }

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
