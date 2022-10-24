#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel.Contexts
{
    [JsonObject]
    public class StackableValidation
    {
        [JsonProperty(PropertyName = "customer")]
        public Customer Customer { get; set; }

        [JsonProperty(PropertyName = "order")]
        public Order Order { get; set; }

        [JsonProperty(PropertyName = "options")]
        public StackableValidationOptions Options { get; set; }

        [JsonProperty(PropertyName = "redeemables")]
        public List<Redeemable> Redeemables { get; set; }

        [JsonProperty(PropertyName = "metadata")]
        public Metadata Metadata { get; set; }

        [JsonProperty(PropertyName = "session")]
        public ValidationSession Session { get; set; }

        public StackableValidation()
        {
            this.Redeemables = new List<Redeemable>();
            this.Metadata = new Metadata();
        }
    }
}
#endif
