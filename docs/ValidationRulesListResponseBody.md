# Voucherify.Model.ValidationRulesListResponseBody
Response body schema for **GET** `v1/validation-rules`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Object** | **string** | The type of the object represented by JSON. This object stores information about validation rules. | [optional] [default to "list"]
**DataRef** | **string** | Identifies the name of the attribute that contains the array of validation rules. | [optional] [default to "data"]
**Data** | [**List&lt;ValidationRule&gt;**](ValidationRule.md) | An array of validation rules. | [optional] 
**Total** | **int?** | Total number of validation rules in the project. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

