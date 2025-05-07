# Voucherify.Model.SimpleVoucher
Simplified voucher data.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | A unique identifier that represents the voucher assigned by Voucherify. | [optional] 
**Code** | **string** | Voucher code. | [optional] 
**Gift** | [**Gift**](Gift.md) |  | [optional] 
**Discount** | [**Discount**](Discount.md) |  | [optional] 
**LoyaltyCard** | [**SimpleLoyaltyCard**](SimpleLoyaltyCard.md) |  | [optional] 
**Type** | **string** | Type of the voucher. | [optional] 
**Campaign** | **string** | Campaign name. | [optional] 
**CampaignId** | **string** | Campaign unique ID. | [optional] 
**IsReferralCode** | **bool?** | Flag indicating whether this voucher is a referral code; &#x60;true&#x60; for campaign type &#x60;REFERRAL_PROGRAM&#x60;. | [optional] 
**HolderId** | **string** | Unique customer identifier of the redeemable holder. It equals to the customer ID assigned by Voucherify. | [optional] 
**ReferrerId** | **string** | Unique identifier of the referrer assigned by Voucherify. | [optional] 
**CategoryId** | **string** | Unique identifier of the category that this voucher belongs to. | [optional] 
**Categories** | [**List&lt;Category&gt;**](Category.md) | Contains details about the category. | [optional] 
**Active** | **bool?** | Shows whether the voucher is on or off. &#x60;true&#x60; indicates an *active* voucher and &#x60;false&#x60; indicates an *inactive* voucher. | [optional] 
**CreatedAt** | **DateTimeOffset?** | Timestamp representing the date and time when the order was created in the ISO 8601 format. | [optional] 
**UpdatedAt** | **DateTimeOffset?** | Timestamp representing the date and time when the order was created. The value is shown in the ISO 8601 format. | [optional] 
**Redemption** | [**SimpleVoucherRedemption**](SimpleVoucherRedemption.md) |  | [optional] 
**StartDate** | **DateTimeOffset?** | Activation timestamp defines when the code starts to be active in ISO 8601 format. Voucher is *inactive before* this date. | [optional] 
**ExpirationDate** | **DateTimeOffset?** | Expiration timestamp defines when the code expires in ISO 8601 format.  Voucher is *inactive after* this date. | [optional] 
**Metadata** | **Object** | A set of custom key/value pairs that you can attach to a voucher. The metadata object stores all custom attributes assigned to the voucher. | [optional] 
**Object** | **string** | The type of the object represented by JSON. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

