#if  VOUCHERIFYSERVER && APIASYNC
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
        
        public async Task<DataModel.Redemption> Get(string redemptionId)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/redemptions/{0}", UriBuilderExtension.EnsureEscapedDataString("redemptionId", redemptionId)));
            return await this.client.DoGetRequest<DataModel.Redemption>(uriBuilder.Uri).ConfigureAwait(false);
        }

        public async Task<DataModel.RedemptionList> List(DataModel.Queries.RedemptionsFilter filter)
        {
            UriBuilder uriBuilder = UriBuilderExtension.WithQuery(this.client.GetUriBuilder("/redemptions"), filter);
            return await this.client.DoGetRequest<DataModel.RedemptionList>(uriBuilder.Uri).ConfigureAwait(false);
        }

        public async Task<DataModel.Redemption> Redeem(string code, DataModel.Queries.RedemptionRedeem query, DataModel.Contexts.RedemptionRedeem context)
        {
            UriBuilder uriBuilder = UriBuilderExtension.WithQuery(this.client.GetUriBuilder(string.Format("/vouchers/{0}/redemption", UriBuilderExtension.EnsureEscapedDataString("code", code))), query);
            return await this.client.DoPostRequest<DataModel.Redemption, DataModel.Contexts.RedemptionRedeem>(uriBuilder.Uri, context).ConfigureAwait(false);
        }
        
        public async Task<DataModel.Redemption> RedeemVoucher(string code, DataModel.Queries.RedemptionRedeem query, DataModel.Contexts.RedemptionRedeem context)
        {
            UriBuilder uriBuilder = UriBuilderExtension.WithQuery(this.client.GetUriBuilder(string.Format("/vouchers/{0}/redemption", UriBuilderExtension.EnsureEscapedDataString("code", code))), query);
            return await this.client.DoPostRequest<DataModel.Redemption, DataModel.Contexts.RedemptionRedeem>(uriBuilder.Uri, context).ConfigureAwait(false);
        }

        public async Task<DataModel.Redemption> RedeemPromotion(string promotionId, DataModel.Contexts.RedemptionRedeem context)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/promotions/tiers/{0}/redemption", promotionId));
            return await this.client.DoPostRequest<DataModel.Redemption, DataModel.Contexts.RedemptionRedeem>(uriBuilder.Uri, context).ConfigureAwait(false);
        }
        
        public async Task<DataModel.RedemptionRollback> Rollback(string redemptionId, DataModel.Queries.RedemptionRollback query, DataModel.Contexts.RedemptionRollback context)
        {
            UriBuilder uriBuilder = UriBuilderExtension.WithQuery(this.client.GetUriBuilder(string.Format("/redemptions/{0}/rollback", UriBuilderExtension.EnsureEscapedDataString("redemptionId", redemptionId))), query);
            return await this.client.DoPostRequest<DataModel.RedemptionRollback, DataModel.Contexts.RedemptionRollback>(uriBuilder.Uri, context).ConfigureAwait(false);
        }

        public async Task<DataModel.VoucherRedemptionList> GetForVoucher(string code)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/vouchers/{0}/redemption", UriBuilderExtension.EnsureEscapedDataString("code", code)));
            return await this.client.DoGetRequest< DataModel.VoucherRedemptionList>(uriBuilder.Uri).ConfigureAwait(false);
        }
    }
}
#endif
