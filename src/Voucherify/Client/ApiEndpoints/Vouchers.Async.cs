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

        [Obsolete(message: "This method is obsolete. Use Api.Validations.ValidateVoucher() instead.", error: false)]
        public async Task<DataModel.Results.VoucherValidation> Validate(DataModel.Queries.VoucherValidation query)
        {
            UriBuilder uriBuilder = UriBuilderExtension.WithQuery(this.client.GetUriBuilder("/validate"), query);
            return await this.client.DoGetRequest<DataModel.Results.VoucherValidation>(uriBuilder.Uri).ConfigureAwait(false);
        }
    }
}
#endif
