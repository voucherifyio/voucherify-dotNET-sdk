# Voucherify.Model.OAuthTokenGenerateResponseBody
Response body schema for **POST** `/oauth/token`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccessToken** | **string** | The access token used to authorize access to the Voucherify API. | [optional] 
**ClientId** | **string** | Unique client identifier, assigned by Voucherify, for OAuth. | [optional] 
**ExpiresAt** | **int?** | Timestamp in seconds in the Unix format indicating when the token expires. | [optional] 
**ExpiresIn** | **int?** | Number of seconds left until the token expires. | [optional] 
**TokenType** | **string** | Type of the token. Use the value as the header prefix for authorization. | [optional] 
**Scope** | **string** | Defines the scope of possible actions that can be done with the OAuth token. The &#x60;api&#x60; scope allows using the server-side API. The &#x60;client_api&#x60; scope allows using the whole client-side API. Possible values: &#x60;api&#x60;, &#x60;assets&#x60;, &#x60;async-actions&#x60;, &#x60;campaigns&#x60;, &#x60;categories&#x60;, &#x60;client_api&#x60;, &#x60;client_consents&#x60;, &#x60;client_customers&#x60;, &#x60;client_events&#x60;, &#x60;client_promotions&#x60;, &#x60;client_publish&#x60;, &#x60;client_qualifications&#x60;, &#x60;client_redeem&#x60;, &#x60;client_redemptions&#x60;, &#x60;client_validate&#x60;, &#x60;client_validations&#x60;, &#x60;client_vouchers&#x60;, &#x60;consents&#x60;, &#x60;customers&#x60;, &#x60;events&#x60;, &#x60;exports&#x60;, &#x60;locations&#x60;, &#x60;loyalties&#x60;, &#x60;metadata-schemas&#x60;, &#x60;orders&#x60;, &#x60;product-collections&#x60;, &#x60;products&#x60;, &#x60;promotions&#x60;, &#x60;publications&#x60;, &#x60;qualifications&#x60;, &#x60;redemptions&#x60;, &#x60;referrals&#x60;, &#x60;rewards&#x60;, &#x60;segments&#x60;, &#x60;skus&#x60;, &#x60;task-results&#x60;, &#x60;templates&#x60;, &#x60;trash-bin&#x60;, &#x60;validation-rules-assignments&#x60;, &#x60;validation-rules&#x60;, &#x60;validations&#x60;, &#x60;vouchers&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

