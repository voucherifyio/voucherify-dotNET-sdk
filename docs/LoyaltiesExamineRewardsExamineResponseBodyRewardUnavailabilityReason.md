# Voucherify.Model.LoyaltiesExamineRewardsExamineResponseBodyRewardUnavailabilityReason
Reason a reward is unavailable.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Reason** | **string** | Identifies why the reward is unavailable.  - &#x60;insufficient_balance&#x60;: The source card balance is lower than the required points cost.  - &#x60;no_target_card&#x60;: The member does not have the loyalty card that would receive the points from a \&quot;points on a loyalty card\&quot; reward. | [optional] 
**Details** | **Object** |  | 
**Object** | **string** | Object type marker. Always &#x60;reward_unavailability_reason&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

