# Voucherify.Model.MembersReportSummaryEntry
All-time member and card changes for the program. Counters that did not change are 0.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Identifies the summary row (format: &#x60;lpmrs_&#x60; followed by hexadecimal characters). | [optional] 
**MembersJoined** | **decimal?** | Counts members who joined the program. | [optional] 
**MembersDeactivated** | **decimal?** | Counts members deactivated. Decreases by 1 when a member is activated again. | [optional] 
**MembersDeleted** | **decimal?** | Counts members deleted. | [optional] 
**Cards** | **decimal?** | Counts cards created. Decreases by 1 when a card is unassigned (e.g. when a member is deleted). | [optional] 
**Object** | **string** | Object type marker. Always &#x60;program_members_summary_report&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

