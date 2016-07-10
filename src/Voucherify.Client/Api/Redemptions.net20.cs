using System;
using System.Collections.Generic;
using Voucherify.Client.Extensions;

namespace Voucherify.Client.Api
{
    public class Redemptions
    {
        private ApiClient client;

        public Redemptions(VoucherifyClient voucherify)
        {
            if (voucherify == null)
            {
                throw new ArgumentNullException("voucherify");
            }

            this.client = new ApiClient(voucherify);
        }

        public void ListRedemptions(DataModel.RedemptionsFilter filter, Action<ApiResponse<IList<DataModel.RedemptionDetails>>> callback)
        {
            UriBuilder uriBuilder = UriBuilderExtension.WithQuery(this.client.GetUriBuilder("/redemptions"), filter);
            this.client.DoGetRequest<IList<DataModel.RedemptionDetails>>(uriBuilder.Uri, callback);
        }

        public void RollbackRedemption(string redemptionId, DataModel.RedemptionRollbackQuery query, Action<ApiResponse<DataModel.VoucherRedemptionResult>> callback)
        {
            UriBuilder uriBuilder = UriBuilderExtension.WithQuery(this.client.GetUriBuilder(string.Format("/redemptions/{0}/rollback", redemptionId)), query);
            this.client.DoPostRequest<DataModel.VoucherRedemptionResult>(uriBuilder.Uri, callback);
        }
    }
}
