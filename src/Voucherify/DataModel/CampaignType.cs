#if VOUCHERIFYSERVER
using Voucherify.Core.Attributes;

namespace Voucherify.DataModel
{
    public enum CampaignType
    {
        [JsonEnumValue(Value = "STATIC")]
        Static,
        [JsonEnumValue(Value = "AUTO-UPDATE")]
        AutoUpdate
    }
}
#endif