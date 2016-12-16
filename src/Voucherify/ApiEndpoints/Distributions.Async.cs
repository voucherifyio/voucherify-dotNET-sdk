#if APIASYNC
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Voucherify.Core.Extensions;

namespace Voucherify.ApiEndpoints
{
    public class Distributions : EndpointBase
    {
        public Distributions(Api api) : base(api)
        {
        }

        public async Task Publish(DataModel.Queries.VoucherPublish query, DataModel.Contexts.VoucherPublish context)
        {
            UriBuilder uriBuilder = UriBuilderExtension.WithQuery(this.client.GetUriBuilder("/vouchers/publish"), query);
            await this.client.DoPostRequest<Core.DataModel.Empty, DataModel.Contexts.VoucherPublish>(uriBuilder.Uri, context);
        }
    }
}

#endif