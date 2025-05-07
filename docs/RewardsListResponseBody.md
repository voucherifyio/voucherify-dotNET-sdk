# Voucherify.Model.RewardsListResponseBody
Response body schema for **GET** `v1/rewards`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Object** | **string** | The type of the object represented by JSON. | [optional] 
**DataRef** | **string** | Identifies the name of the attribute that contains the array of transaction objects. | [optional] 
**Data** | [**List&lt;Reward&gt;**](Reward.md) | A dictionary that contains an array of rewards. Each entry in the array is a separate transaction object. | [optional] 
**Total** | **int?** | Returns how many rewards in the project meet the limits defined by the query parameter definitions. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

