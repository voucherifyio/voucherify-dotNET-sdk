# Voucherify.Model.PromotionTiersList
Promotion Tiers

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Object** | **string** | The type of the object represented by JSON. This object stores information about promotion tiers in a dictionary. | [optional] [default to "list"]
**DataRef** | **string** | Identifies the name of the attribute that contains the array of promotion tier objects. | [optional] [default to "tiers"]
**Tiers** | [**List&lt;PromotionTier&gt;**](PromotionTier.md) | Contains array of promotion tier objects. | [optional] 
**Total** | **int** | Total number of promotion tiers. | [optional] 
**HasMore** | **bool** | As query results are always limited (by the limit parameter), the &#x60;has_more&#x60; flag indicates if there are more records for given filter parameters. This lets you know if you can run another request to get more records returned in the results. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

