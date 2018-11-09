#if VOUCHERIFYCLIENT && !APIASYNC
using System;
using System.Collections.Generic;
using System.Text;
using Voucherify.Core.Communication;
using Voucherify.Core.Extensions;

namespace Voucherify.Client.ApiEndpoints
{
    public class Events : EndpointBase
    {
        public Events(Api api) : base(api)
        {
        }

        public void Create(DataModel.Contexts.EventCreate eventObject, Action<ApiResponse<DataModel.Event>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder("/events/");
            this.client.DoPostRequest(uriBuilder.Uri, eventObject, callback);
        }
    }
}
#endif