# Voucherify.Model.Export

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique export ID. | [optional] 
**Object** | **string** | The type of object being represented. This object stores information about the export. | [optional] [default to ObjectEnum.Export]
**CreatedAt** | **DateTimeOffset?** | Timestamp representing the date and time when the export was scheduled in ISO 8601 format. | [optional] 
**Status** | **string** | Status of the export. Informs you whether the export has already been completed, i.e. indicates whether the file containing the exported data has been generated. | [optional] 
**Channel** | **string** | The channel through which the export was triggered. | [optional] 
**Result** | [**ExportResult**](ExportResult.md) |  | [optional] 
**UserId** | **string** | Identifies the specific user who initiated the export through the Voucherify Dashboard; returned when the channel value is WEBSITE. | [optional] 
**ExportedObject** | **string** |  | [optional] 
**Parameters** | [**ExportParameters**](ExportParameters.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

