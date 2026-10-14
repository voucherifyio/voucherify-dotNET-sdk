# Voucherify.Model.VLMemberActivity
An activity recorded for a member.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CreatedAt** | **DateTimeOffset?** | Timestamp when the activity was recorded (ISO 8601). | [optional] 
**GroupId** | **string** | ID grouping activities recorded within the same request. | [optional] 
**Source** | [**ActivitySource**](ActivitySource.md) |  | [optional] 
**Id** | **string** | Unique activity ID. | [optional] 
**MemberId** | **string** | ID of the member the activity relates to. | [optional] 
**Type** | **string** | Activity type. Allowed values: &#x60;vl.member.created&#x60;, &#x60;vl.member.updated&#x60;, &#x60;vl.member.deleted&#x60;, &#x60;vl.member.activated&#x60;, &#x60;vl.member.deactivated&#x60;, &#x60;vl.member.card.assigned&#x60;, and &#x60;vl.member.card.unassigned&#x60;. | [optional] 
**Data** | [**VLMemberActivityData**](VLMemberActivityData.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

