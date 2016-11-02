﻿using Newtonsoft.Json;

namespace Voucherify.Client.DataModel
{
    [JsonObject]
    public class VoucherValidationContext
    {
        [JsonProperty(PropertyName = "customer")]
        public Customer Customer { get; set; }

        [JsonProperty(PropertyName = "order")]
        public Order Order { get; set; }

        [JsonProperty(PropertyName = "tracking_id")]
        public string TrackingId { get; set; }
    }
}
