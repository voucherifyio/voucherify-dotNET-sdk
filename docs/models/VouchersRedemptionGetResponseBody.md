# Voucherify.Model.VouchersRedemptionGetResponseBody
Response body schema for **GET** `v1/vouchers/{code}/redemption`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RedemptionEntries** | [**List&lt;RedemptionEntry&gt;**](RedemptionEntry.md) | Contains the array of successful and failed redemption objects. | 
**Quantity** | **int** | The maximum number of times a voucher can be redeemed. | [optional] 
**RedeemedQuantity** | **int** | The number of times the voucher was redeemed successfully. | [optional] 
**Object** | **string** | The type of the object represented by JSON. This object stores information about redemptions in a dictionary. | [optional] [default to "list"]
**Url** | **string** | URL | [optional] 
**DataRef** | **string** | Identifies the name of the attribute that contains the array of &#x60;redemption_entries&#x60;. | [optional] [default to "redemption_entries"]
**Total** | **int** | Total number of redemption objects. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

