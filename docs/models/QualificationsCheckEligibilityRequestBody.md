# Voucherify.Model.QualificationsCheckEligibilityRequestBody
Request body schema for **POST** `v1/qualifications`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Customer** | [**Customer**](Customer.md) |  | [optional] 
**Order** | [**Order**](Order.md) |  | [optional] 
**TrackingId** | **string** | Is correspondent to Customer&#39;s source_id | [optional] 
**Scenario** | **string** | Defines the scenario Voucherify should consider during the qualification process.  - &#x60;ALL&#x60; - Scenario that returns all redeemables available for the customer in one API request. This scenario is used by default when no value is selected. - &#x60;CUSTOMER_WALLET&#x60; - returns vouchers applicable to the customer&#39;s cart based on the vouchers assigned to the customer&#39;s profile. - &#x60;AUDIENCE_ONLY&#x60; - returns all vouchers, promotion tiers, and campaigns available to the customer. Voucherify validates the rules based on the customer profile only. - &#x60;PRODUCTS&#x60; - returns all promotions available for the products (when a discount is defined to be applied to the item or when the item is required in the validation rule). - &#x60;PRODUCTS_DISCOUNT&#x60; - returns all promotions available for products when a discount is defined as applicable to specific item(s). - &#x60;PROMOTION_STACKS&#x60; - returns the applicable promotion stacks. - &#x60;PRODUCTS_BY_CUSTOMER&#x60; - returns all promotions available for a customer for the products (when a discount is defined to be applied to the item or when the item is required in the validation rule). - &#x60;PRODUCTS_DISCOUNT_BY_CUSTOMER&#x60; - returns all promotions available for a customer for products when a discount is defined as applicable to specific item(s). | [optional] 
**Options** | [**QualificationsOption**](QualificationsOption.md) |  | [optional] 
**Metadata** | **Object** | A set of key/value pairs that you can send in the request body to check against redeemables requiring **redemption** metadata validation rules to be satisfied. The validation runs against rules that are defined through the &lt;!- - [Create Validation Rules](https://docs.voucherify.io/reference/create-validation-rules) - -&gt;[Create Validation Rules](ref:create-validation-rules) endpoint or via the Dashboard; in the _Advanced Rule Builder_ &amp;rarr; _Advanced_ &amp;rarr; _Redemption metadata satisfy_ or _Basic Builder_ &amp;rarr; _Attributes match_ &amp;rarr; _REDEMPTION METADATA_. [Read more](https://support.voucherify.io/article/148-how-to-build-a-rule). | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

