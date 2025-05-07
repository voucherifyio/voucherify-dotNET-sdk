# Voucherify.Model.Category
This is an object representing a category.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique category ID assigned by Voucherify. | [optional] 
**Name** | **string** | Category name. | [optional] 
**Hierarchy** | **int** | Category hierarchy. Categories with lower hierarchy are processed before categories with higher hierarchy value. | [optional] 
**Object** | **string** | The type of the object represented by the JSON. This object stores information about the category. | [optional] [default to ObjectEnum.Category]
**CreatedAt** | **DateTimeOffset** | Timestamp representing the date and time when the category was created. The value is shown in the ISO 8601 format. | [optional] 
**UpdatedAt** | **DateTimeOffset** | Timestamp representing the date and time when the category was updated. The value is shown in the ISO 8601 format. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

