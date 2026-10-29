# Voucherify.Model.V2LoyaltiesProgramsReportsTiersDailyListResponseBody
Response body schema for **GET** `/v2/loyalties/programs/{programId}/reports/tiers/daily`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Data** | [**List&lt;TiersReportDailyEntry&gt;**](TiersReportDailyEntry.md) | List of report entries, one per tier structure, tier, and aggregation period with recorded movement, ordered by &#x60;date&#x60; ascending. Empty when no movement was recorded in the range. | [optional] 
**Object** | **string** | Object type marker. Always &#x60;report&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

