# Voucherify.Model.CustomerActivity
This is an object representing customer activity.    This is a general object which presents moments from customers' activity. There are all types of different events that customers perform during their journey once they participate in Promotions. Events describe moments when customers redeem coupons and earn points or rewards. The list of all types of activities is listed below.  The details describing the activity are collected in a property named `data`. In this object, software integrators will find all further information explaining the event context.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique event ID, assigned by Voucherify. | [optional] 
**Type** | **string** | Event type. | [optional] 
**Data** | **Object** | Contains details about the event. The objects that are returned in the data attribute differ based on the context of the event type. | [optional] 
**CreatedAt** | **DateTimeOffset?** | Timestamp representing the date and time when the customer activity occurred in ISO 8601 format. | [optional] 
**GroupId** | **string** | Unique identifier of the request that caused the event. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

