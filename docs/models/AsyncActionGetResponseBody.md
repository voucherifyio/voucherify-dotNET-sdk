# Voucherify.Model.AsyncActionGetResponseBody
Response body schema for **GET** `v1/async-actions/{asyncActionId}`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Async action unique ID. | [optional] 
**Type** | **string** | Type of async action. | [optional] 
**Status** | **string** | Status of the async action. Informs you whether the async action has already been completed. | [optional] 
**OperationStatus** | **string** | Status of async action processing. Informs about the async action status, whether it failed, succeeded, or the status is unknown. | [optional] 
**CreatedAt** | **DateTimeOffset** | Timestamp representing the date and time when the async action was scheduled in ISO 8601 format. | [optional] 
**UpdatedAt** | **DateTimeOffset** | Timestamp representing the date and time when the async action was updated. The value is shown in the ISO 8601 format. | [optional] 
**RequestId** | **string** | Unique request ID. | [optional] 
**ProcessingTime** | **int** | The length of time it took to process the request in milliseconds. | [optional] 
**Progress** | **int** | % progress to completion of the asynchronous action. | [optional] 
**Object** | **string** | The type of the object represented by JSON. This object stores information about the &#x60;async_action&#x60;. | [optional] [default to ObjectEnum.AsyncAction]
**Result** | **Object** |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

