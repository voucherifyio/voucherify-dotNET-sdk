# Voucherify.Model.LoyaltiesMembersRedemptionRedeemResponseBody
Response body schema for **POST** `v1/loyalties/{campaignId}/members/{memberId}/redemption` and for **POST** `v1/loyalties/members/{memberId}/redemption`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique redemption ID. | [optional] 
**Object** | **string** | The type of the object represented by the JSON | [optional] [default to ObjectEnum.Redemption]
**Date** | **DateTimeOffset?** | Timestamp representing the date and time when the object was created. The value is shown in the ISO 8601 format. | [optional] 
**CustomerId** | **string** | Unique customer ID of the redeeming customer. | [optional] 
**TrackingId** | **string** | Hashed customer source ID. | [optional] 
**Metadata** | **Object** | The metadata object stores all custom attributes assigned to the redemption. | [optional] 
**Amount** | **int?** | For gift cards, this is a positive integer in the smallest currency unit (e.g. 100 cents for $1.00) representing the number of redeemed credits. For loyalty cards, this is the number of loyalty points used in the transaction. | [optional] 
**Redemption** | **string** | Unique redemption ID of the parent redemption. | [optional] 
**Result** | **string** | Redemption result. | [optional] 
**Status** | **string** | Redemption status. | [optional] 
**RelatedRedemptions** | [**LoyaltiesMembersRedemptionRedeemResponseBodyRelatedRedemptions**](LoyaltiesMembersRedemptionRedeemResponseBodyRelatedRedemptions.md) |  | [optional] 
**FailureCode** | **string** | If the result is &#x60;FAILURE&#x60;, this parameter will provide a generic reason as to why the redemption failed. | [optional] 
**FailureMessage** | **string** | If the result is &#x60;FAILURE&#x60;, this parameter will provide a more expanded reason as to why the redemption failed. | [optional] 
**Order** | [**LoyaltiesMembersRedemptionRedeemResponseBodyOrder**](LoyaltiesMembersRedemptionRedeemResponseBodyOrder.md) |  | [optional] 
**Channel** | [**LoyaltiesMembersRedemptionRedeemResponseBodyChannel**](LoyaltiesMembersRedemptionRedeemResponseBodyChannel.md) |  | [optional] 
**Customer** | [**SimpleCustomer**](SimpleCustomer.md) |  | [optional] 
**RelatedObjectType** | **string** | Defines the related object. | [optional] 
**RelatedObjectId** | **string** | Unique related object ID assigned by Voucherify, i.e. v_lfZi4rcEGe0sN9gmnj40bzwK2FH6QUno for a voucher. | [optional] 
**PromotionTier** | [**PromotionTier**](PromotionTier.md) |  | [optional] 
**Reward** | [**RedemptionRewardResult**](RedemptionRewardResult.md) |  | [optional] 
**Gift** | [**LoyaltiesMembersRedemptionRedeemResponseBodyGift**](LoyaltiesMembersRedemptionRedeemResponseBodyGift.md) |  | [optional] 
**LoyaltyCard** | [**LoyaltiesMembersRedemptionRedeemResponseBodyLoyaltyCard**](LoyaltiesMembersRedemptionRedeemResponseBodyLoyaltyCard.md) |  | [optional] 
**Voucher** | [**LoyaltiesMembersRedemptionRedeemResponseBodyVoucher**](LoyaltiesMembersRedemptionRedeemResponseBodyVoucher.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

