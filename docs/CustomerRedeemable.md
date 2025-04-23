# Voucherify.Model.CustomerRedeemable
Single customer's redeemable

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique redeemable holder identifier. | [optional] 
**CreatedAt** | **DateTimeOffset?** | Timestamp representing the date and time when the redeemable was assigned. The value is shown in the ISO 8601 format. | [optional] 
**RedeemableId** | **string** | Identifier of the redeemable item. | [optional] 
**RedeemableObject** | **string** | Type of the redeemable. | [optional] 
**CustomerId** | **string** | Identifier of the customer. | [optional] 
**HolderRole** | **string** | Role of the holder. | [optional] 
**CampaignId** | **string** | Unique campaign identifier, assigned by Voucherify. | [optional] 
**CampaignType** | **string** | Defines the type of the campaign. | [optional] 
**VoucherType** | **string** | Defines the type of the voucher. | [optional] 
**Redeemable** | [**CustomerRedeemableRedeemable**](CustomerRedeemableRedeemable.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

