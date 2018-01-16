using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;

namespace Voucherify.Core.Serialization
{
    public class JsonSerializer<T>
        where T : class
    {
        private JsonSerializerSettings settings;

        public JsonSerializer() : this(null)
        {
        }

        public JsonSerializer(List<JsonConverter> converters)
        {
            if (converters == null)
            {
                converters = new List<JsonConverter>()
                {
                    new JsonEnumValueConverter(),
                    new MetadataConverter()
                };
            } else
            {
                bool containsEnumConverter = false;
                bool containsMetadataConverter = false;

                foreach (JsonConverter converter in converters)
                {
                    if (converter is JsonEnumValueConverter)
                    {
                        containsEnumConverter = true;
                    }

                    if (converter is MetadataConverter)
                    {
                        containsMetadataConverter = true;
                    }
                }

                if (!containsEnumConverter)
                {
                    converters.Add(new JsonEnumValueConverter());
                }

                if (!containsMetadataConverter)
                {
                    converters.Add(new MetadataConverter());
                }
            }

            this.settings = new JsonSerializerSettings()
            {
                Formatting = Formatting.None,
                DateFormatString = "yyyy-MM-ddTHH:mm:ssZ",
                ContractResolver = new DefaultContractResolver() {
#if !PORTABLE
                    IgnoreSerializableInterface = true
#endif
                },
                Converters = converters
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
