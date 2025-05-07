# Voucherify.Model.CustomersUpdateRequestBody
Request body schema for **PUT** `v1/customers/{customerId}`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Customer&#39;s first and last name. | [optional] 
**Description** | **string** | An arbitrary string that you can attach to a customer object. | [optional] 
**Email** | **string** | Customer&#39;s email address. | [optional] 
**Phone** | **string** | Customer&#39;s phone number. This parameter is mandatory when you try to send out codes to customers via an SMS channel. | [optional] 
**Birthday** | **DateTime?** | &#x60;Deprecated&#x60;. ~~Customer&#39;s birthdate; format YYYY-MM-DD~~. | [optional] 
**Birthdate** | **DateTime?** | Customer&#39;s birthdate; format YYYY-MM-DD. | [optional] 
**Address** | [**CustomersUpdateRequestBodyAddress**](CustomersUpdateRequestBodyAddress.md) |  | [optional] 
**Metadata** | **Object** | A set of custom key/value pairs that you can attach to a customer. The metadata object stores all custom attributes assigned to the customer. It can be useful for storing additional information about the customer in a structured format. This metadata can be used for validating whether the customer qualifies for a discount or it can be used in building customer segments. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

