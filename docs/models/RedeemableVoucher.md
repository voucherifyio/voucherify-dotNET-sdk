# Voucherify.Model.RedeemableVoucher
This is an object representing a voucher.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Assigned by the Voucherify API, identifies the voucher. | [optional] 
**Code** | **string** | A code that identifies a voucher. Pattern can use all letters of the English alphabet, Arabic numerals, and special characters. | [optional] 
**Campaign** | **string** | A unique campaign name, identifies the voucher&#39;s parent campaign. | [optional] 
**CampaignId** | **string** | Assigned by the Voucherify API, identifies the voucher&#39;s parent campaign. | [optional] 
**Category** | **string** | The value is null. | [optional] 
**CategoryId** | **string** | Unique category ID assigned by Voucherify. | [optional] 
**Categories** | **List&lt;Object&gt;** | Contains an empty array. | [optional] 
**Type** | **string** | Defines the type of the voucher.  | [optional] 
**Discount** | [**Discount**](Discount.md) |  | [optional] 
**Gift** | [**RedeemableVoucherGift**](RedeemableVoucherGift.md) |  | [optional] 
**LoyaltyCard** | [**RedeemableVoucherLoyaltyCard**](RedeemableVoucherLoyaltyCard.md) |  | [optional] 
**StartDate** | **DateTimeOffset** | Activation timestamp defines when the code starts to be active in ISO 8601 format. Voucher is *inactive before* this date.  | [optional] 
**ExpirationDate** | **DateTimeOffset** | Expiration timestamp defines when the code expires in ISO 8601 format.  Voucher is *inactive after* this date. | [optional] 
**ValidityTimeframe** | [**ValidityTimeframe**](ValidityTimeframe.md) |  | [optional] 
**ValidityDayOfWeek** | **List&lt;RedeemableVoucher.ValidityDayOfWeekEnum&gt;** | Integer array corresponding to the particular days of the week in which the voucher is valid.  - &#x60;0&#x60; Sunday - &#x60;1&#x60; Monday - &#x60;2&#x60; Tuesday - &#x60;3&#x60; Wednesday - &#x60;4&#x60; Thursday - &#x60;5&#x60; Friday - &#x60;6&#x60; Saturday | [optional] 
**ValidityHours** | [**ValidityHours**](ValidityHours.md) |  | [optional] 
**Active** | **bool** | A flag to toggle the voucher on or off. You can disable a voucher even though it&#39;s within the active period defined by the &#x60;start_date&#x60; and &#x60;expiration_date&#x60;.    - &#x60;true&#x60; indicates an *active* voucher - &#x60;false&#x60; indicates an *inactive* voucher | [optional] 
**AdditionalInfo** | **string** | An optional field to keep any extra textual information about the code such as a code description and details. | [optional] 
**Metadata** | **Object** | The metadata object stores all custom attributes assigned to the code. A set of key/value pairs that you can attach to a voucher object. It can be useful for storing additional information about the voucher in a structured format. | [optional] 
**Assets** | [**VoucherAssets**](VoucherAssets.md) |  | [optional] 
**IsReferralCode** | **bool** | Flag indicating whether this voucher is a referral code; &#x60;true&#x60; for campaign type &#x60;REFERRAL_PROGRAM&#x60;. | [optional] 
**CreatedAt** | **DateTimeOffset** | Timestamp representing the date and time when the voucher was created. The value is shown in the ISO 8601 format. | [optional] 
**UpdatedAt** | **DateTimeOffset** | Timestamp representing the date and time when the voucher was last updated in ISO 8601 format. | [optional] 
**ReferrerId** | **string** | Unique identifier of the referring person. | [optional] 
**HolderId** | **string** | Unique customer identifier of the redeemable holder. It equals to the customer ID assigned by Voucherify. | [optional] 
**Object** | **string** | The type of the object represented by JSON. Default is &#x60;voucher&#x60;. | [optional] [default to "voucher"]
**Publish** | [**RedeemableVoucherPublish**](RedeemableVoucherPublish.md) |  | [optional] 
**Redemption** | [**RedeemableVoucherRedemption**](RedeemableVoucherRedemption.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

