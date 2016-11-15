#if !APIASYNC
using System;
using Voucherify.Core.Communication;
using Voucherify.Core.Extensions;

namespace Voucherify.Client.ApiEndpoints
{
    public class Vouchers : EndpointBase
    {
        public Vouchers(Api api) : base(api)
        {
        }

        public void Validate(DataModel.Queries.VoucherValidation query, Action<ApiResponse<DataModel.Results.VoucherValidation>> callback)
        {
            UriBuilder uriBuilder = UriBuilderExtension.WithQuery(this.client.GetUriBuilder("/validate"), query);
            this.client.DoGetRequest(uriBuilder.Uri, callback);
        }
    }
}
#endif