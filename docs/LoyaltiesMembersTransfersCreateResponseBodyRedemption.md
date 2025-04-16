# Voucherify.Model.LoyaltiesMembersTransfersCreateResponseBodyRedemption
Stores a summary of redemptions that have been applied to the voucher.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Quantity** | **int?** | How many times a voucher can be redeemed. A null value means unlimited. | [optional] 
**RedeemedPoints** | **int?** | Total loyalty points redeemed. | [optional] 
**RedeemedQuantity** | **int?** | How many times a voucher has already been redeemed. | [optional] 
**Object** | **string** | The type of the object represented is by default list. To get this list, you need to make a call to the endpoint returned in the url attribute. | [optional] [default to ObjectEnum.List]
**Url** | **string** | The endpoint where this list of redemptions can be accessed using a **GET** method. /v1/vouchers/{voucher_code}/redemptions | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

