# Voucherify.Model.RedeemableGift
Contains current gift card balance information.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Balance** | **decimal** | Available funds. The value is multiplied by 100 to represent 2 decimal places. For example &#x60;10000 cents&#x60; for &#x60;$100.00&#x60;. | [optional] 
**Credits** | **decimal** | The number of credits that the user wants to use from the gift card to fulfil the order. The value of credits cannot be higher than the current balance on the gift card. If the user gives more points than he has on the gift card, the application will return an error code in response. The value is multiplied by 100 to represent 2 decimal places. For example &#x60;10000 cents&#x60; for &#x60;$100.00&#x60;. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

