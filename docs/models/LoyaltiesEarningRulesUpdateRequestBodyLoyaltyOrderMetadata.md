# Voucherify.Model.LoyaltiesEarningRulesUpdateRequestBodyLoyaltyOrderMetadata
Defines the ratio based on the property defined in the calculation_type parameter. For every given increment of value (1, 10, etc) defined in the every parameter for the property defined in calculation_type, give the customer the number of points defined in the points parameter. In other words, for every order metadata property value, give points.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Every** | **int** | For how many increments of the order metadata property to grant points for. | [optional] 
**Points** | **int** | Number of points to be awarded, i.e. how many points to be added to the loyalty card. | [optional] 
**Property** | **string** | Order metadata property. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

