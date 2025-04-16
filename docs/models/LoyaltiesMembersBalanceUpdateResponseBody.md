# Voucherify.Model.LoyaltiesMembersBalanceUpdateResponseBody
Response schema for **POST** `v1/loyalties/members/{memberId}/balance` and for **POST** `v1/loyalties/{campaignId}/members/{memberId}/balance`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Points** | **int** | The incremental points removed or added to the current balance on the loyalty card. | [optional] 
**Total** | **int** | The total of points accrued over the lifetime of the loyalty card. | [optional] 
**Balance** | **int** | The balance after adding/removing points. | [optional] 
**Type** | **string** | The type of voucher being modified. | [optional] 
**Object** | **string** | The type of the object represented by JSON. Default is balance. | [optional] [default to ObjectEnum.Balance]
**RelatedObject** | [**LoyaltiesMembersBalanceUpdateResponseBodyRelatedObject**](LoyaltiesMembersBalanceUpdateResponseBodyRelatedObject.md) |  | [optional] 
**OperationType** | **string** | The type of operation being performed. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

