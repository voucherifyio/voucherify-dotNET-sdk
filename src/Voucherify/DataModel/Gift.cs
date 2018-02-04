#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using Newtonsoft.Json;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class Gift : ApiObject
    {
        [JsonProperty(PropertyName = "amount")]
        public int Amount { get; private set; }

        [JsonProperty(PropertyName = "balance")]
        public int Balance { get; private set; }

        public Gift() { }
        
        public override string ToString()
        {
            return string.Format("Gift(Amount={0},Balance={1})", this.Amount, this.Balance);
        }
    }
}
#endif