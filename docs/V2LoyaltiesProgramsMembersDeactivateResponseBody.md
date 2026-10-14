# Voucherify.Model.V2LoyaltiesProgramsMembersDeactivateResponseBody
Response body schema for **POST** `/v2/loyalties/programs/{programId}/members/{memberId}/deactivate`. On success, `status` is always `INACTIVE`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Identifies the member. | [optional] 
**CustomerId** | **string** | Identifies the enrolled customer. | [optional] 
**ProgramId** | **string** | Identifies the loyalty program. | [optional] 
**Status** | **string** | Current member status. Allowed values: &#x60;ACTIVE&#x60;, &#x60;INACTIVE&#x60;, &#x60;DELETED&#x60;. &#x60;INACTIVE&#x60; members cannot earn points or redeem rewards. | [optional] 
**Metadata** | **Object** | Stores custom member metadata. Empty object when none is set. | [optional] 
**CreatedAt** | **DateTimeOffset?** | Records when the member was created (ISO 8601). | [optional] 
**UpdatedAt** | **DateTimeOffset?** | Records the last update (ISO 8601). &#x60;null&#x60; if the member has never been updated. | [optional] 
**Object** | **string** | Object type. Always &#x60;member&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

