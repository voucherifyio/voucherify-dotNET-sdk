# Voucherify.Model.V2LoyaltiesProgramsEarningRulesListResponseBody
Response body schema for **GET** `/v2/loyalties/programs/{programId}/earning-rules`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Object** | **string** | Object type marker. Always &#x60;list&#x60;. | [optional] 
**Data** | [**List&lt;ProgramEarningRuleAssignment&gt;**](ProgramEarningRuleAssignment.md) | Earning rule assignments on the current page. | [optional] 
**Cursor** | [**ProgramListCursor**](ProgramListCursor.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

