#if VOUCHERIFYCLIENT && !APIASYNC
using System;
using System.Collections.Generic;
using System.Text;
using Voucherify.Core.Communication;
using Voucherify.Core.Extensions;

namespace Voucherify.Client.ApiEndpoints
{
    public class Consents : EndpointBase
    {
        public Consents(Api api) : base(api)
        {
        }

        public void List(Action<ApiResponse<DataModel.ConsentAndGroupList>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder("/consents");
            this.client.DoGetRequest<DataModel.ConsentAndGroupList>(uriBuilder.Uri, callback);
        }
    }
}
#endif