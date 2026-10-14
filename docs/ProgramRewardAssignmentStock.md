# Voucherify.Model.ProgramRewardAssignmentStock
Reward stock configuration. When `type` is `UNLIMITED`, `limited` must not be provided. When `type` is `LIMITED`, `limited` is required. The API validates field combinations that this schema does not express.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Stock type. | [optional] 
**Limited** | [**ProgramRewardAssignmentStockLimited**](ProgramRewardAssignmentStockLimited.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

