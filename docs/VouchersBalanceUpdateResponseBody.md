# Voucherify.Model.VouchersBalanceUpdateResponseBody
Response body schema for `vouchers/{code}/balance.`

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Amount** | **int?** | The incremental amount added (positive integer) or subtracted (negative integer) to the current balance on the gift card or loyalty card. The value is multiplied by 100 to represent 2 decimal places. For example &#x60;10000 cents&#x60; for &#x60;$100.00&#x60;. | [optional] 
**Total** | **int?** | Total income incurred over the lifespan of the gift card or loyalty card. | [optional] 
**Balance** | **int?** | The balance after adding or subtracting a specified amount. The value is multiplied by 100 to represent 2 decimal places. For example &#x60;10000 cents&#x60; for &#x60;$100.00&#x60;. | [optional] 
**Type** | **string** | The type of voucher being modified. | [optional] 
**OperationType** | **string** | The type of the operation being performed. | [optional] 
**Object** | **string** | The type of the object represented by JSON. Default is &#x60;balance&#x60;. | [optional] 
**RelatedObject** | [**VouchersBalanceUpdateResponseBodyRelatedObject**](VouchersBalanceUpdateResponseBodyRelatedObject.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

