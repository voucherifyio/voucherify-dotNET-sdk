#if VOUCHERIFYSERVER && APIASYNC
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

        public async Task<DataModel.Validation> ValidateVoucher(string code, DataModel.Contexts.Validation context)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/vouchers/{0}/validate", Uri.EscapeDataString(code)));
            return await this.client.DoPostRequest<DataModel.Validation, DataModel.Contexts.Validation>(uriBuilder.Uri, context).ConfigureAwait(false);
        }

        public async Task<DataModel.Validation> ValidatePromotion(DataModel.Contexts.Validation context)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder("/promotions/validation");
            return await this.client.DoPostRequest<DataModel.Validation, DataModel.Contexts.Validation>(uriBuilder.Uri, context).ConfigureAwait(false);
        }

        public async Task<DataModel.Validation> Validate(string code, DataModel.Contexts.Validation context)
        {
            UriBuilder uriBuilder = null;

            if (string.IsNullOrEmpty(code))
            {
                uriBuilder = this.client.GetUriBuilder("/promotions/validation");
            }
            else
            {
                uriBuilder = this.client.GetUriBuilder(string.Format("/vouchers/{0}/validate", Uri.EscapeDataString(code)));
            }

            return await this.client.DoPostRequest<DataModel.Validation, DataModel.Contexts.Validation>(uriBuilder.Uri, context).ConfigureAwait(false);
        }
    }
}

#endif