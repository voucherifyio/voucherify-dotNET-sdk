# Voucherify.Model.RewardPurchaseLimitsFrequency
Purchase frequency limits for a reward.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Frequency limit type. &#x60;NO_LIMIT&#x60; - unlimited purchases. &#x60;LIMITED&#x60; - limited by the &#x60;limits&#x60; array. | [optional] 
**Limits** | [**List&lt;RewardPurchaseLimitsFrequencyLimit&gt;**](RewardPurchaseLimitsFrequencyLimit.md) | Frequency limit definitions. Empty array when &#x60;type&#x60; is &#x60;NO_LIMIT&#x60;; one entry when &#x60;type&#x60; is &#x60;LIMITED&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

