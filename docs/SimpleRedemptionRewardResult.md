# Voucherify.Model.SimpleRedemptionRewardResult
Simplified redemption reward result data

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Customer** | [**SimpleCustomer**](SimpleCustomer.md) |  | [optional] 
**AssignmentId** | **string** | Unique reward assignment ID assigned by Voucherify. | [optional] 
**Voucher** | [**SimpleVoucher**](SimpleVoucher.md) |  | [optional] 
**Product** | [**SimpleProduct**](SimpleProduct.md) |  | [optional] 
**Sku** | [**SimpleSku**](SimpleSku.md) |  | [optional] 
**LoyaltyTierId** | **string** | Unique loyalty tier ID assigned by Voucherify. | [optional] 
**Id** | **string** | Unique reward ID, assigned by Voucherify. | [optional] 
**Object** | **string** | The type of the object represented by the JSON. This object stores information about the reward. | [optional] 
**Name** | **string** | Reward name. | [optional] 
**CreatedAt** | **DateTimeOffset?** | Timestamp representing the date and time when the reward was created. The value is shown in the ISO 8601 format. | [optional] 
**UpdatedAt** | **DateTimeOffset?** | Timestamp representing the date and time when the reward was updated. The value is shown in the ISO 8601 format. | [optional] 
**Parameters** | [**RewardType**](RewardType.md) |  | [optional] 
**Metadata** | **Object** | A set of custom key/value pairs that you can attach to a reward. The metadata object stores all custom attributes assigned to the reward. | [optional] 
**Type** | **string** | Reward type. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

