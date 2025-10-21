# Voucherify.Model.LoyaltiesMembersPendingPointsBalanceResponseBody
Response body schema for **POST** `/loyalties/members/{memberId}/pending-points/{pendingPointsId}/balance`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Points** | **int?** | The number of pending points added to or subtracted from the loyalty card. | [optional] 
**Total** | **int?** | Total number of pending points currently on a loyalty card. | [optional] 
**Object** | **string** | The type of the object represented by JSON. Default is &#x60;balance&#x60;. | [optional] 
**RelatedObject** | [**LoyaltiesMembersPendingPointsBalanceResponseBodyRelatedObject**](LoyaltiesMembersPendingPointsBalanceResponseBodyRelatedObject.md) |  | [optional] 
**OperationType** | **string** | The type of the operation being performed. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

