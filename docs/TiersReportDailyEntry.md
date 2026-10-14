# Voucherify.Model.TiersReportDailyEntry
Aggregated daily program tier-movement statistics for one period, tier structure, and tier. All numeric fields default to 0.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Date** | **DateTime?** | Identifies the start of the aggregation period on the project-local calendar (&#x60;YYYY-MM-DD&#x60;). The date is truncated to the resolution. For &#x60;week&#x60; this is Monday. For &#x60;month&#x60; this is the first day. For &#x60;quarter&#x60; this is the quarter start. | [optional] 
**TierStructureId** | **string** | Unique identifier of the tier structure (format &#x60;lts_...&#x60;). | [optional] 
**TierId** | **string** | Unique identifier of the tier (format &#x60;lt_...&#x60;). | [optional] 
**Joins** | **decimal?** | Number of members who joined this tier in the period. | [optional] 
**Upgrades** | **decimal?** | Number of upgrades into this tier in the period. | [optional] 
**Downgrades** | **decimal?** | Number of downgrades into this tier in the period. | [optional] 
**Lefts** | **decimal?** | Number of members who left this tier in the period. | [optional] 
**Prolongs** | **decimal?** | Counts expiration-date changes for members who stayed on this tier in the period. | [optional] 
**Object** | **string** | Object type marker. Always &#x60;program_tiers_daily_report&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

