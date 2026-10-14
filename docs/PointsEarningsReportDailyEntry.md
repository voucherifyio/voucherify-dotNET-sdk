# Voucherify.Model.PointsEarningsReportDailyEntry
Aggregated daily program points-earnings statistics for one period, earning rule, earning item, and card definition. All numeric fields default to 0.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EarningRuleId** | **string** | Identifies the earning rule (format &#x60;lern_...&#x60;). | [optional] 
**EarningItemId** | **string** | Identifies the earning item that produced the points (format: &#x60;lernei_&#x60; followed by hexadecimal characters). | [optional] 
**CardDefinitionId** | **string** | Identifies the card definition (format &#x60;lcdef_...&#x60;). | [optional] 
**Date** | **DateTime?** | Identifies the start of the truncated aggregation period (&#x60;YYYY-MM-DD&#x60;). For &#x60;week&#x60; this is Monday. For &#x60;month&#x60; this is the first day. For &#x60;quarter&#x60; this is the quarter start. | [optional] 
**SuccessCount** | **decimal?** | Counts earning operations that credited points or added pending points in the period. | [optional] 
**Points** | **decimal?** | Sums points credited immediately by earning rules in the period. Pending points activated in the period are not included. | [optional] 
**PendingPoints** | **decimal?** | Sums pending points added in the period. Activated and canceled pending points are not deducted. | [optional] 
**Object** | **string** | Object type marker. Always &#x60;program_points_earnings_daily_report&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

