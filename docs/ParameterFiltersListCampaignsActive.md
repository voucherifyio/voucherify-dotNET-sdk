# Voucherify.Model.ParameterFiltersListCampaignsActive
Filters campaigns by their `active` state. Pass the filter as an empty object, for example `filters[active][conditions][$enabled]=`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enabled** | **Object** | Campaigns are enabled. | [optional] 
**Disabled** | **Object** | Campaigns are disabled. | [optional] 
**Expired** | **Object** | Campaign &#x60;expiration_date&#x60; is in the past. | [optional] 
**Active** | **Object** | Campaigns are active, &#x60;start_date&#x60; is &#x60;null&#x60; or in the past, and &#x60;expiration_date&#x60; is &#x60;null&#x60; or in the future. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

