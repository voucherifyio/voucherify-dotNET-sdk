# Voucherify.Model.MemberActivityDataRedemption

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique redemption ID. | [optional] 
**CustomerId** | **string** | Unique customer ID of the redeeming customer. | [optional] 
**TrackingId** | **string** | Hashed customer source ID. | [optional] 
**Date** | **DateTimeOffset** | Timestamp representing the date and time when the redemption was created in the ISO 8601 format. | [optional] 
**Amount** | **int** | For gift cards, this is a positive integer in the smallest currency unit (e.g. 100 cents for $1.00) representing the number of redeemed credits. For loyalty cards, this is the number of loyalty points used in the transaction. In the case of redemption rollback, the numbers are expressed as negative integers. and For gift cards, this is a positive integer in the smallest currency unit (e.g. 100 cents for $1.00) representing the number of redeemed credits. For loyalty cards, this is the number of loyalty points used in the transaction. | [optional] 
**Order** | [**MemberActivityDataRedemptionOrder**](MemberActivityDataRedemptionOrder.md) |  | [optional] 
**Reward** | [**MemberActivityDataRedemptionReward**](MemberActivityDataRedemptionReward.md) |  | [optional] 
**Customer** | [**SimpleCustomer**](SimpleCustomer.md) |  | [optional] 
**Result** | **string** | Redemption result. | [optional] 
**Status** | **string** |  | [optional] 
**Voucher** | [**MemberActivityDataRedemptionVoucher**](MemberActivityDataRedemptionVoucher.md) |  | [optional] 
**PromotionTier** | [**MemberActivityDataRedemptionPromotionTier**](MemberActivityDataRedemptionPromotionTier.md) |  | [optional] 
**Redemption** | **string** | Unique redemption ID of the parent redemption. | [optional] 
**Metadata** | **Object** | The metadata object stores all custom attributes in the form of key/value pairs assigned to the redemption. and The metadata object stores all custom attributes assigned to the redemption. | [optional] 
**FailureCode** | **string** | If the result is &#x60;FAILURE&#x60;, this parameter will provide a generic reason as to why the redemption failed. | [optional] 
**FailureMessage** | **string** |  | [optional] 
**Reason** | **string** |  | [optional] 
**Channel** | [**MemberActivityDataRedemptionChannel**](MemberActivityDataRedemptionChannel.md) |  | [optional] 
**Object** | **string** | The type of the object represented by the JSON. This object stores information about the &#x60;redemption&#x60;. | [optional] [default to "redemption"]
**CreatedAt** | **DateTimeOffset** | Timestamp representing the date and time when the redemption was created. The value is shown in the ISO 8601 format. | [optional] 
**ChannelType** | **string** | The source of the channel for the redemption rollback. A &#x60;USER&#x60; corresponds to the Voucherify Dashboard and an &#x60;API&#x60; corresponds to the API. | [optional] 
**ChannelId** | **string** | Unique channel ID of the user performing the redemption. This is either a user ID from a user using the Voucherify Dashboard or an X-APP-Id of a user using the API. | [optional] 
**PreviousOrder** | [**MemberActivityDataRedemptionPreviousOrder**](MemberActivityDataRedemptionPreviousOrder.md) |  | [optional] 
**RelatedRedemptions** | [**MemberActivityDataRedemptionRelatedRedemptions**](MemberActivityDataRedemptionRelatedRedemptions.md) |  | [optional] 
**ParentRedemptionId** | **string** | Unique redemption ID of the parent redemption. | [optional] 
**RelatedObjectType** | **string** | Defines the related object. | [optional] 
**RelatedObjectId** | **string** | Unique related object ID assigned by Voucherify, i.e. v_lfZi4rcEGe0sN9gmnj40bzwK2FH6QUno for a voucher. | [optional] 
**RelatedObjectParentId** | **string** | Unique related parent object ID assigned by Voucherify, i.e. v_lfZi4rcEGe0sN9gmnj40bzwK2FH6QUno for a voucher. | [optional] 
**CampaignName** | **string** | Campaign name | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

