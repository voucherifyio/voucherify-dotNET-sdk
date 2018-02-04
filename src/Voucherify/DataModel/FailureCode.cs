#if VOUCHERIFYSERVER || VOUCHERIFYCLIENT
using Voucherify.Core.Attributes;

namespace Voucherify.DataModel
{
    public enum FailureCode
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
        [JsonEnumValue(Value = "invalid_payload")]
        InvalidPayload,
        [JsonEnumValue(Value = "invalid_amount")]
        InvalidAmount,
        [JsonEnumValue(Value = "missing_amount")]
        MissingAmount,
        [JsonEnumValue(Value = "missing_order_items")]
        MissingOrderItems,
        [JsonEnumValue(Value = "missing_customer")]
        MissingCustomer,
        [JsonEnumValue(Value = "already_rolled_back")]
        AlreadyRolledBack,
        [JsonEnumValue(Value = "invalid_voucher")]
        InvalidVoucher,
        [JsonEnumValue(Value = "invalid_gift")]
        InvalidGift,
        [JsonEnumValue(Value = "duplicate_resource_key")]
        DuplicateResourceKey,
        [JsonEnumValue(Value = "no_voucher_suitable_for_publication")]
        NoVoucherSuitableForPublication,
        [JsonEnumValue(Value = "invalid_add_balance_params")]
        InvalidAddBalanceParams,
        [JsonEnumValue(Value = "invalid_campaign_params")]
        InvalidCampaignParams,
        [JsonEnumValue(Value = "invalid_code_config")]
        InvalidCodeConfig,
        [JsonEnumValue(Value = "invalid_customer")]
        InvalidCustomer,
        [JsonEnumValue(Value = "invalid_export_params")]
        InvalidExportParams,
        [JsonEnumValue(Value = "invalid_product")]
        InvalidProduct,
        [JsonEnumValue(Value = "invalid_publish_params")]
        InvalidpublishParams,
        [JsonEnumValue(Value = "invalid_rollback_params")]
        InvalidRollbackParams,
        [JsonEnumValue(Value = "invalid_sku")]
        InvalidSku,
        [JsonEnumValue(Value = "invalid_validation_rules")]
        InvalidCalidationRules,
        [JsonEnumValue(Value = "invalid_query_params")]
        InvalidQueryParams
    }
}
#endif