# Voucherify.Model.RedemptionsRedeemResponseBody
Response body schema for **POST** `v1/redemptions`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Redemptions** | [**List&lt;Redemption&gt;**](Redemption.md) |  | [optional] 
**ParentRedemption** | [**Redemption**](Redemption.md) |  | [optional] 
**Order** | [**RedemptionsRedeemResponseBodyOrder**](RedemptionsRedeemResponseBodyOrder.md) |  | [optional] 
**InapplicableRedeemables** | [**List&lt;ValidationsRedeemableInapplicable&gt;**](ValidationsRedeemableInapplicable.md) | Lists validation results of each inapplicable redeemable. | [optional] 
**SkippedRedeemables** | [**List&lt;ValidationsRedeemableSkipped&gt;**](ValidationsRedeemableSkipped.md) | Lists validation results of each redeemable. If a redeemable can be applied, the API returns &#x60;\&quot;status\&quot;: \&quot;APPLICABLE\&quot;&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

