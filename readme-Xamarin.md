Voucherify for Xamarin
===

To use Voucherify in you Xamarin project please install Server or Client version from you Package Manager console or use the assembies from `lib/portable-net45+netcore45+wpa81+wp8` folder.

Server
---

```
Instal-Package Voucherify
```

Client
---

```
Instal-Package Voucherify.Client
```

Other Dependencies
---

The initial dependencies to `Microsoft.Net.Http`, `Microsoft.Bcl` and `Microsoft.Bcl.Build` have been removed from the original package to avoid conflicts in environments where they cannot be installed (like Xamarin that supports those functionalities). In case your environment does not support `Microsoft.Net.Http.HttpClient` or `async/await` please add mentioned previously packages manually.

In case you do not need to install any additional libraries make sure that you have added reference to `Microsot.System.Net` assembly.

Sample App
---

![Xamarin Example](/images/Xamarin-Sample.png )