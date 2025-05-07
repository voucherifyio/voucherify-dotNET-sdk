# Voucherify.Model.LoyaltiesTiersGetResponseBody
Response body schema for **GET** `v1/loyalties/{campaignId}/tiers/{loyaltyTierId}`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Loyalty Tier name. | [optional] 
**EarningRules** | [**Dictionary&lt;string, MappingPoints&gt;**](MappingPoints.md) | Contains a list of earning rule IDs and their points mapping for the given earning rule. | [optional] 
**Rewards** | [**Dictionary&lt;string, MappingPoints&gt;**](MappingPoints.md) | Contains a list of reward IDs and their points mapping for the given reward. | [optional] 
**Points** | [**LoyaltiesTiersGetResponseBodyPoints**](LoyaltiesTiersGetResponseBodyPoints.md) |  | [optional] 
**Id** | **string** | Unique loyalty tier ID. | [optional] 
**CampaignId** | **string** | Unique parent campaign ID. | [optional] 
**Metadata** | **Object** | The metadata object stores all custom attributes assigned to the loyalty tier. A set of key/value pairs that you can attach to a loyalty tier object. It can be useful for storing additional information about the loyalty tier in a structured format. | [optional] 
**CreatedAt** | **DateTimeOffset?** | Timestamp representing the date and time when the loyalty tier was created. The value is shown in the ISO 8601 format. | [optional] 
**UpdatedAt** | **DateTimeOffset?** | Timestamp representing the date and time when the loyalty tier was updated. The value is shown in the ISO 8601 format. | [optional] 
**Config** | [**LoyaltiesTiersGetResponseBodyConfig**](LoyaltiesTiersGetResponseBodyConfig.md) |  | [optional] 
**Expiration** | [**LoyaltyTierExpiration**](LoyaltyTierExpiration.md) |  | [optional] 
**Object** | **string** | The type of the object represented by JSON. This object stores information about the loyalty. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

