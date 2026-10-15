# Voucherify.Model.PointsEarningsReportSummaryEntry
Total program points-earnings statistics for one earning rule, earning item, and card definition. All numeric fields default to 0.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EarningRuleId** | **string** | Identifies the earning rule (format &#x60;lern_...&#x60;). | [optional] 
**EarningItemId** | **string** | Identifies the earning item that produced the points (format: &#x60;lernei_&#x60; followed by hexadecimal characters). | [optional] 
**CardDefinitionId** | **string** | Identifies the card definition (format &#x60;lcdef_...&#x60;). | [optional] 
**Id** | **string** | Identifies the summary row (format: &#x60;lppes_&#x60; followed by hexadecimal characters). | [optional] 
**SuccessCount** | **decimal?** | Counts earning operations that credited points or added pending points. | [optional] 
**Points** | **decimal?** | Sums points credited immediately by earning rules. Pending points activated later are not included. | [optional] 
**PendingPoints** | **decimal?** | Sums pending points added. Activated and canceled pending points are not deducted. | [optional] 
**Object** | **string** | Object type marker. Always &#x60;program_points_earnings_summary_report&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

