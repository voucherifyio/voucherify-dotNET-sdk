#if VOUCHERIFYSERVER
using Newtonsoft.Json;
using System;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel.Contexts
{
    [JsonObject]
    public class CustomerUpdateContext
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        [JsonProperty(PropertyName = "source_id")]
        public string SourceId { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "metadata")]
        public Metadata Metadata { get; set; }

        private CustomerUpdateContext()
        {
            this.Metadata = new Metadata();
        }
        
        public static CustomerUpdateContext FromEmpty()
        {
            return new CustomerUpdateContext();
        }

        public static CustomerUpdateContext FromCustomer(Customer customer)
        {
            Metadata metadata = null;

            if (customer.Metadata != null)
            {
                metadata = new Metadata();

                foreach (var key in customer.Metadata.Keys)
                {
                    metadata.Add(key, customer.Metadata[key]);
                }
            }

            return new CustomerUpdateContext()
            {
                Name = customer.Name,
                Email = customer.Email,
                Description = customer.Description,
                SourceId = customer.SourceId,
                Metadata = customer.Metadata
            };
        }

        public CustomerUpdateContext WithName(string name)
        {
            this.Name = name;
            return this;
        }

        public CustomerUpdateContext WithEmail(string email)
        {
            this.Email = email;
            return this;
        }

        public CustomerUpdateContext WithDescription(string description)
        {
            this.Description = description;
            return this;
        }

        public CustomerUpdateContext WithSourceId(string sourceId)
        {
            this.SourceId = sourceId;
            return this;
        }

        public CustomerUpdateContext WithMetadata(Metadata metadata)
        {
            this.Metadata = metadata;
            return this;
        }
    }
}
#endif