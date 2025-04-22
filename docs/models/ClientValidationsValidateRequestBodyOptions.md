# Voucherify.Model.ClientValidationsValidateRequestBodyOptions
Configure parameters returned in the response.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Expand** | **List&lt;ClientValidationsValidateRequestBodyOptions.ExpandEnum&gt;** | The expand array lets you configure the parameters included in the response. Depending on the strings included in the array, the response will contain different details.   | **Expand Option** | **Response Body** | |:- --|:- --| | [\&quot;order\&quot;] | - Same response as fallback response (without an options object).&lt;br&gt;- Order data with calculated discounts are listed in each child redeemable object.&lt;br&gt;- Metadata not included for each discount type. | | [\&quot;redeemable\&quot;] | Expands redeemable objects by including &#x60;metadata&#x60; for each discount type. | | [\&quot;order\&quot;, \&quot;redeemable\&quot;] | - Order data with calculated discounts are listed in each child redeemable object.&lt;br&gt;- Includes &#x60;metadata&#x60; for each discount type. | | [\&quot;category\&quot;] | - Returns an expanded &#x60;categories&#x60; object, showing details about the category. | | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

