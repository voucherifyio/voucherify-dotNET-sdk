# Voucherify.Model.RedemptionVoucherRedemption
Stores a summary of redemptions that have been applied to the voucher.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Quantity** | **int?** | How many times a voucher can be redeemed. A &#x60;null&#x60; value means unlimited. | [optional] 
**RedeemedQuantity** | **int?** | How many times a voucher has already been redeemed. | [optional] 
**RedeemedPoints** | **int?** | Total loyalty points redeemed. | [optional] 
**Object** | **string** | The type of the object represented is by default &#x60;list&#x60;. To get this list, you need to make a call to the endpoint returned in the url attribute. | [optional] 
**Url** | **string** | The endpoint where this list of redemptions can be accessed using a **GET** method. &#x60;/v1/vouchers/{voucher_code}/redemptions&#x60; | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

