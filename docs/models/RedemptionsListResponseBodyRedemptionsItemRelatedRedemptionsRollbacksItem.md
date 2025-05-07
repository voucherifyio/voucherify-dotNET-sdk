# Voucherify.Model.RedemptionsListResponseBodyRedemptionsItemRelatedRedemptionsRollbacksItem

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique rollback redemption ID. | [optional] 
**Date** | **DateTimeOffset** | Timestamp representing the date and time when the object was created. The value is shown in the ISO 8601 format. | [optional] 
**RollbackOrderMode** | **string** | Defines the rollback mode for the order. &#x60;WITH_ORDER&#x60; is a default setting. The redemption is rolled back together with the data about the order, including related discount values. &#x60;WITHOUT_ORDER&#x60; allows rolling the redemption back without affecting order data, including the applied discount values. This is returned only in GET &#x60;v1/redemptions/&#x60; and GET &#x60;v1/redemptions/{redemptionId}&#x60; endpoints. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

