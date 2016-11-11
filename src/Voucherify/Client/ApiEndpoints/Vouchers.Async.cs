#if APIASYNC
using System;
using System.Threading.Tasks;
using Voucherify.Core.Extensions;

namespace Voucherify.Client.ApiEndpoints
{
    public class Vouchers : EndpointBase
    {
        public Vouchers(Api api) : base(api)
        {
        }

        public async Task<DataModel.Results.VoucherValidationResult> Validate(DataModel.Queries.VoucherValidationQuery query)
        {
            UriBuilder uriBuilder = UriBuilderExtension.WithQuery(this.client.GetUriBuilder("/validate"), query);
            return await this.client.DoGetRequest<DataModel.Results.VoucherValidationResult>(uriBuilder.Uri);
        }
    }
}
#endif
