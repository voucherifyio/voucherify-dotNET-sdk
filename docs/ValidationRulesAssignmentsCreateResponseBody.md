# Voucherify.Model.ValidationRulesAssignmentsCreateResponseBody
Response body for **POST** `v1/validation-rules/{validationRuleId}/assignments`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Validation rule assignment ID. | [optional] 
**RuleId** | **string** | Validation rule ID. | [optional] 
**RelatedObjectId** | **string** | The resource ID to which the validation rule was assigned. | [optional] 
**RelatedObjectType** | **string** | The type of resource to which the validation rule was assigned. | [optional] 
**CreatedAt** | **DateTimeOffset?** | Timestamp representing the date and time when the validation rule assignment was created. The value is shown in the ISO 8601 format. | [optional] 
**Object** | **string** | The type of the object represented by the ID. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

