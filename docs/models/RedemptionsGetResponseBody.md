# Voucherify.Model.RedemptionsGetResponseBody

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] 
**Object** | **string** |  | [optional] 
**Date** | **DateTimeOffset** | Timestamp representing the date and time when the object was created. The value is shown in the ISO 8601 format. | [optional] 
**CustomerId** | **string** | Unique customer ID of the redeeming customer. | [optional] 
**TrackingId** | **string** | Hashed customer source ID. | [optional] 
**Metadata** | **Object** | The metadata object stores all custom attributes assigned to the redemption. | [optional] 
**Amount** | **int** | For gift cards, this is a positive integer in the smallest currency unit (e.g. 100 cents for $1.00) representing the number of redeemed credits. For loyalty cards, this is the number of loyalty points used in the transaction. and For gift cards, this represents the number of the credits restored to the card in the rolledback redemption. The number is a negative integer in the smallest currency unit, e.g. -100 cents for $1.00 added back to the card. For loyalty cards, this represents the number of loyalty points restored to the card in the rolledback redemption. The number is a negative integer. | [optional] 
**Redemption** | **string** | Unique redemption ID of the parent redemption. | [optional] 
**Result** | **string** | Redemption result. | [optional] 
**Status** | **string** |  | [optional] 
**RelatedRedemptions** | [**RedemptionsGetResponseBodyRelatedRedemptions**](RedemptionsGetResponseBodyRelatedRedemptions.md) |  | [optional] 
**FailureCode** | **string** | If the result is &#x60;FAILURE&#x60;, this parameter will provide a generic reason as to why the redemption failed. | [optional] 
**FailureMessage** | **string** | If the result is &#x60;FAILURE&#x60;, this parameter will provide a more expanded reason as to why the redemption failed. | [optional] 
**Order** | [**RedemptionsGetResponseBodyOrder**](RedemptionsGetResponseBodyOrder.md) |  | [optional] 
**Channel** | [**RedemptionsGetResponseBodyChannel**](RedemptionsGetResponseBodyChannel.md) |  | [optional] 
**Customer** | [**RedemptionsGetResponseBodyCustomer**](RedemptionsGetResponseBodyCustomer.md) |  | [optional] 
**RelatedObjectType** | **string** | Defines the related object. | [optional] 
**RelatedObjectId** | **string** |  | [optional] 
**PromotionTier** | [**RedemptionsGetResponseBodyPromotionTier**](RedemptionsGetResponseBodyPromotionTier.md) |  | [optional] 
**Reward** | [**RedemptionRewardResult**](RedemptionRewardResult.md) |  | [optional] 
**Gift** | [**RedemptionsGetResponseBodyGift**](RedemptionsGetResponseBodyGift.md) |  | [optional] 
**LoyaltyCard** | [**RedemptionsGetResponseBodyLoyaltyCard**](RedemptionsGetResponseBodyLoyaltyCard.md) |  | [optional] 
**Voucher** | [**RedemptionsGetResponseBodyVoucher**](RedemptionsGetResponseBodyVoucher.md) |  | [optional] 
**Reason** | **string** | System generated cause for the redemption being invalid in the context of the provided parameters. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

