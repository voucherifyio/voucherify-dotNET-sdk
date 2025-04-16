# Voucherify.Model.SimpleCustomerRequiredObjectType
This is an object representing a customer with limited properties used in Event Tracking endpoints.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The unique ID of a customer that is assigned by Voucherify. | [optional] 
**SourceId** | **string** | The merchant&#39;s customer ID if it is different from the Voucherify customer ID. It is really useful in case of an integration between multiple systems. It can be a customer ID from a CRM system, database or 3rd-party service. | [optional] 
**Name** | **string** | Customer&#39;s first and last name. | [optional] 
**Email** | **string** | Customer&#39;s email address. | [optional] 
**Metadata** | **Object** | A set of custom key/value pairs that you can attach to a customer. The metadata object stores all custom attributes assigned to the customer. It can be useful for storing additional information about the customer in a structured format. This metadata can be used for validating whether the customer qualifies for a discount or it can be used in building customer segments.  | [optional] 
**Object** | **string** | The type of the object represented by the JSON. This object stores information about the customer. | [optional] [default to "customer"]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

