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

        public void List(DataModel.Queries.RedemptionsFilter filter, Action<ApiResponse<DataModel.RedemptionList>> callback)
        {
            UriBuilder uriBuilder = UriBuilderExtension.WithQuery(this.client.GetUriBuilder("/redemptions"), filter);
            this.client.DoGetRequest(uriBuilder.Uri, callback);
        }

        public void Redeem(string code, DataModel.Queries.RedemptionRedeem query, DataModel.Contexts.RedemptionRedeem context, Action<ApiResponse<DataModel.Results.RedemptionRedeem>> callback)
        {
            UriBuilder uriBuilder = UriBuilderExtension.WithQuery(this.client.GetUriBuilder(string.Format("/vouchers/{0}/redemption", Uri.EscapeDataString(code))), query);
            this.client.DoPostRequest(uriBuilder.Uri, context, callback);
        }

        public void Rollback(string redemptionId, DataModel.Queries.RedemptionRollback query, DataModel.Contexts.RedemptionRollback context, Action<ApiResponse<DataModel.Results.RedemptionRollback>> callback)
        {
            UriBuilder uriBuilder = UriBuilderExtension.WithQuery(this.client.GetUriBuilder(string.Format("/redemptions/{0}/rollback", Uri.EscapeDataString(redemptionId))), query);
            this.client.DoPostRequest(uriBuilder.Uri, context, callback);
        }

        public void GetForVoucher(string code, Action<ApiResponse<DataModel.VoucherRedemption>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/vouchers/{0}/redemption", Uri.EscapeDataString(code)));
            this.client.DoGetRequest(uriBuilder.Uri, callback);
        }
    }
}
#endif
