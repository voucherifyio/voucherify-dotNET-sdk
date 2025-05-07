# Voucherify.Model.Error
Error details

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **int?** | Error&#39;s HTTP status code. | [optional] 
**Key** | **string** | Short string describing the kind of error which occurred. | [optional] 
**Message** | **string** | A human-readable message providing a short description of the error. | [optional] 
**Details** | **string** | A human-readable message providing more details about the error. | [optional] 
**RequestId** | **string** | This ID is useful when troubleshooting and/or finding the root cause of an error response by our support team. | [optional] 
**ResourceId** | **string** | Unique resource ID that can be used in another endpoint to get more details. | [optional] 
**ResourceType** | **string** | The resource type. | [optional] 
**VarError** | [**ErrorError**](ErrorError.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

