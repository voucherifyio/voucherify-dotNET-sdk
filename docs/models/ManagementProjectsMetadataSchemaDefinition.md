# Voucherify.Model.ManagementProjectsMetadataSchemaDefinition
Custom definition name. This is also shown in **Project Settings** > **Metadata Schema** in the Voucherify Dashboard.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Indicates the type of metadata. Note that &#x60;\&quot;geopoint\&quot;&#x60; type is a paid feature. | [optional] 
**Optional** | **bool** | Indicates if this definition is optional or not for the resource. | [optional] 
**Array** | **bool** | Indicates if the definition is an array. | [optional] 
**Deleted** | **bool** | Indicates if the definition has been deleted from the schema. | [optional] 
**ObjectType** | **string** | The name of the custom resource (i.e. a nested object) if the resource has been previously defined. Otherwise, it is &#x60;null&#x60; for other types. | [optional] 
**MinLength** | **int** | Value indicating the minimum length. Available only for the &#x60;string&#x60; type. | [optional] 
**MaxLength** | **int** | Value indicating the maximum length. Available only for the &#x60;string&#x60; type. | [optional] 
**ExactLength** | **int** | Value indicating the exact length. Available only for the &#x60;string&#x60; type. | [optional] 
**Eq** | **List&lt;Object&gt;** |  | [optional] 
**Ne** | **List&lt;decimal&gt;** | Array of values that are not allowed. Available only for the &#x60;number&#x60; type. | [optional] 
**Lt** | **decimal** | A property of the &#x60;number&#x60; type must have &#x60;less than&#x60; this value. The value should be up to two decimal places. | [optional] 
**Lte** | **decimal** | A property of the &#x60;number&#x60; type must be &#x60;less than or equal&#x60; to this value. The value should be up to two decimal places. | [optional] 
**Gt** | **decimal** | A property of &#x60;number&#x60; type must be &#x60;greater than&#x60; this value. The value should be up to two decimal places. | [optional] 
**Gte** | **decimal** | A property of &#x60;number&#x60; type must be &#x60;greater than or equal&#x60; to this value. The value should be up to two decimal places. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

