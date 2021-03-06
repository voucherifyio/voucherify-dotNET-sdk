﻿#if VOUCHERIFYSERVER && APIASYNC
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

        public async Task<DataModel.PublicationSingle> Publish(DataModel.Contexts.VoucherPublishSingle context)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder("/vouchers/publish");
            return await this.client.DoPostRequest<DataModel.PublicationSingle, DataModel.Contexts.VoucherPublishSingle>(uriBuilder.Uri, context).ConfigureAwait(false);
        }

        public async Task<DataModel.Publication> CreatePublication(DataModel.Contexts.VoucherPublish context)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder("/publications");
            return await this.client.DoPostRequest<DataModel.Publication, DataModel.Contexts.VoucherPublish>(uriBuilder.Uri, context).ConfigureAwait(false);
        }
    }
}

#endif