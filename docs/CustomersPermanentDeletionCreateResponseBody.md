# Voucherify.Model.CustomersPermanentDeletionCreateResponseBody
Response body schema for **POST** `v1/customers/{customerId}/permanent-deletion`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique permanent deletion object ID. | [optional] 
**CreatedAt** | **DateTimeOffset?** | Timestamp representing the date and time when the customer was requested to be deleted in ISO 8601 format. | [optional] 
**RelatedObjectId** | **string** | Unique customer ID that is being deleted. | [optional] 
**RelatedObject** | **string** | Object being deleted. | [optional] 
**Status** | **string** | Deletion status. | [optional] 
**DataJson** | [**CustomersPermanentDeletionCreateResponseBodyDataJson**](CustomersPermanentDeletionCreateResponseBodyDataJson.md) |  | [optional] 
**Object** | **string** | The type of the object represented by JSON. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

