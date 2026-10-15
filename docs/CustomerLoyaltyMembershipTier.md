# Voucherify.Model.CustomerLoyaltyMembershipTier
Tier recorded on the customer membership.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TierId** | **string** | Identifies the tier. | [optional] 
**TierStructureId** | **string** | Identifies the tier structure. | [optional] 
**CardId** | **string** | Identifies the loyalty card that holds this tier. | [optional] 
**CardDefinitionId** | **string** | Identifies the card definition for this tier. | [optional] 
**ExpiresAt** | **DateTimeOffset?** | Timestamp representing when the tier expires. The value is shown in the ISO 8601 format. &#x60;null&#x60; when the tier does not expire. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

