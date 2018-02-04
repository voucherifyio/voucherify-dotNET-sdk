﻿#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using System.Collections.Generic;
using Newtonsoft.Json;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel.Contexts
{
    [JsonObject]
    public class OrderCreate
    {
        [JsonProperty(PropertyName = "source_id")]
        public string SourceId { get; set; }

        [JsonProperty(PropertyName = "amount")]
        public int Amount { get; set; }

        [JsonProperty(PropertyName = "items")]
        public List<OrderItem> Items { get; private set; }

        [JsonProperty(PropertyName = "metadata")]
        public Metadata Metadata { get; private set; }

        public OrderCreate()
        {
            this.Items = new List<OrderItem>();
            this.Metadata = new Metadata();
        }

        public OrderCreate WithAmount(int amount)
        {
            this.Amount = amount;
            return this;
        }

        public OrderCreate WithItems(List<OrderItem> items)
        {
            this.Items = items;
            return this;
        }
    }
}
#endif