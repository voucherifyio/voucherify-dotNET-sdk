# Voucherify.Model.LoyaltiesUpdateCampaignResponseBody
Response body schema for **PUT** `/loyalties/{campaignId}`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique campaign ID, assigned by Voucherify. | [optional] 
**Name** | **string** | Campaign name. | [optional] 
**Description** | **string** | An optional field to keep any extra textual information about the campaign such as a campaign description and details. | [optional] 
**CampaignType** | **string** | Type of campaign. | [optional] [default to CampaignTypeEnum.LOYALTYPROGRAM]
**Type** | **string** | Defines whether the campaign can be updated with new vouchers after campaign creation.      - &#x60;AUTO_UPDATE&#x60;: the campaign is dynamic, i.e. vouchers will generate based on set criteria     -  &#x60;STATIC&#x60;: vouchers need to be manually published | [optional] 
**Voucher** | [**LoyaltyCampaignVoucher**](LoyaltyCampaignVoucher.md) |  | [optional] 
**AutoJoin** | **bool** | Indicates whether customers will be able to auto-join a loyalty campaign if any earning rule is fulfilled. | [optional] 
**JoinOnce** | **bool** | If this value is set to &#x60;true&#x60;, customers will be able to join the campaign only once. | [optional] 
**UseVoucherMetadataSchema** | **bool** | Flag indicating whether the campaign is to use the voucher&#39;s metadata schema instead of the campaign metadata schema. | [optional] 
**ValidityTimeframe** | [**ValidityTimeframe**](ValidityTimeframe.md) |  | [optional] 
**ValidityDayOfWeek** | **List&lt;LoyaltiesUpdateCampaignResponseBody.ValidityDayOfWeekEnum&gt;** | Integer array corresponding to the particular days of the week in which the voucher is valid.  - &#x60;0&#x60; Sunday - &#x60;1&#x60; Monday - &#x60;2&#x60; Tuesday - &#x60;3&#x60; Wednesday - &#x60;4&#x60; Thursday - &#x60;5&#x60; Friday - &#x60;6&#x60; Saturday | [optional] 
**ValidityHours** | [**ValidityHours**](ValidityHours.md) |  | [optional] 
**ActivityDurationAfterPublishing** | **string** | Defines the amount of time the campaign will be active in ISO 8601 format after publishing. For example, a campaign with a &#x60;duration&#x60; of &#x60;P24D&#x60; will be valid for a duration of 24 days. | [optional] 
**VouchersCount** | **int** | Total number of unique vouchers in campaign. | [optional] 
**StartDate** | **DateTimeOffset** | Activation timestamp defines when the campaign starts to be active in ISO 8601 format. Campaign is *inactive before* this date.  | [optional] 
**ExpirationDate** | **DateTimeOffset** | Expiration timestamp defines when the campaign expires in ISO 8601 format.  Campaign is *inactive after* this date. | [optional] 
**Active** | **bool** | A flag to toggle the campaign on or off. You can disable a campaign even though it&#39;s within the active period defined by the &#x60;start_date&#x60; and &#x60;expiration_date&#x60;.    - &#x60;true&#x60; indicates an *active* campaign - &#x60;false&#x60; indicates an *inactive* campaign | [optional] 
**Metadata** | **Object** | The metadata object stores all custom attributes assigned to the campaign. A set of key/value pairs that you can attach to a campaign object. It can be useful for storing additional information about the campaign in a structured format. | [optional] 
**CreatedAt** | **DateTimeOffset** | Timestamp representing the date and time when the campaign was created. The value is shown in the ISO 8601 format. | [optional] 
**UpdatedAt** | **DateTimeOffset** | Timestamp representing the date and time when the campaign was last updated in ISO 8601 format. | [optional] 
**Category** | **string** | Unique category name. | [optional] 
**CreationStatus** | **string** | Indicates the status of the campaign creation. | [optional] 
**VouchersGenerationStatus** | **string** | Indicates the status of the campaign&#39;s voucher generation. | [optional] 
**Readonly** | **bool** | Indicates whether the campaign can be only read by a restricted user in the Areas and Stores enterprise feature. It is returned only to restricted users; this field is not returned for users with other roles. | [optional] 
**Protected** | **bool** | Indicates whether the resource can be deleted. | [optional] 
**CategoryId** | **string** | Unique category ID that this campaign belongs to. | [optional] 
**Categories** | [**List&lt;Category&gt;**](Category.md) | Contains details about the category. | [optional] 
**Object** | **string** | The type of the object represented by JSON. This object stores information about the campaign. | [optional] [default to "campaign"]
**LoyaltyTiersExpiration** | [**LoyaltyTiersExpirationAll**](LoyaltyTiersExpirationAll.md) |  | [optional] 
**ValidationRulesAssignments** | [**ValidationRulesAssignmentsList**](ValidationRulesAssignmentsList.md) |  | [optional] 
**AccessSettingsAssignments** | [**AccessSettingsCampaignAssignmentsList**](AccessSettingsCampaignAssignmentsList.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

