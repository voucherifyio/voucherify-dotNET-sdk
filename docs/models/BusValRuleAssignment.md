# Voucherify.Model.BusValRuleAssignment
Assignments of business validation rule

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The unique identifier for a assignment | [optional] 
**RuleId** | **string** | The unique identifier for a rule | [optional] 
**RelatedObjectId** | **string** | The unique identifier for a related object | [optional] 
**RelatedObjectType** | **string** | The type of related object | [optional] 
**CreatedAt** | **DateTimeOffset** | Timestamp representing the date and time when the object was created. The value is shown in the ISO 8601 format. | [optional] 
**UpdatedAt** | **DateTimeOffset** | Timestamp representing the date and time when the object was last updated in ISO 8601 format. | [optional] 
**Object** | **string** | The type of the object represented by JSON. | [optional] [default to ObjectEnum.ValidationRulesAssignment]
**ValidationStatus** | **string** | The validation status of the assignment | [optional] 
**ValidationOmittedRules** | **List&lt;string&gt;** | The list of omitted rules | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

