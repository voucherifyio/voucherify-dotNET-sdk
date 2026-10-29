# Voucherify.Model.MembersReportDailyEntry
Member and card changes for one aggregation period. Counters that did not change in the period are 0.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Date** | **DateTime?** | Identifies the start of the truncated aggregation period (&#x60;YYYY-MM-DD&#x60;). For &#x60;week&#x60; this is Monday. For &#x60;month&#x60; this is the first day. For &#x60;quarter&#x60; this is the quarter start. | [optional] 
**MembersJoined** | **decimal?** | Counts members who joined the program in the period. | [optional] 
**MembersDeactivated** | **decimal?** | Counts members deactivated in the period. Decreases by 1 when a member is activated again. | [optional] 
**MembersDeleted** | **decimal?** | Counts members deleted in the period. | [optional] 
**Cards** | **decimal?** | Counts cards created in the period. Decreases by 1 when a card is unassigned (e.g. when a member is deleted). | [optional] 
**Object** | **string** | Object type marker. Always &#x60;program_members_daily_report&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

