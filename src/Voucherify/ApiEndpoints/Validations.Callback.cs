#if !APIASYNC
using System;
using System.Collections.Generic;
using System.Text;
using Voucherify.Core.Communication;
using Voucherify.Core.Extensions;
using DataModel = Voucherify.DataModel;

namespace Voucherify.ApiEndpoints
{
    public class Validations : EndpointBase
    {
        public Validations(Api api) : base(api)
        {
        }

        public void ValidateVoucher(string code, DataModel.Contexts.Validation context, Action<ApiResponse<DataModel.Validation>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/vouchers/{0}/validate", Uri.EscapeDataString(code)));
            this.client.DoPostRequest(uriBuilder.Uri, context, callback);
        }

        public void ValidatePromotion(DataModel.Contexts.Validation context, Action<ApiResponse<DataModel.Validation>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder("/promotions/validation");
            this.client.DoPostRequest(uriBuilder.Uri, context, callback);
        }

        public void Validate(string code, DataModel.Contexts.Validation context, Action<ApiResponse<DataModel.Validation>> callback)
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
             
            this.client.DoPostRequest(uriBuilder.Uri, context, callback);
        }
    }
}

#endif