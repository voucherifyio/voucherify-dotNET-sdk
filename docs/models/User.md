# Voucherify.Model.User
Details about the user.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The unique identifier of the user who has been assigned to the project. | [optional] 
**Login** | **string** | The login data of the user who has been assigned to the project. | [optional] 
**Email** | **string** | The email address of the user who has been assigned to the project. | [optional] 
**FirstName** | **string** | The first name of the user who has been assigned to the project. | [optional] 
**LastName** | **string** | The last name of the user who has been assigned to the project. | [optional] 
**Projects** | **Dictionary&lt;string, string&gt;** | Lists key-value pairs, where the key is the project to which the user is assigned. The value is the role assigned in a given project. The predefined Voucherify roles are: &#x60;ADMIN&#x60;, &#x60;USER&#x60;, &#x60;VIEWER&#x60;, &#x60;MERCHANT&#x60;, &#x60;USER_RESTRICTED&#x60; (for the Areas and Stores, an Enterprise feature). | [optional] 
**IsOwner** | **bool** | Determines if the user is the owner for the organization in Voucherify. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

