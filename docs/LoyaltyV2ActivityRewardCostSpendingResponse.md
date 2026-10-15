# Voucherify.Model.LoyaltyV2ActivityRewardCostSpendingResponse
Points spending definition.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique spending identifier, prefixed with &#x60;lrspn_&#x60;. Assigned by the API when omitted on create/update. | [optional] 
**Name** | **string** | Optional display name of the spending definition, or &#x60;null&#x60;. | [optional] 
**Points** | **int?** | Number of points the member must spend. | [optional] 
**CardDefinitionId** | **string** | Unique identifier of the card definition the points are spent from, prefixed with &#x60;lcdef_&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

