# Voucherify.Model.ProductCollectionsListResponseBody
Response body schema for **GET** `v1/product-collections`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Object** | **string** | The type of the object represented by JSON. This object stores information about product collections. | [optional] 
**DataRef** | **string** | Identifies the name of the JSON property that contains the array of product collections. | [optional] 
**Data** | [**List&lt;ProductCollectionsItem&gt;**](ProductCollectionsItem.md) | A dictionary that contains an array of product collections and their details. | [optional] 
**Total** | **int?** | Total number of product collections. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

