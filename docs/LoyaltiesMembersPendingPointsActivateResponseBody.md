# Voucherify.Model.LoyaltiesMembersPendingPointsActivateResponseBody
Response body schema for **POST** `/loyalties/members/{memberId}/pending-points/{pendingPointsId}/activate`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Points** | **int?** | The number of pending points added to the loyalty card. | [optional] 
**Total** | **int?** | Total number of points incurred over the lifespan of the loyalty card, minus the expired points. | [optional] 
**Balance** | **int?** | The current number of loyalty points after the pending points have been added. | [optional] 
**Type** | **string** | The type of the voucher being modified. For pending points, it is always &#x60;loyalty_card&#x60;. | [optional] [default to TypeEnum.LoyaltyCard]
**Object** | **string** | The type of the object represented by JSON. Default is &#x60;balance&#x60;. | [optional] [default to ObjectEnum.Balance]
**RelatedObject** | [**LoyaltiesMembersPendingPointsActivateResponseBodyRelatedObject**](LoyaltiesMembersPendingPointsActivateResponseBodyRelatedObject.md) |  | [optional] 
**OperationType** | **string** | The type of the operation being performed. | [optional] [default to OperationTypeEnum.MANUAL]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

