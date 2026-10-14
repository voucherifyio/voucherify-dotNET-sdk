# Voucherify.Model.SpendingReportSummaryEntry
Total program spending statistics for one card definition that has recorded spending. Numeric fields default to `0`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Identifies the summary row (&#x60;lssum_...&#x60;). | [optional] 
**CardDefinitionId** | **string** | Identifies the card definition (&#x60;lcdef_...&#x60;). | [optional] 
**Success** | **decimal?** | Counts successful spending operations. | [optional] 
**SuccessOnReward** | **decimal?** | Counts successful reward purchases. | [optional] 
**SuccessOnOrder** | **decimal?** | Counts successful order payments. | [optional] 
**Points** | **decimal?** | Totals points spent. | [optional] 
**PointsOnRewards** | **decimal?** | Totals points spent on reward purchases. | [optional] 
**PointsOnOrder** | **decimal?** | Totals points spent on order payments. | [optional] 
**AmountOnOrder** | **decimal?** | Totals order amount paid with points. | [optional] 
**Object** | **string** | Object type marker. Always &#x60;spending_summary_report&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

