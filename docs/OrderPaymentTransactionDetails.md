# Voucherify.Model.OrderPaymentTransactionDetails
Details of a `PAY_WITH_POINTS` order transaction.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Reason** | **string** | Human-readable reason: \&quot;Points spent on order payment\&quot;. | [optional] 
**Rejection** | [**OrderPaymentRejection**](OrderPaymentRejection.md) |  | [optional] 
**Metadata** | **Object** | Transaction metadata. For pay-with-points transactions this contains the flattened payment limits used for the calculation: &#x60;amount_limit&#x60; for the &#x60;AMOUNT_LIMIT&#x60; type and/or &#x60;points_limit&#x60; for the &#x60;POINTS_LIMIT&#x60; type. Empty object when the default &#x60;CARD_BALANCE&#x60; limit was used or when not set. | [optional] 
**Payment** | [**OrderPaymentPaymentDetails**](OrderPaymentPaymentDetails.md) |  | [optional] 
**SpendingCap** | [**OrderPaymentTransactionDetailsSpendingCap**](OrderPaymentTransactionDetailsSpendingCap.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

