# Voucherify.Model.ManagementProjectsBrandingCreateRequestBodyCockpits
Defines customer cockpit details.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CampaignsOverviewEnabled** | **bool?** | Enables the campaign overview for customers. | [optional] [default to false]
**LoyaltyEnabled** | **bool?** | Enables the loyalty campaign overview for customers. | [optional] [default to true]
**GiftCardsEnabled** | **bool?** | Enables the gift card overview for customers. | [optional] [default to true]
**CouponsEnabled** | **bool?** | Enables the discount coupon overview for customers. | [optional] [default to true]
**ReferralsEnabled** | **bool?** | Enables the referral campaign overview for customers. | [optional] [default to true]
**Theme** | **string** | Determines the color scheme of the customer cockpit. | [optional] [default to ThemeEnum.Default]
**UseCustomDoubleOptInRedirectUrl** | **bool?** | Enables the double opt-in option. It must be a valid URL format. | [optional] [default to false]
**CustomDoubleOptInRedirectUrl** | **string** | Defines the URL for the double opt-in consent. It must be a valid URL format. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

