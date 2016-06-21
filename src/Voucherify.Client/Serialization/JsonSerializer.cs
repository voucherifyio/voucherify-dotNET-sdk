using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Voucherify.Client.Serialization
{
    public class JsonSerializer<TResult>
        where TResult : class
    {  
        public TResult Deserialize(string payload)
        {
            return JsonConvert.DeserializeObject<TResult>(payload, new StringEnumConverter());
        }

        public string Serialize(TResult payload)
        {
            return JsonConvert.SerializeObject(payload, new StringEnumConverter());
        }
    }
}
