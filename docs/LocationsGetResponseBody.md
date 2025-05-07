# Voucherify.Model.LocationsGetResponseBody
Response schema for listing locations using **GET** `/v1/locations/{locationId}`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique location ID, assigned by the Voucherify API. | [optional] 
**Object** | **string** | The type of the object represented by JSON. This object stores information about a &#x60;location&#x60;. | [optional] 
**Name** | **string** | Location name. | [optional] 
**Shape** | [**LocationsGetResponseBodyShape**](LocationsGetResponseBodyShape.md) |  | [optional] 
**CreatedAt** | **DateTimeOffset?** | Timestamp representing the date and time when the location was created. The value is shown in the ISO 8601 format. | [optional] 
**UpdatedAt** | **DateTimeOffset?** | Timestamp representing the date and time when the location was updated. The value is shown in the ISO 8601 format. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

