# Voucherify.Model.TemplatesCampaignsCreateTemplateResponseBody
Response body schema for **POST** `/v1/templates/campaigns`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique identifier of the campaign template. It is assigned by Voucherify. | [optional] 
**Name** | **string** | User-defined name of the campaign template. | [optional] 
**Description** | **string** | User-defined description of the campaign template. | [optional] 
**CampaignType** | **string** | Type of the campaign used to create the campaign template. Templates created from a promotion tier are converted to &#x60;DISCOUNT_COUPONS&#x60;. | [optional] 
**CreatedAt** | **DateTimeOffset?** | Timestamp representing the date and time when the campaign template was created. The value is shown in the ISO 8601 format. | [optional] 
**Object** | **string** | The type of the object represented by JSON. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

