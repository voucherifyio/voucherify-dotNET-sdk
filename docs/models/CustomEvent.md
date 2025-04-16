# Voucherify.Model.CustomEvent

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Customer** | [**SimpleCustomerRequiredObjectType**](SimpleCustomerRequiredObjectType.md) |  | 
**Id** | **string** | Unique custom event ID. | [optional] 
**Object** | **string** | The object represented is an &#x60;event&#x60;. | [optional] [default to ObjectEnum.Event]
**Type** | **string** | The event name. | [optional] 
**Referral** | [**CustomEventReferral**](CustomEventReferral.md) |  | [optional] 
**Loyalty** | [**CustomEventLoyalty**](CustomEventLoyalty.md) |  | [optional] 
**Metadata** | **Object** | A set of custom key/value pairs that you can attach to a customer. The metadata object stores all custom attributes assigned to the customer object. | [optional] 
**CreatedAt** | **DateTimeOffset** | Timestamp representing the date and time when the custom event was created. The value is shown in the ISO 8601 format. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

