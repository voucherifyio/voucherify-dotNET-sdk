# Voucherify.Model.RewardsReportDailyEntry
Aggregated reward-purchase counts for one period and reward. Counts that did not occur in the period are 0.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Date** | **DateTime?** | Identifies the start of the truncated aggregation period (&#x60;YYYY-MM-DD&#x60;). For &#x60;week&#x60; this is Monday. For &#x60;month&#x60; this is the first day. For &#x60;quarter&#x60; this is the quarter start. | [optional] 
**RewardId** | **string** | Identifies the reward (&#x60;lrew_...&#x60;). | [optional] 
**SuccessCount** | **decimal?** | Counts approved reward purchases in the period. | [optional] 
**FailuresCount** | **decimal?** | Counts reward purchase attempts that failed in the period. | [optional] 
**FailuresBreakdown** | **Object** | Always an empty object even if &#x60;failures_count&#x60; is above zero. | [optional] 
**Object** | **string** | Object type marker. Always &#x60;program_rewards_daily_report&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

