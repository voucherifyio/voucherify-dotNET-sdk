# Voucherify.Model.V2LoyaltiesProgramsReportsPointsEarningsDailyListResponseBody
Response body schema for **GET** `/v2/loyalties/programs/{programId}/reports/points-earnings/daily`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Data** | [**List&lt;PointsEarningsReportDailyEntry&gt;**](PointsEarningsReportDailyEntry.md) | List of report entries, one per aggregation period, earning rule, earning item, and card definition with recorded activity, ordered by &#x60;date&#x60; ascending. Empty when no activity was recorded in the range. | [optional] 
**Object** | **string** | Object type marker. Always &#x60;report&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

