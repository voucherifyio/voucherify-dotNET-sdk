# Voucherify.Model.SegmentsGetResponseBody
Response body schema for **GET** `v1/v1/segments/{segmentId}`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique segment ID. | [optional] 
**Name** | **string** | Segment name. | [optional] 
**CreatedAt** | **DateTimeOffset?** | Timestamp representing the date and time when the segment was created. The value is shown in the ISO 8601 format. | [optional] 
**Type** | **string** | Describes whether the segment is dynamic (customers come in and leave based on set criteria) or static (manually selected customers). | [optional] 
**Filter** | **Object** | Defines a set of criteria for an &#x60;auto-update&#x60; segment type.   | [optional] 
**InitialSyncStatus** | **string** |  | [optional] 
**Object** | **string** | The type of the object represented by JSON. This object stores information about the customer segment. | [optional] [default to ObjectEnum.Segment]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

