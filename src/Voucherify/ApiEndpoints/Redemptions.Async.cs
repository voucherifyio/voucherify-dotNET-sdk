#if APIASYNC
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Voucherify.Core.Extensions;

namespace Voucherify.ApiEndpoints
{
    public class Redemptions : EndpointBase
    {
        public Redemptions(Api api) : base(api)
        {
        }

        public async Task<DataModel.RedemptionList> List(DataModel.Queries.RedemptionsFilter filter)
        {
            UriBuilder uriBuilder = UriBuilderExtension.WithQuery(this.client.GetUriBuilder("/redemptions"), filter);
            return await this.client.DoGetRequest<DataModel.RedemptionList>(uriBuilder.Uri).ConfigureAwait(false);
        }

        public async Task<DataModel.Results.RedemptionRedeem> Redeem(string code, DataModel.Queries.RedemptionRedeem query, DataModel.Contexts.RedemptionRedeem context)
        {
            UriBuilder uriBuilder = UriBuilderExtension.WithQuery(this.client.GetUriBuilder(string.Format("/vouchers/{0}/redemption", Uri.EscapeDataString(code))), query);
            return await this.client.DoPostRequest<DataModel.Results.RedemptionRedeem, DataModel.Contexts.RedemptionRedeem>(uriBuilder.Uri, context).ConfigureAwait(false);
        }

        public async Task<DataModel.Results.RedemptionRollback> Rollback(string redemptionId, DataModel.Queries.RedemptionRollback query, DataModel.Contexts.RedemptionRollback context)
        {
            UriBuilder uriBuilder = UriBuilderExtension.WithQuery(this.client.GetUriBuilder(string.Format("/redemptions/{0}/rollback", Uri.EscapeDataString(redemptionId))), query);
            return await this.client.DoPostRequest<DataModel.Results.RedemptionRollback, DataModel.Contexts.RedemptionRollback>(uriBuilder.Uri, context).ConfigureAwait(false);
        }

        public async Task<DataModel.VoucherRedemption> GetForVoucher(string code)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/vouchers/{0}/redemption", Uri.EscapeDataString(code)));
            return await this.client.DoGetRequest< DataModel.VoucherRedemption>(uriBuilder.Uri).ConfigureAwait(false);
        }
    }
}
#endif
