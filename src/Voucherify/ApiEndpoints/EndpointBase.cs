using System;
using System.Collections.Generic;
using Voucherify.Core.Communication;
using Voucherify.Core.Extensions;

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

            Dictionary<string, string> headers = new Dictionary<string, string>() {
                { Core.Constants.HttpHeaderAppId, api.AppId },
                { Core.Constants.HttpHeaderAppToken, api.AppToken },
                { Core.Constants.HttpHeaderChannel, Core.Constants.HttpHeaderChannelName }
            };

            if (api.Version != Core.ApiVersion.Default)
            {
                headers.Add(Core.Constants.HttpHeaderApiVersion, JsonEnumValueAttributeExtension.GetValue(api.Version));
            }


            this.client = new ApiClient(
                api.Secure, 
                api.Endpoint, 
                headers,
                new List<Newtonsoft.Json.JsonConverter>()
                {
                    new Core.Serialization.ObjectListFromArrayConverter<DataModel.Voucher, DataModel.VoucherList>(api.Version, Core.ApiVersion.v2017_04_05),
                    new Core.Serialization.ObjectListFromArrayConverter<DataModel.Campaign, DataModel.CampaignList>(api.Version, Core.ApiVersion.v2017_04_05)
                });
        }
    }
}
