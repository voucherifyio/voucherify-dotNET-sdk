using System;
using System.Collections.Generic;
using Voucherify.Core.Communication;

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

            this.client = new ApiClient(
                api.Secure,
                api.Endpoint,
                new Dictionary<string, string>()
                {
                    { Core.Constants.HttpHeaderClintAppId, api.AppId },
                    { Core.Constants.HttpHeaderClientAppToken, api.AppToken },
                    { Core.Constants.HttpHeaderClientOrigin, api.Origin }
                });
        }
    }
}
