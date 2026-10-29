# Voucherify.Model.SpendingReportDailyEntry
Aggregated program spending statistics for one period and card definition. Numeric fields default to `0`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Date** | **DateTime?** | Identifies the start of the truncated aggregation period (&#x60;YYYY-MM-DD&#x60;). For &#x60;week&#x60; this is Monday. For &#x60;month&#x60; this is the first day. For &#x60;quarter&#x60; this is the quarter start. | [optional] 
**CardDefinitionId** | **string** | Identifies the card definition (&#x60;lcdef_...&#x60;). | [optional] 
**Success** | **decimal?** | Counts successful spending operations in the period. | [optional] 
**SuccessOnReward** | **decimal?** | Counts successful reward purchases in the period. | [optional] 
**SuccessOnOrder** | **decimal?** | Counts successful order payments in the period. | [optional] 
**Points** | **decimal?** | Totals points spent in the period. | [optional] 
**PointsOnRewards** | **decimal?** | Totals points spent on reward purchases in the period. | [optional] 
**PointsOnOrder** | **decimal?** | Totals points spent on order payments in the period. | [optional] 
**AmountOnOrder** | **decimal?** | Totals order amount paid with points in the period. | [optional] 
**Object** | **string** | Object type marker. Always &#x60;spending_daily_report&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

