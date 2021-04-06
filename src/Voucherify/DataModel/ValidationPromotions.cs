#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class ValidationPromotions : Validation
    { 
        [JsonProperty(PropertyName = "promotions")]
        public List<ValidationPromotionTier> Promotions { get; private set; }

        public override string ToString()
        {
            return string.Format("Validation(Promotions={0},Result={1})", this.Promotions, this.ToString());
        }
    }
}
#endif