#if VOUCHERIFYCLIENT && APIASYNC
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

        public async Task<DataModel.ValidationVoucher> ValidateVoucher(DataModel.Queries.VoucherValidation query)
        {
            UriBuilder uriBuilder = UriBuilderExtension.WithQuery(this.client.GetUriBuilder("/validate"), query);
            return await this.client.DoGetRequest<DataModel.ValidationVoucher>(uriBuilder.Uri).ConfigureAwait(false);
        }
    }
}
#endif
