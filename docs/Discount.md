# Voucherify.Model.Discount

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** |  | [optional] 
**AmountOff** | **decimal?** | Amount taken off the subtotal of a price. Value is multiplied by 100 to precisely represent 2 decimal places. For example, a $10 discount is written as 1000. | [optional] 
**AmountOffFormula** | **string** |  | [optional] 
**AggregatedAmountLimit** | **int?** | Maximum discount amount per order. | [optional] 
**Effect** | **string** |  | [optional] 
**IsDynamic** | **bool?** | Flag indicating whether the discount was calculated using a formula. | [optional] 
**UnitOff** | **int?** | Number of units to be granted a full value discount. | [optional] 
**UnitOffFormula** | **string** | Formula used to calculate the number of units. | [optional] 
**UnitType** | **string** | The product deemed as free, chosen from product inventory (e.g. time, items). | [optional] 
**Product** | [**DiscountProduct**](DiscountProduct.md) |  | [optional] 
**Sku** | [**SimpleSkuDiscountUnit**](SimpleSkuDiscountUnit.md) |  | [optional] 
**Units** | [**List&lt;DiscountUnitMultipleOneUnit&gt;**](DiscountUnitMultipleOneUnit.md) |  | [optional] 
**PercentOff** | **decimal?** | The percent discount that the customer will receive. | [optional] 
**PercentOffFormula** | **string** |  | [optional] 
**AmountLimit** | **decimal?** | Upper limit allowed to be applied as a discount. Value is multiplied by 100 to precisely represent 2 decimal places. For example, a $6 maximum discount is written as 600. | [optional] 
**FixedAmount** | **decimal?** | Sets a fixed value for an order total or the item price. The value is multiplied by 100 to precisely represent 2 decimal places. For example, a $10 discount is written as 1000. If the fixed amount is calculated by the formula, i.e. the &#x60;fixed_amount_formula&#x60; parameter is present in the fixed amount definition, this value becomes the **fallback value**. As a result, if the formula cannot be calculated due to missing metadata, for example, this value will be used as the fixed value. | [optional] 
**FixedAmountFormula** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

