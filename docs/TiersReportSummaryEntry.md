# Voucherify.Model.TiersReportSummaryEntry
Total program tier-movement statistics for one tier structure and tier. All numeric fields default to 0.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Identifies the summary row (format: &#x60;lptrs_&#x60; followed by hexadecimal characters). | [optional] 
**TierStructureId** | **string** | Unique identifier of the tier structure (format &#x60;lts_...&#x60;). | [optional] 
**TierId** | **string** | Unique identifier of the tier (format &#x60;lt_...&#x60;). | [optional] 
**Joins** | **decimal?** | Total number of members who joined this tier. | [optional] 
**Upgrades** | **decimal?** | Total number of upgrades into this tier. | [optional] 
**Downgrades** | **decimal?** | Total number of downgrades into this tier. | [optional] 
**Lefts** | **decimal?** | Total number of members who left this tier. | [optional] 
**Prolongs** | **decimal?** | Counts expiration-date changes for members who stayed on this tier. | [optional] 
**Object** | **string** | Object type marker. Always &#x60;program_tiers_summary_report&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

