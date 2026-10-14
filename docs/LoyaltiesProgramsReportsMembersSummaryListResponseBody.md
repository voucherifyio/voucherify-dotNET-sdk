# Voucherify.Model.LoyaltiesProgramsReportsMembersSummaryListResponseBody
Response body schema for **GET** `/v2/loyalties/programs/{programId}/reports/members/summary`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Data** | [**List&lt;MembersReportSummaryEntry&gt;**](MembersReportSummaryEntry.md) | List of summary rows for the program. Contains one row when activity was recorded, ordered by &#x60;id&#x60; descending. Empty when no activity was recorded. | [optional] 
**Object** | **string** | Object type marker. Always &#x60;report&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

