# Voucherify.Model.AccessSettingsUnassign
Unassigns the campaign from an area or a store. Provide the area and/or store IDs in the respective arrays. If a campaign changes assignments between areas or stores, unassign it first. For example, if a campaign is assigned to Area-01, but it must be now assigned to Store-01 within this area, you have to unassign the campaign from Area-01 and assigned to Store-01 only.  If you want to assign the campaign to stores only, you do not have to send the area ID.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AreasIds** | **List&lt;string&gt;** | List all area IDs from which the campaign will be unassigned. | [optional] 
**AreaStoresIds** | **List&lt;string&gt;** | List all store IDs from which the campaign will be unassigned. | [optional] 
**AreaAllStoresIds** | **List&lt;string&gt;** | List all area IDs where the campaign will be unassigned from all stores in the area. This unassignment is not equal to the unassignment from all &#x60;area_stores_ids&#x60; listed separately. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

