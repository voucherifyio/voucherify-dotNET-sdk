﻿using Newtonsoft.Json;
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

        public JsonSerializer(JsonSerializerSettings settings)
        {
            this.settings = settings ?? new JsonSerializerSettings()
            {
                Formatting = Formatting.None,
                DateFormatString = "yyyy-MM-ddTHH:mm:ssZ",
                ContractResolver = new DefaultContractResolver() {
#if !PORTABLE
                    IgnoreSerializableInterface = true
#endif
                },
                Converters = new List<JsonConverter>() { new JsonEnumValueConverter(), new MetadataConverter() },
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
