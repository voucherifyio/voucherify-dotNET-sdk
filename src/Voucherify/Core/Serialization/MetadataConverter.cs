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
            return (objectType == typeof(Metadata));
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return new Core.DataModel.Metadata(serializer.Deserialize<Dictionary<string, object>>(reader));
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            Core.DataModel.Metadata metadata = value as Metadata;
            writer.WriteStartObject();

            foreach (KeyValuePair<string, object> entry in metadata)
            {
                writer.WritePropertyName(entry.Key);
                writer.WriteValue(entry.Value);
            }

            writer.WriteEndObject();
        }
    }
}
