# Voucherify.Model.CardLifetimeBucketPendingPoints
Lifetime counters of pending points. The available pending balance is max(`total` - `activated` - `canceled`, 0).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Total** | **decimal?** | Total pending points ever added. | [optional] 
**Activated** | **decimal?** | Total pending points activated into regular points. | [optional] 
**Canceled** | **decimal?** | Total pending points canceled. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

