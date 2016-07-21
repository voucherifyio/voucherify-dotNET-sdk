using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace Voucherify.Client.Serialization
{
    public  class MetadataConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return (objectType == typeof(DataModel.Metadata));
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return new DataModel.Metadata(serializer.Deserialize<Dictionary<string, object>>(reader));
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        { 
            DataModel.Metadata metadata = value as DataModel.Metadata;
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
