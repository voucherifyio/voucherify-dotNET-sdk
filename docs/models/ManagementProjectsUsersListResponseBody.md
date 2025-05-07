# Voucherify.Model.ManagementProjectsUsersListResponseBody
Object containing a list of users assigned to the project.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Object** | **string** | The type of the object represented by JSON. This object stores information about the users in a dictionary. | [optional] [default to ObjectEnum.List]
**DataRef** | **string** | Identifies the name of the attribute that contains the array of user objects. | [optional] [default to DataRefEnum.Data]
**Data** | [**List&lt;User&gt;**](User.md) | Array of user objects. | [optional] 
**Total** | **int** | The total number of users. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

