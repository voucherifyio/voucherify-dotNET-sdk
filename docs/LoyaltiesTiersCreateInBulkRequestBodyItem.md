# Voucherify.Model.LoyaltiesTiersCreateInBulkRequestBodyItem

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Loyalty Tier name. | [optional] 
**EarningRules** | [**Dictionary&lt;string, MappingPoints&gt;**](MappingPoints.md) | Contains a list of earning rule IDs and their points mapping for the given earning rule. | [optional] 
**Rewards** | [**Dictionary&lt;string, MappingPoints&gt;**](MappingPoints.md) | Contains a list of reward IDs and their points mapping for the given reward. | [optional] 
**Points** | [**LoyaltyTierBasePoints**](LoyaltyTierBasePoints.md) |  | [optional] 
**Metadata** | **Object** | The metadata object stores all custom attributes assigned to the loyalty tier. A set of key/value pairs that you can attach to a loyalty tier object. It can be useful for storing additional information about the loyalty tier in a structured format. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

