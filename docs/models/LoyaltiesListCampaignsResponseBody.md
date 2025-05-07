# Voucherify.Model.LoyaltiesListCampaignsResponseBody
Response body schema for **Get** `/loyalties`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Object** | **string** | The type of the object represented by JSON. This object stores information about loyalty campaigns in a dictionary. | [optional] [default to "list"]
**DataRef** | **string** | Identifies the name of the attribute that contains the array of loyalty campaign objects. | [optional] [default to DataRefEnum.Campaigns]
**Campaigns** | [**List&lt;LoyaltyCampaign&gt;**](LoyaltyCampaign.md) | Contains an array of loyalty campaign objects. | [optional] 
**Total** | **int** | Total number of loyalty campaign objects. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

