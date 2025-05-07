# Voucherify.Model.ProductsSkusUpdateRequestBody
Request body schema for **PUT** `v1/products/{productId}/skus/{skuId}`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Sku** | **string** | Unique user-defined SKU name. | [optional] 
**Price** | **int?** | SKU unit price. The value is multiplied by 100 to represent 2 decimal places. For example &#x60;10000 cents&#x60; for &#x60;$100.00&#x60;. | [optional] 
**Currency** | **string** | SKU price currency. | [optional] 
**Attributes** | **Object** | The attributes object stores values for all custom attributes inherited by the SKU from the parent product. A set of key/value pairs that are attached to a SKU object and are unique to each SKU within a product family. | [optional] 
**ImageUrl** | **string** | The HTTPS URL pointing to the .png or .jpg file that will be used to render the SKU image. | [optional] 
**Metadata** | **Object** | The metadata object stores all custom attributes assigned to the SKU. A set of key/value pairs that you can attach to a SKU object. It can be useful for storing additional information about the SKU in a structured format. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

