# Voucherify.Model.ManagementProjectsUsersAssignRequestBody

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The unique identifier of the user who will be assigned to the project. It can be found in Team Settings &gt; Team &gt; Edit member. **Required** with the &#x60;role&#x60; string.  Do **not** use with the &#x60;login&#x60; string. | [optional] 
**Login** | **string** | The login data of the user who will be assigned to the project. **Required** with the &#x60;role&#x60; string.  Do **not** use with the &#x60;id&#x60; string. | [optional] 
**Role** | **string** | The role of the user to be added. It can be one of the following predefined roles: &#x60;ADMIN&#x60;, &#x60;USER&#x60;, &#x60;VIEWER&#x60;, &#x60;MERCHANT&#x60;, or an ID of a custom role. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

