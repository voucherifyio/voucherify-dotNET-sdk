# Voucherify.Model.RedemptionVoucherGift
Object representing gift parameters. Child attributes are present only if `type` is `GIFT_VOUCHER`. Defaults to `null`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Amount** | **int** | Total gift card income over the lifetime of the card. The value is multiplied by 100 to represent 2 decimal places. For example &#x60;10000 cents&#x60; for &#x60;$100.00&#x60;. | [optional] 
**SubtractedAmount** | **int** | Total amount of subtracted credits over the gift card lifetime. The value is multiplied by 100 to represent 2 decimal places. For example &#x60;10000 cents&#x60; for &#x60;$100.00&#x60;. | [optional] 
**Balance** | **int** | Available funds. The value is multiplied by 100 to represent 2 decimal places. For example &#x60;10000 cents&#x60; for &#x60;$100.00&#x60;. | [optional] 
**Effect** | **string** | Defines how the credits are applied to the customer&#39;s order. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

