#if !APIASYNC
using System;
using Voucherify.Core.Communication;
using Voucherify.Core.Extensions;

namespace Voucherify.Client.ApiEndpoints
{
    public class Validations : EndpointBase
    {
        public Validations(Api api) : base(api)
        {
        }

        public void ValidateVoucher(DataModel.Queries.VoucherValidation query, Action<ApiResponse<DataModel.Results.VoucherValidation>> callback)
        {
            UriBuilder uriBuilder = UriBuilderExtension.WithQuery(this.client.GetUriBuilder("/validate"), query);
            this.client.DoGetRequest(uriBuilder.Uri, callback);
        }
    }
}
#endif