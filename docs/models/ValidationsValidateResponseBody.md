# Voucherify.Model.ValidationsValidateResponseBody
Response body schema for **POST** `v1/validations`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StackingRules** | [**StackingRules**](StackingRules.md) |  | 
**Id** | **string** | Unique identifier of the validation, assigned by Voucherify. | [optional] 
**Valid** | **bool** | The result of the validation. It takes all of the redeemables into account and returns a &#x60;false&#x60; if at least one redeemable is inapplicable. Returns &#x60;true&#x60; if all redeemables are applicable. | [optional] 
**Redeemables** | [**List&lt;ValidationsValidateResponseBodyRedeemablesItem&gt;**](ValidationsValidateResponseBodyRedeemablesItem.md) |  | [optional] 
**SkippedRedeemables** | [**List&lt;ValidationsRedeemableSkipped&gt;**](ValidationsRedeemableSkipped.md) | Lists validation results of each skipped redeemable. | [optional] 
**InapplicableRedeemables** | [**List&lt;ValidationsRedeemableInapplicable&gt;**](ValidationsRedeemableInapplicable.md) | Lists validation results of each inapplicable redeemable. | [optional] 
**Order** | [**ValidationsValidateResponseBodyOrder**](ValidationsValidateResponseBodyOrder.md) |  | [optional] 
**TrackingId** | **string** | Hashed customer source ID. | [optional] 
**Session** | [**Session**](Session.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

