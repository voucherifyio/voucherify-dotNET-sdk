# Voucherify.Model.ExamineCardReference
Card reference in examine results.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique card ID (&#x60;lcrd_...&#x60;). | [optional] 
**CardDefinitionId** | **string** | Unique card definition ID (&#x60;lcdef_...&#x60;). | [optional] 
**CardType** | **string** | Card type. Currently only &#x60;INDIVIDUAL&#x60; exists. | [optional] 
**Code** | **string** | Card code. May be &#x60;null&#x60; right after member creation because card codes are generated asynchronously. | [optional] 
**Object** | **string** | Object type marker. Always &#x60;card&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

