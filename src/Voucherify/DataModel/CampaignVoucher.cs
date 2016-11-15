﻿#if VOUCHERIFYSERVER
using Newtonsoft.Json;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class CampaignVoucher : ApiObject
    {
        [JsonProperty("code_config")]
        public CodeConfig CodeConfig { get; private set; }

        [JsonProperty(PropertyName = "type")]
        public VoucherType Type { get; private set; }
        
        [JsonProperty(PropertyName = "category")]
        public string Category { get; private set; }

        [JsonProperty(PropertyName = "discount")]
        public Discount Discount { get; private set; }

        [JsonProperty(PropertyName = "gift")]
        public Gift Gift { get; private set; }
        
        [JsonProperty(PropertyName = "redemption")]
        public CampaignVoucherRedemption Redemption { get; private set; }

        public CampaignVoucher()
        {
        }

        public override string ToString()
        {
            return string.Format("CampaignVoucher[Type={0},Category={1},Discount={2},Gift={3},Redemption={4}]",
                this.Type,
                this.Category,
                this.Discount,
                this.Gift,
                this.Redemption);
        }
    }
}
#endif
