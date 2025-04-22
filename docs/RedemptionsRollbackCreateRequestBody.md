# Voucherify.Model.RedemptionsRollbackCreateRequestBody
Request body schema for **POST** `v1/redemptions/{redemptionId}/rollback`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Reason** | **string** | Reason for the rollback. | [optional] 
**TrackingId** | **string** | Customer&#39;s &#x60;source_id&#x60;. | [optional] 
**Customer** | [**Customer**](Customer.md) |  | [optional] 
**Order** | [**Order**](Order.md) |  | [optional] 
**Metadata** | **Object** | A set of key/value pairs that you can send in the request body to update **redemption** metadata. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

