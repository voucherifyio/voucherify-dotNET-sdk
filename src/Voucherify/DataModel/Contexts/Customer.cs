#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using Newtonsoft.Json;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel.Contexts
{
    [JsonObject]
    public class Customer : CustomerCreate
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
    }
}
#endif