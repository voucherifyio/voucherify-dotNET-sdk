#if VOUCHERIFYSERVER
using System;
using Newtonsoft.Json;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class Customer : ApiObject
    { 
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        [JsonProperty(PropertyName = "source_id")]
        public string SourceId { get; private set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        [JsonProperty(PropertyName = "email")]
        public string Email { get; private set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; private set; }

        [JsonProperty(PropertyName = "created_at")]
        public DateTime? CreatedAt { get; private set; }

        [JsonProperty(PropertyName = "metadata")]
        public Metadata Metadata { get; private set; }

        public Customer()
        {
            this.Metadata = new Metadata();
        }

        public override string ToString()
        {
            return string.Format("Customer[Id={0},SourceId={1},Name={2},Email={3},Metadata={4}]",
                this.Id,
                this.SourceId,
                this.Name,
                this.Email,
                this.Metadata);
        }
    }
}
#endif
