﻿#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using Newtonsoft.Json;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class Gift : ApiObject
    {
        [JsonProperty(PropertyName = "amount")]
        public int Amount { get; private set; }

        public Gift() { }

        public Gift WithAmount(int amount)
        {
            this.Amount = amount;
            return this;
        }

        public override string ToString()
        {
            return string.Format("Gift[Amount={0}]", this.Amount);
        }
    }
}
#endif