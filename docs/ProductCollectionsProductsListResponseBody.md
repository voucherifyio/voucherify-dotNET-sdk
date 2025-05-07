# Voucherify.Model.ProductCollectionsProductsListResponseBody
Response body schema for **GET** `v1/product-collections/{productCollectionId}/products`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Object** | **string** | The type of the object represented by JSON. This object stores information about products and SKUs. | [optional] 
**DataRef** | **string** | Identifies the name of the JSON property that contains the array of products and SKUs. | [optional] 
**Data** | [**List&lt;ProductCollectionsProductsListResponseBodyDataItem&gt;**](ProductCollectionsProductsListResponseBodyDataItem.md) |  | [optional] 
**Total** | **int?** | Total number of products &amp; SKUs in the product collection. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

