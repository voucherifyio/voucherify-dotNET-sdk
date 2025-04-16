# Voucherify.Model.SkusListForProduct
Contains information about child SKUs.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Object** | **string** | The type of the object represented by JSON. This object stores information about SKUs. | [optional] [default to "list"]
**DataRef** | **string** | Identifies the name of the JSON property that contains the array of SKUs. | [optional] [default to "data"]
**Data** | [**List&lt;Sku&gt;**](Sku.md) | A dictionary that contains an array of SKUs. | [optional] 
**Total** | **int?** | Total number of SKUs in the product. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

