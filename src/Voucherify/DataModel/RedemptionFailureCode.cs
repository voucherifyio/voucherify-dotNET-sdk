#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using Voucherify.Core.Attributes;

namespace Voucherify.DataModel
{
    public enum RedemptionFailureCode
    {
        [JsonEnumValue(Value = "resource_not_found")]
        ResourceNotFound,
        [JsonEnumValue(Value = "voucher_not_active")]
        VoucherNotActive,
        [JsonEnumValue(Value = "voucher_expired")]
        VoucherExpired,
        [JsonEnumValue(Value = "voucher_disabled")]
        VoucherDisabled,
        [JsonEnumValue(Value = "quantity_exceeded")]
        QuantityExceeded,
        [JsonEnumValue(Value = "gift_amount_exceeded")]
        GiftAmountExceeded,
        [JsonEnumValue(Value = "customer_rules_violated")]
        CustomerRulesViolated,
        [JsonEnumValue(Value = "order_rules_violated")]
        OrderRulesViolated,
        [JsonEnumValue(Value = "invalid_order")]
        InvalidOrder,
        [JsonEnumValue(Value = "invalid_amount")]
        InvalidAmount,
        [JsonEnumValue(Value = "missing_amount")]
        MissingAmount,
        [JsonEnumValue(Value = "missing_order_items")]
        MissingOrderItems,
        [JsonEnumValue(Value = "missing_customer")]
        MissingCustomer
    }
}
#endif