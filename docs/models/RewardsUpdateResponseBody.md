# Voucherify.Model.RewardsUpdateResponseBody
Response body schema for **PUT** `v1/rewards/{rewardId}`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique reward ID, assigned by Voucherify. | [optional] 
**Name** | **string** | Reward name. | [optional] 
**Stock** | **int** | Configurable for **material rewards**. The number of units of the product that you want to share as reward. | [optional] 
**Redeemed** | **int** | Defines the number of already invoked (successful) reward redemptions.  | [optional] 
**Attributes** | [**RewardsUpdateResponseBodyAttributes**](RewardsUpdateResponseBodyAttributes.md) |  | [optional] 
**Metadata** | **Object** | The metadata object stores all custom attributes assigned to the reward. A set of key/value pairs that you can attach to a reward object. It can be useful for storing additional information about the reward in a structured format. | [optional] 
**Type** | **string** | Reward type. | [optional] 
**Parameters** | [**RewardType**](RewardType.md) |  | [optional] 
**CreatedAt** | **DateTimeOffset** | Timestamp representing the date and time when the reward was created. The value is shown in the ISO 8601 format. | [optional] 
**UpdatedAt** | **DateTimeOffset** | Timestamp representing the date and time when the reward was updated. The value is shown in the ISO 8601 format. | [optional] 
**Object** | **string** | The type of the object represented by the JSON. This object stores information about the reward. | [default to ObjectEnum.Reward]

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

