# Voucherify.Model.CategoriesListResponseBody
Response body schema for **GET** `v1/categories`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Object** | **string** | The type of the object represented by JSON. This object stores information about categories in a dictionary. | [optional] [default to ObjectEnum.List]
**DataRef** | **string** | Identifies the name of the attribute that contains the array of category objects. | [optional] [default to DataRefEnum.Data]
**Data** | [**List&lt;Category&gt;**](Category.md) |  | [optional] 
**Total** | **int** | Total number of categories. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

