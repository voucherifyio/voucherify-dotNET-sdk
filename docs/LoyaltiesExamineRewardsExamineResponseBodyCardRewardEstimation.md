# Voucherify.Model.LoyaltiesExamineRewardsExamineResponseBodyCardRewardEstimation
Reward availability estimation for a card.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Reward** | [**LoyaltiesExamineRewardsExamineResponseBodyRewardReference**](LoyaltiesExamineRewardsExamineResponseBodyRewardReference.md) |  | 
**Status** | **string** | Whether the reward can currently be obtained with this card. | [optional] 
**Cost** | [**LoyaltiesExamineRewardsExamineResponseBodyRewardCost**](LoyaltiesExamineRewardsExamineResponseBodyRewardCost.md) |  | 
**UnavailabilityReasons** | [**List&lt;LoyaltiesExamineRewardsExamineResponseBodyRewardUnavailabilityReason&gt;**](LoyaltiesExamineRewardsExamineResponseBodyRewardUnavailabilityReason.md) | Reasons the reward is unavailable. Absent when the reward is available. | [optional] 
**Object** | **string** | Object type marker. Always &#x60;reward_estimation&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

