# Voucherify.Model.PromotionsStacksListResponseBody
Response body schema for **GET** `v1/promotions/stacks` and for **GET** `v1/promotions/{campaignId}/stacks`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Object** | **string** | The type of the object represented by JSON. This object stores information about promotion stacks in a dictionary. | [optional] 
**DataRef** | **string** | Identifies the name of the attribute that contains the array of promotion stack objects. | [optional] 
**Data** | [**List&lt;PromotionStack&gt;**](PromotionStack.md) | Contains array of promotion stack objects. | [optional] 
**Total** | **int?** | Total number of promotion stacks. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

