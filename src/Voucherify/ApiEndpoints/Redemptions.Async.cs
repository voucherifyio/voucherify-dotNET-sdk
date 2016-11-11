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

        public async Task<IList<DataModel.RedemptionEntry>> List(DataModel.Contexts.RedemptionsFilterContext filter)
        {
            UriBuilder uriBuilder = UriBuilderExtension.WithQuery(this.client.GetUriBuilder("/redemptions"), filter);
            return await this.client.DoGetRequest<IList<DataModel.RedemptionEntry>>(uriBuilder.Uri);
        }

        public async Task<DataModel.Results.RedemptionResult> Redeem(string code, DataModel.Contexts.RedemptionContext context)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/vouchers/{0}/redemption", Uri.EscapeDataString(code)));
            return await this.client.DoPostRequest<DataModel.Results.RedemptionResult, DataModel.Contexts.RedemptionContext>(uriBuilder.Uri, context);
        }

        public async Task<DataModel.Results.RedemptionResult> Redeem(string code, DataModel.Queries.RedemptionQuery query)
        {
            UriBuilder uriBuilder = UriBuilderExtension.WithQuery(this.client.GetUriBuilder(string.Format("/vouchers/{0}/redemption", Uri.EscapeDataString(code))), query);
            return await this.client.DoPostRequest< DataModel.Results.RedemptionResult>(uriBuilder.Uri);
        }

        public async Task<DataModel.Results.RedemptionRollbackResult> Rollback(string redemptionId, DataModel.Contexts.RedemptionRollbackContext context)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/redemptions/{0}/rollback", Uri.EscapeDataString(redemptionId)));
            return await this.client.DoPostRequest<DataModel.Results.RedemptionRollbackResult, DataModel.Contexts.RedemptionRollbackContext>(uriBuilder.Uri, context);
        }

        public async Task<DataModel.Results.RedemptionRollbackResult> Rollback(string redemptionId, DataModel.Queries.RedemptionRollbackQuery query)
        {
            UriBuilder uriBuilder = UriBuilderExtension.WithQuery(this.client.GetUriBuilder(string.Format("/redemptions/{0}/rollback", Uri.EscapeDataString(redemptionId))), query);
            return await this.client.DoPostRequest<DataModel.Results.RedemptionRollbackResult>(uriBuilder.Uri);
        }

        public async Task<DataModel.VoucherRedemption> GetForVoucher(string code)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/vouchers/{0}/redemption", Uri.EscapeDataString(code)));
            return await this.client.DoGetRequest< DataModel.VoucherRedemption>(uriBuilder.Uri);
        }
    }
}
#endif
