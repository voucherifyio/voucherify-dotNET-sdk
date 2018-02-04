#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using Newtonsoft.Json;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class PromotionTierAction
    {
        [JsonProperty(PropertyName = "discount")]
        public Discount Discount { get; set; }

        public override string ToString()
        {
            return string.Format("PromotionTierAction(Discount={0})", this.Discount);
        }
    }
}
#endif