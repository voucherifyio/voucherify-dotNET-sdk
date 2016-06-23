using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Voucherify.Client.Serialization
{
    public class JsonSerializer<T>
        where T : class
    {  
        public T Deserialize(string payload)
        {
            return JsonConvert.DeserializeObject<T>(payload, new StringEnumConverter());
        }

        public string Serialize(T payload)
        {
            return JsonConvert.SerializeObject(payload, new StringEnumConverter());
        }
    }
}
