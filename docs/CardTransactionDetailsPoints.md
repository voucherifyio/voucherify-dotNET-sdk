# Voucherify.Model.CardTransactionDetailsPoints
Points affected by the transaction (variant-dependent fields; pending points don't return `expiration_date` and `expiration_type`.).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Total** | **decimal?** | Number of points. Negative for debits. | [optional] 
**ExpirationDate** | **DateTime?** | Expiration date of the affected points (&#x60;YYYY-MM-DD&#x60;), or &#x60;null&#x60;. | [optional] 
**ExpirationType** | **string** | Points expiration type of the affected points, or &#x60;null&#x60;. | [optional] 
**Date** | **DateTime?** | Activation date of the pending points (&#x60;YYYY-MM-DD&#x60;). Pending points variants only. | [optional] 
**Type** | **string** | Pending points activation type. Pending points variants only. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

