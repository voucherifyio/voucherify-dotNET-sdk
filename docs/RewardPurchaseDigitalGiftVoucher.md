# Voucherify.Model.RewardPurchaseDigitalGiftVoucher
Gift voucher fulfillment entry.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Voucher identifier of the gift voucher. | [optional] 
**Code** | **string** | Gift voucher code. | [optional] 
**Amount** | **decimal?** | Amount added to (or, for refunds, subtracted from) the gift voucher balance. | [optional] 
**Balance** | **decimal?** | Gift voucher balance after the operation. | [optional] 
**Result** | **string** | Refund handling result for this gift voucher (present in refund results):  - &#x60;CREDITS_SUBTRACTED&#x60;: The credited balance was subtracted.  - &#x60;SKIPPED&#x60;: The voucher was left intact. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

