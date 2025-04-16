# Voucherify.Api.EventsApi

All URIs are relative to *https://api.voucherify.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**TrackCustomEvent**](EventsApi.md#trackcustomevent) | **POST** /v1/events | Track Custom Event |

<a id="trackcustomevent"></a>
# **TrackCustomEvent**
> EventsCreateResponseBody TrackCustomEvent (EventsCreateRequestBody eventsCreateRequestBody = null)

Track Custom Event

To track a custom event, you create an event object.   The event object must be linked to the customer who performs the action. If a customer doesnt exist in Voucherify, the customer will be created.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Voucherify.Api;
using Voucherify.Client;
using Voucherify.Model;

namespace Example
{
    public class TrackCustomEventExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.voucherify.io";
            // Configure API key authorization: X-App-Id
            config.AddApiKey("X-App-Id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-App-Id", "Bearer");
            // Configure API key authorization: X-App-Token
            config.AddApiKey("X-App-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-App-Token", "Bearer");
            // Configure OAuth2 access token for authorization: X-Voucherify-OAuth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EventsApi(config);
            var eventsCreateRequestBody = new EventsCreateRequestBody(); // EventsCreateRequestBody | Specify the details of the custom event. (optional) 

            try
            {
                // Track Custom Event
                EventsCreateResponseBody result = apiInstance.TrackCustomEvent(eventsCreateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventsApi.TrackCustomEvent: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TrackCustomEventWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Track Custom Event
    ApiResponse<EventsCreateResponseBody> response = apiInstance.TrackCustomEventWithHttpInfo(eventsCreateRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventsApi.TrackCustomEventWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eventsCreateRequestBody** | [**EventsCreateRequestBody**](EventsCreateRequestBody.md) | Specify the details of the custom event. | [optional]  |

### Return type

[**EventsCreateResponseBody**](EventsCreateResponseBody.md)

### Authorization

[X-App-Id](../README.md#X-App-Id), [X-App-Token](../README.md#X-App-Token), [X-Voucherify-OAuth](../README.md#X-Voucherify-OAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the event type if the event was received by the application. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

