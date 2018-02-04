#if VOUCHERIFYSERVER
using Voucherify.Core.Attributes;

namespace Voucherify.DataModel
{
    public enum CampaignVoucherGenerationStatus
    {
        [JsonEnumValue(Value = "IN_PROGRESS")]
        InProgress,
        [JsonEnumValue(Value = "DONE")]
        Done,
        [JsonEnumValue(Value = "ERROR")]
        Error
    }
}
#endif