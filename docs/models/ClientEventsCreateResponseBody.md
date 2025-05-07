# Voucherify.Model.ClientEventsCreateResponseBody
Response body schema for **POST** `v1/events`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Customer** | [**SimpleCustomerRequiredObjectType**](SimpleCustomerRequiredObjectType.md) |  | 
**Object** | **string** | The object represented is an &#x60;event&#x60;. | [optional] [default to ObjectEnum.Event]
**Type** | **string** | The event name. | [optional] 
**Referral** | **Object** | A &#x60;null&#x60; referral object. | [optional] 
**Loyalty** | **Object** | A &#x60;null&#x60; loyalty object. | [optional] 
**Metadata** | **Object** |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

