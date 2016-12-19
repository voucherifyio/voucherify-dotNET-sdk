Voucherify for Unity
===

Why?
---

Because of many limitations of Unity (expecially those realted strictly to [iOS](https://developer.xamarin.com/guides/ios/advanced_topics/limitations/)) there was a need to preapre a dedicated solution to support the platform. 

The main dependency of Voucherify library is `Newtonsoft.Json` that provides data serialization to integrate with REST API based on json, but it does not work on iOS as it is so that it's required to used an adjusted version. We recommend you to use library prepared and tested by Voucherify Team: [Newtonsoft.Json by Voucherify](https://github.com/bandraszyk/Newtonsoft.Json). You can see that we did onle one [change](https://github.com/bandraszyk/Newtonsoft.Json/commit/2ce54acd150f676a9a930a9af7da68866cb4da6e) to the original repo.

The following library can be use as an alternative: [Json.Net.Unity3D](https://github.com/SaladLab/Json.Net.Unity3D/releases). It provides more complex changes to the library.

What?
---

For Unity projects you would need to use libraries from `lib/.net35-Unity` [folder](https://github.com/voucherifyio/voucherify-dotNET-sdk/tree/master/lib/net35-Unity) and add `link.xml` files that prevents types from stripping.

```xml
<linker>
  <assembly fullname="Voucherify.Client" preserve="all"/>
  <assembly fullname="Newtonsoft.JSON" preserve="all"/>
</linker>
```

This is a sample file that keeps all types from both libraries, but if you are really concerned about application's size you can prepare more specified version and include only types that you really use.

How?
---

```csharp
using System;
using System.Collections;
using UnityEngine;
using Voucherify.Client;

public class Main : MonoBehaviour {
	public string message = "Hello World";

	// Use this for initialization
	void Start () {
		var api = new Voucherify.Client.Api("<your-client-app-key>", "<your-client-app-token>", "<your-origin>").WithoutSSL();

		api.Vouchers.Validate(
			new Voucherify.DataModel.Queries.VoucherValidation() { Code = "1vHVLcZu" },
			(response) => {
				if (response.Exception != null)
				{
					message = response.Exception.ToString();
				} 
				else 
				{
					message = response.Result.ToString();
				}

				Canvas.ForceUpdateCanvases();
			});
	}

	void OnGUI() {
		GUILayout.Label (message);
	}
}
```