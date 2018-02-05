#if !APIASYNC
using System;
using System.Collections.Generic;
using Voucherify.Core.Communication;
using Voucherify.Core.Extensions;

namespace Voucherify.ApiEndpoints
{
    public class Segments : EndpointBase
    {
        public Segments(Api api) : base(api)
        {
        }

        public void Get(string segmentId, Action<ApiResponse<DataModel.Segment>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/segments/{0}", Uri.EscapeDataString(segmentId)));
            this.client.DoGetRequest(uriBuilder.Uri, callback);
        }

        public void Create(DataModel.Contexts.SegmentCreate voucher, Action<ApiResponse<DataModel.Segment>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder("/segments/");
            this.client.DoPostRequest(uriBuilder.Uri, voucher, callback);
        }


        public void Delete(string segmentId, Action<ApiResponse> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/segments/{0}", Uri.EscapeDataString(segmentId)));
            this.client.DoDeleteRequest(uriBuilder.Uri, callback);
        }
    }
}
#endif