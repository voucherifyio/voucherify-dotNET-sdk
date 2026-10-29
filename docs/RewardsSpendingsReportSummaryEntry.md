# Voucherify.Model.RewardsSpendingsReportSummaryEntry
All-time points spent on one reward cost and spending for one card definition. Counts and points that did not occur are 0.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RewardId** | **string** | Identifies the reward (&#x60;lrew_...&#x60;). | [optional] 
**CostId** | **string** | Identifies the reward cost (&#x60;lrcst_...&#x60;). | [optional] 
**SpendingId** | **string** | Identifies the reward spending (&#x60;lrspn_...&#x60;). | [optional] 
**CardDefinitionId** | **string** | Identifies the card definition (&#x60;lcdef_...&#x60;). | [optional] 
**Id** | **string** | Identifies the summary row (format: &#x60;lprss_&#x60; followed by hexadecimal characters). | [optional] 
**SuccessCount** | **decimal?** | Counts approved reward point spends. | [optional] 
**Points** | **decimal?** | Totals points spent on those reward spends. | [optional] 
**Object** | **string** | Object type marker. Always &#x60;program_rewards_spendings_summary_report&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

