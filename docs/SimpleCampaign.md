# Voucherify.Model.SimpleCampaign
Simplified campaign data.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Campaign ID. | [optional] 
**Name** | **string** | Campaign name. | [optional] 
**CampaignType** | **string** | Type of campaign. | [optional] 
**Type** | **string** | Defines whether the campaign can be updated with new vouchers after campaign creation or if the campaign consists of standalone vouchers.  - &#x60;AUTO_UPDATE&#x60;: the campaign is dynamic, i.e. vouchers will generate based on set criteria -  &#x60;STATIC&#x60;: vouchers need to be manually published - &#x60;STANDALONE&#x60;: campaign for single vouchers | [optional] 
**IsReferralCode** | **bool?** | Flag indicating whether this voucher is a referral code; &#x60;true&#x60; for campaign type &#x60;REFERRAL_PROGRAM&#x60;. | [optional] 
**Voucher** | [**SimpleCampaignVoucher**](SimpleCampaignVoucher.md) |  | [optional] 
**ReferralProgram** | [**ReferralProgram**](ReferralProgram.md) |  | [optional] 
**AutoJoin** | **bool?** | Indicates whether customers will be able to auto-join the campaign if any earning rule is fulfilled. | [optional] 
**JoinOnce** | **bool?** | If this value is set to &#x60;true&#x60;, customers will be able to join the campaign only once. It is always &#x60;false&#x60; for standalone voucher campaigns and it cannot be changed in them. | [optional] 
**Active** | **bool?** | Indicates whether the campaign is active. | [optional] 
**CategoryId** | **string** | The unique category ID that this campaign belongs to. | [optional] 
**Category** | **string** | Unique category name. | [optional] 
**Categories** | [**List&lt;Category&gt;**](Category.md) | Contains details about the category. | [optional] 
**Metadata** | **Object** | A set of custom key/value pairs that you can attach to a campaign. The metadata object stores all custom attributes assigned to the campaign. | [optional] 
**StartDate** | **DateTimeOffset?** | Activation timestamp defines when the campaign starts to be active in ISO 8601 format. Campaign is inactive *before* this date.  | [optional] 
**ExpirationDate** | **DateTimeOffset?** | Expiration timestamp defines when the campaign expires in ISO 8601 format.  Campaign is inactive *after* this date. | [optional] 
**Description** | **string** | An optional field to keep extra textual information about the campaign such as a campaign description and details. | [optional] 
**CreatedAt** | **DateTimeOffset?** | Timestamp representing the date and time when the campaign was created. The value is shown in the ISO 8601 format. | [optional] 
**UpdatedAt** | **DateTimeOffset?** | Timestamp representing the date and time when the campaign was updated in the ISO 8601 format. | [optional] 
**Object** | **string** | The type of the object represented by JSON. This object stores information about the campaign. | [optional] [default to ObjectEnum.Campaign]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

