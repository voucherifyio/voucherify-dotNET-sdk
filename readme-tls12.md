Voucherify TLS 1.2
===

As part of our ongoing efforts to maintain the continued security of our platform, we will be deprecating known weak Transport Layer Security (TLS) ciphers in both TLS 1.0 and 1.1, in accordance with recommendations made by the PCI Security Standards Council. Current version of Voucherify .NET SDK forces to use TLS 1.2, but for some framework versions it is required to do additonal steps to make it work.

.NET Framework 2.0
---

Requirements for support TLS 1.2 are described here: [Support for TLS System Default Versions included in the .NET Framework 2.0 SP2](https://support.microsoft.com/en-us/help/3154517/support-for-tls-system-default-versions-included-in-the-net-framework)

.NET Framework 2.0
---

Requirements for support TLS 1.2 are described here: [Support for TLS System Default Versions included in the .NET Framework 3.5.1](https://support.microsoft.com/en-us/help/3154518/support-for-tls-system-default-versions-included-in-the-net-framework)

Unity
---

We decided to drop Unity support for .NET Framework 3.5 and to support only newest version based on .NET Framework 4.0 as it provides built-in support for TLS 1.2.

