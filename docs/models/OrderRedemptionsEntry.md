# Voucherify.Model.OrderRedemptionsEntry

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Date** | **DateTimeOffset** | Timestamp representing the date and time when the redemption was created. The value is shown in the ISO 8601 format. | [optional] 
**RollbackId** | **string** | Unique ID of the redemption rollback. | [optional] 
**RollbackDate** | **DateTimeOffset** | Timestamp representing the date and time when the redemption rollback was created. The value is shown in the ISO 8601 format. | [optional] 
**RelatedObjectType** | **string** | The source of the incentive. | [optional] [default to "redemption"]
**RelatedObjectId** | **string** | Unique ID of the parent redemption. | [optional] 
**RelatedObjectParentId** | **string** | Represent&#39;s the campaign ID of the voucher if the redemption was based on a voucher that was part of bulk codes generated within a campaign. In case of a promotion tier, this represents the campaign ID of the promotion tier&#39;s parent campaign. | [optional] 
**Stacked** | **List&lt;string&gt;** | Contains a list of unique IDs of child redemptions, which belong to the stacked incentives. | [optional] 
**RollbackStacked** | **List&lt;string&gt;** | Lists the rollback redemption IDs of the particular child redemptions. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

