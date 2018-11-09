#if VOUCHERIFYCLIENT
using System;
using System.Collections.Generic;
using Voucherify.Core.Attributes;
using Voucherify.Core.Communication;
using Voucherify.Core.Extensions;

namespace Voucherify.Client.ApiEndpoints
{
    public abstract class EndpointBase
    {
        internal ApiClient client;

        public EndpointBase(Client.Api api)
        {
            if (api == null)
            {
                throw new ArgumentNullException("api");
            }

            Dictionary<string, string> headers = new Dictionary<string, string>() {
                { Core.Constants.HttpHeaderClintAppId, api.AppId },
                    { Core.Constants.HttpHeaderClientAppToken, api.AppToken },
                    { Core.Constants.HttpHeaderClientOrigin, api.Origin }
            };

            if (api.Version != Core.ApiVersion.Default)
            {
                headers.Add(Core.Constants.HttpHeaderApiVersion, JsonEnumValueAttributeExtension.GetValue(api.Version));
            }

            this.client = new ApiClient(api.Secure, api.Endpoint, headers, null);
        }
    }
}
#endif