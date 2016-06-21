using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Voucherify.Client.DataModel
{
    [DataContract]
    public class VoucherRedemption
    {
        [DataMember(Name = "quantity")]
        public int? Quantity { get; private set; }

        [DataMember(Name = "redeemed_quantity")]
        public int? RedeemedQuantity { get; private set;  }

        [DataMember(Name = "redemption_entries")]
        public List<RedemptionEntry> RedemptionEntries { get; private set; }

        public static VoucherRedemption WithQuantity(int limit)
        {
            return new VoucherRedemption() { Quantity = limit };
        }
    }
}
