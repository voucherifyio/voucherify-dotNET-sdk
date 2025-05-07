# Created with Openapi Generator

<a id="cli"></a>
## Run the following powershell command to generate the library

```ps1
$properties = @(
    'apiName=Api',
    'targetFramework=netstandard2.1',
    'validatable=true',
    'nullableReferenceTypes=true',
    'hideGenerationTimestamp=true',
    'packageVersion=8.0',
    'packageAuthors=OpenAPI',
    'packageCompany=OpenAPI',
    'packageCopyright=No Copyright',
    'packageDescription=A library generated from a OpenAPI doc',
    'packageName=Voucherify',
    'packageTags=',
    'packageTitle=OpenAPI Library'
) -join ","

$global = @(
    'apiDocs=true',
    'modelDocs=true',
    'apiTests=true',
    'modelTests=true'
) -join ","

java -jar "<path>/openapi-generator/modules/openapi-generator-cli/target/openapi-generator-cli.jar" generate `
    -g csharp-netcore `
    -i <your-swagger-file>.yaml `
    -o <your-output-folder> `
    --library generichost `
    --additional-properties $properties `
    --global-property $global `
    --git-host "github.com" `
    --git-repo-id "GIT_REPO_ID" `
    --git-user-id "GIT_USER_ID" `
    --release-note "Minor update"
    # -t templates
```

<a id="usage"></a>
## Using the library in your project

```cs
using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace YourProject
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            var api = host.Services.GetRequiredService<IAsyncActionsApi>();
            GetAsyncActionApiResponse apiResponse = await api.GetAsyncActionAsync("todo");
            AsyncActionGetResponseBody model = apiResponse.Ok();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) => Host.CreateDefaultBuilder(args)
          .ConfigureApi((context, options) =>
          {
              // the type of token here depends on the api security specifications
              ApiKeyToken token = new("<your token>", ClientUtils.ApiKeyHeader.Authorization);
              options.AddTokens(token);

              // optionally choose the method the tokens will be provided with, default is RateLimitProvider
              options.UseProvider<RateLimitProvider<ApiKeyToken>, ApiKeyToken>();

              options.ConfigureJsonOptions((jsonOptions) =>
              {
                  // your custom converters if any
              });

              options.AddApiHttpClients(builder: builder => builder
                .AddRetryPolicy(2)
                .AddTimeoutPolicy(TimeSpan.FromSeconds(5))
                .AddCircuitBreakerPolicy(10, TimeSpan.FromSeconds(30))
                // add whatever middleware you prefer
              );
          });
    }
}
```
<a id="questions"></a>
## Questions

- What about HttpRequest failures and retries?
  If supportsRetry is enabled, you can configure Polly in the ConfigureClients method.
- How are tokens used?
  Tokens are provided by a TokenProvider class. The default is RateLimitProvider which will perform client side rate limiting.
  Other providers can be used with the UseProvider method.
- Does an HttpRequest throw an error when the server response is not Ok?
  It depends how you made the request. If the return type is ApiResponse<T> no error will be thrown, though the Content property will be null. 
  StatusCode and ReasonPhrase will contain information about the error.
  If the return type is T, then it will throw. If the return type is TOrDefault, it will return null.
- How do I validate requests and process responses?
  Use the provided On and After methods in the Api class from the namespace Voucherify.Rest.DefaultApi.
  Or provide your own class by using the generic ConfigureApi method.

<a id="dependencies"></a>
## Dependencies

- [Microsoft.Extensions.Hosting](https://www.nuget.org/packages/Microsoft.Extensions.Hosting/) - 5.0.0 or later
- [Microsoft.Extensions.Http](https://www.nuget.org/packages/Microsoft.Extensions.Http/) - 5.0.0 or later
- [Microsoft.Extensions.Http.Polly](https://www.nuget.org/packages/Microsoft.Extensions.Http.Polly/) - 5.0.1 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 4.7.0 or later

<a id="documentation-for-authorization"></a>
## Documentation for Authorization


Authentication schemes defined for the API:
<a id="X-App-Id"></a>
### X-App-Id

- **Type**: API key
- **API key parameter name**: X-App-Id
- **Location**: HTTP header

<a id="X-App-Token"></a>
### X-App-Token

- **Type**: API key
- **API key parameter name**: X-App-Token
- **Location**: HTTP header

<a id="X-Client-Token"></a>
### X-Client-Token

- **Type**: API key
- **API key parameter name**: X-Client-Token
- **Location**: HTTP header

<a id="X-Client-Application-Id"></a>
### X-Client-Application-Id

- **Type**: API key
- **API key parameter name**: X-Client-Application-Id
- **Location**: HTTP header

<a id="X-Management-Id"></a>
### X-Management-Id

- **Type**: API key
- **API key parameter name**: X-Management-Id
- **Location**: HTTP header

<a id="X-Management-Token"></a>
### X-Management-Token

- **Type**: API key
- **API key parameter name**: X-Management-Token
- **Location**: HTTP header

<a id="X-Voucherify-OAuth"></a>
### X-Voucherify-OAuth

- **Type**: OAuth
- **Flow**: implicit
- **Authorization URL**: https://api.voucherify.io/v1/oauth/token
- **Scopes**:   
- api:   
- vouchers:   
- client_api:   
- client_vouchers:   
- promotions:   
- client_promotions:   
- campaigns:   
- client_publish:   
- exports:   
- publications:   
- client_validate:   
- validations:   
- client_validations:   
- qualifications:   
- client_qualifications:   
- client_redeem:   
- redemptions:   
- client_redemptions:   
- customers:   
- client_customers:   
- orders:   
- products:   
- skus:   
- validation-rules:   
- validation-rules-assignments:   
- segments:   
- events:   
- client_events:   
- rewards:   
- assets:   
- task-results:   
- loyalties:   
- client_consents:   
- consents:   
- async-actions:   
- product-collections:   
- categories:   
- metadata-schemas:   
- locations:   
- referrals:   
- trash-bin:   
- templates: 


## Build
- SDK version: 8.0
- Generator version: 7.12.0-SNAPSHOT
- Build package: org.openapitools.codegen.languages.CSharpClientCodegen

## Api Information
- appName: Voucherify API
- appVersion: v2018-08-01
- appDescription: Voucherify promotion engine REST API. Please see https://docs.voucherify.io/docs for more details.

## [OpenApi Global properties](https://openapi-generator.tech/docs/globals)
- generateAliasAsModel: 
- supportingFiles: 
- models: omitted for brevity
- apis: omitted for brevity
- apiDocs: true
- modelDocs: true
- apiTests: true
- modelTests: true

## [OpenApi Generator Parameters](https://openapi-generator.tech/docs/generators/csharp-netcore)
- allowUnicodeIdentifiers: 
- apiName: Api
- caseInsensitiveResponseHeaders: 
- conditionalSerialization: true
- disallowAdditionalPropertiesIfNotPresent: 
- gitHost: github.com
- gitRepoId: GIT_REPO_ID
- gitUserId: GIT_USER_ID
- hideGenerationTimestamp: true
- interfacePrefix: I
- library: generichost
- licenseId: 
- modelPropertyNaming: PascalCase
- netCoreProjectFile: true
- nonPublicApi: false
- nullableReferenceTypes: true
- optionalAssemblyInfo: 
- optionalEmitDefaultValues: true
- optionalMethodArgument: true
- optionalProjectFile: 
- packageAuthors: OpenAPI
- packageCompany: OpenAPI
- packageCopyright: No Copyright
- packageDescription: A library generated from a OpenAPI doc
- packageGuid: {6697F413-0A81-4686-8AF0-5DC6C31FCE82}
- packageName: Voucherify
- packageTags: 
- packageTitle: OpenAPI Library
- packageVersion: 8.0
- releaseNote: Minor update
- returnICollection: false
- sortParamsByRequiredFlag: 
- sourceFolder: src
- targetFramework: netstandard2.1
- useCollection: false
- useDateTimeOffset: true
- useOneOfDiscriminatorLookup: false
- validatable: true
For more information, please visit [https://www.voucherify.io/contact-support](https://www.voucherify.io/contact-support)

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project.
