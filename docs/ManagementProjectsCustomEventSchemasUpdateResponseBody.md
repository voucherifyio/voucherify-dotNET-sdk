# Voucherify.Model.ManagementProjectsCustomEventSchemasUpdateResponseBody
Response body schema for **POST** `/management/v1/projects/{projectId}/custom-event-schema/{customEventSchemaId}`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique identifier of the custom event schema. | [optional] 
**Name** | **string** | User-defined name of the custom event. This is also shown in **Project Settings** &gt; **Event Schema** in the Voucherify Dashboard. | [optional] 
**Schema** | [**ManagementProjectsCustomEventSchemasUpdateResponseBodySchema**](ManagementProjectsCustomEventSchemasUpdateResponseBodySchema.md) |  | [optional] 
**CreatedAt** | **DateTimeOffset?** | Timestamp representing the date and time when the custom event schema was created. The value is shown in the ISO 8601 format. | [optional] 
**UpdatedAt** | **DateTimeOffset?** | Timestamp representing the date and time when the custom event schema was updated. The value is shown in the ISO 8601 format. | [optional] 
**Object** | **string** | The type of the object represented by JSON. | [optional] [default to ObjectEnum.CustomEventSchema]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

