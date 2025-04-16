# Voucherify.Model.LoyaltiesMembersRewardsListResponseBody
Response body schema for **GET** `v1/loyalties/members/{memberId}/rewards`

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Object** | **string** | The type of the object represented by JSON. | [optional] [default to ObjectEnum.List]
**DataRef** | **string** | Identifies the name of the attribute that contains the array of loyalty reward objects. | [optional] [default to DataRefEnum.Data]
**Data** | [**List&lt;LoyaltiesMembersRewardsListResponseBodyDataItem&gt;**](LoyaltiesMembersRewardsListResponseBodyDataItem.md) | Contains array of loyalty reward objects. | [optional] 
**Total** | **int?** | Total number of loyalty reward objects. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

