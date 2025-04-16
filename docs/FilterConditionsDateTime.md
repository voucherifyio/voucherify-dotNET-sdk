# Voucherify.Model.FilterConditionsDateTime
Data filters used to narrow down the data records to be returned in the result.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**After** | **DateTimeOffset?** | Value is after this date. The value for this parameter is shown in the ISO 8601 format. | [optional] 
**Before** | **DateTimeOffset?** | Value is before this date. The value for this parameter is shown in the ISO 8601 format. | [optional] 
**HasValue** | **string** | Value is NOT null. The value for this parameter is an empty string. | [optional] 
**IsUnknown** | **string** | Value is null. The value for this parameter is an empty string. | [optional] 
**MoreThan** | **int?** | Value is more days ago before the current date and time, e.g. more than &#x60;10&#x60; days ago. | [optional] 
**LessThan** | **int?** | Value is less days before the current date and time, e.g. less than &#x60;10&#x60; days ago. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

