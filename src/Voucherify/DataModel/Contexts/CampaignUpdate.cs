﻿#if VOUCHERIFYSERVER
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel.Contexts
{
    [JsonObject]
    public class CampaignUpdate
    {
        [JsonProperty(PropertyName = "type")]
        public CampaignType Type { get; set; }

        [JsonProperty(PropertyName = "start_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? StartDate { get; set; }

        [JsonProperty(PropertyName = "expiration_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ExpirationDate { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "metadata")]
        public Metadata Metadata { get; set; }

        public CampaignUpdate()
        {
            this.Metadata = new Metadata();
        }
    }
}
#endif