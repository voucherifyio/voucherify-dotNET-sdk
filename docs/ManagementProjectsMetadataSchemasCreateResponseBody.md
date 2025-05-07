# Voucherify.Model.ManagementProjectsMetadataSchemasCreateResponseBody
Response body schema for **POST** `management/v1/projects/{projectId}/metadata-schemas`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique identifier of the metadata schema. | [optional] 
**RelatedObject** | **string** | The resource type. You can define custom metadata schemas, which have a custom &#x60;\&quot;related_object\&quot;&#x60; resource type. The standard metadata schemas are: &#x60;\&quot;campaign\&quot;&#x60;, &#x60;\&quot;customer\&quot;&#x60;, &#x60;\&quot;earning_rule\&quot;&#x60;, &#x60;\&quot;loyalty_tier\&quot;&#x60;, &#x60;\&quot;order\&quot;&#x60;, &#x60;\&quot;order_item\&quot;&#x60;, &#x60;\&quot;product\&quot;&#x60;, &#x60;\&quot;promotion_tier\&quot;&#x60;, &#x60;\&quot;publication\&quot;&#x60;, &#x60;\&quot;redemption\&quot;&#x60;, &#x60;\&quot;reward\&quot;&#x60;, &#x60;\&quot;voucher\&quot;&#x60;. | [optional] 
**Properties** | [**Dictionary&lt;string, ManagementProjectsMetadataSchemaDefinition&gt;**](ManagementProjectsMetadataSchemaDefinition.md) | Contains metadata definitions. | [optional] 
**AllowDefinedOnly** | **bool?** | Restricts the creation of metadata fields when set to &#x60;true&#x60;. It indicates whether or not you can create new metadata definitions, e.g. in the campaign or publication manager. If set to &#x60;true&#x60;, then only the defined fields are available for assigning values. | [optional] 
**CreatedAt** | **DateTimeOffset?** | Timestamp representing the date and time when the metadata schema was created. The value for this parameter is shown in the ISO 8601 format. | [optional] 
**UpdatedAt** | **DateTimeOffset?** | Timestamp representing the date and time when the metadata schema was updated. The value for this parameter is shown in the ISO 8601 format. | [optional] 
**Object** | **string** | The type of the object represented by the JSON. This object stores information about the metadata schema. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

