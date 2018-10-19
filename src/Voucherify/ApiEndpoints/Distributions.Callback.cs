#if VOUCHERIFYSERVER && !APIASYNC
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

        public void Publish(DataModel.Contexts.VoucherPublishSingle context, Action<ApiResponse<DataModel.PublicationSingle>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder("/vouchers/publish");
            this.client.DoPostRequest(uriBuilder.Uri, context, callback);
        }

        public void CreatePublication(DataModel.Contexts.VoucherPublish context, Action<ApiResponse<DataModel.Publication>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder("/publications");
            this.client.DoPostRequest(uriBuilder.Uri, context, callback);
        }
    }
}

#endif