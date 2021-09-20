#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using Voucherify.Core.Attributes;

namespace Voucherify.DataModel
{
    public enum DiscountEffect
    {
        [JsonEnumValue(Value = "APPLY_TO_ORDER")]
        ApplyToOrder,
        [JsonEnumValue(Value = "APPLY_TO_ITEMS")]
        ApplyToItems,
        [JsonEnumValue(Value = "APPLY_TO_ITEMS_PROPORTIONALLY")]
        ApplyToItemsProportionally,
        [JsonEnumValue(Value = "APPLY_TO_ITEMS_PROPORTIONALLY_BY_QUANTITY")]
        ApplyToItemsProportionallyByQuantity,
        [JsonEnumValue(Value = "ADD_NEW_ITEMS")]
        AddNewItems,
        [JsonEnumValue(Value = "ADD_MISSING_ITEMS")]
        AddMissingItems
    }
}
#endif