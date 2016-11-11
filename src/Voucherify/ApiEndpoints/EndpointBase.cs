using System;
using System.Collections.Generic;
using Voucherify.Core.Communication;

namespace Voucherify.ApiEndpoints
{
    public abstract class EndpointBase
    {
        internal ApiClient client;

        public EndpointBase(Api api)
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
                    { Core.Constants.HttpHeaderAppId, api.AppId },
                    { Core.Constants.HttpHeaderAppToken, api.AppToken },
                    { Core.Constants.HttpHeaderChannel, Core.Constants.HttpHeaderChannelName }
                });
        }
    }
}
