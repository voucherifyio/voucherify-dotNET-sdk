# Voucherify.Model.LoyaltiesTiersRewardsListResponseBody
Response body schema for **GET** `v1/loyalties/{campaignId}/tiers/{loyaltyTierId}/rewards`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Object** | **string** | The type of the object represented by JSON. This object stores information about loyalty tier rewards in a dictionary. | [optional] [default to "list"]
**DataRef** | **string** | Identifies the name of the attribute that contains the array of loyalty tier reward objects. | [optional] [default to "data"]
**Data** | [**List&lt;LoyaltiesLoyaltyTierReward&gt;**](LoyaltiesLoyaltyTierReward.md) | Contains array of loyalty tier reward objects. | [optional] 
**Total** | **int?** | Total number of loyalty tier reward objects. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

