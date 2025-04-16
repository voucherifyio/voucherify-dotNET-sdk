# Voucherify.Model.RedemptionsRollbackCreateResponseBody
Response body schema for **POST** `v1/redemptions/{redemptionId}/rollback`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique identifier of the redemption rollback. | [optional] 
**Object** | **string** | The type of the object represented by the JSON | [optional] [default to ObjectEnum.RedemptionRollback]
**Date** | **DateTimeOffset?** | Timestamp representing the date and time when the object was created. The value is shown in the ISO 8601 format. | [optional] 
**CustomerId** | **string** | Unique customer ID of the redeeming customer. | [optional] 
**TrackingId** | **string** | Hashed customer source ID. | [optional] 
**Metadata** | **Object** | The metadata object stores all custom attributes assigned to the redemption. | [optional] 
**Amount** | **int?** | For gift cards, this represents the number of the credits restored to the card in the rolledback redemption. The number is a negative integer in the smallest currency unit, e.g. -100 cents for $1.00 added back to the card. For loyalty cards, this represents the number of loyalty points restored to the card in the rolledback redemption. The number is a negative integer. | [optional] 
**Redemption** | **string** | Unique redemption ID of the parent redemption. | [optional] 
**Reason** | **string** | System generated cause for the redemption being invalid in the context of the provided parameters. | [optional] 
**Result** | **string** | Redemption result. | [optional] 
**Status** | **string** | Redemption status. | [optional] 
**FailureCode** | **string** | If the result is &#x60;FAILURE&#x60;, this parameter will provide a generic reason as to why the redemption failed. | [optional] 
**FailureMessage** | **string** | If the result is &#x60;FAILURE&#x60;, this parameter will provide a more expanded reason as to why the redemption failed. | [optional] 
**Order** | [**RedemptionsRollbackCreateResponseBodyOrder**](RedemptionsRollbackCreateResponseBodyOrder.md) |  | [optional] 
**Channel** | [**RedemptionsRollbackCreateResponseBodyChannel**](RedemptionsRollbackCreateResponseBodyChannel.md) |  | [optional] 
**Customer** | [**SimpleCustomer**](SimpleCustomer.md) |  | [optional] 
**RelatedObjectType** | **string** | Defines the related object. | [optional] 
**RelatedObjectId** | **string** | Unique identifier of the related object. It is assigned by Voucherify, i.e. &#x60;v_lfZi4rcEGe0sN9gmnj40bzwK2FH6QUno&#x60; for a voucher. | [optional] 
**Voucher** | [**Voucher**](Voucher.md) |  | [optional] 
**PromotionTier** | [**PromotionTier**](PromotionTier.md) |  | [optional] 
**Reward** | [**RedemptionRewardResult**](RedemptionRewardResult.md) |  | [optional] 
**Gift** | [**RedemptionsRollbackCreateResponseBodyGift**](RedemptionsRollbackCreateResponseBodyGift.md) |  | [optional] 
**LoyaltyCard** | [**RedemptionsRollbackCreateResponseBodyLoyaltyCard**](RedemptionsRollbackCreateResponseBodyLoyaltyCard.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

