# Voucherify.Model.CategoriesCreateResponseBody
Response body schema for **POST** `v1/categories`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique category ID assigned by Voucherify. | [optional] 
**Name** | **string** | Category name. | [optional] 
**Hierarchy** | **int?** | Category hierarchy. Categories with lower hierarchy are processed before categories with higher hierarchy value. | [optional] 
**Object** | **string** |  | [optional] 
**CreatedAt** | **DateTimeOffset?** | Timestamp representing the date and time when the category was created. The value is shown in the ISO 8601 format. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

