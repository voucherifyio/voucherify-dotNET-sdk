# Voucherify.Model.LoyaltiesMembersTiersListResponseBody
Response body schema for **GET** `v1/loyalties/members/{memberId}/tiers`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Object** | **string** | The type of the object represented by JSON. This object stores information about loyalty tiers in a dictionary. | [optional] 
**DataRef** | **string** | Identifies the name of the attribute that contains the array of loyalty tier objects. | [optional] 
**Data** | [**List&lt;LoyaltyTier&gt;**](LoyaltyTier.md) |  | [optional] 
**Total** | **int?** | Total number of loyalty tier objects. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

