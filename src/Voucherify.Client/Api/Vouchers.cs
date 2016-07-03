using System;
using System.Collections.Generic;
using Voucherify.Client.Extensions;
using RSG;

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

        public IPromise<IList<DataModel.Voucher>> ListVouchers(DataModel.VouchersFilter filter)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder("/vouchers/").WithQuery(filter);
            return this.client.DoGetRequest<IList<DataModel.Voucher>>(uriBuilder.Uri);
        }

        public IPromise<DataModel.Voucher> Get(string code)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/vouchers/{0}", code));
            return this.client.DoGetRequest<DataModel.Voucher>(uriBuilder.Uri);
        }
        
        public IPromise<DataModel.Voucher> CreateVoucher(DataModel.Voucher voucher)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder("/vouchers/");
            return this.client.DoPostRequest<DataModel.Voucher, DataModel.Voucher>(uriBuilder.Uri, voucher);
        }

        public IPromise<DataModel.Voucher> CreateVoucherWithCode(string code, DataModel.Voucher voucher)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/vouchers/{0}", code));
            return this.client.DoPostRequest<DataModel.Voucher, DataModel.Voucher>(uriBuilder.Uri, voucher);
        }

        public IPromise DisableVoucher(string code)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/vouchers/{0}/disable", code));
            return this.client.DoPostRequest(uriBuilder.Uri);
        } 

        public IPromise EnableVoucher(string code)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/vouchers/{0}/enable", code));
            return this.client.DoPostRequest(uriBuilder.Uri);
        }

        public IPromise<DataModel.VoucherRedemptionResult> Redeem(string code, DataModel.VoucherRedemptionQuery query)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/vouchers/{0}/redemption", code)).WithQuery(query);
            return this.client.DoPostRequest<DataModel.VoucherRedemptionResult>(uriBuilder.Uri);
        }

        public IPromise<DataModel.VoucherRedemptionResult> Redeem(string code, DataModel.VoucherRedemptionContext context)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/vouchers/{0}/redemption", code));
            return this.client.DoPostRequest<DataModel.VoucherRedemptionResult, DataModel.VoucherRedemptionContext>(new Uri(string.Format("/vouchers/{0}/redemption", code)), context);
        }

        public IPromise<DataModel.VoucherRedemption> Redemption(string code)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/vouchers/{0}/redemption", code));
            return this.client.DoGetRequest<DataModel.VoucherRedemption>(uriBuilder.Uri);
        }
    }
}
