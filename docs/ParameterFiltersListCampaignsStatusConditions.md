# Voucherify.Model.ParameterFiltersListCampaignsStatusConditions
Data conditions used to narrow down the data records to be returned in the result.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Active** | **Object** | Campaigns finished generation codes. This also returns campaigns regardless of their &#x60;expiration_date&#x60; and &#x60;start_date&#x60;. | [optional] 
**Failed** | **Object** | Campaigs failed to generated codes. | [optional] 
**InProgress** | **Object** | Campaigns are generating codes or they are updating. | [optional] 
**Expired** | **Object** | Campaigns generated codes, but their &#x60;expiration_date&#x60; is in the past. | [optional] 
**BeforeStart** | **Object** | Campaigns generated codes, but their &#x60;start_date&#x60; is in the future. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

