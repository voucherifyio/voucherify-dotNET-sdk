# Voucherify.Model.LoyaltyPendingPointsDetailsEvent
Details about the event that created pending points.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique event identifier, assigned by Voucherify. | [optional] 
**Type** | **string** | Type of the event that triggered the creation of pending points. | [optional] [default to TypeEnum.CustomerOrderPaid]
**GroupId** | **string** | Unique identifier of the request that triggered the event, assigned by Voucherify. | [optional] 
**EntityId** | **string** | Unique identifier of the entity that triggered the event, assigned by Voucherify. For pending points, it is the &#x60;customer_id&#x60; of the customer who paid for the order. | [optional] 
**CreatedAt** | **DateTimeOffset** | Timestamp representing the date and time when the event occurred. The value is shown in the ISO 8601 format. | [optional] 
**Category** | **string** | Type of the event. | [optional] 
**EventSource** | [**EventSource**](EventSource.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

