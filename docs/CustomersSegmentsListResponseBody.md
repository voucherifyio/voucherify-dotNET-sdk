# Voucherify.Model.CustomersSegmentsListResponseBody
Response body schema for **GET** `v1/customers/{customerId}/segments`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Object** | **string** | The type of the object represented by JSON. This object stores information about customer segments. | [optional] 
**DataRef** | **string** | Identifies the name of the JSON property that contains the array of segment IDs. | [optional] 
**Data** | [**List&lt;SimpleSegment&gt;**](SimpleSegment.md) | A dictionary that contains an array of segment IDs and names. | [optional] 
**Total** | **int?** | Total number of segments the customer belongs to. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

