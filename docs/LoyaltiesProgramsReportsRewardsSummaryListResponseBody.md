# Voucherify.Model.LoyaltiesProgramsReportsRewardsSummaryListResponseBody
Response body schema for **GET** `/v2/loyalties/programs/{programId}/reports/rewards/summary`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Data** | [**List&lt;RewardsReportSummaryEntry&gt;**](RewardsReportSummaryEntry.md) | List of summary rows, one per reward with a recorded purchase attempt, ordered by &#x60;id&#x60; descending. Contains at most 100 rows. Empty when no purchase attempts were recorded. | [optional] 
**Object** | **string** | Object type marker. Always &#x60;report&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

