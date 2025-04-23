# Voucherify.Model.ProductCollectionsGetResponseBody
Response body schema for **GET** `v1/product-collections/{productCollectionId}`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Product collection ID. | [optional] 
**Name** | **string** | Unique user-defined product collection name. | [optional] 
**Type** | **string** | Describes whether the product collection is dynamic (products come in and leave based on set criteria) or static (manually selected products). | [optional] 
**Filter** | **Object** | Defines a set of criteria and boundary conditions for an &#x60;AUTO_UPDATE&#x60; product collection type. | [optional] 
**Products** | [**List&lt;ProductCollectionsGetResponseBodyProductsItem&gt;**](ProductCollectionsGetResponseBodyProductsItem.md) | Defines a set of products for a &#x60;STATIC&#x60; product collection type. | [optional] 
**CreatedAt** | **DateTimeOffset?** | Timestamp representing the date and time when the product collection was created. The value is shown in the ISO 8601 format. | [optional] 
**Object** | **string** | The type of the object represented by JSON. This object stores information about the static product collection. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

