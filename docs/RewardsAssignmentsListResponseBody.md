# Voucherify.Model.RewardsAssignmentsListResponseBody
Response body schema for **GET** `v1/rewards/{rewardID}/assignments`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Object** | **string** | The type of the object represented by JSON. This object stores information about reward assignments in a dictionary. | [optional] [default to "list"]
**DataRef** | **string** | Identifies the name of the attribute that contains the array of reward assignments. | [optional] [default to "data"]
**Data** | [**List&lt;RewardAssignment&gt;**](RewardAssignment.md) |  | [optional] 
**Total** | **int?** | Total number of reward assignments. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

