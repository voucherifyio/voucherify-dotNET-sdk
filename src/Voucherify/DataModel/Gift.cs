#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using Newtonsoft.Json;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class Gift : ApiObject
    {
        [JsonProperty(PropertyName = "amount")]
        public long Amount { get; private set; }

        [JsonProperty(PropertyName = "balance")]
        public long Balance { get; private set; }

        public Gift() { }
        
        public override string ToString()
        {
            return string.Format("Gift(Amount={0},Balance={1})", this.Amount, this.Balance);
        }
    }
}
#endif