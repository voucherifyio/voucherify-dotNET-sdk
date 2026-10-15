# Voucherify.Model.RewardsReportSummaryEntry
All-time reward-purchase counts for one reward. Counts that did not occur are 0.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Identifies the summary row (format: &#x60;lprrs_&#x60; followed by hexadecimal characters). | [optional] 
**RewardId** | **string** | Identifies the reward (&#x60;lrew_...&#x60;). | [optional] 
**SuccessCount** | **decimal?** | Counts approved reward purchases. | [optional] 
**FailuresCount** | **decimal?** | Counts reward purchase attempts that failed. | [optional] 
**FailuresBreakdown** | **Object** | Counts failed reward purchase attempts by reason. A reason is present only when it was recorded. Empty when no failures were recorded. Keys can also be a card-transaction rejection reason or a publication error key. | 
**Object** | **string** | Object type marker. Always &#x60;program_rewards_summary_report&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

