# Voucherify.Model.LoyaltyPointsBucket
Contains the details about expiring loyalty points.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique identifier of the loyalty points bucket. | [optional] 
**VoucherId** | **string** | Unique identifier of the parent loyalty card. | [optional] 
**CampaignId** | **string** | Unique identifier of the parent campaign. | [optional] 
**Bucket** | [**LoyaltyPointsBucketBucket**](LoyaltyPointsBucketBucket.md) |  | [optional] 
**Status** | **string** | Loyalty point point bucket status. | [optional] 
**ExpiresAt** | **DateTimeOffset** | Date when the number of points defined in the bucket object are due to expire. | [optional] 
**CreatedAt** | **DateTimeOffset** | Timestamp representing the date and time when the loyalty point bucket object was created in ISO 8601 format. | [optional] 
**UpdatedAt** | **DateTimeOffset** | Timestamp representing the date and time when the loyalty point bucket object was updated in ISO 8601 format. | [optional] 
**Object** | **string** | The type of the object represented by JSON. This object stores information about the loyalty point bucket. | [optional] [default to ObjectEnum.LoyaltyPointsBucket]

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

