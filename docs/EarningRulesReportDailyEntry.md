# Voucherify.Model.EarningRulesReportDailyEntry
Aggregated daily program earning-rule evaluation statistics for one period and earning rule. All numeric fields default to 0.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Date** | **DateTime?** | Identifies the start of the truncated aggregation period (&#x60;YYYY-MM-DD&#x60;). For &#x60;week&#x60; this is Monday. For &#x60;month&#x60; this is the first day. For &#x60;quarter&#x60; this is the quarter start. | [optional] 
**EarningRuleId** | **string** | Identifies the earning rule (format &#x60;lern_...&#x60;). | [optional] 
**SuccessCount** | **decimal?** | Counts eligibility checks that passed the trigger limit in the period. | [optional] 
**FailuresCount** | **decimal?** | Counts eligibility checks that failed the trigger limit in the period. | [optional] 
**FailuresBreakdown** | **Object** | Always an empty object even if &#x60;failures_count&#x60; is above zero. | [optional] 
**Object** | **string** | Object type marker. Always &#x60;program_earning_rules_daily_report&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

