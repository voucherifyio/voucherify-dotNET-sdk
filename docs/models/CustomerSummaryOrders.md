# Voucherify.Model.CustomerSummaryOrders

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TotalAmount** | **int** | The total amount spent by the customer. The value is multiplied by 100 to represent 2 decimal places. For example &#x60;10000 cents&#x60; for &#x60;$100.00&#x60;. | [optional] 
**TotalCount** | **int** | Total number of orders made by the customer. | [optional] 
**AverageAmount** | **int** | Average amount spent on orders. &#x60;total_amount&#x60; &amp;divide; &#x60;total_count&#x60;. The value is multiplied by 100 to represent 2 decimal places. For example &#x60;10000 cents&#x60; for &#x60;$100.00&#x60;. | [optional] 
**LastOrderAmount** | **int** | Amount spent on last order. The value is multiplied by 100 to represent 2 decimal places. For example &#x60;10000 cents&#x60; for &#x60;$100.00&#x60;. | [optional] 
**LastOrderDate** | **DateTimeOffset** | Timestamp representing the date and time of the customer&#39;s last order in ISO 8601 format. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

