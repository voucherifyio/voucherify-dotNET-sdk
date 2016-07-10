using System;
using System.Collections.Generic;
using Voucherify.Client.Extensions;
using RSG;

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

        public IPromise<IList<DataModel.RedemptionDetails>> ListRedemptions(DataModel.RedemptionsFilter filter)
        {
            UriBuilder uriBuilder = UriBuilderExtension.WithQuery(this.client.GetUriBuilder("/redemptions"), filter);
            return this.client.DoGetRequest<IList<DataModel.RedemptionDetails>>(uriBuilder.Uri);
        }

        public IPromise<DataModel.VoucherRedemptionResult> RollbackRedemption(string redemptionId, DataModel.RedemptionRollbackQuery query)
        {
            UriBuilder uriBuilder = UriBuilderExtension.WithQuery(this.client.GetUriBuilder(string.Format("/redemptions/{0}/rollback", redemptionId)), query);
            return this.client.DoPostRequest<DataModel.VoucherRedemptionResult>(uriBuilder.Uri);
        }
    }
}