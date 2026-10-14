# Voucherify.Model.CardTransactionDetails
Card transaction details. Variant-dependent fields are not present on all variants.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Reason** | **string** | Reason for the transaction (e.g. the reason provided in a manual adjustment request). | [optional] 
**Rejection** | [**CardTransactionDetailsRejection**](CardTransactionDetailsRejection.md) |  | [optional] 
**Metadata** | **Object** | Transaction metadata (empty object when none). | [optional] 
**Points** | [**CardTransactionDetailsPoints**](CardTransactionDetailsPoints.md) |  | [optional] 
**Bucket** | [**LoyaltyV2CardPointsBucketSimple**](LoyaltyV2CardPointsBucketSimple.md) |  | [optional] 
**Buckets** | [**List&lt;LoyaltyV2CardPointsBucketSimple&gt;**](LoyaltyV2CardPointsBucketSimple.md) | The points buckets that expired (&#x60;POINTS_EXPIRED&#x60; only). | [optional] 
**Date** | **DateTime?** | Expiration date (&#x60;POINTS_EXPIRED&#x60; only, &#x60;YYYY-MM-DD&#x60;). | [optional] 
**Reward** | [**CardTransactionDetailsReward**](CardTransactionDetailsReward.md) |  | [optional] 
**RewardTransaction** | [**CardTransactionDetailsRewardTransaction**](CardTransactionDetailsRewardTransaction.md) |  | [optional] 
**CardTransaction** | [**CardTransactionDetailsCardTransaction**](CardTransactionDetailsCardTransaction.md) |  | [optional] 
**Purchase** | [**CardTransactionDetailsPurchase**](CardTransactionDetailsPurchase.md) |  | [optional] 
**Order** | [**CardTransactionDetailsOrder**](CardTransactionDetailsOrder.md) |  | [optional] 
**OrderTransaction** | [**CardTransactionDetailsOrderTransaction**](CardTransactionDetailsOrderTransaction.md) |  | [optional] 
**TargetCard** | [**CardTransactionDetailsTargetCard**](CardTransactionDetailsTargetCard.md) |  | [optional] 
**PurchaseTransaction** | [**CardTransactionDetailsPurchaseTransaction**](CardTransactionDetailsPurchaseTransaction.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

