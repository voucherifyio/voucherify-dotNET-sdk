# Voucherify.Model.MemberActivityDataRedemptionVoucher

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] 
**Code** | **string** |  | [optional] 
**Gift** | [**MemberActivityDataRedemptionVoucherGift**](MemberActivityDataRedemptionVoucherGift.md) |  | [optional] 
**Discount** | [**Discount**](Discount.md) |  | [optional] 
**LoyaltyCard** | [**MemberActivityDataRedemptionVoucherLoyaltyCard**](MemberActivityDataRedemptionVoucherLoyaltyCard.md) |  | [optional] 
**Type** | **string** |  | [optional] 
**Campaign** | **string** |  | [optional] 
**CampaignId** | **string** |  | [optional] 
**IsReferralCode** | **bool** | Flag indicating whether this voucher is a referral code; &#x60;true&#x60; for campaign type &#x60;REFERRAL_PROGRAM&#x60;. | [optional] 
**HolderId** | **string** | Unique customer identifier of the redeemable holder. It equals to the customer ID assigned by Voucherify. | [optional] 
**ReferrerId** | **string** |  | [optional] 
**CategoryId** | **string** |  | [optional] 
**Categories** | [**List&lt;Category&gt;**](Category.md) | Contains details about the category. | [optional] 
**Active** | **bool** | Shows whether the voucher is on or off. &#x60;true&#x60; indicates an *active* voucher and &#x60;false&#x60; indicates an *inactive* voucher. and A flag to toggle the voucher on or off. You can disable a voucher even though it&#39;s within the active period defined by the &#x60;start_date&#x60; and &#x60;expiration_date&#x60;.    - &#x60;true&#x60; indicates an *active* voucher - &#x60;false&#x60; indicates an *inactive* voucher | [optional] 
**CreatedAt** | **string** |  | [optional] 
**UpdatedAt** | **string** |  | [optional] 
**Redemption** | [**MemberActivityDataRedemptionVoucherRedemption**](MemberActivityDataRedemptionVoucherRedemption.md) |  | [optional] 
**StartDate** | **string** |  | [optional] 
**ExpirationDate** | **DateTimeOffset** | Expiration timestamp defines when the code expires in ISO 8601 format.  Voucher is *inactive after* this date. | [optional] 
**Metadata** | **Object** | A set of custom key/value pairs that you can attach to a voucher. The metadata object stores all custom attributes assigned to the voucher. and The metadata object stores all custom attributes assigned to the code. A set of key/value pairs that you can attach to a voucher object. It can be useful for storing additional information about the voucher in a structured format. | [optional] 
**Object** | **string** |  | [optional] 
**Category** | **string** | Tag defining the category that this voucher belongs to. Useful when listing vouchers using the List Vouchers endpoint. | [optional] 
**ValidityTimeframe** | [**ValidityTimeframe**](ValidityTimeframe.md) |  | [optional] 
**ValidityDayOfWeek** | **List&lt;MemberActivityDataRedemptionVoucher.ValidityDayOfWeekEnum&gt;** | Integer array corresponding to the particular days of the week in which the voucher is valid.  - &#x60;0&#x60; Sunday - &#x60;1&#x60; Monday - &#x60;2&#x60; Tuesday - &#x60;3&#x60; Wednesday - &#x60;4&#x60; Thursday - &#x60;5&#x60; Friday - &#x60;6&#x60; Saturday | [optional] 
**ValidityHours** | [**ValidityHours**](ValidityHours.md) |  | [optional] 
**AdditionalInfo** | **string** | An optional field to keep any extra textual information about the code such as a code description and details. | [optional] 
**Assets** | [**VoucherAssets**](VoucherAssets.md) |  | [optional] 
**Publish** | [**MemberActivityDataRedemptionVoucherPublish**](MemberActivityDataRedemptionVoucherPublish.md) |  | [optional] 
**ValidationRulesAssignments** | [**ValidationRulesAssignmentsList**](ValidationRulesAssignmentsList.md) |  | [optional] 
**Holder** | [**SimpleCustomer**](SimpleCustomer.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

