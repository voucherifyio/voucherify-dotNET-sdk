#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using Newtonsoft.Json;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class ValidationPromotionTier : ApiObjectWithId
    {
        [JsonProperty(PropertyName = "banner")]
        public string Banner { get; private set; }

        [JsonProperty(PropertyName = "discount")]
        public Discount Discount { get; private set; }

        [JsonProperty(PropertyName = "order")]
        public Order Order { get; private set; }

        [JsonProperty(PropertyName = "discount_amount")]
        public long? DiscountAmount { get; private set; }

        [JsonProperty(PropertyName = "hierarchy")]
        public int? Hierarchy { get; private set; }

        [JsonProperty(PropertyName = "applicable_to")]
        public VoucherSubjectList ApplicableTo { get; private set; }

        [JsonProperty(PropertyName = "inapplicable_to")]
        public VoucherSubjectList InapplicableTo { get; private set; }

        public override string ToString()
        {
            return string.Format("ValidationPromotionTier(Id={0},Discount={1},DiscountAmount={2},Order={3},ApplicableTo={4},InapplicableTo={5})",
                this.Id, this.Discount, this.DiscountAmount, this.Order, this.ApplicableTo, this.InapplicableTo);
        }
    }
}
#endif