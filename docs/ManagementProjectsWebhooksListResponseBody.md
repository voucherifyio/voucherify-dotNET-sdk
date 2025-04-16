# Voucherify.Model.ManagementProjectsWebhooksListResponseBody
Object containing a list of webhook configurations.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Object** | **string** | The type of the object represented by JSON. This object stores information about the webhook configurations in a dictionary. | [optional] [default to ObjectEnum.List]
**DataRef** | **string** | Identifies the name of the attribute that contains the array of webhook objects. | [optional] [default to DataRefEnum.Data]
**Data** | [**List&lt;ManagementProjectsWebhook&gt;**](ManagementProjectsWebhook.md) | Array of webhook objects. | [optional] 
**Total** | **int?** | The total number of webhook objects. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

