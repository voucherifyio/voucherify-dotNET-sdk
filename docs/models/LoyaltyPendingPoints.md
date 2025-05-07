# Voucherify.Model.LoyaltyPendingPoints
Contains details about the pending point entry.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Details** | [**LoyaltyPendingPointsDetails**](LoyaltyPendingPointsDetails.md) |  | 
**Id** | **string** | Unique identifier of the pending point entry, assigned by Voucherify. | [optional] 
**VoucherId** | **string** | Unique identifier of the loyalty card, assigned by Voucherify. | [optional] 
**CampaignId** | **string** | Unique campaign identifier, assigned by Voucherify. | [optional] 
**CustomerId** | **string** | Unique customer identifier, assigned by Voucherify. | [optional] 
**OrderId** | **string** | Unique order identifier, assigned by Voucherify. | [optional] 
**Points** | **int** | Number of points in the pending state. | [optional] 
**ActivatesAt** | **DateTimeOffset** | Date when the pending points are activated and added to the customer&#39;s loyalty card. | [optional] 
**CreatedAt** | **DateTimeOffset** | Timestamp representing the date and time when the pending point entry was created. The value is shown in the ISO 8601 format. | [optional] 
**UpdatedAt** | **DateTimeOffset** | Timestamp representing the date and time when the pending point entry was modified. The value is shown in the ISO 8601 format. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

