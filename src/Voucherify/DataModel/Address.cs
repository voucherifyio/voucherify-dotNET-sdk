#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Voucherify.DataModel
{
    [JsonObject]
    public class Address
    {
        [JsonProperty(PropertyName = "city")]
        public string City { get; private set; }

        [JsonProperty(PropertyName = "state")]
        public string State { get; private set; }

        [JsonProperty(PropertyName = "line_1")]
        public string Line1 { get; private set; }

        [JsonProperty(PropertyName = "line_2")]
        public string Line2 { get; private set; }

        [JsonProperty(PropertyName = "country")]
        public string Country { get; private set; }

        [JsonProperty(PropertyName = "postal_code")]
        public string PostalCode { get; private set; }

        public override string ToString()
        {
            return string.Format("Address(County={0},City={1})", this.Country, this.City);
        }
    }
}
#endif