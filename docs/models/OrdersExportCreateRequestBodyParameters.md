# Voucherify.Model.OrdersExportCreateRequestBodyParameters
List of available fields and filters that can be exported with an order along with the sorting order of the returned data.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Order** | **ExportOrderOrder** |  | [optional] 
**Fields** | [**List&lt;ExportOrderFields&gt;**](ExportOrderFields.md) | Array of strings containing the data in the export. These fields define the headers in the CSV file. | [optional] 
**Filters** | **Object** | Allowed additional properties must start with \&quot;metadata.\&quot; | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

