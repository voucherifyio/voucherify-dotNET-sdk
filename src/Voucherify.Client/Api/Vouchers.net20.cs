using System;
using System.Collections.Generic;
using System.Text;
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

        public void ListVouchers(DataModel.VouchersFilter filter, Action<ApiResponse<IList<DataModel.Voucher>>> callback)
        {
            UriBuilder uriBuilder = UriBuilderExtension.WithQuery(this.client.GetUriBuilder("/vouchers/"), filter);
            this.client.DoGetRequest<IList<DataModel.Voucher>>(uriBuilder.Uri, callback);
        }

        public void Get(string code, Action<ApiResponse<DataModel.Voucher>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/vouchers/{0}", code));
            this.client.DoGetRequest<DataModel.Voucher>(uriBuilder.Uri, callback);
        }

        public void CreateVoucher(DataModel.Voucher voucher, Action<ApiResponse<DataModel.Voucher>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder("/vouchers/");
            this.client.DoPostRequest<DataModel.Voucher, DataModel.Voucher>(uriBuilder.Uri, voucher, callback);
        }

        public void CreateVoucherWithCode(string code, DataModel.Voucher voucher, Action<ApiResponse<DataModel.Voucher>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/vouchers/{0}", code));
            this.client.DoPostRequest<DataModel.Voucher, DataModel.Voucher>(uriBuilder.Uri, voucher, callback);
        }

        public void UpdateVoucher(string code, DataModel.VoucherUpdate voucher, Action<ApiResponse<DataModel.Voucher>> callback)
        {

            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/vouchers/{0}", code));
            this.client.DoPutRequest<DataModel.Voucher, DataModel.VoucherUpdate>(uriBuilder.Uri, voucher, callback);
        }

        public void DisableVoucher(string code, Action<ApiResponse> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/vouchers/{0}/disable", code));
            this.client.DoPostRequest(uriBuilder.Uri, callback);
        }

        public void EnableVoucher(string code, Action<ApiResponse> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/vouchers/{0}/enable", code));
            this.client.DoPostRequest(uriBuilder.Uri, callback);
        }

        public void  Redeem(string code, DataModel.VoucherRedemptionQuery query, Action<ApiResponse<DataModel.VoucherRedemptionResult>> callback)
        {
            UriBuilder uriBuilder = UriBuilderExtension.WithQuery(this.client.GetUriBuilder(string.Format("/vouchers/{0}/redemption", code)), query);
            this.client.DoPostRequest<DataModel.VoucherRedemptionResult>(uriBuilder.Uri, callback);
        }

        public void Redeem(string code, DataModel.VoucherRedemptionContext context, Action<ApiResponse<DataModel.VoucherRedemptionResult>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/vouchers/{0}/redemption", code));
            this.client.DoPostRequest<DataModel.VoucherRedemptionResult, DataModel.VoucherRedemptionContext>(new Uri(string.Format("/vouchers/{0}/redemption", code)), context, callback);
        }

        public void Redemption(string code, Action<ApiResponse<DataModel.VoucherRedemption>> callback)
        {
            UriBuilder uriBuilder = this.client.GetUriBuilder(string.Format("/vouchers/{0}/redemption", code));
            this.client.DoGetRequest<DataModel.VoucherRedemption>(uriBuilder.Uri, callback);
        }
    }
}
