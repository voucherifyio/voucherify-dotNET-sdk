# Voucherify.Model.ManagementProjectsListResponseBody
Schema model for **GET** `managment/v1/projects`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Object** | **string** | The type of the object represented by JSON. This object stores information about the projects in a dictionary. | [optional] [default to ObjectEnum.List]
**DataRef** | **string** | Identifies the name of the attribute that contains the array of project objects. | [optional] [default to DataRefEnum.Data]
**Data** | [**List&lt;ManagementProject&gt;**](ManagementProject.md) | Array of project objects. | [optional] 
**Total** | **int** | The total number of projects. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

