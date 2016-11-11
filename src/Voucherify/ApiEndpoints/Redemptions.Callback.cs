#if !APIASYNC
using System;
using System.Collections.Generic;
using Voucherify.Core.Communication;
using Voucherify.Core.Extensions;

namespace Voucherify.ApiEndpoints
{
    public class Redemptions : EndpointBase
    {
        public Redemptions(Api api) : base(api)
        {
        }

        public void List(DataModel.Contexts.RedemptionsFilterContext filter, Action<ApiResponse<IList<DataModel.RedemptionEntry>>> callback)
        {
            UriBuilder uriBuilder = UriBuilderExtension.WithQuery(this.client.GetUriBuilder("/redemptions"), filter);
            this.client.DoGetRequest(uriBuilder.Uri, callback);
        }

        public void Redeem(string code, DataModel.Contexts.RedemptionContext context, Action<ApiResponse<DataModel.Results.RedemptionResult>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/vouchers/{0}/redemption", Uri.EscapeDataString(code)));
            this.client.DoPostRequest(uriBuilder.Uri, context, callback);
        }

        public void Redeem(string code, DataModel.Queries.RedemptionQuery query, Action<ApiResponse<DataModel.Results.RedemptionResult>> callback)
        {
            UriBuilder uriBuilder = UriBuilderExtension.WithQuery(this.client.GetUriBuilder(string.Format("/vouchers/{0}/redemption", Uri.EscapeDataString(code))), query);
            this.client.DoPostRequest(uriBuilder.Uri, callback);
        }

        public void Rollback(string redemptionId, DataModel.Contexts.RedemptionRollbackContext context, Action<ApiResponse<DataModel.Results.RedemptionRollbackResult>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/redemptions/{0}/rollback", Uri.EscapeDataString(redemptionId)));
            this.client.DoPostRequest(uriBuilder.Uri, context, callback);
        }

        public void Rollback(string redemptionId, DataModel.Queries.RedemptionRollbackQuery query, Action<ApiResponse<DataModel.Results.RedemptionRollbackResult>> callback)
        {
            UriBuilder uriBuilder = UriBuilderExtension.WithQuery(this.client.GetUriBuilder(string.Format("/redemptions/{0}/rollback", Uri.EscapeDataString(redemptionId))), query);
            this.client.DoPostRequest(uriBuilder.Uri, callback);
        }

        public void GetForVoucher(string code, Action<ApiResponse<DataModel.VoucherRedemption>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/vouchers/{0}/redemption", Uri.EscapeDataString(code)));
            this.client.DoGetRequest(uriBuilder.Uri, callback);
        }
    }
}
#endif
