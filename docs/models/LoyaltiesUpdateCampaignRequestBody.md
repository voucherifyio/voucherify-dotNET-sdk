# Voucherify.Model.LoyaltiesUpdateCampaignRequestBody
Request body schema for **PUT** `/loyalties/{campaignId}`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StartDate** | **DateTimeOffset** | Activation timestamp defines when the campaign starts to be active in ISO 8601 format. Campaign is *inactive before* this date.  | [optional] 
**ExpirationDate** | **DateTimeOffset** | Expiration timestamp defines when the campaign expires in ISO 8601 format.  Campaign is *inactive after* this date. | [optional] 
**ValidityTimeframe** | [**ValidityTimeframe**](ValidityTimeframe.md) |  | [optional] 
**ValidityDayOfWeek** | **List&lt;LoyaltiesUpdateCampaignRequestBody.ValidityDayOfWeekEnum&gt;** | Integer array corresponding to the particular days of the week in which the voucher is valid.  - &#x60;0&#x60; Sunday - &#x60;1&#x60; Monday - &#x60;2&#x60; Tuesday - &#x60;3&#x60; Wednesday - &#x60;4&#x60; Thursday - &#x60;5&#x60; Friday - &#x60;6&#x60; Saturday | [optional] 
**ValidityHours** | [**ValidityHours**](ValidityHours.md) |  | [optional] 
**Description** | **string** | An optional field to keep any extra textual information about the campaign such as a campaign description and details. | [optional] 
**Category** | **string** | The category assigned to the campaign. Either pass this parameter OR the &#x60;category_id&#x60;. | [optional] 
**Metadata** | **Object** | The metadata object stores all custom attributes assigned to the campaign. A set of key/value pairs that you can attach to a campaign object. It can be useful for storing additional information about the campaign in a structured format. | [optional] 
**UnsetMetadataFields** | **List&lt;string&gt;** | Determine which metadata should be removed from campaign. | [optional] 
**CategoryId** | **string** | Unique category ID that this campaign belongs to. Either pass this parameter OR the &#x60;category&#x60;. | [optional] 
**AccessSettings** | [**AccessSettings**](AccessSettings.md) |  | [optional] 
**ActivityDurationAfterPublishing** | **string** | Defines the amount of time the vouchers will be active after publishing. The value is shown in the ISO 8601 format. For example, a voucher with the value of P24D will be valid for a duration of 24 days. | [optional] 
**JoinOnce** | **bool** | If this value is set to &#x60;true&#x60;, customers will be able to join the campaign only once. It is always &#x60;false&#x60; for standalone voucher campaigns and it cannot be changed in them. | [optional] 
**AutoJoin** | **bool** | Indicates whether customers will be able to auto-join a loyalty campaign if any earning rule is fulfilled. | [optional] 
**Type** | **string** | Defines whether the campaign can be updated with new vouchers after campaign creation.  - &#x60;AUTO_UPDATE&#x60;: By choosing the auto update option you will create a campaign that can be enhanced by new vouchers after the time of creation (e.g. by publish vouchers method). -  &#x60;STATIC&#x60;: vouchers need to be manually published.  If the &#x60;type&#x60; of the campaign is &#x60;STANDALONE&#x60;, the type cannot be changed. Also, the &#x60;type&#x60; cannot be changed to &#x60;STANDALONE&#x60;. | [optional] 
**LoyaltyTiersExpiration** | [**LoyaltyTiersExpirationAll**](LoyaltyTiersExpirationAll.md) |  | [optional] 
**Options** | [**LoyaltiesUpdateCampaignRequestBodyOptions**](LoyaltiesUpdateCampaignRequestBodyOptions.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

