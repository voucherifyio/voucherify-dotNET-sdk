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
        public string SourceId { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "created_at")]
        public DateTime? CreatedAt { get; private set; }

        [JsonProperty(PropertyName = "metadata")]
        public Metadata Metadata { get; private set; }

        public Customer()
        {
            this.Metadata = new Metadata();
        }

        public Customer WithSourceId(string sourceId)
        {
            this.SourceId = sourceId;
            return this;
        }

        public Customer WithName(string name)
        {
            this.Name = name;
            return this;
        }

        public Customer WithEmail(string email)
        {
            this.Email = email;
            return this;
        }

        public Customer WithDescription(string description)
        {
            this.Description = description;
            return this;
        }

        public Customer WithMetadata(Metadata metadata)
        {
            this.Metadata = metadata;
            return this;
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
