#if VOUCHERIFYSERVER
using Voucherify.Core.Attributes;

namespace Voucherify.DataModel
{
    public enum CampaignExtensionType
    {
        [JsonEnumValue(Value = "STATIC")]
        Static,
        [JsonEnumValue(Value = "AUTO-UPDATE")]
        AutoUpdate
    }
}
#endif