# Voucherify.Model.VoucherBalance
Contains information on how the balance was affected by the transaction.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The type of voucher whose balance is being adjusted due to the transaction. | [optional] 
**Total** | **int?** | The number of all points or credits accumulated on the card as affected by add or subtract operations. | [optional] 
**Object** | **string** | The type of the object represented by the JSON. | [optional] 
**Points** | **int?** | Points added or subtracted in the transaction of a loyalty card. | [optional] 
**Balance** | **int?** | The available points or credits on the card after the transaction as affected by redemption or rollback. | [optional] 
**OperationType** | **string** | The type of the operation being performed. The operation type is &#x60;AUTOMATIC&#x60; if it is an automatic redemption. | [optional] 
**RelatedObject** | [**VoucherBalanceRelatedObject**](VoucherBalanceRelatedObject.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

