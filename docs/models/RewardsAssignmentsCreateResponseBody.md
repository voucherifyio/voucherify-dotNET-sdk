# Voucherify.Model.RewardsAssignmentsCreateResponseBody
Response body schema for **POST** `v1/rewards/{rewardId}/assignments/`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique reward assignment ID, assigned by Voucherify. | [optional] 
**RewardId** | **string** | Associated reward ID. | [optional] 
**CreatedAt** | **DateTimeOffset** | Timestamp representing the date and time when the reward assignment was created. The value is shown in the ISO 8601 format. | [optional] 
**UpdatedAt** | **DateTimeOffset** | Timestamp representing the date and time when the reward assignment was updated. The value is shown in the ISO 8601 format. | [optional] 
**Object** | **string** | The type of the object represented by the JSON. This object stores information about the reward assignment. | [optional] [default to ObjectEnum.RewardAssignment]
**RelatedObjectId** | **string** | Related object ID to which the reward was assigned. | [optional] 
**RelatedObjectType** | **string** | Related object type to which the reward was assigned. | [optional] [default to RelatedObjectTypeEnum.Campaign]
**Parameters** | [**RewardsAssignmentsCreateResponseBodyParameters**](RewardsAssignmentsCreateResponseBodyParameters.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

