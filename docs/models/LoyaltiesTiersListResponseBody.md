# Voucherify.Model.LoyaltiesTiersListResponseBody
Response body schema for **GET** `v1/loyalties/{campaignId}/tiers`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Object** | **string** | The type of the object represented by JSON. This object stores information about loyalty tiers in a dictionary. | [optional] [default to ObjectEnum.List]
**DataRef** | **string** | Identifies the name of the attribute that contains the array of loyalty tier objects. | [optional] [default to DataRefEnum.Data]
**Data** | [**List&lt;LoyaltyTier&gt;**](LoyaltyTier.md) | This is an object representing a loyalty tier. Loyalty tiers are used to create a loyalty program with different levels of membership and varied earning rules and rewards based on customer&#39;s tiers. | [optional] 
**Total** | **int** | Total number of loyalty tier objects. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

