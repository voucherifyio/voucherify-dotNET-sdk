#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using Newtonsoft.Json;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class OrderItemProduct
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "metadata")]
        public Metadata Metadata { get; set; }
        
        [JsonProperty(PropertyName = "override")]
        public bool Override { get; set; }
   
        public OrderItemProduct()
        {
            this.Metadata = new Metadata();
        }

        public override string ToString()
        {
            return string.Format("OrderItemProduct(Name={0},Metadata={1},Override={2})", this.Name, this.Metadata, this.Override);
        }
    }
}
#endif