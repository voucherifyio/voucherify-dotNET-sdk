# Voucherify.Model.LoyaltyCampaignVoucher
Schema model for a campaign voucher.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CodeConfig** | [**CodeConfig**](CodeConfig.md) |  | 
**Type** | **string** | Type of voucher. | [optional] [default to TypeEnum.LOYALTYCARD]
**LoyaltyCard** | [**CampaignLoyaltyCard**](CampaignLoyaltyCard.md) |  | [optional] 
**Redemption** | [**LoyaltyCampaignVoucherRedemption**](LoyaltyCampaignVoucherRedemption.md) |  | [optional] 
**IsReferralCode** | **bool** | Always &#x60;false&#x60; for a loyalty card voucher | [optional] 
**StartDate** | **DateTimeOffset** | Activation timestamp defines when the campaign starts to be active in ISO 8601 format. Campaign is *inactive before* this date.  | [optional] 
**ExpirationDate** | **DateTimeOffset** | Expiration timestamp defines when the campaign expires in ISO 8601 format.  Campaign is *inactive after* this date. | [optional] 
**ValidityTimeframe** | [**ValidityTimeframe**](ValidityTimeframe.md) |  | [optional] 
**ValidityDayOfWeek** | **List&lt;LoyaltyCampaignVoucher.ValidityDayOfWeekEnum&gt;** | Integer array corresponding to the particular days of the week in which the voucher is valid.  - &#x60;0&#x60; Sunday - &#x60;1&#x60; Monday - &#x60;2&#x60; Tuesday - &#x60;3&#x60; Wednesday - &#x60;4&#x60; Thursday - &#x60;5&#x60; Friday - &#x60;6&#x60; Saturday | [optional] 
**ValidityHours** | [**ValidityHours**](ValidityHours.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

