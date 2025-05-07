# Voucherify.Model.LoyaltiesTiersEarningRulesListResponseBody
Response body schema for **GET** `v1/loyalties/{campaignId}/tiers/{loyaltyTierId}/earning-rules`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Object** | **string** | The type of the object represented by JSON. This object stores information about earning rules in a dictionary. | [optional] [default to ObjectEnum.List]
**DataRef** | **string** | Identifies the name of the attribute that contains the array of earning rule objects. | [optional] [default to DataRefEnum.Data]
**Data** | [**List&lt;EarningRule&gt;**](EarningRule.md) | Contains array of earning rule objects. | [optional] 
**Total** | **int** | Total number of earning rule objects. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

