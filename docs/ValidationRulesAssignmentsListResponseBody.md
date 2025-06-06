# Voucherify.Model.ValidationRulesAssignmentsListResponseBody
Response body for **GET** `v1/validation-rules-assignments` and **GET** `v1/validation-rules/{validationRuleId}/assignments`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Object** | **string** | The type of the object represented by JSON. This object stores information about validation rule assignments. | [optional] 
**DataRef** | **string** | Identifies the name of the JSON property that contains the array of validation rule assignments. | [optional] 
**Data** | [**List&lt;ValidationRuleAssignment&gt;**](ValidationRuleAssignment.md) | A dictionary that contains an array of validation rule assignments. | [optional] 
**Total** | **int?** | Total number of validation rule assignments. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

