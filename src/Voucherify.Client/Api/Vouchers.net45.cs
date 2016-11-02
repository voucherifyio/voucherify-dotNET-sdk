using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Voucherify.Client.Extensions;

namespace Voucherify.Client.Api
{
    public class Vouchers
    {
        private ApiClient client;

        public Vouchers(VoucherifyClient voucherify)
        {
            if (voucherify == null)
            {
                throw new ArgumentNullException("voucherify");
            }

            this.client = new ApiClient(voucherify);
        }

        public async Task<IList<DataModel.Voucher>> ListVouchers(DataModel.VouchersFilter filter)
        {
            UriBuilder uriBuilder = UriBuilderExtension.WithQuery(this.client.GetUriBuilder("/vouchers/"), filter);
            return await this.client.DoGetRequest<IList<DataModel.Voucher>>(uriBuilder.Uri);
        }

        public async Task<DataModel.Voucher> Get(string code)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/vouchers/{0}", code));
            return await this.client.DoGetRequest<DataModel.Voucher>(uriBuilder.Uri);
        }

        public async Task<DataModel.Voucher> CreateVoucher(DataModel.Voucher voucher)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder("/vouchers/");
            return await this.client.DoPostRequest<DataModel.Voucher, DataModel.Voucher>(uriBuilder.Uri, voucher);
        }

        public async Task<DataModel.Voucher> CreateVoucherWithCode(string code, DataModel.Voucher voucher)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/vouchers/{0}", code));
            return await this.client.DoPostRequest<DataModel.Voucher, DataModel.Voucher>(uriBuilder.Uri, voucher);
        }

        public async Task<DataModel.Voucher> UpdateVoucher(string code, DataModel.VoucherUpdate voucher)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/vouchers/{0}", code));
            return await this.client.DoPutRequest<DataModel.Voucher, DataModel.VoucherUpdate>(uriBuilder.Uri, voucher);
        }

        public async Task DisableVoucher(string code)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/vouchers/{0}/disable", code));
            await this.client.DoPostRequest(uriBuilder.Uri);
        }

        public async Task EnableVoucher(string code)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/vouchers/{0}/enable", code));
            await this.client.DoPostRequest(uriBuilder.Uri);
        }

        public async Task<DataModel.VoucherRedemptionResult> Redeem(string code, DataModel.VoucherRedemptionQuery query)
        {
            UriBuilder uriBuilder = UriBuilderExtension.WithQuery(this.client.GetUriBuilder(string.Format("/vouchers/{0}/redemption", code)), query);
            return await this.client.DoPostRequest<DataModel.VoucherRedemptionResult>(uriBuilder.Uri);
        }

        public async Task<DataModel.VoucherRedemptionResult> Redeem(string code, DataModel.VoucherRedemptionContext context)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/vouchers/{0}/redemption", code));
            return await this.client.DoPostRequest<DataModel.VoucherRedemptionResult, DataModel.VoucherRedemptionContext>(uriBuilder.Uri, context);
        }

        public async Task<DataModel.VoucherRedemption> Redemption(string code)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/vouchers/{0}/redemption", code));
            return await this.client.DoGetRequest<DataModel.VoucherRedemption>(uriBuilder.Uri);
        }

        public async Task<DataModel.VoucherValidationResult> Validate(string code, DataModel.VoucherValidationContext context)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/vouchers/{0}/validate", code));
            return await this.client.DoPostRequest<DataModel.VoucherValidationResult, DataModel.VoucherValidationContext>(uriBuilder.Uri, context);
        }
    }
}
