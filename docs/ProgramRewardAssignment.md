# Voucherify.Model.ProgramRewardAssignment
A reward assigned to a program, with stock configuration and redemption counter.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RewardId** | **string** | Unique reward identifier. | [optional] 
**Stock** | [**ProgramRewardAssignmentStock**](ProgramRewardAssignmentStock.md) |  | 
**Redeemed** | **decimal?** | Number of times the reward has been redeemed within the program. Defaults to 0. | [optional] 
**CreatedAt** | **DateTimeOffset?** | Assignment creation timestamp (ISO 8601). | [optional] 
**UpdatedAt** | **DateTimeOffset?** | Last update timestamp (ISO 8601), or &#x60;null&#x60; when never updated. | [optional] 
**Object** | **string** | Object type marker. Always &#x60;program_reward&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

