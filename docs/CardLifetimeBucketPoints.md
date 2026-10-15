# Voucherify.Model.CardLifetimeBucketPoints
Lifetime counters of regular points. All counters default to 0. The available balance is calculated as: `total` - `subtracted` - `expired` - `spent` - `refunded` + `returned` - `locked` + `unlocked` - `purchased_reversed`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Total** | **decimal?** | Total accumulated points, including points added manually, earned by fulfilling earning rules and activated from pending points (excluding returned points). | [optional] 
**Earned** | **decimal?** | Total points earned by fulfilling earning rules (does not include activated pending points or points added manually). | [optional] 
**Added** | **decimal?** | Total manually added points. | [optional] 
**Purchased** | **decimal?** | Total points purchased via a &#x60;LOYALTY_CARD_POINTS&#x60; reward (credited to the target card). | [optional] 
**PurchasedReversed** | **decimal?** | Total purchased points reversed via reward refund. | [optional] 
**Subtracted** | **decimal?** | Total manually subtracted points. | [optional] 
**Expired** | **decimal?** | Total expired points. | [optional] 
**Spent** | **decimal?** | Total points spent on rewards. | [optional] 
**Refunded** | **decimal?** | Total refunded points (points that were earned by products which were later returned). | [optional] 
**Returned** | **decimal?** | Total returned points (by returning a purchased reward). | [optional] 
**Locked** | **decimal?** | Total locked points (by locking a purchased reward). | [optional] 
**Unlocked** | **decimal?** | Total unlocked points (by unlocking a purchased reward). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

