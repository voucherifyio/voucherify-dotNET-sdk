# Voucherify.Model.MemberActivity
This is an object representing member activity.    This is a general object which presents moments from members' activity. There are all types of different events that members perform during their journey once they participate in a loyalty program. Events describe moments when the members redeem loyalty cards and earn points or rewards. The list of all types of activities is listed below.  The details describing the activity are collected in an array property named `data`. In this object, software integrators can find all further information explaining the event context.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique event ID, assigned by Voucherify. | [optional] 
**Type** | **string** | Event type. | [optional] 
**Data** | [**MemberActivityData1**](MemberActivityData1.md) |  | [optional] 
**CreatedAt** | **DateTimeOffset?** | Timestamp representing the date and time when the member activity occurred in ISO 8601 format. | [optional] 
**GroupId** | **string** | Unique identifier of the request that caused the event. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

