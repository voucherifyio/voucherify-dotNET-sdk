#if !APIASYNC
using System;
using System.Collections.Generic;
using System.Text;
using Voucherify.Core.Communication;
using Voucherify.Core.Extensions;
using DataModel = Voucherify.DataModel;

namespace Voucherify.ApiEndpoints
{
    public class Distributions : EndpointBase
    {
        public Distributions(Api api) : base(api)
        {
        }

        public void Publish(DataModel.Queries.VoucherPublish query, DataModel.Contexts.VoucherPublish context, Action<ApiResponse<Core.DataModel.Empty>> callback)
        {
            UriBuilder uriBuilder = UriBuilderExtension.WithQuery(this.client.GetUriBuilder("/vouchers/publish"), query);
            this.client.DoPostRequest(uriBuilder.Uri, context, callback);
        }
    }
}

#endif