# Voucherify.Model.RedemptionRewardResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Customer** | [**SimpleCustomer**](SimpleCustomer.md) |  | [optional] 
**AssignmentId** | **string** | Unique reward assignment ID assigned by Voucherify. | [optional] 
**Voucher** | [**Voucher**](Voucher.md) |  | [optional] 
**Product** | [**Product**](Product.md) |  | [optional] 
**Sku** | [**Sku**](Sku.md) |  | [optional] 
**LoyaltyTierId** | **string** | Unique loyalty tier ID assigned by Voucherify. | [optional] 
**Id** | **string** | Unique reward ID. | [optional] 
**Name** | **string** | Name of the reward. | [optional] 
**Object** | **string** | The type of the object represented by the JSON | [optional] [default to ObjectEnum.Reward]
**CreatedAt** | **DateTimeOffset** | Timestamp representing the date and time when the redemption was created. The value is shown in the ISO 8601 format. | [optional] 
**UpdatedAt** | **DateTimeOffset** | Timestamp in ISO 8601 format indicating when the reward was updated. | [optional] 
**Parameters** | [**RedemptionRewardResultParameters**](RedemptionRewardResultParameters.md) |  | [optional] 
**Metadata** | **Object** | A set of custom key/value pairs that you can attach to a reward. The metadata object stores all custom attributes assigned to the reward. | [optional] 
**Type** | **string** | Reward type. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

