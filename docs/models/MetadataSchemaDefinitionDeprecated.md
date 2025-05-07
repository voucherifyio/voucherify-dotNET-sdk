# Voucherify.Model.MetadataSchemaDefinitionDeprecated
Custom definition name. This is also shown in **Project Settings** > **Metadata Schema** in the Voucherify Dashboard.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** |  | [optional] 
**Array** | **bool** | Indicates whether the definition is an array. | [optional] 
**Optional** | **bool** | Indicates whether this definition is optional or not optional for the resource. | [optional] 
**ObjectType** | **string** | Returns the name of the custom resource if the resource was previously defined in the Dashboard as a custom (non-standard) Nested object. | [optional] 
**Eq** | **List&lt;Object&gt;** | Array of possible values when the setting for &#x60;is equal to any of&#x60; in the Dashboard is defined explicitly. | [optional] 
**Ne** | **List&lt;Object&gt;** | Array of values that are not allowed when the setting for &#x60;is not equal to any of&#x60; in the Dashboard is defined explicitly. | [optional] 
**Lt** | **int** | A property of &#x60;number&#x60; type must have &#x60;less than&#x60; this value. | [optional] 
**Lte** | **int** | A property of &#x60;number&#x60; type must be &#x60;less than or equal&#x60; to this value. | [optional] 
**Gt** | **int** | A property of &#x60;number&#x60; type must be &#x60;greater than&#x60; this value. | [optional] 
**Gte** | **int** | A property of &#x60;number&#x60; type must be &#x60;greater than or equal&#x60; to this value. | [optional] 
**Deleted** | **bool** | Indicates whether the definition was deleted from the schema. | [optional] 
**MaxLength** | **int** | Value for maximum length when the setting for &#x60;has maximum length of&#x60; in the Dashboard is defined explicitly. | [optional] 
**MinLength** | **int** | Value indicating minimum length when the setting for &#x60;has minimum length of&#x60; in the Dashboard is defined explicitly. | [optional] 
**ExactLength** | **int** | Value indicating exact length when the setting for &#x60;has exact length of&#x60; in the Dashboard is defined explicitly. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

