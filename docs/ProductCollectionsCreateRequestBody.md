# Voucherify.Model.ProductCollectionsCreateRequestBody

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Show that the product collection is static (manually selected products). | [optional] [default to TypeEnum.STATIC]
**Name** | **string** | Unique user-defined product collection name. | [optional] 
**Products** | [**List&lt;ProductCollectionsCreateRequestBodyProductsItem&gt;**](ProductCollectionsCreateRequestBodyProductsItem.md) | Defines a set of products for a &#x60;STATIC&#x60; product collection type. | [optional] 
**Filter** | **Object** | Defines a set of criteria and boundary conditions for an &#x60;AUTO_UPDATE&#x60; product collection type. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

