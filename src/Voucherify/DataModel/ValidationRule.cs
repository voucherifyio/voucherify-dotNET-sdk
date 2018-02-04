#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using System;
using Newtonsoft.Json;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class ValidationRule : ApiObjectWithId
    {
        [JsonProperty(PropertyName = "voucher_code")]
        public string VoucherCode { get; private set; }

        [JsonProperty(PropertyName = "campaign_name")]
        public string CampaignName { get; private set; }

        [JsonProperty(PropertyName = "junction")]
        public string Junction { get; private set; }

        [JsonProperty(PropertyName = "segments")]
        public Metadata Segments { get; private set; }

        [JsonProperty(PropertyName = "products")]
        public Metadata Products { get; private set; }

        [JsonProperty(PropertyName = "skus")]
        public Metadata Skus { get; private set; }

        [JsonProperty(PropertyName = "orders")]
        public Metadata Orders { get; private set; }

        [JsonProperty(PropertyName = "redemptions")]
        public Metadata Redemptions { get; private set; }

        public ValidationRule()
        {
            this.Segments = new Metadata();
            this.Products = new Metadata();
            this.Skus = new Metadata();
            this.Orders = new Metadata();
            this.Redemptions = new Metadata();
        }

        public override string ToString()
        {
            return string.Format("ValidationRule(Id={0},Voucher={1},Campaign={2})", this.Id, this.VoucherCode, this.CampaignName);
        }
    }
}
#endif