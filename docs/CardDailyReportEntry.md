# Voucherify.Model.CardDailyReportEntry
Aggregated card points statistics for one period. Each field sums the operations of one kind recorded in the period. All numeric fields default to 0.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Date** | **DateTime?** | Identifies the start of the truncated aggregation period (&#x60;YYYY-MM-DD&#x60;). For &#x60;week&#x60; this is Monday. For &#x60;month&#x60; this is the first day. For &#x60;quarter&#x60; this is the quarter start. | [optional] 
**PointsTotal** | **decimal?** | Points credited to the card in the period. Sums &#x60;points_earned&#x60;, &#x60;points_added&#x60;, and &#x60;points_purchased&#x60;. Points spent, expired, subtracted, refunded, returned, or reversed are not deducted. | [optional] 
**PointsEarned** | **decimal?** | Points earned through earning rules in the period. Includes pending points activated in the period. | [optional] 
**PointsAdded** | **decimal?** | Points added manually in the period. | [optional] 
**PointsPurchased** | **decimal?** | Points purchased (e.g. via loyalty-card-points rewards) in the period. | [optional] 
**PointsPurchasedReversed** | **decimal?** | Purchased points reversed (e.g. by reward refunds) in the period. | [optional] 
**PointsSubtracted** | **decimal?** | Points subtracted manually in the period. | [optional] 
**PointsExpired** | **decimal?** | Points expired in the period. | [optional] 
**PointsSpent** | **decimal?** | Points spent (on rewards and order payments) in the period. | [optional] 
**PointsRefunded** | **decimal?** | Points refunded in the period. | [optional] 
**PointsReturned** | **decimal?** | Points returned in the period. | [optional] 
**PointsLocked** | **decimal?** | Points locked in the period. | [optional] 
**PointsUnlocked** | **decimal?** | Points unlocked in the period. Includes points released when a spending transaction is approved (also counted in &#x60;points_spent&#x60;) or rejected. | [optional] 
**PendingPointsTotal** | **decimal?** | Pending points added in the period. Activated and canceled pending points are not deducted. | [optional] 
**PendingPointsActivated** | **decimal?** | Pending points activated in the period. Also counted in &#x60;points_earned&#x60; and &#x60;points_total&#x60;. | [optional] 
**PendingPointsCanceled** | **decimal?** | Pending points canceled in the period. | [optional] 
**Object** | **string** | Object type marker. Always &#x60;card_daily_report&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

