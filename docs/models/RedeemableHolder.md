# Voucherify.Model.RedeemableHolder
Single customer's redeemable

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique identifier of the redeemable holder. | [optional] 
**CreatedAt** | **DateTimeOffset** | Timestamp representing the date and time when the redeemable was assigned. The value is shown in the ISO 8601 format. | [optional] 
**RedeemableId** | **string** | Identifier of the redeemable item. | [optional] 
**RedeemableObject** | **string** | Type of the redeemable. | [optional] 
**CustomerId** | **string** | Unique identifier of the customer. | [optional] 
**HolderRole** | **string** | Role of the holder. | [optional] 
**CampaignId** | **string** | Unique identifier of the campaign as assigned by Voucherify. | [optional] 
**CampaignType** | **string** | Defines the type of the campaign. | [optional] [default to CampaignTypeEnum.REFERRALPROGRAM]
**VoucherType** | **string** | Defines the type of the voucher. | [optional] 
**Metadata** | **Object** | A set of custom key/value pairs that you can attach to a redeemable holder. The metadata object stores all custom attributes assigned to the &#x60;redeemable_holder&#x60; object. | [optional] 
**Object** | **string** | The type of the object represented by JSON. | [optional] [default to ObjectEnum.RedeemableHolder]

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

