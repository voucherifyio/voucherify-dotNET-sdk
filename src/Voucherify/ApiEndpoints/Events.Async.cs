#if VOUCHERIFYSERVER && APIASYNC
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Voucherify.Core.Extensions;

namespace Voucherify.ApiEndpoints
{
    public class Events : EndpointBase
    {
        public Events(Api api) : base(api)
        {
        }

        public async Task<DataModel.Event> Create(DataModel.Contexts.EventCreate eventObject)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder("/events/");
            return await this.client.DoPostRequest<DataModel.Event, DataModel.Contexts.EventCreate>(uriBuilder.Uri, eventObject).ConfigureAwait(false);
        }
    }
}
#endif