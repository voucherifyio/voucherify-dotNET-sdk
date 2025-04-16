# Voucherify.Model.LoyaltyTierExpiration
Defines loyalty tier expiration date.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CustomerId** | **string** | Unique customer identifier of the customer making the purchase. The ID is assigned by Voucherify. | [optional] 
**CampaignId** | **string** | Unique campaign ID, assigned by Voucherify. | [optional] 
**TierId** | **string** | Unique tier ID, assigned by Voucherify. | [optional] 
**StartDate** | **string** | Activation timestamp defines when the loyalty tier starts to be active in ISO 8601 format. Loyalty tier is inactive before this date. | [optional] 
**ExpirationDate** | **string** | Expiration timestamp defines when the loyalty tier expires in ISO 8601 format. Loyalty tier is inactive after this date. | [optional] 
**CreatedAt** | **DateTimeOffset** | Timestamp representing the date and time when the loyalty tier was created. The value is shown in the ISO 8601 format. | [optional] 
**UpdatedAt** | **DateTimeOffset** | Timestamp representing the date and time when the loyalty tier was updated. The value is shown in the ISO 8601 format. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

