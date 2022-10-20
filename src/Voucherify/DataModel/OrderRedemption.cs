#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Voucherify.Core.Extensions;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class OrderRedemption
    {
        [JsonProperty(PropertyName = "date")]
        public DateTime? Date { get; private set; }

        [JsonProperty("related_object_id")]
        public string RelatedObjectId { get; private set; }

        [JsonProperty("related_object_type")]
        public string RelatedObjectType { get; private set; }

        [JsonProperty("stacked")]
        public List<string> Stacked { get; private set; }

        public OrderRedemption()
        {
            this.Stacked = new List<string>();
        }

        public override string ToString()
        {
            return string.Format("OrderRedemption(Date={0},RelatedObjectId={1},RelatedObjectType={2},Stacked={3})", this.Date, this.RelatedObjectId, this.RelatedObjectType, ListExtensions.ToString(this.Stacked));
        }
    }
}
#endif