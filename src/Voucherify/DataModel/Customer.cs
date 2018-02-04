#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using System;
using Newtonsoft.Json;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class Customer : ApiObjectWithId
    {
        [JsonProperty(PropertyName = "source_id")]
        public string SourceId { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        [JsonProperty(PropertyName = "phone")]
        public string Phone { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "address")]
        public Address Address { get; private set; }

        [JsonProperty(PropertyName = "metadata")]
        public Metadata Metadata { get; private set; }
#if VOUCHERIFYSERVER
        [JsonProperty(PropertyName = "summary")]
        public CustomerSummary Summary { get; private set; }
        
        [JsonProperty(PropertyName = "loyalty")]
        public CustomerLoyalty Loyalty { get; private set; }
#endif
        public Customer()
        {
            this.Metadata = new Metadata();
        }

        public override string ToString()
        {
            return string.Format("Customer(Id={0},SoruceId={1},Name={2})", this.Id, this.SourceId, this.Name);
        }
    }
}
#endif
