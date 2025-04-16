# Voucherify.Model.VouchersTransactionsExportCreateResponseBody
Response body schema for **POST** `v1/vouchers/{code}/transactions/export`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique export ID. | [optional] 
**Object** | **string** | The type of object being represented. This object stores information about the &#x60;export&#x60;. | [optional] [default to ObjectEnum.Export]
**CreatedAt** | **DateTimeOffset?** | Timestamp representing the date and time when the export was scheduled in ISO 8601 format. | [optional] 
**Status** | **string** | Status of the export. Informs you whether the export has already been completed, i.e. indicates whether the file containing the exported data has been generated. | [optional] [default to StatusEnum.SCHEDULED]
**Channel** | **string** | The channel through which the export was triggered. | [optional] [default to "API"]
**ExportedObject** | **string** | The type of exported object. | [optional] [default to ExportedObjectEnum.VoucherTransactions]
**Parameters** | [**VoucherTransactionsFilters**](VoucherTransactionsFilters.md) |  | 
**Result** | [**VouchersTransactionsExportCreateResponseBodyResult**](VouchersTransactionsExportCreateResponseBodyResult.md) |  | [optional] 
**UserId** | **string** | Identifies the specific user who initiated the export through the Voucherify Dashboard; returned when the &#x60;channel&#x60; value is &#x60;WEBSITE&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

