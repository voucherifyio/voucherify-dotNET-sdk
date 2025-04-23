# Voucherify.Model.TemplatesCampaignsCampaignSetupCreateResponseBody
Response body schema for **POST** `/v1/templates/campaigns/{campaignTemplateId}/campaign-setup`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CreatedResources** | [**List&lt;TemplatesCampaignsCampaignSetupCreateResponseBodyCreatedResourcesItem&gt;**](TemplatesCampaignsCampaignSetupCreateResponseBodyCreatedResourcesItem.md) | Contains a list of resources that have been added to the project when the campaign has been created out of the template. | [optional] 
**Campaign** | [**Campaign**](Campaign.md) |  | 
**Object** | **string** | The type of the object represented by JSON. This object stores information about the campaign created out of the campaign template. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

