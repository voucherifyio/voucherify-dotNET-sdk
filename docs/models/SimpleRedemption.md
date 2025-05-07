# Voucherify.Model.SimpleRedemption
Simplified redemption data.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique redemption ID. | [optional] 
**CustomerId** | **string** | Unique customer ID of the redeeming customer. | [optional] 
**TrackingId** | **string** | Hashed customer source ID. | [optional] 
**Date** | **DateTimeOffset** | Timestamp representing the date and time when the redemption was created in the ISO 8601 format. | [optional] 
**Amount** | **int** | For gift cards, this is a positive integer in the smallest currency unit (e.g. 100 cents for $1.00) representing the number of redeemed credits. For loyalty cards, this is the number of loyalty points used in the transaction. In the case of redemption rollback, the numbers are expressed as negative integers. | [optional] 
**Order** | [**SimpleOrder**](SimpleOrder.md) |  | [optional] 
**Reward** | [**SimpleRedemptionRewardResult**](SimpleRedemptionRewardResult.md) |  | [optional] 
**Customer** | [**SimpleCustomer**](SimpleCustomer.md) |  | [optional] 
**Result** | **string** | Redemption result. | [optional] 
**Status** | **string** |  | [optional] 
**Voucher** | [**SimpleVoucher**](SimpleVoucher.md) |  | [optional] 
**PromotionTier** | [**SimplePromotionTier**](SimplePromotionTier.md) |  | [optional] 
**Redemption** | **string** | Unique redemption ID of the parent redemption. | [optional] 
**Metadata** | **Object** | The metadata object stores all custom attributes in the form of key/value pairs assigned to the redemption. | [optional] 
**FailureCode** | **string** | If the result is &#x60;FAILURE&#x60;, this parameter will provide a generic reason as to why the redemption failed. | [optional] 
**FailureMessage** | **string** | If the result is &#x60;FAILURE&#x60;, this parameter will provide an expanded reason as to why the redemption failed. | [optional] 
**Reason** | **string** | The reason for the redemption rollback. | [optional] 
**Channel** | [**SimpleRedemptionChannel**](SimpleRedemptionChannel.md) |  | [optional] 
**Object** | **string** | The type of the object represented by the JSON. This object stores information about the &#x60;redemption&#x60;. | [optional] [default to "redemption"]

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

