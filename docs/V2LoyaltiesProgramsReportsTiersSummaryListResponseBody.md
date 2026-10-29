# Voucherify.Model.V2LoyaltiesProgramsReportsTiersSummaryListResponseBody
Response body schema for **GET** `/v2/loyalties/programs/{programId}/reports/tiers/summary`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Data** | [**List&lt;TiersReportSummaryEntry&gt;**](TiersReportSummaryEntry.md) | List of summary rows, one per tier structure and tier with recorded movement, ordered by &#x60;id&#x60; descending. Contains at most 100 rows. Empty when no movement was recorded. | [optional] 
**Object** | **string** | Object type marker. Always &#x60;report&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

