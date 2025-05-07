# Voucherify.Model.LoyaltiesPointsExpirationExportCreateResponseBody
Object representing an export of points expirations. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique export ID. | [optional] 
**Object** | **string** | The type of object being represented. This object stores information about the export. | [optional] [default to ObjectEnum.Export]
**CreatedAt** | **DateTimeOffset** | Timestamp representing the date and time when the export was scheduled in ISO 8601 format. | [optional] 
**Status** | **string** | Status of the export. Informs you whether the export has already been completed. | [optional] [default to StatusEnum.SCHEDULED]
**Channel** | **string** | The channel through which the export was triggered. | [optional] 
**ExportedObject** | **string** | The type of exported object. | [optional] [default to ExportedObjectEnum.PointsExpiration]
**Parameters** | [**LoyaltiesPointsExpirationExportCreateResponseBodyParameters**](LoyaltiesPointsExpirationExportCreateResponseBodyParameters.md) |  | [optional] 
**Result** | **Object** | Always null. | [optional] 
**UserId** | **string** | &#x60;user_id&#x60; identifies the specific user who initiated the export through the Voucherify Dashboard. &#x60;user_id&#x60; is returned when the channel value is &#x60;WEBSITE&#x60;. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

