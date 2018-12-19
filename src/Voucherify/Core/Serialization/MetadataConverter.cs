using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Voucherify.Core.DataModel;

namespace Voucherify.Core.Serialization
{
    public class MetadataConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return (objectType == typeof(Metadata)) || (objectType == typeof(Json));
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (objectType == typeof(Json))
            {
                return new Core.DataModel.Json(serializer.Deserialize<Dictionary<string, object>>(reader));
            }

            return new Core.DataModel.Metadata(serializer.Deserialize<Dictionary<string, object>>(reader));
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            Dictionary<string, object> metadata = value as Dictionary<string, object>;
            writer.WriteStartObject();

            foreach (KeyValuePair<string, object> entry in metadata)
            {
                writer.WritePropertyName(entry.Key);
                serializer.Serialize(writer, entry.Value);
            }

            writer.WriteEndObject();
        }
    }
}
