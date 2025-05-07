# Voucherify.Model.PromotionsStacksCreateResponseBody
Response body schema for **POST** `v1/promotions/{campaignId}/stacks`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Promotion stack name. | [optional] 
**Tiers** | [**PromotionsStacksCreateResponseBodyTiers**](PromotionsStacksCreateResponseBodyTiers.md) |  | [optional] 
**Id** | **string** | Unique promotion stack ID. | [optional] 
**CreatedAt** | **DateTimeOffset** | Timestamp representing the date and time when the promotion stack was created. The value is shown in the ISO 8601 format. | [optional] 
**CampaignId** | **string** | Promotion stack&#39;s parent campaign&#39;s unique ID. | [optional] 
**Object** | **string** | The type of the object represented by JSON. | [optional] [default to ObjectEnum.PromotionStack]
**CategoryId** | **string** | Promotion stack category ID. | [optional] 
**Categories** | [**List&lt;PromotionStackBase&gt;**](PromotionStackBase.md) | Details about the category assigned to the promotion stack. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

