# Voucherify.Model.ClientValidationsValidateRequestBody
Response body schema for **POST** `v1/validations`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Options** | [**ClientValidationsValidateRequestBodyOptions**](ClientValidationsValidateRequestBodyOptions.md) |  | [optional] 
**Redeemables** | [**List&lt;ClientValidationsValidateRequestBodyRedeemablesItem&gt;**](ClientValidationsValidateRequestBodyRedeemablesItem.md) |  | [optional] 
**Order** | [**Order**](Order.md) |  | [optional] 
**Customer** | [**Customer**](Customer.md) |  | [optional] 
**Session** | [**Session**](Session.md) |  | [optional] 
**TrackingId** | **string** | Is correspondent to Customer&#39;s source_id | [optional] 
**Metadata** | **Object** | A set of key/value pairs that you can attach to a redemption object. It can be useful for storing additional information about the redemption in a structured format. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

