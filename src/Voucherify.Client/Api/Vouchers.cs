using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Voucherify.Client.Extensions;

namespace Voucherify.Client.Api
{
    public class Vouchers
    {
        private ApiClient client;

        public Vouchers(VoucherifyClient client)
        {
            if (client == null)
            {
                throw new ArgumentNullException("client");
            }

            this.client = new ApiClient(client);
        }

        public async Task<IList<DataModel.Voucher>> ListVouchers(DataModel.VouchersFilter filter)
        {
            UriBuilder uriBuilder = new UriBuilder("/vouchers/").WithQuery(filter);
            return await this.client.DoGetRequest<IList<DataModel.Voucher>>(uriBuilder.Uri);
        }

        public async Task<DataModel.Voucher> Get(String code)
        {
            UriBuilder uriBuilder = new UriBuilder(string.Format("/vouchers/{0}", code));
            return await this.client.DoGetRequest<DataModel.Voucher>(uriBuilder.Uri);
        }
        
        public async Task<DataModel.Voucher> CreateVoucher(DataModel.Voucher voucher)
        {
            UriBuilder uriBuilder = new UriBuilder("/vouchers/");
            return await this.client.DoPostRequest<DataModel.Voucher, DataModel.Voucher>(uriBuilder.Uri, voucher);
        }

        public async Task<DataModel.Voucher> CreateVoucherWithCode(string code, DataModel.Voucher voucher)
        {
            UriBuilder uriBuilder = new UriBuilder(string.Format("/vouchers/{0}", code));
            return await this.client.DoPostRequest<DataModel.Voucher, DataModel.Voucher>(uriBuilder.Uri, voucher);
        }

        public async Task<dynamic> DisableVoucher(string code)
        {
            UriBuilder uriBuilder = new UriBuilder(string.Format("/vouchers/{0}/disable", code));
            return await this.client.DoPostRequest<dynamic>(uriBuilder.Uri);
        } 

        public async Task<dynamic> EnableVoucher(string code)
        {
            UriBuilder uriBuilder = new UriBuilder(string.Format("/vouchers/{0}/enable", code));
            return await this.client.DoPostRequest<dynamic>(uriBuilder.Uri);
        }

        public async Task<DataModel.VoucherRedemptionResult> Redeem(string code, DataModel.VoucherRedemptionQuery query)
        {
            UriBuilder uriBuilder = new UriBuilder(string.Format("/vouchers/{0}/redemption", code)).WithQuery(query);
            return await this.client.DoPostRequest<DataModel.VoucherRedemptionResult>(uriBuilder.Uri);
        }

        public async Task<DataModel.VoucherRedemptionResult> Redeem(string code, DataModel.VoucherRedemptionContext context)
        {
            UriBuilder uriBuilder = new UriBuilder(string.Format("/vouchers/{0}/redemption", code));
            return await this.client.DoPostRequest<DataModel.VoucherRedemptionResult, DataModel.VoucherRedemptionContext>(new Uri(string.Format("/vouchers/{0}/redemption", code)), context);
        }

        public async Task<DataModel.VoucherRedemption> Redemption(string code)
        {
            UriBuilder uriBuilder = new UriBuilder(string.Format("/vouchers/{0}/redemption", code));
            return await this.client.DoGetRequest<DataModel.VoucherRedemption>(uriBuilder.Uri);
        }

        public async Task<IList<DataModel.VoucherRedemption>> ListRedemptions(DataModel.RedemptionsFilter filter)
        {
            UriBuilder uriBuilder = new UriBuilder("/redemptions").WithQuery(filter);
            return await this.client.DoGetRequest<IList<DataModel.VoucherRedemption>>(uriBuilder.Uri);
        }

        public async Task<DataModel.VoucherRedemptionResult> RollbackRedemption(string redemptionId, DataModel.RedemptionRollbackQuery query)
        {
            UriBuilder uriBuilder = new UriBuilder(string.Format("/vouchers/{0}/roolback", redemptionId)).WithQuery(query);
            return await this.client.DoPostRequest<DataModel.VoucherRedemptionResult>(uriBuilder.Uri);
        }
    }
}
