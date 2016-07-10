using Newtonsoft.Json;

namespace Voucherify.Client.DataModel
{
    [JsonObject]
    public class VoucherRedemptionContext
    {
        [JsonProperty(PropertyName = "customer")]
        public Customer Customer { get; set; }
        
        [JsonProperty(PropertyName = "order")]
        public Order Order { get; set; }

        [JsonProperty(PropertyName = "metadata")]
        public Metadata Metadata { get; set; }

        public VoucherRedemptionContext()
        {
            this.Metadata = new Metadata();
        }
    }
}
