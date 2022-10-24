#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class Redeemable
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        [JsonProperty(PropertyName = "object")]
        public string Object { get; private set; }

        [JsonProperty(PropertyName = "status")]
        public string Status { get; private set; }

        [JsonProperty(PropertyName = "order")]
        public Order Order { get; private set; }

        [JsonProperty(PropertyName = "applicable_to")]
        public VoucherSubjectList ApplicableTo { get; private set; }

        [JsonProperty(PropertyName = "inapplicable_to")]
        public VoucherSubjectList InapplicableTo { get; private set; }

        [JsonProperty(PropertyName = "result")]
        public RedeemableResult Result { get; private set; }

        [JsonProperty(PropertyName = "metadata")]
        public Metadata Metadata { get; private set; }

        public override string ToString()
        {
            return string.Format("Redeemable(Id={0},Object={1},Status={2},Order={3},ApplicableTo={4},InapplicableTo={5},Result={6},Metadata={7})", this.Id, this.Object, this.Status, this.Order, this.ApplicableTo, this.InapplicableTo, this.Result, this.Metadata);
        }
    }
}
#endif
