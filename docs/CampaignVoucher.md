# Voucherify.Model.CampaignVoucher
Schema model for a campaign voucher.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Type of voucher. | [optional] 
**Discount** | [**Discount**](Discount.md) |  | [optional] 
**Gift** | [**Gift**](Gift.md) |  | [optional] 
**LoyaltyCard** | [**CampaignLoyaltyCard**](CampaignLoyaltyCard.md) |  | [optional] 
**Redemption** | [**CampaignVoucherRedemption**](CampaignVoucherRedemption.md) |  | [optional] 
**CodeConfig** | [**CodeConfig**](CodeConfig.md) |  | 
**IsReferralCode** | **bool?** | Flag indicating whether this voucher is a referral code; &#x60;true&#x60; for campaign type &#x60;REFERRAL_PROGRAM&#x60;. | [optional] 
**StartDate** | **DateTimeOffset?** | Activation timestamp defines when the campaign starts to be active in ISO 8601 format. Campaign is *inactive before* this date.  | [optional] 
**ExpirationDate** | **DateTimeOffset?** | Expiration timestamp defines when the campaign expires in ISO 8601 format.  Campaign is *inactive after* this date. | [optional] 
**ValidityTimeframe** | [**ValidityTimeframe**](ValidityTimeframe.md) |  | [optional] 
**ValidityDayOfWeek** | **List&lt;CampaignVoucher.ValidityDayOfWeekEnum&gt;** | Integer array corresponding to the particular days of the week in which the voucher is valid.  - &#x60;0&#x60; Sunday - &#x60;1&#x60; Monday - &#x60;2&#x60; Tuesday - &#x60;3&#x60; Wednesday - &#x60;4&#x60; Thursday - &#x60;5&#x60; Friday - &#x60;6&#x60; Saturday | [optional] 
**ValidityHours** | [**ValidityHours**](ValidityHours.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

