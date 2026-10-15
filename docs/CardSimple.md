# Voucherify.Model.CardSimple
A loyalty card in its simple representation, as embedded in member responses.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Identifies the card. | [optional] 
**CardDefinitionId** | **string** | Identifies the card definition. | [optional] 
**CardType** | **string** | Card type. Currently only &#x60;INDIVIDUAL&#x60; is supported. | [optional] 
**Code** | **string** | Human-readable card code. Card code generation is asynchronous - this field is &#x60;null&#x60; right after member creation and is populated shortly after, once the background code generation completes. | [optional] 
**LifetimeBucket** | [**CardLifetimeBucket**](CardLifetimeBucket.md) |  | [optional] 
**Balance** | [**CardBalance**](CardBalance.md) |  | [optional] 
**Object** | **string** | Object type. Always &#x60;card&#x60;. | [optional] 
**NextExpiration** | [**CardNextExpiration**](CardNextExpiration.md) |  | [optional] 
**NextActivation** | [**CardNextActivation**](CardNextActivation.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

