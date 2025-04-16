# Voucherify.Model.RedemptionsListResponseBodyRedemptionsItemOrderItemsItemSku

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | A unique identifier that represents the SKU and is assigned by Voucherify. | [optional] 
**SourceId** | **string** | The merchant&#39;s SKU ID (if it is different than Voucherify&#39;s SKU ID). It is really useful in case of integration between multiple systems. It can be an ID from an eCommerce site, a database or a 3rd party service. | [optional] 
**Override** | **bool** | The override set to &#x60;true&#x60; is used to store the product information in the system. If the product does not exist, it will be created with a source_id; if it does exist, the provided values for the name, price, and metadata will replace those already stored in the system. | [optional] 
**Sku** | **string** | The SKU name. | [optional] 
**Price** | **decimal** | SKU price. A positive integer in the smallest currency unit (e.g. 100 cents for $1.00). | [optional] 
**Metadata** | **Object** | A set of custom key/value pairs that you can attach to an SKU. It can be useful for storing additional information about the SKU in a structured format. It can be used to create product collections. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

