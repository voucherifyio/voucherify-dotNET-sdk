# Voucherify.Model.V2LoyaltiesRewardsGetResponseBody
Response body schema for **GET** `/v2/loyalties/rewards/{rewardId}`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique reward identifier, prefixed with &#x60;lrew_&#x60;. | [optional] 
**Name** | **string** | Display name of the reward. | [optional] 
**Type** | **string** | Reward type. | [optional] 
**Status** | **string** | Current lifecycle status of the reward. | [optional] 
**StartDate** | **DateTimeOffset?** | Date from which the reward is available, or &#x60;null&#x60; when not set. | [optional] 
**EndDate** | **DateTimeOffset?** | Date until which the reward is available, or &#x60;null&#x60; when not set. | [optional] 
**ValidityHours** | [**RewardValidityHoursResponse**](RewardValidityHoursResponse.md) |  | 
**Material** | [**RewardMaterialResponse**](RewardMaterialResponse.md) |  | [optional] 
**Digital** | [**RewardDigitalResponse**](RewardDigitalResponse.md) |  | [optional] 
**Refunds** | [**LoyaltyV2ActivityRewardRefunds**](LoyaltyV2ActivityRewardRefunds.md) |  | 
**Costs** | [**List&lt;RewardCostResponse&gt;**](RewardCostResponse.md) | Point costs of the reward. Empty array when no costs are defined. | [optional] 
**PurchaseLimits** | [**RewardPurchaseLimits**](RewardPurchaseLimits.md) |  | 
**Metadata** | **Object** | Arbitrary key-value metadata attached to the reward. Empty object when not set. | [optional] 
**CreatedAt** | **DateTimeOffset?** | Timestamp when the reward was created (ISO-8601). | [optional] 
**UpdatedAt** | **DateTimeOffset?** | Timestamp when the reward was last updated (ISO-8601), or &#x60;null&#x60; when never updated. | [optional] 
**Object** | **string** | Object type marker; always &#x60;reward&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

