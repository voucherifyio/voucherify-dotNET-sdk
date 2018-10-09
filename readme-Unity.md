Voucherify for Unity
===

Installation
---

1. Use libraries directly from [here](https://github.com/voucherifyio/voucherify-dotNET-sdk/tree/master/lib/net35-Unity) 
2. Once libraries are added to your project, include link.xml file that prevents types from stripping.


```xml
<linker>
  <assembly fullname="Voucherify.Client" preserve="all"/>
  <assembly fullname="Newtonsoft.JSON" preserve="all"/>
</linker>
```

Why?
---

Because of many limitations of Unity (expecially those realted strictly to [iOS](https://developer.xamarin.com/guides/ios/advanced_topics/limitations/)) there was a need to preapre a dedicated solution to support the platform. 

The main dependency of Voucherify library is `Newtonsoft.Json` that provides data serialization to integrate with REST API based on json, but it does not work on iOS as it is so that it's required to use an adjusted version. We recommend you to use library prepared and tested by Voucherify Team: [Newtonsoft.Json by Voucherify](https://github.com/bandraszyk/Newtonsoft.Json). You can see there that we did only one [change](https://github.com/bandraszyk/Newtonsoft.Json/commit/2ce54acd150f676a9a930a9af7da68866cb4da6e) to the original repo.

The following library can be use as an alternative: [Json.Net.Unity3D](https://github.com/SaladLab/Json.Net.Unity3D/releases). It provides more complex changes to the library.

Example
---

```csharp
using System;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Main : MonoBehaviour
{
    public string message = "Hello World";

    public bool ServerCertificateManualVerificationCallback(System.Object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
    {
        // -- Hack for RSA encryption
        if (certificate.GetKeyAlgorithm() == "1.2.840.113549.1.1.1" && sslPolicyErrors == SslPolicyErrors.RemoteCertificateChainErrors)
        {
            chain.ChainPolicy.RevocationFlag = X509RevocationFlag.EntireChain;
            chain.ChainPolicy.RevocationMode = X509RevocationMode.Online;
            chain.ChainPolicy.UrlRetrievalTimeout = new TimeSpan(0, 1, 0);
            chain.ChainPolicy.VerificationFlags = X509VerificationFlags.AllFlags;

            for (int i = 0; i < chain.ChainStatus.Length; i++)
            {
                X509ChainStatus chainStatus = chain.ChainStatus[i];
            
                if (chainStatus.Status != X509ChainStatusFlags.OfflineRevocation && 
                    chainStatus.Status != X509ChainStatusFlags.RevocationStatusUnknown && 
                    chainStatus.Status != X509ChainStatusFlags.PartialChain)
                {
                    return false;
                }
            }

            return chain.Build((X509Certificate2)certificate);
        }

        return true;
    }

    // Use this for initialization
    void Start () {
        Voucherify.Client.Api api = new Voucherify.Client.Api("<your-api-id>", "<your-api-secret>", "*");

        ServicePointManager.ServerCertificateValidationCallback = ServerCertificateManualVerificationCallback;

        api.Validations.ValidateVoucher(
            new Voucherify.DataModel.Queries.VoucherValidation() { Code = "<code>" },
            (response) => {
                if (response.Exception != null)
                {
                    message = "Exception: " + response.Exception.ToString();
                }
                else
                {
                    message = "Voucher:" + response.Result.ToString();
                }

                Canvas.ForceUpdateCanvases();
            });
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnGUI()
    {
        GUILayout.Label(message);
    }
}
```
