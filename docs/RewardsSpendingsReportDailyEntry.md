# Voucherify.Model.RewardsSpendingsReportDailyEntry
Aggregated points spent on one reward cost and spending for one period and card definition. Counts and points that did not occur in the period are 0.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RewardId** | **string** | Identifies the reward (&#x60;lrew_...&#x60;). | [optional] 
**CostId** | **string** | Identifies the reward cost (&#x60;lrcst_...&#x60;). | [optional] 
**SpendingId** | **string** | Identifies the reward spending (&#x60;lrspn_...&#x60;). | [optional] 
**CardDefinitionId** | **string** | Identifies the card definition (&#x60;lcdef_...&#x60;). | [optional] 
**Date** | **DateTime?** | Identifies the start of the truncated aggregation period (&#x60;YYYY-MM-DD&#x60;). For &#x60;week&#x60; this is Monday. For &#x60;month&#x60; this is the first day. For &#x60;quarter&#x60; this is the quarter start. | [optional] 
**SuccessCount** | **decimal?** | Counts approved reward point spends in the period. | [optional] 
**Points** | **decimal?** | Totals points spent on those reward spends in the period. | [optional] 
**Object** | **string** | Object type marker. Always &#x60;program_rewards_spendings_daily_report&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

