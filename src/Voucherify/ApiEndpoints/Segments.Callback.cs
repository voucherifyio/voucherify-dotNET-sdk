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

        public void Get(string validationRuleId, Action<ApiResponse<DataModel.Segment>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/validation-rules/{0}", Uri.EscapeDataString(validationRuleId)));
            this.client.DoGetRequest(uriBuilder.Uri, callback);
        }

        public void Create(DataModel.Contexts.SegmentCreate voucher, Action<ApiResponse<DataModel.Segment>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder("/validation-rules/");
            this.client.DoPostRequest(uriBuilder.Uri, voucher, callback);
        }


        public void Delete(string validationRuleId, Action<ApiResponse> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/validation-rules/{0}", Uri.EscapeDataString(validationRuleId)));
            this.client.DoDeleteRequest(uriBuilder.Uri, callback);
        }
    }
}
#endif