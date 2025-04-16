# Voucherify.Model.ProductsListResponseBody
Response body schema for **GET** `v1/products`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Object** | **string** | The type of the object represented by JSON. This object stores information about products in a dictionary. | [optional] [default to "list"]
**DataRef** | **string** | Identifies the name of the attribute that contains the array of product objects. | [optional] [default to "products"]
**Products** | [**List&lt;Product&gt;**](Product.md) | Contains array of product objects. | [optional] 
**Total** | **int?** | Total number of product objects. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

