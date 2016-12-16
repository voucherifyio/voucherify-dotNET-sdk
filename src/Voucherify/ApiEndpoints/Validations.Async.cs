#if APIASYNC
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Voucherify.Core.Extensions;

namespace Voucherify.ApiEndpoints
{
    public class Validations : EndpointBase
    {
        public Validations(Api api) : base(api)
        {
        }

        public async Task<DataModel.Results.VoucherValidation> ValidateVoucher(string code, DataModel.Contexts.VoucherValidation context)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/vouchers/{0}/validate", Uri.EscapeDataString(code)));
            return await this.client.DoPostRequest< DataModel.Results.VoucherValidation, DataModel.Contexts.VoucherValidation>(uriBuilder.Uri, context);
        }
    }
}

#endif