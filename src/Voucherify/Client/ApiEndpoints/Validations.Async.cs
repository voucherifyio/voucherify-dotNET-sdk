#if APIASYNC
using System;
using System.Threading.Tasks;
using Voucherify.Core.Extensions;

namespace Voucherify.Client.ApiEndpoints
{
    public class Validations : EndpointBase
    {
        public Validations(Api api) : base(api)
        {
        }

        public async Task<DataModel.Results.VoucherValidation> ValidateVoucher(DataModel.Queries.VoucherValidation query)
        {
            UriBuilder uriBuilder = UriBuilderExtension.WithQuery(this.client.GetUriBuilder("/validate"), query);
            return await this.client.DoGetRequest<DataModel.Results.VoucherValidation>(uriBuilder.Uri);
        }
    }
}
#endif
