#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using Newtonsoft.Json;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel
{
    [JsonObject]
    public  class ValidationPromotion : ApiObjectWithId
    {
        [JsonProperty(PropertyName = "banner")]
        public string Banner { get; private set; }

        [JsonProperty(PropertyName = "discount")]
        public Discount Discount { get; private set; }

        [JsonProperty(PropertyName = "discounted_amount")]
        public long? DiscountedAmount { get; private set; }

        public override string ToString()
        {
            return string.Format("ValidationOrder(Id={0},Discount={1},Amount={2})", this.Id, this.Discount, this.DiscountedAmount);
        }
    }
}
#endif