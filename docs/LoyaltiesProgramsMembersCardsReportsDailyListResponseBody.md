# Voucherify.Model.LoyaltiesProgramsMembersCardsReportsDailyListResponseBody
Response body schema for **GET** `/v2/loyalties/programs/{programId}/members/{memberId}/cards/{cardId}/reports/daily`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Data** | [**List&lt;CardDailyReportEntry&gt;**](CardDailyReportEntry.md) | List of report entries, one per aggregation period with recorded activity, ordered by &#x60;date&#x60; ascending. Empty when no activity was recorded in the range. | [optional] 
**Object** | **string** | Object type marker. Always &#x60;report&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

