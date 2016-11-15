#if VOUCHERIFYSERVER
using Newtonsoft.Json;

namespace Voucherify.DataModel.Contexts
{
    [JsonObject]
    public class VoucherRedemption
    {
        [JsonProperty(PropertyName = "quantity")]
        public int? Quantity { get; private set; }

        public VoucherRedemption() { }

        public VoucherRedemption WithQuantity(int? quantity)
        {
            this.Quantity = quantity;
            return this;
        }

        public VoucherRedemption SingleUse()
        {
            this.Quantity = 1;
            return this;
        }

        public VoucherRedemption Unlimited()
        {
            this.Quantity = null;
            return this;
        }
    }
}
#endif