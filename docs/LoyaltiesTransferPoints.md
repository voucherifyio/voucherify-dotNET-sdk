# Voucherify.Model.LoyaltiesTransferPoints

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | Unique loyalty card code from which the user wants to transfer loyalty points (source). | [optional] 
**Points** | **int?** | The number of loyalty points that the user wants to transfer to another loyalty card. The number of points cannot be higher than the current balance on the loyalty card (source). | [optional] 
**Reason** | **string** | Reason for the transfer. | [optional] 
**SourceId** | **string** | The merchant&#39;s transaction ID if it is different from the Voucherify transaction ID. It is really useful in case of an integration between multiple systems. It can be a transaction ID from a CRM system, database or 3rd-party service. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

